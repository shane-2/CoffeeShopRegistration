using System;
using System.Collections.Generic;

namespace CoffeeShopRegistration.Models;

public partial class Item
{
    public int Id { get; set; }

    public string? ItemName { get; set; }

    public string? Description { get; set; }

    public string? Category { get; set; }

    public decimal? Price { get; set; }

    
}
