using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDatabaseFirst.Models
{
    public partial class Category
    {
        public Category()
        {
            Books = new HashSet<Book>();
        }

        [Key]
        public int Id { get; set; }
        public string Name { get; set; } = null!;

        [ForeignKey("CategoriesId")]
        [InverseProperty(nameof(Book.Categories))]
        public virtual ICollection<Book> Books { get; set; }
    }
}
