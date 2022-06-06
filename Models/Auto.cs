using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ConcesionariaApp.Models
{
    public class Auto
    {
        public int Id { get; set; }

        public string Modelo { get; set; }

        public string AñoDelModelo { get; set; }

        public string Marca { get; set; }

        [Range(1, 10000000), DataType(DataType.Currency)]
        [Column(TypeName = "decimal(18, 2)")]
        public decimal PrecioTotal { get; set; }
    }
}
