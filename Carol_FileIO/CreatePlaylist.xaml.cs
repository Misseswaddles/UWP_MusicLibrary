using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;//added for file picker
using Windows.Storage.Pickers; //added for file picker
using Windows.UI.Xaml; //added for file picker
using Windows.UI.Xaml.Controls; //added for file picker
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Carol_FileIO
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class CreatePlaylist : Page
    {
        private static object audioExtensions;

    
        public CreatePlaylist()
        {
            this.InitializeComponent();
        }

        private void ClickToMain(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void Create_playlist_Click(object sender, RoutedEventArgs e)
        {
            var firstPlaylist = new Playlist
            {
                sampleFile = "testFile.txt",
                simpleContent = "Third time is a charm!"
             };

            Playlist.WriteText(firstPlaylist);
        }




    }
}
