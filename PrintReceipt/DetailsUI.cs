using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PrintReceipt
{
    public partial class DetailsUI : Form
    {
        Print_dbDataContext db = new Print_dbDataContext();
        int indexrow;
        
        public DetailsUI()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'printItemsDS.print_information' table. You can move, or remove it, as needed.
            LoadCustomerList(); 

        }
   

       private void LoadCustomerList()
       {
           CustomerDataGridView.AutoResizeColumns();
           CustomerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

           CustomerDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

           var vendorinfo = from E in db.print_informations select E;

           CustomerDataGridView.DataSource = vendorinfo;


        }

       //private void vendor_datagridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
       //{
       //    vendor_delete_btn.Visible = true;
       //    vendor_update_btn.Visible = true;
       //    vendor_save_btn.Visible = false;

       //    if (e.RowIndex >= 0)
       //    {
       //        indexrow = e.RowIndex;
       //        DataGridViewRow row = this.vendor_datagridview.Rows[indexrow];

       //        vendor_name_textbox.Text = row.Cells["Name"].Value.ToString();
       //        vendor_address_textbox.Text = row.Cells["Address"].Value.ToString();
       //        vendor_contact_textbox.Text = row.Cells["ContactNumber"].Value.ToString();
       //        vendor_email_textbox.Text = row.Cells["Email"].Value.ToString();
       //        vendor_type_combobox.Text = row.Cells["Type"].Value.ToString();

       //    }
       //}

       //private void vendor_save_btn_Click(object sender, EventArgs e)
       //{
       //    try
       //    {
       //        Vendor vn = new Vendor();
       //        vn.Name = vendor_name_textbox.Text;
       //        vn.Address = vendor_address_textbox.Text;
       //        vn.ContactNumber = vendor_contact_textbox.Text;
       //        vn.Email = vendor_email_textbox.Text;
       //        vn.Type = vendor_type_combobox.SelectedItem.ToString();

       //        db.Vendors.InsertOnSubmit(vn);
       //        db.SubmitChanges();
       //        MessageBox.Show("Data Inserted");
       //        Loadvendorlist();
           
       //    }
       //    catch (Exception es)
       //    {
       //        MessageBox.Show("Error: " + es);

       //    }
       //}

       //private void vendor_update_btn_Click(object sender, EventArgs e)
       //{
       //    try
       //    {
       //        DataGridViewRow updaterow = vendor_datagridview.Rows[indexrow];
       //        updaterow.Cells[1].Value = vendor_name_textbox.Text;
       //        updaterow.Cells[2].Value = vendor_address_textbox.Text;
       //        updaterow.Cells[3].Value = vendor_contact_textbox.Text;
       //        updaterow.Cells[4].Value = vendor_email_textbox.Text;
       //        updaterow.Cells[5].Value = vendor_type_combobox.SelectedItem.ToString();

       //        db.SubmitChanges();

       //        MessageBox.Show("Update Successful");

       //    }
       //    catch (Exception es)
       //    {
       //        MessageBox.Show("Error: " + es);

       //    }
       //}

        private void btnShow_Click(object sender, EventArgs e)
        {

        }

        private void CustomerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //vendor_delete_btn.Visible = true;
            //    vendor_update_btn.Visible = true;
            //    vendor_save_btn.Visible = false;

            if (e.RowIndex >= 0)
            {
                indexrow = e.RowIndex;
                DataGridViewRow row = this.CustomerDataGridView.Rows[indexrow];

                txtName.Text = row.Cells["customer_name"].Value.ToString();
                txtInformation.Text = row.Cells["information"].Value.ToString();
                txtTotal.Text = row.Cells["total_amount"].Value.ToString();
                txtDue.Text = row.Cells["due_amount"].Value.ToString();
                txtPaid.Text = row.Cells["paid_amount"].Value.ToString();
                dateTimePicker1.Value = Convert.ToDateTime(row.Cells["date"].Value.ToString());


            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                DataGridViewRow updaterow = CustomerDataGridView.Rows[indexrow];
                updaterow.Cells[1].Value = txtName.Text;
                updaterow.Cells[6].Value = txtInformation.Text;
                updaterow.Cells[4].Value = Convert.ToDecimal(txtDue.Text);
                updaterow.Cells[3].Value = Convert.ToDecimal(txtPaid.Text);
                updaterow.Cells[2].Value = Convert.ToDecimal(txtTotal.Text);
                updaterow.Cells[5].Value = dateTimePicker1.Value;


                db.SubmitChanges();

                MessageBox.Show("Update Successful");

            }
            catch (Exception es)
            {
                MessageBox.Show("Error: " + es);

            }
        }

        private void txtPaid_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPaid.Text))
            {
                txtDue.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(0));

            }
            else
            {
                txtDue.Text = Convert.ToString(Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(txtPaid.Text));

            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           DataGridViewRow delete_row = CustomerDataGridView.Rows[indexrow];
           db.print_informations.DeleteOnSubmit(db.print_informations.Single(p=>p.id==Convert.ToInt16(delete_row.Cells[0].Value)));
           db.SubmitChanges();
           DetailsUI fr = new DetailsUI();
           fr.Show();
           this.Close();
          // LoadCustomerList();
           
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
           
            //var vendorinfo = from E in db.print_informations where E.id.ToString() == Convert.ToInt16(txtCustomerSearch.Text).ToString() select E;
            var vendorinfo = from E in db.print_informations where E.customer_name ==txtCustomerSearch.Text select E;
            
            CustomerDataGridView.DataSource = vendorinfo;
        }

        private void txtPay_TextChanged(object sender, EventArgs e)
        {
            //if (string.IsNullOrWhiteSpace(txtPay.Text))
            //{
            //    txtDue.Text = (Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(0)).ToString();
            //    txtPaid.Text = (Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(0)).ToString();
            //}
            //else
            //{
            //    txtDue.Text = (Convert.ToDecimal(txtDue.Text) - Convert.ToDecimal(txtPay.Text)).ToString();
            //    txtPaid.Text = (Convert.ToDecimal(txtPaid.Text) + Convert.ToDecimal(txtPay.Text)).ToString();

            //}
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtPay.Text))
            {
                txtDue.Text = (Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(0)).ToString();
                txtPaid.Text = (Convert.ToDecimal(txtTotal.Text) - Convert.ToDecimal(0)).ToString();
            }
            else
            {
                txtDue.Text = (Convert.ToDecimal(txtDue.Text) - Convert.ToDecimal(txtPay.Text)).ToString();
                txtPaid.Text = (Convert.ToDecimal(txtPaid.Text) + Convert.ToDecimal(txtPay.Text)).ToString();

            }

        }

        private void All_Click(object sender, EventArgs e)
        {
            var vendorinfo = from E in db.print_informations  select E;
            CustomerDataGridView.DataSource = vendorinfo;
        }

        private void btnNonPaid_Click(object sender, EventArgs e)
        {
            var vendorinfo = from E in db.print_informations where E.due_amount >0 select E;
            CustomerDataGridView.DataSource = vendorinfo;
        }

        private void btnPaid_Click(object sender, EventArgs e)
        {
            var vendorinfo = from E in db.print_informations where E.due_amount == 0 select E;
            CustomerDataGridView.DataSource = vendorinfo;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //var vendorinfo = from E in db.print_informations where E.customer_name.ToString() == text_customer_name.Text.ToString() select E;
           // CustomerDataGridView.DataSource = vendorinfo;
        }

        private void txtCustomerSearch_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        
    }
}
