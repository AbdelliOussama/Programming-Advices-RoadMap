Create Table Users(
UserID int identity(1,1) primary key,
PersonID int foreign key references People(PersonID),
UserName nvarchar(60),
Password nvarchar(60),
IsActive bit )


alter table Users 
alter column IsActive bit  not null;



create table ApplicationType
(ApplicationTypeID int identity(1,1)primary key,
ApplicationTypeTitle nvarchar(50) not null,
ApplicationFees smallmoney not null)

exec sp_rename 'ApplicationType' ,'ApplicationTypes';


Create table Applications(
ApplicatioID int identity(1,1) primary key,
ApplicantPersonID int foreign key references People(PersonID) not null,
ApplicationDate DateTime not null,
ApplicationTypeID int foreign key references ApplicationTypes(ApplicationTypeID) not null,
ApplicationStatus tinyint not null,
LastStatusDate DateTime not null,
PaidFees smallmoney not null,
CreatedByUserID int foreign key references Users(UserID)
);

create table LicenseClasses(
LicenseClassID int identity(1,1) primary key,
ClassName nvarchar(50) not null,
ClassDescription nvarchar(500) not null,
MinimumAllowedAge tinyint not null,
DefaultValidityLength tinyint not null,
ClassFees smallmoney not null)


create table LocalDrivingLicenseApplications(
LocalDrivingLicenseApplicationID int identity(1,1) primary key,
ApplicationID int foreign key References Applications(ApplicationID) not null,
LicenseCassID int foreign key references LicenseClasses(LicenseClassID)
);


create table TestTypes(
TestTypeID int identity(1,1) primary key,
TestTypeTitle nvarchar(50) not null,
TestTyepDescription nvarchar(500) not null,
TestTypeFees smallmoney not null
);

create table TestAppointmlents(
TestAppointmentID int identity(1,1) primary key,
TestTypeID int foreign key References TestTypes(TestTypeID) not null,
LocalDrivingLicenseApplicationID int Foreign key references LocalDrivingLicenseApplications(LocalDrivingLicenseApplicationID) not null,
AppointmentDate DateTime not null,
PaidFees smallMoney not null,
CreatedByUserID int Foreign key references Users(UserID) not null,
IsLocked tinyint not null,
RetakeTestApplicationID int foreign key references Applications(ApplicationID)
);


create table Tests(
TestID int identity(1,1) primary key ,
TestAppointmentID int foreign key references TestAppointments(TestAppointmentID) not null,
TestResult bit not null,
Notes nvarchar(500) not null,
CreatedByUserID int foreign key references Users(UserID) not null
);

create table Drivers(
DriverID int identity(1,1) primary key,
PersonID int Foreign key references People(PersonID) not null,
CreatedByUserID int Foreign key references Users(UserID) not null,
CreatedDate DateTime not null
);

Create table Licenses(
LicenseID int identity (1,1) primary key ,
ApplicationID int foreign key references Applications(ApplicationID) not null,
DriverID int foreign key references Drivers(DriverID) not null,
LicenseClass  int foreign key references LicenseClasses(LicenseClassID) not null,
IssueDate DateTime not null,
ExpirationDate DateTime not null,
Notes nvarchar(500),
PaidFees smallmoney not null,
IsActive bit not null,
IssueReason tinyint not null,
CreatedByUserID int foreign key references Users(UserID) not null
);



Create table DetainedLicenses(
DetainID int identity(1,1) primary key,
LicenseID int foreign key references Licenses(LicenseID) not null,
DetainDate DateTime not null,
FineFees smallMoney not null,
CreatedByUserID int foreign key references Users(userID) not null,
IsReleased bit ,
ReleaseDate DateTime ,
ReleasedByUserID int foreign key references Users(UserID) not null,
ReleaseApplicationID int foreign key references Applications(ApplicationID) not null
);









