using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace GCD0705.AppDev.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        [DisplayName("Category Name")]
        public string Name { get; set; }
    }
}