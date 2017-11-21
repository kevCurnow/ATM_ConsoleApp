SET IDENTITY_INSERT Accounts ON 
GO
INSERT INTO Accounts(AccountID, AccountNumber, PIN, AccountType, CustomerID)
Values(1, 1234567, 1234, 1, 1);
SET IDENTITY_INSERT Accounts OFF