using System;
using System.Collections.Generic;

namespace EsayAccount.DAL2
{
    public partial class Product
    {
        public Product()
        {
            UnitProduct = new HashSet<UnitProduct>();
        }

        public int IdProduct { get; set; }
        public int CodeProduct { get; set; }
        public string NameProduct { get; set; }
        public double? Qyt { get; set; }
        public bool? IsDeleat { get; set; }
        public bool? IsActive { get; set; }
        public int? IsType { get; set; }
        public int? CodeCategory { get; set; }
        public byte[] Img { get; set; }
        public int? CodeBranch { get; set; }
        public int? CodeStore { get; set; }
        public double? Discount { get; set; }
        public double? Tax { get; set; }

        public Branch CodeBranchNavigation { get; set; }
        public Category CodeCategoryNavigation { get; set; }
        public Store CodeStoreNavigation { get; set; }
        public ICollection<UnitProduct> UnitProduct { get; set; }
    }
}
