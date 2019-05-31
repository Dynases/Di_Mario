USE [DBDinoM_Mario]
GO

EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vr_NotaDeEntrega'

GO

EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vr_NotaDeEntrega'

GO

/****** Object:  View [dbo].[Vr_NotaDeEntrega]    Script Date: 31/05/2019 5:36:46 ******/
DROP VIEW [dbo].[Vr_NotaDeEntrega]
GO

/****** Object:  View [dbo].[Vr_NotaDeEntrega]    Script Date: 31/05/2019 5:36:46 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Vr_NotaDeEntrega]
AS
select concat(venta.tanumi,'-',SubString(cast(year(getdate()) as nvarchar(4)),3,4)) as tanumi, venta.tafdoc AS FechaVenta, concat (cliente.ydalmacen  ,'-',cliente.ydcod) AS numicliente,IIF(venta.tatven =1,'CONTADO','CREDITO') as TipoVenta, cliente.yddesc AS cliente, cliente.yddirec, cliente.yddctnum AS ci, '78140596' AS telefono, vendedor.ydcod AS numivendedor, vendedor.yddesc AS vendedor, 
                  almacen.aanumi AS numialmacen, almacen.aabdes AS almacen, FORMAT(venta.tafvcr, 'dd-MM-yyyy') AS FechaCredito, detalle.tbcmin AS cantidad, detalle.tbty5prod AS codProducto, producto.yfcdprod1 AS producto, gr2.ycdes3 AS Presentacion, 
                  gr3.ycdes3 AS pa, detalle.tbpbas AS unitario, detalle.tbptot AS subtotal,
				 cast(((venta.tadesc*100)/( venta.tatotal + venta.tadesc)) as decimal(18,2))    AS porcentajeDescuento,
				 venta.tadesc as Descuento,
				  venta.tatotal + venta.tadesc AS TotalSub, venta.tatotal AS Total, 
				   detalle.tblote AS lote, detalle.tbfechaVenc AS FechaVenc, 
				  FORMAT(venta.tafvcr, 'dd-MM-yyyy') as tafvcr, uni.ycdes3 AS Unidad,Day(Getdate()) as dia, MONTH (Getdate()) as mes, YEAR (GETDATE ())as ano,'' as mensaje,venta .tatven as tipo
from TV001 as venta inner join TV0011 as detalle on venta.tanumi=detalle .tbtv1numi 
inner join TY004 as cliente on venta.taclpr =cliente.ydnumi 
inner join TA001 as almacen on almacen .aanumi =venta .taalm 
inner join TY004 as vendedor on vendedor .ydnumi =venta.taven
inner join TY005 as producto on producto .yfnumi =detalle .tbty5prod  
inner join TY0031 as gr2 on gr2.yccod1 =1 and gr2 .yccod2 =4 and gr2.yccod3 =producto .yfgr4
inner join TY0031 as gr3 on gr3.yccod1 =1 and gr3.yccod2 =5 and gr3 .yccod3 =producto .yfMed 
inner join TY0031 as uni on uni.yccod1 =1 and uni.yccod2 =6 and uni .yccod3 =producto .yfumin 
where venta.tanumi =53 

GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane1', @value=N'[0E232FF0-B466-11cf-A24F-00AA00A3EFFF, 1.00]
Begin DesignProperties = 
   Begin PaneConfigurations = 
      Begin PaneConfiguration = 0
         NumPanes = 4
         Configuration = "(H (1[40] 4[20] 2[20] 3) )"
      End
      Begin PaneConfiguration = 1
         NumPanes = 3
         Configuration = "(H (1 [50] 4 [25] 3))"
      End
      Begin PaneConfiguration = 2
         NumPanes = 3
         Configuration = "(H (1 [50] 2 [25] 3))"
      End
      Begin PaneConfiguration = 3
         NumPanes = 3
         Configuration = "(H (4 [30] 2 [40] 3))"
      End
      Begin PaneConfiguration = 4
         NumPanes = 2
         Configuration = "(H (1 [56] 3))"
      End
      Begin PaneConfiguration = 5
         NumPanes = 2
         Configuration = "(H (2 [66] 3))"
      End
      Begin PaneConfiguration = 6
         NumPanes = 2
         Configuration = "(H (4 [50] 3))"
      End
      Begin PaneConfiguration = 7
         NumPanes = 1
         Configuration = "(V (3))"
      End
      Begin PaneConfiguration = 8
         NumPanes = 3
         Configuration = "(H (1[56] 4[18] 2) )"
      End
      Begin PaneConfiguration = 9
         NumPanes = 2
         Configuration = "(H (1 [75] 4))"
      End
      Begin PaneConfiguration = 10
         NumPanes = 2
         Configuration = "(H (1[66] 2) )"
      End
      Begin PaneConfiguration = 11
         NumPanes = 2
         Configuration = "(H (4 [60] 2))"
      End
      Begin PaneConfiguration = 12
         NumPanes = 1
         Configuration = "(H (1) )"
      End
      Begin PaneConfiguration = 13
         NumPanes = 1
         Configuration = "(V (4))"
      End
      Begin PaneConfiguration = 14
         NumPanes = 1
         Configuration = "(V (2))"
      End
      ActivePaneConfig = 0
   End
   Begin DiagramPane = 
      Begin Origin = 
         Top = 0
         Left = 0
      End
      Begin Tables = 
      End
   End
   Begin SQLPane = 
   End
   Begin DataPane = 
      Begin ParameterDefaults = ""
      End
      Begin ColumnWidths = 31
         Width = 284
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1500
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
         Width = 1200
      End
   End
   Begin CriteriaPane = 
      Begin ColumnWidths = 11
         Column = 1440
         Alias = 900
         Table = 1176
         Output = 720
         Append = 1400
         NewValue = 1170
         SortType = 1356
         SortOrder = 1416
         GroupBy = 1350
         Filter = 1356
         Or = 1350
         Or = 1350
         Or = 1350
      End
   End
End
' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vr_NotaDeEntrega'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=1 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vr_NotaDeEntrega'
GO


