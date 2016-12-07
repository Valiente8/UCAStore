using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UCAStore.Models
{
    public class Category
    {
        public int Id { get; set; }
        [DisplayName("Nombre de la categoría")]
        [Required(ErrorMessage = "Es requerido ingresar el nombre de la categoría")]
        [StringLength(50, MinimumLength = 4, ErrorMessage = "El nombre de la categoría debe tener al menos 5 caracteres")]
        public string Name { get; set; }

        public virtual ICollection<Product> Products { get; set; }

    }
}