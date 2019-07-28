USE [DBDinoM_Mario]
GO

/****** Object:  UserDefinedTableType [dbo].[TV0011Type]    Script Date: 28/07/2019 14:05:12 ******/
CREATE TYPE [dbo].[TV001Type] AS TABLE(
	[tanumi] [int] NULL,
	[codigo][nvarchar](50)null,
	[tafdoc][date]null,
	[vendedor][nvarchar](150)null,
	[tafvcr][date]null,
	[codcliente][nvarchar](50)null,
	[cliente][nvarchar](150)null,
	[moneda][nvarchar](100)null,
	[taobs][nvarchar](200)null,
	[subtotal]decimal(18,2)null,
	[descuento]decimal(18,2)null,
	[porcentaje]decimal(18,2)null,
	[total]decimal(18,2)null,
	[tienedescuento] int null,
	[existepagos]int null,
	[estado] int null
)
GO


