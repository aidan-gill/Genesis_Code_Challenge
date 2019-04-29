# Genesis_Code_Challenge

# Created to host the code test project for Genesis Automation. 
# Project created in VS2013 with .Net Framework 4.7 and Dev Express controls 17.2

Reading from the Orders database, tables created from the script provided. 

Orders Screen
•	The Orders screen should show a list of orders from the Orders table in the database. 
•	The data should be populated by a DevExpress grid, and the following columns should be shown: ReferenceNumber, OrderValue, OrderDate, CustomerName
•	The OrderValue should be formatted to two decimal places and should use the currency format of the Windows environment. 
•	The OrderDate should be formatted to dd-MMM-yyyy (“01-Sep-2018”)
•	The Customer Name field should be a combination of the Customer’s First Name and Last Name.  
•	A “View Customer” button should be present on every row after the additional columns. When clicked, it should load the View Customer Screen. 

Customer Screen
•	The View Customer Screen should be a form-based screen with the following fields: 
First Name, Last Name
•	The First Name and Last Name should be editable. 
•	The form should have a Cancel | Save button.
•	When Save is clicked, the form should close.
•	The previous screen should refresh the list of orders and show the changed Customer Name. 

