using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_CalculatorApp
{
    class ClearEverythingState: CalculatorState
    {
        public void enter() {
            clearEverything();
        }
        protected void clearEverything() {
            if (!isOperand1Complete)
            {
                operand1 = "0";
            }
            else operand2 = "0";
        }
    }
}
