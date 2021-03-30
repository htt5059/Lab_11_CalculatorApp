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
            if (op == "")
            {
                op = input;
                isOperand1Complete = true;
                if (isCalculationComplete)
                {
                    operand2 = "0";
                    isCalculationComplete = false;
                    isOperand2Complete = false;
                }
            }
            else {
                if (!isCalculationComplete && isCalculationButtonPressed)
                    CalculatorState.getInstance().nextState(3, null);
                op = input;
                isOperand1Complete = true;
                if (isCalculationComplete)
                {
                    operand2 = "0";
                    isCalculationComplete = false;
                    isOperand2Complete = false;
                }
            }
        }
    }
}
