using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_CalculatorApp
{
    class CalculatorState
    {
        public const int BACKSPACE = 0;
        public const int DIGIT = 1;
        public const int OP = 2;
        public const int CALCULATION = 3;
        public const int SPECIAL_OP = 4;
        public const int CLEAR_EVERYTHING = 5;
        public const int CLEAR = 6;
        protected static string operand1 = "0";
        protected static string operand2 = "0";
        protected static string op = "";
        protected static string result;
        protected static bool period1 = false;
        protected static bool period2 = false;
        protected static bool isOperand1Complete = false;
        protected static bool isOperand2Complete = false;
        protected static bool isCalculationComplete = false;
        static private CalculatorState cal = new CalculatorState();
        static private DigitState digit = new DigitState();
        static private OperatorState opr = new OperatorState();
        static private CalculationState cs = new CalculationState();
        static private SpecialOperationState sop = new SpecialOperationState();
        static private BackspaceState back = new BackspaceState();
        static private ClearEverythingState ces = new ClearEverythingState();
        static private ClearState clear = new ClearState();
        protected static string error = "";
        protected static string tempHistory;

        public static CalculatorState getInstance() { return cal; }
        public CalculatorState nextState(int state, string input)
        {
            switch (state)
            {
                case 0:
                    back.enter();
                    cal = back;
                    return cal;
                case 1:
                    digit.enter(input);
                    cal = digit;
                    return cal;
                case 2:
                    opr.enter(input);
                    cal = opr;
                    return cal;
                case 3:
                    cs.enter();
                    cal = cs;
                    return cal;
                case 4:
                    sop.enter(input);
                    cal = sop;
                    return cal;
                case 5:
                    ces.enter();
                    cal = ces;
                    return cal;
                case 6:
                    clear.enter();
                    cal = clear;
                    return cal;
                default:
                    return cal;
            }
        }
        public String display()
        {
            if (error != "") {
                string mess = error;
                reset();
                return mess;
            }
            error = "";
            if (isCalculationComplete) {
                return tempHistory;
            }
            else if (isOperand2Complete)
            {
                return $"{Convert.ToString(Convert.ToDouble(operand1))} {op} {Convert.ToString(Convert.ToDouble(operand2))}";
            }
            else return $"{Convert.ToString(Convert.ToDouble(operand1))} {op}";
        }
        public String clearScreen() => "";
        public virtual void enter(String input) { }
        public virtual void enter() { }
        protected void reset() {
            error = "";
            operand1 = "0";
            operand2 = "0";
            op = "";
            isOperand1Complete = false;
            isOperand2Complete = false;
            isCalculationComplete = false;
            period1 = false;
            period2 = false;
        }
    }
}
