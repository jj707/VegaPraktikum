using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Calculator
{
    public class Calculation
    {
        private string _equationText;
        public string EquationText
        {
            get
            {
                return _equationText;
            }
            set
            {
                _equationText = value;
                ValueChanged?.Invoke(this, EventArgs.Empty);
            }
        }

        public event EventHandler ValueChanged;

        public void UpdateEquation(string input)
        {
            var isOperator = IsOperator(input.Last());
            if (!isOperator || (isOperator && CanWriteOperator(input, EquationText)))
            {
                EquationText += input;
            }
        }

        public bool CanWriteOperator(string value, string equationText)
        {
            var isValueOperator = IsOperator(value.Last());

            var isLastCharOperator = IsOperator(equationText.Trim().LastOrDefault());

            return isValueOperator != isLastCharOperator;
        }

        public bool IsOperator(char value)
        {
            bool isOperator = false;
            switch (value)
            {
                case '+':
                case '-':
                case '*':
                case '/':
                    isOperator = true;
                    break;
            }
            return isOperator;
        }

        public void Clear()
        {
            EquationText = "";
        }

        public void CalculateEquation(string equationText)
        {
            if (string.IsNullOrWhiteSpace(equationText))
            {
                return;
            }

            var result = Convert.ToDouble(new DataTable().Compute(equationText, null));

            EquationText = result.ToString();

        }

        public void SetEquation(string text)
        {
            EquationText = text;
        }
    }
}
