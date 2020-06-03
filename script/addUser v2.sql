USE [sms]
GO

/****** Object:  Table [dbo].[Users]    Script Date: 02-06-2020 20:15:52 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[Users](
	[UserId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[Email] [varchar](100) NULL,
	[UserName] [varchar](100) NULL,
	[Password] [varchar](200) NULL,
	[IsActive] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[UserId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [df_Password]  DEFAULT ('admin@123') FOR [Password]
GO

ALTER TABLE [dbo].[Users] ADD  CONSTRAINT [df_IsActive]  DEFAULT ((1)) FOR [IsActive]
GO


