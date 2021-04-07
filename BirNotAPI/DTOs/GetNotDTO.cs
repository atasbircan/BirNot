using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirNotAPI.DTOs
{
    public class GetNotDTO
    {
        public int Id { get; set; }

        public string Baslik { get; set; }

        public string Icerik { get; set; }

        public DateTime SonDegistirilme { get; set; }
    }
}