using Microsoft.Data.SqlClient;
using New.Namespace;

namespace CrudSuppliers
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void byEntityFrameworkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NWindContext dbContext = new NWindContext())
            {
                DgvSuppliersList.DataSource = dbContext.Suppliers.Where(s => s.Id > 10).ToList();
            }
        }

        private void byAdoNetToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string connectionString = "Server=tfnsdotde0400b;Database = Northwind;Trusted_Connection = True;";
            SqlConnection myCn = new SqlConnection(connectionString);
            myCn.Open();
            SqlCommand sql = new SqlCommand();
            sql.CommandText = "SELECT * FROM Suppliers";
            sql.CommandType = System.Data.CommandType.Text;
            sql.Connection = myCn;
            SqlDataReader myReader = sql.ExecuteReader();
            List<Supplier> suppliers = new List<Supplier>();
            while (myReader.Read())
            {
                Supplier supplier = new Supplier();
                supplier.Id = (int)myReader["SupplierID"];
                supplier.CompanyName = (string)myReader[1];
                supplier.ContactName = (string)myReader[2];
                supplier.ContactTitle = (string)myReader["ContactTitle"];
                suppliers.Add(supplier);
            }
            myReader.Close();
            DgvSuppliersList.DataSource= suppliers;
        }

        private void byEFWithScaffoldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (NorthwindContext dbContext = new NorthwindContext())
            {
                DgvSuppliersList.DataSource = dbContext.Suppliers.Where(s => s.SupplierId > 10).ToList();
            }
        }
    }
}