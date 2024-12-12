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
    public partial class ÖÖğrenci : Form
    {
        public ÖÖğrenci()
        {
            InitializeComponent();
        }

        public class Ogrenci
        {
            public int OgrenciID { get; set; }
            public string Ad { get; set; }
            public string Soyad { get; set; }
            public float GNO { get; set; }
        }

        private void ÖÖğrenci_Load(object sender, EventArgs e)
        {

        }
    }
}
