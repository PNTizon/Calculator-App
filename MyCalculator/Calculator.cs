namespace MyCalculator
{
    public partial class Calculator : Form
    {
        private string currentCalculation = "";
        private string firstNum = "0";
        private string operation = "";
        private decimal result = 0;
        private decimal lastSecondNumber = 0;
        private string lastOperation = "";

        public Calculator()
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyPress += new KeyPressEventHandler(Calculator_KeyPress);
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string buttonText = button.Text;

            if (currentCalculation.Length >= 13)
            {
                txtOutput.Text = "Input Too Long";
                SetButtonsEnabled(false);
                return;
            }

            if (buttonText == "." && currentCalculation.Contains("."))
            {
                return;
            }

            if (buttonText == "." && string.IsNullOrEmpty(currentCalculation))
            {
                currentCalculation = "0";
            }
            currentCalculation += buttonText;
            txtOutput.Text = Comma_Dot_Click(currentCalculation);
        }
        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            string newOperation = button.Text;

            if (!string.IsNullOrEmpty(firstNum) && string.IsNullOrEmpty(currentCalculation))
            {
                operation = newOperation;
                txtOperationBox.Text = $"{firstNum} {operation}";
            }
            if (!string.IsNullOrEmpty(firstNum) && !string.IsNullOrEmpty(operation) && !string.IsNullOrEmpty(currentCalculation))
            {
                EqualSign.PerformClick();
                operation = newOperation;
                txtOperationBox.Text = $"{firstNum} {operation}";
            }
            else if (!string.IsNullOrEmpty(txtOutput.Text) && txtOutput.Text != "0")
            {
                firstNum = txtOutput.Text;
                operation = newOperation;
                txtOperationBox.Text = $"{firstNum} {operation}";

                currentCalculation = "";
                txtOutput.Text = string.Empty;
            }
        }
        private void btnPercent_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(currentCalculation) || currentCalculation == "0")
            {
                txtOutput.Text = "ERROR";
                SetButtonsEnabled(false);
                return;
            }
            txtOperationBox.Text = $"%({txtOutput.Text})";
            txtOutput.Text = Convert.ToString(Convert.ToDouble(txtOutput.Text) / Convert.ToDouble(100));
        }
        private void EqualSign_Click(object sender, EventArgs e)
        {
            decimal firstNumber, secondNumber;

            if (string.IsNullOrEmpty(firstNum) || string.IsNullOrEmpty(currentCalculation) && string.IsNullOrEmpty(lastOperation))
            {
                txtOutput.Text = "ERROR";
                SetButtonsEnabled(false);
                return;
            }

            if (string.IsNullOrEmpty(currentCalculation))
            {
                firstNumber = Convert.ToDecimal(firstNum);
                secondNumber = lastSecondNumber;
            }
            else
            {
                firstNumber = Convert.ToDecimal(firstNum);
                secondNumber = Convert.ToDecimal(currentCalculation);
                lastSecondNumber = secondNumber;
                lastOperation = operation;
            }

            try
            {
                switch (lastOperation)
                {
                    case "+":
                        result = firstNumber + secondNumber;
                        break;
                    case "-":
                        result = firstNumber - secondNumber;
                        break;
                    case "*":
                        result = firstNumber * secondNumber;
                        break;
                    case "/":
                        if (secondNumber == 0)
                        {
                            txtOutput.Text = "Invalid!";
                            SetButtonsEnabled(false);
                            return;
                        }
                        result = firstNumber / secondNumber;
                        break;
                    default:
                        txtOutput.Text = "Syntax Error";
                        SetButtonsEnabled(false);
                        return;
                }

                if (currentCalculation.Contains(".") || firstNum.Contains("."))
                {
                    txtOutput.Text = result.ToString("N1");
                }
                else
                {
                    txtOutput.Text = result.ToString("N0");
                }

                txtOperationBox.Text = $"{firstNumber} {lastOperation} {secondNumber} = ";

                firstNum = result.ToString();  
                currentCalculation = "";       
                operation = "";
            }
            catch (Exception)
            {
                txtOutput.Text = "Syntax Error";
                currentCalculation = "";
                SetButtonsEnabled(false);
            }
        }
        private void Clear_Click(object sender, EventArgs e)
        {
            txtOutput.Text = "0";
            txtOperationBox.Text = "";
            currentCalculation = "";
            firstNum = "";
            operation = "";
            result = 0;

            SetButtonsEnabled(true);
        }
        private void ClearEntry_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(currentCalculation) && currentCalculation.Length > 0)
            {
                currentCalculation = currentCalculation.Remove(currentCalculation.Length - 1, 1);
                txtOutput.Text = currentCalculation;
            }
            if (string.IsNullOrEmpty(currentCalculation))
            {
                txtOutput.Text = "0";
            }
        }
        private string Comma_Dot_Click(string input)
        {
            string cleanedInput = input.Replace(",", "");
            if (cleanedInput.Contains("."))
            {
                string[] parts = cleanedInput.Split('.');

                string formattedIntegerPart = $"{int.Parse(parts[0]):n0}";

                return parts.Length > 1 ? formattedIntegerPart + "." + parts[1] : formattedIntegerPart + ".";
            }
            else
            {
                return $"{double.Parse(cleanedInput):n0}";
            }
        }
        private void SetButtonsEnabled(bool isEnabled)
        {
            foreach (Control control in this.Controls)
            {
                if (control is Button button && button.Name != "ClearButton")
                {
                    button.Enabled = isEnabled;
                }
            }
        }
        private void Calculator_KeyPress(object? sender, KeyPressEventArgs e)
        {
            switch (e.KeyChar)
            {
                case '0':
                    Zero.PerformClick();
                    break;
                case '1':
                    One.PerformClick();
                    break;
                case '2':
                    two.PerformClick();
                    break;
                case '3':
                    three.PerformClick();
                    break;
                case '4':
                    Four.PerformClick();
                    break;
                case '5':
                    Five.PerformClick();
                    break;
                case '6':
                    Six.PerformClick();
                    break;
                case '7':
                    Seven.PerformClick();
                    break;
                case '8':
                    Eight.PerformClick();
                    break;
                case '9':
                    Nine.PerformClick();
                    break;
                case '+':
                    AdditionSign.PerformClick();
                    break;
                case '-':
                    SubtractionSign.PerformClick();
                    break;
                case '*':
                    MultiplySign.PerformClick();
                    break;
                case '/':
                    DivisionSign.PerformClick();
                    break;
                case (char)Keys.Enter:
                    EqualSign.PerformClick();
                    e.Handled = true;
                    break;
                case '.':
                    Decimal.PerformClick();
                    break;
                case (char)8:
                    ClearEntry.PerformClick();
                    break;
                default:
                    break;
            }
        }
    }
}