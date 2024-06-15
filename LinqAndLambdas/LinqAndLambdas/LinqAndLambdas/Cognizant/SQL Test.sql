/*
ID | DeptId | Employee 
1 | 3 | ABC 
2 | 2 | XYZ 
3 | 3 | PQR 
4 | 3 | 123 

DeptID| DepartmentName 
1 Admin 
2 Accounts 
3 IT
*/

--PROBLEM: GET THE DEPARTMENT THAT DOES NOT HAVE EMPLOYEES

--using not in
select DepartmentName
from department
where deptid not in(
	SELECT 	d.DeptID, count(*)
	FROM employee e
		inner join department d on e.DeptId = d.DeptId
	group by d.DeptID
)

--using right join
select DepartmentName from (
	select d.DepartmentName, count(*) count
	FROM employee e
		Inner join department d on e.DeptId = d.DeptId
	group by d.DeptID
)tbl
where count = 0