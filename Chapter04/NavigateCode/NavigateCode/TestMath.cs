using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NavigateCode
{
    public class TestMath
    {
        public void SimpleMath()
        {
            int n1 = 10;
            int n2 = 2;

            MathHelper.Calculator calc = new MathHelper.Calculator();

            int added = calc.Add(n1, n2);
            int substracted = calc.Substract(n1, n2);
            int multiplied = calc.Multiply(n1, n2);
            decimal divided = calc.Divide(n1, n2);
        }
    }
}
