CREATE TABLE Users (
  userID NUMBER(10) PRIMARY KEY,
  userName VARCHAR2(20) NOT NULL,
  email VARCHAR2(30) NOT NULL,
  AccountPassword VARCHAR2(20) NOT NULL UNIQUE, 
  credit NUMBER(7,2)
);

CREATE TABLE MovieCategory (
  CategoryID NUMBER(3) PRIMARY KEY,
  CategoryName VARCHAR2(20) NOT NULL UNIQUE
);

CREATE TABLE Movies (
  MovieID NUMBER(10) PRIMARY KEY,
  MovieName VARCHAR2(50) NOT NULL UNIQUE,
  MovieDuration NUMBER(3) NOT NULL,
  MovieRate NUMBER(3,1) CHECK (MovieRate BETWEEN 0 AND 10),
  ReleaseDate DATE NOT NULL,
  MovieCategoryID NUMBER(3) REFERENCES MovieCategory(CategoryID) ON DELETE CASCADE
);

CREATE TABLE Shows (
  ShowID NUMBER(10) PRIMARY KEY, 
  ShowName NUMBER(10) NOT NULL,
  MovieID NUMBER(10) REFERENCES Movies(MovieID) ON DELETE CASCADE,
  ShowDayDate DATE NOT NULL,
  startTime TIMESTAMP NOT NULL,
  numberOfSeats NUMBER(3) NOT NULL,
  available_seats NUMBER(3),
  Price NUMBER(5,2) NOT NULL
);

CREATE TABLE SeatTypes (
  TypeID NUMBER(3) PRIMARY KEY,
  TypeName VARCHAR2(20) NOT NULL
);

CREATE TABLE Seats (
  SeatID NUMBER(10) PRIMARY KEY,
  ShowSeatNumber NUMBER(3),
  ShowID NUMBER(10) REFERENCES Shows(ShowID) ON DELETE CASCADE,
  taken NUMBER(1),  -- 0 for not yet, 1 for done
  TypeID NUMBER(3) REFERENCES SeatTypes(TypeID) ON DELETE CASCADE
);

CREATE TABLE reservations (
  resID NUMBER(10) PRIMARY KEY,
  userID NUMBER(10) REFERENCES Users(userID) ON DELETE CASCADE,
  MovieName VARCHAR2(50),
  ShowNumber NUMBER(10),
  ShowID NUMBER(10) REFERENCES Shows(ShowID) ON DELETE CASCADE,
  SeatID NUMBER(10) REFERENCES Seats(SeatID) ON DELETE CASCADE,
  Payment_method VARCHAR2(20) CHECK (Payment_method IN ('Cash','Fawry','Viza')),
  ReservationDate DATE,
  ReservationStatus NUMBER(1)  -- 0 for not yet, 1 for done
);





CREATE SEQUENCE MovieID_Seq
  START WITH 1
  INCREMENT BY 1
  NOCACHE
  NOCYCLE;

CREATE SEQUENCE ShowId_Seq
  START WITH 1
  INCREMENT BY 1
  NOCACHE
  NOCYCL




-- *****************************************************************************************************************




INSERT INTO Users VALUES (1, 'Ahmed', 'ahmed@email.com', 'pass123', 150.00);
INSERT INTO Users VALUES (2, 'Sara', 'sara@email.com', 'sara456', 200.50);
INSERT INTO Users VALUES (3, 'Ali', 'ali@email.com', 'ali789', 300.00);
INSERT INTO Users VALUES (4, 'Mona', 'mona@email.com', 'mona000', 400.75);
INSERT INTO Users VALUES (5, 'Omar', 'omar@email.com', 'omar321', 120.20);

INSERT INTO MovieCategory VALUES (1, 'Action');
INSERT INTO MovieCategory VALUES (2, 'Comedy');
INSERT INTO MovieCategory VALUES (3, 'Drama');
INSERT INTO MovieCategory VALUES (4, 'Horror');
INSERT INTO MovieCategory VALUES (5, 'Sci-Fi');

INSERT INTO Movies VALUES (101, 'Fast & Furious', 120, 7.8, TO_DATE('2021-06-15', 'YYYY-MM-DD'), 1);
INSERT INTO Movies VALUES (102, 'The Hangover', 100, 8.2, TO_DATE('2009-06-05', 'YYYY-MM-DD'), 2);
INSERT INTO Movies VALUES (103, 'The Godfather', 175, 9.2, TO_DATE('1972-03-24', 'YYYY-MM-DD'), 3);
INSERT INTO Movies VALUES (104, 'The Conjuring', 112, 7.5, TO_DATE('2013-07-19', 'YYYY-MM-DD'), 4);
INSERT INTO Movies VALUES (105, 'Interstellar', 169, 8.6, TO_DATE('2014-11-07', 'YYYY-MM-DD'), 5);

INSERT INTO Shows VALUES (201, 1, 101, TO_DATE('2025-05-01', 'YYYY-MM-DD'), TO_TIMESTAMP('2025-05-01 18:00:00', 'YYYY-MM-DD HH24:MI:SS'), 100, 90, 75.00);
INSERT INTO Shows VALUES (202, 2, 102, TO_DATE('2025-05-02', 'YYYY-MM-DD'), TO_TIMESTAMP('2025-05-02 20:00:00', 'YYYY-MM-DD HH24:MI:SS'), 80, 70, 65.00);
INSERT INTO Shows VALUES (203, 3, 103, TO_DATE('2025-05-03', 'YYYY-MM-DD'), TO_TIMESTAMP('2025-05-03 17:00:00', 'YYYY-MM-DD HH24:MI:SS'), 120, 100, 85.00);
INSERT INTO Shows VALUES (204, 4, 104, TO_DATE('2025-05-04', 'YYYY-MM-DD'), TO_TIMESTAMP('2025-05-04 19:00:00', 'YYYY-MM-DD HH24:MI:SS'), 90, 85, 70.00);
INSERT INTO Shows VALUES (205, 5, 105, TO_DATE('2025-05-05', 'YYYY-MM-DD'), TO_TIMESTAMP('2025-05-05 21:00:00', 'YYYY-MM-DD HH24:MI:SS'), 110, 95, 90.00);

INSERT INTO SeatTypes VALUES (1, 'Regular');
INSERT INTO SeatTypes VALUES (2, 'VIP');
INSERT INTO SeatTypes VALUES (3, 'Couple');
INSERT INTO SeatTypes VALUES (4, 'Balcony');
INSERT INTO SeatTypes VALUES (5, 'Recliner');

INSERT INTO Seats VALUES (301, 1, 201, 0, 1);
INSERT INTO Seats VALUES (302, 2, 202, 1, 2);
INSERT INTO Seats VALUES (303, 3, 203, 0, 3);
INSERT INTO Seats VALUES (304, 4, 204, 1, 4);
INSERT INTO Seats VALUES (305, 5, 205, 0, 5);


INSERT INTO reservations VALUES (401, 1, 'Fast & Furious', 1, 201, 301, 'Cash', TO_DATE('2025-04-29', 'YYYY-MM-DD'), 1);
INSERT INTO reservations VALUES (402, 2, 'The Hangover', 2, 202, 302, 'Viza', TO_DATE('2025-04-29', 'YYYY-MM-DD'), 1);
INSERT INTO reservations VALUES (403, 3, 'The Godfather', 3, 203, 303, 'Fawry', TO_DATE('2025-04-29', 'YYYY-MM-DD'), 0);
INSERT INTO reservations VALUES (404, 4, 'The Conjuring', 4, 204, 304, 'Cash', TO_DATE('2025-04-29', 'YYYY-MM-DD'), 1);
INSERT INTO reservations VALUES (405, 5, 'Interstellar', 5, 205, 305, 'Viza', TO_DATE('2025-04-29', 'YYYY-MM-DD'), 0);





-- *****************************************************************************************************************



-- 1. Stored procedure to get user details by ID (using OUT parameters)
CREATE OR REPLACE PROCEDURE GetUserByID 
(
    p_userID IN NUMBER,
    p_userName OUT VARCHAR2,
    p_email OUT VARCHAR2,
    p_credit OUT NUMBER
)
AS
BEGIN
    SELECT userName, email, credit 
    INTO p_userName, p_email, p_credit
    FROM Users
    WHERE userID = p_userID;
EXCEPTION
    WHEN NO_DATA_FOUND THEN
        p_userName := NULL;
        p_email := NULL;
        p_credit := NULL;
END GetUserByID;
/


-- 2. Stored procedure to get movies by category (using SysRefCursor)
CREATE OR REPLACE PROCEDURE GetMoviesByCategory 
(
    p_categoryID IN NUMBER,
    p_movies_cursor OUT SYS_REFCURSOR
)
AS
BEGIN
    OPEN p_movies_cursor FOR
    SELECT m.MovieID, m.MovieName, m.MovieDuration, m.MovieRate, m.ReleaseDate, c.CategoryName
    FROM Movies m
    JOIN MovieCategory c ON m.MovieCategoryID = c.CategoryID
    WHERE m.MovieCategoryID = p_categoryID;
END GetMoviesByCategory;
/


-- 3. Stored procedure to get available shows for a specific movie
CREATE OR REPLACE PROCEDURE GetShowsForMovie
(
    p_movieID IN NUMBER,
    p_shows_cursor OUT SYS_REFCURSOR
)
AS
BEGIN
    OPEN p_shows_cursor FOR
    SELECT s.ShowID, m.MovieName, s.ShowDayDate, s.startTime, s.available_seats, s.Price
    FROM Shows s
    JOIN Movies m ON s.MovieID = m.MovieID
    WHERE s.MovieID = p_movieID
    AND s.available_seats > 0;
END GetShowsForMovie;
/


-- 4. Stored procedure to update available seats
CREATE OR REPLACE PROCEDURE UpdateAvailableSeats
(
    p_showID IN NUMBER,
    p_seatsBooked IN NUMBER
)
AS
BEGIN
    UPDATE Shows
    SET available_seats = available_seats - p_seatsBooked
    WHERE ShowID = p_showID;
    
    COMMIT;
END UpdateAvailableSeats;
/


-- 5. Stored procedure to get reservation details for a user
CREATE OR REPLACE PROCEDURE GetUserReservations
(
    p_userID IN NUMBER,
    p_reservations_cursor OUT SYS_REFCURSOR
)
AS
BEGIN
    OPEN p_reservations_cursor FOR
    SELECT r.resID, r.MovieName, r.ShowNumber, r.ShowID, r.SeatID, r.Payment_method, 
           r.ReservationDate, r.ReservationStatus, st.TypeName as SeatType
    FROM reservations r
    JOIN Seats s ON r.SeatID = s.SeatID
    JOIN SeatTypes st ON s.TypeID = st.TypeID
    WHERE r.userID = p_userID;
END GetUserReservations;
/