﻿using ETicaretApi.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaretApi.Domain.Entities
{
    public class Order:BaseEntity
    {
        public Guid CustomerId { get; set; }
        public string Adress { get; set; }
        public string Description { get; set; }
        public ICollection<Product> products { get; set; }
        public Customer Customer { get; set; }
    }
}
