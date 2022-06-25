using Acme.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ACM.BL
{
    public class Product : EntityBase, ILoggable
    {
        public Product()
        {

        }
        public Product(int productId)
        {
            ProductId = productId;
        }

        public decimal? CurrentPrice { get; set; }
        public string ProductDescription { get; set; }
        public int ProductId { get; private set; }
        private string _productname;
        public string ProductName 
        {
            get
            {
                return _productname.InsertSpaces();
            }
            set {
                _productname = value;
            } 
        }
        public override string ToString() => ProductName;
        public override bool Validate()
        {
            if (string.IsNullOrWhiteSpace(ProductName)) return false;
            if (CurrentPrice == null) return false;
            return true;
        }
        public string log() => $"{ProductName}";
    }
}
