using System;
using System.Collections.Generic;
using System.Text;

namespace IteratorsAndComparatorsExercise.Models.Contracts
{
    public interface IListyIterator<T>
    {
        void Create(params T[] args);

        bool Move();

        void Print();

        bool HasNext();
    }
}
