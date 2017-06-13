using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RadioStation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://radio.mosaiquefm.net:8000/mosalive";
            pictureBox1.ImageLocation = "C:\\Users\\asus\\Documents\\Visual Studio 2015\\Projects\\RadioStation\\mosa.jpg";
            button1.Focus();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://5.135.138.182:8000/direct";
            pictureBox1.ImageLocation = "C:\\Users\\asus\\Documents\\Visual Studio 2015\\Projects\\RadioStation\\ifm.png";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://stream6.tanitweb.com/shems";
            pictureBox1.ImageLocation = "C:\\Users\\asus\\Documents\\Visual Studio 2015\\Projects\\RadioStation\\shems.jpg";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://stream6.tanitweb.com/sabrafm";
            pictureBox1.ImageLocation = "C:\\Users\\asus\\Documents\\Visual Studio 2015\\Projects\\RadioStation\\sabra.png";

        }

        private void button5_Click(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.URL = "http://ns326208.ip-37-59-9.eu:8000/sarahafm";
            pictureBox1.ImageLocation = "C:\\Users\\asus\\Documents\\Visual Studio 2015\\Projects\\RadioStation\\saraha.png";
        }

        private void axWindowsMediaPlayer1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axWindowsMediaPlayer1.Hide();
        }
    }
}
