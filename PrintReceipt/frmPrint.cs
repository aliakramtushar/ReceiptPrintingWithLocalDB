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
    public partial class frmPrint : Form
    {
        List<Receipt> _list;
        string _total, _cash, _due, _date, _customerName, _customerInformation, _storeName,_print_id,_discount,_SI;
        public frmPrint(List<Receipt> dataSource, string total, string cash, string due, string date, string customerName, string customerInformation, string print_id, string storeName,string SI, string discount)
        {
            InitializeComponent();
            _list = dataSource;
            _total = total;
            _due = due;
            _cash = cash;
            _date = date;
            _customerName = customerName;
            _customerInformation = customerInformation;
            _print_id = print_id;
            _storeName = storeName;
            _discount = discount;
            _SI = SI;
        }

        private void frmPrint_Load(object sender, EventArgs e)
        {
            ReceiptBindingSource.DataSource = _list;
            Microsoft.Reporting.WinForms.ReportParameter[] para = new Microsoft.Reporting.WinForms.ReportParameter[]
            {

                new Microsoft.Reporting.WinForms.ReportParameter("pTotal",_total),
                new Microsoft.Reporting.WinForms.ReportParameter("pCash",_cash),
                new Microsoft.Reporting.WinForms.ReportParameter("pDue",_due),
                new Microsoft.Reporting.WinForms.ReportParameter("pDate",_date),
                new Microsoft.Reporting.WinForms.ReportParameter("pCustomerName",_customerName),
                new Microsoft.Reporting.WinForms.ReportParameter("pCustomerInformation",_customerInformation),
                new Microsoft.Reporting.WinForms.ReportParameter("pPrintID",_print_id),
                new Microsoft.Reporting.WinForms.ReportParameter("pDiscount",_discount),                   
                new Microsoft.Reporting.WinForms.ReportParameter("pStoreName",_storeName),
                new Microsoft.Reporting.WinForms.ReportParameter("pSI",_SI)
            };
            this.reportViewer.LocalReport.SetParameters(para);
            this.reportViewer.RefreshReport();
        }
    }
}
