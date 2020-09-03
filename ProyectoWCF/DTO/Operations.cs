namespace Calculadora.Model
{
    public class Operations : IAritmetica
    {

        public Operations(decimal x, decimal y)
        {
            firstNumber = x;
            secoundNumber = y;

        }
        public decimal firstNumber { get; set; }
        public decimal secoundNumber { get; set; }

        private decimal Sum() => firstNumber + secoundNumber;

        private decimal Rest() => firstNumber - secoundNumber;

        private decimal Multiply() => firstNumber * secoundNumber;
        private decimal Divide() => (secoundNumber == 0) ? 0 : (firstNumber / secoundNumber);

        public decimal Calculate(string operation)
        {
            decimal total = 0;
            switch (operation)
            {
                case MathOperation.SUM:
                    total = Sum();
                    break;

                case MathOperation.REST:
                     total = Rest();
                    break;

                case MathOperation.MULTIPLY:
                     total = Multiply();
                    break;

                case MathOperation.DIVISION:
                     total = Divide();
                    break;
                    
            }
            return total;
        }


    }
}
