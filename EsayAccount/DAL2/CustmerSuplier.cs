﻿using System;
using System.Collections.Generic;

namespace EsayAccount.DAL2
{
    public partial class CustmerSuplier
    {
        public CustmerSuplier()
        {
            Invoice = new HashSet<Invoice>();
        }

        public int Id { get; set; }
        public int Code { get; set; }
        public int? IsType { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string Tel1 { get; set; }
        public string Tel2 { get; set; }
        public bool? IsDeleat { get; set; }
        public bool? IsActive { get; set; }
        public int? AccountCode { get; set; }

        public ICollection<Invoice> Invoice { get; set; }
    }
}
