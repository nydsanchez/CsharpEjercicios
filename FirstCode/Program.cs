Random dice = new Random(); // this is other way to do it -> Random dice = new() 
int roll = dice.Next(1, 7);
Console.WriteLine(roll);
Console.Clear();

Random dice2 = new Random();
int roll1 = dice2.Next();  //will return values ranging from 0 to 2,147,483,647, which is the maximum value an int can store.
int roll2 = dice2.Next(101); //you can expect a random value between 0 and 100.
int roll3 = dice2.Next(50, 101); //you can expect a random value between 50 and 100.

Console.WriteLine($"First roll: {roll1}");
Console.WriteLine($"Second roll: {roll2}");
Console.WriteLine($"Third roll: {roll3}");
