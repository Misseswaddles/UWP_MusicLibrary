using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Storage;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace UWP_MusicApp_Final
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class PlayList : Page
    {
        private const string V = ",";
        List<Songs> Songslist = new List<Songs>();
        string PlayListName;

        public PlayList()
        {
            this.InitializeComponent();

        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            PlayListName = e.Parameter as string;
            //System.Diagnostics.Debug.Print("FileName : {0}  \n", PlayListName);

            getSongsListFromFile(PlayListName);
        }
        private async void HyperlinkButton_ClickAsync(object sender, RoutedEventArgs e)
        {

            myMediaPlayerElement.AutoPlay = true;
            var musicFileName = (string)((HyperlinkButton)sender).Tag;
            //System.Diagnostics.Debug.Print("myFilePath : {0}  \n", musicFileName);

            var musicFile = await KnownFolders.MusicLibrary.GetFileAsync(musicFileName);
            myMediaPlayerElement.Source = MediaSource.CreateFromStorageFile(musicFile);

        }





        private async void getSongsListFromFile(string PlayListFileName)
        {

            try
            {

                var playListFolder = await KnownFolders.DocumentsLibrary.GetFolderAsync("MyPlayList");
                var playListFile = await playListFolder.GetFileAsync(PlayListFileName);
                var stream = await playListFile.OpenStreamForReadAsync();

                Songs song = new Songs();

                using (var reader = new StreamReader(stream))
                {
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {
                        var lineArray = line.Split(',');
                        song = new Songs
                        {
                            Title = lineArray[0],
                            TitleWithFileExtn = lineArray[1],
                            FilePath = lineArray[2],
                            Album = lineArray[3],
                            Artist = lineArray[4]
                        };
                        Songslist.Add(song);
                        System.Diagnostics.Debug.WriteLine(" TitleWithFileExtn:::: ", song.TitleWithFileExtn);
                    }



                }
            }
            catch (Exception exp)
            {
                System.Diagnostics.Debug.WriteLine(" Exception ", exp);
            }
            SongsListView.ItemsSource = Songslist;


        }

        private void DeleteSongs_Button_Click(object sender, RoutedEventArgs e)
        {

            //playslist name is PlayListName

            List<Songs> myPlaylist = new List<Songs>();
           // Debug.Print("print total number of songs inlist  : {0}", Songslist.Count());
            foreach (Songs song in Songslist)
            {
                if (!song.IsChecked)
                {
                    myPlaylist.Add(song);
                    System.Diagnostics.Debug.WriteLine("song selected : {0} ,{1},{2}, {3} \n", song.TitleWithFileExtn, song.Title, song.FilePath, song.Album);

                }
            }

            //Need to add feature where we re-write the playlist with the selected song/s removed

            SongsListView.ItemsSource = myPlaylist;

        }
        private void Home_Button_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

    }
}
