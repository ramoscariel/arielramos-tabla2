using System.ComponentModel.DataAnnotations;

namespace arielramos_tabla2.Models
{
    public class Burger
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public bool WithCheese {  get; set; }
        [Range(0.99,99.99)] public decimal price { get; set; }
        public List<Promo> Promos { get; set; }
    }
}
