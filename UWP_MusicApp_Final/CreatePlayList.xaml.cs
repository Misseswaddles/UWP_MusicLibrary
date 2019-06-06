using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;
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
    public sealed partial class CreatePlayList : Page
    {
        //private List<Songs> SongsList;

        //public List<Songs> playlist; //name of what is sent over. 

        private List<Songs> songsLists; //commented from Selvis code
        public string imagePath { get; set; }
        public string imageName { get; set; }




        public CreatePlayList()
        {
            this.InitializeComponent();
        }

        /**
      * Override this method to retrieve the passed List of song objects from Main page
      */
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // Convert paramater to Song objects
            songsLists = new List<Songs>();
            songsLists = e.Parameter as List<Songs>;//Get object while merging
            System.Diagnostics.Debug.WriteLine(songsLists.Count);
            ListView1.ItemsSource = songsLists;
           Songs.ItemsSource = songsLists;
        }


        private void CreatePLSave_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));

            //Save the playlist by creating a file with the 
            //playlist name and storing song details.

            string filename = PLnametext.Text; 
            if (filename == null || filename == " ")
            {
                filename = "default";
                //save filename as default when there is no input from user
            }
            WriteTextFileAsync(filename);
        }

        //Below is to be refactored so Write file is in a fileio
        public async void WriteTextFileAsync(string filename)
        {
            string textfilename = filename + ".txt";
            var storageFolder = KnownFolders.DocumentsLibrary;
            var textfile = await storageFolder.CreateFileAsync(textfilename, CreationCollisionOption.ReplaceExisting);
            var textStream = await textfile.OpenAsync(FileAccessMode.ReadWrite);
            var textwriter = new DataWriter(textStream);
            textwriter.WriteString("type=playlist,name=" + filename + "," + imageName + "," + imagePath + "\r");
            foreach(Songs song in songsLists) //renamed to reflect what was sent from Mainpage. 
            {
                //Changed the name of the properties used. 
                //textwriter.WriteString("type=song,name=" + song.name + ",artist=default" + song.artist);
                //Title = musicProperties.Title, Album = musicProperties.Album, TitleName = file.Name, FilePath = file.Path
                textwriter.WriteString(song.Title + "," + song.Artist + "," + song.Album +"," + song.TitleName + ","+ song.FilePath);
                textwriter.WriteString("\r");
            }
            await textwriter.StoreAsync();
        }


        private async void CoverImage_Click(object sender, RoutedEventArgs e)
        {
            var ImagePicker = new Windows.Storage.Pickers.FileOpenPicker();
            string[] ImageTypes = new string[] { ".jpg", ".bmp", ".png", ".jpeg", ".jpg" };
            //Add your ImageTypes to the ImageTypeFilter list of ImagePicker.
            foreach (string ImageType in ImageTypes)
            {
                ImagePicker.FileTypeFilter.Add(ImageType);
            }
            ImagePicker.SuggestedStartLocation = PickerLocationId.PicturesLibrary;
            ImagePicker.ViewMode = PickerViewMode.Thumbnail;
            StorageFile file = await ImagePicker.PickSingleFileAsync();
            imagePath = file.Path;
            imageName = file.Name;
        }
    }
}
