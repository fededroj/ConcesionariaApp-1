using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace ConcesionariaApp.Models
{
    public class AutoMarcaViewModel
    {
        public List<Auto> Autos { get; set; }
        public SelectList Marcas { get; set; }
        public string AutoMarca { get; set; }
        public string SearchString { get; set; }
    }
}