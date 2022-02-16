--Select
--ANSII
Select ContactName Adi,CompanyName Sirketadi,City Sehir from Customers

Select ContactName,City from Customers where City = 'London'

--case insensitive
select * from Products where CategoryID = 1 or CategoryID=3

select * from Products where CategoryID = 1 and UnitPrice>=10

--sırala order by
select * from Products order by ProductName

select * from Products order by CategoryID,ProductName

select * from Products order by UnitPrice asc --ascending azdan çoka

select * from Products order by UnitPrice desc --descending çoktan aza

select * from Products where CategoryID=1 order by UnitPrice desc

select count(*) Adet from Products where CategoryID=1

select CategoryId ,count(*) Adet from  Products group by CategoryID --group by grup şeklinde getiriyor

select CategoryID, count(*) Adet from Products where UnitPrice>20 group by CategoryID having count(*)<10

select Products.ProductID,Products.ProductName,Products.UnitPrice,Categories.CategoryName
from Products inner join Categories on Products.CategoryID = Categories.CategoryID
where Products.UnitPrice>10

--DTO Data Transformation object

select * from Products p left join [Order Details] od on p.ProductID = od.ProductID

select * from Customers c left join Orders o on c.CustomerID = o.CustomerID where o.CustomerID is null

select * from Customers c right join Orders o on c.CustomerID = o.CustomerID where c.CustomerID is null

select * from Products p inner join [Order Details] od on p.ProductID = od.OrderID
inner join Orders o on o.OrderID = od.OrderID

select * from Customers where CompanyName like 'a__%'