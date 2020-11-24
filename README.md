# BunningsSearchCshap


# Testing Challenge 1 - Automation Test Analyst
A testing challenge to be solved as part of a screening process

# Context
You are the quality analyst / engineer for a team at Bunnings.
You are retrofitting some testing procedures on the now live website.
Challenge
You are to design test cases and a test tracking plan for the newly rolled out search and results features on this site, the feature in question is outlined on this screenshot
Identify and document your testing strategy and approach to testing this application in an Agile development environment
List down any assumptions and questions you have about the brief
Design and document test cases for this feature as it appears on the site
Apply test automation to this feature outline the approach and tools you will use _
Write test automation scripts for your top 3 test cases
# Deliverables:
Spend as little or as much time as you like ⌚ on the challenge, please record the total time you spend on this and include it in your response
The code you produce can be in any language ⭐
If you complete the automation part of the challenge output of the efforts ❗ must be committed back into a Public Repo(created by you) in Github and the URL shared back for review.

# Bunning Search feature automation Challenge is done using 
•	C#
•	Selenium
•	chrome webdriver
•	NUnit
•	
## Following test cases automated 
  
### Scenario 01: Customer check for the Search Input Load
Given Customer visit to https://www.bunnings.com.au/
When Customer load the Bunnings web site
Then Search input should appear next to the D.I.Y. Advice
And Search Input should active
And display place holder should display “Search our products, services & D.I.Y. Advice”

### Scenario 07: Search for product category
Given Customer is on the Bunning Web site
When Customer enter “nails” to the search input
And click Search
Then results page should load
And results page should display “698 results for nails” 
And Our Range Tab should display with products
And  Our Range Tab heading should display  “Our Range(690)”
And D.I.Y. Advice tab heading should display “D.I.Y. Advice(8)”
And Services tab heading should display “Services(0)”
And Other tab heading should display “Other (0)”

### Scenario 08: Search for Item number
Given Customer is on the Bunning Web site
When Customer enter “0110663” to the search input
And click Search
Then Product page should display
And should display the details of the product of the “0110663” 
 Eg :“ Ryobi ONE+ 18V 2.5Ah Drill Driver Kit”

### Scenario 10: Search for Brand Name
Given Customer is on the Bunning Web site
When Customer enter “Ozito” to the search input
And click Search
Then results page should load
And results page should display “296 results for Ozito” 
And Our Range Tab should display with products
And Our Range Tab heading should display “Our Range (292)”
And D.I.Y. Advice tab heading should display “D.I.Y. Advice (0)”
And Services tab heading should display “Services(0)”
And Other tab heading should display “Other (4)”

### Scenario 11: Search for Services

Given Customer is on the Bunning Web site
When Customer enter “Key” to the search input
And select Key cutting Service from the drop down
Then results page should load
And results page should display “493 results for keys” 
And Services Tab should display with services
And Services tab heading should display “Services (2)”
And D.I.Y. Advice tab heading should display “D.I.Y. Advice (15)”
And Our Range Tab heading should display “Our Range (471)”
And Other tab heading should display “Other (5)”


### Scenario 12: Search for DIY Advice
Given Customer is on the Bunning Web site
When Customer enter “Key” to the search input
And select Keys in D.I.Y.Advice from the drop down
Then results page should load
And results page should display “494 results for keys” 
And D.I.Y.Advice Tab should display with D.I.Y.Advice
And Services tab heading should display “Services(2)”
And D.I.Y.Advice tab heading should display “D.I.Y.Advice (15)”
And Our Range Tab heading should display “Our Range(471)”
And Other tab heading should display “Other(5)”

   

 
  ## Following Assumption used in the Automation
    •	Customer knows how to navigate to the Bunnings Web site.
    •	Local Store is set
    •	Product stock is not change
    
  ### NuGet Package manager use to load the dependencies.

