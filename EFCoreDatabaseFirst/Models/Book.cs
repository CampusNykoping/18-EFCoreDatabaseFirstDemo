using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDatabaseFirst.Models
{
    [Index(nameof(AuthorId), Name = "IX_Books_AuthorId")]
    public partial class Book
    {
        public Book()
        {
            Categories = new HashSet<Category>();
        }

        [Key]
        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty("Books")]
        public virtual Author Author { get; set; } = null!;

        [ForeignKey("BooksId")]
        [InverseProperty(nameof(Category.Books))]
        public virtual ICollection<Category> Categories { get; set; }
    }
}
