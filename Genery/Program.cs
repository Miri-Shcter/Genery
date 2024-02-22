// See https://aka.ms/new-console-template for more information
using Genery;



Console.WriteLine("Hello, World!");
static void printObj<T>(T obj)
{
    Console.WriteLine(obj);
}
//printObj<int>(5);
//printObj<string>("exelent");
SwapList<int> swapList = new SwapList<int>();
swapList.Add(5);
swapList.Add(12);
swapList.Add(13);
Console.WriteLine(swapList[0]+" "+swapList[1] +" "+ swapList[2]);
swapList.Swaper(1, 2);
Console.WriteLine(swapList[0] + " " + swapList[1] + " " + swapList[2]);