# Exercise---AssociativeArrays

1.	Count Chars in a String
Create a program that counts all characters in a string, except for space (' '). 
Print all the occurrences in the following format:
"{char} -> {occurrences}"

2.	A Miner Task
You will be given a sequence of strings, each on a new line. Every odd line on the console is representing a resource (e.g. Gold, Silver, Copper and so on) and every even - quantity. Your task is to collect the resources and print them each on a new line.
Print the resources and their quantities in the following format:
"{resource} –> {quantity}"
The quantities will be in the range [1… 2 000000000].

3.	Orders
Create a program that keeps the information about products and their prices. Each product has a name, a price and a quantity. If the product doesn't exist yet, add it with its starting quantity.
If you receive a product, which already exists, increase its quantity by the input quantity and if its price is different, replace the price as well.
You will receive products' names, prices and quantities on new lines. Until you receive the command "buy", keep adding items. When you do receive the command "buy", print the items with their names and the total price of all the products with that name.
Input
•	Until you receive "buy", the products will be coming in the format: "{name} {price} {quantity}".
•	The product data is always delimited by a single space.
Output
•	Print information about each product in the following format: 
"{productName} -> {totalPrice}"
•	Format the average grade to the 2nd digit after the decimal separator.

4.	SoftUni Parking
Write a program, which validates a parking place for an online service. Users can register to park and unregister to leave.
The program receives 2 commands:	
•	"register {username} {licensePlateNumber}":
o	The system only supports one car per user at the moment, so if a user tries to register another license plate, using the same username, the system should print:
"ERROR: already registered with plate number {licensePlateNumber}"
o	If the aforementioned checks passes successfully, the plate can be registered, so the system should print:
 "{username} registered {licensePlateNumber} successfully"
•	"unregister {username}":
o	If the user is not present in the database, the system should print:
"ERROR: user {username} not found"
o	If the aforementioned check passes successfully, the system should print:
"{username} unregistered successfully"
After you execute all of the commands, print all of the currently registered users and their license plates in the format: 
•	"{username} => {licensePlateNumber}"

5. Courses
Create a program that keeps the information about courses. Each course has a name and registered students.
You will be receiving a course name and a student name, until you receive the command "end". Check if such a course already exists, and if not, add the course. Register the user into the course. When you receive the command "end", print the courses with their names and total registered users. For each contest print the registered users.
Input
•	Until the "end" command is received, you will be receiving input in the format: "{courseName} : {studentName}".
•	The product data is always delimited by " : ".
Output
•	Print the information about each course in the following the format: 
"{courseName}: {registeredStudents}"
•	Print the information about each student in the following the format:
"-- {studentName}"

6. Student Academy
Create a program that keeps the information about students and their grades. 
You will receive n pair of rows. First, you will receive the student's name, after that, you will receive their grade. Check if the student already exists and if not, add him. Keep track of all grades for each student.
When you finish reading the data, keep the students with an average grade higher than or equal to 4.50.
Print the students and their average grade in the following format:
"{name} –> {averageGrade}"
Format the average grade to the 2nd decimal place.

7. Company Users
Create a program that keeps information about companies and their employees. 
You will be receiving a company name and an employee's id, until you receive the "End" command. Add each employee to the given company. Keep in mind that a company cannot have two employees with the same id.
When you finish reading the data, print the company's name and each employee's id in the following format:
{companyName}
-- {id1}
-- {id2}
-- {idN}
Input / Constraints
•	Until you receive the "End" command, you will be receiving input in the format: "{companyName} -> {employeeId}".
•	The input always will be valid.



