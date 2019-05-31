using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core; //used for windows media player
using Windows.Media.Playback; //used for windows media player
using Windows.Storage.Pickers;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
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
    public sealed partial class PlayMusic : Page
    {


        //MediaSource _mediaSource = "ms-appx:///Assets/Afternoon_Crickets_Long.mp3";
        //MediaPlayerElement _mediaPlayer;
        



        //Create a new file picker
        // var filePicker = new Windows.Storage.Pickers.FileOpenPicker();

        //make collection of all video types you want to support
        //string[] fileTypes = new string[] { ".mp3", ".mp4" };

        //foreach(string fileType in fileTypes)
        //  {
        //  filePicker.FileTypeFilter.Add(fileType);
        // }

        //set picker to start location to the music library
        // filePicker.SuggestedStartLocation = PickerLocationId.Music;

        public PlayMusic() //works, but I can't 
        {
            this.InitializeComponent();


        }

   


        private void PMClickToMain(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }





    }
}
