using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Storage;
using Windows.Storage.Search;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;


namespace ListMusicFiles
{
  
    public sealed partial class MainPage : Page
    {
        //MediaPlayer player;
        public MainPage()
        {
            this.InitializeComponent();
            GetSongs();
        }



        private async void GetSongs()
        {
           
            List<Songs> songs = new List<Songs>();

            QueryOptions queryOption = new QueryOptions
                (CommonFileQuery.OrderByTitle, new string[] { ".mp3", ".mp4", ".wma" });

            queryOption.FolderDepth = FolderDepth.Deep;

            Queue<IStorageFolder> folders = new Queue<IStorageFolder>();

            var files = await KnownFolders.MusicLibrary.CreateFileQueryWithOptions
              (queryOption).GetFilesAsync();

            foreach (var file in files)
                {
                var prop = file.Properties ;
                var musicProperties = await prop.GetMusicPropertiesAsync();
               
                
                songs.Add(new Songs() { Title = musicProperties.Title, Link = file.Path, Album  = musicProperties.Album });
               Debug.Print("Name : {0},Path : {1} \n", musicProperties.Title, file.Path);
                
            }
           
          Songs.ItemsSource = songs;



        }

        private void Title_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                MyMediaElement.Stop();
                MyMediaElement.AutoPlay = true;
                

                var myFilePath = ((HyperlinkButton)sender).Tag;
                System.Diagnostics.Debug.Print("myFilePath : {0}  \n", myFilePath);

                var mySourceUri = new Uri(myFilePath.ToString());
                System.Diagnostics.Debug.Print("mySourceUri :{0}\n", mySourceUri.OriginalString);

                var mySourceUriTest = new Uri(this.BaseUri, "Assets/Skip_To_My_Lou.mp3");
                //var mySourceUriTest = new Uri(this.BaseUri, "Assets/Wildlife.wmv");
                //var tempmusic = @"C:/Users/rsrir/Music/Skip_To_My_Lou.mp3";
                // var mySourceUriTest = new Uri(tempmusic, UriKind.RelativeOrAbsolute);

                System.Diagnostics.Debug.Print("mySourceUriTest :{0}\n", mySourceUriTest);



                 MyMediaElement.Source = mySourceUriTest;
                 MyMediaElement.Play();

            }catch(Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.ToString());
            }
        }


    }
}
