﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using TN_Core_Web_App.Infrastructure.SharedKernel;

namespace TN_Core_Web_App.Data.Entities
{
    [Table("Slides")]
    public class Slide : DomainEntity<int>
    {
        [StringLength(250)]
        [Required]
        public string Name { set; get; }

        [StringLength(250)]
        public string Description { set; get; }

        [StringLength(250)]
        [Required]
        public string Image { set; get; }

        [StringLength(250)]
        public string Url { set; get; }

        public int? DisplayOrder { set; get; }

        public bool Status { set; get; }

        public string Content { set; get; }

        [StringLength(25)]
        [Required]
        public string GroupAlias { get; set; }
    }
}
