using System;
using System.Collections.Generic;

namespace EFCoreDBFirstFluentAPI.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public string Address { get; set; } = null!;
        public DateTime Created { get; set; }
    }
}
