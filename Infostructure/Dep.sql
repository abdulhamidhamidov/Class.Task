CREATE TABLE courses (
                         Id serial PRIMARY KEY,
                         CourseName VARCHAR(255) NOT NULL,
                         Description TEXT,
                         StartDate DATE,
                         EndDate DATE
);
CREATE TABLE groups (
                        Id serial PRIMARY KEY ,
                        CourseId INT  REFERENCES courses(Id),
                        GroupName VARCHAR(255) NOT NULL,
                        GroupSize INT
);
CREATE TABLE mentors (
                         Id serial PRIMARY KEY,
                         FullName VARCHAR(255) NOT NULL,
                         Email VARCHAR(255) UNIQUE,
                         PhoneNumber VARCHAR(15),
                         CourseId INT REFERENCES courses(Id)
);
CREATE TABLE students (
                          Id serial PRIMARY KEY ,
                          FullName VARCHAR(255) NOT NULL,
                          Email VARCHAR(255) UNIQUE,
                          PhoneNumber VARCHAR(15),
                          GroupId INT  REFERENCES groups (Id)
);

insert into courses(coursename, description, startdate, enddate) values (@CourseName,@Description, StartDate, @EndDate);


insert into mentors(FullName, Email, PhoneNumber, CourseId) values (@FullName, @Email, @PhoneNumber, @CourseId);
update mentors set FullName=@FullName, Email=@Email, PhoneNumber=@PhoneNumber, CourseId=@CourseId where id=@Id;




