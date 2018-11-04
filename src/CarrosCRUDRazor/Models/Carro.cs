using System;

namespace CarrosCRUDRazor.Models
{
    public class Carro
    {
        public int Id { get; set; }
        public string Modelo { get; set; }
        public string Marca { get; set; }
        public DateTime Ano { get; set; }
        public string cor { get; set; }
        public decimal valor { get; set; }

    }
    
}