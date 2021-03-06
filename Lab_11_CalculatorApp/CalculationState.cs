using System;

namespace Lab_11_CalculatorApp
{
    class CalculationState : CalculatorState
    {
        public override void enter()
        {
            calculation();
            tempHistory = $"{Convert.ToString(Convert.ToDouble(operand1))} {op} {Convert.ToString(Convert.ToDouble(operand2))} = {result}";
            operand1 = result;
            result = "";
            isCalculationComplete = true;
            isCalculationButtonPressed = false;
        }
        protected void calculation()
        {
            if (op == "")
            {
                result += operand1;
            }
            else if (op != "" && !isCalculationComplete)
            {
                if (!isOperand2Complete)
                {
                    operand2 = operand1;
                    isOperand2Complete = true;
                }
                double o1 = Convert.ToDouble(operand1);
                double o2 = Convert.ToDouble(operand2);
                switch (op)
                {
                    case "+":
                        result = Convert.ToString(o1 + o2);
                        break;
                    case "-":
                        result = Convert.ToString(o1 - o2);
                        break;
                    case "*":
                        result = Convert.ToString(o1 * o2);
                        break;
                    case "/":
                        result = Convert.ToString(o1 / o2);
                        break;
                    default:
                        break;
                }
            }
            else
            {
                double o1 = Convert.ToDouble(operand1);
                double o2 = Convert.ToDouble(operand2);
                switch (op)
                {
                    case "+":
                        result = Convert.ToString(o1 + o2);
                        break;
                    case "-":
                        result = Convert.ToString(o1 - o2);
                        break;
                    case "*":
                        result = Convert.ToString(o1 * o2);
                        break;
                    case "/":
                        if (o2 == 0)
                        {
                            error = "Cannot divide by zero";
                        }
                        else
                        {
                            result = Convert.ToString(o1 / o2);
                        }
                        break;
                    default:
                        break;
                }
            }

        }
    }
}
