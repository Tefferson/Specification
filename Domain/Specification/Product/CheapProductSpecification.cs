using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specification.Product
{
    public class CheapProductSpecification : ProductSpecification
    {
        private decimal price;
        public CheapProductSpecification(decimal price)
        {
            this.price = price;
        }

        public override bool IsSatisfiedBy(Domain.Product product)
        {
            return product.Price <= price;
        }
    }
}
