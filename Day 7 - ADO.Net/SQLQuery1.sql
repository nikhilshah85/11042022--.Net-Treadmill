create database shoppingDB

create table products
(
	pId int primary key,
	pName varchar(20),
	pCategory varchar(20),
	pPrice int,
	pIsInStock bit)

	insert into products values(101,'Pepsi','Cold-Drinks',50,1)
	insert into products values(102,'Fossil','Watch',50,1)
	insert into products values(103,'IPhone','Phone',50,1)
	insert into products values(104,'Dell','Laptop',50,1)
	insert into products values(105,'Trailhawk','SUV',50,1)
	insert into products values(106,'Tshirt','Clothing',50,1)
	insert into products values(107,'Woodland','Shoes',50,1)
