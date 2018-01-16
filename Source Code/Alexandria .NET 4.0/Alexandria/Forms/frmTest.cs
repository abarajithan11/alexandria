using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.IO;
using System.Diagnostics;

namespace Alexandria
{
    public partial class frmTest : Form
    {
        public frmTest()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Directory.GetCurrentDirectory(), Directory.GetCurrentDirectory() + @"\Resources\User Guide.pdf");
            Process P = new Process
            {
                StartInfo = { FileName = "AcroRd32.exe", Arguments = path }
            };
            P.Start();
            MessageBox.Show(Directory.GetCurrentDirectory() + @"\Resources\User Guide.pdf");
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            

        }

        private void button3_Click(object sender, EventArgs e)
        {
            
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }




    }
}
