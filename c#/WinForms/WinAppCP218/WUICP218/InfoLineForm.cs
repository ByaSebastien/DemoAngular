using Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL.Extensions;

namespace WUI
{
    public partial class InfoLineForm : Form
    {
        private Entreprise _Enterprise;
        public Entreprise EnterpriseToChange 
        {
            get 
            {
                return _Enterprise;
            }
            set
            { 
                _Enterprise = value;
            }
        }
        private void Bind(Entreprise enterprise)
        {
            nameTextBox.Text = enterprise.Name;
            addressTextBox.Text = enterprise.Address;
            cityTextBox.Text = enterprise.City;
            postalCodeTextBox.Text = enterprise.PostalCode;
            naceCodeTextBox.Text = enterprise.NaceCode;
            AssignCheckedLanguage(enterprise.Idiom);
            employeesNumberComboBox.Text = _Enterprise.CountEmployees.ToString();            
            iDToolStripStatusLabel.Text = enterprise.Id.ToString();
        }
        public void AssignCheckedLanguage(Language pIdiom)
        {
            switch (pIdiom)
            {
                case Language.Inconnu:
                    unknowRadioButton.Checked = true;
                    break;
                case Language.Duits:
                    dutchRadioButton.Checked = true;
                    break;
                case Language.Engels:
                    englishRadioButton.Checked = true;
                    break;
                case Language.Frans:
                    frenchRadioButton.Checked = true;
                    break;
                case Language.Nederlands:
                    nederlandsRadioButton.Checked = true;
                    break;
                default:
                    break;
            }
        }
        public InfoLineForm()
        {
            InitializeComponent();
        }
        private void InfoLineForm_Load(object sender, EventArgs e)
        {
            employeesNumberComboBox.DataSource = Enum.GetValues(typeof(EmployeesNumber));
            Bind(_Enterprise);
            confirmButton.Enabled = false;
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            confirmButton.Enabled = true;
        }
        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            confirmButton.Enabled = true;
        }
        private void languageGroupBox_Enter(object sender, EventArgs e)
        {
            confirmButton.Enabled = true;
        }
        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void confirmButton_Click(object sender, EventArgs e)
        {            
            int id = _Enterprise.Id;
            string name = nameTextBox.Text;
            string address = addressTextBox.Text;
            string city = cityTextBox.Text;
            string postalCode = postalCodeTextBox.Text;
            string naceCode = naceCodeTextBox.Text;
            Language idiom = ConvertTextToLanguage();
            EmployeesNumber number = (EmployeesNumber)employeesNumberComboBox.SelectedItem;
            _Enterprise = new Entreprise(id, name, address, postalCode, city, naceCode, idiom, number);
            this.Close();
        }
        private Language ConvertTextToLanguage()
        {
            foreach (Control control in languageGroupBox.Controls)
            {
                RadioButton? button = control as RadioButton;
                if (button is not null && button.Checked)
                    return button.Text.ToEnum(Language.Inconnu);              
            }
            return Language.Inconnu;
        }
    }
}
