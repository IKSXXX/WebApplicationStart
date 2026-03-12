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
    }
}
