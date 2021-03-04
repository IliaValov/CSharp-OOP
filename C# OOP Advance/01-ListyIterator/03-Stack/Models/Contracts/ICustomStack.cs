using System;
using System.Collections.Generic;
using System.Text;

namespace _03_Stack.Models.Contracts
{
    public interface ICustomStack<T>: IEnumerable<T>
    {
        void Push(params T[] args);

        T Pop();
    }
}
