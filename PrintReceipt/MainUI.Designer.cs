namespace PrintReceipt
{
    partial class MainUI
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.productNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quantityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.totalDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.receiptBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCustomerName = new System.Windows.Forms.Label();
            this.lblCustomerTotal = new System.Windows.Forms.Label();
            this.lblCustomerInformation = new System.Windows.Forms.Label();
            this.lblCash = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtDue = new System.Windows.Forms.TextBox();
            this.txtCash = new System.Windows.Forms.TextBox();
            this.txtCustomerTotal = new System.Windows.Forms.TextBox();
            this.txtCustomerInformation = new System.Windows.Forms.TextBox();
            this.lblDue = new System.Windows.Forms.Label();
            this.lblPrice = new System.Windows.Forms.Label();
            this.lblProductQuantity = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.btbAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.btnCustomerView = new System.Windows.Forms.Button();
            this.labeltemp = new System.Windows.Forms.Label();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.lblSI = new System.Windows.Forms.Label();
            this.btnRefresh = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AutoGenerateColumns = false;
            this.dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.productNameDataGridViewTextBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.quantityDataGridViewTextBoxColumn,
            this.totalDataGridViewTextBoxColumn});
            this.dataGridView.DataSource = this.receiptBindingSource;
            this.dataGridView.Location = new System.Drawing.Point(545, 121);
            this.dataGridView.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(666, 363);
            this.dataGridView.TabIndex = 0;
            // 
            // productNameDataGridViewTextBoxColumn
            // 
            this.productNameDataGridViewTextBoxColumn.DataPropertyName = "ProductName";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.productNameDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle5;
            this.productNameDataGridViewTextBoxColumn.HeaderText = "Product Name";
            this.productNameDataGridViewTextBoxColumn.Name = "productNameDataGridViewTextBoxColumn";
            this.productNameDataGridViewTextBoxColumn.Width = 150;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.priceDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle6;
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price (Per Unit)";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.Width = 200;
            // 
            // quantityDataGridViewTextBoxColumn
            // 
            this.quantityDataGridViewTextBoxColumn.DataPropertyName = "Quantity";
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.quantityDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle7;
            this.quantityDataGridViewTextBoxColumn.HeaderText = "Quantity";
            this.quantityDataGridViewTextBoxColumn.Name = "quantityDataGridViewTextBoxColumn";
            // 
            // totalDataGridViewTextBoxColumn
            // 
            this.totalDataGridViewTextBoxColumn.DataPropertyName = "total";
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.totalDataGridViewTextBoxColumn.DefaultCellStyle = dataGridViewCellStyle8;
            this.totalDataGridViewTextBoxColumn.HeaderText = "Total";
            this.totalDataGridViewTextBoxColumn.Name = "totalDataGridViewTextBoxColumn";
            this.totalDataGridViewTextBoxColumn.ReadOnly = true;
            this.totalDataGridViewTextBoxColumn.Width = 200;
            // 
            // receiptBindingSource
            // 
            this.receiptBindingSource.DataSource = typeof(PrintReceipt.Receipt);
            // 
            // lblCustomerName
            // 
            this.lblCustomerName.AutoSize = true;
            this.lblCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerName.Location = new System.Drawing.Point(113, 231);
            this.lblCustomerName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustomerName.Name = "lblCustomerName";
            this.lblCustomerName.Size = new System.Drawing.Size(62, 18);
            this.lblCustomerName.TabIndex = 1;
            this.lblCustomerName.Text = "Name :";
            // 
            // lblCustomerTotal
            // 
            this.lblCustomerTotal.AutoSize = true;
            this.lblCustomerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerTotal.Location = new System.Drawing.Point(209, 433);
            this.lblCustomerTotal.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustomerTotal.Name = "lblCustomerTotal";
            this.lblCustomerTotal.Size = new System.Drawing.Size(56, 18);
            this.lblCustomerTotal.TabIndex = 3;
            this.lblCustomerTotal.Text = "Total :";
            // 
            // lblCustomerInformation
            // 
            this.lblCustomerInformation.AutoSize = true;
            this.lblCustomerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCustomerInformation.Location = new System.Drawing.Point(72, 296);
            this.lblCustomerInformation.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCustomerInformation.Name = "lblCustomerInformation";
            this.lblCustomerInformation.Size = new System.Drawing.Size(103, 18);
            this.lblCustomerInformation.TabIndex = 4;
            this.lblCustomerInformation.Text = "Information :";
            // 
            // lblCash
            // 
            this.lblCash.AutoSize = true;
            this.lblCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCash.Location = new System.Drawing.Point(208, 476);
            this.lblCash.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblCash.Name = "lblCash";
            this.lblCash.Size = new System.Drawing.Size(57, 18);
            this.lblCash.TabIndex = 5;
            this.lblCash.Text = "Cash :";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(200, 228);
            this.txtCustomerName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(326, 35);
            this.txtCustomerName.TabIndex = 8;
            // 
            // txtDue
            // 
            this.txtDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDue.Location = new System.Drawing.Point(275, 559);
            this.txtDue.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDue.Multiline = true;
            this.txtDue.Name = "txtDue";
            this.txtDue.ReadOnly = true;
            this.txtDue.Size = new System.Drawing.Size(165, 35);
            this.txtDue.TabIndex = 89;
            this.txtDue.TextChanged += new System.EventHandler(this.txtDue_TextChanged);
            // 
            // txtCash
            // 
            this.txtCash.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCash.Location = new System.Drawing.Point(275, 473);
            this.txtCash.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCash.Multiline = true;
            this.txtCash.Name = "txtCash";
            this.txtCash.Size = new System.Drawing.Size(165, 35);
            this.txtCash.TabIndex = 5;
            this.txtCash.TextChanged += new System.EventHandler(this.txtCash_TextChanged);
            this.txtCash.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_KeyPress);
            // 
            // txtCustomerTotal
            // 
            this.txtCustomerTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerTotal.Location = new System.Drawing.Point(275, 430);
            this.txtCustomerTotal.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCustomerTotal.Multiline = true;
            this.txtCustomerTotal.Name = "txtCustomerTotal";
            this.txtCustomerTotal.ReadOnly = true;
            this.txtCustomerTotal.Size = new System.Drawing.Size(165, 35);
            this.txtCustomerTotal.TabIndex = 10;
            this.txtCustomerTotal.TextChanged += new System.EventHandler(this.txtCustomerTotal_TextChanged);
            // 
            // txtCustomerInformation
            // 
            this.txtCustomerInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerInformation.Location = new System.Drawing.Point(200, 293);
            this.txtCustomerInformation.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtCustomerInformation.Multiline = true;
            this.txtCustomerInformation.Name = "txtCustomerInformation";
            this.txtCustomerInformation.Size = new System.Drawing.Size(327, 35);
            this.txtCustomerInformation.TabIndex = 9;
            // 
            // lblDue
            // 
            this.lblDue.AutoSize = true;
            this.lblDue.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDue.Location = new System.Drawing.Point(217, 562);
            this.lblDue.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDue.Name = "lblDue";
            this.lblDue.Size = new System.Drawing.Size(48, 18);
            this.lblDue.TabIndex = 12;
            this.lblDue.Text = "Due :";
            this.lblDue.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblPrice
            // 
            this.lblPrice.AutoSize = true;
            this.lblPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrice.Location = new System.Drawing.Point(913, 549);
            this.lblPrice.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblPrice.Name = "lblPrice";
            this.lblPrice.Size = new System.Drawing.Size(52, 16);
            this.lblPrice.TabIndex = 13;
            this.lblPrice.Text = "Price :";
            // 
            // lblProductQuantity
            // 
            this.lblProductQuantity.AutoSize = true;
            this.lblProductQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductQuantity.Location = new System.Drawing.Point(552, 554);
            this.lblProductQuantity.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProductQuantity.Name = "lblProductQuantity";
            this.lblProductQuantity.Size = new System.Drawing.Size(72, 16);
            this.lblProductQuantity.TabIndex = 14;
            this.lblProductQuantity.Text = "Quantity :";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(542, 506);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(114, 16);
            this.lblProductName.TabIndex = 15;
            this.lblProductName.Text = "Product Name :";
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(975, 544);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtPrice.Multiline = true;
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(236, 30);
            this.txtPrice.TabIndex = 3;
            this.txtPrice.TextChanged += new System.EventHandler(this.txtPrice_TextChanged);
            this.txtPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_KeyPress);
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(654, 544);
            this.txtQuantity.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtQuantity.Multiline = true;
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(236, 30);
            this.txtQuantity.TabIndex = 2;
            this.txtQuantity.TextChanged += new System.EventHandler(this.txtQuantity_TextChanged);
            this.txtQuantity.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_KeyPress);
            // 
            // txtProductName
            // 
            this.txtProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductName.Location = new System.Drawing.Point(670, 501);
            this.txtProductName.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtProductName.Multiline = true;
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(541, 30);
            this.txtProductName.TabIndex = 1;
            this.txtProductName.TextChanged += new System.EventHandler(this.txtProductName_TextChanged);
            // 
            // btbAdd
            // 
            this.btbAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btbAdd.Location = new System.Drawing.Point(654, 590);
            this.btbAdd.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btbAdd.Name = "btbAdd";
            this.btbAdd.Size = new System.Drawing.Size(150, 69);
            this.btbAdd.TabIndex = 4;
            this.btbAdd.Text = "Add";
            this.btbAdd.UseVisualStyleBackColor = false;
            this.btbAdd.Click += new System.EventHandler(this.btbAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.Red;
            this.btnDelete.Location = new System.Drawing.Point(815, 590);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(150, 69);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.BackColor = System.Drawing.Color.Yellow;
            this.btnPrint.Location = new System.Drawing.Point(975, 590);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(150, 69);
            this.btnPrint.TabIndex = 10;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Visible = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(901, 49);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(310, 24);
            this.dateTimePicker.TabIndex = 22;
            // 
            // comboBox
            // 
            this.comboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox.ForeColor = System.Drawing.SystemColors.InfoText;
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Location = new System.Drawing.Point(132, 32);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(363, 41);
            this.comboBox.TabIndex = 7;
            this.comboBox.Text = "Chandpur Electric Co.";
            // 
            // btnCustomerView
            // 
            this.btnCustomerView.BackColor = System.Drawing.SystemColors.Info;
            this.btnCustomerView.Location = new System.Drawing.Point(749, 19);
            this.btnCustomerView.Name = "btnCustomerView";
            this.btnCustomerView.Size = new System.Drawing.Size(101, 75);
            this.btnCustomerView.TabIndex = 11;
            this.btnCustomerView.Text = "Go to Customer Details";
            this.btnCustomerView.UseVisualStyleBackColor = false;
            this.btnCustomerView.Click += new System.EventHandler(this.btnCustomerView_Click);
            // 
            // labeltemp
            // 
            this.labeltemp.AutoSize = true;
            this.labeltemp.ForeColor = System.Drawing.Color.Gainsboro;
            this.labeltemp.Location = new System.Drawing.Point(83, 366);
            this.labeltemp.Name = "labeltemp";
            this.labeltemp.Size = new System.Drawing.Size(0, 18);
            this.labeltemp.TabIndex = 28;
            this.labeltemp.Visible = false;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(180, 528);
            this.lblDiscount.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(85, 18);
            this.lblDiscount.TabIndex = 90;
            this.lblDiscount.Text = "Discount :";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(275, 516);
            this.txtDiscount.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.txtDiscount.Multiline = true;
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(165, 35);
            this.txtDiscount.TabIndex = 6;
            this.txtDiscount.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            this.txtDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.all_KeyPress);
            // 
            // lblSI
            // 
            this.lblSI.AutoSize = true;
            this.lblSI.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblSI.Location = new System.Drawing.Point(77, 351);
            this.lblSI.Name = "lblSI";
            this.lblSI.Size = new System.Drawing.Size(0, 18);
            this.lblSI.TabIndex = 92;
            this.lblSI.Visible = false;
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.btnRefresh.Location = new System.Drawing.Point(642, 19);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(101, 75);
            this.btnRefresh.TabIndex = 93;
            this.btnRefresh.Text = "New Bill";
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.lblSI);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.lblDiscount);
            this.Controls.Add(this.labeltemp);
            this.Controls.Add(this.btnCustomerView);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btbAdd);
            this.Controls.Add(this.txtProductName);
            this.Controls.Add(this.txtQuantity);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.lblProductName);
            this.Controls.Add(this.lblProductQuantity);
            this.Controls.Add(this.lblPrice);
            this.Controls.Add(this.lblDue);
            this.Controls.Add(this.txtCustomerInformation);
            this.Controls.Add(this.txtCustomerTotal);
            this.Controls.Add(this.txtCash);
            this.Controls.Add(this.txtDue);
            this.Controls.Add(this.txtCustomerName);
            this.Controls.Add(this.lblCash);
            this.Controls.Add(this.lblCustomerInformation);
            this.Controls.Add(this.lblCustomerTotal);
            this.Controls.Add(this.lblCustomerName);
            this.Controls.Add(this.dataGridView);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(5, 4, 5, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Print Form";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.receiptBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.BindingSource receiptBindingSource;
        private System.Windows.Forms.Label lblCustomerName;
        private System.Windows.Forms.Label lblCustomerTotal;
        private System.Windows.Forms.Label lblCustomerInformation;
        private System.Windows.Forms.Label lblCash;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtDue;
        private System.Windows.Forms.TextBox txtCash;
        private System.Windows.Forms.TextBox txtCustomerTotal;
        private System.Windows.Forms.TextBox txtCustomerInformation;
        private System.Windows.Forms.Label lblDue;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.Label lblProductQuantity;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.Button btbAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.Button btnCustomerView;
        private System.Windows.Forms.Label labeltemp;
        private System.Windows.Forms.DataGridViewTextBoxColumn productNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn quantityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn totalDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label lblSI;
        private System.Windows.Forms.Button btnRefresh;
    }
}

