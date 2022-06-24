using BLL;
using Models;
using WUI;
using System.Linq;
using System.Diagnostics;

namespace WUICP218
{
    public partial class frmMain : Form
    {
        private IList<Entreprise> _Lines = new List<Entreprise>();
        private IList<Entreprise> _ErrorLines = new List<Entreprise>();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            tSSDateLabel.Text = DateTime.Now.ToString();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            tSSDateLabel.Text = DateTime.Now.ToString();
        }

        private void lireFichierCP218ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "csv files |*.csv";
                ofd.Title = "Lire fichier csv";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    this.Cursor = Cursors.WaitCursor;
                    string fileName = ofd.FileName;
                    _Lines = Cp218.GetEnterprise(fileName);
                    //_Lines = RemoveDouble(_Lines);
                    fileLinesDataGridView.DataSource = _Lines;
                    this.Cursor = Cursors.Default;
                }
            }
        }
        private void fileLinesDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (InfoLineForm frm = new InfoLineForm())
            {
                frm.EnterpriseToChange = _Lines[e.RowIndex];
                frm.ShowDialog();
                _Lines[e.RowIndex] = frm.EnterpriseToChange;
                fileLinesDataGridView.Refresh();
            }
        }
        private void errorFileLinesDataGridView_RowHeaderMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            using (InfoLineForm frm = new InfoLineForm())
            {
                frm.EnterpriseToChange = _ErrorLines[e.RowIndex];
                frm.ShowDialog();
                _ErrorLines[e.RowIndex] = frm.EnterpriseToChange;
                for (int currentLine = 0; currentLine < _Lines.Count; currentLine++)
                {
                    if (_Lines[currentLine].Id == frm.EnterpriseToChange.Id && (_Lines[currentLine].Idiom == Language.Inconnu || _Lines[currentLine].CountEmployees == EmployeesNumber.Inconnu))                   
                        _Lines[currentLine] = frm.EnterpriseToChange;
                }
                errorDataGridView.Refresh();
                lenghtErrorDataGridView.Refresh();
            }
        }
        private void mainTabControl_Click(object sender, EventArgs e)
        {
            string tabPageCurrent = mainTabControl.SelectedTab.Name;
            switch (tabPageCurrent)
            {
                case "allTabPage":
                    fileLinesDataGridView.Refresh();
                    break;
                case "errorTabPage":
                    GetErrorEntreprise();
                    break;
                case "lenghtErrorTabPage":
                    GetLenghtErrorEntreprise();
                    break;
                default:
                    MessageBox.Show($"Page inconnue {tabPageCurrent}");
                    break;
            }
        }
        public void GetErrorEntreprise()
        {
            this.Cursor = Cursors.WaitCursor;
            _ErrorLines = _Lines.Where(ent => ent.Idiom == Language.Inconnu).ToList();
            errorDataGridView.DataSource = _ErrorLines;
            this.Cursor = Cursors.Default;
        }
        public void GetLenghtErrorEntreprise()
        {
            this.Cursor = Cursors.WaitCursor;
            _ErrorLines = _Lines.Where(ent => ent.CountEmployees == EmployeesNumber.Inconnu).ToList();
            lenghtErrorDataGridView.DataSource = _ErrorLines;
            this.Cursor = Cursors.Default;
        }
        public IList<Entreprise> RemoveDouble(IList<Entreprise> entreprises)
        {
            int index = 0;
            var _DoubleLines = from line in entreprises
                               group line by line.Id into grp
                               where grp.Count() > 1
                               select new { Key = grp.Key, Data = grp.ToList(), Count = grp.Count() };

            foreach (var item in _DoubleLines)
            {
                for (int verif = 0; verif < item.Data.Count; verif++)
                {
                    if (item.Data[verif].Idiom != Language.Inconnu && item.Data[verif].CountEmployees != EmployeesNumber.Inconnu)
                        index = verif;
                }
                for (int currentLine = 0; currentLine < entreprises.Count; currentLine++)
                {
                    if (item.Data[index].Id == entreprises[currentLine].Id && !item.Data[index].Equals(entreprises[currentLine]))
                    {
                        entreprises.Remove(_Lines[currentLine]);
                    }
                }
            }
            return entreprises;
        }
    }
}