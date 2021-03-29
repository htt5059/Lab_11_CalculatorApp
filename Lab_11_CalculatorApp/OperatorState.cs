using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_CalculatorApp
{
    class OperatorState : CalculatorState
    {
        public override void enter(String input)
        {
            readOp(input);
        }
        protected void readOp(String input)
        {
            op = input;
            isOperand1Complete = true;
            if (isCalculationComplete) {
                operand2 = "0";
                isCalculationComplete = false;
                isOperand2Complete = false;
            }
            
        }
    }
}
