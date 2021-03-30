using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gp.Domain
{
    public class Chemical : Product//Chemical hérite de Product
    {
         public string LabName { get; set; }

        public Adress Adress { get; set; }
        public override void GetMyType()
        {
            Console.WriteLine("je suis un produit chimique");
        }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine(LabName);
        }
    }
}
