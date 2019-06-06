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
        //private const String DIRECTORY = "C:\\Users\\keyro\\source\\repos\\Playlist";  //
        //no access to this directory so using appdata

        public Playlist(string name)
        {
            this.name = name;

        }

        public String name { get; set; }
        public List<Songs> songs { get; set; }



        /*  Not yet implemented correctly

       public void addSong(Songs song)
       {
           if (songs == null)
           {
               songs = new List<Songs>();
           }
           songs.Add(song);
       }

       public void removeSong(Songs song)
       {
           if (songs != null && songs.Count > 0)
           {
               songs.Remove(song);

           }

       }


       public void savePlaylist()
       {
           String filePath = DIRECTORY + "\\" + name + ".txt";

           //convert Song object into string to store it as each line in file
           List<string> songNames = new List<string>();
           foreach (Songs song in songs)
           {
               songNames.Add(song.Title); //changed from .name to .Title CF
           }

           // Check what happens if file is not present
           // songNames.AsEnumerable<Song>
           System.IO.File.WriteAllLines(@filePath, songNames);
       }
      

        public static async void WriteTextFileAsync(string filename, string content)
        {

            var storageFolder = ApplicationData.Current.LocalFolder;
            var textfile = await storageFolder.CreateFileAsync(filename, CreationCollisionOption.ReplaceExisting);
            var textStream = await textfile.OpenAsync(FileAccessMode.ReadWrite);
            var textwriter = new DataWriter(textStream);
            textwriter.WriteString(content);
            await textwriter.StoreAsync();

            //Windows.Storage.CreationCollisionOption.ReplaceExisting);

        }

        public static async Task<string> ReadTextFileAsync(string filename)
        {

            var storageFolder = ApplicationData.Current.LocalFolder;
            var textfile = await storageFolder.GetFileAsync(filename);
            var textStream = await textfile.OpenReadAsync();
            var textReader = new DataReader(textStream);
            var textLength = textStream.Size;
            await textReader.LoadAsync((uint)textLength);
            return textReader.ReadString((uint)textLength);

        }

     */


    }
}
