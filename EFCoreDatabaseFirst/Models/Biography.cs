using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EFCoreDatabaseFirst.Models
{
    [Index(nameof(AuthorId), Name = "IX_Biographies_AuthorId", IsUnique = true)]
    public partial class Biography
    {
        [Key]
        public int Id { get; set; }
        [Column("Biography")]
        public string Biography1 { get; set; } = null!;
        public DateTime DateOfBirth { get; set; }
        public string PlaceOfBirth { get; set; } = null!;
        public string Nationality { get; set; } = null!;
        public int AuthorId { get; set; }

        [ForeignKey(nameof(AuthorId))]
        [InverseProperty("Biography")]
        public virtual Author Author { get; set; } = null!;
    }
}
