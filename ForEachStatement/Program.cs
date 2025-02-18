string[] names = [ "Rowena", "Robin", "Bao" ];
foreach (string name in names)
{
    Console.WriteLine(name);
}

/*FOREACH IN JAVASCRIP
const name = ["Rowena", "Robin", "Bao"];

name.forEach((element) => console.log(element));

*/

int[] inventory = { 200, 450, 700, 175, 250 };
int total=0;
int bin = 0;
foreach (int product in inventory)
{
    total+=product;
    bin++;
    Console.WriteLine($"Bin {bin} = {product} items (Running total: {total})");
}
Console.WriteLine($"We have {total} items in inventory.");
