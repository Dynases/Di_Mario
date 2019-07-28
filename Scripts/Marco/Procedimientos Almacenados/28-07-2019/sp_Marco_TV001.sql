USE [DBDinoM_Mario]
GO

/****** Object:  StoredProcedure [dbo].[sp_Mam_TV001]    Script Date: 28/07/2019 14:36:51 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO



------------Ojo el detalle de la identidad comenzara en 1000 para que no haiga datos duplicado con los id que genera el detalle

--drop procedure sp_Mam_TV001
CREATE PROCEDURE [dbo].[sp_Marco_TV001] (@tipo int,@tanumi int=-1,
@tauact nvarchar(10)='',@TV001 TV001Type ReadOnly,@fechai date=null,@fechaf date=null)

AS
BEGIN
	DECLARE @newHora nvarchar(5)
	set @newHora=CONCAT(DATEPART(HOUR,GETDATE()),':',DATEPART(MINUTE,GETDATE()))

	DECLARE @newFecha date
	set @newFecha=GETDATE()

	IF @tipo=2--MODIFICACION
	BEGIN
		BEGIN TRY 
			--MODIFICO LOS REGISTROS
			UPDATE TV001
			SET tatotal =td.total ,tadesc =td.descuento , tafact  =@newFecha,tahact  =@newHora,tauact  =@tauact
			FROM TV001  INNER JOIN @TV001 AS td
			ON TV001 .tanumi    = td.tanumi  and td.estado=2 -- and td.tbcmin<> null;
			select @tanumi as newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),2,@newFecha,@newHora,@tauact)
		END CATCH
	END

	IF @tipo=3 --Listar Ventas
	BEGIN
		BEGIN TRY 
select a.tanumi as  tanumi ,concat(a.tanumi,'-19') as codigo ,a.tafdoc ,vendedor .yddesc as vendedor ,a.tafvcr ,concat(a.taalm,'-',cliente.ydcod )as codcliente,
		cliente.yddesc as cliente,IIF(tamon=1,'Boliviano','Dolar') as moneda ,a.taobs ,
		a.tatotal +a.tadesc as subtotal,a.tadesc as descuento,cast(((a.tadesc *100)/(a.tatotal +a.tadesc)) as decimal (18,2)) as porcentaje,a.tatotal as total,IIF(a.tadesc >0,1,0)as tienedescuento,
		(IIF(Exists(select * from TV00121 where tdtv12numi =a.tanumi),1,0))as existepagos,
		1 as estado
		from TV001 as a inner join TY004 as cliente on cliente .ydnumi  =a.taclpr and a.taest>0 
		inner join TY004 as vendedor on vendedor .ydnumi =taven 
		inner join TV0011 as b on b.tbtv1numi =a.tanumi 
		where a.tafdoc >=@fechai and a.tafdoc <=@fechaf 
					group by a.tanumi ,a.taalm ,a.tafdoc ,a.taven ,vendedor .yddesc,a.tatven ,a.tafvcr ,a.taclpr,
		cliente.yddesc ,a.tamon ,a.taest ,a.taobs ,vendedor.ydcod ,
		a.tadesc, a.taice,a.tatotal, a.tafact ,a.tahact ,cliente.ydcod,vendedor.ydnumi,cliente.ydalmacen,a.tauact ,a.taproforma
				order by a.tanumi asc
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@tauact)
		END CATCH
	END

End










GO


