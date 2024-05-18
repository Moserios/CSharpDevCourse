using System;
using System.CodeDom.Compiler;

//You have the following values to convert:

byte a = 10; //Convert this value into "short" type (assign into another short type of variable)
short ab;
ab = a;


int b = 10; //Convert this value into "short" type (assign into another short type of variable)
short bc;
bc = (short)b;


string c = "10.34"; //Convert this value into "double" type using Parse  //Also, convert the same value into "decimal" type  using TryParse
double cc;
cc = double.Parse(c);
bool cd = decimal.TryParse(c, out decimal ce);


decimal d = 20.3M; //Convert this value into "string" type (assign into another string type of variable)
string de = System.Convert.ToString(d);



//And then print all the converted values i.e 10, 10, 10.34, 10.34, 11.56.
System.Console.Write($"{ab}, {bc}, {cc}, {ce}, {de}.");

System.Console.ReadKey();
