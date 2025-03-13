Pizza Order Management System
Description
This project is a basic pizza order management system created as part of a learning exercise during my studies. While I did not spend additional time improving or expanding the project beyond its initial scope, it serves as a functional example of handling orders, users, and products using object-oriented programming principles in C#. The project demonstrates how to build a simple pizza ordering system, including features such as user authentication, product management, and order processing.

Features
User Authentication: Users can sign up, log in, and manage their details. The system supports two roles: Admin and Member.
Pizza Catalog: Admins can add, update, and remove pizzas from the catalog. Members can browse the catalog.
Order Management: Users can add pizzas to their basket and place orders, with validation for user input such as phone numbers.
Database Simulation: The project uses in-memory lists to simulate a database for products, users, and orders.
Exceptions Handling: Various custom exceptions are used to handle common issues like invalid user input or missing products.
Project Structure
Models: Contains classes for Product, User, Order, and a simple Database simulation.
Utilities: Contains services for order handling, user management, and product catalog management. Includes validation and exception handling for various user actions.
Exceptions: Custom exceptions like PizzaNotFoundException, WrongPasswordException, and UserNotFoundException are implemented for error handling.
Technologies Used
C# (Console Application)
Object-Oriented Programming (OOP)
Custom Exception Handling
Basic In-Memory Database Simulation
Installation
Clone the repository:
git clone https://github.com/your-username/PizzaOrderSystem.git

Open the solution in Visual Studio or any C# IDE.

Build and run the project.

Usage
Sign Up / Log In: Create a new user or sign in with existing credentials.
Admin Features: Add, update, or delete pizzas from the catalog.
Member Features: Browse available pizzas, add them to the basket, and complete the order.
Future Improvements
This project was created for educational purposes and has not been extended with additional features. However, future improvements could include:
Implementing a proper database system (e.g., SQL or NoSQL).
Enhancing the user interface (e.g., using a GUI framework like WPF).
Adding features like payment integration, pizza customization, and more robust user management.
License
This project is licensed under the MIT License.

