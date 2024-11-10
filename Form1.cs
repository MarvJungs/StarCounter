using LiveSplit_Sync_Console;

namespace StarCounter
{
    public partial class Form_starcounter : Form
    {
        readonly int addrMarioAction = 0x33B17C;

        readonly int[] victoryAction = { 0x1302, 0x1303, 0x1307 };
        readonly int[] deathAction = { 0x1928, 0x1929 };

        readonly int timeToSleep = 100;


        private int _prevMarioAction = 0;
        private int _currentMarioAction = 0;
        private ProcessManager? _processManager;

        public Form_starcounter()
        {
            InitializeComponent();

            timer_update.Interval = timeToSleep;
            timer_update.Tick += timer_update_Tick;
            timer_update.Tick += checkForEmulator;
            timer_update.Start();
        }

        private void timer_update_Tick(object sender, EventArgs e)
        {
            if (_processManager == null)
            {
                return;
            }
            bool success_starcount = int.TryParse(label_amountStars.Text, out int amountStars);
            bool success_deathcount = int.TryParse(label_amountDeaths.Text, out int amountDeaths);
            if (!success_starcount || !success_deathcount)
            {
                MessageBox.Show("Couldn't read Starnumber or Deathcount", null, MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error);
                return;
            }

            _prevMarioAction = _currentMarioAction;
            _currentMarioAction = _processManager.ReadMemory((nint)(_processManager.GetBaseAddress().ToInt64() + addrMarioAction));
            if (victoryAction.Contains<int>(_currentMarioAction) && _prevMarioAction != _currentMarioAction)
            {
                amountStars++;
                label_amountStars.Text = amountStars.ToString();
            }
            else if (deathAction.Contains<int>(_currentMarioAction) && _prevMarioAction != _currentMarioAction)
            {
                amountDeaths++;
                label_amountDeaths.Text = amountDeaths.ToString();
            }

        }

        private void checkForEmulator(object snder, EventArgs e)
        {
            try
            {
                _processManager = new ProcessManager();
            }
            catch (Exception)
            {
                label_amountDeaths.Visible = false;
                label_amountStars.Visible = false;
                label_x_death.Visible = false;
                label_x_star.Visible = false;
                pictureBox_death.Visible = false;
                pictureBox_star.Visible = false;
                return;
            }
            label_amountDeaths.Visible = true;
            label_amountStars.Visible = true;
            label_x_death.Visible = true;
            label_x_star.Visible = true;
            pictureBox_death.Visible = true;
            pictureBox_star.Visible = true;
        }

        private void button_decrease_stars_Click(object sender, EventArgs e)
        {
            bool success_starcount = int.TryParse(label_amountStars.Text, out int amountStars);
            if (!success_starcount)
            {
                MessageBox.Show("Couldn't read Starnumber", null, MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error);
                return;
            }
            label_amountStars.Text = (--amountStars < 0 ? 0 : amountStars).ToString();
        }

        private void button_reset_stars_Click(object sender, EventArgs e)
        {
            int amountStars = 0;
            label_amountStars.Text = amountStars.ToString();
        }

        private void button_increase_stars_Click(object sender, EventArgs e)
        {
            bool success_starcount = int.TryParse(label_amountStars.Text, out int amountStars);
            if (!success_starcount)
            {
                MessageBox.Show("Couldn't read Starnumber", null, MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error);
                return;
            }
            label_amountStars.Text = (++amountStars).ToString();
        }

        private void button_decrease_deaths_Click(object sender, EventArgs e)
        {
            bool success_deaths = int.TryParse(label_amountDeaths.Text, out int amountDeaths);
            if (!success_deaths)
            {
                MessageBox.Show("Couldn't read Deaths", null, MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error);
                return;
            }
            label_amountDeaths.Text = (--amountDeaths).ToString();
        }

        private void button_reset_deaths_Click(object sender, EventArgs e)
        {
            int amountDeaths = 0;
            label_amountDeaths.Text = amountDeaths.ToString();
        }

        private void button_increase_deaths_Click(object sender, EventArgs e)
        {
            bool success_deaths = int.TryParse(label_amountDeaths.Text, out int amountDeaths);
            if (!success_deaths)
            {
                MessageBox.Show("Couldn't read Deaths", null, MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error);
                return;
            }
            label_amountDeaths.Text = (++amountDeaths).ToString();
        }

        private void settingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_settings(this).ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
