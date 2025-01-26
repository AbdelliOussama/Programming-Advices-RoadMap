select * from VehicleDetails;

select Makes.Make, count(*) as VehiculeNumber from VehicleDetails
join Makes on VehicleDetails.MakeID =Makes.MakeID 
where Year between 1950 and 2000 
group by Makes.Make having count (*) >12000
order by VehiculeNumber desc;
;

select * from 
(
select Makes.Make, count(*) as VehiculeNumber from VehicleDetails
join Makes on VehicleDetails.MakeID =Makes.MakeID 
where Year between 1950 and 2000 
group by Makes.Make 
)R1 where VehiculeNumber >12000
order by VehiculeNumber desc;


select Makes.Make, count(*) as VehiculeNumber ,  (select count(*)from VehicleDetails)as TotalVehicles  from VehicleDetails
join Makes on VehicleDetails.MakeID =Makes.MakeID 
where Year between 1950 and 2000 
group by Makes.Make 
order by VehiculeNumber desc;
;

select * ,cast (VehiculeNumber as float)/ Cast (TotalVehicles as float)as Perc from
(
select Makes.Make, count(*) as VehiculeNumber ,  (select count(*)from VehicleDetails)as TotalVehicles  from VehicleDetails
join Makes on VehicleDetails.MakeID =Makes.MakeID 
where Year between 1950 and 2000 
group by Makes.Make 
)R1 order by VehiculeNumber desc;




select Makes.Make,FuelTypes.FuelTypeName,Count(*) as NumberOfVehicles from VehicleDetails
join Makes on Makes.MakeID = VehicleDetails.MakeID
join FuelTypes on FuelTypes.FuelTypeID=VehicleDetails.FuelTypeID
where Year between 1950 and 2000
group by Makes.Make, FuelTypes.FuelTypeName
order by Makes.Make;


select VehicleDetails.*,FuelTypes.FuelTypeName from VehicleDetails 
join FuelTypes on VehicleDetails.FuelTypeID = FuelTypes.FuelTypeID
where FuelTypes.FuelTypeName=N'GAS';


select count (*) as TotalGasMakes from
(
select distinct  Makes.Make,FuelTypes.FuelTypeName from VehicleDetails
join makes on VehicleDetails.MakeID =  Makes.MakeID
join FuelTypes on VehicleDetails.FuelTypeID=FuelTypes.FuelTypeID 
where FuelTypes.FuelTypeName= N'GAS'
)R1;



select Makes.Make,Count(*) as NumberOfVehicles from VehicleDetails
join Makes on VehicleDetails.MakeID =Makes.MakeID
group by Makes.Make
Order by Count(*) desc;


select * from
(
select Makes.Make,Count(*) as NumberOfVehicles from VehicleDetails
join Makes on VehicleDetails.MakeID =Makes.MakeID
group by Makes.Make
)R1
where NumberOfVehicles>20000;


select Makes.Make from Makes
where Make like 'B%';

select Makes.Make from Makes
where Make like '%W';

select * from Makes;
select * from DriveTypes;


select distinct Makes.Make, DriveTypes.DriveTypeName from VehicleDetails
inner join Makes on VehicleDetails.MakeID=Makes.MakeID
join DriveTypes on VehicleDetails.DriveTypeID=DriveTypes.DriveTypeID
where DriveTypes.DriveTypeName='FWD';
	 


select count(*) from
(
select distinct Makes.Make, DriveTypes.DriveTypeName from VehicleDetails
inner join Makes on VehicleDetails.MakeID=Makes.MakeID
join DriveTypes on VehicleDetails.DriveTypeID=DriveTypes.DriveTypeID
where DriveTypes.DriveTypeName='FWD'
)R1;
 



 
select distinct Makes.Make ,DriveTypes.DriveTypeName ,count(*)as Total from VehicleDetails
join DriveTypes on VehicleDetails.DriveTypeID = DriveTypes.DriveTypeID 
join Makes on VehicleDetails.MakeID =Makes.MakeID 
group by Makes.Make ,DriveTypes.DriveTypeName
order by Make asc ,Total desc;

-- Get total vehicles per DriveTypeName Per Make then filter only results with total > 10,000
select * from
(
select distinct Makes.Make ,DriveTypes.DriveTypeName ,count(*)as Total from VehicleDetails
join DriveTypes on VehicleDetails.DriveTypeID = DriveTypes.DriveTypeID 
join Makes on VehicleDetails.MakeID =Makes.MakeID 
group by Makes.Make ,DriveTypes.DriveTypeName
)R1 where Total >10000
order by Make asc ,Total desc;


--Get all Vehicles that number of doors is not specified

select * from VehicleDetails 
where NumDoors is null;

--Get Total Vehicles that number of doors is not specified
select count(*) from VehicleDetails
where NumDoors is null;

--Get percentage of vehicles that has no doors specified

Select  ( 
			cast (
				(select count(*) from VehicleDetails where NumDoors is null) as float)
			/
			cast ((select count(*) from VehicleDetails)as float)
		) as Percentage ;



--Get MakeID , Make, SubModelName for all vehicles that have SubModelName 'Elite'

SELECT    distinct    VehicleDetails.MakeID, Makes.Make, SubModelName
FROM            VehicleDetails INNER JOIN
                         SubModels ON VehicleDetails.SubModelID = SubModels.SubModelID INNER JOIN
                         Makes ON VehicleDetails.MakeID = Makes.MakeID
	
	where SubModelName='Elite';


--Get all vehicles that have Engines > 3 Liters and have only 2 doors
select * from VehicleDetails 
where Engine_Liter_Display >3 and NumDoors =2;


--Get make and vehicles that the engine contains 'OHV' and have Cylinders = 4
select Makes.Make,VehicleDetails.* from VehicleDetails
join Makes on VehicleDetails.MakeID = Makes.MakeID
where Engine like '%OHV%' and Engine_Cylinders=4;


--Get all vehicles that their body is 'Sport Utility' and Year > 2020
select * from  VehicleDetails
join Bodies on VehicleDetails.BodyID =Bodies.BodyID
where Bodies.BodyName='Sport Utility' and  VehicleDetails.Year>2020;

--Get all vehicles that their Body is 'Coupe' or 'Hatchback' or 'Sedan'
SELECT       bodyName, VehicleDetails.*
FROM            VehicleDetails INNER JOIN
                         Bodies ON VehicleDetails.BodyID = Bodies.BodyID
Where BodyName in ('Coupe','Hatchback','Sedan')

--Get all vehicles that their body is 'Coupe' or 'Hatchback' or 'Sedan' and manufactured in year 2008 or 2020 or 2021
SELECT       bodyName, VehicleDetails.*
FROM            VehicleDetails INNER JOIN
                         Bodies ON VehicleDetails.BodyID = Bodies.BodyID
Where BodyName in ('Coupe','Hatchback','Sedan') and Year in (2008,2020,2021)
order by Year;


--Return found=1 if there is any vehicle made in year 1950

select Found=1
where Exists (select top 1 * from VehicleDetails where Year =1950);


--Get all Vehicle_Display_Name, NumDoors and add extra column to describe number of doors by words, and if door is null display 'Not Set'

select distinct Vehicle_Display_Name,NumDoors , door_description=
case 
when NumDoors=0 then 'No Doors '
when NumDoors=2 then 'Two Doors'
when NumDoors=3 then 'Three Doors '
when NumDoors=4 then 'Four Doors '
when NumDoors=6 then 'Six Doors '
when NumDoors=8 then 'Eight Doors '
else 'Not Set'
end
from VehicleDetails;

--Get all Vehicle_Display_Name, year and add extra column to calcuate the age of the car then sort the results by age desc.
select Vehicle_Display_Name,Year ,Age =Year (GetDate())- VehicleDetails.Year
from VehicleDetails
order by Age desc;

--Get all Vehicle_Display_Name, year, Age for vehicles that their age between 15 and 25 years old 
select * from 
(
select Vehicle_Display_Name,Year,Age = Year (GetDate()) - VehicleDetails.Year
from VehicleDetails 
)R1 
where Age between 15 and 25;

--Get Minimum Engine CC , Maximum Engine CC , and Average Engine CC of all Vehicles
select Min(Engine_CC) as Minimum_Engine_CC,Max(Engine_CC) as Maximum_Engine_CC,avg(Engine_CC) as Average_Engine_CC
from VehicleDetails;


--Get all vehicles that have the minimum Engine_CC
Select VehicleDetails.Vehicle_Display_Name from VehicleDetails
where Engine_CC = ( select  Min(Engine_CC) as MinEngineCC  from VehicleDetails );

--Get all vehicles that have the Maximum Engine_CC
Select VehicleDetails.Vehicle_Display_Name from VehicleDetails
where Engine_CC = ( select  Max(Engine_CC) as MaxEngineCC  from VehicleDetails );

--Get all vehicles that have Engin_CC below average
Select VehicleDetails.Vehicle_Display_Name from VehicleDetails
where Engine_CC = ( select AVG(Engine_CC) as AverageEngineCC  from VehicleDetails );

--Get total vehicles that have Engin_CC above average
select Count(*) as NumberOfVehiclesAboveAverageEngineCC from
(
 
	Select ID,VehicleDetails.Vehicle_Display_Name from VehicleDetails
	where Engine_CC > ( select  Avg(Engine_CC) as MinEngineCC  from VehicleDetails )

) R1

--Get all unique Engin_CC and sort them Desc
select distinct  Engine_CC from VehicleDetails
order by Engine_CC desc

--Get the maximum 3 Engine CC
select distinct top 3 Engine_CC from VehicleDetails;

--Get all vehicles that has one of the Max 3 Engine CC
Select Vehicle_Display_Name from VehicleDetails
where Engine_CC in 
(
	
	Select  distinct top 3 Engine_CC from VehicleDetails
	Order By Engine_CC Desc
)

--Get all Makes that manufactures one of the Max 3 Engine CC
SELECT        distinct Makes.Make
FROM            VehicleDetails INNER JOIN
                         Makes ON VehicleDetails.MakeID = Makes.MakeID
WHERE        (VehicleDetails.Engine_CC IN
                             (SELECT DISTINCT TOP (3) Engine_CC
                               FROM            VehicleDetails 
                               ORDER BY Engine_CC DESC)
							 )

Order By Make


select * from VehicleDetails;
--Get a table of unique Engine_CC and calculate tax per Engine CC
select Engine_CC,

	CASE
		WHEN Engine_CC between 0 and 1000 THEN 100
		 WHEN Engine_CC between 1001 and 2000 THEN 200
		 WHEN Engine_CC between 2001 and 4000 THEN 300
		 WHEN Engine_CC between 4001 and 6000 THEN 400
		 WHEN Engine_CC between 6001 and 8000 THEN 500
		 WHEN Engine_CC > 8000 THEN 600	
		ELSE 0

	END as Tax

from 
(
	select distinct Engine_CC from VehicleDetails
	
) R1
order by Engine_CC

--Get Make and Total Number Of Doors Manufactured Per Make

SELECT        Makes.Make, Sum(VehicleDetails.NumDoors) AS TotalNumberOfDoors
FROM            VehicleDetails INNER JOIN
                         Makes ON VehicleDetails.MakeID = Makes.MakeID

Group By Make
Order By TotalNumberOfDoors desc

--Get Total Number Of Doors Manufactured by 'Ford'

SELECT        Makes.Make, Sum(VehicleDetails.NumDoors) AS TotalNumberOfDoors
FROM            VehicleDetails INNER JOIN
                         Makes ON VehicleDetails.MakeID = Makes.MakeID

Group By Make
Having Make='Ford'

--Get Number of Models Per Make
SELECT        Makes.Make, COUNT(*) AS NumberOfModels
FROM            Makes INNER JOIN
                         MakeModels ON Makes.MakeID = MakeModels.MakeID
GROUP BY Makes.Make
Order By NumberOfModels Desc;

--Get the highest 3 manufacturers that make the highest number of models
SELECT    top 3    Makes.Make, COUNT(*) AS NumberOfModels
FROM            Makes INNER JOIN
                         MakeModels ON Makes.MakeID = MakeModels.MakeID
GROUP BY Makes.Make
Order By NumberOfModels Desc;

--Get the highest number of models manufactured
select Max(NumberOfModels) as MaxNumberOfModels
from
(

		SELECT        Makes.Make, COUNT(*) AS NumberOfModels
		FROM            Makes INNER JOIN
								 MakeModels ON Makes.MakeID = MakeModels.MakeID
		GROUP BY Makes.Make
		
) R1

--Get the highest Manufacturers manufactured the highest number of models
SELECT        Makes.Make, COUNT(*) AS NumberOfModels
		FROM            Makes INNER JOIN
								 MakeModels ON Makes.MakeID = MakeModels.MakeID
		GROUP BY Makes.Make

		having COUNT(*) = (

										select Max(NumberOfModels) as MaxNumberOfModels
										from
										(

												SELECT      MakeID, COUNT(*) AS NumberOfModels
												FROM       
																		 MakeModels
												GROUP BY MakeID
												
										) R1

							)


--Get the Lowest Manufacturers manufactured the lowest number of models

SELECT        Makes.Make, COUNT(*) AS NumberOfModels
		FROM            Makes INNER JOIN
								 MakeModels ON Makes.MakeID = MakeModels.MakeID
		GROUP BY Makes.Make

		having COUNT(*) = (

										select min(NumberOfModels) as MaxNumberOfModels
										from
										(

												SELECT      MakeID, COUNT(*) AS NumberOfModels
												FROM       
																		 MakeModels
												GROUP BY MakeID
												
										) R1

							)

--Get all Fuel Types , each time the result should be showed in random order
select FuelTypeName from FuelTypes 
order by  newID();



