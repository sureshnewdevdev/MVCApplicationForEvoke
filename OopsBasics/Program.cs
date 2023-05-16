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

int x=190;
int y=210;
int avg = 0;
int sum = 0;
int big;
sum = f.SumAndAvg(x, y,ref avg,out big);

Console.WriteLine(sum);
Console.WriteLine(avg);

Console.ReadLine();