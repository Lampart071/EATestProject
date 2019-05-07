﻿using System;
using EAAutoFramework.Base;
using EAEmployeeTest.Pages;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace EAEmployeeTest
{
    [TestClass]
    public class UnitTest1 : Base
    {
        string url = "http://localhost/ExecuteAutoEmployee/";

        [TestMethod]
        public void TestMethod1()
        {
            DriverContext.Driver = new FirefoxDriver();
            DriverContext.Driver.Navigate().GoToUrl(url);

            LoginPage page = new LoginPage();
            page.ClickLoginLink();
            page.Login("admin", "password");

            //CurrentPage = page.ClickEmployeeList();
            //((EmployeePage)CurrentPage).ClickCreateNew();

            //EmployeePage employeePage = page.ClickEmployeeList();
            //employeePage.ClickCreateNew();

            CurrentPage = page.ClickEmployeeList();
            ((EmployeePage)CurrentPage).ClickCreateNew();

        }


    }
}
