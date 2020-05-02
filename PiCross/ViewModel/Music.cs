using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ViewModel
{
    public class Music
    {
        private readonly MediaPlayer Player;

        public Music(MediaPlayer player)
        {
            this.Player = player;
        }

        public void Open(Uri uri)
        {
            Player.Open(uri);
        }

        public void Rewind()
        {
            Player.Position = new TimeSpan(-5, -5, -5);
        }
        public void Play()
        {
            Player.Play();
        }
        public void Stop()
        {
            Player.Pause();
        }
    }
}
