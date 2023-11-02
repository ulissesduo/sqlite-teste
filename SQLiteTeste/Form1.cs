using SQLiteTeste.Models;

namespace SQLiteTeste
{
    public partial class Form1 : Form
    {
        readonly public DateTime today = DateTime.Now;
        public bool VerifyDate = false;
        private readonly DogTreatmentDbContext _context;

        public Form1(DogTreatmentDbContext context)
        {

            InitializeComponent();
            _context = context;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        public bool RecordExistsForToday()
        {
            var teste = _context.tbDogTreatments.Any(t => t.Date.Date == today.Date);
            return teste;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //if (RecordExistsForToday())
            //    Update();
            //else
                CreateProduct();
        }

        private void CreateProduct()
        {
            var newProduct = new DogTreatment
            {
                Food = int.Parse(txtfood.Text),
                MissingFood = int.Parse(txtMissingFood.Text),
                Water = int.Parse(txtWater.Text),
                MissingWater = int.Parse(txtMissingWater.Text),
                Date = DateTime.Now
            };

            _context.tbDogTreatments.Add(newProduct);
            _context.SaveChanges();
        }

        public void Update()
        {

            var existingTreatment = _context.tbDogTreatments.FirstOrDefault(t => t.Date.Date == today.Date);

            if (existingTreatment != null)
            {
                existingTreatment.Food = int.Parse(txtfood.Text);
                existingTreatment.MissingFood = int.Parse(txtMissingFood.Text);
                existingTreatment.Water = int.Parse(txtfood.Text);
                existingTreatment.MissingWater = int.Parse(txtfood.Text);
                _context.SaveChanges();
            }

        }

        private void LoadProducts()
        {

            var products = _context.tbDogTreatments.ToList();
            dataGridView1.DataSource = products;

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            LoadProducts();
        }
    }
}