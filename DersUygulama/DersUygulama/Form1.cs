using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DersUygulama
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Öğrenci Öğrenci= new Öğrenci();
            Öğrenci.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DanismanOgretmen DanismanOgretmen = new DanismanOgretmen();
            DanismanOgretmen.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OgrenciIsleri OgrenciIsleri = new OgrenciIsleri();
            OgrenciIsleri.Show();
        }
    }
}
