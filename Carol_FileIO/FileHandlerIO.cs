using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Streams;

namespace Carol_FileIO
{
    /// <summary>
    /// FileHandlerIO is a static class used to handle read write to the file system
    /// It is asynchronous, and would be used to store the playlists, and hopefully
    /// User information. 
    /// </summary>
    internal static class FileHandlerIO
    {
        /// <summary>
        /// WriteTextFileAsync accepts the playlist filename as a string and will store the 
        /// song object content as a string. Each song object will be a line item
        /// </summary>
        /// <param name="playlistFile">This is the user specified playlist filename.txt </param>
        /// <param name="songContent">Each line item is the text version of the song object.</param>
        public async static void WriteTextFileAsync(string playlistFile, string songContent)
        {
            var storageFolder = ApplicationData.Current.LocalFolder;
            var textFile = await storageFolder.CreateFileAsync(playlistFile, CreationCollisionOption.OpenIfExists);
            var textStream = await textFile.OpenAsync(FileAccessMode.ReadWrite);
            var textWriter = new DataWriter(textStream);
            textWriter.WriteString(songContent);
            await textWriter.StoreAsync();
        }

        /// <summary>
        /// ReadTextFileAsync accepts the playlist file string and reads the file, line by line
        /// and will play the file in order.Ideally, this should be read into a list array, 
        /// but currently will return the string contents of the file. 
        /// The method is commented out because the Task hasn't been created yet, which creats an error. 
        /// </summary>
        /// <param name="playlistFile"></param>
        /// <return name =songString >the song text object from the playlist</returns>
      
       // public async static Task<playPlaylist> ReadTextFileAsync (string playlistFile) //will err
        //{
           // var storageFolder = ApplicationData.Current.LocalFolder;
            //var textFile = await storageFolder.GetFileAsync(playlistFile);
            //var textStream = await textFile.OpenReadAsync();
            //var textReader = new DataReader(textStream);
            //var textLength = textStream.Size; //Assuming we are limiting playlist size. Max length 1000 songs?
            //await textReader.LoadAsync((uint)textLength);
            //return textReader.ReadString((uint)textLength);
        //}

    }
}
