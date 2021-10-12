USE master
GO

CREATE DATABASE [Project]
GO

Use Project
Go

CREATE Table Students
(
	StudentNumber varchar(10),
	NameSurname varchar(80),
	Gender varchar(10),
	StudentDOB varchar(20),
	Phone varchar(10),
	Address_ varchar(100),
	ImgPath varchar(100),
	Primary Key (StudentNumber)
);
CREATE TABLE Courses
(
	ModCode varchar(10),
	ModName varchar(50),
	ModDesc varchar(200),
	Link varchar(200),
	PRIMARY KEY (ModCode)
);
CREATE TABLE StudentCourses
(
	StudentNumber varchar(10) FOREIGN KEY REFERENCES Students(StudentNumber),
	ModCode varchar(10) FOREIGN KEY REFERENCES Courses(ModCode),
	PRIMARY KEY (StudentNumber, Modcode)
);

Insert Into Students(StudentNumber, NameSurname, StudentDOB, Phone, Address_, ImgPath, Gender) Values
('50000', 'Adam Adams','09-10-2000' , '0711112222','10 Plat Str, Johannesburg','Adam Adams.png', 'Male');
Insert Into Students(StudentNumber, NameSurname, StudentDOB, Phone, Address_, ImgPath, Gender) Values
('50001', 'Bram Adams','09-11-2000' , '0711113333','1 Easter Road, Pretoria','BramAdams.png', 'Male')
Insert Into Students(StudentNumber, NameSurname, StudentDOB, Phone, Address_, ImgPath, Gender) Values
('50002', 'Tam Binks','19-10-2000' , '0711112322','10 Aler Lane, Alexandria','TamBinks.png', 'Female')
Insert Into Students(StudentNumber, NameSurname, StudentDOB, Phone, Address_, ImgPath, Gender) Values
('50003', 'Cam Peggs','09-12-1999' , '0711112233','4 Epson Road, Alexandria','CamPeggs.png', 'Female')
Insert Into Students(StudentNumber, NameSurname, StudentDOB, Phone, Address_, ImgPath, Gender) Values
('50004', 'Lily Hicks','10-03-2001' , '0711212222','10 Process Lane, Harties','LilyHicks.png', 'Female')
Insert Into Students(StudentNumber, NameSurname, StudentDOB, Phone, Address_, ImgPath, Gender) Values
('50005', 'Rick Astley','08-11-1998' , '0711112222','17 Berg Lane, Brits','RickAstley.png', 'Male')
Insert Into Students(StudentNumber, NameSurname, StudentDOB, Phone, Address_, ImgPath, Gender) Values
('50006', 'Jeff JustJeff','15-07-2000' , '0711112222','10 Alder Lane, BitTown','JeffJustJeff.png', 'Male')
Insert Into Students(StudentNumber, NameSurname, StudentDOB, Phone, Address_, ImgPath, Gender) Values
('50007', 'Elly Olsen','05-11-2000' , '0711112222','9 Aler Lane, Alexandria','EllyOlsen.png', 'Female')
Insert Into Students(StudentNumber, NameSurname, StudentDOB, Phone, Address_, ImgPath, Gender) Values
('50008', 'Peter Quill','12-05-2000' , '0711112222','1 Link Street, Kosmos','PeterQuill.png', 'Male')
Insert Into Students(StudentNumber, NameSurname, StudentDOB, Phone, Address_, ImgPath, Gender) Values
('50009', 'Alex Mason','27-08-2000' , '0711112222','2 Alder Lane, Mooinooi','AlexMason.png', 'Male')
Insert Into Students(StudentNumber, NameSurname, StudentDOB, Phone, Address_, ImgPath, Gender) Values
('50010', 'Max Black','09-08-2000' , '0711112222','10 Kraai Street, Mooinooi','MaxBlack.png', 'Female')
Insert Into Students(StudentNumber, NameSurname, StudentDOB, Phone, Address_, ImgPath, Gender) Values
('50011', 'Sera Lynn','09-01-2000' , '0711112222','10 Vink Street, Pretoria','SeraLynn.png', 'Female')
Insert Into Students(StudentNumber, NameSurname, StudentDOB, Phone, Address_, ImgPath, Gender) Values
('50012', 'Bojack Horseman','09-10-1999' , '0711112222','8 Sims Street, Pretoria','BojackHorseman.png', 'Male')

Insert Into Courses(ModCode, ModName, ModDesc, Link) VALUES 
('PRG282', 'Programming 282', 'Learning of Object Relation Programming and data usage in programs.','https://www.youtube.com/watch?v=V9r-Gp3uNCE')
Insert Into Courses(ModCode, ModName, ModDesc, Link) VALUES 
('PRG281', 'Programming 281', 'Learning of Object Relation Programming.','https://www.youtube.com/watch?v=t2SPg6IuT3k')
Insert Into Courses(ModCode, ModName, ModDesc, Link) VALUES 
('WPR281', 'Web-Programming 281', 'Learning of HTML scripts and adding them via Javascripts.','https://www.youtube.com/watch?v=Gd0RBdFRvF0')
Insert Into Courses(ModCode, ModName, ModDesc, Link) VALUES 
('DBD281', 'Database Development 281', 'Learning of SQL server and database development.','https://www.sqlshack.com/learn-sql-create-database-create-table/')

Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50000', 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50001', 'PRG282');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50002', 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50003', 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50004', 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50005', 'PRG282');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50006', 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50007', 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50008', 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50009', 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50011', 'PRG282');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50010', 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50012', 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50001', 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50002', 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50003', 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50004', 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50005', 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50006', 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50007', 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50008', 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50009', 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50010', 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50011', 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50012', 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50000', 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50003', 'PRG282');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50001', 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50004', 'PRG282');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50001', 'WPR281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50005', 'DBD281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50011', 'PRG281');
Insert Into StudentCourses(StudentNumber,ModCode) VALUES ('50009', 'WPR281');
GO

CREATE PROC spGetStudents
AS
BEGIN
	SELECT * FROM Students;
END
GO

CREATE PROC spGetCourses
AS
BEGIN
	SELECT * FROM Courses;
END
GO

CREATE PROC spPopulateCourses
(
	@StudnetID VARCHAR(10)
)
AS
BEGIN
	SELECT Courses.ModCode, Courses.ModName, Courses.ModDesc, Courses.Link 
	FROM Courses
	INNER JOIN StudentCourses ON Courses.ModCode = StudentCourses.ModCode
	INNER JOIN Students ON StudentCourses.StudentNumber = Students.StudentNumber
	WHERE Students.StudentNumber = @StudnetID;
END
GO

CREATE PROC spUpdateStudents
(
	@StudentNumber VARCHAR(10),
	@NameSurname VARCHAR(80),
	@Gender VARCHAR(10),
	@DOB VARCHAR(20),
	@Phone VARCHAR(10),
	@Address VARCHAR(100),
	@ImgPath VARCHAR(100)
)
AS
BEGIN
	UPDATE Students 
	SET NameSurname = @NameSurname, Gender = @Gender, StudentDOB = @DOB, Phone = @Phone, Address_ = @Address, ImgPath = @ImgPath 
	WHERE StudentNumber = @StudentNumber;
END
GO

CREATE PROC spUpdateCourses
(
	@ModCode VARCHAR(10),
	@ModName VARCHAR(50),
	@ModDesc VARCHAR(200),
	@Link VARCHAR(200)
)
AS
BEGIN
	UPDATE Courses 
	SET ModName = @ModName, ModDesc = @ModDesc, Link = @Link 
	WHERE ModCode = @ModCode;
END
GO

CREATE PROC spDeleteStudents
(
	@StudnetNumber VARCHAR(10)
)
AS
BEGIN
	DELETE FROM StudentCourses WHERE StudentNumber = @StudnetNumber;
	DELETE FROM Students WHERE StudentNumber = @StudnetNumber;
END
GO

CREATE PROC spDeleteCourses
(
	@CourseCode VARCHAR(10)
)
AS
BEGIN
	DELETE FROM StudentCourses WHERE ModCode = @CourseCode;
	DELETE FROM Courses WHERE ModCode = @CourseCode;
END
GO

CREATE PROC spDeleteCoursesStudent
(
	@CourseCode VARCHAR(10),
	@StudentNumber VARCHAR(10)
)
AS
BEGIN
	DELETE FROM StudentCourses WHERE ModCode = @CourseCode AND StudentNumber = @StudentNumber;
END
GO

CREATE PROC spSearchStudents
(
	@StudnetNumber VARCHAR(10)
)
AS
BEGIN
	SELECT * FROM Students WHERE StudentNumber = @StudnetNumber;
END
GO

CREATE PROC spSearchCourses
(
	@CourseCode VARCHAR(10)
)
AS
BEGIN
	SELECT * FROM Courses WHERE ModCode = @CourseCode;
END
GO

CREATE PROC spAddStudents
(
	@StudentNumber VARCHAR(10),
	@NameSurname VARCHAR(80),
	@Gender VARCHAR(10),
	@DOB VARCHAR(20),
	@Phone VARCHAR(10),
	@Address VARCHAR(100),
	@ImgPath VARCHAR(100)
)
AS
BEGIN
	INSERT INTO Students 
	VALUES (@StudentNumber, @NameSurname, @Gender, @DOB, @Phone, @Address, @ImgPath);
END
GO

CREATE PROC spAddCourses
(
	@ModCode VARCHAR(10),
	@ModName VARCHAR(50),
	@ModDesc VARCHAR(200),
	@Link VARCHAR(200)
)
AS
BEGIN
	INSERT INTO Courses 
	VALUES (@ModCode, @ModName, @ModDesc, @Link);
END
GO

CREATE PROC spAddStudentCourses
(
	@ModCode VARCHAR(10),
	@StudentNumber VARCHAR(10)
)
AS
BEGIN
	INSERT INTO StudentCourses
	(StudentNumber, ModCode)
	VALUES (@StudentNumber, @ModCode);
END
GO

CREATE PROC spDeleteJoingCourses
(
	@StudnetNumber VARCHAR(10)
)
AS
BEGIN
	DELETE FROM StudentCourses WHERE StudentNumber = @StudnetNumber;
END
GO

CREATE PROC spGetModCodes
AS
BEGIN
	SELECT ModCode FROM Courses;
END
GO