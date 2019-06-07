using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_MusicApp_Final
{
    public class Songs
    {
        //Title, Artist, Album,TitleName, FilePath
        //public Songs(string Title)
        //{
        //    this.Title = Title;
        //}


        public string Title { get; set; } = "Unknown";  //"Afternoon Crickets Long"

        public string Artist { get; set; } = "Not Available"; //Add artist if available, if not, set default to "Unknown"
        public string Album { get; set; } = "Not Available"; //YouTube Audio collection

        public string TitleWithFileExtn { get; set; } //FileName crickets.mp3
        public bool IsChecked { get; set; }  //Is the box checked to be saved to a playlist. 

        public string FilePath { get; set; } //The file path. 

        //Title, Artist, Album, TitleName, FilePath  

        //what is shown on Xaml:
        //Title, Artist Album

    }
}
