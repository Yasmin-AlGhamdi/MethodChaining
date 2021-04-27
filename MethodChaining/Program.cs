using System;

namespace MethodChaining
{
    class EasyMath
    {
        private int firstValue;
        private int secondValue;

        public EasyMath setFirstOperand(int value)
        {
            this.firstValue = value;
            return this;
        }
        public EasyMath setSecondOperand(int value)
        {
            this.secondValue = value;
            return this;
        }
        public int sum()
        {
            return this.firstValue + this.secondValue;
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            EasyMath em = new EasyMath();
            int result = em.setFirstOperand(50).setSecondOperand(30).sum();
            Console.WriteLine(result);
            Console.ReadKey();
        
        }
    }
}
