using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintReceipt
{
    public partial class MainUI : Form
    {
        int order = 1;
        double total = 0;
        public string temp;
        public int tempForCheck;
        Print_dbDataContext db = new Print_dbDataContext();
        public MainUI()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void btbAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtProductName.Text))
            {
                MessageBox.Show("Please Enter The Product Name");

            }
            if (string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
                MessageBox.Show("Please Enter the Quantity they wanted");

            }
            if (string.IsNullOrWhiteSpace(txtPrice.Text))
            {
                MessageBox.Show("Please Enter The Unit Price");

            }
            if (!string.IsNullOrEmpty(txtProductName.Text) && !string.IsNullOrEmpty(txtPrice.Text) && !string.IsNullOrEmpty(txtQuantity.Text))
            {
                Receipt obj = new Receipt() { Id = order++, ProductName = txtProductName.Text, Price = Convert.ToDouble(txtPrice.Text), Quantity = Convert.ToInt32(txtQuantity.Text), CustomerName = txtCustomerName.Text, CustomerInformation = txtCustomerInformation.Text };
                total += obj.Price * obj.Quantity;

                receiptBindingSource.Add(obj);
                receiptBindingSource.MoveLast();
                txtProductName.Text = string.Empty;
                txtPrice.Text = string.Empty;
                txtQuantity.Text = string.Empty;
                txtCustomerTotal.Text = string.Format("{0}", total);                                          
            }
            btnPrint.Visible = true;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            receiptBindingSource.DataSource = new List<Receipt>();
            comboBox.Items.Add("Chandpur Electric Co.");
            comboBox.Items.Add("M. R. TRADERS");          
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Receipt obj = receiptBindingSource.Current as Receipt;
            if(obj==null)
            {
                MessageBox.Show("Please select any product you want to delete");
            }
            else
            {
                total -= obj.Price * obj.Quantity;
                txtCustomerTotal.Text = string.Format("{0}", total);
                receiptBindingSource.RemoveCurrent();
            }
            
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(txtCustomerName.Text))
            {
                MessageBox.Show("Please Enter The Customer Name");

            }
            if (string.IsNullOrWhiteSpace(txtCash.Text))
            {
                MessageBox.Show("Please Enter The Paid Amount");
                txtCash.Text = Convert.ToString(0);
            }
            if (string.IsNullOrWhiteSpace(txtDiscount.Text))
            {

                txtDiscount.Text = Convert.ToString(0);

            }

            else
            {
                print_information pi = new print_information();
                pi.customer_name = txtCustomerName.Text;
                pi.information = txtCustomerInformation.Text;
                pi.total_amount = Convert.ToDecimal(txtCustomerTotal.Text) - Convert.ToDecimal(txtDiscount.Text);
                pi.paid_amount = Convert.ToDecimal(txtCash.Text);
                pi.due_amount = Convert.ToDecimal(txtDue.Text);
                //pi.due_amount = Convert.ToDecimal(txtCustomerTotal.Text) - Convert.ToDecimal(txtCash.Text);
                pi.date = dateTimePicker.Value;
                db.print_informations.InsertOnSubmit(pi);
                db.SubmitChanges();

                var result = (from t in db.print_informations
                              orderby t.id descending
                              select t.id).First();

               
                labeltemp.Text = comboBox.Text;


                if (labeltemp.Text == "Chandpur Electric Co.")
                {
                    lblSI.Text = "A-Z Electric & Electronics Market, 135, Nawabpur Road, Dhaka-1100";
                }
                if (labeltemp.Text == "M. R. TRADERS")
                {
                    lblSI.Text = "Mohon Electric Market,135, Nawabpur Road, Dhaka-1100";
                }


                using (frmPrint frm = new frmPrint(receiptBindingSource.DataSource as List<Receipt>, string.Format("{0}", total), string.Format("{0}", txtCash.Text), string.Format("{0:0.00}", Convert.ToDouble(txtDue.Text)), DateTime.Now.ToString("dd/MM/yyyy"), this.txtCustomerName.Text, this.txtCustomerInformation.Text, result.ToString(), this.labeltemp.Text, this.lblSI.Text, string.Format("{0}", txtDiscount.Text)))
                {
                    frm.ShowDialog();

                }
            }
            
        }

        private void btnCustomerView_Click(object sender, EventArgs e)
        {
            DetailsUI frm = new DetailsUI();
            frm.Show();
        }

        private void txtCash_TextChanged(object sender, EventArgs e)
        {
            txtDiscount.Text = null;

                if (string.IsNullOrWhiteSpace(txtCash.Text))
                {
                    txtDue.Text = (Convert.ToDecimal(txtCustomerTotal.Text) - Convert.ToDecimal(0)).ToString();

                }
                else
                {
                    txtDue.Text = (Convert.ToDecimal(txtCustomerTotal.Text) - Convert.ToDecimal(txtCash.Text)).ToString();
                }

       
        }

        private void txtDiscount_TextChanged(object sender, EventArgs e)
        {
           
            if (string.IsNullOrWhiteSpace(txtDiscount.Text))
            {
                txtDue.Text = (Convert.ToDecimal(txtCustomerTotal.Text) - Convert.ToDecimal(0)).ToString();

            }
            else
            {
                txtDue.Text = (Convert.ToDecimal(txtCustomerTotal.Text) - Convert.ToDecimal(txtCash.Text) - Convert.ToDecimal(txtDiscount.Text)).ToString();                
            }                 

        }

        private void txtDue_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(txtProductName.Text) && !string.IsNullOrWhiteSpace(txtPrice.Text) && !string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
            }
        }

        private void txtPrice_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtProductName.Text) && !string.IsNullOrWhiteSpace(txtPrice.Text) && !string.IsNullOrWhiteSpace(txtQuantity.Text))
            {
            }
        }

        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCustomerTotal_TextChanged(object sender, EventArgs e)
        {

        }

      
        private void all_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar) || (e.KeyChar == (char)Keys.Back)))
                e.Handled = true;
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainUI frmNew = new MainUI();
            frmNew.Show();
            
        }
       
    }
}
