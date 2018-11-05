using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace PSX_Classic_PC
{
    public partial class Form1 : Form
    {
        WMPLib.WindowsMediaPlayer player = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
            player.URL = "res/music/menu.mp3";
            player.controls.stop();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            player.controls.play();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }
    }
}
