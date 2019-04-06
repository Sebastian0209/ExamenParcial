using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC.Models
{

    public enum TipoUnidad
    {
        Botella,
        Metro,
        Litro,
        caja
    } 

      public enum TipoEstado
    {
        Activo,
        Inactivo
    }


    public class Product
    {

        [Key]
        public int ProductoId { get; set; }

        [Required]

        public string  Nombre { get; set; }

        
        public decimal Precio { get; set; }

        
        public int Cantidad { get; set; }

        [Required]

        public TipoUnidad Quantity { get; set; }

        [Required]
        public TipoEstado Estado { get; set; }


    }
}