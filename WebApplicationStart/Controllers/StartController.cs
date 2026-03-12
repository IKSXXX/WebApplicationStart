using Microsoft.AspNetCore.Mvc;

namespace OnlineShopWebApp.Controllers
{
    public class StartController : Controller
    {
        public string Task1()
        {
            var currentHour = DateTime.Now.Hour;
            string s;

            if (currentHour < 6) s = "Доброй ночи";

            else if (currentHour < 12) s =  "Доброе утро";

            else if (currentHour < 18) s = "Добрый день";

            else s = "Добрый вечер";
            
            return s;
        }
    }
}