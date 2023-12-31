USE [PatientDb]
GO
SET IDENTITY_INSERT [dbo].[Allergies] ON 

INSERT [dbo].[Allergies] ([Id], [Name]) VALUES (1, N'Drugs - Penicillin')
INSERT [dbo].[Allergies] ([Id], [Name]) VALUES (2, N'Drugs - Others')
INSERT [dbo].[Allergies] ([Id], [Name]) VALUES (3, N'Animals')
INSERT [dbo].[Allergies] ([Id], [Name]) VALUES (4, N'Food')
INSERT [dbo].[Allergies] ([Id], [Name]) VALUES (5, N'Ointments')
INSERT [dbo].[Allergies] ([Id], [Name]) VALUES (6, N'Plant')
INSERT [dbo].[Allergies] ([Id], [Name]) VALUES (7, N'Sprays')
INSERT [dbo].[Allergies] ([Id], [Name]) VALUES (8, N'Others')
INSERT [dbo].[Allergies] ([Id], [Name]) VALUES (9, N'No Allergies')
SET IDENTITY_INSERT [dbo].[Allergies] OFF
GO
SET IDENTITY_INSERT [dbo].[Diseases] ON 

INSERT [dbo].[Diseases] ([Id], [Name]) VALUES (1, N'Dengue')
INSERT [dbo].[Diseases] ([Id], [Name]) VALUES (2, N'Covid-19')
INSERT [dbo].[Diseases] ([Id], [Name]) VALUES (3, N'Hepatitis B')
INSERT [dbo].[Diseases] ([Id], [Name]) VALUES (4, N'Malaria')
SET IDENTITY_INSERT [dbo].[Diseases] OFF
GO
SET IDENTITY_INSERT [dbo].[Ncd] ON 

INSERT [dbo].[Ncd] ([Id], [Name]) VALUES (1, N'Cancer')
INSERT [dbo].[Ncd] ([Id], [Name]) VALUES (2, N'Disorders of ear')
INSERT [dbo].[Ncd] ([Id], [Name]) VALUES (3, N'Disorder of eye')
INSERT [dbo].[Ncd] ([Id], [Name]) VALUES (4, N'Mental illness')
INSERT [dbo].[Ncd] ([Id], [Name]) VALUES (5, N'Oral health problems')
INSERT [dbo].[Ncd] ([Id], [Name]) VALUES (6, N'Asthma')
SET IDENTITY_INSERT [dbo].[Ncd] OFF
GO
