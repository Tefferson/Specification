using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specification
{
    public class DirectSpecification<T> : ISpecification<T>
    {
        private Func<T, bool> expression;
        public DirectSpecification(Func<T, bool> expression)
        {
            if (expression == null)
                throw new ArgumentNullException();
            this.expression = expression;
        }

        public bool IsSatisfiedBy(T o)
        {
            return this.expression(o);
        }
    }
}
