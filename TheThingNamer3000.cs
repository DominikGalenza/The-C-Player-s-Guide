using System;

Console.WriteLine("What kind of thing are we talking about?");
// Kind of thing
string a = Console.ReadLine();
Console.WriteLine("How would you describe it? Big? Azure? Tattered?");
// Description
string b = Console.ReadLine();
/* Text */
string c = "of Doom";
/* Number */
string d = "3000";

Console.WriteLine($"The {b} {a} {c} {d}!");