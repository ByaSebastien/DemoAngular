using BLLFactorial;
using System.Numerics;

namespace WinFormsFactorial
{
    public partial class factorialForm : Form
    {
        public factorialForm()
        {
            InitializeComponent();
        }

        private void calculButton_Click(object sender, EventArgs e)
        {   
            BigInteger resultat = Factorial.Calculate(nombreNumericUpDown.Value);
            resultatTextBox.Text = resultat.ToString("N0");
        }
    }
}