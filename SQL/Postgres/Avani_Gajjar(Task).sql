-- to see the schemas 
Select * from information_schema.tables;

-- select query
Select * from inventory;

--Distinct 
Select Distinct(name) from category;

--Where Clause 
Select * from city where City='Ahmadnagar';

--Order by: 
Select Payment_id, amount, payment_date from payment order by amount;
Select Payment_id, amount, payment_date from payment order by amount DESC;

--And : 
select * from staff where username='Mike' And password='8cb2237d0679ca88db6464eac60da96345513964';

--Or:
select * from rental where inventory_id=27 or rental_id=25;

--Not:
select address, address2, district, city_id from address where not city_id=439;

--insert:
insert into actor values (205,'Bug','Bonty',NOW()::timestamp);
select * from actor where actor_id=205;

--NUll
select * from staff where picture is null;

--not null
select * from customer where active is not null;

--update 
update rental set return_date=current_date where customer_id=438;
select * from rental where customer_id=438;

-- delete 
delete from actor where actor_id=203;

-- top 
select * from film_category where film_id>=27 limit 10;

-- min and max and as
select max(amount) as max_amt from payment;
select min(amount) as min_amt from payment;

--count 
select distinct(count(name)) from language;

--sum 
select sum(amount) as Grand_total from payment;

--avg
select avg(amount) from payment where staff_id=2;

--like 
select city_id, city from city where city like 'A%i';
select city_id, city from city where city like 'A___i';

--In
select * from Country where Country in ('Peru', 'Mexico', 'Austria');

--Between
select * from address where district between 'England' and 'Maharastra' order by district;

--Alias
select actor_id, first_name, last_update as Timestamp from actor;

--JOINS

--Inner join
--getting detail which staff rented 
select staff.staff_id, rental_id, username,rental.rental_date from staff 
inner join rental on rental.staff_id = staff.staff_id;

--joining 3 tables 
--getting the detail which staff rented to which customer
select staff.staff_id, rental_id, username,rental.rental_date, customer.customer_id, customer.first_name from staff 
inner join rental on rental.staff_id = staff.staff_id
inner join customer on rental.cust_id=customer.customer_id;

--left join
select language.language_id, language.name, film.film_id, film.title from language 
left join film on film.language_id=language.language_id;

--right join 
select staff.staff_id, staff.first_name, store.store_id, store.address_id from staff
right join store on staff.staff_id=store.manager_staff_id;

--full join 
select staff.staff_id, staff.first_name, store.store_id, store.address_id from staff
full join store on staff.staff_id=store.manager_staff_id;

--self join
select A.actor_id, A.first_name AS F_Name, B.last_name AS L_name
from actor A, actor B
where A.actor_id <> B.actor_id
and A.first_name = B.first_name;

--Union
select * from store
union 
select * from inventory;

--Union with where clause 
select * from film_actor where film_id=227
union all 
select * from film_category where film_id=625;

--Group by 
select district,count(address_id) from address group by district;

--Having clause 
select customer_id,avg(amount) from payment group by customer_id having avg(amount)>=3.5;

--Exists
select film_id,title,release_year from film where exists 
(select language_id from language where language_id=1);

--ANY
select film_id,title from film where film_id=any
(select film_id from film_actor where actor_id=27);

--ALL
select city_id,city, country_id from city where country_id=all
(select country_id from country where country_id between 10 and 25);

--SELECT INTO 
select * into backup_inventory from inventory;

--Join and select into 
select staff.staff_id, staff.username, staff.email, address.postal_code, address.phone
into staff_location from staff inner join address on staff.address_id=address.address_id;

select * from staff_location;

--Insert into

--case
SELECT country_id, country, last_update,
CASE
	WHEN country like 'A%' THEN 'The country name start with A'
	WHEN country like 'M%' THEN 'The country name start with M'
	ELSE 'Country name neither start with A nor M'
END AS Country_with_A_AND_M
FROM country;

--COALESCE()
select address,address_id, coalesce(postal_code, '') from address;

--stored procedure
create procedure Film_rating()
language sql
as $$
select film_id,title,description from film where rating='PG-13'
$$;

call film_rating();

select 30+20 as addition;
select 10-27 as subtraction;
select 23*9 as multiplication;
select 22/4 as division;
select 27%5 as modulo;
select 3^2;


select * from actor;
select * from address;
select * from category;
select * from city;
select * from country;
select * from customer;
select * from film;
select * from film_category;
select * from film_actor;
select * from inventory;
select * from language;
select * from payment;
select * from rental;
select * from staff;
select * from store;

--create database
create database temp_database;

--create table
CREATE TABLE Person(
    P_id int,
    F_name varchar(255),
    L_name varchar(255),
    Address varchar(255),
    City varchar(255)
);

INSERT INTO Person (P_id, F_name, L_name, Address, City)
VALUES 
    (1, 'Alice', 'Johnson', '123 Main St', 'New York'),
    (2, 'Bob', 'Smith', '456 Oak Ave', 'Los Angeles'),
    (3, 'Charlie', 'Williams', '789 Pine St', 'Chicago');
select * from person ;

--drop table
drop table staff_loc;

--Alter : add column 
alter table store 
add store_name varchar(200);

select * from store;

--Alter : rename column 
alter table rental 
rename customer_id to cust_id;

select * from rental;

--Alter : change data type 
ALTER TABLE address
ALTER COLUMN address2 TYPE varchar(100) USING address2::varchar(100);

--Alter : drop the column 
alter table store
drop column store_name ;

--constraint 
CREATE TABLE Student(
    Sid int NOT NULL UNIQUE,
    F_name varchar(255),
    L_name varchar(255) NOT NULL,
    City varchar(255)
);

INSERT INTO Student (Sid, F_name, L_name, City)
VALUES 
    (1, 'John', 'Doe', 'New York'),
    (2, 'Jane', 'Smith', 'Los Angeles'),
    (3, 'Bob', 'Johnson', 'Chicago');
select * from student;

--Alter table : Primary key 
ALTER TABLE Person
ADD CONSTRAINT p_id PRIMARY KEY (p_id);

--Alter table : Foreign Key
ALTER TABLE student
ADD FOREIGN KEY (sid) REFERENCES person(p_id);

--check 
ALTER TABLE Person
ADD CONSTRAINT city CHECK (City in ('New York','Los Angeles','Chicago'));

INSERT INTO person VALUES(4,'John','David','101 saint lane','Vegas');

--default
ALTER TABLE film_category
ALTER last_update SET DEFAULT current_date;
select * from film_category;

--index 
CREATE INDEX rental_index
ON rental (rental_id, inventory_id, return_date);

--drop index
drop index rental_index;

--century 
SELECT EXTRACT(CENTURY FROM TIMESTAMP '2024-12-16 12:21:13') as century;

--day 
SELECT EXTRACT(DAY FROM TIMESTAMP '2024-12-16 12:21:13') as day;

--dow : day of the week sun-0 sat-6
SELECT EXTRACT(DOW FROM TIMESTAMP '2024-12-16 12:21:13') as DAY_OF_THE_WEEK;

SELECT CURRENT_TIME;
SELECT CURRENT_DATE;
SELECT CURRENT_TIMESTAMP;
SELECT CURRENT_TIMESTAMP(3);

-- view
CREATE VIEW film_rating_list AS
SELECT film.film_id, film.title, film.rating, inventory.store_id FROM film 
INNER JOIN inventory ON film.film_id=inventory.film_id;

SELECT * FROM film_rating_list;

--drop table
drop table student;

select * from rental where cust_id=438;
select * from rental where 
to_date(to_char(rental_date, 'YYYY/MM/DD'), 'YYYY/MM/DD')='2005-05-31' 
and cust_id=438;

select * into actor2 from city ;
select * from city where city_id=25;
select * from country;

select * from actor;
create table actor2 (actor_id integer, first_name varchar(45), last_name varchar(45),
			   last_update date);
	
CREATE OR REPLACE FUNCTION copy_record2() RETURNS TRIGGER AS $$
BEGIN
  INSERT INTO actor2 (actor_id,first_name,last_name,last_update) 
  VALUES (NEW.actor_id, NEW.first_name, NEW.last_name, NEW.last_update);
  RETURN NULL;
END;
$$ LANGUAGE plpgsql;

CREATE TRIGGER before_insert 
BEFORE INSERT ON actor
FOR EACH ROW EXECUTE FUNCTION copy_record2();

drop trigger before_insert;








INSERT INTO actor VALUES (1093,'avani','b',CURRENT_DATE);
SELECT * FROM actor;

select * from actor_info;


