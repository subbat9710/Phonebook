# Phonebook
This phonebook app was developed using ASP.NET MVC, EntityFramework, and MS SQL Server to provide users with a simple and efficient way to manage their contacts. 
Users can add, edit, and delete contacts, search for contacts by name or phone number, and view contact details such as email address and physical address.

The app features a clean and intuitive user interface, with a simple layout and easy-to-use navigation. Contacts are stored using MS SQL Server and EntityFramework, 
allowing for efficient data storage and retrieval.

To ensure secure user access, EntityFramework Identity was used for user login with role-based access control. Users can create an account, log in, and access 
the app's features based on their assigned roles. For example, an administrator can view and edit all contacts, while a regular user can only view and edit their 
own contacts.

During development, one of the main challenges was ensuring that the role-based access control was implemented correctly and securely. This was overcome by thoroughly 
testing the app's authentication and authorization mechanisms and making sure that all user roles were properly defined and assigned.
