USE [ApartmentSmart]
GO
/****** Object:  Table [dbo].[tblRoom]    Script Date: 9/14/2019 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRoom](
	[Room_ID] [varchar](36) NOT NULL,
	[Room_number] [varchar](50) NULL,
	[Room_floor] [varchar](1) NULL,
	[Room_Type] [varchar](36) NULL,
	[Room_Price_daily] [decimal](10, 2) NULL,
	[Room_Price_monthly] [decimal](10, 2) NULL,
	[Room_status] [varchar](36) NULL,
	[Room_MetersNo] [nchar](10) NULL,
	[Room_Remark] [nchar](10) NULL,
 CONSTRAINT [PK_tblRoom] PRIMARY KEY CLUSTERED 
(
	[Room_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblStatus]    Script Date: 9/14/2019 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblStatus](
	[StatusID] [varchar](36) NOT NULL,
	[Name] [varchar](200) NULL,
	[StatusType] [varchar](100) NULL,
 CONSTRAINT [PK_tblStatus] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[uv_room]    Script Date: 9/14/2019 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[uv_room] 
AS
SELECT  
    r.Room_ID,
    r.Room_number,
    r.Room_floor,
    r.Room_Type,
    t.Name AS RoomType,
    r.Room_Price_daily,
    r.Room_Price_monthly,
    r.Room_status,
    s.Name AS RoomStatus,
    r.Room_MetersNo,
    r.Room_Remark
FROM tblRoom r
INNER JOIN tblStatus s ON r.Room_status = s.StatusID
INNER JOIN tblStatus t ON r.Room_Type = t.StatusID
GO
/****** Object:  Table [dbo].[tblRenter]    Script Date: 9/14/2019 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRenter](
	[Renter_ID] [varchar](36) NOT NULL,
	[Renter_TitleName] [varchar](20) NULL,
	[Renter_Name] [varchar](200) NULL,
	[Renter_Lastname] [varchar](200) NULL,
	[Renter_Nationality] [varchar](100) NULL,
	[Renter_Card] [varchar](15) NULL,
	[Renter_Address] [varchar](max) NULL,
	[Renter_Tel] [varchar](15) NULL,
	[Renter_Status] [varchar](1) NULL,
	[Renter_Remark] [varchar](max) NULL,
 CONSTRAINT [PK_tblRenter] PRIMARY KEY CLUSTERED 
(
	[Renter_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[uv_renter]    Script Date: 9/14/2019 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[uv_renter]
AS
SELECT 
    r.Renter_ID,
    r.Renter_TitleName,
    r.Renter_Name,
    r.Renter_Lastname,
    r.Renter_Nationality,
    r.Renter_Card,
    r.Renter_Tel,
    r.Renter_Address,
    r.Renter_TitleName + ' ' + r.Renter_Name + ' ' + r.Renter_Lastname  AS RenterFullName
FROM tblRenter r
GO
/****** Object:  Table [dbo].[tblContract]    Script Date: 9/14/2019 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblContract](
	[Contract_ID] [varchar](36) NOT NULL,
	[Renter_ID] [varchar](36) NULL,
	[Room_ID] [varchar](36) NULL,
	[Contract_No] [varchar](20) NULL,
	[Contract_Date] [datetime] NULL,
	[Contract_Recognizance] [decimal](10, 2) NULL,
	[Contract_Status] [varchar](36) NULL,
	[Contract_Type] [varchar](36) NULL,
	[Date_Checkin] [datetime] NULL,
	[Date_Checkout] [datetime] NULL,
	[power_first] [float] NULL,
	[water_first] [float] NULL,
	[room_price] [decimal](10, 2) NULL,
	[Remark] [varchar](max) NULL,
 CONSTRAINT [PK_tblContract] PRIMARY KEY CLUSTERED 
(
	[Contract_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  View [dbo].[uv_contract]    Script Date: 9/14/2019 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[uv_contract]
AS
SELECT 
    c.Contract_ID,
    c.Contract_No,
    c.Contract_Date,
    c.Contract_Recognizance,
    c.Contract_Status,
    s.Name AS Contract_StatusName,
    c.Contract_Type,
    t.Name AS Contract_TypeName,
    c.Date_Checkin,
    c.Date_Checkout,
    c.room_price,
    c.Renter_ID,
    rent.RenterFullname,
    rent.Renter_Card,
    rent.Renter_Address,
    rent.Renter_Tel,
    rent.Renter_Nationality,
    c.Room_ID,
    room.Room_number,
    room.Room_floor,
    room.RoomType,
    room.Room_MetersNo,
    room.RoomStatus
FROM tblContract c
INNER JOIN tblStatus t ON c.Contract_Type = t.StatusID
INNER JOIN tblStatus s ON c.Contract_Status = s.StatusID
INNER JOIN uv_renter rent ON c.Renter_ID = rent.Renter_ID
INNER JOIN uv_room room ON c.Room_ID = room.Room_ID
GO
/****** Object:  Table [dbo].[tblPayment]    Script Date: 9/14/2019 1:40:09 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPayment](
	[Pay_ID] [varchar](36) NOT NULL,
	[Contract_ID] [varchar](36) NULL,
	[Record_ID] [varchar](36) NULL,
	[Pay_date] [datetime] NULL,
	[Pay_Sum_amount] [decimal](10, 2) NULL,
	[Pay_status] [varchar](36) NULL,
	[UserID] [varchar](36) NULL,
 CONSTRAINT [PK_tblPayment] PRIMARY KEY CLUSTERED 
(
	[Pay_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[uv_payment]    Script Date: 9/14/2019 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[uv_payment]
AS
select 
    p.Pay_ID,
    p.Contract_ID,
    p.Pay_date,
    c.Contract_No,
    c.Room_number,
    c.Room_floor,
    c.RenterFullname,
    c.Contract_Recognizance,
    c.room_price,
    c.Contract_Type,
    c.Contract_TypeName,
    c.Date_Checkin,
    c.Date_Checkout,
    p.Pay_status,
    p.Pay_Sum_amount,
    s.Name AS PaymentStatus
from tblPayment p
INNER JOIN tblStatus s ON p.Pay_status = s.StatusID
INNER JOIN uv_contract c ON p.Contract_ID = c.Contract_ID


GO
/****** Object:  Table [dbo].[tblPaymentDT]    Script Date: 9/14/2019 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblPaymentDT](
	[PayDT_ID] [varchar](36) NOT NULL,
	[Pay_ID] [varchar](36) NULL,
	[Detail] [varchar](500) NULL,
	[Amount] [decimal](10, 2) NULL,
 CONSTRAINT [PK_tblPaymentDT] PRIMARY KEY CLUSTERED 
(
	[PayDT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[uv_payment_print]    Script Date: 9/14/2019 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[uv_payment_print]
AS
SELECT 
    uv.*,
    dt.PayDT_ID,
    dt.Detail,
    dt.Amount 
FROM uv_payment uv
LEFT JOIN tblPaymentDT dt ON uv.Pay_ID = dt.Pay_ID
GO
/****** Object:  Table [dbo].[tblRecord]    Script Date: 9/14/2019 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRecord](
	[Record_ID] [varchar](36) NOT NULL,
	[Year] [varchar](5) NULL,
	[Month] [varchar](50) NULL,
	[RecordStatus] [varchar](36) NULL,
 CONSTRAINT [PK_tblRecord] PRIMARY KEY CLUSTERED 
(
	[Record_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[uv_record]    Script Date: 9/14/2019 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[uv_record]
AS
SELECT * FROM tblRecord r
INNER JOIN tblStatus s ON r.RecordStatus = s.StatusID

GO
/****** Object:  Table [dbo].[tblRecordDT]    Script Date: 9/14/2019 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblRecordDT](
	[RecordDT_ID] [varchar](36) NOT NULL,
	[Record_ID] [varchar](36) NULL,
	[Contract_ID] [varchar](36) NULL,
	[Num_Water] [float] NULL,
	[Before_Power] [float] NULL,
	[Num_Power] [float] NULL,
	[Record_water] [float] NULL,
	[Record_power] [float] NULL,
	[Record_date] [datetime] NULL,
 CONSTRAINT [PK_tblRecordDT] PRIMARY KEY CLUSTERED 
(
	[RecordDT_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  View [dbo].[uv_record_detail]    Script Date: 9/14/2019 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE VIEW [dbo].[uv_record_detail]
AS
SELECT 
    r.*,
    rdt.RecordDT_ID,
    rdt.Contract_ID,
    rdt.Num_Water,
    rdt.Before_Power,
    rdt.Num_Power,
    rdt.Record_water,
    rdt.Record_power,
    rdt.Record_date,
    c.room_price,
    c.RenterFullname,
    c.Room_number
FROM tblRecord r
LEFT JOIN tblRecordDT rdt ON r.Record_ID = rdt.Record_ID
INNER JOIN uv_contract c ON rdt.Contract_ID = c.Contract_ID
GO
/****** Object:  Table [dbo].[tblOwner]    Script Date: 9/14/2019 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblOwner](
	[Owner_ID] [varchar](36) NOT NULL,
	[Owner_Name] [varchar](500) NULL,
	[Owner_Tax] [varchar](15) NULL,
	[Owner_Address] [varchar](max) NULL,
	[Owner_Moo] [varchar](20) NULL,
	[Owner_Tambon] [varchar](200) NULL,
	[Owner_Amphur] [varchar](200) NULL,
	[Owner_Province] [varchar](200) NULL,
	[Owner_Zip] [varchar](5) NULL,
	[Owner_Tel] [varchar](15) NULL,
	[Record_power] [float] NULL,
	[Record_water] [float] NULL,
 CONSTRAINT [PK_tblOwner] PRIMARY KEY CLUSTERED 
(
	[Owner_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[tblUser]    Script Date: 9/14/2019 1:40:10 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tblUser](
	[UserID] [varchar](36) NOT NULL,
	[Username] [varchar](50) NULL,
	[User_name] [varchar](500) NULL,
	[User_password] [varchar](50) NULL,
	[User_type] [varchar](1) NULL,
 CONSTRAINT [PK_tblUser] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[tblContract] ([Contract_ID], [Renter_ID], [Room_ID], [Contract_No], [Contract_Date], [Contract_Recognizance], [Contract_Status], [Contract_Type], [Date_Checkin], [Date_Checkout], [power_first], [water_first], [room_price], [Remark]) VALUES (N'0f2b767a-8e1f-42d1-a546-02f1b6f69be2', N'069b533a-644e-45b6-aaee-359c29c8036e', N'7db7c77e-0be4-441c-9f73-9390ea339ef1', N'CON20190003', CAST(N'2019-08-24T15:13:50.143' AS DateTime), CAST(6000.00 AS Decimal(10, 2)), N'C3A9B05E-7151-488E-99C6-5EBA38A3BB5D', N'12F0398E-0197-466C-9D76-171E9C4CAC4A', CAST(N'2019-09-01T15:13:50.000' AS DateTime), CAST(N'9990-01-01T00:00:00.000' AS DateTime), 0, 0, CAST(3500.00 AS Decimal(10, 2)), N'')
GO
INSERT [dbo].[tblContract] ([Contract_ID], [Renter_ID], [Room_ID], [Contract_No], [Contract_Date], [Contract_Recognizance], [Contract_Status], [Contract_Type], [Date_Checkin], [Date_Checkout], [power_first], [water_first], [room_price], [Remark]) VALUES (N'1c102bf8-d572-4c51-9976-8687c282eaf9', N'069b533a-644e-45b6-aaee-359c29c8036e', N'4b5ed133-8aa5-42cd-a1cc-29d0291a6f46', N'CON20190007', CAST(N'2019-09-13T15:55:58.137' AS DateTime), CAST(500.00 AS Decimal(10, 2)), N'C3A9B05E-7151-488E-99C6-5EBA38A3BB5D', N'F540A7D1-B1E6-4F65-9645-A08EDC6BD3A1', CAST(N'2019-09-13T15:55:58.130' AS DateTime), CAST(N'2019-09-16T15:55:58.000' AS DateTime), 0, 0, CAST(550.00 AS Decimal(10, 2)), N'')
GO
INSERT [dbo].[tblContract] ([Contract_ID], [Renter_ID], [Room_ID], [Contract_No], [Contract_Date], [Contract_Recognizance], [Contract_Status], [Contract_Type], [Date_Checkin], [Date_Checkout], [power_first], [water_first], [room_price], [Remark]) VALUES (N'620c3cb3-8b85-4aef-9e85-746faccfa922', N'b594d00c-02f0-4899-a10e-2f0caa04b624', N'de2778a1-c803-4bce-851b-3008daa97157', N'CON20190001', CAST(N'2019-08-22T22:47:59.730' AS DateTime), CAST(3000.00 AS Decimal(10, 2)), N'C3A9B05E-7151-488E-99C6-5EBA38A3BB5D', N'F540A7D1-B1E6-4F65-9645-A08EDC6BD3A1', CAST(N'2019-08-22T22:47:59.717' AS DateTime), CAST(N'2019-08-30T16:02:13.577' AS DateTime), 0, 0, CAST(500.00 AS Decimal(10, 2)), N'')
GO
INSERT [dbo].[tblContract] ([Contract_ID], [Renter_ID], [Room_ID], [Contract_No], [Contract_Date], [Contract_Recognizance], [Contract_Status], [Contract_Type], [Date_Checkin], [Date_Checkout], [power_first], [water_first], [room_price], [Remark]) VALUES (N'635d003c-8357-4332-8ece-130e687ec38f', N'069b533a-644e-45b6-aaee-359c29c8036e', N'a54c54d3-5c13-4a67-b9dd-0ddf4fc229b0', N'CON20190012', CAST(N'2019-09-13T22:54:43.640' AS DateTime), CAST(4000.00 AS Decimal(10, 2)), N'5E6D9764-AFA4-4363-A08A-116A0C997414', N'12F0398E-0197-466C-9D76-171E9C4CAC4A', CAST(N'2019-10-01T22:54:43.000' AS DateTime), CAST(N'9990-01-01T00:00:00.000' AS DateTime), 0, 0, CAST(4000.00 AS Decimal(10, 2)), N'')
GO
INSERT [dbo].[tblContract] ([Contract_ID], [Renter_ID], [Room_ID], [Contract_No], [Contract_Date], [Contract_Recognizance], [Contract_Status], [Contract_Type], [Date_Checkin], [Date_Checkout], [power_first], [water_first], [room_price], [Remark]) VALUES (N'739468fa-11fa-43cc-8ca2-7a7de7843d87', N'60ca86b9-77d3-4931-80cc-dbab3806a219', N'4b5ed133-8aa5-42cd-a1cc-29d0291a6f46', N'CON20190004', CAST(N'2019-08-30T00:32:44.107' AS DateTime), CAST(5000.00 AS Decimal(10, 2)), N'C3A9B05E-7151-488E-99C6-5EBA38A3BB5D', N'12F0398E-0197-466C-9D76-171E9C4CAC4A', CAST(N'2019-08-30T00:32:44.090' AS DateTime), CAST(N'9990-01-01T00:00:00.000' AS DateTime), 0, 0, CAST(3500.00 AS Decimal(10, 2)), N'')
GO
INSERT [dbo].[tblContract] ([Contract_ID], [Renter_ID], [Room_ID], [Contract_No], [Contract_Date], [Contract_Recognizance], [Contract_Status], [Contract_Type], [Date_Checkin], [Date_Checkout], [power_first], [water_first], [room_price], [Remark]) VALUES (N'817cf5f7-c666-49b3-97e9-2c39af01c151', N'069b533a-644e-45b6-aaee-359c29c8036e', N'5316a831-bb89-4280-9242-7eb435dd41a7', N'CON20190013', CAST(N'2019-09-13T23:06:30.823' AS DateTime), CAST(4000.00 AS Decimal(10, 2)), N'5E6D9764-AFA4-4363-A08A-116A0C997414', N'12F0398E-0197-466C-9D76-171E9C4CAC4A', CAST(N'2019-10-01T23:06:30.000' AS DateTime), CAST(N'9990-01-01T00:00:00.000' AS DateTime), 100, 0, CAST(4000.00 AS Decimal(10, 2)), N'')
GO
INSERT [dbo].[tblContract] ([Contract_ID], [Renter_ID], [Room_ID], [Contract_No], [Contract_Date], [Contract_Recognizance], [Contract_Status], [Contract_Type], [Date_Checkin], [Date_Checkout], [power_first], [water_first], [room_price], [Remark]) VALUES (N'8287586e-65b5-409f-92a8-cbe7ea634265', N'96691dd2-d1ed-4988-ac18-c21db63e8923', N'4b5ed133-8aa5-42cd-a1cc-29d0291a6f46', N'CON20190010', CAST(N'2019-09-13T16:18:35.277' AS DateTime), CAST(1000.00 AS Decimal(10, 2)), N'C3A9B05E-7151-488E-99C6-5EBA38A3BB5D', N'F540A7D1-B1E6-4F65-9645-A08EDC6BD3A1', CAST(N'2019-09-13T16:18:35.270' AS DateTime), CAST(N'2019-09-14T16:18:35.000' AS DateTime), 0, 0, CAST(990.00 AS Decimal(10, 2)), N'')
GO
INSERT [dbo].[tblContract] ([Contract_ID], [Renter_ID], [Room_ID], [Contract_No], [Contract_Date], [Contract_Recognizance], [Contract_Status], [Contract_Type], [Date_Checkin], [Date_Checkout], [power_first], [water_first], [room_price], [Remark]) VALUES (N'8ade79dc-2f16-4052-a1bc-e1630a8dc933', N'8ae15318-155b-47ce-8f8a-a02e580775f1', N'de2778a1-c803-4bce-851b-3008daa97157', N'CON20190011', CAST(N'2019-09-13T16:34:31.323' AS DateTime), CAST(500.00 AS Decimal(10, 2)), N'C3A9B05E-7151-488E-99C6-5EBA38A3BB5D', N'F540A7D1-B1E6-4F65-9645-A08EDC6BD3A1', CAST(N'2019-09-13T16:34:31.317' AS DateTime), CAST(N'2019-09-20T16:34:31.000' AS DateTime), 0, 0, CAST(300.00 AS Decimal(10, 2)), N'')
GO
INSERT [dbo].[tblContract] ([Contract_ID], [Renter_ID], [Room_ID], [Contract_No], [Contract_Date], [Contract_Recognizance], [Contract_Status], [Contract_Type], [Date_Checkin], [Date_Checkout], [power_first], [water_first], [room_price], [Remark]) VALUES (N'91af524c-9751-4376-bfc2-f5379d985ddb', N'96691dd2-d1ed-4988-ac18-c21db63e8923', N'a54c54d3-5c13-4a67-b9dd-0ddf4fc229b0', N'CON20190005', CAST(N'2019-08-31T09:26:23.957' AS DateTime), CAST(500.00 AS Decimal(10, 2)), N'C3A9B05E-7151-488E-99C6-5EBA38A3BB5D', N'F540A7D1-B1E6-4F65-9645-A08EDC6BD3A1', CAST(N'2019-09-01T09:26:23.000' AS DateTime), CAST(N'2019-09-03T09:26:23.000' AS DateTime), 0, 0, CAST(950.00 AS Decimal(10, 2)), N'')
GO
INSERT [dbo].[tblContract] ([Contract_ID], [Renter_ID], [Room_ID], [Contract_No], [Contract_Date], [Contract_Recognizance], [Contract_Status], [Contract_Type], [Date_Checkin], [Date_Checkout], [power_first], [water_first], [room_price], [Remark]) VALUES (N'a5fbeb93-bacd-4ec2-8db0-53b243521343', N'069b533a-644e-45b6-aaee-359c29c8036e', N'4b5ed133-8aa5-42cd-a1cc-29d0291a6f46', N'CON20190008', CAST(N'2019-09-13T16:03:30.380' AS DateTime), CAST(1000.00 AS Decimal(10, 2)), N'C3A9B05E-7151-488E-99C6-5EBA38A3BB5D', N'F540A7D1-B1E6-4F65-9645-A08EDC6BD3A1', CAST(N'2019-09-13T16:03:30.373' AS DateTime), CAST(N'2019-09-14T16:03:30.000' AS DateTime), 0, 0, CAST(950.00 AS Decimal(10, 2)), N'')
GO
INSERT [dbo].[tblContract] ([Contract_ID], [Renter_ID], [Room_ID], [Contract_No], [Contract_Date], [Contract_Recognizance], [Contract_Status], [Contract_Type], [Date_Checkin], [Date_Checkout], [power_first], [water_first], [room_price], [Remark]) VALUES (N'bf22eecc-3d6a-4fec-be2c-3e800bcfcb55', N'8ae15318-155b-47ce-8f8a-a02e580775f1', N'5316a831-bb89-4280-9242-7eb435dd41a7', N'CON20190006', CAST(N'2019-08-31T09:27:31.960' AS DateTime), CAST(6000.00 AS Decimal(10, 2)), N'C3A9B05E-7151-488E-99C6-5EBA38A3BB5D', N'12F0398E-0197-466C-9D76-171E9C4CAC4A', CAST(N'2019-09-01T09:27:31.000' AS DateTime), CAST(N'9990-01-01T00:00:00.000' AS DateTime), 0, 0, CAST(4000.00 AS Decimal(10, 2)), N'')
GO
INSERT [dbo].[tblContract] ([Contract_ID], [Renter_ID], [Room_ID], [Contract_No], [Contract_Date], [Contract_Recognizance], [Contract_Status], [Contract_Type], [Date_Checkin], [Date_Checkout], [power_first], [water_first], [room_price], [Remark]) VALUES (N'fbd2b7fb-f6e9-4d4a-9747-80dbcde87613', N'60ca86b9-77d3-4931-80cc-dbab3806a219', N'de2778a1-c803-4bce-851b-3008daa97157', N'CON20190009', CAST(N'2019-09-13T16:11:10.807' AS DateTime), CAST(500.00 AS Decimal(10, 2)), N'C3A9B05E-7151-488E-99C6-5EBA38A3BB5D', N'F540A7D1-B1E6-4F65-9645-A08EDC6BD3A1', CAST(N'2019-09-13T16:11:10.800' AS DateTime), CAST(N'2019-09-13T16:11:10.790' AS DateTime), 0, 0, CAST(550.00 AS Decimal(10, 2)), N'')
GO
INSERT [dbo].[tblOwner] ([Owner_ID], [Owner_Name], [Owner_Tax], [Owner_Address], [Owner_Moo], [Owner_Tambon], [Owner_Amphur], [Owner_Province], [Owner_Zip], [Owner_Tel], [Record_power], [Record_water]) VALUES (N'7A53AF74-75DE-46D0-8F27-6BEA383AC510', N'ทดสอบ', N'1234567890123', N'ทดสอบ', N'2', N'ตลาดใหญ่', N'ดอยสะเก็ด', N'เชียงใหม่', N'50220', N'053840112', 7, 120)
GO
INSERT [dbo].[tblPayment] ([Pay_ID], [Contract_ID], [Record_ID], [Pay_date], [Pay_Sum_amount], [Pay_status], [UserID]) VALUES (N'3f4c8f98-4e16-46d0-845c-cec02a04de87', N'817cf5f7-c666-49b3-97e9-2c39af01c151', N'9d06e21b-628f-49d9-b1a2-ff28e434e804', NULL, CAST(4479.00 AS Decimal(10, 2)), N'C42C5738-A1C1-4719-8F8C-DE3A2B8BF887', NULL)
GO
INSERT [dbo].[tblPayment] ([Pay_ID], [Contract_ID], [Record_ID], [Pay_date], [Pay_Sum_amount], [Pay_status], [UserID]) VALUES (N'5454eb44-dcf6-489f-aab7-9c9d81c54e10', N'635d003c-8357-4332-8ece-130e687ec38f', N'f3cd6a29-efaf-4823-8c88-804338cdf7ea', NULL, CAST(4943.00 AS Decimal(10, 2)), N'C42C5738-A1C1-4719-8F8C-DE3A2B8BF887', NULL)
GO
INSERT [dbo].[tblPayment] ([Pay_ID], [Contract_ID], [Record_ID], [Pay_date], [Pay_Sum_amount], [Pay_status], [UserID]) VALUES (N'691557c1-7df5-4a89-a202-5a125057a939', N'817cf5f7-c666-49b3-97e9-2c39af01c151', N'f3cd6a29-efaf-4823-8c88-804338cdf7ea', NULL, CAST(4437.00 AS Decimal(10, 2)), N'C42C5738-A1C1-4719-8F8C-DE3A2B8BF887', NULL)
GO
INSERT [dbo].[tblPayment] ([Pay_ID], [Contract_ID], [Record_ID], [Pay_date], [Pay_Sum_amount], [Pay_status], [UserID]) VALUES (N'82fe27bd-e720-4a71-ab72-35060fcd034c', N'817cf5f7-c666-49b3-97e9-2c39af01c151', N'cacd07ff-0267-4b58-944e-4e7097fd75b4', NULL, CAST(4799.00 AS Decimal(10, 2)), N'C42C5738-A1C1-4719-8F8C-DE3A2B8BF887', NULL)
GO
INSERT [dbo].[tblPayment] ([Pay_ID], [Contract_ID], [Record_ID], [Pay_date], [Pay_Sum_amount], [Pay_status], [UserID]) VALUES (N'922ebfd6-97f0-4472-ad88-2bc786f73cfc', N'635d003c-8357-4332-8ece-130e687ec38f', N'9d06e21b-628f-49d9-b1a2-ff28e434e804', NULL, CAST(4590.00 AS Decimal(10, 2)), N'C42C5738-A1C1-4719-8F8C-DE3A2B8BF887', NULL)
GO
INSERT [dbo].[tblPayment] ([Pay_ID], [Contract_ID], [Record_ID], [Pay_date], [Pay_Sum_amount], [Pay_status], [UserID]) VALUES (N'94d05123-c268-4be8-9bd6-183c92f13114', N'635d003c-8357-4332-8ece-130e687ec38f', N'cacd07ff-0267-4b58-944e-4e7097fd75b4', NULL, CAST(4820.00 AS Decimal(10, 2)), N'C42C5738-A1C1-4719-8F8C-DE3A2B8BF887', NULL)
GO
INSERT [dbo].[tblPayment] ([Pay_ID], [Contract_ID], [Record_ID], [Pay_date], [Pay_Sum_amount], [Pay_status], [UserID]) VALUES (N'9c118c60-17a0-4d00-b350-8a7655259bad', N'8ade79dc-2f16-4052-a1bc-e1630a8dc933', NULL, CAST(N'2019-09-13T19:55:44.283' AS DateTime), CAST(2100.00 AS Decimal(10, 2)), N'CAA27F61-673E-45A8-8FEF-A83945CBFD80', N'992dffdd-ac3f-4d06-bc43-e5849f80d1fb')
GO
INSERT [dbo].[tblPayment] ([Pay_ID], [Contract_ID], [Record_ID], [Pay_date], [Pay_Sum_amount], [Pay_status], [UserID]) VALUES (N'dbd69ded-c777-4a60-a77a-4fd727820407', N'8287586e-65b5-409f-92a8-cbe7ea634265', NULL, CAST(N'2019-09-14T01:07:14.747' AS DateTime), CAST(990.00 AS Decimal(10, 2)), N'CAA27F61-673E-45A8-8FEF-A83945CBFD80', N'992dffdd-ac3f-4d06-bc43-e5849f80d1fb')
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'0d6bbcc1-9bd3-4122-909c-b79dd53fcbac', N'94d05123-c268-4be8-9bd6-183c92f13114', N'ค่าน้ำปะปา เดือน ตุลาคม ใช้น้ำปะปา0 หน่วย', CAST(120.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'1f861cdf-b45d-49d9-9bcd-d4e2ce6c7646', N'691557c1-7df5-4a89-a202-5a125057a939', N'ค่าห้องพัก เดือนธันวาคม', CAST(4000.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'34ca04d9-4b1d-479f-ace2-57d60dcba8f2', N'691557c1-7df5-4a89-a202-5a125057a939', N'ค่าไฟฟ้า เดือนธันวาคม มิเตอร์ไฟฟ้า 114 ถึง 125 ใช้ไฟไป 11 หน่วย', CAST(77.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'3e49c949-e70b-46d3-b4f3-2fa7ebcaafdf', N'94d05123-c268-4be8-9bd6-183c92f13114', N'ค่าไฟฟ้า เดือนตุลาคม มิเตอร์ไฟฟ้า 0 ถึง 100 ใช้ไฟไป 100 หน่วย', CAST(700.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'400c4e1a-21c1-4040-a1a0-1d700fcf6ff3', N'82fe27bd-e720-4a71-ab72-35060fcd034c', N'ค่าห้องพัก เดือนตุลาคม', CAST(4000.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'488b6044-0019-44bc-a468-c8f6be3de4bb', N'3f4c8f98-4e16-46d0-845c-cec02a04de87', N'ค่าน้ำปะปา เดือน พฤศจิกายน ใช้น้ำปะปา97 หน่วย', CAST(360.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'6caa64d9-296d-4faf-a566-cf214400571d', N'922ebfd6-97f0-4472-ad88-2bc786f73cfc', N'ค่าน้ำปะปา เดือน พฤศจิกายน ใช้น้ำปะปา100 หน่วย', CAST(240.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'75f342f4-df46-4d2c-96d4-fce11fd0844e', N'691557c1-7df5-4a89-a202-5a125057a939', N'ค่าน้ำปะปา เดือน ธันวาคม ใช้น้ำปะปา114 หน่วย', CAST(360.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'84e90762-c27b-4f16-bfe3-b0d830daffad', N'5454eb44-dcf6-489f-aab7-9c9d81c54e10', N'ค่าห้องพัก เดือนธันวาคม', CAST(4000.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'8d732c31-a5ca-4273-81f6-679479032edd', N'922ebfd6-97f0-4472-ad88-2bc786f73cfc', N'ค่าไฟฟ้า เดือนพฤศจิกายน มิเตอร์ไฟฟ้า 100 ถึง 150 ใช้ไฟไป 50 หน่วย', CAST(350.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'915efc66-c3e2-4225-aa2f-ff591eb17f2b', N'5454eb44-dcf6-489f-aab7-9c9d81c54e10', N'ค่าน้ำปะปา เดือน ธันวาคม ใช้น้ำปะปา150 หน่วย', CAST(600.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'ad472a6c-d462-4cd7-8884-b4c23ad365c0', N'82fe27bd-e720-4a71-ab72-35060fcd034c', N'ค่าน้ำปะปา เดือน ตุลาคม ใช้น้ำปะปา0 หน่วย', CAST(120.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'b48d9d7f-1c8e-4777-8cfc-6292f8b9fc28', N'3f4c8f98-4e16-46d0-845c-cec02a04de87', N'ค่าไฟฟ้า เดือนพฤศจิกายน มิเตอร์ไฟฟ้า 97 ถึง 114 ใช้ไฟไป 17 หน่วย', CAST(119.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'b99c6f16-1c54-4cc0-bee0-07548b92c91c', N'922ebfd6-97f0-4472-ad88-2bc786f73cfc', N'ค่าห้องพัก เดือนพฤศจิกายน', CAST(4000.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'cd0d6561-fca2-4cde-9912-ed970b0b28b8', N'82fe27bd-e720-4a71-ab72-35060fcd034c', N'ค่าไฟฟ้า เดือนตุลาคม มิเตอร์ไฟฟ้า 0 ถึง 97 ใช้ไฟไป 97 หน่วย', CAST(679.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'dc617f12-86f4-44f5-b4f9-0d7ae1186dc6', N'5454eb44-dcf6-489f-aab7-9c9d81c54e10', N'ค่าไฟฟ้า เดือนธันวาคม มิเตอร์ไฟฟ้า 150 ถึง 199 ใช้ไฟไป 49 หน่วย', CAST(343.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'ec03eaf7-920b-4af4-8068-b42f5cd45f36', N'9c118c60-17a0-4d00-b350-8a7655259bad', N'ค่าห้องพัก', CAST(2100.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'f00f92f5-adf7-43b7-8c2d-283f13cda30f', N'dbd69ded-c777-4a60-a77a-4fd727820407', N'ค่าห้องพัก', CAST(990.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'f3ca36e2-b097-4493-9fdc-a4a2d9a0a0f5', N'3f4c8f98-4e16-46d0-845c-cec02a04de87', N'ค่าห้องพัก เดือนพฤศจิกายน', CAST(4000.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblPaymentDT] ([PayDT_ID], [Pay_ID], [Detail], [Amount]) VALUES (N'ff1c3dc9-14f4-40a5-a349-502a30970113', N'94d05123-c268-4be8-9bd6-183c92f13114', N'ค่าห้องพัก เดือนตุลาคม', CAST(4000.00 AS Decimal(10, 2)))
GO
INSERT [dbo].[tblRecord] ([Record_ID], [Year], [Month], [RecordStatus]) VALUES (N'9d06e21b-628f-49d9-b1a2-ff28e434e804', N'2562', N'พฤศจิกายน', N'69093347-B007-409A-8D86-6B9D44F1D990')
GO
INSERT [dbo].[tblRecord] ([Record_ID], [Year], [Month], [RecordStatus]) VALUES (N'cacd07ff-0267-4b58-944e-4e7097fd75b4', N'2562', N'ตุลาคม', N'69093347-B007-409A-8D86-6B9D44F1D990')
GO
INSERT [dbo].[tblRecord] ([Record_ID], [Year], [Month], [RecordStatus]) VALUES (N'f3cd6a29-efaf-4823-8c88-804338cdf7ea', N'2562', N'ธันวาคม', N'69093347-B007-409A-8D86-6B9D44F1D990')
GO
INSERT [dbo].[tblRecordDT] ([RecordDT_ID], [Record_ID], [Contract_ID], [Num_Water], [Before_Power], [Num_Power], [Record_water], [Record_power], [Record_date]) VALUES (N'074ec67c-8cba-468f-b0a8-0126f387f9f0', N'9d06e21b-628f-49d9-b1a2-ff28e434e804', N'635d003c-8357-4332-8ece-130e687ec38f', 2, 100, 150, 120, 7, CAST(N'2019-09-14T01:04:05.633' AS DateTime))
GO
INSERT [dbo].[tblRecordDT] ([RecordDT_ID], [Record_ID], [Contract_ID], [Num_Water], [Before_Power], [Num_Power], [Record_water], [Record_power], [Record_date]) VALUES (N'400f33e5-b0aa-440f-acfa-ee231ec13002', N'cacd07ff-0267-4b58-944e-4e7097fd75b4', N'817cf5f7-c666-49b3-97e9-2c39af01c151', 1, 0, 97, 120, 7, CAST(N'2019-09-13T23:47:07.393' AS DateTime))
GO
INSERT [dbo].[tblRecordDT] ([RecordDT_ID], [Record_ID], [Contract_ID], [Num_Water], [Before_Power], [Num_Power], [Record_water], [Record_power], [Record_date]) VALUES (N'7cd00488-178b-454e-852c-169deb12359e', N'cacd07ff-0267-4b58-944e-4e7097fd75b4', N'635d003c-8357-4332-8ece-130e687ec38f', 1, 0, 100, 120, 7, CAST(N'2019-09-13T23:47:03.123' AS DateTime))
GO
INSERT [dbo].[tblRecordDT] ([RecordDT_ID], [Record_ID], [Contract_ID], [Num_Water], [Before_Power], [Num_Power], [Record_water], [Record_power], [Record_date]) VALUES (N'ae84ddea-3eb3-4e05-b8c5-4059cdb51e77', N'f3cd6a29-efaf-4823-8c88-804338cdf7ea', N'635d003c-8357-4332-8ece-130e687ec38f', 5, 150, 199, 120, 7, CAST(N'2019-09-14T01:06:33.687' AS DateTime))
GO
INSERT [dbo].[tblRecordDT] ([RecordDT_ID], [Record_ID], [Contract_ID], [Num_Water], [Before_Power], [Num_Power], [Record_water], [Record_power], [Record_date]) VALUES (N'bbb784f8-4c65-44e7-ad84-d6c7b67d24f5', N'f3cd6a29-efaf-4823-8c88-804338cdf7ea', N'817cf5f7-c666-49b3-97e9-2c39af01c151', 3, 114, 125, 120, 7, CAST(N'2019-09-14T01:06:33.687' AS DateTime))
GO
INSERT [dbo].[tblRecordDT] ([RecordDT_ID], [Record_ID], [Contract_ID], [Num_Water], [Before_Power], [Num_Power], [Record_water], [Record_power], [Record_date]) VALUES (N'c9087364-0527-4ebc-98e7-6e651d17ebd2', N'9d06e21b-628f-49d9-b1a2-ff28e434e804', N'817cf5f7-c666-49b3-97e9-2c39af01c151', 3, 97, 114, 120, 7, CAST(N'2019-09-14T01:04:05.633' AS DateTime))
GO
INSERT [dbo].[tblRenter] ([Renter_ID], [Renter_TitleName], [Renter_Name], [Renter_Lastname], [Renter_Nationality], [Renter_Card], [Renter_Address], [Renter_Tel], [Renter_Status], [Renter_Remark]) VALUES (N'069b533a-644e-45b6-aaee-359c29c8036e', N'นาย', N'กฤณ', N'ประวิงรัตน', N'ไทย', N'222222222228', N'4/1309-1310 ถ.นวมินทร์เขต คลองกลุ่ม กรงุ เทพ 10230
', N'081-6413340', NULL, N'')
GO
INSERT [dbo].[tblRenter] ([Renter_ID], [Renter_TitleName], [Renter_Name], [Renter_Lastname], [Renter_Nationality], [Renter_Card], [Renter_Address], [Renter_Tel], [Renter_Status], [Renter_Remark]) VALUES (N'60ca86b9-77d3-4931-80cc-dbab3806a219', N'นางสาว', N'ลลิดา', N'บุญมี ', N'ไทย', N'6222115842712', N'61/1 ถ.สุขาอุปถมั ภ์ซ.9 อ.เมือง จ.อุบลราชธานี34000', N'081-5483918', NULL, N'')
GO
INSERT [dbo].[tblRenter] ([Renter_ID], [Renter_TitleName], [Renter_Name], [Renter_Lastname], [Renter_Nationality], [Renter_Card], [Renter_Address], [Renter_Tel], [Renter_Status], [Renter_Remark]) VALUES (N'8ae15318-155b-47ce-8f8a-a02e580775f1', N'นางสาว', N'แก้วกนก ', N'สุดจรงิ ', N'ไทย', N'7439957071053', N'641/126 ซ.ประปา 3 ต.ในเมือง อ.บ้านไผ่ จ.ขอนแก่น', N'089-7147156', NULL, N'')
GO
INSERT [dbo].[tblRenter] ([Renter_ID], [Renter_TitleName], [Renter_Name], [Renter_Lastname], [Renter_Nationality], [Renter_Card], [Renter_Address], [Renter_Tel], [Renter_Status], [Renter_Remark]) VALUES (N'96691dd2-d1ed-4988-ac18-c21db63e8923', N'นางสาว', N'น้้าทิพย์', N'ประเสรฐิช่วง', N'ไทย', N'2374912938304', N'95/170 Noble House Phayathai,
พญาไท ราชเทวี กทม. 10400
', N'089-7109774', NULL, N'')
GO
INSERT [dbo].[tblRenter] ([Renter_ID], [Renter_TitleName], [Renter_Name], [Renter_Lastname], [Renter_Nationality], [Renter_Card], [Renter_Address], [Renter_Tel], [Renter_Status], [Renter_Remark]) VALUES (N'b594d00c-02f0-4899-a10e-2f0caa04b624', N'นาย', N'ณรงค์ฤทธิ์ ', N'แสงกล้า', N'ไทย', N'111111111119', N'197/6 ถ.อุดรดุษฎีต.หมากแข้ง อ.เมือง จ.อุดรธานี14100', N'087-9917940', NULL, N'')
GO
INSERT [dbo].[tblRoom] ([Room_ID], [Room_number], [Room_floor], [Room_Type], [Room_Price_daily], [Room_Price_monthly], [Room_status], [Room_MetersNo], [Room_Remark]) VALUES (N'4b5ed133-8aa5-42cd-a1cc-29d0291a6f46', N'A004', N'1', N'FA9E4E48-C2FC-463E-A1CE-7B64825C047B', CAST(900.00 AS Decimal(10, 2)), CAST(4000.00 AS Decimal(10, 2)), N'A6DEF890-61C9-44A3-91DD-DBA3BBE98327', N'0         ', N'          ')
GO
INSERT [dbo].[tblRoom] ([Room_ID], [Room_number], [Room_floor], [Room_Type], [Room_Price_daily], [Room_Price_monthly], [Room_status], [Room_MetersNo], [Room_Remark]) VALUES (N'5316a831-bb89-4280-9242-7eb435dd41a7', N'B002', N'2', N'FA9E4E48-C2FC-463E-A1CE-7B64825C047B', CAST(950.00 AS Decimal(10, 2)), CAST(4000.00 AS Decimal(10, 2)), N'395D77F2-9D91-40D6-82E7-3F9DB1E498DE', N'125       ', N'          ')
GO
INSERT [dbo].[tblRoom] ([Room_ID], [Room_number], [Room_floor], [Room_Type], [Room_Price_daily], [Room_Price_monthly], [Room_status], [Room_MetersNo], [Room_Remark]) VALUES (N'73eba7a0-cc9d-470d-aed7-0d401a100410', N'A003', N'1', N'FA9E4E48-C2FC-463E-A1CE-7B64825C047B', CAST(900.00 AS Decimal(10, 2)), CAST(4000.00 AS Decimal(10, 2)), N'A6DEF890-61C9-44A3-91DD-DBA3BBE98327', N'0         ', N'          ')
GO
INSERT [dbo].[tblRoom] ([Room_ID], [Room_number], [Room_floor], [Room_Type], [Room_Price_daily], [Room_Price_monthly], [Room_status], [Room_MetersNo], [Room_Remark]) VALUES (N'7db7c77e-0be4-441c-9f73-9390ea339ef1', N'A002', N'1', N'C3F38F56-8CD0-4ACC-BBD4-97845CEABF28', CAST(550.00 AS Decimal(10, 2)), CAST(3000.00 AS Decimal(10, 2)), N'A6DEF890-61C9-44A3-91DD-DBA3BBE98327', N'0         ', N'          ')
GO
INSERT [dbo].[tblRoom] ([Room_ID], [Room_number], [Room_floor], [Room_Type], [Room_Price_daily], [Room_Price_monthly], [Room_status], [Room_MetersNo], [Room_Remark]) VALUES (N'a54c54d3-5c13-4a67-b9dd-0ddf4fc229b0', N'B001', N'2', N'FA9E4E48-C2FC-463E-A1CE-7B64825C047B', CAST(950.00 AS Decimal(10, 2)), CAST(4000.00 AS Decimal(10, 2)), N'395D77F2-9D91-40D6-82E7-3F9DB1E498DE', N'199       ', N'          ')
GO
INSERT [dbo].[tblRoom] ([Room_ID], [Room_number], [Room_floor], [Room_Type], [Room_Price_daily], [Room_Price_monthly], [Room_status], [Room_MetersNo], [Room_Remark]) VALUES (N'de2778a1-c803-4bce-851b-3008daa97157', N'A001', N'1', N'C3F38F56-8CD0-4ACC-BBD4-97845CEABF28', CAST(500.00 AS Decimal(10, 2)), CAST(3000.00 AS Decimal(10, 2)), N'A6DEF890-61C9-44A3-91DD-DBA3BBE98327', N'0         ', N'          ')
GO
INSERT [dbo].[tblStatus] ([StatusID], [Name], [StatusType]) VALUES (N'01957AB2-0751-49A8-87DD-3471DFA47145', N'มัดจำ', N'ContractStatus')
GO
INSERT [dbo].[tblStatus] ([StatusID], [Name], [StatusType]) VALUES (N'12F0398E-0197-466C-9D76-171E9C4CAC4A', N'รายเดือน', N'ContractType')
GO
INSERT [dbo].[tblStatus] ([StatusID], [Name], [StatusType]) VALUES (N'2CF0938A-8352-4131-B798-1BC90BAEC19C', N'มัดจำ', N'RoomStatus')
GO
INSERT [dbo].[tblStatus] ([StatusID], [Name], [StatusType]) VALUES (N'395D77F2-9D91-40D6-82E7-3F9DB1E498DE', N'ไม่ว่าง', N'RoomStatus')
GO
INSERT [dbo].[tblStatus] ([StatusID], [Name], [StatusType]) VALUES (N'5E6D9764-AFA4-4363-A08A-116A0C997414', N'เข้าพัก', N'ContractStatus')
GO
INSERT [dbo].[tblStatus] ([StatusID], [Name], [StatusType]) VALUES (N'69093347-B007-409A-8D86-6B9D44F1D990', N'โพสเพื่อชำระ', N'RecordStatus')
GO
INSERT [dbo].[tblStatus] ([StatusID], [Name], [StatusType]) VALUES (N'A6DEF890-61C9-44A3-91DD-DBA3BBE98327', N'ว่าง', N'RoomStatus')
GO
INSERT [dbo].[tblStatus] ([StatusID], [Name], [StatusType]) VALUES (N'C3A9B05E-7151-488E-99C6-5EBA38A3BB5D', N'หมดสัญญา', N'ContractStatus')
GO
INSERT [dbo].[tblStatus] ([StatusID], [Name], [StatusType]) VALUES (N'C3F38F56-8CD0-4ACC-BBD4-97845CEABF28', N'ห้องพัดลม', N'RoomType')
GO
INSERT [dbo].[tblStatus] ([StatusID], [Name], [StatusType]) VALUES (N'C42C5738-A1C1-4719-8F8C-DE3A2B8BF887', N'ค้างชำระ', N'PaymentStatus')
GO
INSERT [dbo].[tblStatus] ([StatusID], [Name], [StatusType]) VALUES (N'CAA27F61-673E-45A8-8FEF-A83945CBFD80', N'ชำระเรียบร้อย', N'PaymentStatus')
GO
INSERT [dbo].[tblStatus] ([StatusID], [Name], [StatusType]) VALUES (N'ED7BF5C4-C1E0-42D9-AEEF-62D2FE39D882', N'บันทึกแล้วเรียบ', N'RecordStatus')
GO
INSERT [dbo].[tblStatus] ([StatusID], [Name], [StatusType]) VALUES (N'F540A7D1-B1E6-4F65-9645-A08EDC6BD3A1', N'รายวัน', N'ContractType')
GO
INSERT [dbo].[tblStatus] ([StatusID], [Name], [StatusType]) VALUES (N'FA9E4E48-C2FC-463E-A1CE-7B64825C047B', N'ห้องแอร์', N'RoomType')
GO
INSERT [dbo].[tblUser] ([UserID], [Username], [User_name], [User_password], [User_type]) VALUES (N'992dffdd-ac3f-4d06-bc43-e5849f80d1fb', N'admin', N'Admin', N'1', NULL)
GO
ALTER TABLE [dbo].[tblContract]  WITH CHECK ADD  CONSTRAINT [FK_tblContract_tblRenter] FOREIGN KEY([Renter_ID])
REFERENCES [dbo].[tblRenter] ([Renter_ID])
GO
ALTER TABLE [dbo].[tblContract] CHECK CONSTRAINT [FK_tblContract_tblRenter]
GO
ALTER TABLE [dbo].[tblPayment]  WITH CHECK ADD  CONSTRAINT [FK_tblPayment_tblContract] FOREIGN KEY([Contract_ID])
REFERENCES [dbo].[tblContract] ([Contract_ID])
GO
ALTER TABLE [dbo].[tblPayment] CHECK CONSTRAINT [FK_tblPayment_tblContract]
GO
ALTER TABLE [dbo].[tblPayment]  WITH CHECK ADD  CONSTRAINT [FK_tblPayment_tblRecord] FOREIGN KEY([Record_ID])
REFERENCES [dbo].[tblRecord] ([Record_ID])
GO
ALTER TABLE [dbo].[tblPayment] CHECK CONSTRAINT [FK_tblPayment_tblRecord]
GO
ALTER TABLE [dbo].[tblPayment]  WITH CHECK ADD  CONSTRAINT [FK_tblPayment_tblUser] FOREIGN KEY([UserID])
REFERENCES [dbo].[tblUser] ([UserID])
GO
ALTER TABLE [dbo].[tblPayment] CHECK CONSTRAINT [FK_tblPayment_tblUser]
GO
ALTER TABLE [dbo].[tblPaymentDT]  WITH CHECK ADD  CONSTRAINT [FK_tblPaymentDT_tblPaymentDT] FOREIGN KEY([Pay_ID])
REFERENCES [dbo].[tblPayment] ([Pay_ID])
GO
ALTER TABLE [dbo].[tblPaymentDT] CHECK CONSTRAINT [FK_tblPaymentDT_tblPaymentDT]
GO
ALTER TABLE [dbo].[tblRecordDT]  WITH CHECK ADD  CONSTRAINT [FK_tblRecordDT_tblContract] FOREIGN KEY([Contract_ID])
REFERENCES [dbo].[tblContract] ([Contract_ID])
GO
ALTER TABLE [dbo].[tblRecordDT] CHECK CONSTRAINT [FK_tblRecordDT_tblContract]
GO
ALTER TABLE [dbo].[tblRecordDT]  WITH CHECK ADD  CONSTRAINT [FK_tblRecordDT_tblRecord] FOREIGN KEY([Record_ID])
REFERENCES [dbo].[tblRecord] ([Record_ID])
GO
ALTER TABLE [dbo].[tblRecordDT] CHECK CONSTRAINT [FK_tblRecordDT_tblRecord]
GO
