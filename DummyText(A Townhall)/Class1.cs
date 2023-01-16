using System;
using System.Drawing;

namespace DummyText_A_Townhall_
{
    public class TownHall
    {
        private static string DummyTxt;

        private static string RepeatText;

        private static int StandardCounter;

        private static bool Logic;

        public TownHall()
        {
            DummyTxt = "A Town Hall Is Different From Balablu, Bluehuhu, Bulabu";
            RepeatText = ", Balablu, Bluehuhu, Bulabu";
            StandardCounter = 10;
            Logic = true;

        }
        public string DummyText(string input)
        {
            try
            {
                if (input.ToUpper() == "TOWNHALL")
                {
                    
                    return DummyTxt;
                }
                else
                {
                    throw new Exception("Argument entered is invalid ");
                }

            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }
        public string DummyText(string input, int count)
        {
            try
            {

                if (input.ToUpper() == "TOWNHALL" && count > StandardCounter)
                {
                    string Dummy = DummyTxt;
                    while (Logic)
                    {
                        if (StandardCounter < count)
                        {
                            Dummy += RepeatText;
                            StandardCounter = LettersCounter(Dummy);
                        }
                        else
                        {
                            Logic = false;
                        }
                    }

                    return Dummy.Substring(0, count);

                }
                else
                {
                    if (input.ToUpper() != "TOWNHALL")
                    {

                        throw new Exception($"{input}: This Argument entered is invalid ");
                    }
                    else if (count < StandardCounter)
                    {
                        throw new Exception($"Can't generate Dummy Text because \"{count}\" is less than the 10");
                    }
                    else
                    {
                        throw new Exception($"\"{input}\" and \"{count}\" are invalid Agurment");
                    }
                }
            }
            catch (Exception ex)
            {
                return ex.Message;
            }


        }

        public int LettersCounter(string word)
        {
            string alphabets = "";

            foreach (string letter in word.Split(' '))
            {
                alphabets += letter;
            }
            return alphabets.Length;
        }

        public int WhiteSpaceCounter(string word)
        {
            int WhiteSpaces = 0;
            foreach (char w in word)
            {
                if (w == ' ')
                {
                    WhiteSpaces += 1;
                }
            }
            return WhiteSpaces;
        }
    }

}

