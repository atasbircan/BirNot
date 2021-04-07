using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace BirNotAPI.Models
{
    [Table("Notlar")]
    public class Not
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string Baslik { get; set; }

        public string Icerik { get; set; }

        public DateTime SonDegistirilme { get; set; } = DateTime.Now;

        [Required]
        public string YazarId { get; set; }

        [ForeignKey("YazarId")]
        public virtual ApplicationUser Yazar { get; set; }
    }
}