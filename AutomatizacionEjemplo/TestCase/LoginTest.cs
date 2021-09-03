using AutomatizacionEjemplo.PageObject;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace AutomatizacionEjemplo.TestCase
{
    /*Clase que contiene lso casos de prueba del login*/
    [TestFixture] //Anotacion de Nunit para marcar una clase que contenga casos de prueba
    public class LoginTest : BaseTest
    {


        //Test: Anotacion de Nunit para marcar a un metodo como un caso de prueba automatizado
        //Metodo que implementa el caso de prueba del login. El resultado esperado es que el usuario se loguee correctamente
        [Test]
        public void SuccesfulLoginTest() 
        {
            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage employeePage =  loginPage.LoginAs("admin", "admin123");

            Assert.IsTrue(employeePage.FormIsPresent());
        }

    }

}
