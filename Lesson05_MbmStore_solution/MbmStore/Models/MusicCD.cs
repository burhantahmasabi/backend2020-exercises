using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace MbmStore.Models {

    public class MusicCD : Product {
        public string Artist { get; set; }
        public string Label { get; set; }
        public short Released { get; set; }

        public List<Track> Tracks { get; } = new List<Track>();

        public void AddTrack(Track track) {
            Tracks.Add(track);
        }

        public MusicCD() {}

        public MusicCD(string artist, string title, decimal price, short released)
            : base(title, price) {
            Artist = artist;
            Released = released;
        }

        public TimeSpan GetPlayingTime() {
            TimeSpan ts = TimeSpan.Parse("00:00");

            foreach (Track track in this.Tracks) {
                ts += track.Length;
            }
            return ts;

        }
    }
}