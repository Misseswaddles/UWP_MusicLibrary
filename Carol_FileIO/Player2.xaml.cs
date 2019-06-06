using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Media.Core;
using Windows.Media.Playback;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Search;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Imaging;
using Windows.UI.Xaml.Navigation;

//Below is some documentation that may be handy when converting media selected by filepicker to a playlist.
//https://docs.microsoft.com/en-us/uwp/api/windows.media.core.mediasource

namespace Carol_FileIO
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Player2 : Page
    {

        MediaSource _mediaSource;
        private BitmapImage _posterSource;

        public Player2()
        {
            this.InitializeComponent();
            MediaPlayerElement _mediaPlayer = new MediaPlayerElement();
            _posterSource = new BitmapImage(new Uri("ms-appx:///Assets/speaker_img.png"));
           //_mediaPlayer.PosterSource = new BitmapImage(new Uri("ms-appx:///Assets/speaker_img.png"));
            _mediaPlayer.PosterSource = _posterSource;

           // private string _playListImage { get; set; }
          //  public string PlayListImage
      //  {
      //      get { return _playListImage; }
      //     set { _playListImage = value; }
       // }
            //public string playListImage { get; set => new BitmapImage(new Uri("ms-appx:///Assets/speaker_img.png"))}
        //string playListImage = new BitmapImage(new Uri("ms-appx:///Assets/speaker_img.png"));

        }//Player 2 class

        /// <summary>
        /// Select_Song_Click allows user to select a song using filepicker.
        /// Filepath begins at MusicLibrary
        /// Songs are sent to MediaPlayerElement.Source 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Select_Song_Click(object sender, RoutedEventArgs e)
        {

          
            var filePicker = new Windows.Storage.Pickers.FileOpenPicker();

            //make a collection of all Song types you want to support (for testing we are adding just 3).
            string[] fileTypes = new string[] { ".mp3" };

            //Add your fileTypes to the FileTypeFilter list of filePicker.
            foreach (string fileType in fileTypes)
            {
                filePicker.FileTypeFilter.Add(fileType);
            }

            //Set picker start location to the Music library
            filePicker.SuggestedStartLocation = PickerLocationId.MusicLibrary;

            //Retrieve file from picker
            StorageFile file = await filePicker.PickSingleFileAsync();

            if (!(file is null))
            {
                _mediaSource = MediaSource.CreateFromStorageFile(file);
                System.Diagnostics.Debug.WriteLine("_mediaSource : {0} ", _mediaSource.ToString());
                _mediaPlayer.Source = _mediaSource; //what is this and what are the source requirements to get it to work? 
                                                    //Can you use a URI? used a hyperlink button tag. 
            }

        }

        /// <summary>
        /// Select_Image_Click allows user to select a an image using filepicker.
        /// Filepath is supposed to start at PicturesLibrary
        /// Image selected is then sent to mediaplayer.postersource on page.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void Select_Image_Click(object sender, RoutedEventArgs e)
        {
            var ImagePicker = new Windows.Storage.Pickers.FileOpenPicker();

            string[] ImageTypes = new string[] { ".jpg" };            //make a collection of all Pictures you want 

            //Add your ImageTypes to the ImageTypeFilter list of ImagePicker.
            foreach (string ImageType in ImageTypes)
            {
                ImagePicker.FileTypeFilter.Add(ImageType);
            }

            //Set picker start location to the Saved Picture library
            ImagePicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            ImagePicker.ViewMode = PickerViewMode.Thumbnail;

            // Filter to include a sample subset of file types.
            ImagePicker.FileTypeFilter.Clear();
            ImagePicker.FileTypeFilter.Add(".bmp");
            ImagePicker.FileTypeFilter.Add(".png");
            ImagePicker.FileTypeFilter.Add(".jpeg");
            ImagePicker.FileTypeFilter.Add(".jpg");

            //Retrieve file from picker
            StorageFile file = await ImagePicker.PickSingleFileAsync();

            if (file != null)
            {
                // Open a stream for the selected file.
                // The 'using' block ensures the stream is disposed
                // after the image is loaded.
                using (Windows.Storage.Streams.IRandomAccessStream fileStream =
                    await file.OpenAsync(Windows.Storage.FileAccessMode.Read))
                {
                    // Set the image source to the selected bitmap.
                    Windows.UI.Xaml.Media.Imaging.BitmapImage bitmapImage =
                        new Windows.UI.Xaml.Media.Imaging.BitmapImage();

                    bitmapImage.SetSource(fileStream);
                    System.Diagnostics.Debug.WriteLine("bitmap");
                    //System.Diagnostics.Debug.WriteLine(bitmapImage.UriSource.ToString());
                    System.Diagnostics.Debug.WriteLine("bitmap");
                    _mediaPlayer.PosterSource = bitmapImage;
                    System.Diagnostics.Debug.WriteLine(_mediaPlayer.PosterSource.ToString());

                }

            }



        }

        /// <summary>
        /// Button_Back_Click returns user to Main page with click event.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void Button_Back_Click(object sender, RoutedEventArgs e)
        {
            
                Frame.Navigate(typeof(MainPage));

        }

    }//class
}
