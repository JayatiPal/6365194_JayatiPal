SELECT * FROM (
    SELECT Category, ProductName, Price,
           ROW_NUMBER() OVER (
               PARTITION BY Category 
               ORDER BY Price DESC
           ) AS RowNumRank
    FROM Products
) ranked
WHERE RowNumRank <= 3;

SELECT * FROM (
    SELECT Category, ProductName, Price,
           RANK() OVER (
               PARTITION BY Category 
               ORDER BY Price DESC
           ) AS Rank
    FROM Products
) ranked
WHERE Rank <= 3;

SELECT * FROM (
    SELECT Category, ProductName, Price,
           DENSE_RANK() OVER (
               PARTITION BY Category 
               ORDER BY Price DESC
           ) AS DenseRank
    FROM Products
) ranked
WHERE DenseRank <= 3;
