/****** Object:  Login [bcsuser]    Script Date: 12/06/2012 20:40:28 ******/
/* For security reasons the login is created disabled and with a random password. */
/****** Object:  Login [bcsuser]    Script Date: 12/06/2012 20:40:28 ******/
CREATE LOGIN [bcsuser] WITH PASSWORD=N'-2(Bî©l8tAc74¤,Ü8CMÃy[/zY', DEFAULT_DATABASE=[bcs_development], DEFAULT_LANGUAGE=[us_english], CHECK_EXPIRATION=OFF, CHECK_POLICY=ON
GO
EXEC sys.sp_addsrvrolemember @loginame = N'bcsuser', @rolename = N'sysadmin'
GO
ALTER LOGIN [bcsuser] DISABLE