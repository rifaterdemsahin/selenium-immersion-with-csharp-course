using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTestProject
{
    class Program
    {
        static void Main(string[] args)
        {
            // Initialize the ChromeDriver
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Size = new System.Drawing.Size(1273, 672);

            try
            {
                // Open the URL
                driver.Navigate().GoToUrl("https://devopsengineering.thinkific.com/manage/courses/2776905");

                // Click on the "Bulk importer" link
                driver.FindElement(By.LinkText("Bulk importer")).Click();

                // Click on the "Add chapter" button
                driver.FindElement(By.CssSelector(".add-chapter_uOzhc")).Click();

                // Wait for the "Successfully created a new chapter" toast message
                var wait = new OpenQA.Selenium.Support.UI.WebDriverWait(driver, TimeSpan.FromSeconds(10));
                wait.Until(drv => drv.FindElement(By.CssSelector(".Toast_toast__message__176 > span")));

                // Input section details
                driver.FindElement(By.Id("input-5")).SendKeys("Section 1: Introduction to DevOps and Testable Code,\n");
                driver.FindElement(By.CssSelector(".add-chapter_uOzhc")).Click();

                wait.Until(drv => drv.FindElement(By.CssSelector(".Toast_toast__message__176 > span")));
                driver.FindElement(By.Id("input-6")).SendKeys("Section 2: Fundamentals of Testable Code");
                driver.FindElement(By.CssSelector(".add-chapter_uOzhc")).Click();

                wait.Until(drv => drv.FindElement(By.CssSelector(".Toast_toast__message__176 > span")));
                driver.FindElement(By.Id("input-7")).SendKeys("Section 3: Setting Up Your Environment for Testable Code");
                driver.FindElement(By.CssSelector(".add-chapter_uOzhc")).Click();

                wait.Until(drv => drv.FindElement(By.CssSelector(".Toast_toast__message__176 > span")));
                driver.FindElement(By.Id("input-8")).SendKeys("Section 4: Designing for Testability");
                driver.FindElement(By.CssSelector(".add-chapter_uOzhc")).Click();

                wait.Until(drv => drv.FindElement(By.CssSelector(".Toast_toast__message__176 > span")));
                driver.FindElement(By.Id("input-9")).SendKeys("Section 5: Tools and Technologies for Testable Code");
                driver.FindElement(By.CssSelector(".add-chapter_uOzhc")).Click();

                wait.Until(drv => drv.FindElement(By.CssSelector(".Toast_toast__message__176 > span")));
                driver.FindElement(By.Id("input-10")).SendKeys("Section 6: Refactoring Code for Testability");
                driver.FindElement(By.CssSelector(".add-chapter_uOzhc")).Click();

                wait.Until(drv => drv.FindElement(By.CssSelector(".Toast_toast__message__176 > span")));
                driver.FindElement(By.Id("input-11")).SendKeys("Section 7: Building a Culture of Quality with Testable Code\n");
                driver.FindElement(By.CssSelector(".add-chapter_uOzhc")).Click();

                wait.Until(drv => drv.FindElement(By.CssSelector(".Toast_toast__message__176 > span")));
                driver.FindElement(By.Id("input-12")).SendKeys("Section 8: Enhancing Delivery with Testable Code");
                driver.FindElement(By.CssSelector(".add-chapter_uOzhc")).Click();

                wait.Until(drv => drv.FindElement(By.CssSelector(".Toast_toast__message__176 > span")));
                driver.FindElement(By.Id("input-13")).SendKeys("Section 9: Future Trends and Career Opportunities in DevOps and Testable Code");
                driver.FindElement(By.CssSelector(".add-chapter_uOzhc")).Click();

                wait.Until(drv => drv.FindElement(By.CssSelector(".Toast_toast__message__176 > span")));
                driver.FindElement(By.Id("input-14")).SendKeys("Conclusion and Next Steps");
                driver.FindElement(By.CssSelector(".add-chapter_uOzhc")).Click();

                // Wait for the final toast message
                wait.Until(drv => drv.FindElement(By.CssSelector(".Toast_toast__message__176 > span")));

                Console.WriteLine("Test completed successfully!");
            }
            catch (Exception e)
            {
                Console.WriteLine($"Test failed: {e.Message}");
            }
            finally
            {
                // Close the browser
                driver.Quit();
            }
        }
    }
}
