using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WUI;

namespace WinFormsAppSupplier.WUI
{
    public partial class IndexForm : Form
    {
        private IList<Supplier> _Suppliers;
        public int Index;
        public IndexForm()
        {
            InitializeComponent();
        }

        private void IndexForm_Load(object sender, EventArgs e)
        {
            ISupplierRepository supplierRepository = new SupplierRepository();
            _Suppliers = (IList<Supplier>)supplierRepository.GetAll();
            suppliersDataGridView.DataSource = _Suppliers;
            CheckSuppliersCountToSwitchEnabledListButton();
            suppliersDataGridView.Rows[0].Selected = false;
        }
        private void addButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            Supplier supplier = new Supplier 
            {
                CompanyName = companyNameTextBox.Text,
                ContactName = contactTitleTextBox.Text,
                ContactTitle = contactTitleTextBox.Text,
                Address = addressTextBox.Text,
                City = cityTextBox.Text,
                Region = regionTextBox.Text,
                PostalCode = postalCodeTextBox.Text,
                Country = countryTextBox.Text,
                Phone = phoneTextBox.Text,
                Fax = faxTextBox.Text,
                HomePage = homePageTextBox.Text
            };
            ISupplierRepository supplierRepository = new SupplierRepository();
            supplierRepository.Add(supplier);
            _Suppliers = (IList<Supplier>)supplierRepository.GetAll();
            suppliersDataGridView.DataSource = _Suppliers;

            suppliersDataGridView.Rows[0].Selected = false;
            ClearTextBoxs();
            if (modifyButton.Enabled)
                EnabledSwitchModifyAndRemoveButton();
            CheckSuppliersCountToSwitchEnabledListButton();
            Cursor.Current = Cursors.Default;
        }

        private void modifyButton_Click(object sender, EventArgs e)
        {
            confirmModifyButton.Visible = true;
            cancelModifyButton.Visible = true;
            companyNameTextBox.Text = _Suppliers[Index].CompanyName;
            ContactNameTextBox.Text = _Suppliers[Index].ContactName;
            contactTitleLabel.Text = _Suppliers[Index].ContactTitle;
            addressTextBox.Text = _Suppliers[Index].Address;
            cityTextBox.Text = _Suppliers[Index].City;
            regionTextBox.Text = _Suppliers[Index].Region;
            postalCodeTextBox.Text = _Suppliers[Index].PostalCode;
            countryTextBox.Text = _Suppliers[Index].Country;
            phoneTextBox.Text = _Suppliers[Index].Phone;
            faxTextBox.Text = _Suppliers[Index].Fax;
            homePageTextBox.Text = _Suppliers[Index].HomePage;
        }
        private void removeButton_Click(object sender, EventArgs e)
        {
            ISupplierRepository supplierRepository = new SupplierRepository();
            supplierRepository.Delete(_Suppliers[Index].Id);
            _Suppliers = (IList<Supplier>)supplierRepository.GetAll();
            suppliersDataGridView.DataSource = _Suppliers;
            suppliersDataGridView.Rows[0].Selected = false;
            ClearTextBoxs();
            if (modifyButton.Enabled)
                EnabledSwitchModifyAndRemoveButton();
            CheckSuppliersCountToSwitchEnabledListButton();
        }
        private void suppliersDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            Index = e.RowIndex;
            if (e.RowIndex >= 0)
            {
                suppliersDataGridView.Rows[e.RowIndex].Selected = true;
                if (!modifyButton.Enabled)
                    EnabledSwitchModifyAndRemoveButton();
            }
        }
        private void confirmModifyButton_Click(object sender, EventArgs e)
        {
            confirmModifyButton.Visible = false;
            cancelModifyButton.Visible = false;
            Supplier supplier = new Supplier
            {
                Id = _Suppliers[Index].Id,
                CompanyName = companyNameTextBox.Text,
                ContactName = contactTitleTextBox.Text,
                ContactTitle = contactTitleTextBox.Text,
                Address = addressTextBox.Text,
                City = cityTextBox.Text,
                Region = regionTextBox.Text,
                PostalCode = postalCodeTextBox.Text,
                Country = countryTextBox.Text,
                Phone = phoneTextBox.Text,
                Fax = faxTextBox.Text,
                HomePage = homePageTextBox.Text
            };
            ISupplierRepository supplierRepository = new SupplierRepository();
            supplierRepository.Update(supplier);
            _Suppliers = (IList<Supplier>)supplierRepository.GetAll();
            suppliersDataGridView.DataSource = _Suppliers;
            suppliersDataGridView.Rows[0].Selected = false;
            ClearTextBoxs();
            if (modifyButton.Enabled)
                EnabledSwitchModifyAndRemoveButton();
        }
        /// <summary>
        /// Clear All textboxs and checkbox
        /// </summary>
        private void ClearTextBoxs()
        {
            companyNameTextBox.Text = null;
            ContactNameTextBox.Text = null;
            contactTitleLabel.Text = null;
            addressTextBox.Text = null;
            cityTextBox.Text = null;
            regionTextBox.Text = null;
            postalCodeTextBox.Text = null;
            countryTextBox.Text = null;
            phoneTextBox.Text = null;
            faxTextBox.Text = null;
            homePageTextBox.Text = null;
        }
        /// <summary>
        /// Enable or disable Modify and Remove buttons
        /// </summary>
        private void EnabledSwitchModifyAndRemoveButton()
        {
            if (modifyButton.Enabled && removeButton.Enabled)
            {
                modifyButton.Enabled = false;
                modifyButton.BackColor = Color.Silver;
                removeButton.Enabled = false;
                removeButton.BackColor = Color.Silver;
            }
            else
            {
                modifyButton.Enabled = true;
                modifyButton.BackColor = Color.DarkCyan;
                removeButton.Enabled = true;
                removeButton.BackColor = Color.DarkCyan;
            }
        }
        /// <summary>
        /// Check if suppliers count is more than 0 to enable list button
        /// </summary>
        private void CheckSuppliersCountToSwitchEnabledListButton()
        {
            if (_Suppliers.Count > 0)
            {
                if (!listButton.Enabled)
                {
                    listButton.Enabled = true;
                    listButton.BackColor = Color.DarkCyan;
                }
            }
            else
            {
                if (listButton.Enabled)
                {
                    listButton.Enabled = false;
                    listButton.BackColor = Color.Silver;
                }
            }
        }

    }
}
