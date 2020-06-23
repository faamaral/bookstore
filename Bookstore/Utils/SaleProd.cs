using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Bookstore.Utils
{
    class SaleProd
    {
        private int id_prod { get; set; }
        private string isbn_prod { get; set; }
        private string name_prod { get; set; }
        private int amount_prod { get; set; }
        private decimal price { get; set; }
        public decimal priceTotal_prod {get;set;}
        public decimal priceFinal_prod { get; set; }

        //public decimal _priceTotal
        //{
        //    get { return priceTotal_prod; }
        //    set { this.priceTotal_prod = value; }
        //}
        public void calcPriceTotal(decimal v)
        {
            priceTotal_prod += v;
            //_priceTotal = _priceTotal + v;
        }

        public decimal calcDiscountValue(decimal percent, decimal priceProds)
        {
            decimal p = percent / 100;
            return p * priceProds;
        }
    }
}
