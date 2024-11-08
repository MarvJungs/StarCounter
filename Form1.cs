using LiveSplit_Sync_Console;

namespace StarCounter
{
    public partial class Starcounter : Form
    {
        readonly int addrMarioAction = 0x33B17C;

        readonly int[] victoryAction = { 0x1303, 0x1904 };
        readonly int deathAction = 0x1929;

        readonly int timeToSleep = 100;
        
        readonly ProcessManager processManager = new ProcessManager();

        private int _prevMarioAction = 0;
        private int _currentMarioAction = 0;

        public Starcounter()
        {
            InitializeComponent();

            timer_update.Interval = timeToSleep;
            timer_update.Tick += timer_update_Tick;
            timer_update.Start();
        }

        private void timer_update_Tick(object sender, EventArgs e)
        {
            bool success_starcount = int.TryParse(label_amountStars.Text, out int amountStars);
            bool success_deathcount = int.TryParse(label_amountDeaths.Text, out int amountDeaths);
            if (!success_starcount || !success_deathcount)
            {
                MessageBox.Show("Couldn't read Starnumber or Deathcount", null, MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error);
                return;
            }

            _prevMarioAction = _currentMarioAction;
            _currentMarioAction = processManager.ReadMemory((nint)(processManager.GetBaseAddress().ToInt64() + addrMarioAction));
            if (victoryAction.Contains<int>(_currentMarioAction) && _prevMarioAction != _currentMarioAction)
            {
                amountStars++;
                label_amountStars.Text = amountStars.ToString();
            }
            else if (_currentMarioAction == deathAction && _prevMarioAction != _currentMarioAction)
            {
                amountDeaths++;
                label_amountDeaths.Text = amountDeaths.ToString();
            }

        }
    }
}
