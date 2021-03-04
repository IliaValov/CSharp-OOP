using System;
using System.Collections.Generic;
using System.Text;

namespace _06_StrategyPattern.Contracts
{
    public interface IPerson<Person> : IComparable<Person>
    {
    }
}
