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

Console.WriteLine($"{byteNumber} {sbyteNumber} {shortNumber} {shortNumber} {ushortNumber} {intNumber} {uintNumber} {longNumber} {ulongNumber}");
Console.WriteLine($"{floatNumber} {doubleNumber} {decimalNumber} {character} {name} {isExpected}");