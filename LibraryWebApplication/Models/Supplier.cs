using System;
using System.Collections.Generic;

namespace LibraryWebApplication.Models;

public partial class Supplier
{
    public int Id { get; set; }

    public string CompanyName { get; set; } = null!;

    public string PhoneNumber { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? Address { get; set; }

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
