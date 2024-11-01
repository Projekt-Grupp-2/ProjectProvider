﻿using System;
using System.Collections.Generic;

namespace ProductProvider.Infrastructure.Entities;

public partial class ColorEntity
{
    public Guid Id { get; set; } = Guid.NewGuid();

    public string? Name { get; set; }

    public string? HexadecimalColor { get; set; }

    public virtual ICollection<WarehouseEntity> Warehouses { get; set; } = new List<WarehouseEntity>();
}
