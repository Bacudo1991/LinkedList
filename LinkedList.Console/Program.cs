using LinkedList.Core;
using System.ComponentModel.Design;

var list = new SinglyLinkedList<string>();
var opt = string.Empty;
do 
{
    opt = Menu();
    switch(opt)
    {
        case "0":
            Console.WriteLine("Bye");
            break;
        case "1":
            Console.Write("Enter value: ");
            list.InsertAtBeginning(Console.ReadLine()!);
            break;
        case "2":
            Console.Write("Enter value: ");
            list.InsertAtEnd(Console.ReadLine()!);
            break;
        case "3":
            Console.Write("Enter value to search: ");
            var value = Console.ReadLine()!;
            Console.WriteLine(list.Contains(value) ? "Value found" : "Value not found");
            break;
        case "4":
            Console.Write("Enter value to remove: ");
            list.Remove(Console.ReadLine()!);
            break;
        case "5":
            list.PrintList();
            break;
        default:
            Console.WriteLine("Invalid option");
            break;
    }    
} while (opt != "0");

string Menu()
{
    Console.WriteLine(":::::::: Menu ::::::::");
    Console.WriteLine();
    Console.WriteLine("1. Insert at beginning");
    Console.WriteLine("2. Insert at end");
    Console.WriteLine("3. Search value");
    Console.WriteLine("4. Remove value");
    Console.WriteLine("5. Print list");
    Console.WriteLine("0. Exit");
    Console.Write("Choose an option: ");
    return Console.ReadLine()!;
}