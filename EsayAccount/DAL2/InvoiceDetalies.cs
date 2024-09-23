using System;
using System.Collections.Generic;

namespace EsayAccount.DAL2
{
    public partial class InvoiceDetalies
    {
        public int Id { get; set; }
        public int? Num { get; set; }
        public int? InvoiceCode { get; set; }
        public int? ProductCode { get; set; }
        public double? Price { get; set; }
        public double? Qyt { get; set; }
        public double? Amount { get; set; }
        public double? Discount { get; set; }
        public double? AmountAfterDiscount { get; set; }
        public double? Tax { get; set; }
        public double? TaxValue { get; set; }
        public double? AmountAfterTax { get; set; }
        public int? UintProductCode { get; set; }
        public double? Factor { get; set; }
        public int? StoreCode { get; set; }

        public Invoice InvoiceCodeNavigation { get; set; }
        public Store StoreCodeNavigation { get; set; }
        public UnitProduct UintProductCodeNavigation { get; set; }
    }
}
