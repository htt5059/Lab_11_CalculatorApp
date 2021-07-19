using System;

namespace Lab_11_CalculatorApp
{
    class DigitState : CalculatorState
    {
        public override void enter(String input)
        {
            readInput(input);
        }
        protected void readInput(String input)
        {
            if (isCalculationComplete)
            {
                reset();
            }
            if (!isOperand1Complete)
                if (input == "." && !period1)
                {
                    operand1 += input;
                    period1 = true;
                }
                else if (input == "." && period1) return;
                else operand1 += input;
            else
            {
                isOperand2Complete = true;
                if (input == "." && !period2)
                {
                    operand2 += input;
                    period2 = true;
                }
                else if (input == "." && period2) return;
                else operand2 += input;
            }
        }
    }
}
