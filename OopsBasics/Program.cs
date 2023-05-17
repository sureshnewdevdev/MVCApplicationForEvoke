// See https://aka.ms/new-console-template for more information
using OopsBasics;


//Employee employee = new Employee(10,"AAAA");

//Console.WriteLine(employee.Id);
//Console.WriteLine(employee.Name);
//Console.WriteLine(employee.ObjectCreatedTime);

MathMethods m = new MathMethods();

int ans = m.Add(10, 90);

ParentXClass parentXClass = new ParentXClass();
Console.WriteLine(   parentXClass.GetName());

ChildXClass childXClass = new ChildXClass();
Console.WriteLine(childXClass.GetName());

parentXClass = new ChildXClass();
Console.WriteLine(parentXClass.GetName());

FunctionExamples f = new FunctionExamples();


// In Abstract - Virtual , Sealed, Staic

var result =MathUtility.Add(10M, 23.677M);

MyClass my=new MyClass();
my.Mul(10, 10);

Console.ReadLine();