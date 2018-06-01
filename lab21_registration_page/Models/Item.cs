//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace lab21_registration_page.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.Data.Entity;

    public partial class Item
    {

        public int ID { get; set; }

        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "A Name is required!")]
        public string Name { get; set; }
        [StringLength(60, MinimumLength = 3)]
        [Required(ErrorMessage = "A Description is required!")]
        public string Description { get; set; }

        [Range(1, 100)]
        [Required(ErrorMessage = "A Quantity is required!")]
        public int? Quantity { get; set; }

        [Range(1, 100)]
        [Required(ErrorMessage = "A Price is required!")]
        public decimal? Price { get; set; }

        [StringLength(60, MinimumLength = 3)]
        public string Image { get; set; }
    }
}
