using System;
using System.Linq;
using LinqToDB.Mapping;
using Newtonsoft.Json;
namespace LastTesst.Models

{
    [Table(Name = "users")]
    public class User
    {
        //[Column("id")]
        //public int Id { get; set; }

        [Column("name")]
        public string Name { get; set; }

        [Column("nickname")]
        public string Nickname { get; set; }

        [Column("email")]
        public string Email { get; set; }

        [Column("password")]
        public string Password { get; set; }

        [Column("phone")]
        public string Phone { get; set; }
        
        [Column("image")]
        public string Image { get; set; }
        
        [Column("products")] 
        public int[] Products { get; set; }
    }
}