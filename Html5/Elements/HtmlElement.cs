namespace Bridge.Html5
{
    /// <summary>
    /// The HTMLHtmlElement interface serves as the root node for a given HTML document.  This object inherits the properties and methods described in the HTMLElement interface.
    /// You can retrieve the HTMLHtmlElement object for a given document by reading the value of the document.documentElement property.
    /// </summary>
    [Ignore]
    [Name("HTMLHtmlElement")]
    public class HtmlElement : Element
    {
        [Template("document.createElement('html')")]
        public HtmlElement()
        {
        }
    }
}
