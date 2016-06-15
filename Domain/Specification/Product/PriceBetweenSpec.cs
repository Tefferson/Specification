using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specification.Product
{
    public class PriceBetweenSpec : ProductSpecification 
    {
        private decimal leftPrice;
        private decimal rightPrice;

        public PriceBetweenSpec(decimal leftPrice, decimal rightPrice)
        {
            this.leftPrice = leftPrice;
            this.rightPrice = rightPrice;
        }

        public override bool IsSatisfiedBy(Domain.Product product)
        {
            return product.Price >= leftPrice && product.Price <= rightPrice;
        }
    }
}
