using AutomatizacionEjemplo.Handler;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionEjemplo.TestCase
{
    /*
     * Clase base para todos los test
     */
    public abstract class BaseTest
    {
        //Selenium Driver
        protected IWebDriver Driver;

        //Url de la aplicacion bajo prueba
        protected string Url = ConfigurationManager.AppSettings["Url"];

        //SetUp: Anotacion de Nunit para ejecutar un metodo antes de cada test
        //Metodo para iniciar el navegador Chrome y navegar a una URL
        [SetUp]
        public void BeforeBaseTest()
        {
            Driver = new FirefoxDriver();
            Driver.Navigate().GoToUrl(Url);

        }

        //TearDown: Anotacion de Nunit para ejecutar un metodo despues de cada test
        //Metodo para cerrar el navegador y hacer una captura de pantalla si el test falla
        [TearDown]
        public void AfterBaseTest()
        {

            var status = TestContext.CurrentContext.Result.Outcome.Status;
            if (status == NUnit.Framework.Interfaces.TestStatus.Failed)
                ScreenShotHandler.TakeScreenShot(Driver);


            if (Driver != null)
            {
                Driver.Quit();
            }
        }
    }


}
