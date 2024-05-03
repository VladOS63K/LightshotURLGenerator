using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GraphicGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string urlChrs = "qwertyuiopasdfghjklzxcvbnm1234567890";
            char[] charMap = urlChrs.ToCharArray();
            int linksCount = (int)numericUpDown1.Value;
            List<string> listUrls = new List<string>();

            for (int i = 0; i < linksCount; i++)
            {
                Random rand = new Random();
                string output = "https://prntscr.com/";
                for (int ii = 0; ii < 6; ii++)
                {
                    char randChar = charMap[rand.Next(0, charMap.Length)];
                    output += randChar;
                }
                listUrls.Add(output);
            }

            Console.WriteLine("\n\nYour URLs are:\n");
            
            foreach (string url in listUrls)
            {
                Console.WriteLine(url);
                PictureBox box = new PictureBox();
                box.BorderStyle = BorderStyle.FixedSingle;
                box.SizeMode = PictureBoxSizeMode.StretchImage;
                box.Location = new Point(3, 3);
                box.Size = new Size(48,48);
                box.Parent = flowLayoutPanel1;
                box.InitialImage = Properties.Resources.icons8_загрузка__1_;
                box.ErrorImage = Properties.Resources.загруженное__1_;
                box.ImageLocation = url;
                box.Click += (s,p) =>
                {
                    PictureBox sBox = s as PictureBox;
                    Process.Start(sBox.ImageLocation);
                };

                box.MouseEnter += (s, p) =>
                {
                    PictureBox sBox = s as PictureBox;
                    label1.Text = "URL: " + sBox.ImageLocation;
                };

                box.MouseLeave += (s, p) =>
                {
                    label1.Text = "Click on image to open URL.";
                };
                flowLayoutPanel1.PerformLayout();
            }
        }
    }
}
