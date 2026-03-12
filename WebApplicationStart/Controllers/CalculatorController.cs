using Microsoft.AspNetCore.Mvc;

namespace WebApplicationStart.Controllers
{
    public class CalculatorController : Controller
    {
        public string Task2(double num1, double num2)
        {
            return $"{num1} + {num2} = {num1 + num2}";
        }

        public string Task3(double num1, double num2, string sign = "+")
        {
            return sign switch
            {
                "+" => $"{num1} {sign} {num2} = {num1 + num2}",
                "-" => $"{num1} {sign} {num2} = {num1 - num2}",
                "*" => $"{num1} {sign} {num2} = {num1 * num2}",
                _ => """
                        Недопустимая операция!
                        В последнем сегменте может быть указан только один знак арифметической операции.
                        Допустимые варианты символов: +, - , *.                        
                        """,
            };
        }
        public string task4(double a, double b, string c = "+")
        {
            return c switch
            {
                "+" => $"{a} {c} {b} = {a + b}",
                "-" => $"{a} {c} {b} = {a - b}",
                "*" => $"{a} {c} {b} = {a * b}",
                "/" => (b != 0) ? $"{a} {c} {b} = {a / b}"
                                        : "На ноль делить нельзя! Введите другое значение параметра b.",
                _ => """
                        Недопустимая операция!
                        В параметре, в котором передается знак арифметической опреации, 
                        могут быть указаны только следующие варианты символов: %2B, - , *, /.                        
                        """,
            };
        }
    }
}
