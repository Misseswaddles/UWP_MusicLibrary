using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Storage;
using Windows.Storage.Search;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace UWP_MusicApp_Final
{
    /// <summary>
    /// This Music Application uses Media Player Element to play songs. Songs are originally retrieved from Music LIbrary
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<Songs> SongsList = new List<Songs>();

        List<Songs> playlist = new List<Songs>(); //added here. 

        List<PlayListObj> PlayListDropdownFiles = new List<PlayListObj>();

        public const string MY_PLAYLIST_FOLDER = "MyPlayList"; //

        public MainPage()
        {
            this.InitializeComponent();

            GetListOfSongs();
            GetListOfPlayList();
        }

        private async void GetListOfPlayList()
        {
            var palyListFolder = await KnownFolders.DocumentsLibrary.CreateFolderAsync(MY_PLAYLIST_FOLDER, CreationCollisionOption.OpenIfExists);

            //var palyListFolder = await KnownFolders.DocumentsLibrary.GetFolderAsync("MyPlayList");

            var playlistFiles = await palyListFolder.GetFilesAsync();
            foreach (var file in playlistFiles)
            {
                PlayListObj obj = new PlayListObj();
                obj.FileName = file.DisplayName;
                obj.FilePath = file.Path;
                obj.PlayListNameWithExtn = file.Name;

                PlayListDropdownFiles.Add(obj);
               // System.Diagnostics.Debug.Print("GetListOfPlayList PlayListFile...................{0} {1}\n", file.Name, file.Path);
            }
            PlayListCombo.ItemsSource = PlayListDropdownFiles;
        }

        // This method fetches selected songs from UI.
        private List<Songs> SelectedSongs()
        {
            List<Songs> myPlaylist = new List<Songs>();

            foreach (Songs song in SongsList)
            {
                if (song.IsChecked == true)
                {
                    myPlaylist.Add(song);
                    System.Diagnostics.Debug.WriteLine("song selected : {0}  \n", song.TitleWithFileExtn);
                }
            }
            return myPlaylist;
        }

        //This method fetches songs from windows My Music library and populates the files information into songs object
        private async void GetListOfSongs()
        {
            QueryOptions queryOption = new QueryOptions
                (CommonFileQuery.OrderByTitle, new string[] { ".mp3", ".mp4", ".wma" });
            queryOption.FolderDepth = FolderDepth.Deep;

            IReadOnlyList<StorageFile> files = await KnownFolders.MusicLibrary.CreateFileQueryWithOptions
              (queryOption).GetFilesAsync();


            foreach (var file in files)
            {
                var prop = file.Properties;
                var musicProperties = await prop.GetMusicPropertiesAsync();

                if (musicProperties.Title == null || musicProperties.Title == "")
                {
                    string _title = file.Name;
                    musicProperties.Title = _title.Substring(0, _title.LastIndexOf(".") + 1);
                }

                SongsList.Add(new Songs() { Title = musicProperties.Title, Artist = musicProperties.Artist, Album = musicProperties.Album, TitleWithFileExtn = file.Name, FilePath = file.Path });
                //Debug.Print("Name : {0}, Path : {1} .  Music props:{2}\n", musicProperties.Title, file.Name, musicProperties.ToString());
                Debug.WriteLine("Title : {0}, Album : {1},  Title Name:{2}, File Path: {3}, Music Props: {4}\n", musicProperties.Title, musicProperties.Album, file.Name, file.Path, musicProperties.ToString());
            }

            // Songs.ItemsSource = SongsList;  //Used for original working gridlist
            SongsListView.ItemsSource = SongsList;
        }

        //This Click method navigates the display to CreatePlayList page 
        private void Create_Playlist_Button_Click(object sender, RoutedEventArgs e)
        {
            List<Songs> playlist = SelectedSongs();

            Frame.Navigate(typeof(CreatePlayList), playlist);
          

        }


        //This hyperlink button (which is attached to each song object on the main page,
        //will direct the selected song object to MediaPlayerElement to play
        private async void HyperlinkButton_ClickAsync(object sender, RoutedEventArgs e)
        {
            myMediaPlayerElement.AutoPlay = false; //Let the user click play. 
            var musicFileName = (string)((HyperlinkButton)sender).Tag;
            System.Diagnostics.Debug.WriteLine("myFilePath : {0}", musicFileName);  //musicFileName is not a file path. It is the file name. Ex, Afternoon_Crickets_long.mp3

            var musicFile = await KnownFolders.MusicLibrary.GetFileAsync(musicFileName);
            myMediaPlayerElement.Source = MediaSource.CreateFromStorageFile(musicFile);

        }

        private void Go_Button_Click(object sender, RoutedEventArgs e)
        {
            PlayListObj selctedPlaylistName = (PlayListObj)PlayListCombo.SelectedItem;
            //System.Diagnostics.Debug.Print("selctedPlaylistName------{0}", selctedPlaylistName.DisplayName);
            Frame.Navigate(typeof(PlayList), selctedPlaylistName.PlayListNameWithExtn);
        }
    }
}
