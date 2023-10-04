using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    {
        private int _productId;
        private string _productName;
        private string _manufacturer;
        private int _qunatity;
        public int ProductId
        {
            get { return _productId; }
            set { _productId = value;}
        }
        public string ProductName
        {
            get { return _productName; }
            set { _productName = value; }
        }
        public string Manufacturer
        {
            get { return _manufacturer; }
            set { _manufacturer = value; }
        }
        public int Quantity
        {
            get { return _qunatity; }
            set { _qunatity = value; }
        }
    }
}
