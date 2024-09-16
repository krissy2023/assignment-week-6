﻿using System;
using System.Collections.Generic;

namespace Week6.Server.Models;

public partial class Store
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public virtual ICollection<Sale> Sales { get; set; } = new List<Sale>();
}
