IF NOT EXISTS (SELECT 1 FROM dbo.[User])
BEGIN
	INSERT INTO dbo.[User]
	VALUES
	('Mohi','Heidari'),
	('Mahsa','Maherian'),
	('Ari','Rafi'),
	('Mahin','Fashbaf'),
	('Sari','Maher');
END