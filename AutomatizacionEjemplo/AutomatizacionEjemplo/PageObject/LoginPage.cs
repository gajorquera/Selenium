using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomatizacionEjemplo.PageObject
{
    /*Clase para representar la pagina del Login*/
    public class LoginPage : BasePage
    {
        //localizadores
        protected By UserInput = By.Id("user");
        protected By PasswordInput = By.Id("pass");
        protected By LoginButton = By.Id("loginButton");

        //Constructor Lanza una excepcion si el Titulo de la pagina del login no es el correcto//
        public LoginPage(IWebDriver driver)
        {
            Driver = driver;

            if (Driver.Title.Equals("AUT Login-TestFaceClub"))
            
                throw new Exception("Esta no es el login de la pagina");
        }

        //Metodo para escribir el usuario
        public void TypeUserName(String user)
        {
            Driver.FindElement(UserInput).SendKeys(user);

        }

        //Metodo para escribir la password
        public void TypePassword(String password)
        {
            Driver.FindElement(PasswordInput).SendKeys(password);

        }

        //Metodo para hacer click en el boton del login
        public void ClickLoginButton()
        {
            Driver.FindElement(LoginButton).Click();

        }

        //Metodo para logearse retorna a la pagina del formulario Empleados
        public EmployeePage LoginAs(String user, String password)
        {

            TypeUserName(user);
            TypePassword(password);
            ClickLoginButton();
            return new EmployeePage(Driver);

        }


    }





}
