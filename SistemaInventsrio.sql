Create Database TiendaDB
USE [TiendaDB]
GO
/****** Object:  Table [dbo].[Proveedor]    Script Date: 09/14/2017 20:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Proveedor](
	[ID_Proveedor] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Compañia] [nchar](100) NOT NULL,
	[Contacto] [nchar](50) NOT NULL,
	[Direccion] [nchar](50) NOT NULL,
	[Telefono] [nchar](20) NOT NULL,
	[Correo] [nchar](30) NOT NULL,
 CONSTRAINT [PK_Proveedor] PRIMARY KEY CLUSTERED 
(
	[ID_Proveedor] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 09/14/2017 20:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Id_Usuario] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nchar](10) NOT NULL,
	[Clave] [nchar](10) NOT NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[Id_Usuario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Clientes]    Script Date: 09/14/2017 20:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Clientes](
	[ID_Cliente] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nchar](20) NOT NULL,
	[Apellido] [nchar](20) NOT NULL,
	[Direccion] [nchar](50) NOT NULL,
	[Telefono] [nchar](15) NOT NULL,
	[Documento] [nchar](20) NOT NULL,
	[Estado] [nchar](1) NOT NULL,
 CONSTRAINT [PK_Clientes] PRIMARY KEY CLUSTERED 
(
	[ID_Cliente] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Empleados]    Script Date: 09/14/2017 20:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Empleados](
	[Id_Empleado] [int] IDENTITY(1,1) NOT NULL,
	[Nombre_Empleado] [nchar](10) NULL,
	[Apellido_Empleado] [nchar](10) NULL,
	[Cedula_Empleado] [nchar](10) NULL,
	[Direccion] [nchar](10) NULL,
	[Telefono] [nchar](10) NULL,
	[Fecha_Ingreso] [nchar](10) NULL,
	[Status] [nchar](10) NULL,
	[Departamento] [nchar](10) NULL,
 CONSTRAINT [PK_Empleados] PRIMARY KEY CLUSTERED 
(
	[Id_Empleado] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Menu]    Script Date: 09/14/2017 20:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Menu](
	[IdMenu] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[Activa] [int] NULL,
 CONSTRAINT [PK_IdMenu] PRIMARY KEY CLUSTERED 
(
	[IdMenu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Inventario]    Script Date: 09/14/2017 20:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Inventario](
	[ID_Inventario] [int] IDENTITY(1,1) NOT NULL,
	[Estatus] [nchar](1) NOT NULL,
	[Cantida] [int] NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[Descripcion] [nchar](50) NOT NULL,
 CONSTRAINT [PK_Inventario] PRIMARY KEY CLUSTERED 
(
	[ID_Inventario] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FormaPago]    Script Date: 09/14/2017 20:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FormaPago](
	[ID_FormaPago] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion] [nchar](20) NOT NULL,
 CONSTRAINT [PK_FormaPago] PRIMARY KEY CLUSTERED 
(
	[ID_FormaPago] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[proc_Menu]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_Menu]
AS
BEGIN
 SELECT m.idmenu, m.Nombre
   FROM Menu m
  WHERE m.activa<>0
  order by m.IdMenu 
END
GO
/****** Object:  StoredProcedure [dbo].[proc_ProveedorUpdate]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ProveedorUpdate]
(
	@IDProveedor int, 
	@NombreCompañia nchar(100), 
	@Contacto nchar(20), 
	@Direccion nchar(50), 
	@Telefono nchar(20), 
	@Correo nchar(30)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [Proveedor]
	SET
		[Nombre_Compañia] = @NombreCompañia, 
		[Contacto] = @Contacto, 
		[Direccion] = @Direccion, 
		[Telefono] = @Telefono, 
		[Correo] = @Correo
	WHERE
		([ID_Proveedor] = @IDProveedor)

	SET @Err = @@Error


	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_ProveedorLoadByPrimaryKey]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ProveedorLoadByPrimaryKey]
(
	@IDProveedor int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ID_Proveedor], 
		[Nombre_Compañia], 
		[Contacto], 
		[Direccion], 
		[Telefono], 
		[Correo]
	FROM [dbo].[Proveedor]
	WHERE
		([ID_Proveedor] = @IDProveedor)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_ProveedorLoadAll]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ProveedorLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ID_Proveedor], 
		[Nombre_Compañia], 
		[Contacto], 
		[Direccion], 
		[Telefono], 
		[Correo]
	FROM [dbo].[Proveedor]

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_ProveedorInsert]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ProveedorInsert]
(
	@ID_Proveedor int = NULL OUTPUT, 
	@Nombre_Compañia nchar(100), 
	@Contacto nchar(20), 
	@Direccion nchar(50), 
	@Telefono nchar(20), 
	@Correo nchar(30)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [Proveedor]
	(
		[Nombre_Compañia], 
		[Contacto], 
		[Direccion], 
		[Telefono], 
		[Correo]
	)
	
	VALUES
	(
		@Nombre_Compañia, 
		@Contacto, 
		@Direccion, 
		@Telefono, 
		@Correo
	)


	SET @Err = @@Error

		
	SELECT @ID_Proveedor = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_ProveedorDelete]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ProveedorDelete]
(
	@IDProveedor int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[Proveedor]
	WHERE
		([ID_Proveedor] = @IDProveedor)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  Table [dbo].[Factura]    Script Date: 09/14/2017 20:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Factura](
	[ID_Factura] [int] IDENTITY(1,1) NOT NULL,
	[Fecha] [date] NOT NULL,
	[Total] [float] NOT NULL,
	[Id_Cliente] [int] NOT NULL,
	[Forma_Pago] [nchar](20) NOT NULL,
	[Vendedor] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Factura] PRIMARY KEY CLUSTERED 
(
	[ID_Factura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[proc_ClientesInsert]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ClientesInsert]
(
	@ID_Cliente int = NULL OUTPUT, 
	@Nombre nchar(20), 
	@Apellido nchar(20), 
	@Direccion nchar(50), 
	@Telefono nchar(10), 
	@Documento nchar(12), 
	@Estado nchar(1)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [Clientes]
	(
		[Nombre], 
		[Apellido], 
		[Direccion], 
		[Telefono], 
		[Documento], 
		[Estado]
	)
	
	VALUES
	(
		@Nombre, 
		@Apellido, 
		@Direccion, 
		@Telefono, 
		@Documento, 
		@Estado
	)


	SET @Err = @@Error

		
	SELECT @ID_Cliente = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_ClientesDelete]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ClientesDelete]
(
	@IDCliente int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[Clientes]
	WHERE
		([ID_Cliente] = @IDCliente)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[usp_ValidarUsuario]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[usp_ValidarUsuario]
(
   @usu varchar(15),
   @cla varchar(10)
)
as
begin
   select Usuario,clave
   from Usuario
   where usuario=@usu  
     and clave = @cla
end
GO
/****** Object:  Table [dbo].[SubMenu]    Script Date: 09/14/2017 20:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[SubMenu](
	[IdSubMenu] [int] NOT NULL,
	[Nombre] [varchar](100) NOT NULL,
	[IdMenu] [int] NOT NULL,
	[Activa] [int] NULL,
	[imagen] [varchar](250) NULL,
 CONSTRAINT [PK_SubMenu] PRIMARY KEY CLUSTERED 
(
	[IdMenu] ASC,
	[IdSubMenu] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
/****** Object:  Table [dbo].[Producto]    Script Date: 09/14/2017 20:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Producto](
	[ID_Producto] [int] IDENTITY(1,1) NOT NULL,
	[Descripcion_Producto] [nchar](50) NOT NULL,
	[Precio_Compra] [float] NOT NULL,
	[Precio_Venta] [float] NOT NULL,
	[Inventario] [int] NOT NULL,
	[ID_Proveedor] [int] NOT NULL,
 CONSTRAINT [PK_Producto] PRIMARY KEY CLUSTERED 
(
	[ID_Producto] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[proc_SubMenu]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_SubMenu]
AS
BEGIN
   SELECT m.idmenu,s.Nombre,s.imagen 
   FROM Menu m, SubMenu s
   WHERE m.IdMenu=s.IdMenu 
      AND s.activa<>0
   order by m.IdMenu       
END
GO
/****** Object:  Table [dbo].[DetalleFactura]    Script Date: 09/14/2017 20:47:17 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DetalleFactura](
	[ID_DetalleFactura] [int] IDENTITY(1,1) NOT NULL,
	[ID_Producto] [int] NOT NULL,
	[Cantidad] [int] NOT NULL,
	[ID_Factura] [int] NOT NULL,
	[Monto] [float] NOT NULL,
	[Itbis] [float] NOT NULL,
 CONSTRAINT [PK_DetalleFactura] PRIMARY KEY CLUSTERED 
(
	[ID_DetalleFactura] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[proc_ProductoUpdate]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ProductoUpdate]
(
	@IDProducto int, 
	@DescripcionProducto nchar(50), 
	@PrecioCompra float, 
	@PrecioVenta float, 
	@Inventario int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [Producto]
	SET
		[Descripcion_Producto] = @DescripcionProducto, 
		[Precio_Compra] = @PrecioCompra, 
		[Precio_Venta] = @PrecioVenta, 
		[Inventario] = @Inventario
	WHERE
		([ID_Producto] = @IDProducto)

	SET @Err = @@Error


	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_ProductoLoadByPrimaryKey]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ProductoLoadByPrimaryKey]
(
	@IDProducto int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ID_Producto], 
		[Descripcion_Producto], 
		[Precio_Compra], 
		[Precio_Venta], 
		[Inventario]
	FROM [dbo].[Producto]
	WHERE
		([ID_Producto] = @IDProducto)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_ProductoLoadAll]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ProductoLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ID_Producto], 
		[Descripcion_Producto], 
		[Precio_Compra], 
		[Precio_Venta], 
		[Inventario]
	FROM [dbo].[Producto]

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_ProductoInsert]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ProductoInsert]
(
	@ID_Producto int = NULL OUTPUT, 
	@Descripcion_Producto nchar(50), 
	@Precio_Compra float, 
	@Precio_Venta float, 
	@Inventario int,
	@ID_Proveedor int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [Producto]
	(
		[Descripcion_Producto], 
		[Precio_Compra], 
		[Precio_Venta], 
		[Inventario],
		[ID_Proveedor]
	)
	
	VALUES
	(
		@Descripcion_Producto, 
		@Precio_Compra, 
		@Precio_Venta, 
		@Inventario,
		@ID_Proveedor
	)


	SET @Err = @@Error

		
	SELECT @ID_Producto = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_ProductoDelete]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_ProductoDelete]
(
	@IDProducto int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[Producto]
	WHERE
		([ID_Producto] = @IDProducto)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_FacturaUpdate]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_FacturaUpdate]
(
	@ID_Factura int, 
	@Fecha date, 
	@Total float, 
	@Id_Cliente int, 
	@Forma_Pago nchar(20), 
	@Vendedor nchar(20)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [Factura]
	SET
		[Fecha] = @Fecha, 
		[Total] = @Total, 
		[Id_Cliente] = @Id_Cliente, 
		[Forma_Pago] = @Forma_Pago, 
		[Vendedor] = @Vendedor
	WHERE
		([ID_Factura] = @ID_Factura)

	SET @Err = @@Error


	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_FacturaLoadByPrimaryKey]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_FacturaLoadByPrimaryKey]
(
	@IDFactura int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ID_Factura], 
		[Fecha], 
		[Total], 
		[Id_Cliente], 
		[Forma_Pago], 
		[Vendedor]
	FROM [dbo].[Factura]
	WHERE
		([ID_Factura] = @IDFactura)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_FacturaLoadAll]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_FacturaLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ID_Factura], 
		[Fecha], 
		[Total], 
		[Id_Cliente], 
		[Forma_Pago], 
		[Vendedor]
	FROM [dbo].[Factura]

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_FacturaInsert]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_FacturaInsert]
(
	@ID_Factura int = NULL OUTPUT, 
	@Fecha date, 
	@Total float, 
	@Id_Cliente int, 
	@Forma_Pago nchar(20), 
	@Vendedor nchar(20)
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [Factura]
	(
		[Fecha], 
		[Total], 
		[Id_Cliente], 
		[Forma_Pago], 
		[Vendedor]
	)
	
	VALUES
	(
		@Fecha, 
		@Total, 
		@Id_Cliente, 
		@Forma_Pago, 
		@Vendedor
	)


	SET @Err = @@Error

		
	SELECT @ID_Factura = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_FacturaDelete]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_FacturaDelete]
(
	@IDFactura int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[Factura]
	WHERE
		([ID_Factura] = @IDFactura)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_DetalleFacturaUpdate]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DetalleFacturaUpdate]
(
	@ID_DetalleFactura int, 
	@ID_Producto int, 
	@Cantidad int, 
	@ID_Factura int, 
	@Monto float, 
	@Itbis float, 
	@ID_Cliente int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int
	
	
	

	UPDATE [DetalleFactura]
	SET
		[ID_Producto] = @ID_Producto, 
		[Cantidad] = @Cantidad, 
		[ID_Factura] = @ID_Factura, 
		[Monto] = @Monto, 
		[Itbis] = @Itbis, 
		[ID_Cliente] = @ID_Cliente
	WHERE
		([ID_DetalleFactura] = @ID_DetalleFactura)

	SET @Err = @@Error


	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_DetalleFacturaLoadByPrimaryKey]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DetalleFacturaLoadByPrimaryKey]
(
	@IDDetalleFactura int
)
AS
BEGIN
	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ID_DetalleFactura], 
		[ID_Producto], 
		[Cantidad], 
		[ID_Factura], 
		[Monto], 
		[Itbis], 
		[ID_Cliente]
	FROM [dbo].[DetalleFactura]
	WHERE
		([ID_DetalleFactura] = @IDDetalleFactura)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_DetalleFacturaLoadAll]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DetalleFacturaLoadAll]
AS
BEGIN

	SET NOCOUNT ON
	DECLARE @Err int

	SELECT
		[ID_DetalleFactura], 
		[ID_Producto], 
		[Cantidad], 
		[ID_Factura], 
		[Monto], 
		[Itbis], 
		[ID_Cliente]
	FROM [dbo].[DetalleFactura]

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_DetalleFacturaInsert]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DetalleFacturaInsert]
(
	@ID_DetalleFactura int = NULL OUTPUT, 
	@ID_Producto int, 
	@Cantidad int, 
	@ID_Factura int, 
	@Monto float, 
	@Itbis float 
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	
	
	INSERT
	INTO [DetalleFactura]
	(
		[ID_Producto], 
		[Cantidad], 
		[ID_Factura], 
		[Monto], 
		[Itbis] 
		
	)
	
	VALUES
	(
		@ID_Producto, 
		@Cantidad, 
		@ID_Factura, 
		@Monto, 
		@Itbis
		
	)


	SET @Err = @@Error

		
	SELECT @ID_DetalleFactura = SCOPE_IDENTITY()

	

	RETURN @Err
END
GO
/****** Object:  StoredProcedure [dbo].[proc_DetalleFacturaDelete]    Script Date: 09/14/2017 20:47:19 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[proc_DetalleFacturaDelete]
(
	@IDDetalleFactura int
)
AS
BEGIN

	SET NOCOUNT OFF
	DECLARE @Err int

	DELETE
	FROM [dbo].[DetalleFactura]
	WHERE
		([ID_DetalleFactura] = @IDDetalleFactura)

	SET @Err = @@Error

	RETURN @Err
END
GO
/****** Object:  ForeignKey [FK_DetalleFactura_Factura]    Script Date: 09/14/2017 20:47:17 ******/
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Factura] FOREIGN KEY([ID_Factura])
REFERENCES [dbo].[Factura] ([ID_Factura])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Factura]
GO
/****** Object:  ForeignKey [FK_DetalleFactura_Producto]    Script Date: 09/14/2017 20:47:17 ******/
ALTER TABLE [dbo].[DetalleFactura]  WITH CHECK ADD  CONSTRAINT [FK_DetalleFactura_Producto] FOREIGN KEY([ID_Producto])
REFERENCES [dbo].[Producto] ([ID_Producto])
GO
ALTER TABLE [dbo].[DetalleFactura] CHECK CONSTRAINT [FK_DetalleFactura_Producto]
GO
/****** Object:  ForeignKey [FK_Factura_Clientes]    Script Date: 09/14/2017 20:47:17 ******/
ALTER TABLE [dbo].[Factura]  WITH CHECK ADD  CONSTRAINT [FK_Factura_Clientes] FOREIGN KEY([Id_Cliente])
REFERENCES [dbo].[Clientes] ([ID_Cliente])
GO
ALTER TABLE [dbo].[Factura] CHECK CONSTRAINT [FK_Factura_Clientes]
GO
/****** Object:  ForeignKey [FK_Producto_Proveedor]    Script Date: 09/14/2017 20:47:17 ******/
ALTER TABLE [dbo].[Producto]  WITH CHECK ADD  CONSTRAINT [FK_Producto_Proveedor] FOREIGN KEY([ID_Proveedor])
REFERENCES [dbo].[Proveedor] ([ID_Proveedor])
GO
ALTER TABLE [dbo].[Producto] CHECK CONSTRAINT [FK_Producto_Proveedor]
GO
/****** Object:  ForeignKey [Fk_Menu_SubMenu]    Script Date: 09/14/2017 20:47:17 ******/
ALTER TABLE [dbo].[SubMenu]  WITH CHECK ADD  CONSTRAINT [Fk_Menu_SubMenu] FOREIGN KEY([IdMenu])
REFERENCES [dbo].[Menu] ([IdMenu])
GO
ALTER TABLE [dbo].[SubMenu] CHECK CONSTRAINT [Fk_Menu_SubMenu]
GO
