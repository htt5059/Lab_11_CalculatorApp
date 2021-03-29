using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_CalculatorApp
{
    class CalculatorState
    {
        public const int DIGIT = 1;
        public const int OP = 2;
        public const int CALCULATION = 3;
        public const int SPECIAL_OP = 4;
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
        static private SpecialOperation sop = new SpecialOperation();
        protected static string tempHistory;

        public static CalculatorState getInstance() { return cal; }
        public CalculatorState nextState(int state, string input)
        {
            switch (state)
            {
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
                default:
                    cs.enter();
                    cal = cs;
                    return cal;
            }
        }
        public String display()
        {
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
    }
}
