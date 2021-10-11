using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;
using TN_Core_Web_App.Data.Enums;

namespace TN_Core_Web_App.Application.ViewModels.Blog
{
    public class PageViewModel
    { 
    public int Id { set; get; }
    [Required]
    [MaxLength(256)]
    public string Name { set; get; }

    [MaxLength(256)]
    [Required]
    public string Alias { set; get; }

    public string Content { set; get; }
    public Status Status { set; get; }
    }
}
