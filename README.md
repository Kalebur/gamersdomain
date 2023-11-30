# Gamers' Domain E-Commerce Site
---
![Gamers' Domain Homepage](https://cdn.discordapp.com/attachments/1090349167890669578/1179668663691903036/gd-home-page.jpg?ex=657a9f0e&is=65682a0e&hm=16ea64f72b6ed900ff3b6f94ae8e210dc26edb0bb70a74e43e6a1d91e2a2a109&)
This project is an e-commerce application built using Blazor. It uses Entity Framework Core and SQLite to store a list of products and categories and display those to the users on the site. Users can browse a list of all products on the home page or narrow down their selection to products in a specific category by clicking one of the categories along the top of the page. Clicking into a product's page shows a bigger image of the product and lets users add the product to their shopping cart. The cart icon along the top shows the number of unique items in the cart, and clicking that icon will take you to the cart screen where you can update desired quantities or remove items from the cart entirely. Products in the shopping cart are saved to the browser's local storage to persist the data between sessions.

**There is no final checkout process currently implemented. Clicking the checkout button on the cart screen will only take you to an empty page with the 'Checkout' heading.**

## How to Run the Project
---
1. Clone the repo to your PC
2. Open the gamersdomain.sln file in Visual Studio
3. Ensure that the gamersdomain.Server project is selected in the Startup Projects dropdown ![Highlighted Startup Projects button](https://cdn.discordapp.com/attachments/1090349167890669578/1179673085704667146/startup.png?ex=657aa32c&is=65682e2c&hm=724987cb17ba8b91f08ac9627d9a97c05bb8298b3db5c753a2120d105799e3ca&)
4. Click the green Play button to run the project

A seeded database that includes some test products has been included with the commit files to make it easier to run and test the repo out of the box without having to perform any additional steps or configuration.

## Code:You Features List
---
The features I've chosen to implement in my capstone project for Code:You are as follows:

1. Create a dictionary or list, populate it with several values, retrieve at least one value, and use it in your program
2. Make a generic class and use it (ServiceResponse is a generic class and is used in the server product service)
3. Make your application an API (You can view/test the API endpoints by appending /swagger/index.html to the base URL)
4. Make your application asynchronous
5. Query your database using a raw SQL query, not EF (The GetProductById() method uses a raw SQL query to find and return the matching product)


## Technologies Used
---
* .NET/C#
* Blazor
* Entity Framework Core
* SQLite
