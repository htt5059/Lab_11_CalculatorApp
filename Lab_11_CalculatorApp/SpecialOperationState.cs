using System;

namespace Lab_11_CalculatorApp
{
    class SpecialOperationState : CalculatorState
    {
        public override void enter(string input)
        {
            if (isCalculationComplete && isOperand1Complete && isOperand2Complete)
            {
                reset();
            }
            else if (isCalculationComplete)
            {
                operand2 = "0";
                isCalculationComplete = false;
                isOperand2Complete = false;
            }
            switch (input)
            {
                case "+/-":
                    negating();
                    break;
                case "sqrt(x)":
                    sqrt();
                    break;
                case "1/x":
                    inverting();
                    break;
                case "x^2":
                    squaring();
                    break;
                case "%":
                    percenting();
                    break;
                default:
                    break;
            }
        }
        protected void negating()
        {
            if (!isOperand1Complete)
            {
                operand1 = Convert.ToString(Convert.ToDouble(operand1) * (-1));
            }
            else if (!isOperand2Complete)
            {
                operand2 = Convert.ToString(Convert.ToDouble(operand1) * (-1));
                isOperand2Complete = true;
            }
            else
            {
                operand2 = Convert.ToString(Convert.ToDouble(operand2) * (-1));
            }
        }
        protected void sqrt()
        {
            if (!isOperand1Complete)
            {
                if (Convert.ToDouble(operand1) < 0)
                {
                    error = "Invalid input";
                }
                else
                {
                    operand1 = Convert.ToString(Math.Sqrt(Convert.ToDouble(operand1)));
                }
            }
            else if (!isOperand2Complete)
            {
                if (Convert.ToDouble(operand2) < 0)
                {
                    error = "Invalid input";
                }
                else
                {
                    operand2 = Convert.ToString(Math.Sqrt(Convert.ToDouble(operand1)));
                    isOperand2Complete = true;
                }
            }
            else
            {
                if (Convert.ToDouble(operand2) < 0)
                {
                    error = "Invalid input";
                }
                else
                {
                    operand2 = Convert.ToString(Math.Sqrt(Convert.ToDouble(operand2)));
                }
            }
        }
        protected void inverting()
        {
            if (!isOperand1Complete)
            {
                if (Convert.ToDouble(operand1) == 0)
                {
                    error = "Cannot divide by zero";
                }
                else operand1 = Convert.ToString(1 / Convert.ToDouble(operand1));
            }
            else if (!isOperand2Complete)
            {
                operand2 = Convert.ToString(1 / Convert.ToDouble(operand1));
                isOperand2Complete = true;
            }
            else
            {
                if (Convert.ToDouble(operand2) == 0)
                {
                    error = "Cannot divide by zero";
                }
                else
                {
                    operand2 = Convert.ToString(1 / Convert.ToDouble(operand2));
                    isOperand2Complete = true;
                }
            }
        }
        protected void squaring()
        {
            if (!isOperand1Complete)
            {
                operand1 = Convert.ToString(Convert.ToDouble(operand1) * Convert.ToDouble(operand1));
            }
            else if (!isOperand2Complete)
            {
                operand2 = Convert.ToString(Convert.ToDouble(operand1) * Convert.ToDouble(operand1));
                isOperand2Complete = true;
            }
            else
            {
                operand2 = Convert.ToString(Convert.ToDouble(operand2) * Convert.ToDouble(operand2));
                isOperand2Complete = true;
            }
        }
        protected void percenting()
        {
            if (!isOperand1Complete)
            {
                operand1 = Convert.ToString(Convert.ToDouble(operand1) / 100);
            }
            else if (!isOperand2Complete)
            {
                operand2 = Convert.ToString(Convert.ToDouble(operand1) / 100);
                isOperand2Complete = true;
            }
            else
            {
                operand2 = Convert.ToString(Convert.ToDouble(operand2) / 100);
                isOperand2Complete = true;
            }
        }
    }
}
