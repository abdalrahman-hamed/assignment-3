using assignment_3.Classes;
Console.Write($"Pleaase Enter the word : ");
string str = Console.ReadLine();
Counter counter = new Counter(str);
counter.print();