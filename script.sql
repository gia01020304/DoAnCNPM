USE [QuanLyHoaDonProject]
GO
/****** Object:  DatabaseRole [AdminBillMain]    Script Date: 11/21/2018 7:37:04 PM ******/
CREATE ROLE [AdminBillMain]
GO
/****** Object:  DatabaseRole [EmployeeOneBill]    Script Date: 11/21/2018 7:37:04 PM ******/
CREATE ROLE [EmployeeOneBill]
GO
/****** Object:  DatabaseRole [EmployeeTwoBill]    Script Date: 11/21/2018 7:37:04 PM ******/
CREATE ROLE [EmployeeTwoBill]
GO
/****** Object:  DatabaseRole [King]    Script Date: 11/21/2018 7:37:04 PM ******/
CREATE ROLE [King]
GO
/****** Object:  Table [dbo].[DangNhaps]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DangNhaps](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[TenDangNhap] [nvarchar](100) NULL,
	[PassWord] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.DangNhaps] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  UserDefinedFunction [dbo].[TestAccount]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[TestAccount](@UserName NVARCHAR(100),@PassWord NVARCHAR(255))
RETURNS table
as
RETURN(SELECT * FROM dbo.DangNhaps
	WHERE TenDangNhap=@UserName AND PassWord=@PassWord)
GO
/****** Object:  UserDefinedFunction [dbo].[getIDIdentity]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE FUNCTION [dbo].[getIDIdentity](@nameTable NVARCHAR(100))
RETURNS TABLE
AS
RETURN( SELECT IDENT_CURRENT(''+@nameTable+'') AS ID )


GO
/****** Object:  Table [dbo].[CTHoaDons]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHoaDons](
	[HoaDonBanId] [int] NOT NULL,
	[HangHoaId] [int] NOT NULL,
	[ThanhTien] [float] NOT NULL,
	[SoLuongBan] [int] NOT NULL,
 CONSTRAINT [PK_dbo.CTHoaDons] PRIMARY KEY CLUSTERED 
(
	[HoaDonBanId] ASC,
	[HangHoaId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonViBanHangs]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViBanHangs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[MaSoThueBan] [nvarchar](max) NULL,
	[DiaChi] [nvarchar](50) NULL,
	[STKBan] [nvarchar](max) NULL,
	[SDTBan] [nvarchar](max) NULL,
 CONSTRAINT [PK_dbo.DonViBanHangs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[DonViMuaHangs]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DonViMuaHangs](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NULL,
	[DiaChiMua] [nvarchar](50) NULL,
	[MaSoThueMua] [nvarchar](max) NULL,
	[STKMua] [nvarchar](20) NULL,
	[SDTMua] [nvarchar](12) NULL,
 CONSTRAINT [PK_dbo.DonViMuaHangs] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HangHoas]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HangHoas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[DVT] [nvarchar](50) NULL,
	[SoLuong] [int] NOT NULL,
	[DonGiaNhap] [float] NOT NULL,
	[DonGiaBan] [float] NOT NULL,
	[GhiChu] [nvarchar](250) NULL,
	[DaXoa] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.HangHoas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HinhThucThanhToans]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HinhThucThanhToans](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[DaXoa] [bit] NOT NULL,
 CONSTRAINT [PK_dbo.HinhThucThanhToans] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[HoaDonBans]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HoaDonBans](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[ThueSuat] [float] NOT NULL,
	[KyHieu] [nvarchar](50) NULL,
	[NgayHD] [datetime] NOT NULL,
	[HinhThucThanhToanId] [int] NOT NULL,
	[NguoiMuaId] [int] NOT NULL,
	[NhanVienBanId] [int] NOT NULL,
	[DaXoa] [bit] NOT NULL,
	[TongTienSo] [nvarchar](100) NULL,
	[TongTienChu] [nvarchar](250) NULL,
 CONSTRAINT [PK_dbo.HoaDonBans] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NguoiMuas]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NguoiMuas](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[DonViMuaHangId] [int] NOT NULL,
	[DaXoa] [bit] NOT NULL,
	[CMND] [nvarchar](12) NULL,
 CONSTRAINT [PK_dbo.NguoiMuas] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[NhanVienBans]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVienBans](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](100) NULL,
	[GioiTinh] [nvarchar](20) NULL,
	[SDT] [nvarchar](max) NULL,
	[DOB] [datetime] NOT NULL,
	[TTLamViec] [nvarchar](100) NULL,
	[HinhAnh] [nvarchar](255) NULL,
	[DiaChi] [nvarchar](255) NULL,
	[CMND] [nvarchar](100) NULL,
	[NgayCap] [datetime] NULL,
	[NoiCap] [nvarchar](100) NULL,
	[DaXoa] [bit] NOT NULL,
	[HonNhan] [bit] NULL,
	[AccountID] [int] NULL,
 CONSTRAINT [PK_dbo.NhanVienBans] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[PerDetail]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PerDetail](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[PermisionId] [int] NOT NULL,
	[ActionCode] [nvarchar](50) NOT NULL,
	[CheckAction] [bit] NOT NULL,
 CONSTRAINT [PK_PerDetail] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Permision]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permision](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nchar](20) NOT NULL,
 CONSTRAINT [PK_Permision] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserPer]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserPer](
	[UserId] [int] NOT NULL,
	[PermisionId] [int] NOT NULL,
	[Licensed] [bit] NOT NULL,
 CONSTRAINT [PK_UserPer] PRIMARY KEY CLUSTERED 
(
	[UserId] ASC,
	[PermisionId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[CTHoaDons]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CTHoaDons_dbo.HangHoas_HangHoaId] FOREIGN KEY([HangHoaId])
REFERENCES [dbo].[HangHoas] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTHoaDons] CHECK CONSTRAINT [FK_dbo.CTHoaDons_dbo.HangHoas_HangHoaId]
GO
ALTER TABLE [dbo].[CTHoaDons]  WITH CHECK ADD  CONSTRAINT [FK_dbo.CTHoaDons_dbo.HoaDonBans_HoaDonBanId] FOREIGN KEY([HoaDonBanId])
REFERENCES [dbo].[HoaDonBans] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[CTHoaDons] CHECK CONSTRAINT [FK_dbo.CTHoaDons_dbo.HoaDonBans_HoaDonBanId]
GO
ALTER TABLE [dbo].[HoaDonBans]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HoaDonBans_dbo.HinhThucThanhToans_HinhThucThanhToanId] FOREIGN KEY([HinhThucThanhToanId])
REFERENCES [dbo].[HinhThucThanhToans] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDonBans] CHECK CONSTRAINT [FK_dbo.HoaDonBans_dbo.HinhThucThanhToans_HinhThucThanhToanId]
GO
ALTER TABLE [dbo].[HoaDonBans]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HoaDonBans_dbo.NguoiMuas_NguoiMuaId] FOREIGN KEY([NguoiMuaId])
REFERENCES [dbo].[NguoiMuas] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDonBans] CHECK CONSTRAINT [FK_dbo.HoaDonBans_dbo.NguoiMuas_NguoiMuaId]
GO
ALTER TABLE [dbo].[HoaDonBans]  WITH CHECK ADD  CONSTRAINT [FK_dbo.HoaDonBans_dbo.NhanVienBans_NhanVienBanId] FOREIGN KEY([NhanVienBanId])
REFERENCES [dbo].[NhanVienBans] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[HoaDonBans] CHECK CONSTRAINT [FK_dbo.HoaDonBans_dbo.NhanVienBans_NhanVienBanId]
GO
ALTER TABLE [dbo].[NguoiMuas]  WITH CHECK ADD  CONSTRAINT [FK_dbo.NguoiMuas_dbo.DonViMuaHangs_DonViMuaHangId] FOREIGN KEY([DonViMuaHangId])
REFERENCES [dbo].[DonViMuaHangs] ([ID])
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[NguoiMuas] CHECK CONSTRAINT [FK_dbo.NguoiMuas_dbo.DonViMuaHangs_DonViMuaHangId]
GO
ALTER TABLE [dbo].[NhanVienBans]  WITH CHECK ADD  CONSTRAINT [FK_NhanVienBans_DangNhaps] FOREIGN KEY([AccountID])
REFERENCES [dbo].[DangNhaps] ([ID])
GO
ALTER TABLE [dbo].[NhanVienBans] CHECK CONSTRAINT [FK_NhanVienBans_DangNhaps]
GO
ALTER TABLE [dbo].[PerDetail]  WITH CHECK ADD  CONSTRAINT [FK_PerDetail_Permision] FOREIGN KEY([PermisionId])
REFERENCES [dbo].[Permision] ([ID])
GO
ALTER TABLE [dbo].[PerDetail] CHECK CONSTRAINT [FK_PerDetail_Permision]
GO
ALTER TABLE [dbo].[UserPer]  WITH CHECK ADD  CONSTRAINT [FK_UserPer_DangNhaps] FOREIGN KEY([UserId])
REFERENCES [dbo].[DangNhaps] ([ID])
GO
ALTER TABLE [dbo].[UserPer] CHECK CONSTRAINT [FK_UserPer_DangNhaps]
GO
ALTER TABLE [dbo].[UserPer]  WITH CHECK ADD  CONSTRAINT [FK_UserPer_Permision] FOREIGN KEY([PermisionId])
REFERENCES [dbo].[Permision] ([ID])
GO
ALTER TABLE [dbo].[UserPer] CHECK CONSTRAINT [FK_UserPer_Permision]
GO
/****** Object:  StoredProcedure [dbo].[usp_AddDonViBanHang]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROC [dbo].[usp_AddDonViBanHang] @Name NVARCHAR(100),@DiaChiBan NVARCHAR(50),@MaSoThueBan NVARCHAR(MAX),
@STKBan NVARCHAR(20),@SDTBan NVARCHAR(12)
AS
BEGIN
INSERT INTO dbo.DonViBanHangs
        ( Name ,
          MaSoThueBan ,
          DiaChi ,
          STKBan ,
          SDTBan
        )
VALUES  ( @Name , -- Name - nvarchar(50)
          @DiaChiBan , -- MaSoThueBan - nvarchar(max)
          @MaSoThueBan , -- DiaChi - nvarchar(50)
          @STKBan , -- STKBan - nvarchar(max)
          @SDTBan  -- SDTBan - nvarchar(max)
        )
        
END







GO
/****** Object:  StoredProcedure [dbo].[usp_AddDonViMuaHang]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[usp_AddDonViMuaHang] @Name NVARCHAR(100),@DiaChiMua NVARCHAR(50),@MaSoThueMua NVARCHAR(MAX),
@STKMua NVARCHAR(20),@SDTMua NVARCHAR(12)
AS
BEGIN
INSERT INTO dbo.DonViMuaHangs
        ( Name ,
          DiaChiMua ,
          MaSoThueMua ,
          STKMua ,
          SDTMua
        )
VALUES  ( @Name , -- Name - nvarchar(50)
          @DiaChiMua , -- DiaChiMua - nvarchar(50)
          @MaSoThueMua , -- MaSoThueMua - nvarchar(max)
          @STKMua , -- STKMua - nvarchar(20)
          @SDTMua  -- SDTMua - nvarchar(12)
        )
        
END





GO
/****** Object:  StoredProcedure [dbo].[usp_AddHinhThucThanhToan]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[usp_AddHinhThucThanhToan] @Name NVARCHAR(100)
AS
BEGIN
INSERT INTO dbo.HinhThucThanhToans
        ( Name, DaXoa )
VALUES  ( @Name, -- Name - nvarchar(100)
          0  -- DaXoa - bit
          )
END






GO
/****** Object:  StoredProcedure [dbo].[usp_AddNguoiMua]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[usp_AddNguoiMua] @Name NVARCHAR(100),@DonViMuaHangId INT,@CMND VARCHAR(12)
AS
BEGIN
INSERT INTO dbo.NguoiMuas
        ( Name, DonViMuaHangId, DaXoa, CMND )
VALUES  ( @Name, -- Name - nvarchar(100)
          @DonViMuaHangId, -- DonViMuaHangId - int
          0, -- DaXoa - bit
          @CMND  -- CMND - nvarchar(12)
          )
END





GO
/****** Object:  StoredProcedure [dbo].[usp_AddNhanVien]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_AddNhanVien]
    @Name NVARCHAR(100) ,
    @GioiTinh NVARCHAR(20) ,
    @SDT NVARCHAR(MAX) ,
    @DOB DATETIME ,
    @TTLamViec NVARCHAR(100) ,
    @HinhAnh NVARCHAR(255) ,
    @DiaChi NVARCHAR(100) ,
    @CMND NVARCHAR(100) ,
    @NgayCap DATETIME ,
    @NoiCap NVARCHAR(100) ,
    @HonNhan BIT ,
    @UserName NVARCHAR(50) ,
    @PassWord NVARCHAR(50) ,
    @RoleID INT
AS
    BEGIN
-- insert account
        INSERT  INTO dbo.DangNhaps
                ( TenDangNhap, PassWord )
        VALUES  ( @UserName, -- TenDangNhap - nvarchar(100)
                  @PassWord  -- PassWord - nvarchar(max)
                  );
        DECLARE @UserId INT;
        SELECT  @UserId = ID
        FROM    dbo.DangNhaps
        WHERE   TenDangNhap = @UserName;

        INSERT  dbo.UserPer
                ( UserId, PermisionId, Licensed )
        VALUES  ( @UserId, -- UserId - int
                  @RoleID, -- PermisionId - int
                  1  -- Licensed - bit
                  );

        INSERT  INTO dbo.NhanVienBans
                ( [Name] ,
                  GioiTinh ,
                  SDT ,
                  DOB ,
                  TTLamViec ,
                  HinhAnh ,
                  DiaChi ,
                  CMND ,
                  NgayCap ,
                  NoiCap ,
                  DaXoa ,
                  HonNhan,
				  AccountID
                )
        VALUES  ( @Name , -- Name - nvarchar(100)
                  @GioiTinh , -- GioiTinh - nvarchar(20)
                  @SDT , -- SDT - nvarchar(max)
                  @DOB , -- DOB - datetime
                  @TTLamViec , -- TTLamViec - nvarchar(100)
                  @HinhAnh , -- HinhAnh - nvarchar(255)
                  @DiaChi , -- DiaChi - nvarchar(255)
                  @CMND , -- CMND - nvarchar(100)
                  @NgayCap , -- NgayCap - datetime
                  @NoiCap , -- NoiCap - nvarchar(100)
                  0 , -- DaXoa - bit
                  @HonNhan,  -- HonNhan - bit
				  @UserId
                );
    END;



GO
/****** Object:  StoredProcedure [dbo].[usp_AddProduct]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[usp_AddProduct] @Name NVARCHAR(100),@DVT NVARCHAR(50),@Soluong INT,
@DonGiaNhap FLOAT,@DonGiaBan FLOAT,@GhiChu NVARCHAR(250)
AS
BEGIN
INSERT INTO dbo.HangHoas
        ( Name ,
          DVT ,
          SoLuong ,
          DonGiaNhap ,
          DonGiaBan ,
          GhiChu ,
          DaXoa
        )
VALUES  ( @Name , -- Name - nvarchar(100)
          @DVT , -- DVT - nvarchar(50)
          @Soluong , -- SoLuong - int
          @DonGiaNhap , -- DonGiaNhap - float
          @DonGiaBan , -- DonGiaBan - float
          @GhiChu , -- GhiChu - nvarchar(250)
          0  -- DaXoa - bit
        )
END




GO
/****** Object:  StoredProcedure [dbo].[usp_checkCMND]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_checkCMND]
@cmnd NVARCHAR(12)
AS
BEGIN
    SELECT * 
	FROM dbo.NguoiMuas
	WHERE dbo.NguoiMuas.CMND=@cmnd
END


GO
/****** Object:  StoredProcedure [dbo].[usp_checkHangHoaKho]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_checkHangHoaKho]
@iD int
AS
BEGIN
	SELECT * FROM HangHoas
	WHERE HangHoas.ID=@iD    
END


GO
/****** Object:  StoredProcedure [dbo].[usp_CheckLogin]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_CheckLogin] @UserName NVARCHAR(50),@Password NVARCHAR(50)
AS
BEGIN
SELECT COUNT(*) FROM dbo.DangNhaps WHERE TenDangNhap = @UserName AND PassWord = @Password
END


GO
/****** Object:  StoredProcedure [dbo].[usp_CheckPermission]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_CheckPermission]
@UserName NVARCHAR(100)
AS
BEGIN
    SELECT PermisionId FROM
	dbo.UserPer,dbo.DangNhaps
	WHERE dbo.DangNhaps.TenDangNhap=@UserName
	AND dbo.UserPer.UserId=dbo.DangNhaps.ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_CountHTTT]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_CountHTTT]
AS
BEGIN
    SELECT * FROM dbo.HinhThucThanhToans
END
GO
/****** Object:  StoredProcedure [dbo].[usp_deleteCtHoaDon]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_deleteCtHoaDon]
@idhoadon int
AS
BEGIN
	BEGIN try
		BEGIN TRANSACTION
		  DELETE dbo.CTHoaDons 
			WHERE dbo.CTHoaDons.HoaDonBanId=@idhoadon    
		COMMIT
	END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END




GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteDonViMuaHang]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROC [dbo].[usp_DeleteDonViMuaHang] @ID INT
AS
BEGIN
	BEGIN try
		BEGIN TRANSACTION
		 DELETE FROM dbo.DonViMuaHangs 
			WHERE ID =@ID     
		COMMIT
	END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END








GO
/****** Object:  StoredProcedure [dbo].[usp_deleteHoaDon]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_deleteHoaDon]
@idhoadon int
AS
BEGIN
	BEGIN try
		BEGIN TRANSACTION
		 DELETE dbo.HoaDonBans 
	WHERE dbo.HoaDonBans.ID=@idhoadon
		COMMIT
	END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END



GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteNhanVien]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_DeleteNhanVien] @ID INT
AS
BEGIN
	BEGIN try
		BEGIN TRANSACTION
		UPDATE dbo.NhanVienBans SET
			DaXoa = 1
		WHERE ID = @ID
		COMMIT
	END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END



GO
/****** Object:  StoredProcedure [dbo].[usp_DeleteProduct]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[usp_DeleteProduct] @ID INT
AS
BEGIN
	BEGIN try
		BEGIN TRANSACTION
		UPDATE dbo.HangHoas
		SET 
		DaXoa = 1
		WHERE ID = @ID
		COMMIT
	END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END





GO
/****** Object:  StoredProcedure [dbo].[usp_FindDVMByName]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[usp_FindDVMByName] @Name NVARCHAR(100)
AS
BEGIN
SELECT * FROM dbo.DonViMuaHangs WHERE Name LIKE '%' + @Name + '%'
END






GO
/****** Object:  StoredProcedure [dbo].[usp_FindHangHoaByName]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[usp_FindHangHoaByName] @Name NVARCHAR(100)
AS
BEGIN
SELECT * FROM dbo.HangHoas WHERE DaXoa = 0 AND Name LIKE '%' + @Name + '%'
END





GO
/****** Object:  StoredProcedure [dbo].[usp_findHoaDon]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_findHoaDon]
@id INT
AS
BEGIN
    SELECT *
	FROM dbo.HoaDonBans
	WHERE dbo.HoaDonBans.ID=@id
END


GO
/****** Object:  StoredProcedure [dbo].[usp_FindNhanVienByName]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[usp_FindNhanVienByName] @Name NVARCHAR(100)
AS
BEGIN
SELECT * FROM dbo.NhanVienBans WHERE DaXoa = 0 AND Name LIKE '%' + @Name + '%'
END




GO
/****** Object:  StoredProcedure [dbo].[usp_GetActionByUserName]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[usp_GetActionByUserName] @UserName NVARCHAR(50)
AS
BEGIN
SELECT * FROM dbo.DangNhaps INNER JOIN dbo.UserPer 
ON dbo.DangNhaps.ID = dbo.UserPer.UserId INNER JOIN dbo.Permision ON PermisionId = dbo.Permision.ID INNER JOIN dbo.PerDetail
ON PerDetail.PermisionId = Permision.ID
WHERE TenDangNhap = @UserName
END



GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllDonViMuaHangs]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[usp_GetAllDonViMuaHangs]
AS
BEGIN
SELECT * FROM dbo.DonViMuaHangs
END




GO
/****** Object:  StoredProcedure [dbo].[usp_getAllHangHoa]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_getAllHangHoa]
AS
BEGIN
    SELECT * 
	FROM dbo.HangHoas
	WHERE DaXoa=0
END


GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllHinhThucThanhToans]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[usp_GetAllHinhThucThanhToans]
AS
BEGIN
SELECT * FROM dbo.HinhThucThanhToans WHERE DaXoa = 0
END





GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllHoaDonBans]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_GetAllHoaDonBans]
AS
BEGIN
   SELECT * FROM dbo.HoaDonBans
END


GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllNhanVien]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_GetAllNhanVien]
AS
    BEGIN
        SELECT  NhanVienBans.* ,
                dbo.DangNhaps.TenDangNhap AS UserName ,
                [PassWord],
				dbo.Permision.ID AS RoleID
        FROM    dbo.NhanVienBans
                INNER JOIN dbo.DangNhaps ON DangNhaps.ID = NhanVienBans.AccountID
				INNER JOIN dbo.UserPer ON dbo.DangNhaps.ID  = dbo.UserPer.UserId
				INNER JOIN dbo.Permision ON dbo.UserPer.PermisionId = dbo.Permision.ID
        WHERE   DaXoa = 0;
    END;



GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllNhanVienGia]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_GetAllNhanVienGia]
@UserName NVARCHAR(100)
AS
BEGIN
    SELECT *FROM dbo.NhanVienBans,dbo.DangNhaps
	WHERE TenDangNhap=@UserName AND dbo.DangNhaps.ID=dbo.NhanVienBans.AccountID
    
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetAllProducts]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[usp_GetAllProducts]
AS
BEGIN
SELECT * FROM dbo.HangHoas WHERE DaXoa = 0
END




GO
/****** Object:  StoredProcedure [dbo].[usp_GetByDate]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_GetByDate]
@dateFrom DATE,
@dateTo DATE
AS
BEGIN
    SELECT dbo.HoaDonBans.ID,dbo.HoaDonBans.KyHieu,NguoiMuas.DonViMuaHangId AS MaKhachHang,
			DonViMuaHangs.Name AS TenDonViMua,dbo.DonViMuaHangs.MaSoThueMua AS MaSoThue,
			dbo.NguoiMuas.Name AS TenNguoiMua,dbo.DonViMuaHangs.DiaChiMua AS DiaChi,
			DonViMuaHangs.STKMua AS STK,dbo.HoaDonBans.NgayHD AS NgayXuat, 
			dbo.HinhThucThanhToans.Name AS HinhThuc,dbo.HoaDonBans.TongTienSo AS ThanhTien


	FROM dbo.HoaDonBans,dbo.NguoiMuas,dbo.DonViMuaHangs,HinhThucThanhToans
	WHERE dbo.HoaDonBans.NgayHD>=@dateFrom AND NgayHD<=@dateTo
		AND dbo.HoaDonBans.NguoiMuaId=dbo.NguoiMuas.ID
		AND dbo.NguoiMuas.DonViMuaHangId=dbo.DonViMuaHangs.ID
		AND dbo.HoaDonBans.HinhThucThanhToanId=dbo.HinhThucThanhToans.ID


END


GO
/****** Object:  StoredProcedure [dbo].[usp_GetDonViBanHang]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[usp_GetDonViBanHang]
AS
BEGIN
SELECT * FROM dbo.DonViBanHangs
END





GO
/****** Object:  StoredProcedure [dbo].[usp_getDonViMuaHangReport2]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_getDonViMuaHangReport2]
@ID INT
AS
BEGIN
    SELECT * FROM dbo.DonViMuaHangs
	WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getDsHH]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_getDsHH]
@id INT
as
BEGIN
    SELECT * 
	FROM dbo.CTHoaDons
	WHERE dbo.CTHoaDons.HoaDonBanId=@id
END



GO
/****** Object:  StoredProcedure [dbo].[usp_getHangHoaByID]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_getHangHoaByID]
@hangHoaId INT
as
BEGIN
    SELECT * 
	FROM dbo.HangHoas
	WHERE dbo.HangHoas.ID=@hangHoaId
END



GO
/****** Object:  StoredProcedure [dbo].[usp_getHangHoaReport]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_getHangHoaReport]
@ID INT
AS
BEGIN
    SELECT Name, DVT, DonGiaBan
	FROM dbo.HangHoas
	WHERE dbo.HangHoas.ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getHangHoaReport2]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_getHangHoaReport2]
@ID INT
AS
BEGIN
    SELECT * FROM dbo.HangHoas
	WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getHoaDonBan]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE	PROC [dbo].[usp_getHoaDonBan]
AS
BEGIN
    SELECT ID,KyHieu,NgayHD,TongTienSo FROM dbo.HoaDonBans
	WHERE DaXoa=0
END




GO
/****** Object:  StoredProcedure [dbo].[usp_getHoaDonBanReport]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_getHoaDonBanReport]
AS
BEGIN
    SELECT ID,KyHieu,NgayHD,NguoiMuaId,TongTienSo
	FROM dbo.HoaDonBans
    
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getHoaDonBanReport2]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_getHoaDonBanReport2]
@ID INT
AS
BEGIN
    SELECT * FROM dbo.HoaDonBans
	WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetHoaDonByDonViMua]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_GetHoaDonByDonViMua]
@DonViMuaHangId INT
AS
BEGIN
    SELECT dbo.HoaDonBans.ID,dbo.HoaDonBans.KyHieu,NguoiMuas.DonViMuaHangId AS MaKhachHang,
			DonViMuaHangs.Name AS TenDonViMua,dbo.DonViMuaHangs.MaSoThueMua AS MaSoThue,
			dbo.NguoiMuas.Name AS TenNguoiMua,dbo.DonViMuaHangs.DiaChiMua AS DiaChi,
			DonViMuaHangs.STKMua AS STK,dbo.HoaDonBans.NgayHD AS NgayXuat, 
			dbo.HinhThucThanhToans.Name AS HinhThuc,dbo.HoaDonBans.TongTienSo AS ThanhTien


	FROM dbo.HoaDonBans,dbo.NguoiMuas,dbo.DonViMuaHangs,HinhThucThanhToans
	WHERE dbo.NguoiMuas.DonViMuaHangId=@DonViMuaHangId
		AND dbo.HoaDonBans.NguoiMuaId=dbo.NguoiMuas.ID
		AND dbo.NguoiMuas.DonViMuaHangId=dbo.DonViMuaHangs.ID
		AND dbo.HoaDonBans.HinhThucThanhToanId=dbo.HinhThucThanhToans.ID


END


GO
/****** Object:  StoredProcedure [dbo].[usp_getHoaDonByFind]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_getHoaDonByFind]
@noidungtimkiem NVARCHAR(100)
AS
BEGIN
    SELECT ID,KyHieu,NgayHD,TongTienSo
	FROM dbo.HoaDonBans
	WHERE ID LIKE '%'+@noidungtimkiem+'$' OR ThueSuat LIKE '%'+@noidungtimkiem+'$' OR KyHieu LIKE '%'+@noidungtimkiem+'$' OR TongTienSo LIKE '%'+@noidungtimkiem+'$' 
END


GO
/****** Object:  StoredProcedure [dbo].[usp_getHTTTReport2]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_getHTTTReport2]
@ID INT
AS
BEGIN
    SELECT * FROM dbo.HinhThucThanhToans
	WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getIDCurrent]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_getIDCurrent]
@nameTable NVARCHAR(255)
AS
BEGIN
    SELECT * FROM dbo.getIdIdentity(@nameTable)
END


GO
/****** Object:  StoredProcedure [dbo].[usp_getIDHDB]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_getIDHDB]
AS
BEGIN
    SELECT IDENT_CURRENT('HoaDonBans') AS ID
END


GO
/****** Object:  StoredProcedure [dbo].[usp_getIDNM]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_getIDNM]
AS
BEGIN
    SELECT IDENT_CURRENT('NguoiMuas') AS ID
END


GO
/****** Object:  StoredProcedure [dbo].[usp_GetNguoiMuaById]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[usp_GetNguoiMuaById] @ID INT
AS
BEGIN
SELECT * FROM dbo.NguoiMuas WHERE DaXoa = 0 AND ID = @ID
END





GO
/****** Object:  StoredProcedure [dbo].[usp_getNguoiMuaReport2]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_getNguoiMuaReport2]
@ID INT
AS
BEGIN
    SELECT * FROM dbo.NguoiMuas
	WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_getNhanVienBanReport2]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_getNhanVienBanReport2]
@ID INT
AS
BEGIN
    SELECT * FROM dbo.NhanVienBans
	WHERE ID=@ID
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetPermision]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[usp_GetPermision]
AS
BEGIN
SELECT  P.ActionCode,[Admin],[P].[Nhân viên in hóa đơn] AS User1,P.[Nhân viên quản lý] AS User2

FROM (
SELECT Name,ActionCode,CAST(CheckAction AS TINYINT) AS CheckAction FROM dbo.Permision INNER JOIN dbo.PerDetail ON PermisionId = dbo.Permision.ID
) x
PIVOT(
	MAX(CheckAction)
	FOR [Name] IN ([Admin],[Nhân viên in hóa đơn],[Nhân viên quản lý])
) P
END





GO
/****** Object:  StoredProcedure [dbo].[usp_getPerMisionGia]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_getPerMisionGia]
AS
BEGIN
    SELECT * FROM [PerDetail]
END
GO
/****** Object:  StoredProcedure [dbo].[usp_GetRoles]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[usp_GetRoles]
AS
BEGIN
SELECT * FROM dbo.Permision
END





GO
/****** Object:  StoredProcedure [dbo].[usp_insertCTHD]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_insertCTHD]
@HoaDonBanId INT,
@HangHoaId INT,
@ThanhTien FLOAT,
@SoLuongBan INT
AS
BEGIN
	BEGIN try
		BEGIN TRANSACTION
			INSERT dbo.CTHoaDons
				( HoaDonBanId ,
					HangHoaId ,
					ThanhTien ,
					SoLuongBan
				)
			VALUES  ( @HoaDonBanId , -- HoaDonBanId - int
					  @HangHoaId , -- HangHoaId - int
					  @ThanhTien , -- ThanhTien - float
					  @SoLuongBan  -- SoLuongBan - int
					)
		COMMIT
	END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END





GO
/****** Object:  StoredProcedure [dbo].[usp_insertHoaDonBan]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_insertHoaDonBan]
@ThueSuat FLOAT, -- ThueSuat - float
@KyHieu NVARCHAR(50), -- KyHieu - nvarchar(50)
@NgayHD DATETIME, -- NgayHD - datetime
@HinhThucThanhToanId INT, -- HinhThucThanhToanId - int
@NguoiMuaId INT, -- NguoiMuaId - int
@NhanVienBanId INT, -- NhanVienBanId - int
@DaXoa bit, -- DaXoa - bit
@TongTienSo NVARCHAR(100), -- TongTienSo - nvarchar(100)
@TongTienChu  NVARCHAR(250)-- TongTienChu - nvarchar(250)
AS
BEGIN
	BEGIN try
		BEGIN TRANSACTION
			INSERT dbo.HoaDonBans
            ( ThueSuat ,
              KyHieu ,
              NgayHD ,
              HinhThucThanhToanId ,
              NguoiMuaId ,
              NhanVienBanId ,
              DaXoa ,
              TongTienSo ,
              TongTienChu
            )
    VALUES  ( @ThueSuat , -- ThueSuat - float
              @KyHieu , -- KyHieu - nvarchar(50)
             @NgayHD , -- NgayHD - datetime
              @HinhThucThanhToanId , -- HinhThucThanhToanId - int
              @NguoiMuaId , -- NguoiMuaId - int
              @NhanVienBanId , -- NhanVienBanId - int
              @DaXoa , -- DaXoa - bit
              @TongTienSo , -- TongTienSo - nvarchar(100)
              @TongTienChu  -- TongTienChu - nvarchar(250)
            )
		COMMIT
	END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[usp_ManagePermision]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[usp_ManagePermision]
AS
    BEGIN
        SELECT  *
        INTO    #Temp
        FROM    dbo.PerDetail;

        DECLARE @Id INT;
        DENY SELECT, INSERT, UPDATE, DELETE ON SCHEMA::dbo TO EmployeeTwoBill;
        DENY SELECT, INSERT, UPDATE, DELETE ON SCHEMA::dbo TO EmployeeOneBill;
        DENY SELECT, INSERT, UPDATE, DELETE ON SCHEMA::dbo TO AdminBillMain;
        WHILE ( SELECT  COUNT(*)
                FROM    #Temp
              ) > 0
            BEGIN
                DECLARE @ActionCode NVARCHAR(100);
                DECLARE @CheckAction BIT;
                DECLARE @PermisionID INT;
                DECLARE @PermisionName NVARCHAR(100);
                DECLARE @sql NVARCHAR(1000);
                SELECT TOP 1
                        @Id = ID ,
                        @ActionCode = ActionCode ,
                        @CheckAction = CheckAction ,
                        @PermisionID = PermisionId
                FROM    #Temp;

                IF ( @PermisionID = 1 )
                    BEGIN
                        SET @PermisionName = 'AdminBillMain';
                    END;
                IF ( @PermisionID = 2 )
                    BEGIN
                        SET @PermisionName = 'EmployeeOneBill';
                    END;
                IF ( @PermisionID = 3 )
                    BEGIN
                        SET @PermisionName = 'EmployeeTwoBill';
                    END;

                IF ( @ActionCode = 'MANAGE_CUSTOMER' )
                    BEGIN
                        IF ( @CheckAction = 1 )
                            BEGIN
                                SET @sql = 'GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::dbo.DonViMuaHangs TO  ';
                                SET @sql = @sql + @PermisionName;
                                EXEC(@sql);
                            END;
                    END;
                IF ( @ActionCode = 'MANAGE_NV' )
                    BEGIN
                        IF ( @CheckAction = 1 )
                            BEGIN
                                SET @sql = 'GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::dbo.NhanVienBans TO ';
                                SET @sql = @sql + @PermisionName;
                                EXEC(@sql);
                            END;

                    END;
                IF ( @ActionCode = 'MANAGE_PRODUCT' )
                    BEGIN
                        IF ( @CheckAction = 1 )
                            BEGIN
                                SET @sql = 'GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::dbo.HangHoas TO ';
                                SET @sql = @sql + @PermisionName;
                                EXEC(@sql);
                            END;

                    END;
                IF ( @ActionCode = 'MANAGE_BILL' )
                    BEGIN
                        IF ( @CheckAction = 1 )
                            --IF ( @PermisionID = 1 )
                            --    BEGIN
                            --        SET @sql = 'GRANT SELECT, INSERT, UPDATE, DELETE ON OBJECT::dbo.HangHoas TO ';
                            --        SET @sql = @sql + @PermisionName;
                            --        EXEC(@sql);
                            --    END;
                        --IF ( @PermisionID = 2 )
                        --    BEGIN
                                SET @sql = 'GRANT INSERT, SELECT ON OBJECT::HoaDonBans TO ';
                                SET @sql = @sql + @PermisionName;
                                EXEC(@sql);
                                SET @sql = ' GRANT SELECT ON OBJECT::DonViMuaHangs TO ';
                                SET @sql = @sql + @PermisionName;
                                EXEC(@sql);
                                SET @sql = ' GRANT INSERT,SELECT ON OBJECT::CTHoaDons TO ';
                                SET @sql = @sql + @PermisionName;
                                EXEC(@sql);
                                SET @sql = ' GRANT INSERT,SELECT ON OBJECT::HangHoas TO ';
                                SET @sql = @sql + @PermisionName;
                                EXEC(@sql);
                                SET @sql = ' GRANT SELECT ON OBJECT::HinhThucThanhToans TO ';
                                SET @sql = @sql + @PermisionName;
                                EXEC(@sql);
                                SET @sql = ' GRANT SELECT ON OBJECT::NhanVienBans TO ';
                                SET @sql = @sql + @PermisionName;
                                EXEC(@sql);
                                SET @sql = ' GRANT SELECT ON OBJECT::DonViBanHangs TO ';
                                SET @sql = @sql + @PermisionName;
                                EXEC(@sql);
                                SET @sql = ' GRANT SELECT,INSERT ON OBJECT::NguoiMuas TO ';
                                SET @sql = @sql + @PermisionName;
                                EXEC(@sql);
                                SET @sql = ' GRANT SELECT ON OBJECT::DangNhaps TO ';
                                SET @sql = @sql + @PermisionName;

                                EXEC(@sql);
                            --END;
                        --IF ( @PermisionID = 3 )
                        --    BEGIN
                        --    END;

                    END;
                IF ( @ActionCode = 'STATISTIC' )
                    BEGIN
                        REVOKE INSERT, UPDATE, SELECT, DELETE ON dbo.HangHoas TO adminbill,userbill1,userbill2;
                        IF ( @CheckAction = 1 )
                            BEGIN
                                SET @sql = 'GRANT INSERT, UPDATE, SELECT, DELETE ON HangHoas TO ';
                                SET @sql = @sql + @PermisionName;
                                EXEC(@sql);
                            END;

                    END;
                IF ( @ActionCode = 'PRINT_BILL' )
                    BEGIN
                        REVOKE INSERT, UPDATE, SELECT, DELETE ON dbo.HangHoas TO adminbill,userbill1,userbill2;
                        IF ( @CheckAction = 1 )
                            BEGIN
                                SET @sql = 'GRANT INSERT, UPDATE, SELECT, DELETE ON HangHoas TO ';
                                SET @sql = @sql + @PermisionName;
                                EXEC(@sql);
                            END;

                    END;
                IF ( @ActionCode = 'INFO_COMPANY' )
                    BEGIN
                        REVOKE INSERT, UPDATE, SELECT, DELETE ON dbo.DonViBanHangs TO adminbill,userbill1,userbill2;
                        IF ( @CheckAction = 1 )
                            BEGIN
                                SET @sql = 'GRANT INSERT, UPDATE, SELECT, DELETE ON DonViBanHangs TO ';
                                SET @sql = @sql + @PermisionName;
                                EXEC(@sql);
                            END;

                    END;
                DELETE  #Temp
                WHERE   ID = @Id;
            END;
    END;



GO
/****** Object:  StoredProcedure [dbo].[usp_showpreviewHoaDon]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_showpreviewHoaDon]
@HoaDonBanId int
AS
BEGIN
    SELECT * FROM dbo.CTHoaDons
	WHERE	HoaDonBanId=@HoaDonBanId
END


GO
/****** Object:  StoredProcedure [dbo].[usp_TestAccount]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
    CREATE PROC [dbo].[usp_TestAccount]
	@UserName NVARCHAR(100),@PassWord NVARCHAR(255)
	AS
    BEGIN
        SELECT * FROM dbo.TestAccount(@UserName,@PassWord)
    END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateDonViBanHang]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO




CREATE PROC [dbo].[usp_UpdateDonViBanHang] @ID INT,@Name NVARCHAR(100),@DiaChiBan NVARCHAR(50),@MaSoThueBan NVARCHAR(MAX),
@STKBan NVARCHAR(20),@SDTBan NVARCHAR(12)
AS
BEGIN
	BEGIN try
		BEGIN TRANSACTION
			UPDATE dbo.DonViBanHangs 
				SET
				Name = @Name,
				DiaChi = @DiaChiBan,
				MaSoThueBan = @MaSoThueBan,
				STKBan = @STKBan,
				SDTBan = @SDTBan

				WHERE ID = @ID 
		COMMIT
	END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END







GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateDonViMuaHang]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO



CREATE PROC [dbo].[usp_UpdateDonViMuaHang] @ID INT,@Name NVARCHAR(100),@DiaChiMua NVARCHAR(50),@MaSoThueMua NVARCHAR(MAX),
@STKMua NVARCHAR(20),@SDTMua NVARCHAR(12)
AS
BEGIN
	BEGIN try
		BEGIN TRANSACTION
			UPDATE dbo.DonViMuaHangs 
			SET
			Name = @Name,
			DiaChiMua = @DiaChiMua,
			MaSoThueMua = @MaSoThueMua,
			STKMua = @STKMua,
			SDTMua = @SDTMua

			WHERE ID = @ID 
		COMMIT
	END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END






GO
/****** Object:  StoredProcedure [dbo].[usp_updateHangHoa]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_updateHangHoa]
@Name NVARCHAR(100),
@DVT NVARCHAR(50),
@SoLuong INT,
@DonGiaNhap FLOAT,
@DonGiaBan FLOAT,
@GhiChu NVARCHAR(250),
@DaXoa BIT,
@ID int
AS
BEGIN
	BEGIN try
		BEGIN TRANSACTION
				UPDATE dbo.HangHoas SET
				dbo.HangHoas.Name=@Name,
				dbo.HangHoas.DVT=@DVT,
				dbo.HangHoas.SoLuong=@SoLuong,
				dbo.HangHoas.DonGiaNhap=@DonGiaNhap,
				dbo.HangHoas.DonGiaBan=@DonGiaBan,
				dbo.HangHoas.GhiChu=@GhiChu,
				dbo.HangHoas.DaXoa=@DaXoa
				WHERE dbo.HangHoas.ID=@ID
		COMMIT
	END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[usp_updateHoaDon]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_updateHoaDon]
@ThueSuat FLOAT,
@KyHieu NVARCHAR(50),
@NgayHD DATETIME,
@HinhThucThanhToanId INT,
@NguoiMuaId INT,
@NhanVienBanId INT,
@DaXoa BIT,
@TongTienSo NVARCHAR(100),
@TongTienChu NVARCHAR(250),
@ID INT
AS
BEGIN
	BEGIN try
		BEGIN TRANSACTION
				 UPDATE dbo.HoaDonBans SET
	dbo.HoaDonBans.ThueSuat=@ThueSuat,
	dbo.HoaDonBans.KyHieu=@KyHieu,
	dbo.HoaDonBans.NgayHD=@NgayHD,
	dbo.HoaDonBans.HinhThucThanhToanId=@HinhThucThanhToanId,
	dbo.HoaDonBans.NguoiMuaId=@NguoiMuaId,
	dbo.HoaDonBans.NhanVienBanId=@NhanVienBanId,
	dbo.HoaDonBans.DaXoa=@DaXoa,
	dbo.HoaDonBans.TongTienSo=@TongTienSo,
	dbo.HoaDonBans.TongTienChu=@TongTienChu
	WHERE dbo.HoaDonBans.ID=@ID
		COMMIT
	END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END



GO
/****** Object:  StoredProcedure [dbo].[usp_updateNguoiMua]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_updateNguoiMua]
@ID INT,
@Name NVARCHAR(100),
@DonViMuaHangId INT,
@DaXoa BIT,
@CMND NVARCHAR(12)
AS 
BEGIN
	BEGIN try
		BEGIN TRANSACTION
		    UPDATE dbo.NguoiMuas SET
			dbo.NguoiMuas.Name=@Name,
			dbo.NguoiMuas.DonViMuaHangId=@DonViMuaHangId,
			dbo.NguoiMuas.DaXoa=@DaXoa,
			dbo.NguoiMuas.CMND=@CMND
			WHERE ID=@ID
		COMMIT
	END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END


GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateNhanVien]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[usp_UpdateNhanVien]
    @ID INT ,
    @Name NVARCHAR(100) ,
    @GioiTinh NVARCHAR(20) ,
    @SDT NVARCHAR(MAX) ,
    @DOB DATETIME ,
    @TTLamViec NVARCHAR(100) ,
    @HinhAnh NVARCHAR(255) ,
    @DiaChi NVARCHAR(100) ,
    @CMND NVARCHAR(100) ,
    @NgayCap DATETIME ,
    @NoiCap NVARCHAR(100) ,
    @HonNhan BIT ,
    @PassWord NVARCHAR(50) ,
    @RoleID INT
AS
    BEGIN
        BEGIN TRY
            BEGIN TRANSACTION;
            UPDATE  dbo.NhanVienBans
            SET     Name = @Name ,
                    GioiTinh = @GioiTinh ,
                    SDT = @SDT ,
                    DOB = @DOB ,
                    TTLamViec = @TTLamViec ,
                    HinhAnh = @HinhAnh ,
                    DiaChi = @DiaChi ,
                    CMND = @CMND ,
                    NgayCap = @NgayCap ,
                    NoiCap = @NoiCap ,
                    HonNhan = @HonNhan
            WHERE   ID = @ID;
            DECLARE @AccountID INT;
            SELECT  @AccountID = AccountID FROM dbo.NhanVienBans WHERE ID = @ID

            UPDATE  dbo.DangNhaps
            SET     [PassWord] = @PassWord
            WHERE   ID = @AccountID;

            UPDATE  dbo.UserPer
            SET     PermisionId = @RoleID
            WHERE   UserId = @AccountID;

            COMMIT;
        END TRY
        BEGIN CATCH
            ROLLBACK TRANSACTION;
        END CATCH;
    END;





GO
/****** Object:  StoredProcedure [dbo].[usp_updateOnePermission]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_updateOnePermission]
@CheckAction BIT,
@IDPermission INT,
@NameActionCode NVARCHAR(50)
AS
BEGIN
    UPDATE dbo.PerDetail
	SET CheckAction=@CheckAction
	WHERE PermisionId=@IDPermission AND ActionCode=@NameActionCode
END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdatePermision]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UpdatePermision]
@MANAGE_CUSTOMER BIT,
@MANAGE_NV BIT,
@MANAGE_PRODUCT bit,
@MANAGE_BILL BIT,
@STATISTIC BIT,
@PRINT_BILL BIT,
@INFO_COMPANY BIT,
@MANAGE_ACCOUNT BIT,
@IDPermission INT
AS
BEGIN
EXEC dbo.usp_updateOnePermission @CheckAction = @MANAGE_CUSTOMER, -- bit
    @IDPermission = @IDPermission, -- int
    @NameActionCode = N'MANAGE_CUSTOMER' -- nvarchar(50)

EXEC dbo.usp_updateOnePermission @CheckAction = @MANAGE_NV, -- bit
    @IDPermission = @IDPermission, -- int
    @NameActionCode = N'MANAGE_NV' -- nvarchar(50)

EXEC dbo.usp_updateOnePermission @CheckAction = @MANAGE_PRODUCT, -- bit
       @IDPermission = @IDPermission, -- int
       @NameActionCode = N'MANAGE_PRODUCT' -- nvarchar(50)

EXEC dbo.usp_updateOnePermission @CheckAction = @MANAGE_BILL, -- bit
       @IDPermission = @IDPermission, -- int
       @NameActionCode = N'MANAGE_BILL' -- nvarchar(50)
EXEC dbo.usp_updateOnePermission @CheckAction = @STATISTIC, -- bit
       @IDPermission = @IDPermission, -- int
       @NameActionCode = N'STATISTIC' -- nvarchar(50)
EXEC dbo.usp_updateOnePermission @CheckAction = @PRINT_BILL, -- bit
       @IDPermission = @IDPermission, -- int
       @NameActionCode = N'PRINT_BILL' -- nvarchar(50)
EXEC dbo.usp_updateOnePermission @CheckAction = @INFO_COMPANY, -- bit
       @IDPermission = @IDPermission, -- int
       @NameActionCode = N'INFO_COMPANY' -- nvarchar(50)
EXEC dbo.usp_updateOnePermission @CheckAction = @MANAGE_ACCOUNT, -- bit
       @IDPermission = @IDPermission, -- int
       @NameActionCode = N'MANAGE_ACCOUNT' -- nvarchar(50)
   
END





GO
/****** Object:  StoredProcedure [dbo].[usp_UpdatePermisionAdmin]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[usp_UpdatePermisionAdmin]
@MANAGE_CUSTOMER bit

AS
BEGIN
    UPDATE dbo.PerDetail
	SET CheckAction=@MANAGE_CUSTOMER
	WHERE PermisionId=1 AND ActionCode=N'MANAGE_CUSTOMER'
END
GO
/****** Object:  StoredProcedure [dbo].[usp_UpdateProduct]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROC [dbo].[usp_UpdateProduct] @ID INT,@Name NVARCHAR(100),@DVT NVARCHAR(50),@Soluong INT,
@DonGiaNhap FLOAT,@DonGiaBan FLOAT,@GhiChu NVARCHAR(250)
AS
BEGIN
	BEGIN try
		BEGIN TRANSACTION
		    UPDATE dbo.HangHoas
			SET 
			Name = @Name,
			DVT = @DVT,
			SoLuong = @Soluong,
			DonGiaNhap = @DonGiaNhap,
			DonGiaBan = @DonGiaBan,
			GhiChu = @GhiChu
			WHERE ID = @ID
		COMMIT
	END TRY
    BEGIN CATCH
		ROLLBACK TRANSACTION
	END CATCH
END






GO
/****** Object:  StoredProcedure [dbo].[XoaHangHoa]    Script Date: 11/21/2018 7:37:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[XoaHangHoa]
@idHangHoa INT
AS
BEGIN
    IF	EXISTS(SELECT 1 FROM dbo.CTHoaDons WHERE HangHoaId =@idHangHoa)
	BEGIN
	    DELETE dbo.CTHoaDons WHERE HangHoaId=@idHangHoa
		DELETE dbo.HangHoas WHERE ID=@idHangHoa
	END
END


GO
