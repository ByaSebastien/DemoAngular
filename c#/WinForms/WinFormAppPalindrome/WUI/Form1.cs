using BLL;

namespace WUI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnFileChoices_Click(object sender, EventArgs e)
        {
            OpenFileDialog myOfd = new OpenFileDialog();
            DialogResult result = myOfd.ShowDialog();
            if (result == DialogResult.OK)
            {
                txtFileName.Text = myOfd.FileName;
                List<string> palindromes = BLLPalindrome.SeekPalindrome(myOfd.FileName);
                lstPalindromes.Items.Clear();
                foreach (string palindrome in palindromes)
                {
                    lstPalindromes.Items.Add(palindrome);                     
                }
            }
        }
        private void btnTestAllWords_Click(object sender, EventArgs e)
        {
            lstPalindromesOK.Items.Clear();
            lstPalindromesNOK.Items.Clear();
            foreach(string palindrome in lstPalindromes.Items)
            {
                try
                {
                    bool result = BLLPalindrome.IsPalindrome(palindrome);
                    if (result)
                        lstPalindromesOK.Items.Add(palindrome);
                }
                catch (PalindromeException ex)
                {
                    lstPalindromesNOK.Items.Add(palindrome);
                    MessageBox.Show($"{ex.Message}\nLe mot {ex.Word} n'est pas un palindrome a cause des lettres : {ex.CharAscendent} et : {ex.CharDescendent}");
                }
            }
        }
    }
}