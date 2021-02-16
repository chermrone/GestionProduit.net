using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gp.Domain;

namespace Gp.Console
{
    class ProgramFirst
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello 4se6");
            //System.Console.ReadKey();pour empecher le console de se fermer immédiatement aprés l'execution du prog
            int? x = 5; //variable explicitement typée
            var y ="abcd";//variable impl tyée; le type est fixé aprés l'initialisation de var
            //number bool n'acceptent as null pour qu'ils s'annulent il faut un ? aprés le type
            x = null;
            //constructeur par def
            Provider test = new Provider();
            test.ConfirmPassword = "1234";
            System.Console.WriteLine(test.ConfirmPassword);
            System.Console.ReadKey();
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





        }
    }
}
