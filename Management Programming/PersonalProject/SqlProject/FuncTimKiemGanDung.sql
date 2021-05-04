USE TSTBKhachSan
GO
CREATE FUNCTION dbo.fuConvertToUnsign1 ( @strInput NVARCHAR(4000) ) 
RETURNS NVARCHAR(4000) 
AS 
BEGIN 
	IF @strInput IS NULL RETURN @strInput IF @strInput = '' 
		RETURN @strInput DECLARE @RT NVARCHAR(4000) 
		DECLARE @SIGN_CHARS NCHAR(136) 
		DECLARE @UNSIGN_CHARS NCHAR (136) 
		SET @SIGN_CHARS = N'ăâđêôơưàảãạáằẳẵặắầẩẫậấèẻẽẹéềểễệế 
							ìỉĩịíòỏõọóồổỗộốờởỡợớùủũụúừửữựứỳỷỹỵý 
							ĂÂĐÊÔƠƯÀẢÃẠÁẰẲẴẶẮẦẨẪẬẤÈẺẼẸÉỀỂỄỆẾÌỈĨỊÍ 
							ÒỎÕỌÓỒỔỖỘỐỜỞỠỢỚÙỦŨỤÚỪỬỮỰỨỲỶỸỴÝ' +NCHAR(272)+ NCHAR(208) 
		SET @UNSIGN_CHARS = N'aadeoouaaaaaaaaaaaaaaaeeeeeeeeee 
							iiiiiooooooooooooooouuuuuuuuuuyyyyy 
							AADEOOUAAAAAAAAAAAAAAAEEEEEEEEEEIIIII 
							OOOOOOOOOOOOOOOUUUUUUUUUUYYYYYDD' 
		DECLARE @COUNTER INT 
		DECLARE @COUNTER1 INT 
		SET @COUNTER = 1 WHILE (@COUNTER <=LEN(@strInput)) 
		BEGIN SET @COUNTER1 = 1 WHILE (@COUNTER1 <=LEN(@SIGN_CHARS)+1) 
		BEGIN IF UNICODE(SUBSTRING(@SIGN_CHARS, @COUNTER1,1)) = UNICODE(SUBSTRING(@strInput,@COUNTER ,1) ) 
		BEGIN IF @COUNTER=1 SET @strInput = SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)-1) 
	ELSE SET @strInput = SUBSTRING(@strInput, 1, @COUNTER-1) +SUBSTRING(@UNSIGN_CHARS, @COUNTER1,1) + SUBSTRING(@strInput, @COUNTER+1,LEN(@strInput)- @COUNTER) BREAK END SET @COUNTER1 = @COUNTER1 +1 END SET @COUNTER = @COUNTER +1 END SET @strInput = REPLACE(@strInput,' ','-') 
	RETURN @strInput 
END