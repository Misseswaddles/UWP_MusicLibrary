﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.Media.Playback;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Media;

namespace Carol_FileIO
{
    public class MediaPlayerElement : Control
    {
        //this.private initializeComponent();

        //IMediaPlaybackSource is the Url where your music sits. 
        //the syntax is slightly different from MediaElement. 
        //Syntax is Source="ms-appx:///Assets/Afternoon_Crickets_Long.mp3" 
        public IMediaPlaybackSource Source { get; set; }

        //ImageSource is the image the Media Player will play in the absence of video. This
        //can also be used to set the image attached to the song.
        public ImageSource PosterSource { get; set; }


    }
}
