using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gp.Domain
{
    public class Category : Concept
    {
        public int CategoryId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Product> Products { get; set; }

        public override void GetDetails()
        {
            throw new NotImplementedException();
        }
    }
}
