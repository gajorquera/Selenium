using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionEjemplo.Handler
{
    /*Clase para capturar pantallas
     */
    public class ScreenShotHandler
    {
        //Obtener la direccion del directorio donde se va a guardar la imagen
        private static string DirectoryPath = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location);


        //Metodo para realizar la captura de pantalla con selenium
        //Retorna la direccion de la imagen que se capturo
        public static string TakeScreenShot(IWebDriver driver)
        {
            long milliseconds = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;

            string imagePath = DirectoryPath + "//img_" + milliseconds + ".png";
            Screenshot image = ((ITakesScreenshot)driver).GetScreenshot();
            image.SaveAsFile(imagePath, ScreenshotImageFormat.Png);

            return imagePath;


        }
    }

}
