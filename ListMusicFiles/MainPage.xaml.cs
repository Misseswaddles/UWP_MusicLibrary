using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
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


// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace ListMusicFiles
{
  
    public sealed partial class MainPage : Page
    {
        MediaPlayer player;
        public MainPage()
        {
            this.InitializeComponent();
            getSongs();
        }



        private async void getSongs()
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
                songs.Add(new Songs() { Title = file.DisplayName, Link = file.Path.ToString()});
              //  System.Diagnostics.Debug.WriteLine("-------------------------------", file.Name,"---------------------",file.Path);
            }
           
          Songs.ItemsSource = songs;



        }

        void playMusic(StorageFile file)
        {
            //Windows.Storage.StorageFolder folder = await Windows.ApplicationModel.Package.Current.InstalledLocation.GetFolderAsync(@"Assets");
           // Windows.Storage.StorageFile file = await folder.GetFileAsync("Skip_To_My_Lou.mp3");
            player.AutoPlay = false;
            player.Source = Windows.Media.Core.MediaSource.CreateFromStorageFile(file);
            player.Play();
        }

      

        private void HyperLink_Click(Windows.UI.Xaml.Documents.Hyperlink sender, Windows.UI.Xaml.Documents.HyperlinkClickEventArgs args)
        {
            MyMediaElement.Source = new Uri("C:/Users/rsrir/Music/Skip_To_My_Lou.mp3") ;
            System.Diagnostics.Debug.WriteLine("Name ====",sender.Name);
            MyMediaElement.Play();
        }
    }
}
