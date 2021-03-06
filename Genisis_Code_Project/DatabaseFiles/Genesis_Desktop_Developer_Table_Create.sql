USE [Orders]
GO
/****** Object:  Table [dbo].[Customer]    Script Date: 18/09/2018 15:45:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Customer](
	[Id] [uniqueidentifier] NOT NULL,
	[FirstName] [nvarchar](50) NOT NULL,
	[LastName] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Customer] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Order]    Script Date: 18/09/2018 15:45:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Order](
	[Id] [uniqueidentifier] NOT NULL,
	[CustomerId] [uniqueidentifier] NOT NULL,
	[ReferenceNumber] [nvarchar](50) NOT NULL,
	[OrderValue] [decimal](18, 7) NOT NULL,
	[OrderDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Order] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Customer] ([Id], [FirstName], [LastName]) VALUES (N'88a96958-a302-4913-9adc-1997b49c7571', N'John', N'Smith')
GO
INSERT [dbo].[Customer] ([Id], [FirstName], [LastName]) VALUES (N'18e8112f-b28e-4124-94b2-1ad1e5f1a868', N'Jane', N'Jones')
GO
INSERT [dbo].[Customer] ([Id], [FirstName], [LastName]) VALUES (N'a0a21498-8538-4539-9f44-b283803afd1c', N'Ray', N'Charles')
GO
INSERT [dbo].[Customer] ([Id], [FirstName], [LastName]) VALUES (N'd9382a08-da4f-4425-9a3b-bb372ce1c012', N'Bruce', N'Murphy')
GO
INSERT [dbo].[Customer] ([Id], [FirstName], [LastName]) VALUES (N'c17a59df-0c7d-4f61-9bb9-e467861984a6', N'Alice', N'Doyle')
GO
INSERT [dbo].[Order] ([Id], [CustomerId], [ReferenceNumber], [OrderValue], [OrderDate]) VALUES (N'059fc228-6a3c-4f94-b4f5-2850b593e417', N'88a96958-a302-4913-9adc-1997b49c7571', N'1', CAST(50.0000000 AS Decimal(18, 7)), CAST(N'2018-09-01T11:17:37.423' AS DateTime))
GO
INSERT [dbo].[Order] ([Id], [CustomerId], [ReferenceNumber], [OrderValue], [OrderDate]) VALUES (N'74b205d5-0171-4955-815d-66991df3a0ed', N'a0a21498-8538-4539-9f44-b283803afd1c', N'4', CAST(150.7566000 AS Decimal(18, 7)), CAST(N'2018-09-04T11:27:23.737' AS DateTime))
GO
INSERT [dbo].[Order] ([Id], [CustomerId], [ReferenceNumber], [OrderValue], [OrderDate]) VALUES (N'd5b2fd42-bff1-48ed-9ddb-741f962d1de9', N'18e8112f-b28e-4124-94b2-1ad1e5f1a868', N'3', CAST(75.9900000 AS Decimal(18, 7)), CAST(N'2018-09-03T11:27:23.737' AS DateTime))
GO
INSERT [dbo].[Order] ([Id], [CustomerId], [ReferenceNumber], [OrderValue], [OrderDate]) VALUES (N'79379356-8b98-4f56-9780-849767db6014', N'88a96958-a302-4913-9adc-1997b49c7571', N'2', CAST(5000.0000340 AS Decimal(18, 7)), CAST(N'2018-09-02T11:17:37.423' AS DateTime))
GO
INSERT [dbo].[Order] ([Id], [CustomerId], [ReferenceNumber], [OrderValue], [OrderDate]) VALUES (N'f7e85dcb-3ba2-48dd-87d6-df5b38b05f3f', N'd9382a08-da4f-4425-9a3b-bb372ce1c012', N'5', CAST(99.9900000 AS Decimal(18, 7)), CAST(N'2018-09-04T11:27:23.737' AS DateTime))
GO
ALTER TABLE [dbo].[Order]  WITH CHECK ADD  CONSTRAINT [FK_Order_Customer] FOREIGN KEY([CustomerId])
REFERENCES [dbo].[Customer] ([Id])
GO
ALTER TABLE [dbo].[Order] CHECK CONSTRAINT [FK_Order_Customer]
GO
