namespace SolidExamples._02_OCP.BadExample
{
    internal enum Browser {
        Firefox,
        GoogleChrome,
        InternetExplorer // Who uses it nowadays? haha
    }
    internal class WebCrawler
    {
        void OpenUrl(string url, Browser browser)
        {
            switch (browser)
            {
                case Browser.Firefox:
                    /* Open For Firefox */
                    break;
                case Browser.GoogleChrome:
                    /* Open For GoogleChrome */
                    break;
                case Browser.InternetExplorer:
                    /* Open For Internet Explorer */
                    break;
            }
        }
    }
}
