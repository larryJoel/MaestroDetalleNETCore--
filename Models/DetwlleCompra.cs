using System;
using System.Collections.Generic;

namespace MaestroDetalle02.Models;

public partial class DetwlleCompra
{
    public int IdDetalleCompra { get; set; }

    public int? IdCompra { get; set; }

    public string? Producto { get; set; }

    public decimal? Precio { get; set; }

    public decimal? Cantidad { get; set; }

    public decimal? Total { get; set; }

    public virtual Compra? IdCompraNavigation { get; set; }
}
