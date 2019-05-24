USE [DBDinoM_Mario]
GO

EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPaneCount' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vr_NotaDeEntrega'

GO

EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane2' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vr_NotaDeEntrega'

GO

EXEC sys.sp_dropextendedproperty @name=N'MS_DiagramPane1' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vr_NotaDeEntrega'

GO

/****** Object:  View [dbo].[Vr_NotaDeEntrega]    Script Date: 24/05/2019 7:10:01 ******/
DROP VIEW [dbo].[Vr_NotaDeEntrega]
GO

/****** Object:  View [dbo].[Vr_NotaDeEntrega]    Script Date: 24/05/2019 7:10:01 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE VIEW [dbo].[Vr_NotaDeEntrega]
AS
SELECT venta.tanumi, venta.tafdoc AS FechaVenta,IIF(venta.tatven =1,'CONTADO','CREDITO') as TipoVenta, cliente.ydnumi AS numicliente, cliente.yddesc AS cliente, cliente.yddirec, cliente.yddctnum AS ci, '78140596' AS telefono, vendedor.ydnumi AS numivendedor, vendedor.yddesc AS vendedor, 
                  almacen.aanumi AS numialmacen, almacen.aabdes AS almacen, venta.tafvcr AS FechaCredito, detalle.tbcmin AS cantidad, detalle.tbty5prod AS codProducto, producto.yfcdprod1 AS producto, gr2.ycdes3 AS Presentacion, 
                  gr3.ycdes3 AS pa, detalle.tbpbas AS unitario, detalle.tbptot AS subtotal, venta.tadesc AS Descuento, venta.tatotal + venta.tadesc AS TotalSub, venta.tatotal AS Total, detalle.tblote AS lote, detalle.tbfechaVenc AS FechaVenc, venta.tafvcr, 
                  uni.ycdes3 AS Unidad, DAY(GETDATE()) AS dia, MONTH(GETDATE()) AS mes, YEAR(GETDATE()) AS ano, '' AS mensaje, venta.tatven AS tipo
FROM     dbo.TV001 AS venta INNER JOIN
                  dbo.TV0011 AS detalle ON venta.tanumi = detalle.tbtv1numi INNER JOIN
                  dbo.TY004 AS cliente ON venta.taclpr = cliente.ydnumi INNER JOIN
                  dbo.TA001 AS almacen ON almacen.aanumi = venta.taalm INNER JOIN
                  dbo.TY004 AS vendedor ON vendedor.ydnumi = venta.taven INNER JOIN
                  dbo.TY005 AS producto ON producto.yfnumi = detalle.tbty5prod INNER JOIN
                  dbo.TY0031 AS gr2 ON gr2.yccod1 = 1 AND gr2.yccod2 = 4 AND gr2.yccod3 = producto.yfgr4 INNER JOIN
                  dbo.TY0031 AS gr3 ON gr3.yccod1 = 1 AND gr3.yccod2 = 5 AND gr3.yccod3 = producto.yfMed INNER JOIN
                  dbo.TY0031 AS uni ON uni.yccod1 = 1 AND uni.yccod2 = 6 AND uni.yccod3 = producto.yfumin
WHERE  (venta.tanumi = 15)

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
         Begin Table = "venta"
            Begin Extent = 
               Top = 7
               Left = 48
               Bottom = 170
               Right = 292
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "detalle"
            Begin Extent = 
               Top = 7
               Left = 340
               Bottom = 170
               Right = 584
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "cliente"
            Begin Extent = 
               Top = 7
               Left = 632
               Bottom = 170
               Right = 876
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "almacen"
            Begin Extent = 
               Top = 7
               Left = 924
               Bottom = 170
               Right = 1168
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "vendedor"
            Begin Extent = 
               Top = 175
               Left = 48
               Bottom = 338
               Right = 292
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "producto"
            Begin Extent = 
               Top = 175
               Left = 340
               Bottom = 338
               Right = 584
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "gr2"
            Begin Extent = 
               Top = 175
               Left = 632
               Bottom = 338
               Right = 876
            End
            DisplayFlags = 280
     ' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vr_NotaDeEntrega'
GO

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPane2', @value=N'       TopColumn = 0
         End
         Begin Table = "gr3"
            Begin Extent = 
               Top = 175
               Left = 924
               Bottom = 338
               Right = 1168
            End
            DisplayFlags = 280
            TopColumn = 0
         End
         Begin Table = "uni"
            Begin Extent = 
               Top = 342
               Left = 38
               Bottom = 472
               Right = 247
            End
            DisplayFlags = 280
            TopColumn = 0
         End
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

EXEC sys.sp_addextendedproperty @name=N'MS_DiagramPaneCount', @value=2 , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'VIEW',@level1name=N'Vr_NotaDeEntrega'
GO


