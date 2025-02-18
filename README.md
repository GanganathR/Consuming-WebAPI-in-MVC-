Use React JS as the JavaScript framework.
Use Aggrid for table
Use Material-UI or Antd as the CSS framework

Make use of Create React App/Vite cli to create a simple “Café Employee” manager that reads from the Backend Program created earlier.

Task 
Instructions
Create a Web application where it has 2 pages. Cafes and Employees.

Café Page:
•	This should call the GET /cafes endpoint.
•	Display a list of cafes in a table:
•	Logo
•	Name
•	Description
•	Employees
•	Location
•	Edit/Delete button on each row at the end of the row. 
•	There should be a way to filter the list via the location. 
•	Upon clicking on the employees, it should go to the employee page and show a list of the employees under the café.
•	There should be an “Add New Café” button on the page

 
Employee Page:
•	This should call the GET /employees endpoint.
•	Display a list of employees in a table:
•	Employee id
•	Name
•	Email address
•	Phone number
•	Days worked in the café
•	Café name
•	Edit/Delete button on each row at the end of the row. 
•	There should be an “Add New Employee” button on the page


 
Add/Edit Café Page:
•	A form with the following:
o	Name [Reusable Textbox] Minimum 6 character and max 10 characters validation. 
o	Description [Reusable Textbox] Max 256 chars validation
o	Logo [File] Max 2mb validation
o	Location [Reusable Textbox]
o	Submit [Button] which will call POST/café or PUT/café 
o	Cancel [Button] which will bring you back to café page.
•	Warn user if there are unsaved changes on the page before navigating away. 
•	If user enters this page via Edit, the form should be prefilled with the café’s information


Add/Edit Employee Page:
•	A form with the following:
o	Name [Reusable Textbox] Minimum 6 character and max 10 characters validation. 
o	Email address [Reusable Textbox] email validation. 
o	Phone number: SG phone number validation (starts with 8 or 9, and have 8 digits). 
o	Gender [Radio Button Group]
o	Assigned Café (Dropdown box) 
o	Submit [Button] which will call POST/employee or PUT/employee, and assign the employee to a café .
o	Cancel [Button] which will bring you back to employee page.
•	Warn user if there are unsaved changes on the page before navigating away. 
•	If user enters this page via Edit, the form should be prefilled with the employee’s information


The Delete button on all pages will have a confirmation pop-up message to proceed with the deletion. After the deletion, the page should refresh to reflect the deletion.
