using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ecommerce.DTO
{
    public class CarritoDTO
    {
        public ProductoDTO? Producto { set; get; }

        public int? Cantidad { set; get; }

        public decimal? Precio { set; get; }

        public decimal? Total { set; get; }

    }
}
