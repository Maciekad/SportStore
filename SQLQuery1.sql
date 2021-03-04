select * from dbo.Products
select * from SportStore.Categories

delete from dbo.Products where ProductId=4

insert into SportStore.Categories(CategoryName) values('Koszykówka')
insert into SportStore.Categories(CategoryName) values('Tenis')
insert into SportStore.Categories(CategoryName) values('Pływanie')

insert into dbo.Products(Description, UnitCost, CategoryId, Name) values('Piłka do gry', 100, 1, 'Piłka adidas')
insert into dbo.Products(Description, UnitCost, CategoryId, Name) values('Rakieta tenisowa do gry w tenisa', 200, 3, 'Rakieta tenisowa')
insert into dbo.Products(Description, UnitCost, CategoryId, Name) values('Płetwy do pływania', 150, 4, 'Płetwy')
insert into dbo.Products(Description, UnitCost, CategoryId, Name) values('Piłka do gry w koszykówkę', 100, 2, 'Piłka adidas')