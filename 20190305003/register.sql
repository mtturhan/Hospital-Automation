use hosp;
CREATE TABLE register (
	id INT IDENTITY(1,1) PRIMARY KEY,
    name NVARCHAR(50),
    surname NVARCHAR(50),
    phone NVARCHAR(11),
    gender NVARCHAR(10),
    birth_date DATE,
    identify_num NVARCHAR(11),
    password NVARCHAR(50)
);