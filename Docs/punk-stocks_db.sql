CREATE TABLE Users (
    UserID INT IDENTITY(1,1) PRIMARY KEY,
    Username NVARCHAR(50)  NOT NULL UNIQUE,
    PasswordHash NVARCHAR(100) NOT NULL,
    CashBalance DECIMAL(18,2) NOT NULL DEFAULT 0,
    Theme INT NOT NULL DEFAULT 0, -- 0 = Light, 1 = Dark
    Language INT NOT NULL DEFAULT 0, -- 0 = English, 1 = French
    IsAdmin BIT NOT NULL DEFAULT 0,
    CreatedAt DATETIME2 NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Stocks (
    StockID INT IDENTITY(1,1) PRIMARY KEY,
    Symbol NVARCHAR(10)  NOT NULL UNIQUE,
    CompanyName NVARCHAR(100) NOT NULL,
    Sector NVARCHAR(50)  NOT NULL,
    CurrentPrice DECIMAL(18,2) NOT NULL CHECK (CurrentPrice > 0),
    Volatility DECIMAL(9,4)  NOT NULL DEFAULT 0.02,
    DividendYield DECIMAL(9,4)  NOT NULL DEFAULT 0
);

CREATE TABLE Holdings (
    HoldingID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL REFERENCES Users(UserID) ON DELETE CASCADE,
    StockID INT NOT NULL REFERENCES Stocks(StockID),
    Quantity INT NOT NULL CHECK (Quantity > 0),
    AvgCost DECIMAL(18,2) NOT NULL,
    UNIQUE (UserID, StockID)
);

CREATE TABLE Transactions (
    TransactionID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL REFERENCES Users(UserID) ON DELETE CASCADE,
    StockID INT NOT NULL REFERENCES Stocks(StockID),
    TransactionType INT NOT NULL CHECK (TransactionType IN (0,1)), -- 0 = Buy, 1 = Sell
    Quantity INT NOT NULL CHECK (Quantity > 0),
    PricePerShare DECIMAL(18,2) NOT NULL,
    ExecutedAt DATETIME2 NOT NULL DEFAULT GETDATE()
);

CREATE TABLE WatchlistItems (
    WatchlistItemID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL REFERENCES Users(UserID) ON DELETE CASCADE,
    StockID INT NOT NULL REFERENCES Stocks(StockID),
    AddedAt DATETIME2 NOT NULL DEFAULT GETDATE(),
    UNIQUE (UserID, StockID)
);

CREATE TABLE Alerts (
    AlertID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL REFERENCES Users(UserID) ON DELETE CASCADE,
    StockID INT NOT NULL REFERENCES Stocks(StockID),
    TargetPrice DECIMAL(18,2) NOT NULL,
    Direction INT NOT NULL CHECK (Direction IN (0,1)), -- 0 = Above, 1 = Below
    IsTriggered BIT NOT NULL DEFAULT 0
);

CREATE TABLE PriceHistories (
    PriceHistoryID INT IDENTITY(1,1) PRIMARY KEY,
    StockID INT NOT NULL REFERENCES Stocks(StockID),
    Price DECIMAL(18,2) NOT NULL,
    RecordedAt DATETIME2 NOT NULL DEFAULT GETDATE()
);

CREATE TABLE Dividends (
    DividendID INT IDENTITY(1,1) PRIMARY KEY,
    UserID INT NOT NULL REFERENCES Users(UserID) ON DELETE CASCADE,
    StockID INT NOT NULL REFERENCES Stocks(StockID),
    Amount DECIMAL(18,2) NOT NULL,
    PaidAt DATETIME2 NOT NULL DEFAULT GETDATE()
);

INSERT INTO Stocks (Symbol, CompanyName, Sector, CurrentPrice)
VALUES ('TEST', 'Test Company', 'Technology', 100.00);

UPDATE Stocks SET CurrentPrice = 125.50 WHERE Symbol = 'TEST';

DELETE FROM Stocks WHERE Symbol = 'TEST';

SELECT * FROM Stocks;