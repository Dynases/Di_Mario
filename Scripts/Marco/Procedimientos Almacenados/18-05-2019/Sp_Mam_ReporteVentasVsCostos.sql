USE [DBDinoM_Mario]
GO
/****** Object:  StoredProcedure [dbo].[Sp_Mam_ReporteVentasVsCostos]    Script Date: 18/05/2019 5:19:49 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



--drop procedure Sp_Mam_ReporteVentas
ALTER PROCEDURE [dbo].[Sp_Mam_ReporteVentasVsCostos] (@tipo int,@numi int=-1,@fechaI date=null,@fechaF date=null,@uact nvarchar(10)='',
@vendedor int=-1,@almacen int=-1)

AS
BEGIN
	DECLARE @newHora nvarchar(5)
	set @newHora=CONCAT(DATEPART(HOUR,GETDATE()),':',DATEPART(MINUTE,GETDATE()))

	DECLARE @newFecha date
	set @newFecha=GETDATE()
	IF @tipo=1 --Reporte Ventas Atendidas General Sucursal con Vendedor
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, GETDATE()) AS varchar)),3,4)) as facturas
,FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(Sum(b.tbptot)-(a.tadesc ) ) totalVenta ,(Sum(b.tbptot2 )) as TotalCosto,
((Sum(b.tbptot )-(a.tadesc ))-(Sum(b.tbptot2 ))) as utilidad
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF and a.taest<>-1

group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore ,a.tadesc ,a.taice   , a.tafdoc
order by cliente .yddesc asc

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END

		IF @tipo=11 --Reporte Ventas Atendidas General Sucursal con Vendedor
	BEGIN
		BEGIN TRY 


		
select a.tcnumi,Concat(venta.taidcore ,'-',Year(a.tcfdoc)) NroDoc ,
	IIF(exists(select factura.fvanumi from TFV001 as factura where factura.fvanumi=a.tctv1numi),
	(select factura.fvanfac from TFV001 as factura where factura.fvanumi=
	a.tctv1numi),'0') as factura
	,a.tctv1numi ,a.tcty4clie ,concat (cliente.ydalmacen  ,'-',cliente.ydcod) as ydcod, cliente.yddesc   as cliente,a.tcty4vend,
	vendedor.yddesc as vendedor,FORMAT ((select Max(detalle.tdfechaPago  ) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf)  , 'dd-MM-yyyy')as FechaPago ,FORMAT (venta.tafdoc , 'dd-MM-yyyy')as FechaVenta ,tctotcre as totalfactura,

	(tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago <@fechai))as pendiente
	
	,	((select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf))as Pagado,
	(tctotcre -((select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago <@fechai)+(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf)))as Saldo,
	sucursal .aabdes  as almacen
	from TV0012 as a inner join TY004 as cliente
	on cliente .ydnumi =a.tcty4clie 
	inner join TY004 as vendedor on vendedor .ydnumi =a.tcty4vend 
	inner join TV001 as venta on venta.tanumi =a.tctv1numi 
	inner join TA001 as sucursal on sucursal.aanumi =venta .taalm 
		where    venta.taest<>-1 and
		(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf)>0
	order by  cliente.yddesc asc

	

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END

	IF @tipo=2 --Reporte Ventas Atendidas General Sucursal con Vendedor
	BEGIN
		BEGIN TRY 
		select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, GETDATE()) AS varchar)),3,4)) as facturas
,FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(Sum(b.tbptot)-(a.tadesc ) ) totalVenta ,(Sum(b.tbptot2 )) as TotalCosto,
((Sum(b.tbptot )-(a.tadesc ))-(Sum(b.tbptot2 ))) as utilidad
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF 
and vendedor .ydnumi =@vendedor and a.taest<>-1
group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore, a.tadesc ,a.taice   , a.tafdoc
order by cliente .yddesc asc

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END


		IF @tipo=22 --Reporte Ventas Atendidas General Sucursal con Vendedor
	BEGIN
		BEGIN TRY 
				
select a.tcnumi,Concat(venta.taidcore ,'-',Year(a.tcfdoc)) NroDoc ,
	IIF(exists(select factura.fvanumi from TFV001 as factura where factura.fvanumi=a.tctv1numi),
	(select factura.fvanfac from TFV001 as factura where factura.fvanumi=
	a.tctv1numi),'0') as factura
	,a.tctv1numi ,a.tcty4clie ,concat (cliente.ydalmacen  ,'-',cliente.ydcod) as ydcod, cliente.yddesc   as cliente,a.tcty4vend,
	vendedor.yddesc as vendedor,FORMAT ((select Max(detalle.tdfechaPago  ) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf)  , 'dd-MM-yyyy')as FechaPago ,FORMAT (venta.tafdoc , 'dd-MM-yyyy')as FechaVenta ,tctotcre as totalfactura,

	(tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago <@fechai))as pendiente
	
	,	((select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf))as Pagado,
	(tctotcre -((select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago <@fechai)+(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf)))as Saldo,
	sucursal .aabdes  as almacen
	from TV0012 as a inner join TY004 as cliente
	on cliente .ydnumi =a.tcty4clie 
	inner join TY004 as vendedor on vendedor .ydnumi =a.tcty4vend 
	inner join TV001 as venta on venta.tanumi =a.tctv1numi 
	inner join TA001 as sucursal on sucursal.aanumi =venta .taalm 
	
		where   venta.taest<>-1 and
		(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf)>0
		and vendedor .ydnumi =@vendedor
		--and venta.tafdoc =@tefdoc 
	order by  cliente.yddesc asc



		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END


		IF @tipo=3 --Reporte Ventas Atendidas General Sucursal con Vendedor
	BEGIN
		BEGIN TRY 



			select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, GETDATE()) AS varchar)),3,4)) as facturas
,FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(Sum(b.tbptot)-(a.tadesc ) ) totalVenta ,(Sum(b.tbptot2 )) as TotalCosto,
((Sum(b.tbptot )-(a.tadesc ))-(Sum(b.tbptot2 ))) as utilidad
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm 
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF 
and a.taalm =@almacen and a.taest<>-1
group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore ,a.tadesc ,a.taice   , a.tafdoc
order by cliente .yddesc asc

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END


	
		IF @tipo=33 --Reporte Ventas Atendidas General Sucursal con Vendedor
	BEGIN
		BEGIN TRY 

	select a.tcnumi,Concat(venta.taidcore ,'-',Year(a.tcfdoc)) NroDoc ,
	IIF(exists(select factura.fvanumi from TFV001 as factura where factura.fvanumi=a.tctv1numi),
	(select factura.fvanfac from TFV001 as factura where factura.fvanumi=
	a.tctv1numi),'0') as factura
	,a.tctv1numi ,a.tcty4clie ,concat (cliente.ydalmacen  ,'-',cliente.ydcod) as ydcod, cliente.yddesc   as cliente,a.tcty4vend,
	vendedor.yddesc as vendedor,FORMAT ((select Max(detalle.tdfechaPago  ) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf)  , 'dd-MM-yyyy')as FechaPago ,FORMAT (venta.tafdoc , 'dd-MM-yyyy')as FechaVenta ,tctotcre as totalfactura,

	(tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago <@fechai))as pendiente
	
	,	((select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf))as Pagado,
	(tctotcre -((select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago <@fechai)+(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf)))as Saldo,
	sucursal .aabdes  as almacen
	from TV0012 as a inner join TY004 as cliente
	on cliente .ydnumi =a.tcty4clie 
	inner join TY004 as vendedor on vendedor .ydnumi =a.tcty4vend 
	inner join TV001 as venta on venta.tanumi =a.tctv1numi 
	inner join TA001 as sucursal on sucursal.aanumi =venta .taalm 
	
		where   venta.taest<>-1 and
		(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf)>0
		and venta.taalm =@almacen and venta.taest<>-1
		--and venta.tafdoc =@tefdoc 
	order by  cliente.yddesc asc
			

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END
		IF @tipo=4 --Reporte Ventas Atendidas General Sucursal con Vendedor 
	BEGIN
		BEGIN TRY 


				select almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi as CodVenta
,cliente .yddesc  AS cliente ,CONCAT (a.taidcore ,'-',Substring((CAST(DATEPART(yy, GETDATE()) AS varchar)),3,4)) as facturas
,FORMAT (a.tafdoc , 'dd-MM-yyyy')  as FechaVenta,(Sum(b.tbptot)-(a.tadesc ) ) totalVenta ,(Sum(b.tbptot2 )) as TotalCosto,
((Sum(b.tbptot )-(a.tadesc ))-(Sum(b.tbptot2 ))) as utilidad
from TV001 as a inner join TV0011 as b on b.tbtv1numi =a.tanumi 
inner join TY004 as vendedor on vendedor .ydtip =2 and
a.taven =vendedor.ydnumi 
inner join TY004 as cliente on cliente.ydtip =1 and cliente.ydnumi =a.taclpr 
inner join TA001 as almacen on almacen .aanumi =a.taalm
and a.tafdoc>=@fechaI  and a.tafdoc <=@fechaF 
and a.taalm =@almacen and vendedor .ydnumi =@vendedor  and a.taest<>-1
group by almacen .aanumi ,almacen .aabdes,vendedor .ydnumi ,vendedor .yddesc ,a.tanumi 
,cliente .yddesc,a.taidcore,a.tadesc ,a.taice   , a.tafdoc
order by cliente .yddesc asc

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END

		IF @tipo=44 --Reporte Ventas Atendidas General Sucursal con Vendedor 
	BEGIN
		BEGIN TRY 

		select a.tcnumi,Concat(venta.taidcore ,'-',Year(a.tcfdoc)) NroDoc ,
	IIF(exists(select factura.fvanumi from TFV001 as factura where factura.fvanumi=a.tctv1numi),
	(select factura.fvanfac from TFV001 as factura where factura.fvanumi=
	a.tctv1numi),'0') as factura
	,a.tctv1numi ,a.tcty4clie ,concat (cliente.ydalmacen  ,'-',cliente.ydcod) as ydcod, cliente.yddesc   as cliente,a.tcty4vend,
	vendedor.yddesc as vendedor,FORMAT ((select Max(detalle.tdfechaPago  ) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf)  , 'dd-MM-yyyy')as FechaPago ,FORMAT (venta.tafdoc , 'dd-MM-yyyy')as FechaVenta ,tctotcre as totalfactura,

	(tctotcre -(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago <@fechai))as pendiente
	
	,	((select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf))as Pagado,
	(tctotcre -((select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago <@fechai)+(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf)))as Saldo,
	sucursal .aabdes  as almacen
	from TV0012 as a inner join TY004 as cliente
	on cliente .ydnumi =a.tcty4clie 
	inner join TY004 as vendedor on vendedor .ydnumi =a.tcty4vend 
	inner join TV001 as venta on venta.tanumi =a.tctv1numi 
	inner join TA001 as sucursal on sucursal.aanumi =venta .taalm 
	
		where   venta.taest<>-1 and
		(select Isnull(Sum(detalle.tdmonto ),0) from TV00121 as detalle where detalle .tdtv12numi =a.tcnumi and
	detalle.tdfechaPago >=@fechai and detalle.tdfechaPago <=@fechaf)>0
		and venta.taalm =@almacen  and vendedor .ydnumi =@vendedor  and venta.taest<>-1
		--and venta.tafdoc =@tefdoc 
	order by  cliente.yddesc asc
				
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@uact)
		END CATCH
	END
	IF @tipo=5
	BEGIN
		BEGIN TRY
SELECT  producto.yfnumi, producto.yfcdprod1, gr1.ycdes3 AS presentacion, Umin.ycdes3 AS unidad, SUM(detalle.tbcmin) AS cantidad, 0 as tbpbas, SUM(detalle.tbptot) AS TotalVenta
FROM     dbo.TV0011 AS detalle INNER JOIN
                  dbo.TY005 AS producto ON detalle.tbty5prod = producto.yfnumi INNER JOIN
                  dbo.TV001 AS venta ON venta.tanumi = detalle.tbtv1numi INNER JOIN
                  dbo.TY0031 AS Umin ON Umin.yccod1 = 1 AND Umin.yccod2 = 5 AND Umin.yccod3 = producto.yfMed INNER JOIN
                  dbo.TY0031 AS gr1 ON gr1.yccod1 = 1 AND gr1.yccod2 = 4 AND gr1.yccod3 = producto.yfgr4 
				  and venta .tafdoc >=@fechaI  and venta.tafdoc <=@fechaF 
GROUP BY producto.yfcdprod1, gr1.ycdes3, producto.yfnumi, Umin.ycdes3
ORDER BY yfcdprod1 asc
		
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@uact)
		END CATCH

END


IF @tipo=6   ------Productos vs ventas Todos los almacenes con su precio de cada producto por almacen
	BEGIN
		BEGIN TRY
select almacen .aanumi ,almacen .aabdes ,producto .yfnumi, producto .yfcdprod1  ,gr1.ycdes3 as presentacion,
Umin .ycdes3 as unidad,Sum( detalle.tbcmin) as cantidad,detalle .tbpbas   ,Sum(detalle.tbptot) as TotalVenta 
from TV0011 as detalle 
inner join TY005 as producto on detalle .tbty5prod =producto .yfnumi 
inner join TV001 as venta on venta .tanumi =detalle .tbtv1numi 
inner join TY0031 as Umin on Umin .yccod1=1 and Umin .yccod2 =5 and Umin .yccod3 =producto .yfMed   
inner join TY0031 as gr1 on gr1.yccod1 =1 and gr1.yccod2 =4 and gr1.yccod3 =producto .yfgr4 
inner join TA001 as almacen on almacen .aanumi =venta .taalm 
 and venta .tafdoc >=@fechaI  and venta.tafdoc <=@fechaF 
group by  almacen .aanumi ,almacen .aabdes ,producto .yfcdprod1 ,gr1.ycdes3,producto .yfnumi,detalle .tbpbas ,
Umin .ycdes3

		
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@uact)
		END CATCH

END

IF @tipo=7   ------Productos vs ventas Todos los almacenes con su precio de cada producto por almacen
	BEGIN
		BEGIN TRY
select almacen .aanumi ,almacen .aabdes ,producto .yfnumi, producto .yfcdprod1  ,gr1.ycdes3 as presentacion,
Umin .ycdes3 as unidad,Sum( detalle.tbcmin) as cantidad,detalle .tbpbas   ,Sum(detalle.tbptot) as TotalVenta 
from TV0011 as detalle 
inner join TY005 as producto on detalle .tbty5prod =producto .yfnumi 
inner join TV001 as venta on venta .tanumi =detalle .tbtv1numi 
inner join TY0031 as Umin on Umin .yccod1=1 and Umin .yccod2 =5 and Umin .yccod3 =producto .yfMed   
inner join TY0031 as gr1 on gr1.yccod1 =1 and gr1.yccod2 =4 and gr1.yccod3 =producto .yfgr4 
inner join TA001 as almacen on almacen .aanumi =venta .taalm 
 and venta .tafdoc >=@fechaI  and venta.tafdoc <=@fechaF 
  and almacen .aanumi =@almacen 
group by  almacen .aanumi ,almacen .aabdes ,producto .yfcdprod1 ,gr1.ycdes3,producto .yfnumi,detalle .tbpbas ,
Umin .ycdes3

		
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@uact)
		END CATCH

END
End







