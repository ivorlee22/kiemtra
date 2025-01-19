--CREATE TABLE Weather(
--    id INT PRIMARY KEY,
--	recordDate DATE,
--    temperature int
-- )

--INSERT INTO Weather VALUES(1,'2015-01-01',10)
--INSERT INTO Weather VALUES(2,'2015-01-02',25)
--INSERT INTO Weather VALUES(3,'2015-01-03',20)
--INSERT INTO Weather VALUES(4,'2015-01-04',30)

SELECT * FROM Weather

SELECT w1.id
FROM Weather w1
WHERE w1.temperature > (
    SELECT w2.temperature
    FROM Weather w2
    WHERE w2.recordDate = DATEADD(DAY, -1, w1.recordDate)
)