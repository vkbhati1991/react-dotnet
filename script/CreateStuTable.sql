USE [sms]
GO

/****** Object:  Table [dbo].[students]    Script Date: 31-05-2020 13:47:10 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET ANSI_PADDING ON
GO

CREATE TABLE [dbo].[students](
	[StudentId] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [varchar](100) NULL,
	[MiddleName] [varchar](100) NULL,
	[LastName] [varchar](100) NULL,
	[Email] [varchar](200) NOT NULL,
	[UserName] [varchar](200) NULL,
	[Password] [varchar](200) NULL,
	[Phone] [varchar](100) NULL,
	[DOB] [date] NULL,
	[DobInText] [varchar](100) NULL,
	[Gender] [varchar](100) NULL,
	[Photo] [varchar](200) NULL,
	[HandiCapped] [varchar](100) NULL,
	[BloodGroup] [varchar](100) NULL,
	[Regigion] [varchar](100) NULL,
	[Category] [varchar](100) NULL,
	[AadharNo] [varchar](100) NULL,
	[BankAccountNumber] [varchar](100) NULL,
	[BankName] [varchar](100) NULL,
	[BankIFSCCode] [varchar](100) NULL,
	[AddressOne] [varchar](100) NULL,
	[AddressTwo] [varchar](100) NULL,
	[Block] [varchar](100) NULL,
	[PinCode] [varchar](100) NULL,
	[City] [varchar](100) NULL,
	[State] [varchar](100) NULL,
	[Country] [varchar](100) NULL,
	[LandMark] [varchar](100) NULL,
	[PermAddressOne] [varchar](100) NULL,
	[PermAddressTwo] [varchar](100) NULL,
	[PermBlock] [varchar](100) NULL,
	[PermPinCode] [varchar](100) NULL,
	[PermCity] [varchar](100) NULL,
	[PermState] [varchar](100) NULL,
	[PermCountry] [varchar](100) NULL,
	[PermLandMark] [varchar](100) NULL,
	[CreatedOn] [date] NULL,
	[Role] [varchar](100) NULL,
	[IsSms] [int] NULL,
	[IsSpecialNeed] [int] NULL,
	[RegistrationNo] [varchar](100) NULL,
	[EnrollmentNo] [varchar](100) NULL,
	[AnnualIncome] [varchar](100) NULL,
	[CastCertificateNo] [varchar](100) NULL,
	[AddmissionType] [varchar](100) NULL,
	[AddmissionScheme] [varchar](100) NULL,
	[OldOrNew] [varchar](100) NULL,
	[PrevClass] [varchar](100) NULL,
	[AddmissionClass] [varchar](100) NULL,
	[Section] [varchar](100) NULL,
	[Stream] [varchar](100) NULL,
	[Session] [varchar](100) NULL,
	[PrevSchoolTcNo] [varchar](100) NULL,
	[PrevSchoolTcDate] [date] NULL,
	[SchoolerNo] [varchar](100) NULL,
	[DateOfAddmission] [date] NULL,
	[Conveyance] [varchar](100) NULL,
	[StudentDocument] [varchar](100) NULL,
	[FatherFirstName] [varchar](100) NULL,
	[FatherMiddleName] [varchar](100) NULL,
	[FatheLastName] [varchar](100) NULL,
	[FatherPhone] [varchar](100) NULL,
	[FatherEmail] [varchar](100) NULL,
	[FatherQualification] [varchar](100) NULL,
	[FatherAadharNo] [varchar](100) NULL,
	[FatherPanNo] [varchar](100) NULL,
	[FatherPhoto] [varchar](100) NULL,
	[FatherDocument] [varchar](100) NULL,
	[MotherFirstName] [varchar](100) NULL,
	[MotherMiddleName] [varchar](100) NULL,
	[MotherLastName] [varchar](100) NULL,
	[MotherPhone] [varchar](100) NULL,
	[MotherEmail] [varchar](100) NULL,
	[MotherQualification] [varchar](100) NULL,
	[MotherAadharNo] [varchar](100) NULL,
	[MotherPanNo] [varchar](100) NULL,
	[MotherPhoto] [varchar](100) NULL,
	[MotherDocument] [varchar](100) NULL,
	[RemarkOne] [varchar](100) NULL,
	[RemarkTwo] [varchar](100) NULL,
	[IsTransport] [int] NULL,
	[TransportCategory] [varchar](100) NULL,
	[TransportRoute] [varchar](100) NULL,
	[TransportFee] [varchar](100) NULL,
	[IsHostal] [int] NULL,
	[IsBoarding] [int] NULL,
	[IsLibrary] [int] NULL,
	[IsActive] [int] NULL,
PRIMARY KEY CLUSTERED 
(
	[StudentId] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY],
UNIQUE NONCLUSTERED 
(
	[Email] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO

SET ANSI_PADDING OFF
GO

ALTER TABLE [dbo].[students] ADD  DEFAULT ('No') FOR [HandiCapped]
GO

ALTER TABLE [dbo].[students] ADD  DEFAULT (getdate()) FOR [CreatedOn]
GO

ALTER TABLE [dbo].[students] ADD  DEFAULT ('student') FOR [Role]
GO

ALTER TABLE [dbo].[students] ADD  DEFAULT ((0)) FOR [IsSms]
GO

ALTER TABLE [dbo].[students] ADD  DEFAULT ((0)) FOR [IsSpecialNeed]
GO

ALTER TABLE [dbo].[students] ADD  DEFAULT ((0)) FOR [IsTransport]
GO

ALTER TABLE [dbo].[students] ADD  DEFAULT ((0)) FOR [IsHostal]
GO

ALTER TABLE [dbo].[students] ADD  DEFAULT ((0)) FOR [IsBoarding]
GO

ALTER TABLE [dbo].[students] ADD  DEFAULT ((0)) FOR [IsLibrary]
GO

ALTER TABLE [dbo].[students] ADD  DEFAULT ((1)) FOR [IsActive]
GO


