USE [DBDinoM_Mario]
GO
/****** Object:  StoredProcedure [dbo].[sp_Mam_TI002]    Script Date: 08/08/2019 5:13:30 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

--drop procedure sp_Mam_TI002
ALTER PROCEDURE [dbo].[sp_Mam_TI002] (@tipo int,@ibid int=-1,@ibfdoc date =null,
@ibconcep int=-1,@ibobs nvarchar(100)='' ,@ibest int=-1,
@ibalm int=-1,@ibdepdest int=-1,@ibiddc int=-1,@ibuact nvarchar(10)='',@TI0021 TI0021Type ReadOnly,
@producto int=-1,@fechaI date=null,@fechaF date =null,@almacen int=-1,@cantidad decimal(18,2)=0,@ibidOrigen int=-1,
@lote nvarchar(50)='',@fechaVenc date=null)

AS
BEGIN
	DECLARE @newHora nvarchar(5)
	set @newHora=CONCAT(DATEPART(HOUR,GETDATE()),':',DATEPART(MINUTE,GETDATE()))
	declare @icid int
	DECLARE @newFecha date
	set @newFecha=GETDATE()
	declare @concepto int
	declare @movimiento int
	declare @TI21 TI0021Type
	declare @deposito int
	declare @conceptoDestino int   -----Concepto Destino
	declare @movimientoDestino int  ----Movimiento Destino 
	declare @depositoDestino int
	declare @ibid2 int
	-------------------------     CURSOR ---------------------
	declare @icibid int
	declare @iccprod int
	declare @iccant decimal(18,2)
	declare @iclot nvarchar(20)  --------ojo la longitud es de 20 en este caso 
	declare @icfvenc date
	declare @cantAct decimal(18,2)
	declare @cantE decimal(18,2)
			declare @can decimal(18,2)
declare @loteAux nvarchar(50)
declare @FechaVencAux date
	-------------------------
	IF @tipo=-1 --ELIMINAR REGISTRO
	BEGIN
		BEGIN TRY 
		
--			set @deposito =(Select b.abnumi   from TI002  as a,TA002 as b,TA001 as c where c.aata2dep =b.abnumi 
--and a.ibid  =@ibid  and a.ibalm  =c.aanumi )

set @deposito =(Select a.ibalm    from TI002  as a,TA002 as b,TA001 as c where c.aata2dep =b.abnumi 
and a.ibid  =@ibid  and a.ibalm  =c.aanumi )

			set @concepto =(Select a.ibconcep from TI002 as a where a.ibid =@ibid)
			set @movimiento =(Select a.cpmov   from TCI001 as a where a.cpnumi=@concepto  )

			if(@concepto =6)
				begin
				set @conceptoDestino  =(Select a.ibconcep from TI002 as a where a.ididdestino=@ibid)

			set @movimientoDestino  =(Select a.cpmov   from TCI001 as a where a.cpnumi=@conceptoDestino  )
			set @ibid2  =(Select a.ibid from TI002 as a where a.ididdestino=@ibid)
			set @depositoDestino =(Select a.ibalm    from TI002  as a,TA002 as b,TA001 as c where c.aata2dep =b.abnumi 
and a.ibid  =@ibid2   and a.ibalm  =c.aanumi )
			UPDATE TI001
			SET TI001.iccven  =(TI001.iccven+((@movimientoDestino)*(-td.iccant)))  
			FROM TI001  INNER JOIN TI0021 AS td
			ON TI001 .iccprod      = td.iccprod and td.icibid =@ibid2  and TI001 .icalm =@depositoDestino  
			and TI001 .iclot =td.iclot and TI001.icfven =td.icfvenc 
				UPDATE TI001
			SET TI001.iccven  =(TI001.iccven+((@movimiento )*(-td.iccant)))  
			FROM TI001  INNER JOIN TI0021 AS td
			ON TI001 .iccprod      = td.iccprod and td.icibid =@ibid and TI001 .icalm =@deposito 
			and TI001 .iclot =td.iclot and TI001.icfven =td.icfvenc 

				DELETE from TI002   where ibid   =@ibid
			DELETE FROM TI0021   WHERE icibid   =@ibid 
				DELETE from TI002   where ibid   =@ibid2 
			DELETE FROM TI0021   WHERE icibid   =@ibid2  
			select @ibid as newNumi  --Consulibr que hace newNumi



				end
				if(@concepto <>6)
				begin
				UPDATE TI001
			SET TI001.iccven  =(TI001.iccven+((@movimiento )*(-td.iccant)))  
			FROM TI001  INNER JOIN TI0021 AS td
			ON TI001 .iccprod      = td.iccprod and td.icibid =@ibid and TI001 .icalm =@deposito 
			and TI001 .iclot =td.iclot and TI001.icfven =td.icfvenc 
				DELETE from TI002   where ibid   =@ibid
			DELETE FROM TI0021   WHERE icibid   =@ibid ;
			select @ibid as newNumi  --Consulibr que hace newNumi
				end
			
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),-1,@newFecha,@newHora,@ibuact)
		END CATCH
	END

	IF @tipo=1 --NUEVO REGISTRO cabezera
	BEGIN
		BEGIN TRY 
                set @ibid=IIF((select COUNT(ibid) from TI002)=0,0,(select MAX(ibid) from TI002))+1
				--set @deposito =(Select b.abnumi   from TA002 as b,TA001 as c where c.aata2dep =b.abnumi 
				--and c.aanumi =@ibalm )
				if(@ibconcep =5)
				begin
				 
				  INSERT INTO TI002 VALUES(@ibid ,@ibfdoc,@ibconcep ,Concat(@ibobs  ,' ORIGEN: ',@ibdepdest,'-',(select TA002.abdesc from  TA002 where TA002.abnumi =@ibdepdest)),@ibest,
			@ibalm ,@ibdepdest,@ibidOrigen,@ibiddc,@newFecha,@newHora,@ibuact)
			select @ibid as newNumi  --Consulibr que hace newNumi
				 update TI002 
				 set TI002.ididdestino=@ibid 
				 ,TI002.ibobs =Concat(TI002.ibobs  ,' DESTINO: ',@ibalm ,'-',(select TA002.abdesc from  TA002 where TA002.abnumi =@ibalm))
				 where TI002.ibid =@ibidOrigen  
				end
				if(@ibconcep =6)
				begin
				 
				  INSERT INTO TI002 VALUES(@ibid ,@ibfdoc,@ibconcep ,@ibobs  ,@ibest,
			@ibalm ,@ibdepdest,@ibidOrigen ,@ibiddc,@newFecha,@newHora,@ibuact)
			select @ibid as newNumi  --Consulibr que hace newNumi
				 
				end
			if(@ibconcep <>5 and @ibconcep <>6)
				begin
				 
				  INSERT INTO TI002 VALUES(@ibid ,@ibfdoc,@ibconcep ,@ibobs  ,@ibest,
			@ibalm ,@ibdepdest ,@ibidOrigen,@ibiddc,@newFecha,@newHora,@ibuact)
			select @ibid as newNumi  --Consulibr que hace newNumi
				 
				end

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@ibuact)
		END CATCH
	END
	IF @tipo=10 --NUEVO Detalle
	BEGIN
		BEGIN TRY 	
			-------VerificarExisteProductoLote----------------------
			declare MiCursor Cursor
	for Select a.icid  ,a.icibid  ,a.iccprod  ,a.iccant  ,a.iclot ,a.icfvenc   
				From @TI0021  a where a.estado=0 and a.iccprod >0 --INNER JOIN TCI001 b ON a.chtmov=b.cpnumi
--Abrir el cursor
open MiCursor
-- Navegar
Fetch MiCursor into @icid,@icibid,@iccprod,@iccant,@iclot,@icfvenc
while (@@FETCH_STATUS = 0)
begin
		--------------------------AQUI OBTENGO EL DEPOSITO MAS EL MOVIMIENTO =1 =-1 -----------
			set @concepto =(Select a.ibconcep from TI002 as a where a.ibid =@ibid)
			set @movimiento =(Select a.cpmov   from TCI001 as a where a.cpnumi=@concepto  )
			set @deposito =(Select a.ibalm    from TI002  as a where a.ibid  =@ibid )--Almacen=Deposito 
			-----------------------------------------------------------------------------------
			if(exists(select TI001.iccprod from TI001 where TI001.iccprod = convert(int, @iccprod)
			and TI001 .icalm =@deposito and TI001.iclot =@iclot and TI001.icfven =@icfvenc ))
			begin 	
				begin try
					begin tran Tr_UpdateTI001
						--Obtener la cantidad actual
				
		

			set @cantAct = (select TI001.iccven  from TI001 where TI001.iccprod  = convert(int, @iccprod)
						                                                       and TI001 .icalm =@deposito
													 and TI001.iclot =@iclot and TI001.icfven =@icfvenc )
						
						
						--Actualizar Saldo Inventario
						update TI001 
							set iccven = (@cantAct+((@movimiento )*(@iccant)))  
							where TI001.iccprod  = CONVERT(int, @iccprod) and TI001 .icalm =@deposito 
							and  TI001.iclot =@iclot and TI001.icfven =@icfvenc
						

						set @icid=IIF((select COUNT(icid) from TI0021)=0,0,(select MAX(icid) from TI0021))+1
				INSERT INTO TI0021 values (@icid,@ibid,@iccprod ,@iccant,@iclot ,@icfvenc )
						select @ibid as newNumi
					commit tran Tr_UpdateTI001
					print concat('Se actualizo el saldo del producto con codigo: ', @iccprod)
				end try
				begin catch
					rollback tran Tr_UpdateTI001
					print concat('No se pudo actualizo el saldo del producto con codigo: ', @iccprod)
				end catch
			end
			else
			begin
				begin try
					begin tran Tr_InsertTI001
						--Insertar Saldo Inventar
						declare @cbumin int
						set @cbumin =( select top 1 a.yfMed   from TY005 as a where a.yfnumi =@iccprod)
				Insert into TI001 values(@deposito ,CONVERT(int, @iccprod), ((@movimiento )*(@iccant))
				, @cbumin,@iclot ,@icfvenc )
				set @icid=IIF((select COUNT(icid) from TI0021)=0,0,(select MAX(icid) from TI0021))+1
				INSERT INTO TI0021 values (@icid,@ibid,@iccprod ,@iccant,@iclot ,@icfvenc )
							select @ibid as newNumi
					commit tran Tr_InsertTI001
					print concat('Se grabo el saldo del producto con codigo: ', @iccprod)
				end try
				begin catch
					rollback tran Tr_InsertTI001
					print concat('No se grabo el saldo del producto con codigo: ', @iccprod)
				end catch
			end
		
	Fetch MiCursor into @icid,@icibid,@iccprod,@iccant,@iclot,@icfvenc
end

--Cerrar el Cursor
close MiCursor
--Liberar la memoria
deallocate MiCursor
			
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@ibuact)
		END CATCH
	END

	IF @tipo=11 --MODIFICO DETALLE
	BEGIN
		BEGIN TRY 
	
	-------VerificarExisteProductoLote----------------------
			declare MiCursor Cursor
	for Select a.icid  ,a.icibid  ,a.iccprod  ,a.iccant  ,a.iclot ,a.icfvenc   
				From @TI0021  a where a.estado=2 and a.iccprod >0 --INNER JOIN TCI001 b ON a.chtmov=b.cpnumi
--Abrir el cursor
open MiCursor
-- Navegar
Fetch MiCursor into @icid,@icibid,@iccprod,@iccant,@iclot,@icfvenc
while (@@FETCH_STATUS = 0)
begin

		--------------------------AQUI OBTENGO EL DEPOSITO MAS EL MOVIMIENTO =1 =-1 -----------
				set @concepto =(Select a.ibconcep from TI002 as a where a.ibid =@ibid)
			set @movimiento =(Select a.cpmov   from TCI001 as a where a.cpnumi=@concepto  )
				set @deposito =(Select a.ibalm    from TI002  as a where a.ibid  =@ibid )--Almacen=Deposito 

				set @cantE = (select d.iccant    from TI0021  d where d.icibid    = @ibid  
				and d.iclot=@iclot and d.icfvenc =@icfvenc and d.iccprod =@iccprod)


		set @loteAux=(select d.iclot    from TI0021 d where d.icibid    = @ibid 
		and d.iclot=@iclot and d.icfvenc =@icfvenc and d.iccprod =@iccprod)
		set @FechaVencAux=(select d.icfvenc     from TI0021 d where d.icibid    = @ibid 
		and d.iclot=@iclot and d.icfvenc =@icfvenc and d.iccprod =@iccprod)
			-----------------------------------------------------------------------------------

			if (exists (select TI001.iccprod from TI001 where TI001.iccprod = convert(int, @iccprod)
			and TI001 .icalm =@deposito and TI001.iclot =@iclot and TI001.icfven =@icfvenc
			and TI001.iclot =@loteAux and TI001 .icfven =@FechaVencAux  ))
			begin 	
				begin try
					begin tran Tr_UpdateTI001
						--Obtener la cantidad actual	
						set @cantAct = (select TI001.iccven  from TI001 where TI001.iccprod  = convert(int, @iccprod) 
						and TI001 .icalm =@deposito 	
						 and TI001.iclot =@iclot and TI001.icfven =@icfvenc )

						update TI001 
							set iccven = (@cantAct+((@movimiento )*(@iccant-@cantE))) 
							where TI001.iccprod  = CONVERT(int, @iccprod) and TI001 .icalm =@deposito 
							and  TI001.iclot =@iclot and TI001.icfven =@icfvenc

								update TI0021
							set iccant =@iccant 
							where TI0021 .icibid =@ibid 
								and  TI0021 .iclot =@iclot and TI0021 .icfvenc  =@icfvenc
						      and TI0021.iccprod   =@iccprod
					commit tran Tr_UpdateTI001
					print concat('Se actualizo el saldo del producto con codigo: ', @iccprod)
				end try
				begin catch
					rollback tran Tr_UpdateTI001
					print concat('No se pudo actualizo el saldo del producto con codigo: ', @iccprod)
				end catch
			end
			else
			begin
				begin try
					begin tran Tr_InsertTI001
						--Insertar Saldo Inventar
					
						set @cantAct = (select TI001.iccven  from TI001 where TI001.iccprod  = convert(int, @iccprod) 
						and TI001 .icalm =@deposito 	
						 and TI001.iclot =@loteAux  and TI001.icfven =@FechaVencAux )
						set @can = (@cantAct -@cantE)
							update TI001 
							set iccven  = @can
							where TI001.iccprod  = CONVERT(int, @iccprod) and TI001 .icalm =@deposito  
								 and TI001.iclot =@loteAux  and TI001.icfven =@FechaVencAux 

		Insert into TI001 values(@deposito ,CONVERT(int, @iccprod), ((@movimiento )*(@iccant))
				, @cbumin,@iclot ,@icfvenc )

				update TI0021
							set iccant =@iccant      --@cantE -@lccant Preguntar a Guido
							,iclot =@iclot ,
							icfvenc =@icfvenc 
							where TI0021 .icibid =@ibid 
								and  TI0021 .iclot =@loteAux and TI0021 .icfvenc  =@FechaVencAux
								   and TI0021.iccprod   =@iccprod
							select @ibid as newNumi
					commit tran Tr_InsertTI001
					print concat('Se grabo el saldo del producto con codigo: ', @iccprod)
				end try
				begin catch
					rollback tran Tr_InsertTI001
					print concat('No se grabo el saldo del producto con codigo: ', @iccprod)
				end catch
			end
		
	Fetch MiCursor into @icid,@icibid,@iccprod,@iccant,@iclot,@icfvenc
end

--Cerrar el Cursor
close MiCursor
--Liberar la memoria
deallocate MiCursor
			
	
		   
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@ibuact)
		END CATCH
	END

	IF @tipo=12 --ELIMINO DETALLE
	BEGIN
		BEGIN TRY 
		-------VerificarExisteProductoLote----------------------
			declare MiCursor Cursor
	for Select a.icid  ,a.icibid  ,a.iccprod  ,a.iccant  ,a.iclot ,a.icfvenc   
				From @TI0021  a where a.estado=-1 and a.iccprod >0 --INNER JOIN TCI001 b ON a.chtmov=b.cpnumi
--Abrir el cursor
open MiCursor
-- Navegar
Fetch MiCursor into @icid,@icibid,@iccprod,@iccant,@iclot,@icfvenc
while (@@FETCH_STATUS = 0)
begin
		--------------------------AQUI OBTENGO EL DEPOSITO MAS EL MOVIMIENTO =1 =-1 -----------
				set @concepto =(Select a.ibconcep from TI002 as a where a.ibid =@ibid)
			set @movimiento =(Select a.cpmov   from TCI001 as a where a.cpnumi=@concepto  )
				set @deposito =(Select a.ibalm    from TI002  as a where a.ibid  =@ibid )--Almacen=Deposito 
				set @cantE = (select d.iccant    from TI0021  d where d.icibid    = @ibid  
				and d.iclot=@iclot and d.icfvenc =@icfvenc and d.iccprod =@iccprod)
			-----------------------------------------------------------------------------------

			if (exists (select TI001.iccprod from TI001 where TI001.iccprod = convert(int, @iccprod)
			and TI001 .icalm =@deposito and TI001.iclot =@iclot and TI001.icfven =@icfvenc ))
			begin 	
				begin try
					begin tran Tr_UpdateTI001
						--Obtener la cantidad actual	
						set @cantAct = (select TI001.iccven  from TI001 where TI001.iccprod  = convert(int, @iccprod) 
						and TI001 .icalm =@deposito 	
						 and TI001.iclot =@iclot and TI001.icfven =@icfvenc)
						  
						update TI001 
							set iccven = (@cantAct+((@movimiento )*(-@cantE)) )
							where TI001.iccprod  = CONVERT(int, @iccprod) and TI001 .icalm =@deposito 
							and  TI001.iclot =@iclot and TI001.icfven =@icfvenc

							delete from TI0021 where TI0021 .icibid =@ibid 
							and  TI0021 .iclot =@iclot and TI0021 .icfvenc  =@icfvenc
							and TI0021.iccprod   =@iccprod
						select @ibid as newNumi
					commit tran Tr_UpdateTI001
					print concat('Se actualizo el saldo del producto con codigo: ', @iccprod)
				end try
				begin catch
					rollback tran Tr_UpdateTI001
					print concat('No se pudo actualizo el saldo del producto con codigo: ', @iccprod)
				end catch
			end
			else
			begin
				begin try
					begin tran Tr_InsertTI001
						--Insertar Saldo Inventar
				
						set @cantAct = (select TI001.iccven  from TI001 where TI001.iccprod  = convert(int, @iccprod) 
						and TI001 .icalm =@deposito 	
						 and TI001.iclot =@loteAux  and TI001.icfven =@FechaVencAux )
						set @can = (@cantAct -@cantE)
							update TI001 
							set iccven  = @can
							where TI001.iccprod  = CONVERT(int, @iccprod) and TI001 .icalm =@deposito  
								 and TI001.iclot =@loteAux  and TI001.icfven =@FechaVencAux 
 
                         delete from TI0021 where TI0021 .icibid =@ibid 
							and  TI0021 .iclot =@iclot and TI0021 .icfvenc  =@icfvenc
							and TI0021.iccprod   =@iccprod
							select @ibid as newNumi
					commit tran Tr_InsertTI001
					print concat('Se grabo el saldo del producto con codigo: ', @iccprod)
				end try
				begin catch
					rollback tran Tr_InsertTI001
					print concat('No se grabo el saldo del producto con codigo: ', @iccprod)
				end catch
			end
		
	Fetch MiCursor into @icid,@icibid,@iccprod,@iccant,@iclot,@icfvenc
end

--Cerrar el Cursor
close MiCursor
--Liberar la memoria
deallocate MiCursor
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),1,@newFecha,@newHora,@ibuact)
		END CATCH
	END
	IF @tipo=2--MODIFICACION
	BEGIN
		BEGIN TRY 

			UPDATE TI002 SET ibfdoc =@ibfdoc,ibconcep =@ibconcep,ibobs =@ibobs
			,ibfact =@newFecha,ibhact =@newHora ,ibuact =@ibuact 
					 Where ibid = @ibid		
			select @ibid as newNumi
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),2,@newFecha,@newHora,@ibuact)
		END CATCH
	END

	IF @tipo=3 --MOSTRaR TODOS
	BEGIN
		BEGIN TRY
		
		select a.ibid ,a.ibfdoc ,a.ibconcep ,b.cpdesc as concepto,a.ibobs ,a.ibest ,a.ibalm,a.ibdepdest  ,a.ibiddc 
		,a.ibfact ,a.ibhact ,a.ibuact
		from TI002 as a inner join TCI001 as b on a.ibconcep =b.cpnumi  and b.cptipo  =1
		order by a.ibid
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END

	IF @tipo=4 --MOSTRaR Deiblle
	BEGIN
		BEGIN TRY
		
	select a.icid ,a.icibid ,a.iccprod ,b.yfcprod ,b.yfcdprod1  as producto,gr3 .ycdes3 as Presentacion,gr4.ycdes3 as Laboratorio,a.iccant ,
		a.iclot ,a.icfvenc ,Cast(null as image ) as img,1 as estado,
		(Sum(inv.iccven)  +a.iccant ) as stock
		from TI0021 as a inner join TY005 as b on a.iccprod =b.yfnumi  and b.yfap =1 and a.icibid =@ibid  
		inner join TI002 as k on k.ibid =a.icibid 
			inner join TI001 as inv on inv.iccprod =a.iccprod  and inv.icalm =k.ibalm 
			and inv .iclot =a.iclot and inv .icfven =a.icfvenc 
			inner join TY0031 as gr3 on gr3.yccod1 =1 and gr3.yccod2 =3 and gr3 .yccod3 =b.yfgr3 
		inner join TY0031 as gr4 on gr4.yccod1 =1 and gr4.yccod2 =4 and gr4.yccod3 =b.yfgr4
		group by a.icid ,a.icibid ,a.iccprod ,b.yfcdprod1  ,a.iccant ,
		a.iclot ,a.icfvenc,gr3.ycdes3 ,gr4.ycdes3 ,b.yfcprod 
			order by a.icid  asc
	
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END

	IF @tipo=5 --MOSTRaR Productos Para el movimiento
	BEGIN
		BEGIN TRY
		select a.yfnumi  ,a.yfcprod ,a.yfcdprod1  ,a.yfcdprod2,gr3 .ycdes3 as Presentacion,gr4 .ycdes3 as Laboratorio ,Sum(b.iccven ) as stock 
		from TY005  as a ,TI001 as b,TY0031 as gr3,TY0031 as gr4 where a.yfnumi not in 
		(select b.iccprod  from @TI0021 as b where  b.estado >=0)
	 and a.yfnumi =b.iccprod and b.icalm =@almacen
	 and gr3.yccod1 =1 and gr3.yccod2 =3 and gr3 .yccod3 =a.yfgr3 
		and gr4.yccod1 =1 and gr4.yccod2 =4 and gr4.yccod3 =a.yfgr4
		 
	 group by a.yfnumi ,a.yfcdprod1 ,a.yfcdprod2 ,a.yfcprod ,gr3.ycdes3 ,gr4.ycdes3 
		 order by a.yfnumi   asc 

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END

	
IF @tipo=7 ----Obtener Librerias
	BEGIN
		BEGIN TRY
	select a.cpnumi ,a.cpdesc  
	from TCI001 as a where a.cptipo  =1
	order by a.cpnumi  asc
				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END	
IF @tipo=8 ----Obtener PRODUCTOS CON SU SALDO DE STOCK
	BEGIN
		BEGIN TRY
	
	select a.yfnumi ,a.yfcdprod1 as producto,a.yfcdprod2 as descripcioncorta,a.yfcprod,isnull(Sum(b.iccven),0) as stock 
	from TY005 as a inner join TI001 as b on b.iccprod =a.yfnumi 
	inner join TA002 as c on c.abnumi =b.icalm and c.abnumi =@almacen  ----@almacen=Deposito 
	group by a.yfnumi ,a.yfcdprod1 ,a.yfcdprod2 ,a.yfcprod 
				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END	

IF @tipo=9 ----Obtener PRODUCTOS CON SU SALDO DE STOCK
	BEGIN
		BEGIN TRY				  


SELECT        IIF(c.cptipo=2,
						 (select r.canumi
						 from TC001 as r where r.canumi=Cast(substring(a.ibobs, 0, charindex('-',a.ibobs)) as integer
						  ))
						  ,    IIF(salida.cptipo=3,
						 (select w.tanumi
						 from TV001 as w where w.tanumi=Cast(substring(a.ibobs, 0,charindex('-',a.ibobs)) as integer
						  ))
						  ,a.ibid)) AS id,
						 IIF(c.cptipo=2,
						 (select Concat('ALM',alm.aanumi) as aabdes
						 from TC001 as r inner join TA001 as alm on r.canumi=Cast(substring(a.ibobs, 0, charindex('-',a.ibobs)) as integer
						  )and r.caalm =alm.aanumi)
						  ,    IIF(salida.cptipo=3,
						 (select Concat('ALM',alma.aanumi) as aabdes
						 from TV001 as w inner join TA001 as alma on w.tanumi=Cast(substring(a.ibobs, 0, charindex('-',a.ibobs)) as integer
						  )and w.taalm =alma.aanumi)
						  ,Concat('DEP',dep.abnumi))) as almacen
						  
						  , a.ibfdoc AS fdoc, IIF(c.cpmov = 1, 1, 2) AS concep,Isnull(c.cpdesc,salida.cpdesc)  AS descConcep,
						  IIF(c.cptipo =1, a.ibobs,IIF(c.cptipo=2 or salida.cptipo=3,
						  substring(a.ibobs, charindex('|',a.ibobs) + 1, LEN(a.ibobs)),a.ibobs))
						   AS obs
						   ,b.iclot as Lote,b.icfvenc as FechaVenc,
						   a.ibest AS est, a.ibalm AS alm, b.icid AS id2, b.iccprod AS cprod, 
						  d.yfcdprod1  AS descProd, medida .ycdes3   AS desc2Prod, 
                         Cast((b.iccant *c.cpmov )AS decimal(18, 2)) AS entrada,
						 Cast((b.iccant *salida.cpmov )AS decimal(18, 2)) AS salida
						 , 0.0 AS saldo, '' AS nombreCliente, FORMAT(a.ibfdoc, 'yyyy-MM-dd') AS fechaR
FROM            dbo.TI002 AS a INNER JOIN
                         dbo.TI0021 AS b ON a.ibid = b.icibid Left JOIN
                         dbo.TCI001 AS c ON c.cpnumi = a.ibconcep and c.cpmov =1 INNER JOIN
                         dbo.TY005  AS d ON d .yfnumi  = b.iccprod and d.yfnumi =@producto   ----Codigo Producto
						 inner join TY0031 as medida on medida .yccod1 =1 and medida .yccod2 =5
						 and medida .yccod3 =d.yfMed 
						  and a.ibfdoc >=@fechaI  and a.ibfdoc <=@fechaF 
						  and a.ibalm=@almacen 
						  Left join dbo.TCI001 as salida on salida.cpnumi = a.ibconcep and salida .cpmov =-1
						  left Join TA002 as dep on dep.abnumi =a.ibalm 

	order by a.ibid 
				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END	
IF @tipo=20 ----Obtener PRODUCTOS CON SU SALDO DE STOCK desde los principios hasta la fecha inicial SIN LOTE
	BEGIN
		BEGIN TRY




SELECT        a.ibid AS id, a.ibfdoc AS fdoc, IIF(c.cpmov = 1, 1, 2) AS concep,Isnull(c.cpdesc,salida.cpdesc)  AS descConcep,
						  IIF(c.cptipo =1, a.ibobs,IIF(c.cptipo=2 or salida.cptipo=3,
						  substring(a.ibobs, charindex('|',a.ibobs) + 1, LEN(a.ibobs)),a.ibobs))
						   AS obs, a.ibest AS est, a.ibalm AS alm, b.icid AS id2, b.iccprod AS cprod, 
						  d.yfcdprod1  AS descProd, medida .ycdes3   AS desc2Prod, 
                         Isnull(Cast((b.iccant *c.cpmov )AS decimal(18, 2)),0) AS entrada,
						 Isnull(Cast((b.iccant *salida.cpmov )AS decimal(18, 2)),0) AS salida
						 , 0.0 AS saldo, '' AS nombreCliente, FORMAT(a.ibfdoc, 'yyyy-MM-dd') AS fechaR
FROM            dbo.TI002 AS a INNER JOIN
                         dbo.TI0021 AS b ON a.ibid = b.icibid Left JOIN
                         dbo.TCI001 AS c ON c.cpnumi = a.ibconcep and c.cpmov =1 INNER JOIN
                         dbo.TY005  AS d ON d .yfnumi  = b.iccprod and d.yfnumi =@producto   ----Codigo Producto
						 inner join TY0031 as medida on medida .yccod1 =1 and medida .yccod2 =5
						 and medida .yccod3 =d.yfMed 
						  and a.ibfdoc <@fechaI 
						  and a.ibalm=@almacen 
						  Left join dbo.TCI001 as salida on salida.cpnumi = a.ibconcep and salida .cpmov =-1

	order by a.ibid  
				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END	

IF @tipo=21 ----Actualizar El Stock de producto
	BEGIN
		BEGIN TRY
	update TI001 set TI001.iccven =@cantidad
	where TI001 .icalm =@almacen and TI001 .iccprod =@producto 

				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END	

IF @tipo=22 ----Obtener Stock de productos
	BEGIN
		BEGIN TRY
	
SELECT      deposito .abnumi ,deposito .abdesc  ,  a.yfnumi , a.yfcprod  , a.yfcdprod1 , a.yfMed
 , a.yfap , c.iccprod,Sum(c.iccven) as iccven, b.yccod3 , b.ycdes3 
FROM            dbo.TY005  AS a INNER JOIN
                         dbo.TI001 AS c ON a.yfnumi  = c.iccprod INNER JOIN
                         dbo.TY0031 AS b ON a.yfMed  = b.yccod3 
						 inner join TA002 as deposito on deposito .abnumi =c.icalm 
WHERE        (b.yccod1  = 1) AND (b.yccod2  = 5)

group by deposito .abnumi ,deposito .abdesc  ,  a.yfnumi , a.yfcprod  , a.yfcdprod1 , a.yfMed
 , a.yfap , c.iccprod ,b.yccod3 , b.ycdes3 
order by deposito .abnumi asc
				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END	

IF @tipo=23 ----Obtener PRODUCTOS CON SU SALDO DE STOCK
	BEGIN
		BEGIN TRY
	

	select a.yfnumi ,a.yfcdprod1 as producto,a.yfcdprod2 as descripcioncorta,a.yfcprod,Sum(b.iccven) as stock 
	from TY005 as a inner join TI001 as b on b.iccprod =a.yfnumi and b.icalm =@almacen 
	inner join TA002 as c on c.abnumi =@almacen	and a.yfnumi =@producto 
		group by a.yfnumi ,a.yfcdprod1 ,a.yfcdprod2 ,a.yfcprod
		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END	

	IF @tipo=24 --MOSTRaR Sucursales
	BEGIN
		BEGIN TRY
	select a.abnumi  as aanumi,a.abdesc   as aabdes 
	from TA002 as a
	order by a.abnumi  asc
				END TRY
		BEGIN CATCH
			INSERT INTO TB001(banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END

IF @tipo=25 --Kardex de productos por numi
	BEGIN
		BEGIN TRY
	
SELECT d .yfnumi, d .yfcdprod1, d.yfcprod, Umin.ycdes3, IIF(c.cptipo = 2,
                      (SELECT r.canumi
                       FROM      TC001 AS r
                       WHERE   r.canumi = Cast(substring(a.ibobs, 0, charindex('-', a.ibobs)) AS integer)), IIF(salida.cptipo = 3,
                      (SELECT w.tanumi
                       FROM      TV001 AS w
                       WHERE   w.tanumi = Cast(substring(a.ibobs, 0, charindex('-', a.ibobs)) AS integer)), a.ibid)) AS id,
					    IIF(c.cptipo = 2,
                      (SELECT Concat('ALM',alm.aanumi) as aabdes
                       FROM      TC001 AS r INNER JOIN
                                         TA001 AS alm ON r.canumi = 
										 Cast(substring(a.ibobs, 0, charindex('-', a.ibobs)) AS integer) AND
										  r.caalm = alm.aanumi), IIF(salida.cptipo = 3,
                      (SELECT Concat('ALM',alma.aanumi) as aabdes
                       FROM      TV001 AS w INNER JOIN
                                         TA001 AS alma ON w.tanumi = Cast(substring(a.ibobs, 0, charindex('-', a.ibobs)) AS integer)
						 AND w.taalm = alma.aanumi), Concat('DEP',dep.abnumi))) AS almacen,
						 a.ibfdoc AS fdoc, IIF(c.cpmov = 1, 1, 2) AS concep, Isnull(c.cpdesc, salida.cpdesc) 
                  AS descConcep, IIF(c.cptipo = 1, a.ibobs, IIF(c.cptipo = 2 OR
                  salida.cptipo = 3, substring(a.ibobs, charindex('|', a.ibobs) + 1, LEN(a.ibobs)), a.ibobs)) AS obs
				  ,b.iclot as Lote,FORMAT(b.icfvenc, 'yyyy-MM-dd') as Fvenc, a.ibest AS est, a.ibalm AS alm, 0 AS id2, b.iccprod AS cprod, d .yfcdprod1 AS descProd, medida.ycdes3 AS desc2Prod, 
                  Isnull(Cast((b.iccant * c.cpmov) AS decimal(18, 2)), 0) AS entrada,
				  Isnull(Cast((b.iccant * salida.cpmov) AS decimal(18, 2)), 0) AS salida, 0.0 AS saldo, 
				  '' AS nombreCliente, FORMAT(a.ibfdoc, 'yyyy-MM-dd') AS fechaR
FROM            dbo.TI002 AS a INNER JOIN
                         dbo.TI0021 AS b ON a.ibid = b.icibid LEFT JOIN
                         dbo.TCI001 AS c ON c.cpnumi = a.ibconcep AND c.cpmov = 1 INNER JOIN
                         dbo.TY005 AS d ON d .yfnumi = b.iccprod and d.yfnumi =@producto    /*----Codigo Producto*/ INNER JOIN
                         TY0031 AS medida ON medida.yccod1 = 1 AND medida.yccod2 = 5 AND medida.yccod3 = d .yfMed AND 
						 a.ibfdoc >= @fechaI AND a.ibfdoc <= @fechaF AND a.ibalm = @almacen  LEFT JOIN
                         dbo.TCI001 AS salida ON salida.cpnumi = a.ibconcep AND salida.cpmov = - 1 LEFT JOIN
                         TA002 AS dep ON dep.abnumi = a.ibalm INNER JOIN
                         TY0031 AS Umin ON Umin.yccod1 = 1 AND Umin.yccod2 = 5 AND Umin.yccod3 = d .yfMed

						 order by a.ibid 
				END TRY
		BEGIN CATCH
			INSERT INTO TB001(banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END


	IF @tipo=26 --Productos que han tenido movimiento en un rango de fecha
	BEGIN
		BEGIN TRY
	select p.yfnumi ,p.yfcdprod1, p.yfcprod, Umin.ycdes3 
	from TY005 as p
	 inner join TY0031 AS Umin ON Umin.yccod1 = 1 AND Umin.yccod2 = 5 AND Umin.yccod3 = p .yfMed
	 and p.yfnumi in(select b.iccprod
	from
	TI002 as a  
	inner join TI0021 as b 
	on b.icibid =a.ibid and  a.ibfdoc >= @fechaI  AND a.ibfdoc <= @fechaF 
	 AND a.ibalm = @almacen )
				END TRY
		BEGIN CATCH
			INSERT INTO TB001(banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END

	IF @tipo=27 --Productos que han tenido movimiento en un rango de fecha
	BEGIN
		BEGIN TRY
select p.yfnumi ,p.yfcdprod1, p.yfcprod, Presentacion.ycdes3 as Presentacion,Umin.ycdes3 as Unidad,'' as SaldoAnterior,
'' as Entradas,'' as Salidas,'' as SaldoFinal
	from TY005 as p
	 inner join TY0031 AS Umin ON Umin.yccod1 = 1 AND Umin.yccod2 = 5 AND Umin.yccod3 = p .yfMed
	 and p.yfnumi in(select b.iccprod
	from
	TI002 as a  
	inner join TI0021 as b 
	on b.icibid =a.ibid and  a.ibfdoc >= @fechaI   AND a.ibfdoc <= @fechaF  
	 AND a.ibalm = @almacen )
	 inner join TY0031 AS Presentacion ON Presentacion.yccod1 = 1 AND
	  Presentacion.yccod2 = 4 AND Presentacion.yccod3 = p .yfgr4 
	  order by p.yfcdprod1 asc
				END TRY
		BEGIN CATCH
			INSERT INTO TB001(banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END

	IF @tipo=28 --Productos que han tenido movimiento en un rango de fecha
	BEGIN
		BEGIN TRY
select a.iclot ,a.icfven  ,a.iccven 
from TI001 as a 
where a.iccprod =@producto  and a.icalm =@almacen 
and a.iccprod in(
select b.iccprod from TI0021  as b,TI002 as c where b.iclot =a.iclot and b.icfvenc =a.icfven 
and b.icibid =c.ibid and c.ibalm =a.icalm )
order by a.icfven asc
				END TRY
		BEGIN CATCH
			INSERT INTO TB001(banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END

IF @tipo=29 ----Obtener PRODUCTOS CON SU SALDO DE STOCK desde los principios hasta la fecha inicial SIN LOTE
	BEGIN
		BEGIN TRY




SELECT        a.ibid AS id, a.ibfdoc AS fdoc, IIF(c.cpmov = 1, 1, 2) AS concep,Isnull(c.cpdesc,salida.cpdesc)  AS descConcep,
						  IIF(c.cptipo =1, a.ibobs,IIF(c.cptipo=2 or salida.cptipo=3,
						  substring(a.ibobs, charindex('|',a.ibobs) + 1, LEN(a.ibobs)),a.ibobs))
						   AS obs, a.ibest AS est, a.ibalm AS alm, b.icid AS id2, b.iccprod AS cprod, 
						  d.yfcdprod1  AS descProd, medida .ycdes3   AS desc2Prod, 
                         Isnull(Cast((b.iccant *c.cpmov )AS decimal(18, 2)),0) AS entrada,
						 Isnull(Cast((b.iccant *salida.cpmov )AS decimal(18, 2)),0) AS salida
						 , 0.0 AS saldo, '' AS nombreCliente, FORMAT(a.ibfdoc, 'yyyy-MM-dd') AS fechaR
FROM            dbo.TI002 AS a INNER JOIN
                         dbo.TI0021 AS b ON a.ibid = b.icibid Left JOIN
                         dbo.TCI001 AS c ON c.cpnumi = a.ibconcep and c.cpmov =1 INNER JOIN
                         dbo.TY005  AS d ON d .yfnumi  = b.iccprod and d.yfnumi =@producto   ----Codigo Producto
						 inner join TY0031 as medida on medida .yccod1 =1 and medida .yccod2 =5
						 and medida .yccod3 =d.yfMed 
						  and a.ibfdoc <@fechaI 
						  and a.ibalm=@almacen 
						    and a.ibalm=1 and b.iclot =@lote  and b.icfvenc =@fechaVenc 
						  Left join dbo.TCI001 as salida on salida.cpnumi = a.ibconcep and salida .cpmov =-1

	order by a.ibid  
				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END	

IF @tipo=30 ----Obtener PRODUCTOS CON SU SALDO DE STOCK
	BEGIN
		BEGIN TRY				  

SELECT        IIF(c.cptipo=2,
						 (select r.canumi
						 from TC001 as r where r.canumi=Cast(substring(a.ibobs, 0, charindex('-',a.ibobs)) as integer
						  ))
						  ,    IIF(salida.cptipo=3,
						 (select w.tanumi
						 from TV001 as w where w.tanumi=Cast(substring(a.ibobs, 0,charindex('-',a.ibobs)) as integer
						  ))
						  ,a.ibid)) AS id,
						 IIF(c.cptipo=2,
						 (select Concat('ALM',alm.aanumi) as aabdes
						 from TC001 as r inner join TA001 as alm on r.canumi=Cast(substring(a.ibobs, 0, charindex('-',a.ibobs)) as integer
						  )and r.caalm =alm.aanumi)
						  ,    IIF(salida.cptipo=3,
						 (select Concat('ALM',alma.aanumi) as aabdes
						 from TV001 as w inner join TA001 as alma on w.tanumi=Cast(substring(a.ibobs, 0, charindex('-',a.ibobs)) as integer
						  )and w.taalm =alma.aanumi)
						  ,Concat('DEP',dep.abnumi))) as almacen
						  
						  , a.ibfdoc AS fdoc, IIF(c.cpmov = 1, 1, 2) AS concep,Isnull(c.cpdesc,salida.cpdesc)  AS descConcep,
						  IIF(c.cptipo =1, a.ibobs,IIF(c.cptipo=2 or salida.cptipo=3,
						  substring(a.ibobs, charindex('|',a.ibobs) + 1, LEN(a.ibobs)),a.ibobs))
						   AS obs
						   ,b.iclot as Lote,b.icfvenc as FechaVenc,
						   a.ibest AS est, a.ibalm AS alm, b.icid AS id2, b.iccprod AS cprod, 
						  d.yfcdprod1  AS descProd, medida .ycdes3   AS desc2Prod, 
                         Cast((b.iccant *c.cpmov )AS decimal(18, 2)) AS entrada,
						 Cast((b.iccant *salida.cpmov )AS decimal(18, 2)) AS salida
						 , 0.0 AS saldo, '' AS nombreCliente, FORMAT(a.ibfdoc, 'yyyy-MM-dd') AS fechaR
FROM            dbo.TI002 AS a INNER JOIN
                         dbo.TI0021 AS b ON a.ibid = b.icibid Left JOIN
                         dbo.TCI001 AS c ON c.cpnumi = a.ibconcep and c.cpmov =1 INNER JOIN
                         dbo.TY005  AS d ON d .yfnumi  = b.iccprod and d.yfnumi =@producto   ----Codigo Producto
						 inner join TY0031 as medida on medida .yccod1 =1 and medida .yccod2 =5
						 and medida .yccod3 =d.yfMed 
						  and a.ibfdoc >=@fechaI and a.ibfdoc <=@fechaF
						  and a.ibalm=@almacen and b.iclot =@lote  and b.icfvenc =@fechaVenc 
						  Left join dbo.TCI001 as salida on salida.cpnumi = a.ibconcep and salida .cpmov =-1
						  left Join TA002 as dep on dep.abnumi =a.ibalm 

	order by a.ibid  
				END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END	

	

	IF @tipo=31--MOSTRaR Productos Para el movimiento
	BEGIN
		BEGIN TRY
		select a.yfnumi  ,a.yfcprod ,a.yfcdprod1  ,a.yfcdprod2,gr3 .ycdes3 as Presentacion ,gr4 .ycdes3 as Laboratorio,Sum(b.iccven ) as stock 
		from TY005  as a ,TI001 as b ,TY0031 as gr3,TY0031 as gr4 where a.yfnumi =b.iccprod and b.icalm =@almacen 
		 and gr3.yccod1 =1 and gr3.yccod2 =3 and gr3 .yccod3 =a.yfgr3 
		and gr4.yccod1 =1 and gr4.yccod2 =4 and gr4.yccod3 =a.yfgr4
	 group by a.yfnumi ,a.yfcdprod1 ,a.yfcdprod2 ,a.yfcprod ,gr3.ycdes3 ,gr4.ycdes3 
		 order by a.yfnumi   asc 

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END
	IF @tipo=32--MOSTRaR Lotes de producto con stock
	BEGIN
		BEGIN TRY
		
select b.yfcdprod1 ,a.iclot ,a.icfven  ,Sum(a.iccven)as stock 
from TI001 as a ,TY005 as b
where a.iccprod =@producto  ----CodProducto
and a.iccven >0 and a.iccprod =b.yfnumi
and a.icalm =@almacen ---Almacen
group by  b.yfcdprod1 ,a.iclot ,a.icfven  
order by a.icfven asc

		END TRY
		BEGIN CATCH
			INSERT INTO TB001 (banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END
IF @tipo=33 --Productos que han tenido movimiento en un rango de fecha
	BEGIN
		BEGIN TRY
select distinct p.yfnumi ,p.yfcdprod1  ,Presentacion.ycdes3 as Presentacion,Umin.ycdes3 as Unidad,Cast(0 as decimal(18,2)) as SaldoAnterior,
Cast(0 as decimal(18,2)) as Entradas,Cast(0 as decimal(18,2)) as Salidas,Cast(0 as decimal(18,2)) as SaldoFinal,inv.iclot ,FORMAT(inv.icfven , 'yyyy-MM-dd')as icfven  
	from TY005 as p
	 inner join TY0031 AS Umin ON Umin.yccod1 = 1 AND Umin.yccod2 = 5 AND Umin.yccod3 = p .yfMed
	  inner join TI001 as inv on inv.iccprod =p.yfnumi 
	  and inv.iccprod in(select b.iccprod 
	  from TI0021 as b 
	 inner join TI002 as a  on a.ibid =b.icibid and  a.ibfdoc >= @fechaI    AND a.ibfdoc <= @fechaF 
	 AND a.ibalm =@almacen  and b.iccprod =inv.iccprod and b.iclot =inv.iclot and b.icfvenc =inv.icfven ) 

	 inner join TY0031 AS Presentacion ON Presentacion.yccod1 = 1 AND
	  Presentacion.yccod2 = 4 AND Presentacion.yccod3 = p .yfgr4 
	  order by p.yfnumi asc
				END TRY
		BEGIN CATCH
			INSERT INTO TB001(banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END

IF @tipo=34
	BEGIN
		BEGIN TRY
SELECT      deposito .abnumi ,deposito .abdesc  ,  a.yfnumi , a.yfcprod  , a.yfcdprod1 , a.yfMed
 , a.yfap , c.iccprod,c.iclot ,FORMAT(c.icfven, 'yyyy-MM-dd')as icfven ,c.iccven as iccven, b.yccod3 , b.ycdes3 ,Presentacion .ycdes3 as presentacion
FROM            dbo.TY005  AS a INNER JOIN
                         dbo.TI001 AS c ON a.yfnumi  = c.iccprod INNER JOIN
                         dbo.TY0031 AS b ON a.yfMed  = b.yccod3 
						 inner join TA002 as deposito on deposito .abnumi =c.icalm 
						 inner join TY0031 AS Presentacion ON Presentacion.yccod1 = 1 AND
	  Presentacion.yccod2 = 4 AND Presentacion.yccod3 = a.yfgr4 
						 and c.iccven >0
WHERE        (b.yccod1  = 1) AND (b.yccod2  = 5)

group by deposito .abnumi ,deposito .abdesc  ,  a.yfnumi , a.yfcprod  , a.yfcdprod1 , a.yfMed
 , a.yfap , c.iccprod ,b.yccod3 , b.ycdes3 ,c.iclot ,c.icfven ,c.iccven ,Presentacion .ycdes3
order by deposito .abnumi asc
				END TRY
		BEGIN CATCH
			INSERT INTO TB001(banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END
	IF @tipo=35 --MOSTRaR Sucursales
	BEGIN
		BEGIN TRY
SELECT       a.yfnumi  , a.yfcdprod1 ,Sum(c.iccven) as iccven
FROM            dbo.TY005  AS a INNER JOIN
                         dbo.TI001 AS c ON a.yfnumi  = c.iccprod 

group by   a.yfnumi , a.yfcprod  , a.yfcdprod1 , a.yfMed
 , a.yfap , c.iccprod 
 order by yfcdprod1 asc
				END TRY
		BEGIN CATCH
			INSERT INTO TB001(banum,baproc,balinea,bamensaje,batipo,bafact,bahact,bauact)
				   VALUES(ERROR_NUMBER(),ERROR_PROCEDURE(),ERROR_LINE(),ERROR_MESSAGE(),3,@newFecha,@newHora,@ibuact)
		END CATCH

END
End




