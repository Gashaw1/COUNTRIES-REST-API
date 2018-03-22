Create Table Continent
(
	   CotinentID nvarchar(50),
       CotinentName nvarchar(50)      
			  CONSTRAINT CContinent_CotinentID_PK PRIMARY KEY(CotinentID)
      
)
go

Create Table Countary
(
	 countryID nvarchar(50),
	 countryName nvarchar(50),
	 countryCapital nvarchar(50),
     countryPopulation int,
	 CotinentID nvarchar(50)
		  CONSTRAINT Countary_CountryID_PK PRIMARY KEY(countryID),	    
         CONSTRAINT Countary_CotinentID_FK FOREIGN KEY(CotinentID)REFERENCES Continent(CotinentID)	 
		
)
go

create proc SP_ReturnContent
as
begin
	select * from Continent;
end
go

create proc SP_ReturnContentByID 
@CotinentID nvarchar(50)
as
begin
	select * from Continent
	where Continent.CotinentID = @CotinentID;
end

go
Create proc Sp_ReturnCountary
as
begin
	select * from Countary;
end

go
Create proc Sp_ReturnCountaryByID
@countryID nvarchar(50)
as
begin
	select * from Countary
	where countryID = @countryID
end
go
--sample data
insert into Continent values('2dududfu22222','Aferica')
insert into Continent values('e8e8e8e8e88e','Asia')

Insert into Countary values('39diuieiewspo','Ethiopia','addis ababa','9999999','2dududfu22222')
Insert into Countary values('39dwweiewspo','Gana','Dakar','799999','2dududfu22222')

Insert into Countary values('wwwww0w0ww00w','Japan','Beging','4444444','e8e8e8e8e88e')
Insert into Countary values('wwwwwww666sw6','China','Tokio','9333999','e8e8e8e8e88e')

