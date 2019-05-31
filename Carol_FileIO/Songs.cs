using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carol_FileIO
{
    class Songs
    {
        public static List<Songs> ItemsSource { get; internal set; }
        public string Title { get; set; }
        public string FilePath { get; set; }
        public string Album { get; set; }
        
        public string ImageSource { get; set; }
    }
}
