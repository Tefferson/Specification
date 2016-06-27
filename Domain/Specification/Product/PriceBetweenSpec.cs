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
            : base(p => p.Price >= leftPrice, p => p.Price <= rightPrice) { }
    }
}
