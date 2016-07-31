USE [SIPIDB]
GO

UPDATE [dbo].[THANA]
   SET [ThanaName] = <ThanaName, varchar(50),>
      ,[DistrictId] = <DistrictId, int,>
      ,[BanglaThanaName] = <BanglaThanaName, nvarchar(200),>
 WHERE <Search Conditions,,>
GO

