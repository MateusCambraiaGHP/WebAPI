using System.ComponentModel.DataAnnotations.Schema;

namespace MateusWebAPI.Model
{
    public class Product
    {
        public int Id { get; set; }
     
        [Column(TypeName = "varchar(40)")]
        public string Name { get; set; }

        [Column(TypeName = "varchar(40)")]
        public string Description { get; set; }

        [Column(TypeName = "decimal(10,2)")]
        public double Price { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime CreatedAt{ get; set; }

        [Column(TypeName = "varchar(40)")]
        public string CreatedBy{ get; set; }
    }
}
