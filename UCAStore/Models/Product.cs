using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UCAStore.Models
{
    public class Product
    {
        public int   Id { get; set; }
        [DisplayName("Nombre del producto")]
        [Required(ErrorMessage ="Es requerido ingresar el nombre del producto")]
        [StringLength(70,MinimumLength=3, ErrorMessage ="El nombre del producto debe tener al menos 3 caracteres")]
        public string Name { get; set; }

        [DataType(DataType.MultilineText)]
        [StringLength(200, MinimumLength = 10, ErrorMessage = "La descripción debe tener entre 10 y 200 caracteres")]
        public string Description { get; set; }

        public string Color { get; set; }

        [Required(ErrorMessage ="El peso del producto es requerido")]
        public decimal Weight { get; set; }

        [DisplayName("URL de la imagen")]
        [DataType(DataType.ImageUrl)]
        [Required(ErrorMessage = "Debe agregar una imagen para el producto")]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage ="El precio del producto es requerido")]
        [Range(0.1, 100000, ErrorMessage ="El precio debe estar entre 0.1 y 100000")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }

        [DisplayName("Categoría")]
        public int? CategoryId { get; set; }
        public virtual Category Category { get; set;}

        public virtual ICollection<Image> Images { get; set; }

    }
}