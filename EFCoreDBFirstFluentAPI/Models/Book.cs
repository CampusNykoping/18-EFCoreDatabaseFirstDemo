using System;
using System.Collections.Generic;

namespace EFCoreDBFirstFluentAPI.Models
{
    public partial class Book
    {
        public Book()
        {
            Categories = new HashSet<Category>();
        }

        public int Id { get; set; }
        public string Title { get; set; } = null!;
        public int AuthorId { get; set; }

        public virtual Author Author { get; set; } = null!;

        public virtual ICollection<Category> Categories { get; set; }
    }
}
