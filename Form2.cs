using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StarCounter
{
    public partial class Form_settings : Form
    {
        private Form_starcounter _starcounter;
        public Form_settings(Form_starcounter starcounter)
        {
            InitializeComponent();
            _starcounter = starcounter;
        }

        private void button_settings_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_settings_apply_Click(object sender, EventArgs e)
        {
            bool success_starcount = int.TryParse(textBox_settings_stars_amount.Text, out int amountStars);
            bool success_deathcount = int.TryParse(textBox_settings_amount_deaths.Text, out int amountDeaths);

            if (!success_starcount || !success_deathcount)
            {
                MessageBox.Show("Couldn't read Starnumber or Deathcount", null, MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error);
                return;
            }

            _starcounter.label_amountStars.Text = amountStars.ToString();
            _starcounter.label_amountDeaths.Text = amountDeaths.ToString();
        }
    }
}
