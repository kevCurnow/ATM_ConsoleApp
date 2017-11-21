SET IDENTITY_INSERT Customers ON 
GO
INSERT INTO Customers(CustomerID, FirstName, LastName)
Values(1, 'John', 'Smith');
SET IDENTITY_INSERT Accounts OFF