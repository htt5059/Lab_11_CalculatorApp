using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_CalculatorApp
{
    class CalculationState: CalculatorState
    {
        public override void enter()
        {
            calculation();
            tempHistory=$"{Convert.ToString(Convert.ToDouble(operand1))} {op} {Convert.ToString(Convert.ToDouble(operand2))} = {result}";
            operand1 = result;
            result = "";
            isCalculationComplete = true;
        }
        protected void calculation()
        {
            if (op == "")
            {
                result += operand1;
            }
            else if (op != "" && !isOperand2Complete)
            {
                operand2 += operand1;
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
                        result = Convert.ToString(o1 / o2);
                        break;
                    default:
                        break;
                }
            }
            
        }
    }
}
