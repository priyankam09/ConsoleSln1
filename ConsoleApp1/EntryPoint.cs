using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;
using System;

class EntryPoint
    {
    //initialise your driver
    static IWebDriver driver = new ChromeDriver();
    //static IWebElement textBox;
    // static IWebElement checkBox;
    //static IWebElement radioButton;
    //static IWebElement dropDownMenu;
    //static IWebElement elementFromDropDownMenu;
    static IAlert alert;
    static IWebElement image;
    static void Main()
    {
        // select by Name
        //string url1 = "http://testing.todvachev.com/selectors/name/";
        //open page with driver to select by Name
        //driver.Navigate().GoToUrl(url1);
        //IWebElement element = driver.FindElement(By.Name("myName"));
        
        //or to select by ID
        //string url2 = "http://testing.todvachev.com/selectors/id/";
        //string ID = "testImage";
        //driver.Navigate().GoToUrl(url2);
        //IWebElement element = driver.FindElement(By.Id(ID));

        //or select by class name
        //string url3 = "http://testing.todvachev.com/selectors/class-name/";
        //string className = "testClass"; //here we have selected a paragraph with text
        //driver.Navigate().GoToUrl(url3);
        //IWebElement element = driver.FindElement(By.ClassName(className));
        //Console.WriteLine(element.Text);

        /*or select by CSS Path or XPath; CSS works faster than XPath, IE has poor support for XPath
        string url4 = "http://testing.todvachev.com/selectors/css-path";
        //string cssPath = "#post-108 > div > figure > img"; //shows Selenium the path of HTML code
        //If cssPath is not correct, NoSuchElementException
        string cssPath = "#post-108 > div > fig > img";
        string xPath = "//*[@id=\"post-108\"]/div/figure/img";
        IWebDriver driver = new ChromeDriver();
        driver.Navigate().GoToUrl(url4);
        //IWebElement cssPathElement = driver.FindElement(By.CssSelector(cssPath));
        IWebElement cssPathElement;
        IWebElement xPathElement = driver.FindElement(By.XPath(xPath));
        try
        {
            cssPathElement = driver.FindElement(By.CssSelector(cssPath));
            if (cssPathElement.Displayed)
            {         GreenMessage("I can see the CSS Path element");     }         }
        catch (NoSuchElementException)
        {             RedMessage("Something went wrong");         } */
        
        /* if (element.Displayed)
            if (cssPathElement.Displayed)
        {
            //System.Console.WriteLine("Yes I can see the element"); or you can create methods to print message in different colors.
            GreenMessage("Yes I can see the element");
        } else {
            //System.Console.WriteLine("Something went wrong");
            RedMessage("Something went wrong");
        }
        if (xPathElement.Displayed)
        {
            GreenMessage("Yes I can see the element");
        } else { 
            //System.Console.WriteLine("Something went wrong");
            RedMessage("Something went wrong");
        } 
        Thread.Sleep(3000); // create a pause of 3 seconds */

        /*string url5 = "http://testing.todvachev.com/special-elements/text-input-field/";
        driver.Navigate().GoToUrl(url5);
        textBox = driver.FindElement(By.Name("username"));
        textBox.SendKeys("Test text");
        Thread.Sleep(3000);
        textBox.Clear();
        Thread.Sleep(3000); */

        /*string url6 = "http://testing.todvachev.com/special-elements/check-button-test-3/";
        string option = "1";
        driver.Navigate().GoToUrl(url6);
        // if you are selecting the first checkbox
        //checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(1)"));
        // if you are selecting the second checkbox
        //checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(3)"));
        //if you have more than one selector, create a string called option with a number 1 and then the below code
        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));

        //to check if the checkmark is placed on the checkbox use the value "checked" in GetAttribute method in if..else statement
        if (checkBox.GetAttribute("checked") == "true")
        {
            Console.WriteLine("Checkbox is checked!");
        } else {     Console.WriteLine("Not Checked!"); }
        //to get the values of the checkbox
        Console.WriteLine(checkBox.GetAttribute("value")); //will get value of first checkbox
        option = "3"; //then reinitialise checkBox
        checkBox = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));
        Console.WriteLine(checkBox.GetAttribute("value")); //will get value of second checkbox */

        /*to place a check mark on a checkbox, need to investigate more.....
        option = "1";
        checkBox.Click();
        Thread.Sleep(3000);*/

        /*string url7 = "http://testing.todvachev.com/special-elements/radio-button-test/";
        string[] option = {"1", "3", "5"};
        driver.Navigate().GoToUrl(url7);
        // if you are selecting the first checkbox
        //radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=\"radio\"]:nth-child(1)"));
        // if you have more than one selector, create a string called option with a number 1 and then the below code
        for (int i = 0; i < option.Length; i++)
        {
            radioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=\"radio\"]:nth-child(1)"));
            if (radioButton.GetAttribute("checked") == "true")
            {
                Console.WriteLine("The " + (i+1) + " Radiobutton is checked!");
            }   else {
                Console.WriteLine("Radiobutton Not Checked!");
            }     }*/

        /* string url8 = "http://testing.todvachev.com/special-elements/drop-down-menu-test/";
        // string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(1)"; // This is the first element. You can change the child(1) number to select the next element
         string dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";
         driver.Navigate().GoToUrl(url8);

         dropDownMenu = driver.FindElement(By.Name("DropDownTest"));
         // Console.WriteLine(dropDownMenu.GetAttribute("value")); // check the value of the current selection of the dropdown menu
         Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value")); //

         elementFromDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));
         Console.WriteLine("The Third option in dropdown menu is: " + elementFromDropDownMenu.GetAttribute("value"));
         elementFromDropDownMenu.Click(); //select the value and make it the new value
         Console.WriteLine("The selected value is: " + dropDownMenu.GetAttribute("value"));

         for (int i = 1; i <=4; i++) //check all elements in dropdown menu
         {
             dropDownMenuElements = "#post-6 > div > p:nth-child(6) > select > option:nth-child(" + i + ")";
             elementFromDropDownMenu = driver.FindElement(By.CssSelector(dropDownMenuElements));
             Console.WriteLine("The " + i + " Third option in dropdown menu is: " + elementFromDropDownMenu.GetAttribute("value"));
         }
         Thread.Sleep(3000); */

        string url9 = "http://testing.todvachev.com/special-elements/alert-box/";
        driver.Navigate().GoToUrl(url9);
        Console.WriteLine(alert.Text); //to display the text in the alert on the screen
        alert = driver.SwitchTo().Alert(); //initialise alert
        alert.Accept(); //to click OK to accept the alert
        image = driver.FindElement(By.CssSelector("#post-119 > div > figure > img")); //to view the instance after the alert was accepted, create an image and find it
        try
        {    if (image.Displayed)
            {
                Console.WriteLine("I can see the image after the alert was accepted");
            }         }
        catch (NoSuchElementException)
        {
            Console.WriteLine("Something went wrong!");
        }
        Thread.Sleep(3000);

        driver.Quit();
     }
 }
/*private static void RedMessage(string message)
{
    Console.ForegroundColor = ConsoleColor.Red;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
}
private static void GreenMessage(string message)
{
    Console.ForegroundColor = ConsoleColor.Green;
    Console.WriteLine(message);
    Console.ForegroundColor = ConsoleColor.White;
} */

//new comment