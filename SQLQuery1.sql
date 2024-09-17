CREATE TABLE TBL_USER(
"NAME" VARCHAR(50)NOT NULL,
SURNAME VARCHAR(50)NOT NULL,
EMAIL VARCHAR(100)NOT NULL,
USERNAME VARCHAR(50),
"PASSWORD" VARCHAR(MAX) NOT NULL,
PROPERTY VARCHAR(50),
CAR_PURCHASE VARCHAR(5),
CONSTRAINT PK_USER PRIMARY KEY (USERNAME)
);


--INSERT INTO TBL_USER VALUES ('Tegra','Balonga','tegrabalonga@gmail.com','userTegra',
--HASHBYTES('SHA2_256','passTegra'), 'Rent an accomodation','Yes')

SELECT * FROM TBL_USER

DELETE FROM TBL_USER WHERE SURNAME = 'Doe';

drop table TBL_USER

CREATE TABLE TBL_USER_DETAILS(
USERNAME VARCHAR(50),
GROSS_MONTHLY_INCOME DECIMAL(9,2)NOT NULL,
ESTIM_MONTHLY_TAX DECIMAL(9,2)NOT NULL,
GROCERIES DECIMAL(9,2)NOT NULL,
WATER_LIGHTS DECIMAL(9,2)NOT NULL,
TRAVEL_COST DECIMAL(9,2)NOT NULL,
CELLPHONE_TELEPHONE VARCHAR(10)NOT NULL,
OTHERS DECIMAL(9,2)NOT NULL,
AVAILABLE_MONEY DECIMAL(9,2),
CONSTRAINT PK_USER_DETAILS PRIMARY KEY (USERNAME),
CONSTRAINT FK_USER_DETAILS FOREIGN KEY (USERNAME) REFERENCES TBL_USER(USERNAME)
);



SELECT * FROM TBL_USER_DETAILS;
select * from TBL_USER;
SELECT * FROM TBL_BUY;
SELECT * FROM TBL_RENT;
SELECT * FROM TBL_VEHICLE;


DELETE FROM TBL_USER where username = 'userTegra' ;
DELETE FROM TBL_USER_DETAILS where username = 'userTegra' ;
DELETE FROM TBL_BUY where username = 'userTegra' ;
DELETE FROM TBL_RENT where username = 'userTegra' ;
DELETE FROM TBL_VEHICLE where username = 'userTegra' ;


CREATE TABLE TBL_RENT(
USERNAME VARCHAR(50),
MONTHLY_RENTAL_AMT INT NOT NULL,
CONSTRAINT PK_RENT PRIMARY KEY (USERNAME),
CONSTRAINT FK_RENT FOREIGN KEY (USERNAME) REFERENCES TBL_USER(USERNAME)
);


CREATE TABLE TBL_BUY(
USERNAME VARCHAR(50),
PURCHASE_PRICE DECIMAL(9,2) NOT NULL,
TOTAL_DEPOSIT DECIMAL(9,2) NOT NULL,
INTEREST_RATE DECIMAL(5,2) NOT NULL,
NO_OF_REPAY_MONTHS INT NOT NULL,
MONTHLY_LOAN_REPAY DECIMAL(9,2)NOT NULL,
CONSTRAINT PK_BUY PRIMARY KEY (USERNAME),
CONSTRAINT FK_BUY FOREIGN KEY (USERNAME) REFERENCES TBL_USER(USERNAME)
);



CREATE TABLE TBL_VEHICLE(
USERNAME VARCHAR(50),
MODEL_MAKE VARCHAR(100)NOT NULL,
PURCHASE_PRICE DECIMAL(9,2)NOT NULL,
TOTAL_DEPOSIT DECIMAL(9,2)NOT NULL,
INTEREST_RATE DECIMAL(9,2)NOT NULL,
ESTIM_INSURANCE DECIMAL(9,2)NOT NULL,
TOTAL_MONTHLY_COST DECIMAL(9,2)NOT NULL,
CONSTRAINT PK_VEHICLE PRIMARY KEY (USERNAME),
CONSTRAINT FK_VEHICLE FOREIGN KEY (USERNAME) REFERENCES TBL_USER(USERNAME)
);


CREATE TABLE TBL_SAVING(
USERNAME VARCHAR(50),
SAVE_AMOUNT DECIMAL(9,2) NOT NULL,
INTEREST DECIMAL(5,2) NOT NULL,
REASON DECIMAL(9,2) NOT NULL,
"DATE" DATE NOT NULL,
MONTHLY_SAVE DECIMAL(9,2),
CONSTRAINT PK_SAVING PRIMARY KEY (USERNAME),
CONSTRAINT FK_SAVING FOREIGN KEY (USERNAME) REFERENCES TBL_USER(USERNAME)
);

drop table TBL_SAVING