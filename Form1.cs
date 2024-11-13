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

        const int margin = 50;

        public int FontSize { get; set; } = 128;

        public Form_starcounter()
        {
            InitializeComponent();
            SetupLayout();

            label_amountStars.Text = 0.ToString();
            label_amountDeaths.Text = 0.ToString();

            timer_update.Interval = timeToSleep;
            timer_update.Tick += timer_update_Tick;
            timer_update.Tick += checkForEmulator;
            timer_update.Start();
        }

        public void SetupLayout()
        {
            button_decrease_stars.Height = FontSize / 2;
            button_decrease_stars.Width = 2 * FontSize / 2;
            button_reset_stars.Height = FontSize / 2;
            button_reset_stars.Width = 2 * FontSize / 2;
            button_increase_stars.Height = FontSize / 2;
            button_increase_stars.Width = 2 * FontSize / 2;

            button_decrease_deaths.Height = FontSize / 2;
            button_decrease_deaths.Width = 2 * FontSize / 2;
            button_reset_deaths.Height = FontSize / 2;
            button_reset_deaths.Width = 2 * FontSize / 2;
            button_increase_deaths.Height = FontSize / 2;
            button_increase_deaths.Width = 2 * FontSize / 2;

            button_reset_deaths.Font = new Font(this.Font.Name, FontSize / 4);
            button_reset_stars.Font = new Font(this.Font.Name, FontSize / 4);

            pictureBox_death.Size = new Size(FontSize * 2, FontSize * 2);
            pictureBox_star.Size = new Size(FontSize * 2, FontSize * 2);
            

            button_decrease_stars.Location = new Point(margin, margin);
            button_reset_stars.Location = new Point(button_decrease_stars.Location.X + button_decrease_stars.Width + margin, margin);
            button_increase_stars.Location = new Point(button_reset_stars.Location.X + button_reset_stars.Width + margin, margin);

            pictureBox_star.Location = new Point(margin, button_decrease_stars.Location.Y + button_decrease_stars.Height + margin);
            label_x_star.Location = new Point(pictureBox_star.Location.X + pictureBox_star.Width + margin, 2 * margin + button_increase_stars.Height + pictureBox_star.Height / 4);
            label_x_star.Font = new Font(this.Font.Name, FontSize);
            label_amountStars.Location = new Point(label_x_star.Location.X + label_x_star.Width + margin, 2 * margin + button_increase_stars.Height + pictureBox_star.Height / 4 - FontSize / 4);
            label_amountStars.Font = new Font(this.Font.Name, FontSize);
            label_amountStars.Width = 4 * FontSize;
            label_amountStars.Height = FontSize;

            this.Height = 5 * 50 + button_decrease_deaths.Height + button_increase_stars.Height + pictureBox_death.Height + pictureBox_star.Height;
            this.Width = label_amountStars.Location.X + 4 * FontSize + margin;

            pictureBox_death.Location = new Point(margin, this.Height / 2 + margin);
            label_x_death.Location = new Point(pictureBox_death.Location.X + pictureBox_death.Width + margin, this.Height / 2 + margin);
            label_x_death.Font = new Font(this.Font.Name, FontSize);
            label_amountDeaths.Location = new Point(label_x_death.Location.X + label_x_death.Width + margin, this.Height / 2 + margin);
            label_amountDeaths.Font = new Font(this.Font.Name, FontSize);
            label_amountDeaths.Width = 4 * FontSize;
            label_amountDeaths.Height = FontSize;

            button_decrease_deaths.Location = new Point(margin, this.Size.Height - button_decrease_deaths.Height - margin);
            button_reset_deaths.Location = new Point(button_decrease_deaths.Location.X + button_decrease_deaths.Width + margin, this.Size.Height - button_reset_deaths.Height - margin);
            button_increase_deaths.Location = new Point(button_reset_deaths.Location.X + button_reset_deaths.Width + margin, this.Size.Height - button_increase_deaths.Height - margin);

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
            timer_update.Tick -= this.checkForEmulator;
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

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Form_about().ShowDialog();
        }
    }
}
