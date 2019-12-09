--CREATE TABLE Cohort (
--    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--    Name VARCHAR(55) NOT NULL
--);

--CREATE TABLE Excercise (
--    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--    Name VARCHAR(55) NOT NULL,
--    Language VARCHAR(55) NOT NULL
--);

--CREATE TABLE Student (
--    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--    FirstName VARCHAR(55) NOT NULL,
--    LastName VARCHAR(55) NOT NULL,
--    SlackHandle VARCHAR(55) NOT NULL,
--    CohortId INTEGER,
--    CONSTRAINT FK_Student_Cohort FOREIGN KEY(CohortId) REFERENCES Cohort(Id)

--);

--CREATE TABLE Instructor (
--    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--    FirstName VARCHAR(55) NOT NULL,
--    LastName VARCHAR(55) NOT NULL,
--    SlackHandle VARCHAR(55) NOT NULL,
--    Specialty VARCHAR(55) NOT NULL,
--    CohortId INTEGER,
--    CONSTRAINT FK_Instructor_Cohort FOREIGN KEY(CohortId) REFERENCES Cohort(Id)

--);

--CREATE TABLE StudentExercise (
--    Id INTEGER NOT NULL PRIMARY KEY IDENTITY,
--    StudentId INTEGER,
--    ExerciseId INTEGER,
--    CONSTRAINT FK_StudentExcercise_Student FOREIGN KEY(StudentId) REFERENCES Student(Id),
--    CONSTRAINT FK_StudentExcercise_Exercise FOREIGN KEY(ExerciseId) REFERENCES Excercise(Id)
--);


INSERT INTO Cohort (Name) VALUES ('Cohort 35');
INSERT INTO Cohort (Name) VALUES ('Cohort 36');
INSERT INTO Cohort (Name) VALUES ('Cohort 37');
INSERT INTO Cohort (Name) VALUES ('Cohort 34');

INSERT INTO Exercise (Name, Language) VALUES ('Heist', 'C#');
INSERT INTO Exercise (Name, Language) VALUES ('Student Exercises', 'C#');
INSERT INTO Exercise (Name, Language) VALUES ('Journal', 'JS');
INSERT INTO Exercise (Name, Language) VALUES ('Welcome to Nashville', 'JS');



