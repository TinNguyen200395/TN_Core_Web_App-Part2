﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TN_Core_Web_App.Application.ViewModels.System;
using TN_Core_Web_App.Data.Enums;

namespace TN_Core_Web_App.Application.ViewModels.Product
{
    public class BillViewModel
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(256)]
        public string CustomerName { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerAddress { set; get; }

        [Required]
        [MaxLength(50)]
        public string CustomerMobile { set; get; }

        [Required]
        [MaxLength(256)]
        public string CustomerMessage { set; get; }

        public PaymentMethod PaymentMethod { set; get; }

        public BillStatus BillStatus { set; get; }

        public DateTime DateCreated { set; get; }

        public DateTime DateModified { set; get; }

        public Status Status { set; get; }

        public Guid? CustomerId { set; get; }

        public List<BillDetailViewModel> BillDetails { set; get; }
    }
}
