using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public int Factorial(int n)
        {
            int F = 1;
            for (int i = 1; i <= n; i++) F *= i;
            return F;
        }
    }
}
