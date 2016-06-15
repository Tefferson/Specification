using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Specification
{
    public interface ISpecification<T>
    {
        bool IsSatisfiedBy(T o);
    }
}
