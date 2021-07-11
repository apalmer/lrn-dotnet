using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lib
{
    public interface IPriorityQueue
    {
        Boolean IsEmpty();
        void InsertWithPriority(int priority, object value);
        object RemoveHighestPriority();
        object Peek();
    }
}
