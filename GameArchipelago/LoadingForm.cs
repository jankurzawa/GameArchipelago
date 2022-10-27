namespace GameArchipelago
{
    public partial class LoadingForm : Form
    {
        private const int Step = 2;
        private const int MaxValue = 100;
        private const int FreezeTime = 1000;

        public LoadingForm()
        {
            InitializeComponent();
            barTimer.Start();
        }

        private void TickTimer(object sender, EventArgs e)
        {
            progBarLoading.Value += Step;
            if (progBarLoading.Value == MaxValue) {
                barTimer.Stop();
                Thread.Sleep(FreezeTime);
                Close(); }
        }
    }
}
