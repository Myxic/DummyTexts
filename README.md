# DummyTexts
## About
 * This Libary will generate this dummy texts - “A Town Hall Is Different From Balablu, Bluehuhu, Bulabu”. 
 * You also have option to define how many characters you want to generate. 
 * There are also methods that allow you count the number of letters in a sentense and number of whitespaces in a sentense. 
 * Note: whitespaces are also characters.

## How to use 
* #### To Generate a dummy text without specifying the number of charaters  
'''
class Program
{
    static void Main(string[] args)
    {
        TownHall DummyText = new();

        Console.WriteLine(DummyText.DummyText("townhall"));
    }
}
'''
