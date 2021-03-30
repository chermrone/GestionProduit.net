using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gp.Domain;
using Gp.Service;

namespace Gp.Console
{
    class ProgramFirst
    {
        static void Main(string[] args)
        {
            /*System.Console.WriteLine("Hello 4se6");
            //System.Console.ReadKey();pour empecher le console de se fermer immédiatement aprés l'execution du prog
            int x ; //variable explicitement typée
            var y ="abcd";//variable impl tyée; le type est fixé aprés l'initialisation de var
            //number bool n'acceptent as null pour qu'ils s'annulent il faut un ? aprés le type
            
            ValueChange(out x);//ref passage par address
            System.Console.WriteLine(x);



            //constructeur par def
            Provider test = new Provider();
            test.Password = "123456";
            test.ConfirmPassword="123456";
            
            System.Console.WriteLine(test);
            System.Console.WriteLine(Provider.NbInstance);
            Provider.SetIsApproved(test);
            System.Console.WriteLine(test.GetIsApproved());

            //inisialiseur d'objets
            Provider test1 = new Provider(1, "drgedhr", "1234", new DateTime(1992, 01, 31))
            {
                Username = "lzelflzrgf", IsApproved = true, ConfirmPassword = "zergeth"
            };






            Product p1 = new Product();
            p1.Name = "gra3";
            p1.DataProd = DateTime.Now;//datesysteme
            Product p2 = new Product("bsal",3,450,"si lebsal",new DateTime(2019,03,15));

            Product p3 = new Product { Name = "gares", Price = 4000, Quantity = 10 };
        System.Console.ReadKey();



        }
        /*public static void ValueChange(int myparam)
        {
            Random rnd = new Random();
            myparam += rnd.Next(1, 13);
            System.Console.WriteLine(myparam);
        }
        public static void ValueChange(ref int myparam)
        {
            Random rnd = new Random();
            myparam += rnd.Next(1, 13);
            System.Console.WriteLine(myparam);
      
        public static void ValueChange(out int myparam)
        {
            Random rnd = new Random();
            myparam = 5;
            myparam += rnd.Next(1, 13);
            System.Console.WriteLine(myparam);
        }
    }  */




            //Product p = new Product() { Name = "apple" };
            //Product C = new Chemical() { LabName = "Medical Maghreb Lab", Name = "bsal" };
            //Product B = new Biological() { Herbs = "zergzrgzergh", Name = "Echerichia Coli" };

            //p.GetMyType();
            //C.GetMyType();
            //B.GetMyType();
            //C.GetDetails();
            //B.GetDetails();

            //Product p1 = new Product
            //{
            //    Name = "Tomate",
            //    Description = "produit ztzrgerhe",
            //    Price = 2500,
            //    DataProd = new DateTime(2021, 02, 24)
            //};
            //p1.GetDetails();

            //List<Product> products = new List<Product>();
            //products.Add(p1);
            //products.Add(p);
            //products.Add(B);
            //products.Add(C);

            //ServiceProduct service = new ServiceProduct(products);
            //var list = service.FindProduct("a", delegate (string c)
            //{
            //    List<Product> list1 = new List<Product>();
            //    foreach (var z in products)
            //    {
            //        if (z.Name.StartsWith(c))
            //            list1.Add(z);
            //    }
            //    return list1;
            //});
            //foreach (var item in list)
            //{
            //    item.GetDetails();
            //}

            //list = service.FindProduct("a", (string c) =>
            //{

            //    return products;
            //});
            //foreach (var item in list)
            //{
            //    item.GetDetails();
            //}

            //int a = 51;

            //System.Console.WriteLine(a.IsGreat(115));

            ServiceProduct service = new ServiceProduct(null);
            service.add(new Product() {
                Name = "apple", 
                Category = new Category() { Name = "Fruit" },
                DataProd = DateTime.Now }
            );
            System.Console.WriteLine(   "Base de données créée ");

            service.Show();


            System.Console.ReadKey();
        }
    }
}
