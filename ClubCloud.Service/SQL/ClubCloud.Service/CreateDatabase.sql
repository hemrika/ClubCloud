SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF OBJECT_ID('[HelloWorld]') IS NOT NULL
    DROP PROC [HelloWorld]
GO

CREATE PROCEDURE [dbo].[HelloWorld]
	@input nvarchar(max),
	@output nvarchar(max) output
AS
	SELECT @output = 'Hello World, you wrote ' + @input + ' at this time: ' + CONVERT(nvarchar(max), GetDate(), 100);
GO

