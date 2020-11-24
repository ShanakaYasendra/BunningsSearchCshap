using System;

using Bunnings.PageAssembly;

using NUnit.Framework;

namespace Bunnings.Test
{
    public class SearchTest:Base
    {

        //Scenario 01: Customer check for the Search Input Load

        //Given Customer visit to https://www.bunnings.com.au/
        //When Customer load the Bunnings web site
        //Then Search input should appear next to the D.I.Y.Advice
        //And Search Input should active
        //And display place holder should display “Search our products, services & D.I.Y.Advice”

        [Test]
        public void PlaceholderTest()
        {
            Assert.AreEqual(pages.homePage.GetElementAttribute(), "Search our products, services & D.I.Y. Advice");
        }

        //Scenario 07: Search for product category

        //Given Customer is on the Bunning Web site
        //When Customer enter “nails” to the search input
        //And click Search
        //Then results page should load
        //And results page should display “696 results for nails” 
        //And Our Range Tab should display with products
        //And Our Range Tab heading should display  “Our Range(688)”
        //And D.I.Y.Advice tab heading should display “D.I.Y.Advice(8)”
        //And Services tab heading should display “Services(0)”
        //And Other tab heading should display “Other(0)”


        [Test]
        public void ProductCategoryTest()
        {
            pages.homePage.PerformSearch("Nails");
            pages.resultsPage.ActiveLink("Our Range");
            string res=pages.resultsPage.h1.Text;
            Assert.AreEqual(res, "697 results for Nails");
            Assert.AreEqual("(689)", pages.resultsPage.GetTab("Our Range"));
            Assert.AreEqual("(8)", pages.resultsPage.GetTab("D.I.Y. Advice"));
            Assert.AreEqual("(0)", pages.resultsPage.GetTab("Services"));
            Assert.AreEqual("(0)", pages.resultsPage.GetTab("Other"));
        }


        //Scenario 08: Search for Item number

        //Given Customer is on the Bunning Web site
        //When Customer enter “0110663” to the search input
        //And click Search
        //Then Product page should display
        //And should display the details of the product of the “0110663”

        [Test]
        public void ItemNumberSearchTest()
        {
            pages.homePage.PerformSearch("0110663");
            Assert.AreEqual("Ryobi ONE+ 18V 2.5Ah Drill Driver Kit | Bunnings Warehouse", pages.productPage.GetTitle());
            Assert.AreEqual("Ryobi ONE+ 18V 2.5Ah Drill Driver Kit", pages.productPage.h1.Text);
        }

        //Scenario 11: Search for Services

        //Given Customer is on the Bunning Web site
        //When Customer enter “Key” to the search input
        //And select Key cutting Service from the drop down
        //Then results page should load
        //And results page should display “494 results for keys” 
        //And Services Tab should display with services
        //And Services tab heading should display “Services(2)”
        //And D.I.Y.Advice tab heading should display “D.I.Y.Advice (15)”
        //And Our Range Tab heading should display “Our Range(471)”
        //And Other tab heading should display “Other(5)”

        [Test]
        public void ServicesSearchTest()
        {
            
            pages.homePage.ClickListItem("key", "Services");
            pages.resultsPage.ActiveLink("Services");
            string res = pages.resultsPage.h1.Text;
            Assert.AreEqual(res, "494 results for keys");
            Assert.AreEqual("(472)", pages.resultsPage.GetTab("Our Range"));
            Assert.AreEqual("(15)", pages.resultsPage.GetTab("D.I.Y. Advice"));
            Assert.AreEqual("(2)", pages.resultsPage.GetTab("Services"));
            Assert.AreEqual("(5)", pages.resultsPage.GetTab("Other"));
        }

        // Scenario 12: Search for DIY Advice

        // Given Customer is on the Bunning Web site
        // When Customer enter “Key” to the search input
        // And select Keys in D.I.Y.Advice from the drop down
        // Then results page should load
        // And results page should display “492 results for keys” 
        // And D.I.Y.Advice Tab should display with D.I.Y.Advice
        // And Services tab heading should display “Services(2)”
        // And D.I.Y.Advice tab heading should display “D.I.Y.Advice (15)”
        // And Our Range Tab heading should display “Our Range(471)”
        // And Other tab heading should display “Other(5)”

        [Test]
        public void DIYAdviceSearchTest()
        {

            pages.homePage.ClickListItem("key", "D.I.Y. Advice");
            pages.resultsPage.ActiveLink("D.I.Y. Advice");
            string res = pages.resultsPage.h1.Text;
            Assert.AreEqual(res, "494 results for keys");
            Assert.AreEqual("(472)", pages.resultsPage.GetTab("Our Range"));
            Assert.AreEqual("(15)", pages.resultsPage.GetTab("D.I.Y. Advice"));
            Assert.AreEqual("(2)", pages.resultsPage.GetTab("Services"));
            Assert.AreEqual("(5)", pages.resultsPage.GetTab("Other"));
        }

    }
}
