using System;
using System.Collections.Generic;
using System.Text;

namespace AlbionOnlineDB.Models
{
    public class AudioInfo
    {
        public string name { get; set; }
    }

    interface IHasAudio
    {
        AudioInfo AudioInfo { get; set; }
    }
}
