using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;

namespace UWP_MusicApp_Final
{
    class Playlist
    {

        public Playlist(string name)
        {
            this.name = name;

        }

        public String name { get; set; }
        public List<Songs> songs { get; set; }




    }
}
