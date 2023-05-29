use hosp
CREATE TABLE appointment (
	id INT IDENTITY(1,1) PRIMARY KEY,
	identify_num NVARCHAR(11),
    doctors NVARCHAR(50),
    clinics NVARCHAR(50),
    date DATE
)