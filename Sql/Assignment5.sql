create trigger saftey
on database
for
create_table,alter_table,drop_table
as
print'you can not create ,drop and alter table in this database'
rollback;

create trigger deep
on Employees
for
insert,update,delete
as
print'you can not insert,update and delete this table i'
rollback;

-- Index
CREATE TABLE Bookstore2
(ISBN_NO    VARCHAR(15) NOT NULL PRIMARY KEY, 
 SHORT_DESC VARCHAR(100), 
 AUTHOR     VARCHAR(40), 
 PUBLISHER  VARCHAR(40), 
 PRICE      FLOAT, 
 INDEX SHORT_DESC_IND(SHORT_DESC, PUBLISHER)
);


create trigger insert
on emp
after delete
as
178

create 

create procedure insertp @Id int
as 
insert into temp(id)
values (@Id)