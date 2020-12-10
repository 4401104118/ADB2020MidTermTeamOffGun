
use ADBTeamOffGunSpatialDB
go


--Cau2
--2a/
DECLARE cs_a CURSOR FOR SELECT MAMD FROM QLThueDat
OPEN cs_a
	BEGIN
    	DECLARE @MaMDa VARCHAR(3)
		FETCH cs_a INTO @MaMDa
		WHILE @@fetch_status=0 
		BEGIN  
			DECLARE @ViTRI GEOMETRY = (SELECT VITRI FROM QLThueDat WHERE MAMD = @MaMDa)
			DECLARE @DTa DECIMAL(9,0) = @ViTRI.MakeValid().STArea() * 10000
			DECLARE @LNTT DECIMAL(18,2) = (@DTa / 10000) * (SELECT MatDoNuoc FROM QLThueDat WHERE MAMD = @MaMDa)
			--PRINT @DTa --in ra diện tích để kiểm nghiệm
			PRINT N'Lượng nước cần thiết cho loại đất ' + @MaMDa + N' là: ' + CONVERT(VARCHAR,CAST(@LNTT AS MONEY)) + N'm3 nước'
			FETCH cs_a INTO @MaMDa	
        END
    END
CLOSE cs_a
DEALLOCATE cs_a
GO
--2b/
DECLARE cs_b CURSOR FOR SELECT MAMD FROM QLThueDat 
OPEN cs_b
	BEGIN
		DECLARE @MaMDb VARCHAR(3)
		FETCH cs_b INTO @MaMDb
		DECLARE @ViTRIb GEOMETRY = (SELECT VITRI FROM QLThueDat WHERE MAMD = @MaMDb)
		DECLARE @DT_MAX DECIMAL(9,0) = @ViTRIb.MakeValid().STArea() * 10000
		DECLARE @MaMD_MAX VARCHAR(3) = @MaMDb
		WHILE @@fetch_status=0 BEGIN  
			DECLARE @ViTRIb2 GEOMETRY = (SELECT VITRI FROM QLThueDat WHERE MAMD = @MaMDb)
			IF @DT_MAX < @ViTRIb2.MakeValid().STArea() BEGIN  
            	SET @DT_MAX = @ViTRIb2.MakeValid().STArea()
				SET @MaMD_MAX = @MaMDb
            END
			FETCH cs_b INTO @MaMDb	
        END
        PRINT N'Loại đất có diện tích lớn nhất là ' + @MaMD_MAX + N' với ' + CONVERT(VARCHAR,CAST(@DT_MAX AS MONEY)) + 'm2'
	END
CLOSE cs_b
DEALLOCATE cs_b
GO
--2c/
DECLARE @DienTichBiMat TABLE (id int IDENTITY (1,1), Vitri geometry) 
DECLARE @kn geometry 
SET @kn = geometry::STGeomFromText('POLYGON ((1 3, 2 -2, 3 -2, 4 -1, 3 4, 1 3))', 0);

DECLARE @m7 geometry
SET @m7 = (SELECT Vitri.MakeValid() FROM QLThueDat where MaMD = 'M7')
DECLARE @m8 geometry
SET @m8 = (SELECT Vitri.MakeValid() FROM QLThueDat where MaMD = 'M8')
DECLARE @m9 geometry
SET @m9 = (SELECT Vitri.MakeValid() FROM QLThueDat where MaMD = 'M9')

INSERT INTO @DienTichBiMat (Vitri) VALUES(
 (@kn.STIntersection(@m7))
)
INSERT INTO @DienTichBiMat (Vitri) VALUES(
 (@kn.STIntersection(@m8))
)
INSERT INTO @DienTichBiMat (Vitri) VALUES(
 (@kn.STIntersection(@m9))
)

SELECT id, Vitri.MakeValid().STArea()*100/10000 as [DienTichBiMat(ha)] FROM @DienTichBiMat


-- 2.d/
DECLARE @KenhNuoc geometry 
SET @KenhNuoc = geometry::STGeomFromText('POLYGON ((1 3, 2 -2, 3 -2, 4 -1, 3 4, 1 3))', 0);
DECLARE @m7 geometry
SET @m7 = (SELECT Vitri.MakeValid() FROM QLThueDat where MaMD = 'M7')
DECLARE @m8 geometry
SET @m8 = (SELECT Vitri.MakeValid() FROM QLThueDat where MaMD = 'M8')
DECLARE @m9 geometry
SET @m9 = (SELECT Vitri.MakeValid() FROM QLThueDat where MaMD = 'M9')

UPDATE QLThueDat
SET Vitri = @m7.STDifference(@KenhNuoc)
WHERE MaMD = 'M7'

UPDATE QLThueDat
SET Vitri = @m8.STDifference(@KenhNuoc)
WHERE MaMD = 'M8'

UPDATE QLThueDat
SET Vitri = @m9.STDifference(@KenhNuoc)
WHERE MaMD = 'M9'

SELECT * FROM QLThueDat