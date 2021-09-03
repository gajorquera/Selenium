using AutomatizacionEjemplo.Handler;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionEjemplo.PageObject
{
    /* Clase para representar la pagina del formulario Empleado*/
    public class EmployeePage : BasePage
    {
        //Localizadores
        protected By Form = By.Id("formEmployee");
        protected By NameInput = By.XPath("//*[@id='formEmployee']/div[2]/div[1]/input");
        protected By EmailInput = By.XPath("//*[@id='formEmployee']/div[2]/div[2]/input");
        protected By AddressTextArea = By.Id("address");
        protected By PhoneInput = By.Id("phone");
        protected By AddButton = By.Id("addButton");


        //Constructor lanza un excepcion si el titulo de la pagina empleado no es el correcto
        public EmployeePage(IWebDriver driver)
        {
            Driver = driver;

            if (!driver.Title.Equals("AUT Form - TestFaceClub"))
                throw new Exception("Esta no es la pagina de Empleado");
        }

        //Metodo para detectar si el formulario del empleado esta cargado
        //Metodo True si el elemento del formulario esta presente sino retorna falso
        public bool FormIsPresent() 
        {
           return WaitHandler.ElementIstPresent(Driver, Form);
        

        }

        //Metodo que permite adicionar empleado
        public void AddEmployee(string name, string email, string address, string phone)
        {
            Driver.FindElement(NameInput).SendKeys(name);
            Driver.FindElement(EmailInput).SendKeys(email);
            Driver.FindElement(AddressTextArea).SendKeys(address);
            Driver.FindElement(PhoneInput).SendKeys(phone);
            Driver.FindElement(AddButton).Click();

        }


        //Metodo para capturar y aceptar una alerta
        //Metodo true si se detecta una alerta y es aceptada, sino retorna falso
        public bool IsSuccessAlertPresent()
        {
            try
            {
                Driver.SwitchTo().Alert().Accept();
                return true;
            }
            catch (NoAlertPresentException) { }
            return false;
        }
    }
}
