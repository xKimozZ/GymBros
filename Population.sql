USE GymBrosDB;

INSERT INTO Users (Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact, Contact_Info)
VALUES
('John', 'Doe', 1, 25, 'password123', 012, 012),
('Jane', 'Smith', 0, 30, 'pass456', 012, 012),
('Alice', 'Johnson', 0, 22, 'pass789', 012, 012),
('Bob', 'Williams', 1, 28, 'passabc', 012, 012),
('Eva', 'Miller', 0, 35, 'passdef', 012, 012),
('David', 'Taylor', 1, 40, 'passghi', 012, 012),
('Sophia', 'Brown', 0, 18, 'passjkl', 012, 012),
('Michael', 'Moore', 1, 32, 'passmno', 012, 012),
('Emma', 'Anderson', 0, 27, 'passpqr', 012, 012),
('Christopher', 'White', 1, 45, 'passstu', 012, 012),
('Olivia', 'Davis', 0, 26, 'passuvw', 012, 012),
('William', 'Jones', 1, 33, 'passxyz', 012, 012),
('Ava', 'Garcia', 0, 29, 'pass123', 012, 012),
('Liam', 'Martinez', 1, 38, 'pass456', 012, 012),
('Isabella', 'Hernandez', 0, 23, 'pass789', 012, 012),
('James', 'Miller', 1, 42, 'passabc', 012, 012),
('Sophie', 'Wilson', 0, 20, 'passdef', 012, 012),
('Ethan', 'Clark', 1, 31, 'passghi', 012, 012),
('Mia', 'Scott', 0, 28, 'passjkl', 012, 012),
('Alexander', 'Lee', 1, 39, 'passmno', 012, 012);

INSERT INTO Staff (Staff_ID, Role)
VALUES
(100, 'Trainer'),
(101, 'Front Desk'),
(102, 'Manager'),
(103, 'Admin'),
(104, 'Trainer'),
(105, 'Front Desk'),
(106, 'Manager'),
(107, 'Admin'),
(108, 'Trainer'),
(109, 'Front Desk');

INSERT INTO Members (Member_ID, Renewal_Date)
VALUES
(110, '2023-02-10'),
(111, '2023-03-15'),
(112, '2023-04-20'),
(113, '2023-05-25'),
(114, '2023-06-30'),
(115, '2023-07-10'),
(116, '2023-08-15'),
(117, '2023-09-20'),
(118, '2023-10-25'),
(119, '2023-11-30');

INSERT INTO Suppliers (Brand_Name)
VALUES
('Supplier A'),
('Supplier B'),
('Supplier C'),
('Supplier D'),
('Supplier E'),
('Supplier F'),
('Supplier G'),
('Supplier H'),
('Supplier I'),
('Supplier J');


INSERT INTO Financial_Records(Transaction_Type, Transaction_Amount) 
VALUES 
('Salary_Staff', 2000),
('Salary_Admin', 4000),
('Membership_fees', 500),
('Class_payment', 2000),
('Extra_Service_payment', 500),
('PT_Session_payment', 1000),
('Equipment_payment', 10000),
('High_severity_maintenance', 1000),
('Mid_severity_maintenance', 500),
('Low_severity_maintenance', 100);

INSERT INTO Announcements (Message_Date, Message_Text, Sender_ID)
VALUES
('2023-01-01', 'Happy New Year!', 102),
('2023-02-14', 'Happy Valentines Day!', 105),
('2023-04-01', 'April Fools!', 103),
('2023-07-04', 'Independence Day Celebration', 104),
('2023-09-01', 'Welcome Back Students!', 106),
('2023-10-31', 'Halloween Party Tomorrow!', 107),
('2023-12-25', 'Merry Christmas!', 108),
('2024-01-01', 'Happy New Year 2024!', 102),
('2024-02-14', 'Valentines Day Specials', 105),
('2024-04-01', 'April Fools Pranks', 103);

INSERT INTO Classes(Class_Type, Class_Mgr, Availability, Description, Instructor_ID, Date, Time, Location, Registered_Num, Class_Max_Limit)
VALUES
('Yoga', 100, 1, 'Nice Yoga', 100, '2023-12-30', '13:00', 'Basement', 0, 100),
('Air Bending', 100, 1, 'Avatar', 104, '2023-12-25', '9:00', 'Everest', 0, 10),
('Fire Bending', 104, 1, 'Avatar 2', 108, '2024-1-1', '6:00', 'Pompei', 0, 200),
('Water Bending', 100, 1, 'Avatar 3', 100, '2023-12-20', '23:00', 'Bermuda Triangle', 0, 50),
('Earth Bending', 104, 1, 'Avatar 4', 104, '2023-12-30', '13:00', 'Basement', 0, 100),
('Zumba', 104, 1, 'Dance fitness party', 108, '2023-12-25', '9:00', 'Everest', 0, 10),
('HIIT', 108, 1, 'High-intensity interval training', 100, '2024-1-1', '6:00', 'Pompei', 0, 200),
('Pilates', 108, 1, 'Core-strengthening exercises', 104, '2023-12-20', '23:00', 'Bermuda Triangle', 0, 50),
('Kickboxing', 104, 1, 'Cardiovascular and strength training', 108, '2024-1-1', '6:00', 'Pompei', 0, 200),
('CrossFit', 108, 1, 'Intense full-body workout', 100, '2023-12-20', '23:00', 'Bermuda Triangle', 0, 50);

INSERT INTO Attends_Class (Member_ID, Class_Type, Num_Attended_Classes)
VALUES
(110, 'Yoga', 0),
(111, 'Kickboxing', 0),
(112, 'Zumba', 0),
(113, 'Air Bending', 0),
(114, 'Water Bending', 0),
(115, 'Kickboxing', 0),
(116, 'HIIT', 0),
(117, 'Pilates', 0),
(118, 'Fire Bending', 0),
(119, 'CrossFit', 0);

INSERT INTO Equipment (Model, Purchase_Date, Maintenance_Sched, Status, Supplier_ID)
VALUES
('Treadmill', '2022-12-01', '2023-01-15', 'Out of Order', 1000),
('Elliptical', '2023-01-05', '2023-02-20', 'Out of Order', 1001),
('Dumbbells', '2023-02-10', '2023-03-25', 'Out of Order', 1002),
('Rowing Machine', '2023-03-15', '2023-04-30', 'Out of Order', 1003),
('Stationary Bike', '2023-04-20', '2023-05-15', 'Out of Order', 1004),
('Smith Machine', '2023-05-25', '2023-06-10', 'Good', 1005),
('Kettlebells', '2023-06-30', '2023-07-25', 'Good', 1006),
('Bench Press', '2023-07-05', '2023-08-10', 'Good', 1007),
('Yoga Mats', '2023-08-15', '2023-09-20', 'Good', 1008),
('Resistance Bands', '2023-09-25', '2023-10-15', 'Good', 1009);

INSERT INTO Extra_Service (Service_Name, Availability, Description, Service_Mgr_ID)
VALUES
('Personal Training', 1, 'One-on-one fitness coaching', 100),
('Nutrition Counseling', 1, 'Diet and nutrition advice', 108),
('Group Fitness Class', 1, 'Join our group workouts', 104),
('Massage Therapy', 1, 'Relax and rejuvenate with massages', 100),
('Sauna Access', 1, 'Enjoy the benefits of the sauna', 104),
('Yoga Workshop', 1, 'Learn and practice yoga', 100),
('Pilates Class', 1, 'Core-strengthening exercises', 108),
('Boxing Lessons', 1, 'Learn the art of boxing', 100),
('Spa Package', 1, 'Indulge in a spa day', 108),
('Cycling Session', 1, 'Get fit with indoor cycling', 104);

INSERT INTO Body_Composition (Member_ID, Height, Weight, Muscle_Prcntg, BodyFat_Prcntg, Body_Type, Chronic_Disease)
VALUES
(110, 170, 70, 30.5, 18.5, 'Athletic', 'None'),
(111, 165, 65, 28.0, 20.0, 'Fit', 'None'),
(112, 175, 80, 25.0, 22.5, 'Average', 'Hypertension'),
(113, 160, 55, 32.0, 15.0, 'Slim', 'None'),
(114, 180, 90, 29.5, 19.0, 'Muscular', 'None'),
(115, 155, 50, 33.5, 14.0, 'Slim', 'None'),
(116, 168, 75, 27.0, 21.5, 'Fit', 'Diabetes'),
(117, 162, 60, 31.0, 16.5, 'Slim', 'None'),
(118, 178, 85, 26.5, 23.0, 'Average', 'None'),
(119, 163, 58, 34.0, 13.5, 'Slim', 'None');

INSERT INTO PT_Session (Date, Member_ID, Staff_ID, Did_Attend)
VALUES
('2023-01-02', 110, 100, 1),
('2023-02-15', 111, 101, 1),
('2023-03-20', 112, 102, 0),
('2024-04-25', 113, 103, NULL),
('2023-05-30', 114, 104, 1),
('2024-06-10', 115, 105, NULL),
('2024-07-15', 116, 106, NULL),
('2023-08-20', 117, 107, 0),
('2023-09-25', 118, 108, 1),
('2024-10-30', 119, 109, NULL);

INSERT INTO Mem_Rcv_Announce (Member_ID, Message_ID)
VALUES
(110, 1),
(111, 2),
(112, 3),
(113, 4),
(114, 5),
(115, 6),
(116, 7),
(117, 8),
(118, 9),
(119, 10);

INSERT INTO Mem_Trans (Member_ID, Transaction_Type, Transaction_Date)
VALUES
(110, 'Membership_fees', '2023-01-10 10:30:00'),
(111, 'Membership_fees', '2023-02-15 12:45:00'),
(112, 'Membership_fees', '2023-03-20 14:20:00'),
(113, 'Membership_fees', '2023-04-25 09:10:00'),
(114, 'Membership_fees', '2023-05-30 11:55:00'),
(115, 'Membership_fees', '2023-06-10 16:40:00'),
(116, 'Membership_fees', '2023-07-15 13:25:00'),
(117, 'Membership_fees', '2023-08-20 15:50:00'),
(118, 'Membership_fees', '2023-09-25 11:15:00'),
(119, 'Membership_fees', '2023-10-30 14:05:00');

INSERT INTO Staff_Rcv_Announce (Staff_ID, Message_ID)
VALUES
(100, 1),
(101, 2),
(102, 3),
(103, 4),
(104, 5),
(105, 6),
(106, 7),
(107, 8),
(108, 9),
(109, 10);

INSERT INTO Staff_Trans (Staff_ID, Transaction_Type, Transaction_Date)
VALUES
(100, 'Salary_Staff', '2023-01-10 10:30:00'),
(101, 'Salary_Staff', '2023-02-15 12:45:00'),
(102, 'Salary_Staff', '2023-03-20 14:20:00'),
(103, 'Salary_Admin', '2023-04-25 09:10:00'),
(104, 'Salary_Staff', '2023-05-30 11:55:00'),
(105, 'Salary_Staff', '2023-06-10 16:40:00'),
(106, 'Salary_Staff', '2023-07-15 13:25:00'),
(107, 'Salary_Admin', '2023-08-20 15:50:00'),
(108, 'Salary_Staff', '2023-09-25 11:15:00'),
(109, 'Salary_Staff', '2023-10-30 14:05:00');

INSERT INTO Supplier_Trans (Supplier_ID, Transaction_Type, Transaction_Date)
VALUES
(1000, 'Equipment_payment', '2023-01-10 10:30:00'),
(1001, 'Equipment_payment', '2023-02-15 12:45:00'),
(1002, 'Equipment_payment', '2023-03-20 14:20:00'),
(1003, 'Equipment_payment', '2023-04-25 09:10:00'),
(1004, 'Equipment_payment', '2023-05-30 11:55:00'),
(1005, 'Equipment_payment', '2023-06-10 16:40:00'),
(1006, 'Equipment_payment', '2023-07-15 13:25:00'),
(1007, 'Equipment_payment', '2023-08-20 15:50:00'),
(1008, 'Equipment_payment', '2023-09-25 11:15:00'),
(1009, 'Equipment_payment', '2023-10-30 14:05:00');

INSERT INTO Maintains (Reporter_ID, Equipment_ID, Request_Date, Dmg_Estimate, Request_Description, Status)
VALUES
(100, 1, '2023-01-05', 3, 'Treadmill belt needs replacement', 'Pending'),
(101, 2, '2023-02-20', 1, 'Elliptical display not working', 'Pending'),
(102, 3, '2023-03-25', 3, 'Dumbbell handle broken', 'Pending'),
(103, 4, '2023-04-30', 5, 'Rowing machine seat torn', 'Pending'),
(104, 5, '2023-05-15', 1, 'Bike pedal loose', 'Pending');

INSERT INTO Uses_Service (Member_ID, Service_Name, Subscription_Len, Num_Attended_Sessions)
VALUES
(110, 'Personal Training', '2023-01-15', 10),
(111, 'Nutrition Counseling', '2023-02-28', 5),
(112, 'Group Fitness Class', '2023-03-31', 12),
(113, 'Massage Therapy', '2023-04-15', 3);


