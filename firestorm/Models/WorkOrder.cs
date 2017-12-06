﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace firestorm.Models
{
    [Table("WorkOrder")]
    public class WorkOrder
    {
        [Key]
        public int OrderID { get; set; }
        public decimal Discount { get; set; }

        [ForeignKey("Company")]
        public virtual int CompanyID { get; set; }
        public virtual Company Company { get; set; }

        public string Comments { get; set; }
    }
}