using System;
using System.Collections.Generic;

namespace EsayAccount.DAL2
{
    public partial class UnitProduct
    {
        public UnitProduct()
        {
            InvoiceDetalies = new HashSet<InvoiceDetalies>();
        }

        public int Id { get; set; }
        public int Code { get; set; }
        public string Barcode { get; set; }
        public double? Factor { get; set; }
        public double? PriceBuy { get; set; }
        public double? PriceSales { get; set; }
        public int? ProductCode { get; set; }
        public int? UintNameCode { get; set; }

        public Product ProductCodeNavigation { get; set; }
        public UnitName UintNameCodeNavigation { get; set; }
        public ICollection<InvoiceDetalies> InvoiceDetalies { get; set; }
    }
}
