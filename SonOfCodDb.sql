USE [SonOfCod]
GO
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'df2d8215-bba6-4494-9396-946483b10a98', 0, N'd8ed3dd0-f99e-4f73-b52a-e687465f5c1e', NULL, 0, 1, NULL, NULL, N'NOTE@GMAIL.COM', N'AQAAAAEAACcQAAAAEO6CYRcJN1yjZ0VWfc4A/U3GE2geH8BFPpgfY8WReCZxPvflJFi7ssOYCWrlntgzRg==', NULL, 0, N'90eeab3c-142c-496a-bbc3-16e611af398e', 0, N'note@gmail.com')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20161203172039_InitialCreateAccount', N'1.0.0-rtm-21431')
