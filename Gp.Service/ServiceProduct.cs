using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gp.Domain;
using Gp.Data;

namespace Gp.Service
{
    public class ServiceProduct
    {
        private List<Product> products;
        GpContext context;

        public ServiceProduct(List<Product> products)
        {
            context = new GpContext();
            this.products = products;
            /*FindProducts = delegate (string c)
            {
                List<Product> list = new List<Product>();
                foreach (var p in products)
                {
                    if (p.Name.StartsWith(c))
                        list.Add(p);
                }
                return list;
            };
            ScanProducts = delegate (Category category)
        {
            List<Product> list = new List<Product>();
            foreach (var p in products)
            {
                if (p.Category.Name == category.Name)
                    p.ToString();
            }
        };*/
        }

        /* private List<Product> Find(string c)
         {
             List<Product> list = new List<Product>();
             foreach (var p in products)
             {
                 if (p.Name.StartsWith(c))
                     list.Add(p);
             }
             return list;
         }
         private void Scan(Category category)
         {
             List<Product> list = new List<Product>();
             foreach (var p in products)
             {
                 if (p.Category.Name == category.Name)
                     p.ToString();
             }
         }*/
        //delegate :créer des var ou attributs spécials qui pointes sur ces attrib ou methodes
        //delegate contien une signature de meth qui pointe sur plusieurs meth
        //delegate= pointeur 3la meth

        //declaration de type delegate fiha pointeur qui respecte cette signature
        //public delegate List<Product> Finddelegate(string c);

        //finddelegate = nom de notre type
        //public Finddelegate FindProducts { get; set; }

        // public delegate void Scandelegate(Category category);
        // public Scandelegate ScanProducts { get; set; }

        public List<Product> FindProduct(string c, Func<string, List<Product>> Fd)
        {
            return Fd(c);
        }

        public void ScanProduct(Category c, Action<Category> Sc)
        {
            Sc(c);
        }
        public List<Product> GetProductByName(string name)
        {//type ienumerable interface y'hériti menha el liste
            var query = from p in products
                        where p.Name.Contains(name)
                        select p;
            //bech trajja3 barcha typet lazem ta3mel new 5ater ma 3endou kan objet wa7ed donc bech yefhem li 3andou barhca lazem ta3mel déclaration
            
            return query.ToList();
        }
        public List<Product> GetProductByNameMethode(string name)
        {
           var query= products
                .Where(p => p.Name.Contains(name))
                .Select(p => p)
                .ToList();
            return query ;
        }

        public Product GetFirstProductByNameMethode(string name)
        {
            var query = products
                 .Where(p => p.Name.Contains(name));
            return query.First();
        }
        public Product GetFirstProductByName(string name)
        {
            var query = from p in products
                        where p.Name.Contains(name)
                        select p;

            return query.FirstOrDefault();//bech trajja3 soit awwel valeur wella null kanou de type nullable wella 0 kana type non nullab.
        }

        public Product GetSingleProductByName(string name)
        {
            var query = from p in products
                        where p.Name.Contains(name)
                        select p;

            return query.SingleOrDefault();//single wa9et tebda met2aked elli el requete trajja3 element bark
        }
        public List<Product> GetTakeProductByName(string name)
        {
            var query = from p in products
                        where p.Name.Contains(name)
                        select p;

            return query.Take(5).ToList();//take kif t7ab ta5ou un nbr d'elements
        }
        public IEnumerable<Product> GetSkipProductByName(string name)
        {
            var query = from p in products
                        where p.Name.Contains(name)
                        select p;

            return query.Skip(5);// wa9et t7eb teskipi 5
        }
        // les methodes hadho lkol esmhom meth selection femma .last w .elementadd femma skipwhile........
        
        public double GetAveragePrice()
        {
            return products.Average(p=>p.Price);
        }
        public List<Product> GetProductOrdred()
        {
            var query = from p in products
                        orderby p.Name
                        select p;
            //kan n7eb desc na3mel espace w nekteb descending
            return query.ToList()
;        }
        public List<Product> GetProductOrdredMeth()
        {
            var query = products.OrderBy(p => p.Name);
            return query.ToList();
        }
        public List<Product> GetProductOrdreddescMeth()
        {
            var query = products.OrderByDescending(p => p.Name);
            return query.ToList();
        }
        public IEnumerable<IGrouping<string, Product>> GetProductGroupBy()
        {
            // iGrouping type de dictionnaire ya5ou clé value
    
            var query = from p in products
                        where p.Price > 100
                        group p by p.Name;
            foreach (var group in query)
            {
                Console.WriteLine(group.Key);
                foreach (var product in group)
                {
                    Console.WriteLine(product.ToString());
                }
            }
            return query;
        }
        public IEnumerable<IGrouping<string, Product>> GetProductGroupBy1()
        {
            // iGrouping type de dictionnaire ya5ou clé value

            var query = products
                .Where(p => p.Price > 100)
                .GroupBy(p=>p.Name);
        
            foreach (var group in query)
            {
                Console.WriteLine(group.Key);
                foreach (var product in group)
                {
                    Console.WriteLine(product.ToString());
                }
            }
            return query;
        }
        public void add(Product p)
        {
            context.Products.Add(p);
            context.SaveChanges();
        }

        public void Show()
        {
            foreach (var item in context.Products.ToList())
            {
                Console.WriteLine($"name= {item.Name}, category= {item.Category.Name} ");
            }
         
        }
    }

}
