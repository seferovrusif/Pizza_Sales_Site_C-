Pizza Order Management System (C#)

## Description

This project is a simple console-based management system developed for handling pizza orders. It was written during my learning period and has not been further developed to avoid wasting time on it. However, it still works with basic functionality. The project is focused on practicing object-oriented programming (OOP) in C# and basic system management (Admin and Member roles).

## Features

- **User Authentication**: Users can log in or sign up. There are two roles: Admin and Member.
- **Product Management**: Admin users can add, update, or remove products. Members can only view products.
- **Cart and Order Management**: Members can add products to their cart, view their cart, and complete their orders.
- **Role-Based Access**: Admin users can manage products and control user operations, while Member users can only make purchases.
- **Simple Data Structure**: Simple in-memory lists are used for database operations.

## Project Structure

- **Program.cs**: Contains the main program and user interactions based on login. Users can log in as an admin or a member.
- **Users and Products**: Admin users can manage products, while Member users can only view products and manage their cart.
- **Service Classes**: Contains services for user and product operations such as adding, updating, and deleting products.
- **Validation**: Login and signup validation is handled by `UserValidation` and `SignInSignUpService` classes.

## Technologies Used

- **C# Console Application**: The basic user interaction is built using a console application.
- **Object-Oriented Programming (OOP)**: Classes like `User`, `Product`, `Order`, `Role` are used to apply fundamental object-oriented principles.
- **In-Memory Database Simulation**: Data is stored in in-memory lists.

## Usage

1. **Setting Up the Project**:  
   - Clone the repository:
     ```bash
     git clone link
     ```
   - Open the project in Visual Studio or another C# IDE and run it.

2. **User Login**:  
   - To log in, enter your email and password. If you don’t have an account, you can sign up for a new user.

3. **Admin Features**:  
   - Admin users can manage products (add, delete, update).
   - Admins can also manage users.

4. **Member Features**:  
   - Member users can view products, add them to the cart, and complete their orders.

## Future Improvements

- Implementing a real database to make the system more robust.
- Developing a user interface to provide a more user-friendly experience.
- Adding features like order tracking, payment integration, and more advanced order options for users.

## License

This project is licensed under the MIT License.
