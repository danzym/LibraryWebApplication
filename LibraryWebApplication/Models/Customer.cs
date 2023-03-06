using System;
using System.Collections.Generic;

namespace LibraryWebApplication.Models;

public partial class Customer
{
    public int Id { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? PhoneNumber { get; set; }

    public string Email { get; set; } = null!;

    public string Address { get; set; } = null!;

    public virtual ICollection<Order> Orders { get; } = new List<Order>();
}
