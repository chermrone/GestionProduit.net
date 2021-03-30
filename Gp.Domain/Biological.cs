using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gp.Domain
{
    public class Biological : Product
    {
        public string Herbs { get; set; }
        public override void GetMyType()
        {
            Console.WriteLine("je suis un poduit biologique");
        }
        public override void GetDetails()
        {
            base.GetDetails();
            Console.WriteLine(Herbs);
        }
    }
}
