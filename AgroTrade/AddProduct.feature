Feature: Create Product
as a farmer I want to add new product so that end user can buy it
Scenario: Data must be valid
Given farmer "ABC" has entered product name as "Potato"
And his email is "abc@gmail.com" and phone is "1234567890"
When click on "Submit"
Then System display message "Product Added Successfully" with "Ok" button
And clicking on "Ok" will take seller on "Home" page

Scenario: Data is invalid
Given farmer enter name "ABC123" and contact number "12345"
When click on "Submit"
Then System display error message "Data is invalid" with "Ok" button
And clicking on "Ok" will remain on the same page
And the values in the fields will remain same

Scenario: Cancel while Creating Product
Given user clicks on "Create" button 
And fill all details
When user clicks on "Cancel" button
Then System redirects to "Home" page

