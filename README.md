# SalesScreen Case Interview
Case interview assignment for Software Engineer position @ SalesScreen

## Prerequisites

* [Visual Studio Code](https://code.visualstudio.com/download)
* [.NET Core 2.2](https://dotnet.microsoft.com/download)
* [C# extension](https://marketplace.visualstudio.com/items?itemName=ms-vscode.csharp) from VS Code Marketplace


## Get Started
Fork this GitHub repository to you personal account and clone the repository to your local machine. Open the folder in Visual Studio Code. A "Would you like to add the required assets to build and debug your project?" notification appears at the top of the window, select *Yes*.

To debug the code, press F5. The application entrypoint is the Main method in Program.cs.

We recommend you keep some notes on how you solve each task, you will be asked about your approach in the interview. To make it easier to review you code, we also recommend that you create separate commits for each task.

## Tasks
The overall goal of this assignment is to create a simple banking application. The application will consist of a simple C#/.NET Core console application that fetches JSON data from a REST API. The application has no UI elements, and simply prints the results to the console.


### Task 1
First we want to determine the amount of available funds on our bank account. Available funds are defined as the sum of the current balance and the credit available on the account. As the first customer of this hypothetical bank, we've received an account with ID=1.

Information about a single bank account can be fetched from the Account endpoint in the API. The endpoint accepts an account ID as input, and returns some basic information for the account specified. If the account ID is not valid, the endpoint will return a 404 Not Found status code. A valid response looks like this: 

GET api/account/{accountId}
```
{
    "id": 1,
    "balance": 10000.0,
    "created": "2019-01-01T00:00:00",
    "credit": 5000.0
}
```

The code for fetching the account information is already implemented, but its not currently working as expected. Your tasks is to find the errors in the current code, and correct them. The expected answer is 15000.


### Task 2
Next we want to get an overview of the expenses on our account. The Transaction endpoint in the API can be used to list all the transactions for an account. Your task is to extend the current code to print the total amount of all expenses the last 30 days, as well as the average value for those transactions.

The Transaction endpoint accepts an account ID as input, and returns all the transactions for that account within the current year. If the account ID is not valid, the endpoint will return a 400 Bad Request status code. A valid response looks like this:

GET api/transaction/{accountId}
```
[
    {
        "id": 1,
        "amount": 100.0,
        "categoryId": 1,
        "date": "2019-01-01T00:00:00"
    },
    {
        "id": 2,
        "amount": 200.0,
        "categoryId": 2,
        "date": "2019-01-03T00:00:00"
    },
    ...
]
```

### Task 3
Now that we have a perception for how our monthly expenses looks like, we've created a monthly budget. The budget is separated into different categories, each with an assigned amount. To validate if the budget we have created is realistic, we want to compare it with the actual expenses for the last 3 full months. The task is to print a list of all the categories for each month, with the difference between the actual expenses and the budget. An example output could look like this:

```
March - Clothing: -200
...

April - Clothing: +350
...

May - Clothing: -600
...
```

OBS!: These are only examples and not necessarily equal to the actual numbers.

To list all the different categories you can use the Category endpoint. This endpoint lists all the different categories and accepts no input. The response looks like this:

GET api/category
```
[
    {
        "id": 1,
        "name": "Groceries"
    },
    {
        "id": 2,
        "name": "Restaurant"
    },
    ...
]
```

To fetch the monthly budgeted amount for each category you can use the Budget endpoint. This endpoint will return the ID of each category with the correponding budget amount. The endpoint accepts an account ID as input. If the account ID is not valid, the endpoint will return a 400 Bad Request status code. A valid response looks like this:

GET api/budget/{accountId}
```
[
    {
        "categoryId": 1,
        "amount": 3000.0
    },
    {
        "categoryId": 2,
        "amount": 1500.0
    },
    ...
]
```