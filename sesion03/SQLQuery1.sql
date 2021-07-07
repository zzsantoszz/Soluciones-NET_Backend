/*   PASO 1 - Crear la Base de Datos BD_CONTACTABILIDAD
		F5
*/
--CREATE DATABASE [BD_CONTACTABILIDAD]

/*	PASO 2 - Ejecutar la sección restante
*/
USE [BD_CONTACTABILIDAD]
GO
/****** Object:  Table [dbo].[tb_Categoria]    Script Date: 19/02/2020 10:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Categoria](
	[idCategoria] [int] IDENTITY(1,1) NOT NULL,
	[nombreCategoria] [varchar](50) NOT NULL,
 CONSTRAINT [PK9] PRIMARY KEY NONCLUSTERED 
(
	[idCategoria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Cliente]    Script Date: 19/02/2020 10:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Cliente](
	[idCliente] [int] IDENTITY(1,1) NOT NULL,
	[nombreCliente] [varchar](50) NOT NULL,
	[apellidosCliente] [varchar](50) NOT NULL,
	[fechaNacimientoCliente] [date] NOT NULL,
	[numeroDocumentoCliente] [varchar](20) NOT NULL,
	[celularCliente] [varchar](20) NULL,
	[direccionCliente] [varchar](50) NULL,
	[emailCliente] [varchar](50) NULL,
	[generoCliente] [char](1) NOT NULL,
	[estadoCliente] [bit] NOT NULL,
	[idTipoDocumento] [int] NOT NULL,
	[idCategoria] [int] NOT NULL,
	[creacionUser] [varchar](20) NULL,
	[fechaCreacion] [date] NULL,
	[modificacionUser] [varchar](20) NULL,
	[fechaModificacion] [date] NULL,
	[idubigeo] [int] NULL,
 CONSTRAINT [PK11] PRIMARY KEY NONCLUSTERED 
(
	[idCliente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Colaborador]    Script Date: 19/02/2020 10:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Colaborador](
	[idColaborador] [int] IDENTITY(1,1) NOT NULL,
	[nombreColaborador] [varchar](50) NOT NULL,
	[apellidoColaborador] [varchar](50) NOT NULL,
	[numeroDocumentoColaborador] [varchar](20) NOT NULL,
	[idRol] [int] NOT NULL,
	[idTipoDocumento] [int] NOT NULL,
	[idubigeo] [int] NULL,
	[nombUser] [varchar](20) NULL,
 CONSTRAINT [PK12] PRIMARY KEY NONCLUSTERED 
(
	[idColaborador] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_ContactoCliente]    Script Date: 19/02/2020 10:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_ContactoCliente](
	[idContactabilidad] [int] IDENTITY(1,1) NOT NULL,
	[idColaborador] [int] NOT NULL,
	[idCliente] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
	[fechaContactoCliente] [datetime] NOT NULL,
	[comentarioContactoCliente] [varchar](250) NULL,
	[estadoContactoCliente] [char](1) NOT NULL,
 CONSTRAINT [PK13] PRIMARY KEY NONCLUSTERED 
(
	[idContactabilidad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Meta]    Script Date: 19/02/2020 10:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Meta](
	[idRol] [int] NOT NULL,
	[idSemanaPlan] [int] NOT NULL,
	[totalMeta] [int] NOT NULL,
	[idProducto] [int] NOT NULL,
 CONSTRAINT [PK15] PRIMARY KEY NONCLUSTERED 
(
	[idRol] ASC,
	[idSemanaPlan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Producto]    Script Date: 19/02/2020 10:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Producto](
	[idProducto] [int] IDENTITY(1,1) NOT NULL,
	[nombreProducto] [varchar](50) NOT NULL,
	[descripcionProducto] [varchar](50) NULL,
	[estadoProducto] [bit] NOT NULL,
 CONSTRAINT [PK10] PRIMARY KEY NONCLUSTERED 
(
	[idProducto] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Rol]    Script Date: 19/02/2020 10:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Rol](
	[idRol] [int] IDENTITY(1,1) NOT NULL,
	[nombreRol] [varchar](20) NOT NULL,
 CONSTRAINT [PK14] PRIMARY KEY NONCLUSTERED 
(
	[idRol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_SemanaPlanificada]    Script Date: 19/02/2020 10:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_SemanaPlanificada](
	[idSemanaPlan] [int] IDENTITY(1,1) NOT NULL,
	[nombreSemanaPlan] [varchar](10) NOT NULL,
	[fechaInicio] [date] NOT NULL,
	[fechaFin] [date] NOT NULL,
	[estadoSemanaPlan] [bit] NOT NULL,
 CONSTRAINT [PK16] PRIMARY KEY NONCLUSTERED 
(
	[idSemanaPlan] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_TipoDocumento]    Script Date: 19/02/2020 10:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_TipoDocumento](
	[idTipoDocumento] [int] IDENTITY(1,1) NOT NULL,
	[nombreTipoDocumento] [varchar](20) NOT NULL,
 CONSTRAINT [PK1] PRIMARY KEY NONCLUSTERED 
(
	[idTipoDocumento] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tb_Ubigeo]    Script Date: 19/02/2020 10:31:31 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tb_Ubigeo](
	[idubigeo] [int] NOT NULL,
	[distrito] [varchar](50) NULL,
	[provincia] [varchar](50) NULL,
	[departamento] [varchar](50) NULL,
	[poblacion] [int] NULL,
	[superficie] [decimal](18, 4) NULL,
 CONSTRAINT [PK_tb_Ubigeo] PRIMARY KEY CLUSTERED 
(
	[idubigeo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[tb_Cliente]  WITH CHECK ADD  CONSTRAINT [FK_tb_Cliente_tb_Ubigeo] FOREIGN KEY([idubigeo])
REFERENCES [dbo].[tb_Ubigeo] ([idubigeo])
GO
ALTER TABLE [dbo].[tb_Cliente] CHECK CONSTRAINT [FK_tb_Cliente_tb_Ubigeo]
GO
ALTER TABLE [dbo].[tb_Cliente]  WITH CHECK ADD  CONSTRAINT [Reftb_Categoria7] FOREIGN KEY([idCategoria])
REFERENCES [dbo].[tb_Categoria] ([idCategoria])
GO
ALTER TABLE [dbo].[tb_Cliente] CHECK CONSTRAINT [Reftb_Categoria7]
GO
ALTER TABLE [dbo].[tb_Cliente]  WITH CHECK ADD  CONSTRAINT [Reftb_TipoDocumento3] FOREIGN KEY([idTipoDocumento])
REFERENCES [dbo].[tb_TipoDocumento] ([idTipoDocumento])
GO
ALTER TABLE [dbo].[tb_Cliente] CHECK CONSTRAINT [Reftb_TipoDocumento3]
GO
ALTER TABLE [dbo].[tb_Colaborador]  WITH CHECK ADD  CONSTRAINT [FK_tb_Colaborador_tb_Ubigeo] FOREIGN KEY([idubigeo])
REFERENCES [dbo].[tb_Ubigeo] ([idubigeo])
GO
ALTER TABLE [dbo].[tb_Colaborador] CHECK CONSTRAINT [FK_tb_Colaborador_tb_Ubigeo]
GO
ALTER TABLE [dbo].[tb_Colaborador]  WITH CHECK ADD  CONSTRAINT [Reftb_Rol15] FOREIGN KEY([idRol])
REFERENCES [dbo].[tb_Rol] ([idRol])
GO
ALTER TABLE [dbo].[tb_Colaborador] CHECK CONSTRAINT [Reftb_Rol15]
GO
ALTER TABLE [dbo].[tb_Colaborador]  WITH CHECK ADD  CONSTRAINT [Reftb_TipoDocumento4] FOREIGN KEY([idTipoDocumento])
REFERENCES [dbo].[tb_TipoDocumento] ([idTipoDocumento])
GO
ALTER TABLE [dbo].[tb_Colaborador] CHECK CONSTRAINT [Reftb_TipoDocumento4]
GO
ALTER TABLE [dbo].[tb_ContactoCliente]  WITH CHECK ADD  CONSTRAINT [Reftb_Cliente10] FOREIGN KEY([idCliente])
REFERENCES [dbo].[tb_Cliente] ([idCliente])
GO
ALTER TABLE [dbo].[tb_ContactoCliente] CHECK CONSTRAINT [Reftb_Cliente10]
GO
ALTER TABLE [dbo].[tb_ContactoCliente]  WITH CHECK ADD  CONSTRAINT [Reftb_Colaborador9] FOREIGN KEY([idColaborador])
REFERENCES [dbo].[tb_Colaborador] ([idColaborador])
GO
ALTER TABLE [dbo].[tb_ContactoCliente] CHECK CONSTRAINT [Reftb_Colaborador9]
GO
ALTER TABLE [dbo].[tb_ContactoCliente]  WITH CHECK ADD  CONSTRAINT [Reftb_Producto14] FOREIGN KEY([idProducto])
REFERENCES [dbo].[tb_Producto] ([idProducto])
GO
ALTER TABLE [dbo].[tb_ContactoCliente] CHECK CONSTRAINT [Reftb_Producto14]
GO
ALTER TABLE [dbo].[tb_Meta]  WITH CHECK ADD  CONSTRAINT [Reftb_Producto19] FOREIGN KEY([idProducto])
REFERENCES [dbo].[tb_Producto] ([idProducto])
GO
ALTER TABLE [dbo].[tb_Meta] CHECK CONSTRAINT [Reftb_Producto19]
GO
ALTER TABLE [dbo].[tb_Meta]  WITH CHECK ADD  CONSTRAINT [Reftb_Rol16] FOREIGN KEY([idRol])
REFERENCES [dbo].[tb_Rol] ([idRol])
GO
ALTER TABLE [dbo].[tb_Meta] CHECK CONSTRAINT [Reftb_Rol16]
GO
ALTER TABLE [dbo].[tb_Meta]  WITH CHECK ADD  CONSTRAINT [Reftb_SemanaPlanificada17] FOREIGN KEY([idSemanaPlan])
REFERENCES [dbo].[tb_SemanaPlanificada] ([idSemanaPlan])
GO
ALTER TABLE [dbo].[tb_Meta] CHECK CONSTRAINT [Reftb_SemanaPlanificada17]
GO









