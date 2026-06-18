using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ecommerce.DTO
{

    public partial class ProductoDTO
    {
        public int IdProducto { get; set; }

        [Required(ErrorMessage = "Ingrese nombre del producto")]
        public string? Nombre { get; set; }

        [Required(ErrorMessage = "Ingrese nombre del producto")]
        public string? Descripcion { get; set; }

        [Required(ErrorMessage = "Seleccione categoria")]
        public int? IdCategoria { get; set; }

        [Required(ErrorMessage = "Igresar precio del producto")]
        public decimal? Precio { get; set; }

        [Required(ErrorMessage = "Ingrese precio oferta del producto")]
        public decimal? PrecioOferta { get; set; }

        [Required(ErrorMessage = "Ingrese cantidad del producto")]
        public int? Cantidad { get; set; }

        [Required(ErrorMessage = "Ingrese imagen del producto")]
        public string? Imagen { get; set; }

        public DateTime? FechaCreacion { get; set; }

        public virtual CategoriaDTO? IdCategoriaNavigation { get; set; }

    }
}
