using System;
using System.Collections.Generic;

namespace EFCoreDBFirstFluentAPI.Models
{
    public partial class Biography
    {
        public int Id { get; set; }
        public string Biography1 { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; } = null!;
        public string Nationality { get; set; } = null!;
        public int AuthorId { get; set; }

        public virtual Author Author { get; set; } = null!;
    }
}
