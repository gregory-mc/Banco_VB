/****NO OLVIDES DE COLOCARTE EN MASTER****/

/****** Object:  Database [Banco]    Script Date: 10/12/2019 21:31:36 ******/
CREATE DATABASE Banco
GO
USE [Banco]
GO
/****** Object:  Table [dbo].[Cliente]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Cliente](
	[IdCliente] [char](8) NOT NULL,
	[Nombre] [varchar](30) NULL,
	[ApPaterno] [varchar](20) NULL,
	[ApMaterno] [varchar](20) NULL,
	[Celular] [char](9) NULL,
	[Direccion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CuentaBancaria]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CuentaBancaria](
	[IdCtaBancaria] [char](10) NOT NULL,
	[IdTipoCuenta] [char](4) NULL,
	[NumTarjeta] [char](16) Not NULL,
	[Saldo] [money] NULL,

PRIMARY KEY CLUSTERED 
(
	[IdCtaBancaria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Movimiento]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Movimiento](
	[IdMovimiento] [char](8) NOT NULL,
	[IdCtaBancaria] [char](10) NULL,
	[IdOperacion] [char](4) NULL,
	[FechaTransaccion] [date] NULL,
	[CuentaDestino] [varchar](20) NULL,
	[Monto] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMovimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Tarjeta]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Tarjeta](
	[NumTarjeta] [char](16) NOT NULL,
	[IdCliente] [char](8) NULL,
	[IdTipoTarj] [char](4) NULL,
	[FechaAfiliacion] [date] NULL,
	[FechaCaducidad] [date] NULL,
PRIMARY KEY CLUSTERED 
(
	[NumTarjeta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoCuenta]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoCuenta](
	[IdTipoCuenta] [char](4) NOT NULL,
	[Descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoCuenta] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoOperacion]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoOperacion](
	[IdOperacion] [char](4) NOT NULL,
	[Descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdOperacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoTarjeta]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoTarjeta](
	[IdTipoTarj] [char](4) NOT NULL,
	[Descripcion] [varchar](50) NULL,
PRIMARY KEY CLUSTERED 
(
	[IdTipoTarj] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[usuarios]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[usuarios](
	[codigo] [nchar](5) NULL,
	[nombre] [nvarchar](100) NULL,
	[apellidop] [nvarchar](100) NULL,
	[apellidom] [nvarchar](100) NULL,
	[usuario] [nvarchar](50) NULL,
	[pass] [nvarchar](100) NULL
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[CuentaBancaria]  WITH CHECK ADD  CONSTRAINT [fk_TipoCuenta] FOREIGN KEY([IdTipoCuenta])
REFERENCES [dbo].[TipoCuenta] ([IdTipoCuenta])
GO
ALTER TABLE [dbo].[CuentaBancaria] CHECK CONSTRAINT [fk_TipoCuenta]
GO
ALTER TABLE [dbo].[CuentaBancaria]  WITH CHECK ADD  CONSTRAINT [fk_NumTarjeta] FOREIGN KEY([NumTarjeta])
REFERENCES [dbo].[Tarjeta] ([NumTarjeta]) ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CuentaBancaria] CHECK CONSTRAINT [fk_NumTarjeta]
GO
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [fk_CuentaT] FOREIGN KEY([IdCtaBancaria])
REFERENCES [dbo].[CuentaBancaria] ([IdCtaBancaria]) ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [fk_CuentaT]
GO
ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [fk_OperacionT] FOREIGN KEY([IdOperacion])
REFERENCES [dbo].[TipoOperacion] ([IdOperacion])
GO
ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [fk_OperacionT]
GO
ALTER TABLE [dbo].[Tarjeta]  WITH CHECK ADD  CONSTRAINT [fk_Cliente] FOREIGN KEY([IdCliente])
REFERENCES [dbo].[Cliente] ([IdCliente]) ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Tarjeta] CHECK CONSTRAINT [fk_Cliente]
GO
ALTER TABLE [dbo].[Tarjeta]  WITH CHECK ADD  CONSTRAINT [fk_Tarjeta] FOREIGN KEY([IdTipoTarj])
REFERENCES [dbo].[TipoTarjeta] ([IdTipoTarj])
GO
ALTER TABLE [dbo].[Tarjeta] CHECK CONSTRAINT [fk_Tarjeta]
GO
/****** Object:  StoredProcedure [dbo].[pa_ListaClientes]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[pa_ListaClientes]

AS

SELECT * FROM Cliente
 --ELSE
--	BEGIN
--		SET @MENSAJE ='NO'
--	END
GO
/****** Object:  StoredProcedure [dbo].[Sp_BuscaUsuario]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- ================================================
-- Template generated from Template Explorer using:
CREATE PROCEDURE [dbo].[Sp_BuscaUsuario] 
@User varchar(30),
@contrasenna char(30)

AS
 IF EXISTS(SELECT * FROM usuarios where Usuario = @User  and pass = @contrasenna)
	BEGIN
		SELECT usuarios.* FROM usuarios where  usuarios.usuario = @User  and usuarios.pass = @contrasenna
	END
 --ELSE
--	BEGIN
--		SET @MENSAJE ='NO'
--	END
GO
/****** Object:  StoredProcedure [dbo].[sp_consultaCta]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_consultaCta]
@DNI char(8)
AS
IF EXISTS (Select IdCtaBancaria from CuentaBancaria where NumTarjeta in (Select NumTarjeta from Tarjeta where IdCliente = @DNI) )
BEGIN
(Select IdCtaBancaria from CuentaBancaria where NumTarjeta in (Select NumTarjeta from Tarjeta where IdCliente = @DNI))
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_EliminarCliente]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Sp_EliminarCliente] 
@id_cliente nchar(8)
AS
BEGIN
	
	SET NOCOUNT ON;

	
	DELETE FROM [dbo].Cliente
      WHERE [dbo].[Cliente].IdCliente=@id_cliente
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_GuardarCliente]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[Sp_GuardarCliente] 
@id nchar(8),
@Nombre nvarchar(100),
@Apellidop nvarchar(100),
@Apellidom nvarchar(100),
@Celular nvarchar(100),
@Direccion nvarchar(100)
AS
BEGIN
	
	SET NOCOUNT ON;

	INSERT INTO Cliente VALUES	(@id,@Nombre,@Apellidop,@Apellidom,@Celular,@Direccion)
END
GO
/****** Object:  StoredProcedure [dbo].[Sp_ModificarCliente]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[Sp_ModificarCliente]
@id nchar(8) ,
@Nombre nvarchar(100),
@Apellidop nvarchar(100),
@Apellidom nvarchar(100),
@Celular nvarchar(100),
@Direccion nvarchar(50)
AS
BEGIN
	
	SET NOCOUNT ON;
	
	UPDATE [dbo].Cliente
	   SET [IdCliente]=@id
		   ,[nombre] = @Nombre
		  ,[ApPaterno] = @Apellidop
		  ,[ApMaterno] = @Apellidom
		  ,[Celular] = @Celular
		  ,[Direccion] =@Direccion
	 WHERE [IdCliente]=@id
END
GO
/****** Object:  StoredProcedure [dbo].[sp_reportes]    Script Date: 10/12/2019 21:31:36 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[sp_reportes]
@DNI char (8) 
AS 
IF EXISTS (SELECT IdCtaBancaria, IdOperacion, FechaTransaccion, CuentaDestino, Monto FROM Movimiento Where IdCtaBancaria in (SELECT IdCtaBancaria FROM CuentaBancaria WHERE NumTarjeta in ( SELECT NumTarjeta FROM Tarjeta WHERE IdCliente = @DNI)))
BEGIN
(SELECT IdCtaBancaria, IdOperacion, FechaTransaccion, CuentaDestino, Monto FROM Movimiento Where IdCtaBancaria in (SELECT IdCtaBancaria FROM CuentaBancaria WHERE NumTarjeta in ( SELECT NumTarjeta FROM Tarjeta WHERE IdCliente = @DNI)))
END
GO

CREATE PROCEDURE sp_GuardarCuenta
@DNI char(8),
@TipoTarjeta varchar(15),
@NumTajeta char(16),
@TipoCuenta varchar(15),
@NumCuenta char(10)
AS
	DECLARE @IdTipoCuenta char(4)
	DECLARE @IdTipoTarjeta char(4)
	DECLARE @FechaAfiliacion date
	DECLARE @FechaCaducidad date
	SET @FechaAfiliacion=GETDATE()
	SET @FechaCaducidad= DATEADD(year,4,@FechaAfiliacion)
	SET @IdTipoCuenta = (SELECT IdTipoCuenta FROM TipoCuenta WHERE Descripcion = @TipoCuenta)
	SET @IdTipoTarjeta = (SELECT IdTipoTarj FROM TipoTarjeta WHERE Descripcion = @TipoTarjeta)
	INSERT INTO Tarjeta VALUES (@NumTajeta,@DNI,@IdTipoTarjeta,@FechaAfiliacion,@FechaCaducidad)
	INSERT INTO CuentaBancaria VALUES	(@NumCuenta,@IdTipoCuenta,@NumTajeta,0)
	
GO

INSERT INTO [dbo].[TipoTarjeta]
           ([IdTipoTarj]
           ,[Descripcion])
     VALUES
           ('TJ01','CREDITO'),('TJ02','DEBITO')
GO

INSERT INTO [dbo].[TipoCuenta]
           ([IdTipoCuenta]
           ,[Descripcion])
     VALUES
           ('TC01','AHORROS'),('TC02','CORRIENTE')
GO

-----------------------------------------

/*A PARTIR DE AQUI MODIFIQUE
A PARTIR DE AQUI MODIFIQUE
A PARTIR DE AQUI MODIFIQUE
A PARTIR DE AQUI MODIFIQUE
A PARTIR DE AQUI MODIFIQUE
A PARTIR DE AQUI MODIFIQUE
A PARTIR DE AQUI MODIFIQUE
A PARTIR DE AQUI MODIFIQUE
A PARTIR DE AQUI MODIFIQUE
A PARTIR DE AQUI MODIFIQUE
*/
go
CREATE PROCEDURE sp_consultarTarjeta 
@DNI varchar (8)
AS
IF EXISTS (SELECT NumTarjeta from Tarjeta where IdCliente= @DNI)
	BEGIN
	(SELECT NumTarjeta from Tarjeta where IdCliente= @DNI)
	END
GO
-------------------------
CREATE PROCEDURE sp_consultarCtaTarjeta
@numTarjeta varchar (16)

AS

IF EXISTS (SELECT IdCtaBancaria from CuentaBancaria where NumTarjeta= @numTarjeta)
BEGIN
(SELECT IdCtaBancaria from CuentaBancaria where NumTarjeta= @numTarjeta)
END
GO

--------------------------------
CREATE PROCEDURE sp_ListarOperaciones
AS

IF EXISTS (SELECT * from TipoOperacion )
	BEGIN
	 (SELECT * from TipoOperacion )
	END
GO
--------------------------------------------
Drop Table Movimiento
USE [Banco]
GO

/****** Object:  Table [dbo].[Movimiento]    Script Date: 12/12/2019 23:48:17 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[Movimiento](
	[IdMovimiento] int NOT NULL Identity,
	[IdCtaBancaria] [char](10) NULL,
	[IdOperacion] [char](4) NULL,
	[FechaTransaccion] [date] NULL,
	[CuentaDestino] [varchar](20) NULL,
	[Monto] [money] NULL,
PRIMARY KEY CLUSTERED 
(
	[IdMovimiento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO

ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [fk_CuentaT] FOREIGN KEY([IdCtaBancaria])
REFERENCES [dbo].[CuentaBancaria] ([IdCtaBancaria]) ON DELETE CASCADE
GO

ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [fk_CuentaT]
GO

ALTER TABLE [dbo].[Movimiento]  WITH CHECK ADD  CONSTRAINT [fk_OperacionT] FOREIGN KEY([IdOperacion])
REFERENCES [dbo].[TipoOperacion] ([IdOperacion])
GO

ALTER TABLE [dbo].[Movimiento] CHECK CONSTRAINT [fk_OperacionT]
GO

/*
#########################################################
#######################################################
#################################################
AGREGUÉ LAS ACCIONES PARA LAS CUENTAS, Y UN NUEVO PROCEDIMIENTO ALMACENADO
*/
-----------------------------------------------------
CREATE PROCEDURE sp_GuardarMovimiento
@IdCta varchar(10),
@IdOp varchar(4),
@cta varchar(20),
@monto money

AS
DECLARE @fecha date
IF (LEN(@cta)=0)
BEGIN
	SET @cta=@IdCta
END
SET @fecha=CONVERT (date, GETDATE()) 
INSERT INTO Movimiento(IdCtaBancaria, IdOperacion, FechaTransaccion, CuentaDestino, Monto) VALUES 
(@IdCta,@IdOp,@fecha,@cta,@monto)
IF (@IdOp='DEPM')
BEGIN
	UPDATE CuentaBancaria SET Saldo=Saldo+@monto WHERE IdCtaBancaria=@IdCta
END
IF (@IdOp='RETI')
BEGIN
	UPDATE CuentaBancaria SET Saldo=Saldo-@monto WHERE IdCtaBancaria=@IdCta
END
IF (@IdOp='DEPO')
BEGIN
	UPDATE CuentaBancaria SET Saldo=Saldo-@monto WHERE IdCtaBancaria=@IdCta
	UPDATE CuentaBancaria SET Saldo=Saldo+@monto WHERE IdCtaBancaria=@cta
END
GO

------------------------------------------------------------------
CREATE PROCEDURE sp_ConsultarSaldo
@IdCta varchar(10)
AS
	SELECT Saldo FROM CuentaBancaria WHERE IdCtaBancaria=@IdCta
GO
/*Aqui EMPIEZO a llenar la tabla de tipo de operaciones
Luego altero el SP_Guardar cuenta porque la reutilizo en la segunda pestaña del FrmCrear Cuenta
pero como no se usa el tipo de Tarjeta ni fechas ni nada de eso usé un IF

*/
INSERT INTO TipoOperacion (IdOperacion,Descripcion) VALUES ('DEPO', 'Deposito a otras cuentas'), ('DEPM','Deposito a la misma cuenta'), ('RETI','Retiros de la cuenta')

GO

USE [Banco]
GO
/****** Object:  StoredProcedure [dbo].[sp_GuardarCuenta]    Script Date: 14/12/2019 13:55:40 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[sp_GuardarCuenta]
@DNI char(8),
@TipoTarjeta varchar(15),
@NumTarjeta char(16),
@TipoCuenta varchar(15),
@NumCuenta char(10),
@Saldo money
AS
	DECLARE @IdTipoCuenta char(4)
	DECLARE @IdTipoTarjeta char(4)
	DECLARE @FechaAfiliacion date
	DECLARE @FechaCaducidad date
	
		SET @FechaAfiliacion=GETDATE()
		SET @FechaCaducidad= DATEADD(year,4,@FechaAfiliacion)
		SET @IdTipoCuenta = (SELECT IdTipoCuenta FROM TipoCuenta WHERE Descripcion = @TipoCuenta)
		SET @IdTipoTarjeta = (SELECT IdTipoTarj FROM TipoTarjeta WHERE Descripcion = @TipoTarjeta)
	IF (LEN(@IdTipoTarjeta)<>0)
	BEGIN
		INSERT INTO Tarjeta VALUES (@NumTarjeta,@DNI,@IdTipoTarjeta,@FechaAfiliacion,@FechaCaducidad)
	END
	INSERT INTO CuentaBancaria VALUES	(@NumCuenta,@IdTipoCuenta,@NumTarjeta,@Saldo)
	GO
	/*15 DE DICIEMBRE */
	
CREATE PROCEDURE sp_validarTarjeta
@Num char(16)
AS
SELECT NumTarjeta From Tarjeta where NumTarjeta=@Num
GO 

CREATE PROCEDURE sp_validarCuenta
@Num char(10)
AS
SELECT * From CuentaBancaria where IdCtaBancaria=@Num
GO

CREATE PROCEDURE sp_Detalles
AS
	SELECT Tar.IdCliente as 'DNI', Cli.Nombre, Tar.NumTarjeta, Ttrj.Descripcion as 'Tipo Tarjeta', 
	Cta.IdCtaBancaria as 'Numero Cuenta',  Tcta.Descripcion as 'Tipo Cuenta', Cta.Saldo FROM Tarjeta Tar 
	INNER JOIN CuentaBancaria Cta ON Tar.NumTarjeta=Cta.NumTarjeta INNER JOIN TipoCuenta Tcta 
	ON Cta.IdTipoCuenta=Tcta.IdTipoCuenta INNER JOIN TipoTarjeta Ttrj ON  Tar.IdTipoTarj=Ttrj.IdTipoTarj 
	INNER JOIN Cliente Cli ON Tar.IdCliente=Cli.IdCliente
GO


INSERT INTO [dbo].[usuarios]
           ([usuario]
           ,[pass])
     VALUES
           ('admin','admin'),('user','user')
GO
