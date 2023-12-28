-- Create Database
CREATE DATABASE GymBrosDB;
USE GymBrosDB;

-- Create Users Table
CREATE TABLE Users (
    User_ID INT IDENTITY(100,1) PRIMARY KEY,
    Fname VARCHAR(50) NOT NULL,
    Lname VARCHAR(50) NOT NULL,
    Gender BIT NOT NULL CHECK (Gender IN (0, 1)),	-- 0 is female, 1 is male
    Age INT NOT NULL CHECK (Age >= 16),
    Account_Pass VARCHAR(50) NOT NULL,
    Emrgncy_Contact INT NOT NULL, -- Assuming it's a phone number
    Contact_Info INT NOT NULL -- Assuming it's a phone number
);

-- Create Staff Table
CREATE TABLE Staff (
    Staff_ID INT PRIMARY KEY,
    Salary INT NOT NULL,
    Role VARCHAR(50) NOT NULL CHECK (Role IN ('Trainer', 'Front Desk', 'Manager', 'Admin')),
	constraint fk_Staff_Users
		FOREIGN KEY (Staff_ID) REFERENCES Users(User_ID)
			ON DELETE CASCADE
			ON UPDATE CASCADE
);

-- Create Suppliers Table
CREATE TABLE Suppliers (
    Supplier_ID INT IDENTITY(1000,1) PRIMARY KEY,
    Brand_Name VARCHAR(50) NOT NULL
);

-- Create Financial_Records Table
CREATE TABLE Financial_Records (
    Transaction_Type VARCHAR(50) PRIMARY KEY,
    Transaction_Amount INT NOT NULL
);

-- Create Announcements Table
CREATE TABLE Announcements (
    Message_ID INT IDENTITY(1,1) PRIMARY KEY,
    Message_Date DATE,
    Message_Text VARCHAR(200) NOT NULL,
    Sender_ID INT,
	constraint fk_Announcements_Sender
		FOREIGN KEY (Sender_ID) REFERENCES Staff(Staff_ID)
			ON DELETE NO ACTION
			ON UPDATE CASCADE
);

-- Create Classes Table
CREATE TABLE Classes (
    Class_Type VARCHAR(50) PRIMARY KEY,
    Class_Mgr INT,
    Price INT NOT NULL,
    Availability BIT NOT NULL CHECK (Availability IN (0, 1)),	-- 0 is NOT Available, 1 is Available
    Description VARCHAR(500) NOT NULL,
    Instructor_ID INT,
    Date DATE,
    Time TIME,
    Location VARCHAR(50),
    Registered_Num INT,
    Class_Max_Limit INT,
	constraint fk_Classes_Instructor
		FOREIGN KEY (Instructor_ID) REFERENCES Staff(Staff_ID)
			ON DELETE SET NULL
			ON UPDATE CASCADE,
	constraint fk_Classes_Mgr
		FOREIGN KEY (Class_Mgr) REFERENCES Staff(Staff_ID)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION
);

-- Create Members Table
CREATE TABLE Members (
    Member_ID INT PRIMARY KEY,
    Renewal_Date DATE NOT NULL,
    Membership_Fees INT NOT NULL,
	constraint fk_Member_Users
		FOREIGN KEY (Member_ID) REFERENCES Users(User_ID)
			ON DELETE CASCADE
			ON UPDATE CASCADE
);

-- Create Equipment Table
CREATE TABLE Equipment (
    Equipment_ID INT IDENTITY(1,1) PRIMARY KEY,
    Model VARCHAR(50) NOT NULL,
    Purchase_Date DATE NOT NULL,
    Maintenance_Sched DATE NOT NULL,
    Status VARCHAR(50) NOT NULL CHECK (Status IN ('Good', 'Needs Maintenance', 'Under Repair', 'Out of Order')),
    Supplier_ID INT,
	constraint fk_Equipment_Supplier
		FOREIGN KEY (Supplier_ID) REFERENCES Suppliers(Supplier_ID)
			ON DELETE NO ACTION
			ON UPDATE CASCADE
);

-- Create Extra_Service Table
CREATE TABLE Extra_Service (
    Service_Name VARCHAR(50) PRIMARY KEY,
    Price INT NOT NULL,
    Availability BIT NOT NULL,
    Description VARCHAR(500) NOT NULL,
    Service_Mgr_ID INT,
	constraint fk_Extra_Service_Mgr
		FOREIGN KEY (Service_Mgr_ID) REFERENCES Staff(Staff_ID)
			ON DELETE SET NULL
			ON UPDATE CASCADE
);

-- Create Body_Composition Table
CREATE TABLE Body_Composition (
    Member_ID INT,
    Height INT,
    Weight INT NOT NULL,
    Muscle_Prcntg FLOAT NOT NULL CHECK (Muscle_Prcntg BETWEEN 0 AND 100),
    BodyFat_Prcntg FLOAT NOT NULL CHECK (BodyFat_Prcntg BETWEEN 0 AND 100),
    Body_Type VARCHAR(50) NOT NULL,
    Chronic_Disease VARCHAR(50) NOT NULL,
    PRIMARY KEY (Member_ID, Height),
	constraint fk_Body_Composition_Member
		FOREIGN KEY (Member_ID) REFERENCES Members(Member_ID)
			ON DELETE CASCADE
			ON UPDATE CASCADE
);

-- Create PT_Session Table
CREATE TABLE PT_Session (
    Session_ID INT IDENTITY(1,1) PRIMARY KEY,
    Date DATE NOT NULL,
    Price INT NOT NULL,
    Member_ID INT,
    Staff_ID INT,
    Did_Attend BIT CHECK (Did_Attend IN (0, 1)),	-- 0 means DID NOT Attend, 1 means Attended, NULL means Session date is yet to come
	constraint fk_PT_Session_Member
		FOREIGN KEY (Member_ID) REFERENCES Members(Member_ID)
			ON DELETE CASCADE
			ON UPDATE CASCADE,
	constraint fk_PT_Session_Instructor
		FOREIGN KEY (Staff_ID) REFERENCES Staff(Staff_ID)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION
);

-- Create Maintains Table
CREATE TABLE Maintains (
    Reporter_ID INT,
    Equipment_ID INT,
    Request_Date DATE NOT NULL,
    Dmg_Estimate INT NOT NULL CHECK (Dmg_Estimate IN (1, 3, 5)),	-- Each estimate results in a certain price for repairs
    Request_Description VARCHAR(500) NOT NULL,
    Status VARCHAR(50) NOT NULL CHECK (Status IN ('Pending', 'In Progress', 'Complete')),
    PRIMARY KEY (Reporter_ID, Equipment_ID),
	constraint fk_Maintains_Reporter
		FOREIGN KEY (Reporter_ID) REFERENCES Staff(Staff_ID)
			ON DELETE NO ACTION
			ON UPDATE CASCADE,
	constraint fk_Maintains_Equipment
		FOREIGN KEY (Equipment_ID) REFERENCES Equipment(Equipment_ID)
			ON DELETE NO ACTION
			ON UPDATE CASCADE
);

-- Create Mem_Rcv_Announce Table
CREATE TABLE Mem_Rcv_Announce (
    Member_ID INT,
    Message_ID INT,
    PRIMARY KEY (Member_ID, Message_ID),
	constraint fk_Mem_Rcv_Announce_Member
		FOREIGN KEY (Member_ID) REFERENCES Members(Member_ID)
			ON DELETE NO ACTION 
			ON UPDATE CASCADE,
	constraint fk_Mem_Rcv_Announce_Message
		FOREIGN KEY (Message_ID) REFERENCES Announcements(Message_ID)
			ON DELETE NO ACTION 
			ON UPDATE NO ACTION 
);

-- Create Mem_Trans Table
CREATE TABLE Mem_Trans (
    Member_ID INT,
    Transaction_Type VARCHAR(50),
	Transaction_Date DATETIME NOT NULL,
    PRIMARY KEY (Member_ID, Transaction_Date),
	constraint fk_Mem_Trans_Member
		FOREIGN KEY (Member_ID) REFERENCES Members(Member_ID)
			ON DELETE NO ACTION
			ON UPDATE CASCADE,
	constraint fk_Mem_Trans_Type
		FOREIGN KEY (Transaction_Type) REFERENCES Financial_Records(Transaction_Type)
			ON DELETE NO ACTION
			ON UPDATE CASCADE
);


-- Create Staff_Rcv_Announce Table
CREATE TABLE Staff_Rcv_Announce (
    Staff_ID INT,
    Message_ID INT,
    PRIMARY KEY (Staff_ID, Message_ID),
	constraint fk_Staff_Rcv_Announce_Staff
		FOREIGN KEY (Staff_ID) REFERENCES Staff(Staff_ID)
			ON DELETE NO ACTION
			ON UPDATE CASCADE,
	constraint fk_Staff_Rcv_Announce_Message
		FOREIGN KEY (Message_ID) REFERENCES Announcements(Message_ID)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION
);

-- Create Staff_Trans Table
CREATE TABLE Staff_Trans (
    Staff_ID INT,
    Transaction_Type VARCHAR(50),
	Transaction_Date DATETIME NOT NULL,
    PRIMARY KEY (Staff_ID, Transaction_Date),
	constraint fk_Staff_Trans_Staff
		FOREIGN KEY (Staff_ID) REFERENCES Staff(Staff_ID)
			ON DELETE NO ACTION
			ON UPDATE CASCADE,
	constraint fk_Staff_Trans_Type
		FOREIGN KEY (Transaction_Type) REFERENCES Financial_Records(Transaction_Type)
			ON DELETE NO ACTION
			ON UPDATE CASCADE
);

-- Create Supplier_Trans Table
CREATE TABLE Supplier_Trans (
    Supplier_ID INT,
    Transaction_Type VARCHAR(50),
	Transaction_Date DATETIME NOT NULL,
    PRIMARY KEY (Supplier_ID, Transaction_Date),
	constraint fk_Supplier_Trans_Supplier
		FOREIGN KEY (Supplier_ID) REFERENCES Suppliers(Supplier_ID)
			ON DELETE NO ACTION
			ON UPDATE CASCADE,
	constraint fk_Supplier_Trans_Type
		FOREIGN KEY (Transaction_Type) REFERENCES Financial_Records(Transaction_Type)
			ON DELETE NO ACTION
			ON UPDATE CASCADE
);

-- Create Uses_Service Table
CREATE TABLE Uses_Service (
    Member_ID INT,
    Service_Name VARCHAR(50),
    Subscription_Len DATE NOT NULL,
    Num_Attended_Sessions INT NOT NULL,
    PRIMARY KEY (Member_ID, Service_Name),
	constraint fk_Uses_Service_Member
		FOREIGN KEY (Member_ID) REFERENCES Members(Member_ID)
			ON DELETE CASCADE
			ON UPDATE CASCADE,
	constraint fk_Uses_Service_Service
		FOREIGN KEY (Service_Name) REFERENCES Extra_Service(Service_Name)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION
);

-- Create Attends_Class Table
CREATE TABLE Attends_Class (
    Member_ID INT,
    Class_Type VARCHAR(50),
    Num_Attended_Classes INT NOT NULL,
    Num_Of_Classes INT NOT NULL,
    PRIMARY KEY (Member_ID, Class_Type),
	constraint fk_Attends_Class_Member
		FOREIGN KEY (Member_ID) REFERENCES Members(Member_ID)
			ON DELETE CASCADE
			ON UPDATE CASCADE,
	constraint fk_Attends_Class_Type
		FOREIGN KEY (Class_Type) REFERENCES Classes(Class_Type)
			ON DELETE NO ACTION
			ON UPDATE NO ACTION 
);

-- CHANGES --
ALTER TABLE Staff DROP COLUMN Salary;
ALTER TABLE Members DROP COLUMN Membership_Fees;
ALTER TABLE Classes DROP COLUMN Price;
ALTER TABLE Extra_Service DROP COLUMN Price;
ALTER TABLE PT_Session DROP COLUMN Price;
ALTER TABLE Attends_Class DROP COLUMN Num_Of_Classes;

INSERT INTO Users (Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact, Contact_Info) VALUES
('Galal', 'Mohamed', 1, 20, '123', 012, 012);

INSERT INTO Users (Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact, Contact_Info) VALUES
('John', 'JJJ', 1, 22, '1234', 015, 015);

INSERT INTO Users (Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact, Contact_Info) VALUES
('JJJ', 'James', 1, 21, '12345', 011, 011);

INSERT INTO Users (Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact, Contact_Info) VALUES
('Om', 'Sayed', 0, 101, '123456', 010, 010);

INSERT INTO Users (Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact, Contact_Info) VALUES
('3m', 'Ragab', 1, 1000, '1234567', 000, 000);

INSERT INTO Users (Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact, Contact_Info) VALUES
('Elon', 'Musk', 1, 50, '12', 911, 911);

INSERT INTO Users (Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact, Contact_Info) VALUES
('Jeff', 'Bezos', 1, 55, '1', 121, 121);

INSERT INTO Staff (Staff_ID, Role) VALUES
(101, 'Front Desk');

INSERT INTO Staff (Staff_ID, Role) VALUES	-- Om Sayed
(103, 'Trainer');

INSERT INTO Staff (Staff_ID, Role) VALUES	-- 3m Ragab
(104, 'Trainer');

INSERT INTO Staff (Staff_ID, Role) VALUES	-- Elon
(105, 'Manager');

INSERT INTO Staff (Staff_ID, Role) VALUES	-- Bezos
(106, 'Manager');

INSERT INTO Members(Member_ID, Renewal_Date) VALUES
(100, '2024-1-1');

INSERT INTO Members(Member_ID, Renewal_Date) VALUES
(102, '2023-12-30');

INSERT INTO Financial_Records(Transaction_Type, Transaction_Amount) VALUES ('Salary_Staff', 2000);
INSERT INTO Financial_Records(Transaction_Type, Transaction_Amount) VALUES ('Salary_Admin', 4000);
INSERT INTO Financial_Records(Transaction_Type, Transaction_Amount) VALUES ('Membership_fees', 500);
INSERT INTO Financial_Records(Transaction_Type, Transaction_Amount) VALUES ('Class_payment', 2000);
INSERT INTO Financial_Records(Transaction_Type, Transaction_Amount) VALUES ('Extra_Service_payment', 500);
INSERT INTO Financial_Records(Transaction_Type, Transaction_Amount) VALUES ('PT_Session_payment', 1000);
INSERT INTO Financial_Records(Transaction_Type, Transaction_Amount) VALUES ('Equipment_payment', 10000);
INSERT INTO Financial_Records(Transaction_Type, Transaction_Amount) VALUES ('High_severity_maintenance', 1000);
INSERT INTO Financial_Records(Transaction_Type, Transaction_Amount) VALUES ('Mid_severity_maintenance', 500);
INSERT INTO Financial_Records(Transaction_Type, Transaction_Amount) VALUES ('Low_severity_maintenance', 100);

INSERT INTO Staff_Trans (Staff_ID, Transaction_Type, Transaction_Date) VALUES (101, 'Salary_Staff', '2023-12-13');
INSERT INTO Staff_Trans (Staff_ID, Transaction_Type, Transaction_Date) VALUES (101, 'Salary_Staff', '2023-11-13');
INSERT INTO Staff_Trans (Staff_ID, Transaction_Type, Transaction_Date) VALUES (101, 'Salary_Staff', '2024-11-13');
INSERT INTO Staff_Trans (Staff_ID, Transaction_Type, Transaction_Date) VALUES (101, 'Salary_Staff', '2025-11-13');

INSERT INTO Mem_Trans (Member_ID, Transaction_Type, Transaction_Date) VALUES (100, 'Membership_fees', '2023-12-13');
INSERT INTO Mem_Trans (Member_ID, Transaction_Type, Transaction_Date) VALUES (102, 'Membership_fees', '2023-11-13');
INSERT INTO Mem_Trans (Member_ID, Transaction_Type, Transaction_Date) VALUES (100, 'Membership_fees', '2024-11-13');
INSERT INTO Mem_Trans (Member_ID, Transaction_Type, Transaction_Date) VALUES (102, 'Membership_fees', '2025-11-13');

INSERT INTO Suppliers(Brand_Name) VALUES
('GYM BRAND 1');
INSERT INTO Suppliers(Brand_Name) VALUES
('GYM BRAND 2');
INSERT INTO Suppliers(Brand_Name) VALUES
('GYM BRAND 3');
INSERT INTO Suppliers(Brand_Name) VALUES
('GYM BRAND 4');

INSERT INTO Equipment(Model, Purchase_Date, Maintenance_Sched, Status, Supplier_ID) VALUES
('BENCH PRESS', '2023-11-13', '2023-12-13', 'Good', 1000);
INSERT INTO Equipment(Model, Purchase_Date, Maintenance_Sched, Status, Supplier_ID) VALUES
('SHOULDER PRESS', '2022-11-13', '2022-12-13', 'Good', 1001);
INSERT INTO Equipment(Model, Purchase_Date, Maintenance_Sched, Status, Supplier_ID) VALUES
('SQUAT RACK', '2023-5-13', '2023-6-13', 'Good', 1001);
INSERT INTO Equipment(Model, Purchase_Date, Maintenance_Sched, Status, Supplier_ID) VALUES
('DUMBELL RACK', '2023-11-1', '2023-12-1', 'Good', 1002);

INSERT INTO Classes(Class_Type, Class_Mgr, Availability, Description, Instructor_ID, Date, Time, Location, Registered_Num, Class_Max_Limit) VALUES
('Yoga1', 105, 1, 'Nice Yoga', 103, '2023-12-30', '13:00', 'Basement', 0, 100);
INSERT INTO Classes(Class_Type, Class_Mgr, Availability, Description, Instructor_ID, Date, Time, Location, Registered_Num, Class_Max_Limit) VALUES
('Air Bending', 106, 1, 'Avatar', 104, '2023-12-25', '9:00', 'Everest', 0, 10);
INSERT INTO Classes(Class_Type, Class_Mgr, Availability, Description, Instructor_ID, Date, Time, Location, Registered_Num, Class_Max_Limit) VALUES
('Fire Bending', 105, 1, 'Avatar 2', 103, '2024-1-1', '6:00', 'Pompei', 0, 200);
INSERT INTO Classes(Class_Type, Class_Mgr, Availability, Description, Instructor_ID, Date, Time, Location, Registered_Num, Class_Max_Limit) VALUES
('Water Bending', 106, 1, 'Avatar 3', 104, '2023-12-20', '23:00', 'Bermuda Triangle', 0, 50);

INSERT INTO Attends_Class(Member_ID, Class_Type, Num_Attended_Classes) VALUES
(100, 'Air Bending', 0);
INSERT INTO Attends_Class(Member_ID, Class_Type, Num_Attended_Classes) VALUES
(102, 'Yoga1', 0);
INSERT INTO Attends_Class(Member_ID, Class_Type, Num_Attended_Classes) VALUES
(100, 'Fire Bending', 0);
INSERT INTO Attends_Class(Member_ID, Class_Type, Num_Attended_Classes) VALUES
(102, 'Water Bending', 0);

INSERT INTO Extra_Service(Service_Name, Availability, Description, Service_Mgr_ID) VALUES
('Massage', 1, 'Chill', 105);
INSERT INTO Extra_Service(Service_Name, Availability, Description, Service_Mgr_ID) VALUES
('Jacuzzi', 1, 'Chill More', 106);
INSERT INTO Extra_Service(Service_Name, Availability, Description, Service_Mgr_ID) VALUES
('Tan', 1, 'Chill More More', 105);
INSERT INTO Extra_Service(Service_Name, Availability, Description, Service_Mgr_ID) VALUES
('Oil', 1, 'Sad', 106);

INSERT INTO Uses_Service(Member_ID, Service_Name, Subscription_Len, Num_Attended_Sessions) VALUES
(100, 'Massage', '2023-12-30', 0);
INSERT INTO Uses_Service(Member_ID, Service_Name, Subscription_Len, Num_Attended_Sessions) VALUES
(102, 'Jacuzzi', '2023-12-25', 0);
INSERT INTO Uses_Service(Member_ID, Service_Name, Subscription_Len, Num_Attended_Sessions) VALUES
(100, 'Tan', '2023-12-20', 0);
INSERT INTO Uses_Service(Member_ID, Service_Name, Subscription_Len, Num_Attended_Sessions) VALUES
(102, 'Oil', '2024-1-1', 0);	

