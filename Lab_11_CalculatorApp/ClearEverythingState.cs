namespace Lab_11_CalculatorApp
{
    class ClearEverythingState : CalculatorState
    {
        public void enter()
        {
            clearEverything();
        }
        protected void clearEverything()
        {
            if (isOperand1Complete && isOperand2Complete && isCalculationComplete) reset();
            else if (!isOperand1Complete) operand1 = "0";
            else operand2 = "0";
        }
    }
}
