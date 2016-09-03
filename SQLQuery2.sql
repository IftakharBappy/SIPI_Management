/****** Script for SelectTopNRows command from SSMS  ******/
SELECT TOP 1000 [Id]
      ,[ThanaName]
      ,[DistrictId]
      ,[BanglaThanaName]
  FROM [SIPIDB].[dbo].[THANA]

  UPDATE [SIPIDB].[dbo].[THANA] 

   SET [SIPIDB].[dbo].[THANA].DistrictId = [SIPIDB].[dbo].[DISTRICT].Id

   FROM [SIPIDB].[dbo].[THANA]  INNER JOIN  [SIPIDB].[dbo].[DISTRICT] ON 

[SIPIDB].[dbo].[THANA].id = [SIPIDB].[dbo].[DISTRICT].id