CREATE TABLE [dbo].[MT_UserActivity](
	[UserActivityID] [int] IDENTITY(1,1) NOT NULL,
	[UserID] [nvarchar](50) NULL,
	[UserLogin] [nvarchar](50) NULL,
	[LogInDate] [datetime] NULL,
	[Status] [nvarchar](50) NULL,
	[IP] [nvarchar](50) NULL,
	[BledneHaslo] [nvarchar](50) NULL,
 CONSTRAINT [PK_MT_UserActivity] PRIMARY KEY CLUSTERED 
(
	[UserActivityID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


