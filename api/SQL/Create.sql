
IF OBJECT_ID('dbo.Cell', 'U') IS NOT NULL 
  DROP TABLE dbo.Cell; 

CREATE TABLE Cell (
    Id INT NOT NULL IDENTITY PRIMARY KEY,
    [Key] VARCHAR(36),
    Url VARCHAR(255)
)

IF OBJECT_ID('dbo.Board', 'U') IS NOT NULL 
  DROP TABLE dbo.Board; 

CREATE TABLE Board (
    Id INT NOT NULL IDENTITY PRIMARY KEY,
    [Key] VARCHAR(36)
)

IF OBJECT_ID('dbo.BoardCell', 'U') IS NOT NULL 
  DROP TABLE dbo.BoardCell; 

CREATE TABLE BoardCell (
    BoardId INT,
    CellId INT,
    FOREIGN KEY (BoardId) REFERENCES Board(Id) ON DELETE CASCADE,
    FOREIGN KEY (CellId) REFERENCES Cell(Id) ON DELETE CASCADE,
    PRIMARY KEY (BoardId, CellId)
)

IF OBJECT_ID('dbo.Player', 'U') IS NOT NULL 
  DROP TABLE dbo.Player; 

CREATE TABLE Player (
    Id INT NOT NULL IDENTITY PRIMARY KEY,
    [Key] VARCHAR(36),
    FirstName VARCHAR(50),
    LastName VARCHAR(50)
)

IF OBJECT_ID('dbo.Game', 'U') IS NOT NULL 
  DROP TABLE dbo.Game; 

CREATE TABLE Game (
    Id INT NOT NULL IDENTITY PRIMARY KEY,
    [Key] VARCHAR(36)
)

IF OBJECT_ID('dbo.GamePlayerBoard', 'U') IS NOT NULL 
  DROP TABLE dbo.GamePlayerBoard; 

CREATE TABLE GamePlayerBoard (
    BoardId INT,
    GameId INT,
    PlayerId INT,
    FOREIGN KEY (BoardId) REFERENCES Board(Id) ON DELETE CASCADE,
    FOREIGN KEY (GameId) REFERENCES Game(Id) ON DELETE CASCADE,
    FOREIGN KEY (PlayerId) REFERENCES Player(Id) ON DELETE CASCADE,
    PRIMARY KEY (BoardId, GameId, PlayerId)
)

