-- Disable all foreign key constraints
EXEC sp_MSforeachtable "ALTER TABLE ? NOCHECK CONSTRAINT all"

-- Disable all triggers
EXEC sp_MSforeachtable "DISABLE TRIGGER all ON ?"

-- Delete all data from all tables
EXEC sp_MSforeachtable "DELETE FROM ?"

DBCC CHECKIDENT ('Addresses', RESEED, 0);
DBCC CHECKIDENT ('CareCenters', RESEED, 0);
DBCC CHECKIDENT ('Residents', RESEED, 0);
DBCC CHECKIDENT ('Diagnoses', RESEED, 0);
DBCC CHECKIDENT ('Prescriptions', RESEED, 0);
DBCC CHECKIDENT ('Roles', RESEED, 0);
DBCC CHECKIDENT ('Employees', RESEED, 0);
DBCC CHECKIDENT ('Assignments', RESEED, 0);
DBCC CHECKIDENT ('Medications', RESEED, 0);
DBCC CHECKIDENT ('SubTasks', RESEED, 0);



-- Addresses
INSERT INTO Addresses (Street, City, State, ZipCode) VALUES
('Østerbrogade 34', 'København', 'Hovedstaden', '2100'),
('Nørrebrogade 18', 'København', 'Hovedstaden', '2200'),
('Vesterbrogade 45', 'København', 'Hovedstaden', '1620'),
('Algade 12', 'Roskilde', 'Sjælland', '4000'),
('H.C. Andersens Boulevard 8', 'Odense', 'Fyn', '5000');

-- CareCenters
INSERT INTO CareCenters (Name, AddressId) VALUES
('Plejecenter Østerbro', 1),
('Plejecenter Nørrebro', 2),
('Plejecenter Vesterbro', 3),
('Plejecenter Roskilde', 4),
('Plejecenter Odense', 5);

-- Residents
INSERT INTO Residents (Name, BirthDate, RoomNumber, Notes, CareCenterId) VALUES
('Anna Hansen', '1935-05-14', '101', 'Har brug for daglig medicinering', 1),
('Bjørn Nielsen', '1942-11-23', '102', 'Lider af demens', 1),
('Carla Jørgensen', '1938-08-12', '201', 'Har behov for fysioterapi', 2),
('David Larsen', '1945-02-05', '202', 'Har diabetes', 2),
('Eva Petersen', '1930-07-19', '301', 'Bruger kørestol', 3);

-- Diagnoses
INSERT INTO DIAGNOSES(Name, Description, ResidentID) VALUES
('Demens', 'Kognitiv svækkelse', 2),
('Diabetes', 'Blodsukker problemer', 4),
('Arthritis', 'Ledbetændelse', 3),
('Højt blodtryk', 'Hypertension', 5);

-- Prescriptions
INSERT INTO Prescriptions(Name, Amount, Unit, ResidentID) VALUES
('Metformin', 500, 'mg', 4),
('Aspirin', 100, 'mg', 3),
('Lisinopril', 10, 'mg', 5),
('Donepezil', 5, 'mg', 2);

-- Roles
INSERT INTO Roles(RoleName) VALUES
('SoSu Hjælper'),
('Task Manager'),
('Administrator');

-- Employees
INSERT INTO Employees(Name, CareCenterId) VALUES
('Dr. Karen Madsen', 1),
('Sygeplejerske Lise Sørensen', 1),
('Fysioterapeut Jakob Hansen', 2),
('Administrator Mette Thomsen', 3),
('Sygeplejerske Søren Kristensen', 4);

-- EmployeeRole
INSERT INTO EmployeeRole(EmployeesEmployeeId, RolesRoleId) VALUES
(1, 1),
(2, 2),
(3, 3),
(4, 3),
(4, 2),
(5, 1),
(5, 2);

-- Assignments

-- Resident 1
INSERT INTO Assignments (TimeStart, TimeEnd, ResidentId) VALUES
('2022-01-01 08:00:00', '2022-01-01 08:45:00', 1),
('2022-01-01 08:50:00', '2022-01-01 09:35:00', 2),
('2022-01-01 09:40:00', '2022-01-01 10:25:00', 3),
('2022-01-01 11:20:00', '2022-01-01 12:05:00', 4),
('2022-01-01 12:10:00', '2022-01-01 12:55:00', 5),
('2022-01-01 13:00:00', '2022-01-01 13:45:00', 3),
('2022-01-01 13:50:00', '2022-01-01 14:35:00', 1),
('2022-01-01 14:40:00', '2022-01-01 15:25:00', 2);

-- SubTasks
-- SubTasks

-- Assignment 1
INSERT INTO SubTasks (Name, AssignmentId, IsCompleted, SubTaskType) VALUES
('Hjælp med morgenmad', 1, 1, 'SubTask'),
('Hjælp med bad', 1, 1, 'SubTask'),
('Hjælp med påklædning', 1, 1, 'SubTask'),
('Vask gulv', 1, 1, 'SubTask'),
('Luft ud', 1, 1, 'SubTask');

-- Assignment 2
INSERT INTO SubTasks (Name, AssignmentId, IsCompleted, SubTaskType) VALUES
('Støv af', 2, 0, 'SubTask'),
('Rens sofa', 2, 1, 'SubTask'),
('Køb chokolade', 2, 0, 'SubTask'),
('Køb blomster fra Bjørn til Carla', 2, 1, 'SubTask');

-- Assignment 3
INSERT INTO SubTasks (Name, AssignmentId, IsCompleted, SubTaskType) VALUES
('Find fjernbetjening', 3, 0, 'SubTask'),
('Læg vasketøj sammen', 3, 1, 'SubTask'),
('Læs dagens avis højt', 3, 1, 'SubTask'),
('Plant nye blomster i haven', 3, 0, 'SubTask');

-- Assignment 4
INSERT INTO SubTasks (Name, AssignmentId, IsCompleted, SubTaskType) VALUES
('Lav en kop te', 4, 1, 'SubTask'),
('Find læsebriller', 4, 1, 'SubTask'),
('Opdatér familiens kontaktinformationer', 4, 0, 'SubTask'),
('Køb ind til aftensmad', 4, 0, 'SubTask');

-- Assignment 5
INSERT INTO SubTasks (Name, AssignmentId, IsCompleted, SubTaskType) VALUES
('Hjælp med at skrive brev', 5, 0, 'SubTask'),
('Gå en tur i parken', 5, 0, 'SubTask'),
('Sæt yndlingsmusik på', 5, 1, 'SubTask'),
('Træn let motion', 5, 1, 'SubTask');

-- Assignment 6
INSERT INTO SubTasks (Name, AssignmentId, IsCompleted, SubTaskType) VALUES
('Giv kattemad', 6, 1, 'SubTask'),
('Skift sengetøj', 6, 1, 'SubTask'),
('Organisér medicinskab', 6, 1, 'SubTask'),
('Læs en bog sammen', 6, 0, 'SubTask');

-- Assignment 7
INSERT INTO SubTasks (Name, AssignmentId, IsCompleted, SubTaskType) VALUES
('Lav en indkøbsliste', 7, 1, 'SubTask'),
('Tag et selfie', 7, 0, 'SubTask'),
('Lyt til en radioudsendelse', 7, 1, 'SubTask'),
('Hjælp med at finde gamle fotos', 7, 0, 'SubTask');

-- Assignment 8
INSERT INTO SubTasks (Name, AssignmentId, IsCompleted, SubTaskType) VALUES
('Skriv dagbog', 8, 0, 'SubTask'),
('Giv planten vand', 8, 1, 'SubTask'),
('Hent post', 8, 1, 'SubTask'),
('Se en film sammen', 8, 0, 'SubTask');

-- MedicineTasks
INSERT INTO SubTasks (Name, AssignmentId, IsCompleted, SubTaskType, MedicineId, Unit, Amount) VALUES
('Tag medicin', 2, 0, 'MedicineTask', 1, 'mg', 500),
('Tag medicin', 2, 0, 'MedicineTask', 2, 'mg', 200),
('Tag medicin', 2, 1, 'MedicineTask', 2, 'mg', 200);

-- Medications

INSERT INTO Medications(Name) VALUES
('Metformin'),
('Aspirin'),
('Lisinopril'),
('Donepezil');

-- AssignmentEmployee
INSERT INTO AssignmentEmployee(TasksAssignmentId, EmployeesEmployeeId) VALUES
(1, 2),
(2, 2),
(3, 2),
(4, 2),
(5, 2),
(6, 2),
(7, 2),
(8, 2);

-- Re-enable all foreign key constraints
EXEC sp_MSforeachtable "ALTER TABLE ? WITH CHECK CHECK CONSTRAINT all"

-- Re-enable all triggers
EXEC sp_MSforeachtable "ENABLE TRIGGER all ON ?"