SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO




ALTER VIEW [dbo].[V_FORMULA_DESIGN]
AS
SELECT     sm.SCALE_NAME
			, fd.CHECKED
			, rm.RM_CODE
			, fd.RM_LOT
			, fd.MAX_VALUE
			, fd.FINAL_VALUE
			, fd.MIN_VALUE
			, fd.SP1_VALUE
			, fd.SP2_VALUE
			, fd.CPS_VALUE
			, fd.HZ_H
			, fd.HZ_M
			, fd.HZ_L
			, fd.CRUSHER
			
			--Hidden
			, fd.REVISION_ID

FROM         FORMULA_MASTER fm INNER JOIN
             REVISION r ON fm.FORMULA_ID = r.FORMULA_ID INNER JOIN
             FORMULA_DETAIL fd ON r.REVISION_ID = fd.REVISION_ID INNER JOIN
             RM_MASTER rm ON fd.RM_NO = rm.RM_NO INNER JOIN
             SCALE_MASTER sm ON rm.SCALE_ID = sm.SCALE_ID






GO


