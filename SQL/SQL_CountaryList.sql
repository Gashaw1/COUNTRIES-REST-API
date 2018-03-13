Create Table Continent
(
	   CotinentID nvarchar(50),
       CotinentName nvarchar(50),
       CotinentPopulation int,
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

