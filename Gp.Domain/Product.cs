using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gp.Domain
{
    
    public class Product : Concept
    {
        
        public int ProductId { get; set; }
        [Required(ErrorMessage ="Nom Requie")]
        public string Name { get; set; }
        [Range(0, int.MaxValue), Column("Quantite")]
        public int Quantity { get; set; }
        public double Price { get; set; }
        [NotMapped]
        public string ImageUrl { get; set; }
        [StringLength(500), MaxLength(450), MinLength(20, ErrorMessage = "la langueur min est 20")]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }
        [DataType(DataType.Date)]
        public DateTime DataProd { get; set; }
       // [ForeignKey("Category")]
        public int CategoryKey { get; set; }
        //public int CategoryId { get; set; } //==> CategoryId
        [ForeignKey("CategoryKey")]
        public virtual Category Category { get; set; } // => clé Category_CategoryId
        public virtual ICollection<Provider> Providers { get; set; }
        public Product()
        {

        }

        public Product(string name, int quantity, float price, string description, DateTime dataProd)
        {
            Name = name;
            Quantity = quantity;
            Price = price;
            Description = description;
            DataProd = dataProd;
        }

        public override void GetDetails()
        {
            Console.WriteLine($"[{Name},{Description},{Price},{DataProd}]");
        }



        //on utilise virtual pour dire que cette methode est redif dans la classe fille meme si la var qui reference l'obj est de type classe mere avec l'utilisation de override fel classe fille
        public virtual void GetMyType()
        {
            Console.WriteLine("je suis un produit");
        }
    }
}
