USE [DBDinoM_Mario]
GO
/****** Object:  StoredProcedure [dbo].[Sp_Mam_ReporteVentas]    Script Date: 18/05/2019 6:10:37 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--drop procedure Sp_Mam_ReporteVentas
ALTER PROCEDURE [dbo].[Sp_Mam_ReporteVentas] (@tipo int,@numi int=-1,@fechaI date=null,@fechaF date=null,@uact nvarchar(10)='',
@vendedor int=-1,@almacen int=-1)

AS
BEGIN
	DECLARE @newHora nvarchar(5)
	set @newHora=CONCAT(DATEPART(HOUR,GETDATE()),':',DATEPART(MINUTE,GETDATE()))

	DECLARE @newFecha date
	set @newFecha=GETDATE()
	IF @tipo=1 --Reporte Ventas Atendidas General Sucursal con Vendedor   con Factura y con Ice
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,concat (cliente.ydalmacen  ,'-',cliente.ydcod) as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, a.tafdoc) AS varchar)),3,4)) as facturas
,FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(factura.fvastot-(a.tadesc ) ) total
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
Left join TFV001 as factura on factura .fvanumi =a.tanumi 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF and a.taest<>-1

group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore,factura.fvanfac,factura .fvastot ,cliente.ydalmacen,cliente .ydcod ,a.tadesc ,a.taice   , a.tafdoc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END

	IF @tipo=2 --Reporte Ventas Atendidas General Sucursal con Vendedor
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,concat (cliente.ydalmacen  ,'-',cliente.ydcod)  as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy,a.tafdoc) AS varchar)),3,4)) as facturas,
FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(factura.fvastot-(a.tadesc  ) )as total
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
inner join TFV001 as factura on factura .fvanumi =a.tanumi 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF 
and vendedor .ydnumi =@vendedor and a.taest<>-1
group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore,factura.fvanfac,factura .fvastot,cliente.ydalmacen,cliente .ydcod  ,a.tadesc ,a.taice   , a.tafdoc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END


		IF @tipo=3 --Reporte Ventas Atendidas General Sucursal con Vendedor
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,concat (cliente.ydalmacen  ,'-',cliente.ydcod) as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, a.tafdoc) AS varchar)),3,4))as facturas,
FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(factura.fvastot-(a.tadesc  ) )as total
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
inner join TFV001 as factura on factura .fvanumi =a.tanumi 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF 
and a.taalm =@almacen and a.taest<>-1
group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore,factura.fvanfac,factura .fvastot ,cliente.ydalmacen,cliente .ydcod,a.tadesc ,a.taice   , a.tafdoc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END

		IF @tipo=4 --Reporte Ventas Atendidas General Sucursal con Vendedor CON FACTURA I ICE
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,concat (cliente.ydalmacen  ,'-',cliente.ydcod) as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, a.tafdoc) AS varchar)),3,4)) as facturas,
FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(factura.fvastot-(a.tadesc  ) )as total
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
inner join TFV001 as factura on factura .fvanumi =a.tanumi 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF 
and a.taalm =@almacen and vendedor .ydnumi =@vendedor and a.taest<>-1
group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore,factura.fvanfac,factura .fvastot,cliente.ydalmacen,cliente .ydcod ,a.tadesc ,a.taice   , a.tafdoc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END



	IF @tipo=5 --Reporte Ventas Atendidas General Sucursal con Vendedor   con factura sin ice 
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,concat (cliente.ydalmacen  ,'-',cliente.ydcod) as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, a.tafdoc) AS varchar)),3,4)) as facturas
,FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(factura.fvastot-(a.tadesc +a.taice ) ) total
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
inner join TFV001 as factura on factura .fvanumi =a.tanumi 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF and a.taest<>-1

group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore,factura.fvanfac,factura .fvastot ,cliente.ydalmacen,cliente .ydcod,a.tadesc ,a.taice   , a.tafdoc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END

	IF @tipo=6 --Reporte Ventas Atendidas General Sucursal con Vendedor
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,concat (cliente.ydalmacen  ,'-',cliente.ydcod)as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, a.tafdoc) AS varchar)),3,4))  as facturas,
FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(factura.fvastot-(a.tadesc+a.taice ) )as total
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
inner join TFV001 as factura on factura .fvanumi =a.tanumi 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF 
and vendedor .ydnumi =@vendedor and a.taest<>-1
group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore,factura.fvanfac,factura .fvastot ,cliente.ydalmacen,cliente .ydcod,a.tadesc ,a.taice   , a.tafdoc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END


		IF @tipo=7 --Reporte Ventas Atendidas General Sucursal con Vendedor con factura sin ice
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,concat (cliente.ydalmacen  ,'-',cliente.ydcod)as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, a.tafdoc) AS varchar)),3,4))as facturas,
FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(factura.fvastot-(a.tadesc +a.taice ) )as total
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
inner join TFV001 as factura on factura .fvanumi =a.tanumi 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF 
and a.taalm =@almacen and a.taest<>-1
group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore,factura.fvanfac,factura .fvastot ,cliente.ydalmacen,cliente .ydcod ,a.tadesc ,a.taice   , a.tafdoc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END

		IF @tipo=8 --Reporte Ventas Atendidas General Sucursal con Vendedor con factura sin ice
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,concat (cliente.ydalmacen  ,'-',cliente.ydcod) as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, a.tafdoc) AS varchar)),3,4)) as facturas,
FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(factura.fvastot-(a.tadesc +a.taice) )as total
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
inner join TFV001 as factura on factura .fvanumi =a.tanumi 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF 
and a.taalm =@almacen and vendedor .ydnumi =@vendedor  and a.taest<>-1
group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore,factura.fvanfac,factura .fvastot ,cliente.ydalmacen,cliente .ydcod ,a.tadesc ,a.taice   , a.tafdoc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END
	-----------------------------SIN FACTURA--------------------------------------------------
	-----------------------------------------------------------------------------------------
	------------------------------------------------------------------------------------------
	IF @tipo=11 --Reporte Ventas Atendidas General Sucursal con Vendedor   sin Factura y con Ice
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,concat (cliente.ydalmacen  ,'-',cliente.ydcod) as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, a.tafdoc) AS varchar)),3,4)) as facturas
,FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(Sum(b.tbptot )-(a.tadesc  ) ) total
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF  and a.taest<>-1

group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore ,a.tadesc,cliente.ydalmacen,cliente .ydcod ,a.taice   , a.tafdoc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END

	IF @tipo=12 --Reporte Ventas Atendidas General Sucursal con Vendedor sin factura con ice
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,concat (cliente.ydalmacen  ,'-',cliente.ydcod)as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, a.tafdoc) AS varchar)),3,4))  as facturas,
FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(Sum(b.tbptot )-(a.tadesc  )  )as total
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF 
and vendedor .ydnumi =@vendedor and a.taest<>-1
group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore ,cliente.ydalmacen,cliente .ydcod ,a.tadesc ,a.taice   , a.tafdoc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END


		IF @tipo=13 --Reporte Ventas Atendidas General Sucursal con Vendedor sin factura con ice
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,concat (cliente.ydalmacen  ,'-',cliente.ydcod) as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, a.tafdoc) AS varchar)),3,4))as facturas,
FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(Sum(b.tbptot )-(a.tadesc  )  )as total
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF 
and a.taalm =@almacen and a.taest<>-1
group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore ,cliente.ydalmacen,cliente .ydcod,a.tadesc ,a.taice   , a.tafdoc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END

		IF @tipo=14 --Reporte Ventas Atendidas General Sucursal con Vendedor sin factura con ice
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,concat (cliente.ydalmacen  ,'-',cliente.ydcod) as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy,a.tafdoc) AS varchar)),3,4)) as facturas,
FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(Sum(b.tbptot )-(a.tadesc )  )as total
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF 
and a.taalm =@almacen and vendedor .ydnumi =@vendedor  and a.taest<>-1
group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore,cliente.ydalmacen,cliente .ydcod,a.tadesc ,a.taice   , a.tafdoc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END



	IF @tipo=15 --Reporte Ventas Atendidas General Sucursal con Vendedor   con factura sin ice 
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,concat (cliente.ydalmacen  ,'-',cliente.ydcod) as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, a.tafdoc) AS varchar)),3,4)) as facturas
,FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(Sum(b.tbptot )-(a.tadesc  +a.taice ) ) total
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF and a.taest<>-1

group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore,cliente.ydalmacen,cliente .ydcod,a.tadesc ,a.taice   , a.tafdoc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END

	IF @tipo=16 --Reporte Ventas Atendidas General Sucursal con Vendedor
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,concat (cliente.ydalmacen  ,'-',cliente.ydcod) as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, a.tafdoc) AS varchar)),3,4))  as facturas,
FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(Sum(b.tbptot )-(a.tadesc  +a.taice) )as total
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF 
and vendedor .ydnumi =@vendedor and a.taest<>-1
group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore ,cliente.ydalmacen,cliente .ydcod,a.tadesc ,a.taice   , a.tafdoc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END


		IF @tipo=17 --Reporte Ventas Atendidas General Sucursal con Vendedor con factura sin ice
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,concat (cliente.ydalmacen  ,'-',cliente.ydcod) as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, a.tafdoc) AS varchar)),3,4))as facturas,
FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(Sum(b.tbptot )-(a.tadesc   +a.taice) )as total
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF 
and a.taalm =@almacen and a.taest<>-1
group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,cliente.ydalmacen,cliente .ydcod,a.taidcore,a.tadesc ,a.taice   , a.tafdoc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END

		IF @tipo=18 --Reporte Ventas Atendidas General Sucursal con Vendedor con factura sin ice
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,concat (cliente.ydalmacen  ,'-',cliente.ydcod) as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, a.tafdoc) AS varchar)),3,4)) as facturas,
FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(Sum(b.tbptot )-(a.tadesc  +a.taice) )as total
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF 
and a.taalm =@almacen and vendedor .ydnumi =@vendedor  and a.taest<>-1
group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore ,cliente.ydalmacen,cliente .ydcod,a.tadesc ,a.taice   , a.tafdoc


		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END
End




