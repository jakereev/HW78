CREATE DATABASE HomeAccounting;
GO

USE HomeAccounting;
GO

CREATE TABLE ExpenseCategories
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(50) NOT NULL
);
GO

CREATE TABLE Expenses
(
    Id INT PRIMARY KEY IDENTITY(1,1),
    Comment NVARCHAR(255),
    Cost DECIMAL(10,2) NOT NULL,
    CategoryId INT,
    FOREIGN KEY (CategoryId) REFERENCES ExpenseCategories(Id)
);
GO