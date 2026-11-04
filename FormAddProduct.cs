using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace ZHElott
{
    public partial class FormAddProduct : Form
    {
        public Models.Product NewProduct = new Models.Product();
        public FormAddProduct()
        {
            InitializeComponent();
        }

        private void FormAddProduct_Load(object sender, EventArgs e)
        {
            productBindingSource.DataSource = NewProduct;
        }
    }
}
