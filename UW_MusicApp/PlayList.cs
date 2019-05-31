using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UW_MusicApp
{
    class PlayList
    {
        //User can make a playlist object (and could make more)
        //It will create a file name (from user), and added as text file.
        //then user can save to file. 
        //first create so we can have just one playlist
        
        //create a constant that will not change for one playlist
        //eventually, this should be changeable to create mulitple playlists
        private const string TEXT_FILE_NAME = "Playlist.txt"; 

        public string Album { get; set; }
        public string Title { get; set; }
        public string FilePath { get; set; } //There may be a better way to do this. 


        //Create a method to write an Album/Tile
        //public async static Task<Songs> GetSongAsync()
        //{
           // var songs = new List<Songs>
        //}
        

    }
}
