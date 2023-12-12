USE [EmployeeManagement]
GO

/****** Object:  Table [dbo].[Employees]    Script Date: 11/12/2023 18:31:21 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Employees](
	[EmployeeID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](30) NOT NULL,
	[LastName] [varchar](50) NOT NULL,
	[Address1] [varchar](100) NOT NULL,
	[Payment] [decimal](10, 2) NOT NULL,
	[EmployeeType] [int] NOT NULL,
	[PaymentType] [int] NOT NULL,
 CONSTRAINT [PK_Employees] PRIMARY KEY CLUSTERED 
(
	[EmployeeID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


CREATE TABLE [dbo].[Expenses](
	[EmployeeID] [int] NOT NULL FOREIGN KEY REFERENCES Employees(EmployeeID),
	[MaxExpenseAmount] [decimal](10, 2) NOT NULL
) ON [PRIMARY]
GO