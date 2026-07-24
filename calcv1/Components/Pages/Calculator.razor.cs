namespace calcv1.Components.Pages
{
    public partial class Calculator
    {
        string current = "";
        string display = "";
        int num1 = 0;
        int num2 = 0;
        char setOperator;
        void Value(int num)
        {
            display += num;
            current += num;
        }
        void Operation(char op)
        {
            num1 = int.Parse(current);
            setOperator = op;
            display += op;
            current = "";
        }

        void Calculate()
        {
            num2 = int.Parse(current);
            double result = 0;
            switch (setOperator)
            {
                case '+':
                    result = num1 + num2;
                    break;
                case '-':
                    result = num1 - num2;
                    break;
                case '*':
                    result = num1 * num2;
                    break;
                case '/':
                    result = num1 / num2;
                    break;
                default:
                    result = num2;
                    break;
            }
            display = result.ToString();
            current = result.ToString();
            num1 = 0;
            setOperator = ' ';
        }
        void Clear()
        {
            display = "";
            num1 = 0;
            num2 = 0;
            setOperator = ' ';
            current = "";

        }
    }
}
