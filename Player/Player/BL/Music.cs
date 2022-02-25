using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;


namespace Player.BL
{
    public class Music
    {
        
        MediaPlayer player = new MediaPlayer();
        public void PlayMusic(object sender, DragEventArgs e)
        {
            
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                string[] data = (string[])e.Data.GetData(DataFormats.FileDrop);

                player.Open(new Uri(data[0], UriKind.Absolute));
                player.Volume = 100;
                player.Play();
            }
            
            
            int a = 10;
            
        }

        
    }
}
