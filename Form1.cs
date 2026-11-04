namespace ZHElott
{
    public partial class Form1 : Form
    {
        Models.SeBikestoreContext context = new Models.SeBikestoreContext();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = context.Products.ToList();
            storeBindingSource.DataSource = context.Stores.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var l = from x in context.Stores
                    where x.StoreName.Contains(textBox1.Text)
                    select x;

            storeBindingSource.DataSource = l.ToList();
        }

        private void storeBindingSource_CurrentChanged(object sender, EventArgs e)
        {
            ReadStocks();
        }


        void ReadStocks()
        {
            if (storeBindingSource.Current == null) return;

            Models.Store store = storeBindingSource.Current as Models.Store;

            var l = from x in context.Stocks
                    where x.StoreSk == store.StoreSk
                    select new StockDetail
                    {
                        StoreSk = x.StoreSk,
                        ProductFk = x.ProductFk,
                        ProductName = x.ProductFkNavigation.ProductName,
                        Quantity = x.Quantity,

                    };

            stockDetailBindingSource.DataSource = l.ToList();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (storeBindingSource.Current == null) return;
            if (productBindingSource.Current == null) return;

            Models.Store s = storeBindingSource.Current as Models.Store;
            Models.Product p = productBindingSource.Current as Models.Product;

            Models.Stock newStock = new Models.Stock();
            newStock.StoreSk = s.StoreSk;
            newStock.ProductFk = p.ProductSk;
            newStock.Quantity = (int)numericUpDownQunatity.Value;

            context.Stocks.Add(newStock);

            context.SaveChanges();


            ReadStocks();

            //ToDo: try-catch
        }

        private void button1_Click(object sender, EventArgs e)
        {
            StockDetail sd = stockDetailBindingSource.Current as StockDetail;

            var törlendő = from x in context.Stocks
                           where x.ProductFk == sd.ProductFk
                           &&
                           x.StoreSk == sd.StoreSk
                           select x;

            context.Stocks.RemoveRange(törlendő);

            context.SaveChanges();

            ReadStocks();


        }

        private void buttonAddProduct_Click(object sender, EventArgs e)
        {
            FormAddProduct fap = new FormAddProduct();
            if (fap.ShowDialog() == DialogResult.OK)
            {
                context.Products.Add(fap.NewProduct);
                context.SaveChanges();

                productBindingSource.DataSource = context.Products.ToList();

            }
        }
    }
}
