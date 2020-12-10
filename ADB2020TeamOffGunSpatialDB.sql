Create database ADBTeamOffGunSpatialDB
go
use ADBTeamOffGunSpatialDB
go
Create table QLThueDat(
id int IDENTITY (1,1),
MauDat nvarchar(10),
MaMD nvarchar(5),
Khuvuctrong nvarchar(50),
MatDoNuoc float,
MatDoDoanhThu float,
Vitri geometry,
)
go
--Cau1
INSERT INTO QLThueDat(MauDat, MaMD, Khuvuctrong, MatDoNuoc, MatDoDoanhThu, Vitri)VALUES(
'Xám', 'M7', 'Trồng lúa', 75000, 250.6,
geometry::STGeomFromText('POLYGON ((-2 -2, 1 -1, 1 3, -1 3, -2 2, -2 -2),(3 0, 5 -2, 7 -2, 7 3, 5 3, 6 1, 3 0))', 0)
)
GO
INSERT INTO QLThueDat(MauDat, MaMD, Khuvuctrong, MatDoNuoc, MatDoDoanhThu, Vitri)VALUES(
'Nâu', 'M8', 'Trồng cây ăn quả', 45000, 350.4,
geometry::STGeomFromText('POLYGON ((-2 -2, 1 -1, 1 0, 3 0, 3 -2, -2 -2))', 0)
)
GO
INSERT INTO QLThueDat(MauDat, MaMD, Khuvuctrong, MatDoNuoc, MatDoDoanhThu, Vitri)VALUES(
'Tím', 'M9', 'Trồng rau', 35000, 450.5,
geometry::STGeomFromText('POLYGON ((1 3, 3 4, 5 3, 5 1, 3 0, 1 0, 1 3))', 0)
)
GO
