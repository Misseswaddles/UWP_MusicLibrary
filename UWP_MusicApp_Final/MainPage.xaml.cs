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
        public MainPage()
        {
            this.InitializeComponent();

            GetListOfSongs();
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
                    System.Diagnostics.Debug.WriteLine("song selected : {0}  \n", song.TitleName);
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

                SongsList.Add(new Songs() { Title = musicProperties.Title, Artist = musicProperties.Artist, Album = musicProperties.Album, TitleName = file.Name, FilePath = file.Path });
                //Debug.Print("Name : {0}, Path : {1} .  Music props:{2}\n", musicProperties.Title, file.Name, musicProperties.ToString());
                Debug.WriteLine("Title : {0}, Album : {1},  Title Name:{2}, File Path: {3}, Music Props: {4}\n", musicProperties.Title, musicProperties.Album, file.Name, file.Path, musicProperties.ToString());
                //OUtput: Note, no title to the song. Need an if statemtn if no title, than take from 
                //Song element: Album: YouTube Audio Library  TitleName: Afternoon_Crickets_Long.mp3 Title: Afternoon Crickets Long  FilePath: C:\Users\keyro\Music\Afternoon_Crickets_Long.mp3 
                //Song element: Album: YouTube Audio Library TitleName: Itsy_Bitsy_Spider_instrumental.mp3 Title: Itsy Bitsy Spider(instrumental)  FilePath: C: \Users\keyro\Music\Itsy_Bitsy_Spider_instrumental.mp3
                // Song element: Album: TitleName: Pop_Goes_The_Weasel.mp3 Title:   FilePath: C: \Users\keyro\Music\Pop_Goes_The_Weasel.mp3

            }

            Songs.ItemsSource = SongsList;  //this won't go away until I update the MainPage.xaml
        }

        //This Click method navigates the display to CreatePlayList page 
        private void Create_Playlist_Button_Click(object sender, RoutedEventArgs e)
        {
            List<Songs> playlist = SelectedSongs();
            //Frame.Navigate(typeof(CreatePlayList), playlist);  //need to implement handling of playlist
            Frame.Navigate(typeof(CreatePlayList), playlist);
          

        }

        //This click method navigates the display to the PlayPlaylist page
        private void Play_Playlist_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(PlayPlaylist));
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
    }
}
