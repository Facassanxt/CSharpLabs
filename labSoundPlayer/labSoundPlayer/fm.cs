using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace labSoundPlayer
{
    public partial class fm : Form
    {
        private SoundPlayer soundPlayer = new SoundPlayer();
        public fm()
        {
            InitializeComponent();

            soundPlayer.SoundLocation = @"C:\Windows\Media\Ring01.wav";
            //soundPlayer.Stream = Properties.Resources.change;

            buPlay.Click += (s, e) => soundPlayer.Play();
            buStop.Click += (s, e) => soundPlayer.Stop();
            buPlayLooping.Click += (s, e) => soundPlayer.PlayLooping();

            button4.Click += (s, e) => SystemSounds.Beep.Play();

        }
    }
}
