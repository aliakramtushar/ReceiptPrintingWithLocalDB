using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintReceipt
{
    public class Receipt
    {
        public int Id { get; set; }
        public string ProductName { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public string CustomerName { get; set; }
        public string CustomerInformation { get; set; }

        public string StoreName { get; set; }
        public double discount { get; set; }
        
        public string total { get { return string.Format("{0}/=", Price * Quantity); } }
        public string SI { get; set; }

    }
}
