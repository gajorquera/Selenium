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
    /*Clase que contiene los casos de prueba del formulario de Empleado*/
    [TestFixture] //Anotacion de Nunit para marcar una clase que contenga casos de prueba
    class EmployeeTest : BaseTest
    {
       
        //Page Object para el formulario Empleado
        private EmployeePage EmployeePage;

        //SetUp: Anotacion de Nunit para ejecutar un metodo antes de cada test
        //Metodo para loguearse en la aplicacion
        [SetUp]
        public void BeforeTest()
        {

            LoginPage loginPage = new LoginPage(Driver);
            EmployeePage = loginPage.LoginAs("admin", "admin123");

        }
        //TestCase: Anotacion de Nunit para marcar a un metodo como un caso de prueba automatizado con parametros
        //Metodo que implementa el caso de prueba de adicionar empleado. El resultado esperado es que se adicione correctamente
        [TestCase("pepe","pepe@gmail.com","Zona 5","458632")]
        [TestCase("juan", "juan@gmail.com", "Zona 10", "111224")]
        public void AddEmployeeTest(string name, string email, string address, string phone )
        {
            EmployeePage.AddEmployee(name,email,address,phone);
            Assert.IsTrue(EmployeePage.IsSuccessAlertPresent());
        }

    }
}
