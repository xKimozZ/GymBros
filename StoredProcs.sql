
USE GymBrosDB;

CREATE PROCEDURE AddMemberProcedure
    @Fname NVARCHAR(50),
    @Lname NVARCHAR(50),
    @pass NVARCHAR(50),
    @age INT,
    @contactInfo INT,
    @emergencyContact INT,
    @gender INT
AS
BEGIN
    INSERT INTO Users (Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact, Contact_Info)
    VALUES (@Fname, @Lname, @gender, @age, @pass, @emergencyContact, @contactInfo);

    INSERT INTO Members (Member_ID, Renewal_Date)
    VALUES (SCOPE_IDENTITY(), DATEADD(MONTH, 1, GETDATE()));
END;

CREATE PROCEDURE AddStaffProcedure
    @Fname NVARCHAR(50),
    @Lname NVARCHAR(50),
    @pass NVARCHAR(50),
    @age INT,
    @contactInfo INT,
    @emergencyContact INT,
    @gender INT,
    @Role NVARCHAR(50)
AS
BEGIN
    INSERT INTO Users (Fname, Lname, Gender, Age, Account_Pass, Emrgncy_Contact, Contact_Info)
    VALUES (@Fname, @Lname, @gender, @age, @pass, @emergencyContact, @contactInfo);

    INSERT INTO Staff (Staff_ID, Role)
    VALUES (SCOPE_IDENTITY(), @Role);
END;

CREATE PROCEDURE UpdateUserProcedure
    @userId INT,
    @newFname NVARCHAR(50),
    @newLname NVARCHAR(50),
    @newPass NVARCHAR(50),
    @newAge INT,
    @newContactInfo INT,
    @newEmergencyContact INT,
    @newGender INT
AS
BEGIN
    UPDATE Users
    SET Fname = @newFname, Lname = @newLname, Gender = @newGender,
        Age = @newAge, Account_Pass = @newPass,
        Emrgncy_Contact = @newEmergencyContact, Contact_Info = @newContactInfo
    WHERE User_ID = @userId;
END;

CREATE PROCEDURE AddOrUpdateBodyCompositionProcedure
    @memberId INT,
    @height INT,
    @weight INT,
    @musclePercentage FLOAT,
    @bodyFatPercentage FLOAT,
    @bodyType NVARCHAR(50),
    @chronicDisease NVARCHAR(50)
AS
BEGIN
    IF EXISTS (SELECT 1 FROM Body_Composition WHERE Member_ID = @memberId)
    BEGIN
        UPDATE Body_Composition
        SET Height = @height,
            Weight = @weight,
            Muscle_Prcntg = @musclePercentage,
            BodyFat_Prcntg = @bodyFatPercentage,
            Body_Type = @bodyType,
            Chronic_Disease = @chronicDisease
        WHERE Member_ID = @memberId;
    END
    ELSE
    BEGIN
        INSERT INTO Body_Composition (Member_ID, Height, Weight, Muscle_Prcntg, BodyFat_Prcntg, Body_Type, Chronic_Disease)
        VALUES (@memberId, @height, @weight, @musclePercentage, @bodyFatPercentage, @bodyType, @chronicDisease);
    END
END;

CREATE PROCEDURE SendAnnouncementProcedure
    @senderId INT,
    @messageText NVARCHAR(200)
AS
BEGIN
    INSERT INTO Announcements (Message_Date, Message_Text, Sender_ID)
    VALUES (GETDATE(), @messageText, @senderId);
END;


CREATE PROCEDURE UpdateSessionCheckInStatusProcedure
    @sessionId INT,
    @memberId INT
AS
BEGIN
    UPDATE PT_Session
    SET Did_Attend = 1
    WHERE Session_ID = @sessionId
        AND Member_ID = @memberId;
END;

CREATE PROCEDURE AddPrivateSessionProcedure
    @memberId INT,
    @staffId INT,
    @sessionDate DATE,
    @didAttend BIT
AS
BEGIN
    INSERT INTO PT_Session (Date, Member_ID, Staff_ID, Did_Attend)
    VALUES (@sessionDate, @memberId, @staffId, @didAttend);
END;

CREATE PROCEDURE UpdatePrivateSessionProcedure
    @sessionId INT,
	@memberId INT,
    @sessionDate DATE,
    @didAttend BIT
AS
BEGIN
    UPDATE PT_Session
    SET Date = @sessionDate,
        Did_Attend = @didAttend
    WHERE Session_ID = @sessionId AND Member_ID = @memberId;
END;

CREATE PROCEDURE GetSessionsByStaffProcedure
    @staffId INT
AS
BEGIN
    SELECT Session_ID, Date, Member_ID, Did_Attend
    FROM PT_Session
    WHERE Staff_ID = @staffId;
END;

CREATE PROCEDURE GetStaffAnnouncementsProcedure
AS
BEGIN
    SELECT Announcements.Message_Text, Staff.Staff_ID, Users.Fname + ' ' + Users.Lname AS SenderName, Staff.Role, Announcements.Message_Date
    FROM Announcements
    JOIN Staff ON Announcements.Sender_ID = Staff.Staff_ID
    JOIN Users ON Announcements.Sender_ID = Users.User_ID;
END;

