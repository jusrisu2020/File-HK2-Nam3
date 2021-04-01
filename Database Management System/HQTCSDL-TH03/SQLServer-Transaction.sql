CREATE DATABASE TestDB;
------------------------------------------------------------------------------- 
-- Part 1   Experimenting with single transactions 
--            - "Logical Units of Work"
------------------------------------------------------------------------------- 

-- Exercise 1.1

USE TestDB;
--  Autocommit mode.  This the default, but can be ensured by
SET IMPLICIT_TRANSACTIONS OFF;

CREATE TABLE T (id INT NOT NULL PRIMARY KEY, s VARCHAR(30), si SMALLINT);
INSERT INTO T (id, s) VALUES (1, 'first');
ROLLBACK; 
SELECT * FROM T; 
-- Did ROLLBACK have any effect?
 -- an explicit transaction begins
 
INSERT INTO T (id, s) VALUES (2, 'second');
SELECT * FROM T; 
ROLLBACK;

-- Exercise 1.2
INSERT INTO T (id, s) VALUES (3, 'third');
ROLLBACK;
SELECT * FROM T;
COMMIT;
-- Does SQL Server accept COMMIT or ROLLBACK in AUTOCOMMIT mode?

-- Exercise 1.3
BEGIN TRANSACTION;
DELETE FROM T WHERE id > 1;
COMMIT;
SELECT * FROM T;

-- Exercise 1.4
-- DDL stands for Data Definition Language.  In SQL the statements like 
-- CREATE, ALTER and DROP are called DDL statements.
-- Now let's test use of DDL commands in a transaction!
SET IMPLICIT_TRANSACTIONS ON;
INSERT INTO T (id, s) VALUES (2, 'will this be committed?');
CREATE TABLE T2 (id INT);  -- testing use of a DDL command in atransaction!
INSERT INTO T2 (id) VALUES (1);
SELECT * FROM T2;
ROLLBACK;
GO  -- GO marks the end of a batch of SQL commands to be sent to the server

SELECT * FROM T;  -- What has happened to T ?
SELECT * FROM T2; -- What has happened to T2 ?
-- What we learned from this experiment?

-- Exercise 1.5
DELETE FROM T WHERE id > 1;
COMMIT;

------------------------------------------------------------------
-- Testing if an error would lead to automatic rollback in SQL Server?
--   @@ERROR is the SQLCode indicator in Transact-SQL, and
--   @@ROWCOUNT is the count indicator of the effected rows
------------------------------------------------------------------
INSERT INTO T (id, s) VALUES (2, 'The test starts by this');
-- division by zero should fail
SELECT 1/0 AS dummy;   -- division by zero should fail
SELECT @@ERROR AS 'sqlcode'
-- Next updating an non-existing row 
UPDATE T SET s = 'foo' WHERE id = 9999;  
SELECT @@ROWCOUNT AS 'Updated'
-- and deleting an non-existing row 
DELETE FROM T WHERE id = 7777; 
SELECT @@ROWCOUNT AS 'Deleted'
COMMIT;
SELECT * FROM T;
--
INSERT INTO T (id, s) VALUES (2, 'Hi, I am a duplicate')
INSERT INTO T (id, s) VALUES (3, 'How about inserting too long string value?')
INSERT INTO T (id, s, si) VALUES (4, 'Smallint overflow for 32769?', 32769);
INSERT INTO T (id, s) VALUES (5, 'Is the transaction still active?');
COMMIT;
-- Did the whole transaction succeed, do we see all inserted rows?
SELECT * FROM T;
GO
DELETE FROM T WHERE id > 1;
SELECT * FROM T;
COMMIT;

------------------------------------------------------------------
-- Exercise 1.5b
-- This is special to SQL Server only!
SET XACT_ABORT ON;  -- In this mode an error generates automatic rollback 
SET IMPLICIT_TRANSACTIONS ON;
SELECT 1/0 AS dummy;   -- division by zero
INSERT INTO T (id, s) VALUES (6, 'insert after arithm. error');
COMMIT;
GO
SET XACT_ABORT OFF; -- In this mode an error does not generate automatic rollback
SELECT * FROM T;
-- What happened to the transaction?

--================================================================
-- A1.2   Experimenting with Transaction Logic
------------------------------------------------------------------
-- Exercise 1.6: COMMIT and ROLLBACK
------------------------------------------------------------------
SET NOCOUNT ON;  -- skipping the "n row(s) affected" messages
DROP TABLE Accounts;
SET IMPLICIT_TRANSACTIONS ON;
-- 
CREATE TABLE Accounts (
acctID  INTEGER NOT NULL PRIMARY KEY,
balance INTEGER NOT NULL 
        CONSTRAINT unloanable_account CHECK (balance >= 0)
);
COMMIT;
INSERT INTO Accounts (acctID,balance) VALUES (101,1000);
INSERT INTO Accounts (acctID,balance) VALUES (202,2000);
SELECT * FROM Accounts;
COMMIT;

-- let’s try the bank transfer
UPDATE Accounts SET balance = balance - 100 WHERE acctID = 101;
UPDATE Accounts SET balance = balance + 100 WHERE acctID = 202;
SELECT * FROM Accounts;
ROLLBACK;

-- Let's test the CHECK constraint actually work:
UPDATE Accounts SET balance = balance - 2000 WHERE acctID = 101;
UPDATE Accounts SET balance = balance + 2000 WHERE acctID = 202;
SELECT * FROM Accounts ; 
ROLLBACK;

-- Transaction logic 
-- using the IF structure of Transact-SQL 
SELECT * FROM Accounts;
UPDATE Accounts SET balance = balance - 2000 WHERE acctID = 101;
IF @@error <> 0 OR @@rowcount = 0
   ROLLBACK 
ELSE BEGIN
   UPDATE Accounts SET balance = balance + 2000 WHERE acctID = 202;
   IF @@error <> 0 OR @@rowcount = 0
      ROLLBACK
   ELSE 
      COMMIT;
   END;

SELECT * FROM Accounts;
COMMIT;

-- Restoring the original contents
DELETE FROM Accounts;
INSERT INTO Accounts (acctID,balance) VALUES (101,1000);
INSERT INTO Accounts (acctID,balance) VALUES (202,2000);
SELECT * FROM Accounts;
COMMIT;

-- How about using a non-existent bank account
UPDATE Accounts SET balance = balance - 500 WHERE acctID = 101;
UPDATE Accounts SET balance = balance + 500 WHERE acctID = 777;
SELECT * FROM Accounts ; 
ROLLBACK;

-- Fixing the case using the IF structure of Transact-SQL 
SELECT * FROM Accounts;
UPDATE Accounts SET balance = balance - 500 WHERE acctID = 101;
IF @@error <> 0 OR @@rowcount = 0
   ROLLBACK 
ELSE BEGIN
   UPDATE Accounts SET balance = balance + 500 WHERE acctID = 707;
   IF @@error <> 0 OR @@rowcount = 0
      ROLLBACK
   ELSE 
      COMMIT;
   END;
SELECT * FROM Accounts;
COMMIT;

