namespace arielramos_tabla2.Models
{
    public class Promo
    {
        public int PromoId { get; set; }
        public string? PromoName { get; set;}
        public string? PromoDescription { get;}
        public int Id { get; set; }
        public Burger? MyBurger { get; set; }
    }
}
