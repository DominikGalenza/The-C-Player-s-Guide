using System;

byte byteNumber = 1;
sbyte sbyteNumber = 2;
short shortNumber = 3;
ushort ushortNumber = 4;
int intNumber = 5;
uint uintNumber = 6;
long longNumber = 7;
ulong ulongNumber = 8;
float floatNumber = 9.0f;
double doubleNumber = 10;
decimal decimalNumber = 11.0m;
char character = 'a';
string name = "Monty";
bool isExpected = false;

byteNumber = 12;
sbyteNumber = 13;
shortNumber = 14;
ushortNumber = 15;
intNumber = 16;
uintNumber = 17;
longNumber = 18;
ulongNumber = 19;
floatNumber = 20.0f;
doubleNumber = 21.0;
decimalNumber = 22.0m;
character = 'b';
name = "Python";
isExpected = true;

Console.WriteLine($"{byteNumber} {sbyteNumber} {shortNumber} {shortNumber} {ushortNumber} {intNumber} {uintNumber} {longNumber} {ulongNumber}");
Console.WriteLine($"{floatNumber} {doubleNumber} {decimalNumber} {character} {name} {isExpected}");