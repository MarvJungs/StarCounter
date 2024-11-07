using LiveSplit_Sync_Console;

namespace StarCounter
{
    public partial class Starcounter : Form
    {
        readonly int addrMarioAction = 0x33B17C;
        readonly int[] victoryAction = { 0x1302, 0x1303, 0x1307 };
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
            bool success = int.TryParse(label_amountStars.Text, out int amountStars);
            if (!success)
            {
                MessageBox.Show("Couldn't read Starnumber", null, MessageBoxButtons.CancelTryContinue, MessageBoxIcon.Error);
                return;
            }

            _prevMarioAction = _currentMarioAction;
            _currentMarioAction = processManager.ReadMemory((nint)(processManager.GetBaseAddress().ToInt64() + addrMarioAction));
            if (victoryAction.Contains<int>(_currentMarioAction) && _prevMarioAction != _currentMarioAction)
            {
                amountStars++;
                label_amountStars.Text = amountStars.ToString();
            }

        }
    }
}
