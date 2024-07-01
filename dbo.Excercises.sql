CREATE TABLE [dbo].[Excercises] (
    [Id]          INT            IDENTITY (1, 1) NOT NULL,
    [Name]        NVARCHAR (MAX) NOT NULL,
    [Description] NVARCHAR (MAX) NOT NULL,
    [BodyPartID]  INT            NOT NULL,
    CONSTRAINT [PK_Excercises] PRIMARY KEY CLUSTERED ([Id] ASC),
	FOREIGN KEY (BodyPartID) REFERENCES BodyParts(Id)
	
);

