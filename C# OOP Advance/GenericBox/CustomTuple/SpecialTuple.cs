using System;
using System.Collections.Generic;
using System.Text;

namespace CustomTuple
{
    public class SpecialTuple<T1, T2 , T3>
    {
        public T1 Item1 { get; set; }
        public T2 Item2 { get; set; }
        public T3 Item3 { get; set; }

        public SpecialTuple(T1 item1, T2 item2 , T3 item3)
        {
            this.Item1 = item1;
            this.Item2 = item2;
            this.Item3 = item3;
        }

        public bool isDrunk()
        {
            if (Item3.Equals("drunk"))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public override string ToString()
        {
            return $"{Item1} -> {Item2} -> {Item3}";
        }
    }
}
