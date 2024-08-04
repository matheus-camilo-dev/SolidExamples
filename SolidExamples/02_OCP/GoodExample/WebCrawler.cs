namespace SolidExamples._02_OCP.GoodExample
{
    internal interface IBrowser 
    {
        void OpenUrl(string url);
    }
    internal interface IFirefoxBrowser : IBrowser { }
    internal interface IGoogleChromeBrowser : IBrowser { }
    internal interface IInternetExplorerBrowser : IBrowser { }
    internal interface IOperaGXBrowser : IBrowser { } // Adding other browser

    internal class WebCrawler
    {
        void OpenUrl(string url, IBrowser browser)
        {
            browser.OpenUrl(url);
        }
    }
}
