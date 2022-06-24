namespace WinFormsAppOrloge
{
    public partial class HorlogeForm : Form
    {
        public HorlogeForm()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStartStop.Text = "Start";
            btnStartStop.Click += Start;
        }
        private void Start(object sender, EventArgs e)
        {
            btnStartStop.Text = "Stop";
            btnStartStop.Click -= Start;
            btnStartStop.Click += Stop;
            tmrWatch.Enabled = true;
            tmrWatch_Tick(tmrWatch, null);
        }
        private void Stop(object sender, EventArgs e)
        {
            btnStartStop.Text = "Start";
            btnStartStop.Click -= Stop;
            btnStartStop.Click += Start;
            tmrWatch.Enabled = false;
        }

        private void tmrWatch_Tick(object sender, EventArgs e)
        {
            txtWatch.Text = DateTime.Now.ToLongTimeString();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            TextBox myTextBox = sender as TextBox;
            MessageBox.Show(myTextBox?.Name);
        }

        private void HorlogeForm_MouseMove(object sender, MouseEventArgs e)
        {
            textBox1.Text = $"{e.X} , {e.Y}";
            textBox2.Text = e.Location.ToString();  
        }
    }
}