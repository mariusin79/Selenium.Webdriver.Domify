﻿using OpenQA.Selenium;

namespace Selenium.Webdriver.Domify.Elements
{
    [DOMElement("p")]
    public class P : WebElement
    {
        public static P Create(IWebElement element)
        {
            return new P(element);
        }

        private P(IWebElement element) :
            base(element)
        {

        }     
    }
}