
create table ToDoItems (
id int,
status char(1) ,
description varchar (80) 
);

insert into ToDoItems (id, status, description)
VALUES (1, 'n', 'go to gym');
insert into ToDoItems (id, status, description)
VALUES (2, 'n', 'go to coding academy');
insert into ToDoItems (id, status, description)
VALUES (3, 'n', 'spend time with family');
insert into ToDoItems (id, status, description)
VALUES (4, 'n', 'search for job');
select * from ToDoItems;
delete from ToDoItems where id = 1;
insert into ToDoItems (id, status, description)
VALUES (1, 'n', 'go to gym');
UPDATE ToDoItems set  status ='y'
where id = 3
select * from ToDoItems
update ToDoItems set description = 'finish coding'
where id = 4
select * from ToDoItems
select id, description from ToDoItems
select id, status, description from ToDoItems
select * from ToDoItems
where id >= 2 and id <=3;
delete from ToDoItems
where id = 1
select * from ToDoItems


