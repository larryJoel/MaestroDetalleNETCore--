using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MaestroDetalle02.Models.Viewmodels
{
    public class CompraVM
    {
        public Compra oCompra { get; set; }
        public List<DetwlleCompra> oDetalleCompra { get; set; }
    }
}