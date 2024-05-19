using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

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

                // List of section names
                List<string> sectionNames = new List<string>
                {
                    "Section 1: Introduction to DevOps and Testable Code",
                    "Section 2: Fundamentals of Testable Code",
                    "Section 3: Setting Up Your Environment for Testable Code",
                    "Section 4: Designing for Testability",
                    "Section 5: Tools and Technologies for Testable Code",
                    "Section 6: Refactoring Code for Testability",
                    "Section 7: Building a Culture of Quality with Testable Code",
                    "Section 8: Enhancing Delivery with Testable Code",
                    "Section 9: Future Trends and Career Opportunities in DevOps and Testable Code",
                    "Conclusion and Next Steps"
                };

                // Initialize WebDriverWait
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

                // Loop through the section names
                for (int i = 0; i < sectionNames.Count; i++)
                {
                    // Click on the "Add chapter" button
                    driver.FindElement(By.CssSelector(".add-chapter_uOzhc")).Click();

                    // Wait for the "Successfully created a new chapter" toast message
                    wait.Until(drv => drv.FindElement(By.CssSelector(".Toast_toast__message__176 > span")));

                    // Input section details
                    string inputId = $"input-{5 + i}";
                    IWebElement inputField = driver.FindElement(By.Id(inputId));
                    inputField.Clear();
                    inputField.SendKeys(sectionNames[i]);
                }

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
