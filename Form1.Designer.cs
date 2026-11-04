namespace ZHElott
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            storeBindingSource = new BindingSource(components);
            listBox2 = new ListBox();
            productBindingSource = new BindingSource(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dataGridView1 = new DataGridView();
            storeSkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productFkDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            productNameDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            quantityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stockDetailBindingSource = new BindingSource(components);
            numericUpDownQunatity = new NumericUpDown();
            buttonAdd = new Button();
            button1 = new Button();
            buttonAddProduct = new Button();
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)stockDetailBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQunatity).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.DataSource = storeBindingSource;
            listBox1.DisplayMember = "StoreName";
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(33, 68);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(201, 324);
            listBox1.TabIndex = 0;
            // 
            // storeBindingSource
            // 
            storeBindingSource.DataSource = typeof(Models.Store);
            storeBindingSource.CurrentChanged += storeBindingSource_CurrentChanged;
            // 
            // listBox2
            // 
            listBox2.DataSource = productBindingSource;
            listBox2.DisplayMember = "ProductName";
            listBox2.FormattingEnabled = true;
            listBox2.Location = new Point(797, 68);
            listBox2.Name = "listBox2";
            listBox2.Size = new Size(201, 324);
            listBox2.TabIndex = 0;
            // 
            // productBindingSource
            // 
            productBindingSource.DataSource = typeof(Models.Product);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(35, 31);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(199, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.DataBindings.Add(new Binding("Text", productBindingSource, "ListPrice", true));
            textBox2.Location = new Point(1021, 68);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(171, 27);
            textBox2.TabIndex = 2;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { storeSkDataGridViewTextBoxColumn, productFkDataGridViewTextBoxColumn, productNameDataGridViewTextBoxColumn, quantityDataGridViewTextBoxColumn });
            dataGridView1.DataSource = stockDetailBindingSource;
            dataGridView1.Location = new Point(259, 68);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(380, 324);
            dataGridView1.TabIndex = 3;
            // 
            // storeSkDataGridViewTextBoxColumn
            // 
            storeSkDataGridViewTextBoxColumn.DataPropertyName = "StoreSk";
            storeSkDataGridViewTextBoxColumn.HeaderText = "StoreSk";
            storeSkDataGridViewTextBoxColumn.MinimumWidth = 6;
            storeSkDataGridViewTextBoxColumn.Name = "storeSkDataGridViewTextBoxColumn";
            storeSkDataGridViewTextBoxColumn.ReadOnly = true;
            storeSkDataGridViewTextBoxColumn.Visible = false;
            storeSkDataGridViewTextBoxColumn.Width = 125;
            // 
            // productFkDataGridViewTextBoxColumn
            // 
            productFkDataGridViewTextBoxColumn.DataPropertyName = "ProductFk";
            productFkDataGridViewTextBoxColumn.HeaderText = "ProductFk";
            productFkDataGridViewTextBoxColumn.MinimumWidth = 6;
            productFkDataGridViewTextBoxColumn.Name = "productFkDataGridViewTextBoxColumn";
            productFkDataGridViewTextBoxColumn.ReadOnly = true;
            productFkDataGridViewTextBoxColumn.Visible = false;
            productFkDataGridViewTextBoxColumn.Width = 125;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            productNameDataGridViewTextBoxColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            productNameDataGridViewTextBoxColumn.HeaderText = "ProductName";
            productNameDataGridViewTextBoxColumn.MinimumWidth = 6;
            productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            productNameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            quantityDataGridViewTextBoxColumn.MinimumWidth = 6;
            quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            quantityDataGridViewTextBoxColumn.ReadOnly = true;
            quantityDataGridViewTextBoxColumn.Width = 125;
            // 
            // stockDetailBindingSource
            // 
            stockDetailBindingSource.DataSource = typeof(StockDetail);
            // 
            // numericUpDownQunatity
            // 
            numericUpDownQunatity.Location = new Point(675, 129);
            numericUpDownQunatity.Name = "numericUpDownQunatity";
            numericUpDownQunatity.Size = new Size(98, 27);
            numericUpDownQunatity.TabIndex = 4;
            numericUpDownQunatity.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // buttonAdd
            // 
            buttonAdd.Location = new Point(675, 162);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(94, 29);
            buttonAdd.TabIndex = 5;
            buttonAdd.Text = "&Add";
            buttonAdd.UseVisualStyleBackColor = true;
            buttonAdd.Click += buttonAdd_Click;
            // 
            // button1
            // 
            button1.Location = new Point(675, 197);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 6;
            button1.Text = "&Delete";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // buttonAddProduct
            // 
            buttonAddProduct.Location = new Point(927, 398);
            buttonAddProduct.Name = "buttonAddProduct";
            buttonAddProduct.Size = new Size(71, 29);
            buttonAddProduct.TabIndex = 7;
            buttonAddProduct.Text = "&Add";
            buttonAddProduct.UseVisualStyleBackColor = true;
            buttonAddProduct.Click += buttonAddProduct_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1177, 450);
            Controls.Add(buttonAddProduct);
            Controls.Add(button1);
            Controls.Add(buttonAdd);
            Controls.Add(numericUpDownQunatity);
            Controls.Add(dataGridView1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(listBox2);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)productBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)stockDetailBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQunatity).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private ListBox listBox2;
        private TextBox textBox1;
        private BindingSource storeBindingSource;
        private BindingSource productBindingSource;
        private TextBox textBox2;
        private DataGridView dataGridView1;
        private BindingSource stockDetailBindingSource;
        private DataGridViewTextBoxColumn storeSkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productFkDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private NumericUpDown numericUpDownQunatity;
        private Button buttonAdd;
        private Button button1;
        private Button buttonAddProduct;
    }
}
