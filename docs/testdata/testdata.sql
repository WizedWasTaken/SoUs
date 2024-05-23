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

-- Assignments for Resident 1
INSERT INTO Assignments (Name, TimeStart, TimeEnd, ResidentId, isCompleted) VALUES
('Morgenmedicin', '2024-05-24 07:00:00', '2024-05-24 07:15:00', 1, 0),
('Daglig kontrol', '2024-05-24 07:15:00', '2024-05-24 07:30:00', 1, 0),
('Træning', '2024-05-24 07:30:00', '2024-05-24 07:45:00', 1, 0),
('Frokostmedicin', '2024-05-24 07:45:00', '2024-05-24 08:00:00', 1, 0),
('Eftermiddags hvile', '2024-05-24 08:00:00', '2024-05-24 08:15:00', 1, 0),
('Aftenmedicin', '2024-05-24 08:15:00', '2024-05-24 08:30:00', 1, 0),
('Daglig snak', '2024-05-24 08:30:00', '2024-05-24 08:45:00', 1, 0),
('Fysioterapi', '2024-05-24 08:45:00', '2024-05-24 09:00:00', 1, 0),
('Aftencheck', '2024-05-24 09:00:00', '2024-05-24 09:15:00', 1, 0),
('Natmedicin', '2024-05-24 09:15:00', '2024-05-24 09:30:00', 1, 0);

-- Assignments for Resident 2
INSERT INTO Assignments (Name, TimeStart, TimeEnd, ResidentId, isCompleted) VALUES
('Morgenmedicin', '2024-05-24 09:30:00', '2024-05-24 09:45:00', 2, 0),
('Daglig kontrol', '2024-05-24 09:45:00', '2024-05-24 10:00:00', 2, 0),
('Træning', '2024-05-24 10:00:00', '2024-05-24 10:15:00', 2, 0),
('Frokostmedicin', '2024-05-24 10:15:00', '2024-05-24 10:30:00', 2, 0),
('Eftermiddags hvile', '2024-05-24 10:30:00', '2024-05-24 10:45:00', 2, 0),
('Aftenmedicin', '2024-05-24 10:45:00', '2024-05-24 11:00:00', 2, 0),
('Daglig snak', '2024-05-24 11:00:00', '2024-05-24 11:15:00', 2, 0),
('Fysioterapi', '2024-05-24 11:15:00', '2024-05-24 11:30:00', 2, 0),
('Aftencheck', '2024-05-24 11:30:00', '2024-05-24 11:45:00', 2, 0),
('Natmedicin', '2024-05-24 11:45:00', '2024-05-24 12:00:00', 2, 0);

-- Assignments for Resident 3
INSERT INTO Assignments (Name, TimeStart, TimeEnd, ResidentId, isCompleted) VALUES
('Morgenmedicin', '2024-05-24 12:00:00', '2024-05-24 12:15:00', 3, 0),
('Daglig kontrol', '2024-05-24 12:15:00', '2024-05-24 12:30:00', 3, 0),
('Træning', '2024-05-24 12:30:00', '2024-05-24 12:45:00', 3, 0),
('Frokostmedicin', '2024-05-24 12:45:00', '2024-05-24 13:00:00', 3, 0),
('Eftermiddags hvile', '2024-05-24 13:00:00', '2024-05-24 13:15:00', 3, 0),
('Aftenmedicin', '2024-05-24 13:15:00', '2024-05-24 13:30:00', 3, 0),
('Daglig snak', '2024-05-24 13:30:00', '2024-05-24 13:45:00', 3, 0),
('Fysioterapi', '2024-05-24 13:45:00', '2024-05-24 14:00:00', 3, 0),
('Aftencheck', '2024-05-24 14:00:00', '2024-05-24 14:15:00', 3, 0),
('Natmedicin', '2024-05-24 14:15:00', '2024-05-24 14:30:00', 3, 0);

-- Assignments for Resident 4
INSERT INTO Assignments (Name, TimeStart, TimeEnd, ResidentId, isCompleted) VALUES
('Morgenmedicin', '2024-05-24 14:30:00', '2024-05-24 14:45:00', 4, 0),
('Daglig kontrol', '2024-05-24 14:45:00', '2024-05-24 15:00:00', 4, 0),
('Træning', '2024-05-24 15:00:00', '2024-05-24 15:15:00', 4, 0),
('Frokostmedicin', '2024-05-24 15:15:00', '2024-05-24 15:30:00', 4, 0),
('Eftermiddags hvile', '2024-05-24 15:30:00', '2024-05-24 15:45:00', 4, 0),
('Aftenmedicin', '2024-05-24 15:45:00', '2024-05-24 16:00:00', 4, 0),
('Daglig snak', '2024-05-24 16:00:00', '2024-05-24 16:15:00', 4, 0),
('Fysioterapi', '2024-05-24 16:15:00', '2024-05-24 16:30:00', 4, 0),
('Aftencheck', '2024-05-24 16:30:00', '2024-05-24 16:45:00', 4, 0),
('Natmedicin', '2024-05-24 16:45:00', '2024-05-24 17:00:00', 4, 0);

-- Assignments for Resident 5
INSERT INTO Assignments (Name, TimeStart, TimeEnd, ResidentId, isCompleted) VALUES
('Morgenmedicin', '2024-05-24 17:00:00', '2024-05-24 17:15:00', 5, 0),
('Daglig kontrol', '2024-05-24 17:15:00', '2024-05-24 17:30:00', 5, 0),
('Træning', '2024-05-24 17:30:00', '2024-05-24 17:45:00', 5, 0),
('Frokostmedicin', '2024-05-24 17:45:00', '2024-05-24 18:00:00', 5, 0),
('Eftermiddags hvile', '2024-05-24 18:00:00', '2024-05-24 18:15:00', 5, 0),
('Aftenmedicin', '2024-05-24 18:15:00', '2024-05-24 18:30:00', 5, 0),
('Daglig snak', '2024-05-24 18:30:00', '2024-05-24 18:45:00', 5, 0),
('Fysioterapi', '2024-05-24 18:45:00', '2024-05-24 19:00:00', 5, 0),
('Aftencheck', '2024-05-24 19:00:00', '2024-05-24 19:15:00', 5, 0),
('Natmedicin', '2024-05-24 19:15:00', '2024-05-24 19:30:00', 5, 0);

INSERT INTO Medications(Name, Amount, Unit, Administered, AssignmentId) VALUES
('Metformin', 500, 'mg', 0, 1),
('Aspirin', 100, 'mg', 0, 2),
('Lisinopril', 10, 'mg', 0, 3),
('Donepezil', 5, 'mg', 0, 4),
('Metformin', 500, 'mg', 0, 5),
('Donepezil', 10, 'mg', 0, 5),
('Aspirin', 500, 'mg', 0, 5)

-- AssignmentEmployee ensuring no overlap for employees
INSERT INTO AssignmentEmployee(EmployeesEmployeeId, TasksAssignmentId) VALUES
(2, 1), (2, 2), (2, 3), (2, 4), (2, 5), (2, 6), (2, 7), (2, 8), (2, 9), (2, 10),
(2, 11), (2, 12), (2, 13), (2, 14), (2, 15), (2, 16), (2, 17), (2, 18), (2, 19), (2, 20),
(2, 21), (2, 22), (2, 23), (2, 24), (2, 25), (2, 26), (2, 27), (2, 28), (2, 29), (2, 30),
(5, 31), (5, 32), (5, 33), (5, 34), (5, 35), (5, 36), (5, 37), (5, 38), (5, 39), (5, 40),
(5, 41), (5, 42), (5, 43), (5, 44), (5, 45), (5, 46), (5, 47), (5, 48), (5, 49), (5, 50);
