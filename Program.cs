using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

string filePath = AppDomain.CurrentDomain.BaseDirectory + '\\';
IWebDriver driver = new ChromeDriver(filePath);

driver.Navigate().GoToUrl("https://www.coffee-anytime.ru/");
Thread.Sleep(5000);

Console.WriteLine(1);

List<IWebElement> elements = driver.FindElements(By.XPath(
    "//div[@class='tab-pane products is-tab active']" +
    "/div[@class='products__item']" +
    "/p[@class='products__name']")).ToList();

Console.WriteLine(1);

List<string> prices = new List<string>();

Console.WriteLine(1);

foreach (IWebElement elem in elements)
{
    prices.Add(elem.Text);
    Console.WriteLine(1);
}

for (int i = 0; i < prices.Count; i++)
{
    Console.Write(prices[i]);
}