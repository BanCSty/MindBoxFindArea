use Test;

IF OBJECT_ID(N'dbo.ProductCategory', N'U') IS NOT NULL
DROP TABLE ProductCategory;

IF OBJECT_ID(N'dbo.Category', N'U') IS NOT NULL
DROP TABLE Category;

IF OBJECT_ID(N'dbo.Product', N'U') IS NOT NULL
DROP TABLE Product;
----------------------------------------------------------------------------------------------------------------------------------------------------------------
 CREATE TABLE Category(
	Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name varchar(100) NOT NULL
);
Insert into Category(Name)
VALUES ('Computer Game'),
       ( 'Car'),
       ('Food');
----------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE TABLE Product(
	Id int IDENTITY(1,1) NOT NULL PRIMARY KEY,
	Name varchar(100) NOT NULL
);
Insert into Product(Name)
VALUES ('Lada Vesta'),
       ('Burger'),
       ('Ball'),
       ('DARK SOULS III');
----------------------------------------------------------------------------------------------------------------------------------------------------------------
CREATE Table ProductCategory(
    Id int IDENTITY(1,1) NOT null primary key,
    ProductID int not null ,
    CategoryID int not null,
    FOREIGN key(ProductID) REFERENCES Product(Id) on update cascade on delete cascade,
    FOREIGN KEY(CategoryID) REFERENCES Category(Id) on update cascade on delete cascade
);
Insert into productcategory(ProductID, CategoryID)
VALUES  (1, 2),
        (1, 1),
        (2, 3),
        (4, 1);
----------------------------------------------------------------------------------------------------------------------------------------------------------------
SELECT p.Name as ProductName, c.Name as CategoryName from Product p
left join ProductCategory pc on pc.ProductId = p.Id
left join Category c on pc.CategoryId = c.Id;
