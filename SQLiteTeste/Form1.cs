using Microsoft.EntityFrameworkCore;
using SQLiteTeste.Models;
using System.Windows.Forms;

namespace SQLiteTeste
{
    public partial class Form1 : Form
    {
        readonly public DateTime today = DateTime.Now;
        public bool VerifyDate = false;
        private readonly DogTreatmentDbContext _context;
        int index;
        private bool isCellBeingEdited = false;
        int WaterColumnIndex = 1; 
        int WaterDrankColumnIndex = 2; 
        int DateColumnIndex = 3; 

        public Form1(DogTreatmentDbContext context)
        {
            InitializeComponent();
            _context = context;
            LoadWaterData();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadWaterData();
        }

        
        private void LoadWaterData()
        {
            var water = _context.tbWater.ToList();
            dataGridView1.DataSource = water;
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadWaterData();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            CreateWater();
            LoadWaterData();
        }

        private void CreateWater()
        {
            int currentWaterValue = int.Parse(txtWater.Text);
            int sumWaterDrank = CalculateSumWaterDrank(currentWaterValue);

            var newWaterCount = new WaterControl
            {
                Water = int.Parse(txtWater.Text),
                Date = DateTime.Now,
                WaterDrank = sumWaterDrank
            };
            _context.tbWater.Add(newWaterCount);
            _context.SaveChanges();
        }
        private void CreateFood()
        {
            var newFoodCount = new FoodControl
            {
                FoodN = int.Parse(txtfood.Text),
                FoodR = int.Parse(txtFoodR.Text),
                FoodP = int.Parse(txtPremium.Text),
                Chicken = int.Parse(txtChicken.Text),
                Date = DateTime.Now
            };
            _context.tbFood.Add(newFoodCount);
            _context.SaveChanges();
        }

        private List<WaterControl> getAllRecords()
        {
            var records = _context.tbWater.ToList();
            var filter = records.Where(r => r.Date.Date == today.Date).ToList();

            return filter;
        }

        private List<WaterControl> SortingWaterControl()
        {
            var getAll = getAllRecords();
            var sortedByDate = getAll.OrderBy(record => record.Date).ToList();
            return sortedByDate;
        }

        //Water value is the current input Water ....
        private int LastWaterDrankValue()
        {
            var currentValue = SortingWaterControl();
            if (currentValue.Any())
            {
                var lastWaterDrank = SortingWaterControl().Last();
                return lastWaterDrank.WaterDrank;
            }
            return 0;
        }

        private int CalculateSumWaterDrank(int currentWaterDrank)
        {
            var lastWaterDrank = LastWaterDrankValue();
            return lastWaterDrank + currentWaterDrank;
        }

        private int GetRowIdFromDataSource(int rowIndex)
        {
            if (_context.tbWater.Count() > rowIndex)
            {
                var id = _context.tbWater.Skip(rowIndex).First().Id;
                var water = _context.tbWater.Skip(rowIndex).First().Water;
                var date = _context.tbWater.Skip(rowIndex).First().Date;

                return id;
            }
            return -1;
        }

        //Delete methods 
        private int GetRowIdFromSelectedRow(DataGridViewRow selectedRow)
        {
            var rowId = (int)selectedRow.Cells["ID"].Value;
            MessageBox.Show(rowId.ToString());
            return rowId;
        }

        private void DeleteRowFromDataSource(int rowId)
        {
            var rowToDelete = _context.tbWater.FirstOrDefault(item => item.Id == rowId);
            if (rowToDelete != null)
            {
                if (DialogResult.Yes == MessageBox.Show("Do you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning))
                {
                    _context.tbWater.Remove(rowToDelete);
                    _context.SaveChanges();
                }
            }
        }
        private void DeleteSelectedRow()
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];
                int rowId = GetRowIdFromSelectedRow(selectedRow);
                DeleteRowFromDataSource(rowId);
                LoadWaterData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DeleteSelectedRow();
        }

        private void dataGridView1_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            isCellBeingEdited = true;
        }

        private void dataGridView1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            isCellBeingEdited = false;

            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                GetRowIdFromDataSource(e.RowIndex);
                _context.SaveChanges();
            }
        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && (e.ColumnIndex == DateColumnIndex || e.ColumnIndex == WaterColumnIndex))
            {
                DataGridViewRow editedRow = dataGridView1.Rows[e.RowIndex];

                // Get the new Water column value
                int editedWater = (int)editedRow.Cells[WaterColumnIndex].Value;

                // Recalculate the WaterDrank value based on the editedWater
                RecalculateWaterDrank(e.RowIndex, editedWater);

                _context.SaveChanges();
            }
        }

        private void RecalculateWaterDrank(int rowIndex, int editedWater)
        {
            if (rowIndex == 0)
            {
                // If it's the first row, WaterDrank is the same as Water
                dataGridView1.Rows[rowIndex].Cells[WaterDrankColumnIndex].Value = editedWater;
            }
            else
            {
                // Get the previous WaterDrank value
                int previousWaterDrank = (int)dataGridView1.Rows[rowIndex - 1].Cells[WaterDrankColumnIndex].Value;

                // Calculate the new WaterDrank based on the previous WaterDrank and editedWater
                int waterDrank = previousWaterDrank + editedWater;

                // Update the WaterDrank column with the calculated value
                dataGridView1.Rows[rowIndex].Cells[WaterDrankColumnIndex].Value = waterDrank;
            }
        }

        
        private void btnGetList_Click(object sender, EventArgs e)
        {
            getAllRecords();
        }
    }
}