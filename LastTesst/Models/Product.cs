using LinqToDB.Mapping;

namespace LastTesst.Models
{
    [Table(Name = "products")]
    public class Product
    {
        [Column("id")]
        public int Id { get; set; }
        
        [Column("style")]
        public string Style { get; set; }
        
        [Column("name")]
        public string Name { get; set; }
        
        [Column("price")]
        public float Price { get; set; }
        
        [Column("discount")]
        public bool Discount { get; set; }
        
        [Column("amount_of_discount")]
        public int Amount_of_discount { get; set; }
        
        [Column("discount_price")]
        public float Discount_price { get; set; }
        
        [Column("image")]
        public string Image { get; set; }
        
        [Column("is_favorite")]
        public bool Is_favourite { get; set; }
        
        [Column("comment_prod")]
        public int Comment { get; set; }
    }
}