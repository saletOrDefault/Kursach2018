CREATE TABLE [dbo].[Items]
(
	[ItemId] INT NOT NULL identity, 
    [Item] NCHAR(50) NOT NULL, 
    [DateFound] DATETIME NOT NULL, 
    [DateBrought] DATETIME NULL, 
    [Description] NCHAR(300) NULL, 
   [District] NCHAR(30) NULL, 
    PRIMARY KEY ([ItemId]),
	FOREIGN KEY ([District]) REFERENCES [dbo].[Districts] ([District])
)
