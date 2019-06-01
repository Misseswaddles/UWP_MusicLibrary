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


            var files = await KnownFolders.MusicLibrary.CreateFileQueryWithOptions
              (queryOption).GetFilesAsync();

            foreach (var file in files)
                {
                var prop = file.Properties ;
                var musicProperties = await prop.GetMusicPropertiesAsync();
             
                
                songs.Add(new Songs() { Title = musicProperties.Title, Album  = musicProperties.Album ,TitleName = file.Name});
               Debug.Print("Name : {0}, Path : {1} .  Music props:{2}\n", musicProperties.Title, file.Name,musicProperties.ToString());
                
            }
           
          Songs.ItemsSource = songs;



        }

        private async void HyperlinkButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
              
                myMediaPlayerElement.AutoPlay = true;
                var musicFileName = (string)((HyperlinkButton)sender).Tag;
                System.Diagnostics.Debug.Print("myFilePath : {0}  \n", musicFileName);

                var musicFile = await KnownFolders.MusicLibrary.GetFileAsync(musicFileName);
                myMediaPlayerElement.Source = MediaSource.CreateFromStorageFile(musicFile);
            }
            catch(Exception ex)
            {
                System.Diagnostics.Debug.Print(ex.ToString());
            }
        }

       

       
    }
}
