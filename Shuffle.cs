using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DUL.Utilities
{
    public class Shuffle
    {
        private static Random R = new Random();
        public static T GiveMeOne<T>(params T[] fromThis)
        {
            return fromThis[R.Next(fromThis.Count())];
        }
    }
}
