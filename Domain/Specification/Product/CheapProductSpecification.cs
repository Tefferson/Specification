using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specification.Product
{
    public class CheapProductSpecification : DirectSpecification<Domain.Product>
    {
        public CheapProductSpecification(decimal price)
            : base(p => p.Price <= price) { }
    }
}
