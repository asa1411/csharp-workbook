using System;

namespace week8_2_sql
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}
//Th sql (30 min final project, simple assignment)
//Tu sql/entity frame work (simple assignment, most in project)
//Th entity work to do app (no assign most in project)
//Tu Todo App work (no assign most in project)
//Th presentations

//sql is a standard query language, has two parts, dml and ddl.
//ddl data definition language
//dml data manipulation language
//databases: relational database (sql, a kind of table or excel sheet of data) and document database( store bunch of data, mongo, lastsearch)
//ddl ex) 

//create table, drop table, not delete table (drop means delete)
//delete does not delete cells but delete entire raws.

//dml ex) select, 
//update employees
//set age = age + 1
//where name = 'Matt'

//insert into employees(id, name, age, gender)
//values(5, 'Matt', 37, 'm')

//for project
//id, descriptor, due date, status (pending, completed, doing) for status 'enum' will be used in c#.
//create, insert, update, select with where, delete couple of records

//Final project layout
/*
Build an application equivalent to app
To do app, pen and pencil checklist
add items
geed dollars
go to school

and then check them off 
Go to the gym;
Accomplished

Add an item;
Mark items as done;
See all items;
see done items;
See pending items;
delete an item;(functionality of app)
if I close the program and come back ater, my app should be saved
entity framework(recommended) vs. sql vs. playofile

when make an error, it should not crush.

Item
Id int  ---system generated or entity generated
des user input
status (enum or bool) -- pending/done

item list
I would not make a simple array of list, but
I would make an item repository or item list
      List<Item>
      and many methods like .getByID(int ..)
      .markDone(item)
utils
this is the stuff of printing
Tell here only when you intend to print something
print Menu
getUserImput

Main
two lines of code
app = new app
app.start?

App
run()
start()


 */