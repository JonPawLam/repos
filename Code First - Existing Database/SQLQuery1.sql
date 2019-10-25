	CREATE TABLE Product 
	(
	[ProductId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY,
	
    [Product] NVARCHAR(50) NULL, 
    [Price] FLOAT NULL, 
	)
	

	CREATE TABLE Cart 
	(
	[CartId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	[OrderID] NVARCHAR(50) NULL,
    [ProductID] INT NULL, 
    [Quantity] FLOAT NULL, 

	FOREIGN KEY (ProductId) REFERENCES Product(ProductId)
	)

			CREATE TABLE Receit 
	(
	[OrderId] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
	[CostumerNo] INT NULL,
    [DateOfOrder] DATE NULL, 
	FOREIGN KEY (CostumerNo) REFERENCES Costumer(CostumerNo)
	)
	
	CREATE TABLE Costumer 
	(
	[CostumerNo] INT IDENTITY(1,1) NOT NULL PRIMARY KEY, 
    [FirstName] NVARCHAR(50) NULL, 
    [LastName] NVARCHAR(50) NULL,
	[CostumerAddress] NVARCHAR(50) NULL,
	)



	--Add Products
	INSERT INTO dbo.Product
	(
	    Product,
	    Price
	)
	VALUES
	(   N'IceTea', -- Product - nvarchar(50)
	    5.0  -- Price - float
	    )

	--Add Cart
	INSERT INTO dbo.Cart
	(
	    OrderID,
	    ProductID,
	    Quantity
	)
	VALUES
	(   N'1', -- OrderID - nvarchar(50)
	    1,   -- ProductID - int
	    1.0  -- Quantity - float
	    )


	--Add Receit 
	INSERT INTO dbo.Receit
	(
	    CostumerNo,
	    DateOfOrder
	)
	VALUES
	(   1,        -- CostumerNo - int
	    GETDATE() -- DateOfOrder - date
	    )

	--Add Costumer
	INSERT INTO dbo.Costumer
	(
	    FirstName,
	    LastName,
	    CostumerAddress
	)
	VALUES
	(   N'Firstname1', -- FirstName - nvarchar(50)
	    N'LastName1', -- LastName - nvarchar(50)
	    N'Street1'  -- CostumerAddress - nvarchar(50)
	)
		
