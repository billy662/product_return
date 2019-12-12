using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product_Return
{
    public class Record
    {
        public String invoiceID { get; set; }
        public String brand { get; set; }
        public String pid { get; set; }
        public String shortCode { get; set; }
        public String color { get; set; }
        public String size { get; set; }
        public int quantity { get; set; }
        public String price { get; set; }
        public Boolean found { get; set; }
        public Boolean packed { get; set; }

        public Record()
        {

        }
    }
}
