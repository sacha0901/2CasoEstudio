

-- Crear la base de datos MyCompany
CREATE DATABASE MyCompany;

-- Usar la base de datos MyCompany
USE MyLaboratory;

-- Crear la tabla Employee
CREATE TABLE Employee (
    IdPK INT IDENTITY(1,1) PRIMARY KEY,
    IdNumber VARCHAR(10) NOT NULL,
    Name NVARCHAR(80) NOT NULL,
    Mail NVARCHAR(255) NOT NULL,
    Birthday DATE NOT NULL
);

-- Insertar datos en la tabla Employee
INSERT INTO Employee (IdNumber, Name, Mail, Birthday)
VALUES
('658542361', 'Juan Gabriel', 'Juan@gmail.com', '24/05/2000'),
('6587542362', 'Gonazalo', 'Gonazalo@gmail.com', '24/05/2000')

SELECT * FROM Employee