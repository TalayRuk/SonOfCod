USE [SonOfCod]
GO
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'0d9fb63a-dec9-4422-a867-0fe557d9f986', 0, N'11853acb-5546-400a-b4be-f8847b692d60', NULL, 0, 1, NULL, NULL, N'NO@ME', N'AQAAAAEAACcQAAAAEHP6Ffx0IUpbEc+J0D6A1uzsnbnOsZD/KV5vLUJlLqIyPBaCuHS8C0sdJAQa8KwELw==', NULL, 0, N'8385a787-7cbc-495d-9254-1b08c2ee9da1', 0, N'no@me')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'44778c19-8f43-4676-a890-8cc7e4167ac6', 0, N'b7e1e3d3-5f07-4e22-afcf-98e77e361701', NULL, 0, 1, NULL, NULL, N'TALAY@ME', N'AQAAAAEAACcQAAAAEIRcnym2kiBi0v6z3H2cnf1y0A0dH1DrDmE8oWX/0hENOlfrIxiIePf62nGZZS5huQ==', NULL, 0, N'51534968-6351-4fac-b0ce-0b52075ad509', 0, N'Talay@me')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'71536d0c-c77b-4b8b-af96-8c826a37905f', 0, N'6f0bcf43-b2c9-4d3b-9395-515d381b9a99', NULL, 0, 1, NULL, NULL, N'NOTE@ME.COM', N'AQAAAAEAACcQAAAAEIk1MXSVPLTDYsqA7wgzgyos8H1T7+jVk6gp2V/4QwML9As1la42jeP7QSGEm69aZA==', NULL, 0, N'631f2ed9-c059-4c73-a25d-c79ebc147a2f', 0, N'note@me.com')
INSERT [dbo].[AspNetUsers] ([Id], [AccessFailedCount], [ConcurrencyStamp], [Email], [EmailConfirmed], [LockoutEnabled], [LockoutEnd], [NormalizedEmail], [NormalizedUserName], [PasswordHash], [PhoneNumber], [PhoneNumberConfirmed], [SecurityStamp], [TwoFactorEnabled], [UserName]) VALUES (N'df2d8215-bba6-4494-9396-946483b10a98', 0, N'd8ed3dd0-f99e-4f73-b52a-e687465f5c1e', NULL, 0, 1, NULL, NULL, N'NOTE@GMAIL.COM', N'AQAAAAEAACcQAAAAEO6CYRcJN1yjZ0VWfc4A/U3GE2geH8BFPpgfY8WReCZxPvflJFi7ssOYCWrlntgzRg==', NULL, 0, N'90eeab3c-142c-496a-bbc3-16e611af398e', 0, N'note@gmail.com')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20161203172039_InitialCreateAccount', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20161204150011_InitialCreateSubscriber', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20161204151454_AddSubscriberDbConnection', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20161205105536_DeleteUserFromSubscriber', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20161205112849_InitialCreatePromotion', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20161205114934_AddAdminUserToPromotion', N'1.0.0-rtm-21431')
INSERT [dbo].[__EFMigrationsHistory] ([MigrationId], [ProductVersion]) VALUES (N'20161205174438_DeleteAdminUserFromPromotion', N'1.0.0-rtm-21431')
SET IDENTITY_INSERT [dbo].[Promotions] ON 

INSERT [dbo].[Promotions] ([Id], [Description], [Image_url], [Title]) VALUES (1, N'The love of Cod: 
Bacalhau / Dry Salted Cod:

Boneless Bits (Migas)

Medium / Large / Extra Large Thickness

Whole Fish

Boneless / Skinless Fillet 

Prices start at $7.99/lb


Wholesale Inquiries Accepted

', N'http://store.claros.com/prodimg/19205.jpg', N'Seafood Lover')
INSERT [dbo].[Promotions] ([Id], [Description], [Image_url], [Title]) VALUES (2, N'This perfect single portion Black cod fillet is marinated in a sweet and smoky teriyaki sauce. Bake it in the oven, and serve with rice and steamed bok choy for a light meal! 6 oz. package, frozen.

Species: Black cod (Anoplopoma fimbria)

Ingredients: Black Cod (Sablefish), Asian BBQ Sauce (Organic Sugar, Tamari Soy Sauce (Water, Soybeans, Salt, Alcohol), Water, Tomato Paste, Rice Vinegar, Molasses, Arrowroot, Onion Juice (Onion Juice, Vinegar, Salt), Ginger Powder, Garlic Powder, Sesame, Canola Oil, Spice, Natural Flavor (Maltodextrin, Hickory Smoke Flavor), Xanthan Gum). 
', N'https://static1.squarespace.com/static/539e75d2e4b0a181d64eaf18/t/56fabc4440261d8e8e9a3bc3/1459272960709/Black+Cod+with+Sweet+%26+Smoky+Teriyaki++-+sustainable+seafood', N'Black Cod with Sweet & Smoky Teriyaki ')
SET IDENTITY_INSERT [dbo].[Promotions] OFF
SET IDENTITY_INSERT [dbo].[Subscribers] ON 

INSERT [dbo].[Subscribers] ([Id], [Company], [Consumer_type], [Email], [First_name], [Last_name]) VALUES (1, N'None', N'Consumer', N'note@me.com', N'Note', N'Kl')
INSERT [dbo].[Subscribers] ([Id], [Company], [Consumer_type], [Email], [First_name], [Last_name]) VALUES (2, N'Fish&Co', N'Industry', N'vj@me.com', N'vj', N'na')
INSERT [dbo].[Subscribers] ([Id], [Company], [Consumer_type], [Email], [First_name], [Last_name]) VALUES (3, N'Fish&Co', N'Industry', N'vj@me.com', N'vj', N'na')
INSERT [dbo].[Subscribers] ([Id], [Company], [Consumer_type], [Email], [First_name], [Last_name]) VALUES (4, N'Alian&Co', N'Industry', N'et@earth', N'et', N'pl')
INSERT [dbo].[Subscribers] ([Id], [Company], [Consumer_type], [Email], [First_name], [Last_name]) VALUES (5, N'Seafood Co', N'Industry', N'dl@Talay.com', N'Dl', N'TalayTai')
INSERT [dbo].[Subscribers] ([Id], [Company], [Consumer_type], [Email], [First_name], [Last_name]) VALUES (6, N'None', N'Consumer', N'Talay@me', N'talay', N'Doe')
SET IDENTITY_INSERT [dbo].[Subscribers] OFF
