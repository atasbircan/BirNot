using BirNotAPI.DTOs;
using BirNotAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BirNotAPI.Extensions
{
    public static class NotExtensions
    {
        public static GetNotDTO ToGetNotDTO(this Not not)
        {
            return new GetNotDTO()
            {
                Id = not.Id,
                Baslik = not.Baslik,
                Icerik = not.Icerik,
                SonDegistirilme = not.SonDegistirilme
            };
        }
    }
}