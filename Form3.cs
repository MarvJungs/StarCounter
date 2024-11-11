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

namespace StarCounter
{
    public partial class Form_about : Form
    {
        public Form_about()
        {
            InitializeComponent();
        }

        private void pictureBox_logo_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://github.com/MarvJungs/StarCounter") { UseShellExecute = true });
        }

        private void pictureBox_kofi_Click(object sender, EventArgs e)
        {
            Process.Start(new ProcessStartInfo("https://ko-fi.com/marvjungs") { UseShellExecute = true });
        }

        private void button_about_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
