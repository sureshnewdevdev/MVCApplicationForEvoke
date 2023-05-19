// See https://aka.ms/new-console-template for more information
using MiscEx;

Console.WriteLine("Hello, World!");
int? x = null;
string emp = null;
int? empno = null;

Class1 cls = null;

if (cls != null)
    Console.WriteLine(cls.MyProperty);

if (emp is null)
{

}

emp = null;
emp = string.Empty;
if (string.IsNullOrEmpty(emp))
{

}

//3 dept

//1 d1
//2 d2
//3 d3

//5 employy

//    1 e1 d1
//    2 e2 d2
//    3 e3 d1
//    4 e4 d1
//    5 e5 d2

//    d1 e1
//    d1 e3
//    d1 e4
//    d2 e2
//    d2 e5
//    d3 null