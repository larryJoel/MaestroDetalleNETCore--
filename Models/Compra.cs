using System;
using System.Collections.Generic;

namespace MaestroDetalle02.Models;

public partial class Compra
{
    public int IdCompra { get; set; }

    public string? NumeroDocumento { get; set; }

    public string? RazonSocial { get; set; }

    public decimal? Total { get; set; }

    public virtual ICollection<DetwlleCompra> DetwlleCompras { get; set;} = new List<DetwlleCompra>();
}
