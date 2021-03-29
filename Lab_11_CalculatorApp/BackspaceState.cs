using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_CalculatorApp
{
    class BackspaceState: CalculatorState
    {
        public void enter() {
            backspace();
        }
        protected void backspace() {
            if (!isOperand1Complete && Convert.ToDouble(operand1) == 0)
            {
                return;
            }
            else if (!isOperand1Complete && Convert.ToDouble(operand1) != 0)
            {
                if (operand1.Length == 1)
                {
                    operand1 = "0";
                }
                else operand1 = operand1.Substring(0, operand1.Length - 1);
            }
            else if (isOperand2Complete && Convert.ToDouble(operand2) == 0) {
                return;
            }
            else if (isOperand2Complete && Convert.ToDouble(operand2) != 0)
            {
                if (operand2.Length == 1)
                {
                    operand2 = "0";
                }
                else operand2 = operand2.Substring(0, operand2.Length - 1);
            }
        }
    }
}
