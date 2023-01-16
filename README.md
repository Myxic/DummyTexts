# DummyTexts
## About
 * This Libary will generate this dummy texts - “A Town Hall Is Different From Balablu, Bluehuhu, Bulabu”. 
 * You also have the option to define how many characters you want to generate. 
 * There are also methods that allow you to count the number of letters in a sentence and the number of whitespaces in a sentence. 
 * Note: whitespaces are also characters.

## How to use 
* #### To use this library please make sure to use the word "townhall" to activate (any other word will return an error) 
* #### To Generate a dummy text without specifying the number of characters  
``` 
class Program
{
    static void Main(string[] args)
    {
        TownHall DummyText = new();
        Console.WriteLine(DummyText.DummyText("townhall"));
    }
}
```

* #### To Generate a dummy text when specifying the number of characters  
``` 
class Program
{
    static void Main(string[] args)
    {
        TownHall DummyText = new();
        Console.WriteLine(DummyText.DummyText("townhall, 24"));
    }
}
```

* #### To Check the number of Letters available in a sentence 
``` 
class Program
{
    static void Main(string[] args)
    {
        TownHall DummyText = new();

        string sentence = DummyText.DummyText("townhall,267");

        // this can be any sentence 

        Console.WriteLine(DummyText.LettersCounter(sentence));
    }
}
```
* #### To Check the number of Whitespace Avaliable in a sentence 
``` 
class Program
{
    static void Main(string[] args)
    {
        TownHall DummyText = new();

        string sentence = DummyText.DummyText("townhall,267");

        // this can be any sentence 

         Console.WriteLine(DummyText.WhiteSpaceCounter(sentence));
    }
}
```

## To contribute to this library
*  
 [DummyText Townhall CODE](https://github.com/Myxic/DummyTexts)
*  [EMAIL](ezemenahi56@gmail.com)
