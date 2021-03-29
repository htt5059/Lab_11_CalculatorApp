using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_11_CalculatorApp
{
    class ClearState:CalculatorState
    {
        public void enter() {
            reset();
        }
    }
}
