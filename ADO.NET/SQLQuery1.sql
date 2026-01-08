USE aryan;
create table studentInfo(
id int primary key,
name varchar(250)
);
select * from studentInfo;

exec sp_help "studentInfo"