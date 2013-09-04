using System.Collections.Generic;
using System.Collections.ObjectModel;
using OpenQA.Selenium;
using Selenium.Webdriver.Domify.Elements;

namespace Selenium.Webdriver.Domify
{
    public abstract class ListWebElements : ISearchContext, IListWebElements
    {
        public IList<Span> Spans
        {
            get { return this.Find<Span>(); }
        }

        public IList<Frame> Frames
        {
            get { return this.Find<Frame>(); }
        }

        public IList<UL> Lists
        {
            get { return this.Find<UL>(); }
        }

        public IList<Div> Divs
        {
            get { return this.Find<Div>(); }
        }

        public IList<HyperLink> Links
        {
            get { return this.Find<HyperLink>(); }
        }

        public IList<Table> Tables
        {
            get { return this.Find<Table>(); }
        }

        public IList<CheckBox> CheckBoxes
        {
            get { return this.Find<CheckBox>(); }
        }

        public IList<SelectList> SelectLists
        {
            get { return this.Find<SelectList>(); }
        }

        public IList<DateField> DateFields
        {
            get { return this.Find<DateField>(); }
        }

        public IList<TextArea> TextAreas
        {
            get { return this.Find<TextArea>(); }
        }

        public IList<TextField> TextFields
        {
            get { return this.Find<TextField>(); }
        }

        public IList<Button> Buttons
        {
            get { return this.Find<Button>(); }
        }

        public IList<FileUpload> FileUploads
        {
            get { return this.Find<FileUpload>(); }
        }

        public IList<Form> Forms
        {
            get { return this.Find<Form>(); }
        }

        public IList<H1> H1s
        {
            get { return this.Find<H1>(); }
        }

        public IList<H2> H2s
        {
            get { return this.Find<H2>(); }
        }

        public IList<H3> H3s
        {
            get { return this.Find<H3>(); }
        }

        public IList<P> Ps
        {
            get { return this.Find<P>(); }
        }

        public IList<HtmlElement> Elements
        {
            get { return this.Find<HtmlElement>(); }
        }

        public IList<RadioButton> RadioButtons
        {
            get { return this.Find<RadioButton>(); }
        }

        public abstract IWebElement FindElement(By @by);

        public abstract ReadOnlyCollection<IWebElement> FindElements(By @by);
    }
}