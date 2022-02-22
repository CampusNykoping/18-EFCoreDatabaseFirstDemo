using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDatabaseFirst.Models
{
    public partial class Customer
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50, ErrorMessage = "Max 50 characters allowed")]
        public string FirstName { get; set; } = null!;
        [StringLength(50)]
        public string LastName { get; set; } = null!;
        [StringLength(100)]
        public string Address { get; set; } = null!;
        public DateTime Created { get; set; }
    }
}
