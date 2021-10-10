
CREATE DATABASE [Project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Project', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Project.mdf' , SIZE = 8192KB , FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Project_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\Project_log.ldf' , SIZE = 8192KB , FILEGROWTH = 65536KB )
GO;
Use Project
Go;

CREATE Table Students
(
	StudentNumber varchar,
	NameSurname varchar,
	StudentDOB	date,
	Phone varchar,
	Address_ varchar,
	ImgPath varchar,
	Primary Key (StudentNumber)
);
CREATE TABLE Courses
(
	ModCode varchar,
	ModName varchar,
	ModDesc varchar,
	Link varchar,
	PRIMARY KEY (ModCode)
);
CREATE TABLE StudentCourses
(
	StudentNumber varchar FOREIGN KEY REFERENCES Students(StudentNumber),
	ModCode varchar FOREIGN KEY REFERENCES Courses(ModCode),
	PRIMARY KEY (StudentNumber, Modcode)
);