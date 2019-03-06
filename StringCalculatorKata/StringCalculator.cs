using System;

namespace StringCalculatorKata
{
    public class StringCalculator
    {
        public int Add(string v)
        {
            if (v == "")
                return 0;
            return int.Parse(v);
        }
    }
}
