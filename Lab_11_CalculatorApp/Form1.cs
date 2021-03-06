using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab_11_CalculatorApp
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            Size = new Size(230, 100);
            textBox1.Font = new Font(textBox1.Font.FontFamily, 16);
        }
        //Digit State
        private void Digit0_Button_MouseClick(object sender, MouseEventArgs e)
        {
            string input = Digit0_Button.Text;
            CalculatorState.getInstance().nextState(1, input);
            textBox1.Text = CalculationState.getInstance().display();
        }

        private void Digit1_Button_MouseClick(object sender, MouseEventArgs e)
        {
            string input = Digit1_Button.Text;
            CalculatorState.getInstance().nextState(1, input);
            textBox1.Text = CalculationState.getInstance().display();
        }

        private void Digit2_Button_MouseClick(object sender, MouseEventArgs e)
        {
            string input = Digit2_Button.Text;
            CalculatorState.getInstance().nextState(1, input);
            textBox1.Text = CalculationState.getInstance().display();
        }

        private void Digit3_Button_MouseClick(object sender, MouseEventArgs e)
        {
            string input = Digit3_Button.Text;
            CalculatorState.getInstance().nextState(1, input);
            textBox1.Text = CalculationState.getInstance().display();
        }

        private void Digit4_Button_MouseClick(object sender, MouseEventArgs e)
        {
            string input = Digit4_Button.Text;
            CalculatorState.getInstance().nextState(1, input);
            textBox1.Text = CalculationState.getInstance().display();
        }

        private void Digit5_Button_MouseClick(object sender, MouseEventArgs e)
        {
            string input = Digit5_Button.Text;
            CalculatorState.getInstance().nextState(1, input);
            textBox1.Text = CalculationState.getInstance().display();
        }

        private void Digit6_Button_MouseClick(object sender, MouseEventArgs e)
        {
            string input = Digit6_Button.Text;
            CalculatorState.getInstance().nextState(1, input);
            textBox1.Text = CalculationState.getInstance().display();
        }

        private void Digit7_Button_Click(object sender, EventArgs e)
        {
            string input = Digit7_Button.Text;
            CalculatorState.getInstance().nextState(1, input);
            textBox1.Text = CalculationState.getInstance().clearScreen();
            textBox1.Text = CalculationState.getInstance().display();
        }

        private void Digit8_Button_MouseClick(object sender, MouseEventArgs e)
        {
            string input = Digit8_Button.Text;
            CalculatorState.getInstance().nextState(1, input);
            textBox1.Text = CalculationState.getInstance().display();
        }

        private void Digit9_Button_MouseClick(object sender, MouseEventArgs e)
        {
            string input = Digit9_Button.Text;
            CalculatorState.getInstance().nextState(1, input);
            textBox1.Text = CalculationState.getInstance().display();
        }

        //Operator State
        private void DigitPeriod_Button_MouseClick(object sender, MouseEventArgs e)
        {
            string input = DigitPeriod_Button.Text;
            CalculatorState.getInstance().nextState(1, input);
            textBox1.Text = CalculationState.getInstance().display();
        }

        private void DivButton_MouseClick(object sender, MouseEventArgs e)
        {
            string input = DivButton.Text;
            CalculatorState.getInstance().nextState(2, input);
            textBox1.Text = CalculationState.getInstance().display();
        }

        private void MultiButton_MouseClick(object sender, MouseEventArgs e)
        {
            string input = MultButton.Text;
            CalculatorState.getInstance().nextState(2, input);
            textBox1.Text = CalculationState.getInstance().display();
        }

        private void SubstractButton_MouseClick(object sender, MouseEventArgs e)
        {
            string input = SubstractButton.Text;
            CalculatorState.getInstance().nextState(2, input);
            textBox1.Text = CalculationState.getInstance().display();
        }

        private void AddButton_MouseClick(object sender, MouseEventArgs e)
        {
            string input = AddButton.Text;
            CalculatorState.getInstance().nextState(2, input);
            textBox1.Text = CalculationState.getInstance().display();
        }

        //Calculation State
        private void ComputeButton_MouseClick(object sender, MouseEventArgs e)
        {
            CalculatorState.getInstance().nextState(3, null);
            textBox1.Text = CalculationState.getInstance().display();
        }

        //Special Operation State
        private void NegateButton_MouseClick(object sender, MouseEventArgs e)
        {
            string input = NegateButton.Text;
            CalculatorState.getInstance().nextState(4, input);
            textBox1.Text = SpecialOperationState.getInstance().display();
        }

        private void InverseButton_MouseClick(object sender, MouseEventArgs e)
        {
            string input = InverseButton.Text;
            CalculatorState.getInstance().nextState(4, input);
            textBox1.Text = SpecialOperationState.getInstance().display();
        }

        private void SquareButton_MouseClick(object sender, MouseEventArgs e)
        {
            string input = SquareButton.Text;
            CalculatorState.getInstance().nextState(4, input);
            textBox1.Text = SpecialOperationState.getInstance().display();
        }

        private void PercentButton_MouseClick(object sender, MouseEventArgs e)
        {
            string input = PercentButton.Text;
            CalculatorState.getInstance().nextState(4, input);
            textBox1.Text = SpecialOperationState.getInstance().display();
        }
        //Special Functions
        private void SQRTButton_MouseClick(object sender, MouseEventArgs e)
        {
            string input = SQRTButton.Text;
            CalculatorState.getInstance().nextState(4, input);
            textBox1.Text = SpecialOperationState.getInstance().display();
        }

        private void BackspaceButton_MouseClick(object sender, MouseEventArgs e)
        {
            CalculatorState.getInstance().nextState(0, null);
            textBox1.Text = BackspaceState.getInstance().display();
        }

        private void ClearAll_MouseClick(object sender, MouseEventArgs e)
        {
            CalculatorState.getInstance().nextState(5, null);
            textBox1.Text = ClearEverythingState.getInstance().display();
        }

        private void ClearButton_MouseClick(object sender, MouseEventArgs e)
        {
            CalculatorState.getInstance().nextState(6, null);
            textBox1.Text = ClearState.getInstance().display();
        }
    }
}
