using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionEjemplo.Handler
{
    /* Clase para manejar las esperas explicitas*/
    public class WaitHandler
    {
        public static bool ElementIstPresent(IWebDriver driver, By locator)
        {

            try
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                wait.Until(drv => drv.FindElement(locator));
                return true;
            }
            catch { }

            return false;
        }
    }
}
