using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace UCAStore.Models
{
    public class Image
    {
        public int ImageId { get; set; }
        [StringLength(255)]
        public string ImageName { get; set; }
        public Filetype Filetype { get; set; }
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}