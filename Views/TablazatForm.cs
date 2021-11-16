using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tapanyagok.Models;
using Tapanyagok.Presenters;
using Tapanyagok.ViewInterfaces;

namespace Tapanyagok.Views
{
    public partial class TablazatForm : Form, ITablazatView
    {
        private TablazatPresenter presenter;
        // Oldaltördelés
        private int pageCount;
        private int sortIndex;

        public TablazatForm()
        {
            InitializeComponent();
            presenter = new TablazatPresenter(this);
            Init();
        }

        public void Init()
        {
            pageNumber = 1;
            itemsPerPage = 25;
            sortBy = "Id";
            sortIndex = 0;
            ascending = true;
        }

        public BindingList<tapanyag> bindingList
        {
            get => (BindingList<tapanyag>)dataGridView1.DataSource;
            set => dataGridView1.DataSource = value;
        }
        public int pageNumber { get; set; }
        public int itemsPerPage { get; set; }
        public string search { get => keresestoolStripTextBox.Text; }
        public string sortBy { get; set; }
        public bool ascending { get; set; }
        public int totalItems
        {
            set
            {
                pageCount = (value - 1) / itemsPerPage + 1;
                PageLabel.Text = pageNumber.ToString() + "/" + pageCount.ToString();
                TotalItemLabel.Text = "Összesen: " + value;
            }
        }

        private void TablazatPresenter_Load(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void KeresestoolStripButton_Click(object sender, EventArgs e)
        {
            presenter.LoadData();
        }

        private void mentestoolStripButton_Click(object sender, EventArgs e)
        {
            presenter.Save();
        }

        private void UjtoolStripButton_Click(object sender, EventArgs e)
        {
            NewDGRow();
        }

        private void TorlesoolStripButton1_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                var sorIndex = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[sorIndex].Selected = true;
            }
            DelDGRow();
        }

        private void FirstButton_Click(object sender, EventArgs e)
        {
            pageNumber = 1;
            presenter.LoadData();
        }

        private void PrevButton_Click(object sender, EventArgs e)
        {
            if (pageNumber > 1)
            {
                pageNumber--;
                presenter.LoadData();
            }
        }

        private void NextButton_Click(object sender, EventArgs e)
        {
            if (pageNumber < pageCount)
            {
                pageNumber++;
                presenter.LoadData();
            }
        }

        private void LastButton_Click(object sender, EventArgs e)
        {
            pageNumber = pageCount;
            presenter.LoadData();
        }

        private void dataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (sortIndex == e.ColumnIndex)
            {
                ascending = !ascending;
            }
            switch (e.ColumnIndex)
            {
                case 1:
                    sortBy = "nev";
                    break;
                case 2:
                    sortBy = "energia";
                    break;
                case 3:
                    sortBy = "feherje";
                    break;
                case 4:
                    sortBy = "nev";
                    break;
                case 5:
                    sortBy = "zsir";
                    break;
                case 6:
                    sortBy = "szenhidrat";
                    break;
                default:
                    break;
            }

            sortIndex = e.ColumnIndex;

            presenter.LoadData();
        }

        private void NewDGRow()
        {
            using (var szerkForm = new TapanyagForm())
            {
                DialogResult dr = szerkForm.ShowDialog(this);
                if (dr == DialogResult.OK)
                {
                    try
                    {
                        presenter.Add(szerkForm.tapanyag);
                        szerkForm.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Hiba", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
            }
        }

        private void EditDGRow(int index)
        {
            var tapanyag = (tapanyag)dataGridView1.Rows[index].DataBoundItem;

            if (tapanyag != null)
            {
                using (var szerkForm = new TapanyagForm())
                {
                    szerkForm.tapanyag = tapanyag;
                    DialogResult dr = szerkForm.ShowDialog(this);
                    if (dr == DialogResult.OK)
                    {
                        presenter.Modify(index, szerkForm.tapanyag);
                        szerkForm.Close();
                    }
                }
            }
        }
        private void DelDGRow()
        {
            while (dataGridView1.SelectedRows.Count > 0)
            {
                presenter.Remove(dataGridView1.SelectedRows[0].Index);
            }
        }

        private void SzerkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows != null)
            {
                var sorIndex = dataGridView1.SelectedCells[0].RowIndex;
                dataGridView1.ClearSelection();
                dataGridView1.Rows[sorIndex].Selected = true;
            }

            EditDGRow(dataGridView1.SelectedRows[0].Index);
        }

        private void torlesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DelDGRow();
        }
    }
}
