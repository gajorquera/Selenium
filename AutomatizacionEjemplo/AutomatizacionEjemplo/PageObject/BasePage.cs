using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionEjemplo.PageObject
{
    /*
     * Clase base para todos los page object
     */
    public abstract class BasePage
    {
        //Selenium Driver
        protected IWebDriver Driver;
    }
}
