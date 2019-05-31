using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carol_FileIO
{
    class Playlist
    {
        public string sampleFile { get; set; }
        public string simpleContent { get; set; }

        //await Windows.Storage.FileIO.WriteTextAsync(sampleFile, "Swift as a shadow");
    





        public static void WriteText(Playlist playlist)
        {
            var playlistData = $"{playlist.simpleContent}";
            FileHandlerIO.WriteTextFileAsync(playlist.sampleFile, playlistData);
        }
        
    } //end class Playlist

}
