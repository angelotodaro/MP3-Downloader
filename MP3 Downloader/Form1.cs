using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MP3_Downloader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var destination = Directory.GetCurrentDirectory() + "/" + fileNameBox.Text + ".mp3";

            new WebClient().DownloadFileTaskAsync(
               new Uri(urlBox.Text),
               destination);
        }
    }
}
