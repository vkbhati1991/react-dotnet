

CREATE Procedure spAddStudent
(
	@StudentId int,
	@FirstName varchar(100),
	@MiddleName varchar(100),
	@LastName varchar(100),
	@Email varchar(200),
	@UserName varchar(200),
	@Password varchar(200),
	@Phone varchar(100),
	@DOB date,
	@DobInText varchar(100),
	@Gender varchar(100),
	@Photo varchar(200),
	@HandiCapped varchar(100),
	@BloodGroup varchar(100),
	@Regigion varchar(100),
	@Category varchar(100),
	@AadharNo varchar(100),
	@BankAccountNumber varchar(100),
	@BankName varchar(100),
	@BankIFSCCode varchar(100),
	@AddressOne varchar(100),
	@AddressTwo varchar(100),
	@Block varchar(100),
	@PinCode varchar(100),
	@City varchar(100),
	@State varchar(100),
	@Country varchar(100),
	@LandMark varchar(100),
	@PermAddressOne varchar(100),
	@PermAddressTwo varchar(100),
	@PermBlock varchar(100),
	@PermPinCode varchar(100),
	@PermCity varchar(100),
	@PermState varchar(100),
	@PermCountry varchar(100),
	@PermLandMark varchar(100),
	@CreatedOn date,
	@Role varchar(100),
	@IsSms int,
	@IsSpecialNeed int,
	@RegistrationNo varchar(100),
	@EnrollmentNo varchar(100),
	@AnnualIncome varchar(100),
	@CastCertificateNo varchar(100), 
	@AddmissionType varchar(100),
	@AddmissionScheme varchar(100),
	@OldOrNew varchar(100),
	@PrevClass varchar(100),
	@AddmissionClass varchar(100),
	@Section varchar(100),
	@Stream varchar(100),
	@Session varchar(100),
	@PrevSchoolTcNo varchar(100),
	@PrevSchoolTcDate date,
	@SchoolerNo varchar(100),
	@DateOfAddmission date,
	@Conveyance varchar(100),
	@StudentDocument varchar(100),
	@FatherFirstName varchar(100),
	@FatherMiddleName varchar(100),
	@FatheLastName varchar(100),
	@FatherPhone varchar(100),
	@FatherEmail varchar(100),
	@FatherQualification varchar(100),
	@FatherAadharNo varchar(100),
	@FatherPanNo varchar(100),
	@FatherPhoto varchar(100),
	@FatherDocument varchar(100),
	@MotherFirstName varchar(100),
	@MotherMiddleName varchar(100),
	@MotherLastName varchar(100),
	@MotherPhone varchar(100),
	@MotherEmail varchar(100),
	@MotherQualification varchar(100),
	@MotherAadharNo varchar(100),
	@MotherPanNo varchar(100),
	@MotherPhoto varchar(100),
	@MotherDocument varchar(100),
	@RemarkOne varchar(100),
	@RemarkTwo varchar(100),
	@IsTransport int,
	@TransportCategory varchar(100),
	@TransportRoute varchar(100),
	@TransportFee varchar(100),
	@IsHostal int,
	@IsBoarding int,
	@IsLibrary int,
	@IsActive int,
	@ReturnCode varchar(200) output
)
as
BEGIN
	SET @ReturnCode = '0'
	IF(@StudentId <> 0)
	BEGIN
		IF EXISTS (SELECT 1 FROM Students Where Email = @Email AND StudentId <> @StudentId)
		BEGIN
			SET @ReturnCode = '2'
			RETURN
		END

		UPDATE Students SET
		FirstName=@FirstName,
		MiddleName=@MiddleName,
		LastName=@LastName, 
		Email=@Email, 
		UserName=@UserName, 
		Password=@Password, 
		Phone=@Phone, 
		DOB=@DOB, 
		DobInText=@DobInText, 
		Gender=@Gender, 
		Photo=@Photo, 
		HandiCapped=@HandiCapped, 
		BloodGroup=@BloodGroup, 
		Regigion=@Regigion, 
		Category=@Category, 
		AadharNo=@AadharNo, 
		BankAccountNumber=@BankAccountNumber, 
		BankName=@BankName, 
		BankIFSCCode=@BankIFSCCode, 
		AddressOne=@AddressOne, 
		AddressTwo=@AddressTwo, 
		Block=@Block, 
		PinCode=@PinCode, 
		City=@City, 
		State=@State, 
		Country=@Country, 
		LandMark=@LandMark, 
		PermAddressOne=@PermAddressOne, 
		PermAddressTwo=@PermAddressTwo, 
		PermBlock=@PermBlock, 
		PermPinCode=@PermPinCode, 
		PermCity=@PermCity, 
		PermState=@PermState, 
		PermCountry=@PermCountry, 
		PermLandMark=@PermLandMark, 
		CreatedOn=@CreatedOn, 
		Role=@Role, 
		IsSms=@IsSms, 
		IsSpecialNeed=@IsSpecialNeed, 
		RegistrationNo=@RegistrationNo, 
		EnrollmentNo=@EnrollmentNo, 
		AnnualIncome=@AnnualIncome, 
		CastCertificateNo=@CastCertificateNo,
		AddmissionType=@AddmissionType, 
		AddmissionScheme=@AddmissionScheme, 
		OldOrNew=@OldOrNew, 
		PrevClass=@PrevClass, 
		AddmissionClass=@AddmissionClass, 
		Section=@Section, 
		Stream=@Stream, 
		Session=@Session, 
		PrevSchoolTcNo=@PrevSchoolTcNo, 
		PrevSchoolTcDate=@PrevSchoolTcDate, 
		SchoolerNo=@SchoolerNo, 
		DateOfAddmission=@DateOfAddmission, 
		Conveyance=@Conveyance, 
		StudentDocument=@StudentDocument, 
		FatherFirstName=@FatherFirstName, 
		FatherMiddleName=@FatherMiddleName, 
		FatheLastName=@FatheLastName, 
		FatherPhone=@FatherPhone, 
		FatherEmail=@FatherEmail, 
		FatherQualification=@FatherQualification, 
		FatherAadharNo=@FatherAadharNo, 
		FatherPanNo=@FatherPanNo, 
		FatherPhoto=@FatherPhoto, 
		FatherDocument=@FatherDocument, 
		MotherFirstName=@MotherFirstName, 
		MotherMiddleName=@MotherMiddleName, 
		MotherLastName=@MotherLastName, 
		MotherPhone	=@MotherPhone, 
		MotherEmail=@MotherEmail, 
		MotherQualification=@MotherQualification, 
		MotherAadharNo=@MotherAadharNo, 
		MotherPanNo=@MotherPanNo, 
		MotherPhoto=@MotherPhoto, 
		MotherDocument=@MotherDocument, 
		RemarkOne=@RemarkOne, 
		RemarkTwo=@RemarkTwo, 
		IsTransport=@IsTransport, 
		TransportCategory=@TransportCategory, 
		TransportRoute=@TransportRoute, 
		TransportFee=@TransportFee, 
		IsHostal=@IsHostal, 
		IsBoarding=@IsBoarding, 
		IsLibrary=@IsLibrary, 
		IsActive=@IsActive 

		WHERE StudentId = @StudentId

		SET @ReturnCode = '0'  
	END
	ELSE
	BEGIN
		IF EXISTS (SELECT 1 FROM Users WHERE Email = @Email)  
        BEGIN  
            SET @ReturnCode = '2'  
            RETURN  
        END  

		INSERT INTO 
		Students(
		FirstName,
		MiddleName,
		LastName,
		Email,
		UserName,
		Password,
		Phone,
		DOB,
		DobInText,
		Gender,
		Photo,
		HandiCapped,
		BloodGroup,
		Regigion,
		Category,
		AadharNo,
		BankAccountNumber,
		BankName,
		BankIFSCCode,
		AddressOne,
		AddressTwo,
		Block,
		PinCode,
		City,
		State,
		Country,
		LandMark,
		PermAddressOne,
		PermAddressTwo,
		PermBlock,
		PermPinCode,
		PermCity,
		PermState,
		PermCountry,
		PermLandMark,
		CreatedOn,
		Role,
		IsSms,
		IsSpecialNeed,
		RegistrationNo,
		EnrollmentNo,
		AnnualIncome,
		CastCertificateNo, 
		AddmissionType,
		AddmissionScheme,
		OldOrNew,
		PrevClass,
		AddmissionClass,
		Section,
		Stream,
		Session,
		PrevSchoolTcNo,
		PrevSchoolTcDate,
		SchoolerNo,
		DateOfAddmission,
		Conveyance,
		StudentDocument,
		FatherFirstName,
		FatherMiddleName,
		FatheLastName,
		FatherPhone,
		FatherEmail,
		FatherQualification,
		FatherAadharNo,
		FatherPanNo,
		FatherPhoto,
		FatherDocument,
		MotherFirstName,
		MotherMiddleName,
		MotherLastName,
		MotherPhone,
		MotherEmail,
		MotherQualification,
		MotherAadharNo,
		MotherPanNo,
		MotherPhoto,
		MotherDocument,
		RemarkOne,
		RemarkTwo,
		IsTransport,
		TransportCategory,
		TransportRoute,
		TransportFee,
		IsHostal,
		IsBoarding,
		IsLibrary,
		IsActive
		)
		VALUES (
		@FirstName,
		@MiddleName,
		@LastName,
		@Email,
		@UserName,
		@Password,
		@Phone,
		@DOB,
		@DobInText,
		@Gender,
		@Photo,
		@HandiCapped,
		@BloodGroup,
		@Regigion,
		@Category,
		@AadharNo,
		@BankAccountNumber,
		@BankName,
		@BankIFSCCode,
		@AddressOne,
		@AddressTwo,
		@Block,
		@PinCode,
		@City,
		@State,
		@Country,
		@LandMark,
		@PermAddressOne,
		@PermAddressTwo,
		@PermBlock,
		@PermPinCode,
		@PermCity,
		@PermState,
		@PermCountry,
		@PermLandMark,
		@CreatedOn,
		@Role,
		@IsSms,
		@IsSpecialNeed,
		@RegistrationNo,
		@EnrollmentNo,
		@AnnualIncome,
		@CastCertificateNo, 
		@AddmissionType,
		@AddmissionScheme,
		@OldOrNew,
		@PrevClass,
		@AddmissionClass,
		@Section,
		@Stream,
		@Session,
		@PrevSchoolTcNo,
		@PrevSchoolTcDate,
		@SchoolerNo,
		@DateOfAddmission,
		@Conveyance,
		@StudentDocument,
		@FatherFirstName,
		@FatherMiddleName,
		@FatheLastName,
		@FatherPhone,
		@FatherEmail,
		@FatherQualification,
		@FatherAadharNo,
		@FatherPanNo,
		@FatherPhoto,
		@FatherDocument,
		@MotherFirstName,
		@MotherMiddleName,
		@MotherLastName,
		@MotherPhone,
		@MotherEmail,
		@MotherQualification,
		@MotherAadharNo,
		@MotherPanNo,
		@MotherPhoto,
		@MotherDocument,
		@RemarkOne,
		@RemarkTwo,
		@IsTransport,
		@TransportCategory,
		@TransportRoute,
		@TransportFee,
		@IsHostal,
		@IsBoarding,
		@IsLibrary,
		@IsActive
		)
		SET @ReturnCode = '0' 
	END

END	
GO


