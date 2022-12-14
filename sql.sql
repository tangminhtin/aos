
USE [master]
GO
/****** Object:  Database [emmahop]    Script Date: 5/7/2022 11:27:20 PM ******/
CREATE DATABASE [emmahop]
GO
ALTER DATABASE [emmahop] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [emmahop] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [emmahop] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [emmahop] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [emmahop] SET ARITHABORT OFF 
GO
ALTER DATABASE [emmahop] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [emmahop] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [emmahop] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [emmahop] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [emmahop] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [emmahop] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [emmahop] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [emmahop] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [emmahop] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [emmahop] SET  DISABLE_BROKER 
GO
ALTER DATABASE [emmahop] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [emmahop] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [emmahop] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [emmahop] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [emmahop] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [emmahop] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [emmahop] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [emmahop] SET RECOVERY FULL 
GO
ALTER DATABASE [emmahop] SET  MULTI_USER 
GO
ALTER DATABASE [emmahop] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [emmahop] SET DB_CHAINING OFF 
GO
ALTER DATABASE [emmahop] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [emmahop] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [emmahop] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [emmahop] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'emmahop', N'ON'
GO
ALTER DATABASE [emmahop] SET QUERY_STORE = OFF
GO
USE [emmahop]
GO
/****** Object:  Table [dbo].[brand]    Script Date: 5/7/2022 11:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[brand](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tilte] [nvarchar](255) NULL,
 CONSTRAINT [PK_brand] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Color]    Script Date: 5/7/2022 11:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Color](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Color] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Credentials]    Script Date: 5/7/2022 11:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Credentials](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[RoleID] [nvarchar](50) NULL,
	[PermissionID] [nvarchar](50) NULL,
 CONSTRAINT [PK_Credentials] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[donation]    Script Date: 5/7/2022 11:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[donation](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[name] [nchar](50) NOT NULL,
	[description] [nchar](50) NOT NULL,
	[phone] [nchar](50) NOT NULL,
	[organizationName] [nchar](50) NOT NULL,
	[imageUrl] [nchar](50) NOT NULL,
	[startDay] [date] NOT NULL,
	[endDay] [date] NOT NULL,
	[status] [int] NOT NULL,
 CONSTRAINT [PK_donation] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order]    Script Date: 5/7/2022 11:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[order_id] [nvarchar](50) NOT NULL,
	[user_id] [int] NOT NULL,
	[total_price] [float] NOT NULL,
	[create_at] [datetime] NOT NULL,
	[voucher_id] [int] NULL,
	[status] [int] NULL,
	[note] [nvarchar](200) NULL,
 CONSTRAINT [PK_order] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[order_details]    Script Date: 5/7/2022 11:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[order_details](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NULL,
	[order_id] [int] NULL,
	[quantity] [int] NULL,
	[price] [float] NULL,
 CONSTRAINT [PK_order_detalis] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Permission]    Script Date: 5/7/2022 11:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Permission](
	[id] [nvarchar](50) NOT NULL,
	[title] [nvarchar](50) NULL,
 CONSTRAINT [PK_Permission] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[product]    Script Date: 5/7/2022 11:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[product](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_code] [nvarchar](50) NOT NULL,
	[product_name] [nvarchar](255) NOT NULL,
	[product_type] [int] NOT NULL,
	[product_color] [int] NOT NULL,
	[product_quantity] [int] NOT NULL,
	[product_brand] [int] NOT NULL,
	[product_image] [nvarchar](max) NOT NULL,
	[product_size] [int] NOT NULL,
	[product_description] [nvarchar](max) NOT NULL,
	[out_price] [float] NOT NULL,
	[status] [int] NOT NULL,
	[product_spec] [nvarchar](max) NULL,
 CONSTRAINT [PK_product] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Role]    Script Date: 5/7/2022 11:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Role](
	[id] [nvarchar](50) NOT NULL,
	[title] [nvarchar](50) NULL,
 CONSTRAINT [PK_Role] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Size]    Script Date: 5/7/2022 11:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Size](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[title] [nvarchar](50) NULL,
 CONSTRAINT [PK_Size] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[type]    Script Date: 5/7/2022 11:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[type](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[tilte] [nvarchar](255) NULL,
 CONSTRAINT [PK_Type] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user]    Script Date: 5/7/2022 11:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[email] [nvarchar](50) NOT NULL,
	[password] [nvarchar](50) NOT NULL,
	[fullname] [nvarchar](255) NOT NULL,
	[phone] [nvarchar](10) NULL,
	[address] [nvarchar](255) NULL,
	[status] [int] NOT NULL,
	[RoleID] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_user] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[user_donation]    Script Date: 5/7/2022 11:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[user_donation](
	[user_id] [int] NOT NULL,
	[donation_id] [int] NOT NULL,
	[name] [nchar](50) NULL,
	[money] [float] NULL,
	[createAt] [datetime] NULL,
	[status] [nchar](10) NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[voucher]    Script Date: 5/7/2022 11:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[voucher](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[voucher_code] [nvarchar](255) NULL,
	[voucher_discount] [float] NULL,
	[voucher_description] [nvarchar](255) NULL,
	[create_at] [date] NULL,
	[delete_at] [date] NULL,
	[quantity] [int] NULL,
 CONSTRAINT [PK_voucher] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[warehouse]    Script Date: 5/7/2022 11:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[warehouse](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[import_code] [nvarchar](255) NOT NULL,
	[user_id] [int] NULL,
	[date_in] [datetime] NULL,
 CONSTRAINT [PK_warehouse] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[warehouse_detail]    Script Date: 5/7/2022 11:27:21 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[warehouse_detail](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[product_id] [int] NOT NULL,
	[in_price] [float] NULL,
	[quantity] [int] NOT NULL,
	[total_price] [float] NOT NULL,
	[date_in] [date] NOT NULL,
	[user_id] [int] NOT NULL,
 CONSTRAINT [PK_warehouse_detail] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[brand] ON 

INSERT [dbo].[brand] ([id], [tilte]) VALUES (1003, N'KG')
INSERT [dbo].[brand] ([id], [tilte]) VALUES (1004, N'Hộp')
SET IDENTITY_INSERT [dbo].[brand] OFF
GO
SET IDENTITY_INSERT [dbo].[Color] ON 

INSERT [dbo].[Color] ([id], [title]) VALUES (1, N'Hàn Quốc')
INSERT [dbo].[Color] ([id], [title]) VALUES (2, N'Việt Nam')
INSERT [dbo].[Color] ([id], [title]) VALUES (3, N'Trung Quốc')
INSERT [dbo].[Color] ([id], [title]) VALUES (1002, N'Ý')
SET IDENTITY_INSERT [dbo].[Color] OFF
GO
SET IDENTITY_INSERT [dbo].[Credentials] ON 

INSERT [dbo].[Credentials] ([id], [RoleID], [PermissionID]) VALUES (1, N'Admin', N'CREATE_BRAND')
INSERT [dbo].[Credentials] ([id], [RoleID], [PermissionID]) VALUES (2, N'Staff', N'CREATE_BRAND')
INSERT [dbo].[Credentials] ([id], [RoleID], [PermissionID]) VALUES (3, N'Staff', N'VIEW_ORDERS')
INSERT [dbo].[Credentials] ([id], [RoleID], [PermissionID]) VALUES (4, N'Staff', N'VIEW_PRODUCT')
SET IDENTITY_INSERT [dbo].[Credentials] OFF
GO
SET IDENTITY_INSERT [dbo].[order] ON 

INSERT [dbo].[order] ([id], [order_id], [user_id], [total_price], [create_at], [voucher_id], [status], [note]) VALUES (1, N'VoTVa', 2, 120000, CAST(N'2022-06-15T11:11:16.250' AS DateTime), NULL, 2, N'')
INSERT [dbo].[order] ([id], [order_id], [user_id], [total_price], [create_at], [voucher_id], [status], [note]) VALUES (2, N'l&bCG', 2, 43000, CAST(N'2022-04-27T23:53:50.190' AS DateTime), NULL, 3, N'')
INSERT [dbo].[order] ([id], [order_id], [user_id], [total_price], [create_at], [voucher_id], [status], [note]) VALUES (3, N'153Uq', 2, 86000, CAST(N'2022-04-29T20:15:42.433' AS DateTime), NULL, 3, N'')
INSERT [dbo].[order] ([id], [order_id], [user_id], [total_price], [create_at], [voucher_id], [status], [note]) VALUES (4, N'4JaoH', 2, 1, CAST(N'2022-06-05T20:04:55.050' AS DateTime), NULL, 2, N'')
INSERT [dbo].[order] ([id], [order_id], [user_id], [total_price], [create_at], [voucher_id], [status], [note]) VALUES (5, N'36Cpi', 2, 215000, CAST(N'2022-06-05T22:50:03.297' AS DateTime), NULL, 1, NULL)
SET IDENTITY_INSERT [dbo].[order] OFF
GO
SET IDENTITY_INSERT [dbo].[order_details] ON 

INSERT [dbo].[order_details] ([id], [product_id], [order_id], [quantity], [price]) VALUES (1, 1005, 1, 2, 43000)
INSERT [dbo].[order_details] ([id], [product_id], [order_id], [quantity], [price]) VALUES (2, 1006, 1, 1, 34000)
INSERT [dbo].[order_details] ([id], [product_id], [order_id], [quantity], [price]) VALUES (3, 1005, 2, 1, 43000)
INSERT [dbo].[order_details] ([id], [product_id], [order_id], [quantity], [price]) VALUES (4, 1005, 3, 2, 43000)
INSERT [dbo].[order_details] ([id], [product_id], [order_id], [quantity], [price]) VALUES (5, 1009, 4, 1, 1)
INSERT [dbo].[order_details] ([id], [product_id], [order_id], [quantity], [price]) VALUES (6, 1007, 5, 1, 172000)
INSERT [dbo].[order_details] ([id], [product_id], [order_id], [quantity], [price]) VALUES (7, 1005, 5, 1, 43000)
SET IDENTITY_INSERT [dbo].[order_details] OFF
GO
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'CREATE_BRAND', N'tao moi hang')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'CREATE_COLORS', N'Tao mau')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'CREATE_ORDERDETAILS', N'Tao moi Order details')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'CREATE_PRODUCT', N'tao mo')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'CREATE_SIZES', N'tao size')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'CREATE_TYPES', N'tao type')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'DELETE_BRAND', N'Xoa Hang')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'DELETE_COLORS', N'Xoa mau')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'DELETE_ORDERDETAILS', N'Xoa order details')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'DELETE_PRODUCT', N'xoa')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'DELETE_SIZES', N'xoa size')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'DELETE_TYPES', N'xoa type')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'DELETE_USERS', N'xoa nguoi dung')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'DETAILS_BRAND', N'Chi tiet hang')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'DETAILS_COLORS', N'Chi tiet mau sac')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'DETAILS_ORDERDETAILS', N'Xem chi tiet ')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'DETAILS_ORDERS', N'Xem chi tiet don hang')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'DETAILS_PRODUCT', N'Chi tiet')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'DETAILS_SIZES', N'chi tiiet size')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'DETAILS_TYPES', N'Chi tiet san pham')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'EDIT_BRAND', N'sua san pham')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'EDIT_COLORS', N'sua mau')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'EDIT_ORDERDETAILS', N'Sua order details')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'EDIT_ORDERS', N'Sua order')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'EDIT_PRODUCT', N'sua')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'EDIT_SIZES', N'sua size')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'EDIT_TYPES', N'sua type')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'VIEW_BRAND', N'xem hang')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'VIEW_COLORS', N'Xem Mau Sac')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'VIEW_ORDERDETAILS', N'Xem Chi tiet don hang')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'VIEW_ORDERS', N'Xem order')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'VIEW_PRODUCT', N'Xem san pham')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'VIEW_SIZES', N'xem size')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'VIEW_TYPES', N'xem the loai')
INSERT [dbo].[Permission] ([id], [title]) VALUES (N'VIEW_USERS', N'xem nguoi dung')
GO
SET IDENTITY_INSERT [dbo].[product] ON 

INSERT [dbo].[product] ([id], [product_code], [product_name], [product_type], [product_color], [product_quantity], [product_brand], [product_image], [product_size], [product_description], [out_price], [status], [product_spec]) VALUES (1005, N'FBKn', N'CÀ CHUA BĂM CIRIO 400G', 1011, 1002, 18, 1004, N'43d626dc-ee58-476a-a506-a1c9e25571a0_ca-chua-bam-cirio-chopped-tomato-hop-400g_9bfab29961744ce5999d639e238bb931_large.jpg ', 2, N'Cà Chua Băm Cirio được sản xuất từ những trái cà chua tươi ngon, được bổ sung nước ép cà chua cho vị thêm đậm đà, giữ nguyên vị ngọt đặc trưng và thơm ngon tự nhiên của cà chua.   Cà chua rất giàu vitamin A, C, K, vitamin B6, kali, folate, thiamin, magiê, niacin, đồng và phốt pho, là những vi chất cần thiết để duy trì một sức khỏe tốt.  Cách dùng: Rất thích hợp để chế biến các món sốt, súp và món nướng. ', 43000, 1, NULL)
INSERT [dbo].[product] ([id], [product_code], [product_name], [product_type], [product_color], [product_quantity], [product_brand], [product_image], [product_size], [product_description], [out_price], [status], [product_spec]) VALUES (1006, N'aayQ1', N'ĐẬU GÀ ĐÓNG HỘP CONTEL 400G', 1011, 1002, 16, 1004, N'3c441d45-d7f5-4052-947d-e392841cd384_slide2.png ', 2, N'Đậu gà Contel được sản xuất theo công nghệ hiện đại, mọi khâu từ tuyển chọn nguyên liệu tới chế biến, đóng bao bì đều diễn ra khép kín dưới sự giám sát và kiểm tra nghiêm ngặt. Sản phẩm không chứa hóa chất, chất bảo quản độc hại, đảm bảo an toàn cho sức khỏe người tiêu dùng. Sản phẩm có hương vị thơm ngon của những nguyên liệu tự nhiên được chọn lọc kỹ càng.', 34000, 1, NULL)
INSERT [dbo].[product] ([id], [product_code], [product_name], [product_type], [product_color], [product_quantity], [product_brand], [product_image], [product_size], [product_description], [out_price], [status], [product_spec]) VALUES (1007, N'HxH9', N'SƯỜN HEO NON FAU 400G', 1002, 2, 57, 1003, N'a88490d5-9581-49df-9ae4-ae848ac320e9_suon-non-heo-huu-co-fau_large.webp ', 2, N'Thịt heo hữu cơ FAU là sản phẩm không có thuốc, kháng sinh, hormon, chất kích thích tăng trưởng... heo được ăn thức ăn hữu cơ (Selen hữu cơ khoáng hữu cơ và các hạt ngũ cốc) và được uống nước sạch.', 172000, 1, N' ')
INSERT [dbo].[product] ([id], [product_code], [product_name], [product_type], [product_color], [product_quantity], [product_brand], [product_image], [product_size], [product_description], [out_price], [status], [product_spec]) VALUES (1009, N'HHM', N'www', 1002, 1, 0, 1003, N'dd14c80a-becc-4cdd-ad70-3cb87d334e62_lavabocotu.jpg ', 1, N'1', 1, 1, NULL)
SET IDENTITY_INSERT [dbo].[product] OFF
GO
INSERT [dbo].[Role] ([id], [title]) VALUES (N'Admin', NULL)
INSERT [dbo].[Role] ([id], [title]) VALUES (N'Customer', NULL)
INSERT [dbo].[Role] ([id], [title]) VALUES (N'Staff', N'Nhan vien')
GO
SET IDENTITY_INSERT [dbo].[Size] ON 

INSERT [dbo].[Size] ([id], [title]) VALUES (1, N'SUNI GREEN FARM')
INSERT [dbo].[Size] ([id], [title]) VALUES (2, N'Thực phẩm Hoàng Đông')
INSERT [dbo].[Size] ([id], [title]) VALUES (1002, N'Gia Vị Nhật Bản Wine Food')
SET IDENTITY_INSERT [dbo].[Size] OFF
GO
SET IDENTITY_INSERT [dbo].[type] ON 

INSERT [dbo].[type] ([id], [tilte]) VALUES (1002, N'Thịt heo')
INSERT [dbo].[type] ([id], [tilte]) VALUES (1003, N'Thịt bò')
INSERT [dbo].[type] ([id], [tilte]) VALUES (1004, N'Cá')
INSERT [dbo].[type] ([id], [tilte]) VALUES (1005, N'Thủy hải sản')
INSERT [dbo].[type] ([id], [tilte]) VALUES (1006, N'Rau củ quả')
INSERT [dbo].[type] ([id], [tilte]) VALUES (1007, N'Trái cây')
INSERT [dbo].[type] ([id], [tilte]) VALUES (1008, N'Gia vị')
INSERT [dbo].[type] ([id], [tilte]) VALUES (1009, N'Sản phẩm khô')
INSERT [dbo].[type] ([id], [tilte]) VALUES (1010, N'Gạo')
INSERT [dbo].[type] ([id], [tilte]) VALUES (1011, N'Thực phẩm đóng hộp')
SET IDENTITY_INSERT [dbo].[type] OFF
GO
SET IDENTITY_INSERT [dbo].[user] ON 

INSERT [dbo].[user] ([id], [email], [password], [fullname], [phone], [address], [status], [RoleID]) VALUES (1, N'admin@admin', N'admin', N'admin', N'1', N'1', 1, N'Admin')
INSERT [dbo].[user] ([id], [email], [password], [fullname], [phone], [address], [status], [RoleID]) VALUES (2, N'lonhvo@gmail.com', N'1', N'long', N'0392221200', N'can tho', 1, N'Customer')
INSERT [dbo].[user] ([id], [email], [password], [fullname], [phone], [address], [status], [RoleID]) VALUES (3, N'crrttz@gmail.com', N'CZMk6qxE', N'Nguyen Huu Ly', N'0123456789', N'Can Tho', 1, N'Admin')
INSERT [dbo].[user] ([id], [email], [password], [fullname], [phone], [address], [status], [RoleID]) VALUES (4, N'lynhce140219@fpt.edu.vn', N'76xkZ5Tr', N'Nguyen Huu Ly', N'0123456789', N'Can Tho', 1, N'Staff')
SET IDENTITY_INSERT [dbo].[user] OFF
GO
ALTER TABLE [dbo].[Credentials]  WITH CHECK ADD  CONSTRAINT [FK_Credentials_Permission] FOREIGN KEY([PermissionID])
REFERENCES [dbo].[Permission] ([id])
GO
ALTER TABLE [dbo].[Credentials] CHECK CONSTRAINT [FK_Credentials_Permission]
GO
ALTER TABLE [dbo].[Credentials]  WITH CHECK ADD  CONSTRAINT [FK_Credentials_Role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([id])
GO
ALTER TABLE [dbo].[Credentials] CHECK CONSTRAINT [FK_Credentials_Role]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_order_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_order_user]
GO
ALTER TABLE [dbo].[order]  WITH CHECK ADD  CONSTRAINT [FK_order_voucher] FOREIGN KEY([voucher_id])
REFERENCES [dbo].[voucher] ([id])
GO
ALTER TABLE [dbo].[order] CHECK CONSTRAINT [FK_order_voucher]
GO
ALTER TABLE [dbo].[order_details]  WITH CHECK ADD  CONSTRAINT [FK_order_detalis_order] FOREIGN KEY([order_id])
REFERENCES [dbo].[order] ([id])
GO
ALTER TABLE [dbo].[order_details] CHECK CONSTRAINT [FK_order_detalis_order]
GO
ALTER TABLE [dbo].[order_details]  WITH CHECK ADD  CONSTRAINT [FK_order_detalis_product] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([id])
GO
ALTER TABLE [dbo].[order_details] CHECK CONSTRAINT [FK_order_detalis_product]
GO
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_brand] FOREIGN KEY([product_brand])
REFERENCES [dbo].[brand] ([id])
GO
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_brand]
GO
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_Color] FOREIGN KEY([product_color])
REFERENCES [dbo].[Color] ([id])
GO
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_Color]
GO
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_Size] FOREIGN KEY([product_size])
REFERENCES [dbo].[Size] ([id])
GO
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_Size]
GO
ALTER TABLE [dbo].[product]  WITH CHECK ADD  CONSTRAINT [FK_product_type] FOREIGN KEY([product_type])
REFERENCES [dbo].[type] ([id])
GO
ALTER TABLE [dbo].[product] CHECK CONSTRAINT [FK_product_type]
GO
ALTER TABLE [dbo].[user]  WITH CHECK ADD  CONSTRAINT [FK_user_role] FOREIGN KEY([RoleID])
REFERENCES [dbo].[Role] ([id])
GO
ALTER TABLE [dbo].[user] CHECK CONSTRAINT [FK_user_role]
GO
ALTER TABLE [dbo].[user_donation]  WITH CHECK ADD  CONSTRAINT [FK_user_donation_donation] FOREIGN KEY([donation_id])
REFERENCES [dbo].[donation] ([id])
GO
ALTER TABLE [dbo].[user_donation] CHECK CONSTRAINT [FK_user_donation_donation]
GO
ALTER TABLE [dbo].[warehouse]  WITH CHECK ADD  CONSTRAINT [FK_warehouse_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[warehouse] CHECK CONSTRAINT [FK_warehouse_user]
GO
ALTER TABLE [dbo].[warehouse_detail]  WITH CHECK ADD  CONSTRAINT [FK_warehouse_detail_product] FOREIGN KEY([product_id])
REFERENCES [dbo].[product] ([id])
GO
ALTER TABLE [dbo].[warehouse_detail] CHECK CONSTRAINT [FK_warehouse_detail_product]
GO
ALTER TABLE [dbo].[warehouse_detail]  WITH CHECK ADD  CONSTRAINT [FK_warehouse_detail_user] FOREIGN KEY([user_id])
REFERENCES [dbo].[user] ([id])
GO
ALTER TABLE [dbo].[warehouse_detail] CHECK CONSTRAINT [FK_warehouse_detail_user]
GO
USE [master]
GO
ALTER DATABASE [emmahop] SET  READ_WRITE 
GO
