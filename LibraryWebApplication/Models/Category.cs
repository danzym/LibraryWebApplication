using System;
using System.Collections.Generic;

namespace LibraryWebApplication.Models;

public partial class Category
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string Description { get; set; } = null!;

    public virtual ICollection<Product> Products { get; } = new List<Product>();
}
