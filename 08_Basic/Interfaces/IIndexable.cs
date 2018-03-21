using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface IIndexable<T> 
    {
        T this[int index] { get; }
    }
}
