CREATE DATABASE employees;
USE employees;
/* type commands with uppercase*/
CREATE table people 
( id INT NOT NULL PRIMARY KEY AUTO_INCREMENT,
email VARCHAR(40) NOT NULL, /* meaning it is necessary that there is an email, if it is only NULL , email is not necessary */
first_name VARCHAR(40) NOT NULL,
last_name VARCHAR(40) NOT NULL 
);
/*  `email`             `first_name`  `this is for table names`
	'john@gmail.com'     'John'       'this is for values'*/

INSERT INTO `people` (`email`, `first_name`, `last_name`)
VALUES('john@gmail.com', 'John', 'Littlecovich'),
	  ('jerry@abv.bg', 'Jerry', 'Notbruccheimer'),
      ('lala@g.com', 'Lala', 'Lulu'),
      ('kiki@ki.com', 'Kikimora', 'Dyavolitova');
/* <*> a star in SQL means all -> SELECT * FROM `where `means select all from where */

SELECT * FROM `people`;
SELECT `first_name` FROM `people`;
SELECT `first_name`, `last_name` FROM `people` LIMIT 3;


SELECT * FROM `people` 
WHERE `first_name` = 'John' /* AND, OR, BETWEEN*/ OR `first_name` = 'Jerry';

UPDATE `people`
SET first_name = 'Peter'
WHERE last_name = 'Littlecovich';

SELECT * FROM `people`
WHERE last_name = 'Littlecovich';

UPDATE `people`
SET first_name = 'James'
WHERE id = 3;

DELETE FROM `people`
WHERE id = 2;

TRUNCATE TABLE `people`; /*deletes all date from the table*/ /*cannot be undone*/
SELECT * FROM `people`;
DROP TABLE `people`; /*cannot be undone*/
DROP DATABASE `employees`; /*to delete the DB*/ /*cannot be undone*/