﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entites.Models.Customer
{
    public class OnlineCustomer
    {
        public int Id { get; set; }
        //foreign Key
        public int CustomerId { get; set; }
        public CustomerInfo Customer { get; set; }
        public string IPAddress { get; set; }
        public string Location { get; set; }
        public DateTime LastActivity { get; set; }
        public string LastVisitedPage { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime ModifiedAt { get; set; }
        public bool IsDeleted { get; set; }
    }
}
