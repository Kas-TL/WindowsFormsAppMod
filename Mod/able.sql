USE [44П-экзамен-ПМ-01-Зуев]
GO

/****** Object:  Table [dbo].[Table_1]    Script Date: 18.04.2022 9:45:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Table_1](
	[id] [varchar](50) NULL,
	[Название] [varchar](50) NULL,
	[Жанр] [varchar](50) NULL,
	[Автор] [varchar](50) NULL,
	[Кол-во в магазине] [varchar](50) NULL,
	[Количество на складе] [varchar](50) NULL,
	[Описание] [varchar](max) NULL,
	[Обложка] [varchar](50) NULL
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO

