Feature: Testing Create Product
Scenario Outline: Testing Creation of Product
Given farmer <farmername> has entered product <productname>
And his email is <email> and phone <phone>
When click on button <submitbutton>
Then System display message <message> with button <okbutton>
And clicking on button <okbutton> will take seller on page <homepage>

Examples: 
| farmername | productname | email           | phone        | submitbutton | okbutton | message |
| "ABC"      | "Rice"      | "abc@gmail.com" | "1234567890" | "Submit"     | "Ok"     | "Product Added Successfully" |
| "ABC1111"      | "Rice"      | "abc@gmail.com" | "1234567890" | "Submit"     | "Ok"     | "Data is invalid" |

Scenario Outline: Testing of invalid data
Given farmer <farmername> has the entered product <productname>
And his email is <email> and with phone <phone>
When farmer click on button <submitbutton>
Then System display the message <message> with button <okbutton>
And clicking on the button <okbutton> will take seller on page <homepage>

Examples: 
| farmername | productname | email           | phone        | submitbutton | okbutton | message |
| "ABC123"      | "Rice"      | "abc@gmail.com" | "1234567890" | "Submit"     | "Ok"     | "Data is invalid" |
