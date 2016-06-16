using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specification.Product
{
    public class PriceBetweenSpec : AndSpecification<Domain.Product>
    {
        public PriceBetweenSpec(decimal leftPrice, decimal rightPrice)
            : base(new DirectSpecification<Domain.Product>(p => p.Price >= leftPrice),
            new DirectSpecification<Domain.Product>(p => p.Price <= rightPrice)) { }
    }
}
