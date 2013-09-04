using System;
using OpenQA.Selenium;

namespace Selenium.Webdriver.Domify.Elements
{
    [DOMElement("*")]
    [Obsolete("Will be removed in v2.0")]
    public class Element : WebElement
    {
        public static Element Create(IWebElement element)
        {
            return new Element(element);
        }

        private Element(IWebElement element) :
            base(element)
        {

        }
    }
}