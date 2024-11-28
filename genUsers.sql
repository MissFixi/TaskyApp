USE [TaskyAppDB]
GO
SET IDENTITY_INSERT [dbo].[Users] ON 
GO
INSERT [dbo].[Users] ([IdUser], [FirstName], [LastName], [IdManager]) VALUES (1, N'John', N'Doe', NULL)
GO
INSERT [dbo].[Users] ([IdUser], [FirstName], [LastName], [IdManager]) VALUES (2, N'Mark', N'Hanberg', 1)
GO
INSERT [dbo].[Users] ([IdUser], [FirstName], [LastName], [IdManager]) VALUES (3, N'Daniele', N'Smith', 1)
GO
INSERT [dbo].[Users] ([IdUser], [FirstName], [LastName], [IdManager]) VALUES (4, N'Ben', N'Stark', 1)
GO
INSERT [dbo].[Users] ([IdUser], [FirstName], [LastName], [IdManager]) VALUES (5, N'Emilie', N'Clover', 2)
GO
SET IDENTITY_INSERT [dbo].[Users] OFF
GO
