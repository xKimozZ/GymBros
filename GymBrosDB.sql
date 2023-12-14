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
    Transaction_Date DATE NOT NULL,
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
    PRIMARY KEY (Member_ID, Transaction_Type),
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
    PRIMARY KEY (Staff_ID, Transaction_Type),
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
    PRIMARY KEY (Supplier_ID, Transaction_Type),
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