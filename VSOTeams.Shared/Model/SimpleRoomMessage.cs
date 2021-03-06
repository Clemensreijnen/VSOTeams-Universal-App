﻿using System;
using System.Collections.Generic;
using System.Text;
using Windows.UI.Xaml.Media;

namespace VSOTeams.Model
{
    public class SimpleRoomMessage
    {
        public string PostedByDisplayName { get; set; }
        public string Content { get; set; }
        public ImageSource MessageTypeURI { get; set; }
        public ImageSource MessageTypeURIBig { get; set; }
        public DateTime postedTime { get; set; }
        public string Url { get; set; }


public TeamRoomMessage message { get; set; }

        public string PostedByImageUrl { get; set; }

        public string PostedByImageLocation { get; set; }
    }
}
