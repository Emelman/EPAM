using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    public interface ISeries<T>
    {
        T GetCurrent();
        bool MoveNext();
        void Reset();
    }
}
