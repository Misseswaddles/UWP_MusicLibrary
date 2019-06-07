using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWP_MusicApp_Final
{
    class PlayListObj
    {
        public string FileName { get; set; } //Playlist file name. what is displayed as 
        public string FilePath { get; set; } //File path for the playlist could be a constant. 

        public string ImageName { get; set; }  //Not sure if needed but in the header file.

        public string PlayListNameWithExtn { get; set; } //
        public string ImagePath { get; set; } = "/Assets/earbudsAndSheetMusic.jpg"; //set default value 


        //



    }
}
