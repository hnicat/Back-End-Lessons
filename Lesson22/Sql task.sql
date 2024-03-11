use P118

select * from Brands
Select * from NoteBooks
select * from Phones

insert into Phones  values 
('Iphone X',3000,1),
('Samsung S23 ',2000,3)

insert into NoteBooks Values ('Lenovo n78',5666,3),
('Samsung b-78',7000,2)


insert into NoteBooks Values ('Lenovo j-89',2500,3),
('Samsung b-79',4000,2)
--9
select n.NoteName,n.NPrice,B.Name as'Brand Name' from  NoteBooks n
join Brands B on B.Id=n.BrandId

--11
select n.NoteName,n.NPrice,B.Name as'Brand Name' from  NoteBooks n
join Brands B on B.Id=n.BrandId  where B.Name like '%S%'

--12
select n.NoteName,n.NPrice,B.Name as'Brand Name' from  NoteBooks n
join Brands B on B.Id=n.BrandId
where n.NPrice >6000 and n.NPrice<9000 or n.NPrice>9000

--14
select BrandId,Count(*) as'Say' from NoteBooks  Group by BrandId


--16
select * from Phones P
join NoteBooks n on n.BrandId=P.BrandId

--22

select  b.Name,sum(n.NPrice) as 'Qiymet', count(*) as 'Say' from Brands b
join NoteBooks n on n.BrandId=b.Id
Group By b.Name
