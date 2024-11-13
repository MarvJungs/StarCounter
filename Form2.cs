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
        private readonly Form_starcounter _starcounter;

        public Form_settings(Form_starcounter starcounter)
        {
            InitializeComponent();
            _starcounter = starcounter;

            textBox_settings_fontsize.Text = _starcounter.FontSize.ToString();
        }

        private void button_settings_ok_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button_settings_apply_Click(object sender, EventArgs e)
        {
            bool success_starcount = int.TryParse(textBox_settings_stars_amount.Text, out int amountStars);
            bool success_deathcount = int.TryParse(textBox_settings_amount_deaths.Text, out int amountDeaths);
            bool success_fontsize = int.TryParse(textBox_settings_fontsize.Text, out int fontsize);

            if (!success_starcount || !success_deathcount)
            {
                MessageBox.Show("Couldn't read Starnumber or Deathcount", null, MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error);
                return;
            }

            if (!success_fontsize)
            {
                MessageBox.Show("Couldn't read Fontsize", null, MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error);
                return;
            }

            _starcounter.label_amountStars.Text = amountStars.ToString();
            _starcounter.label_amountDeaths.Text = amountDeaths.ToString();

            if (!checkBox_settings_show_deaths.Checked && !checkBox_settings_show_stars.Checked) { 
                MessageBox.Show("You cannot disable both counters", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!checkBox_settings_show_deaths.Checked)
            {
                _starcounter.pictureBox_death.Hide();
                _starcounter.label_x_death.Hide();
                _starcounter.label_amountDeaths.Hide();
                _starcounter.button_decrease_deaths.Hide();
                _starcounter.button_reset_deaths.Hide();
                _starcounter.button_increase_deaths.Hide();

                _starcounter.pictureBox_star.Show();
                _starcounter.label_x_star.Show();
                _starcounter.label_amountStars.Show();
                _starcounter.button_decrease_stars.Show();
                _starcounter.button_reset_stars.Show();
                _starcounter.button_increase_stars.Show();

                _starcounter.Height = _starcounter.Height / 2;
            }
            else if (!checkBox_settings_show_stars.Checked) {
                _starcounter.pictureBox_death.Show();
                _starcounter.label_x_death.Show();
                _starcounter.label_amountDeaths.Show();
                _starcounter.button_decrease_deaths.Show();
                _starcounter.button_reset_deaths.Show();
                _starcounter.button_increase_deaths.Show();

                _starcounter.pictureBox_star.Hide();
                _starcounter.label_x_star.Hide();
                _starcounter.label_amountStars.Hide();
                _starcounter.button_decrease_stars.Hide();
                _starcounter.button_reset_stars.Hide();
                _starcounter.button_increase_stars.Hide();

            }
            else if (checkBox_settings_show_stars.Checked && checkBox_settings_show_deaths.Checked)
            {
                _starcounter.pictureBox_death.Show();
                _starcounter.label_x_death.Show();
                _starcounter.label_amountDeaths.Show();
                _starcounter.button_decrease_deaths.Show();
                _starcounter.button_reset_deaths.Show();
                _starcounter.button_increase_deaths.Show();

                _starcounter.pictureBox_star.Show();
                _starcounter.label_x_star.Show();
                _starcounter.label_amountStars.Show();
                _starcounter.button_decrease_stars.Show();
                _starcounter.button_reset_stars.Show();
                _starcounter.button_increase_stars.Show();

                _starcounter.Height = 5 * 50 + _starcounter.button_decrease_deaths.Height + _starcounter.button_increase_stars.Height + _starcounter.pictureBox_death.Height + _starcounter.pictureBox_star.Height;

            }

            _starcounter.FontSize = fontsize;
            _starcounter.SetupLayout();
        }
    }
}
