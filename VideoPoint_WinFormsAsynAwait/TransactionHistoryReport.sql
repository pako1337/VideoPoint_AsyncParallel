SELECT *
FROM Production.TransactionHistory th
INNER JOIN Production.TransactionHistoryArchive tha ON th.Quantity = tha.Quantity
INNER JOIN Production.Product prod ON prod.ProductId = th.ProductID
WHERE th.TransactionDate > '2014-08-02'