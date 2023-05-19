//a|b|a
//b|a|b
//a|b|a

string inputValue = "a";
string[] result = { "0", "1", "2", "3", "4", "5", "6", "7", "8" };
int inputPosition = 0;
bool isContinue = true;
while (isContinue)
{
    Console.WriteLine("Tic Tac Toe");
    Console.WriteLine($"\t{result[0]}|{result[1]}|{result[2]}\n\t-----\n\t{result[3]}|{result[4]}|{result[5]}\n\t-----\n\t{result[6]}|{result[7]}|{result[8]}");
    isContinue = resultForGame(result);
    if (inputValue == "a")
    {
        Console.Write("Player One>>");
    }
    else
    {
        Console.Write("Player Two>>");
    }
    inputPosition = Convert.ToInt32(Console.ReadLine());
    
    if (inputPosition >= 0 && inputPosition < 9)
    {
        
        if (inputValue == "a" && (result[inputPosition] != "b" && result[inputPosition] != "a"))
        {
            result[inputPosition] = inputValue;
            inputValue = "b";
        }
        else if (inputValue == "b" && (result[inputPosition] != "b" && result[inputPosition] != "a"))
        {
            result[inputPosition] = inputValue;
            inputValue = "a";
        }
        else
        {
            Console.Write("This Option is Already Selected Please Select the other one...");
            Console.ReadLine();
        }
    }
    else
    {
        Console.WriteLine("Invalid Input");
        Console.ReadLine();
    }
    Console.Clear();
}


static bool resultForGame(string[] result)
{
    bool isContinue = true;
    string[] input = new string[result.Length];
    result.CopyTo(input, 0);
    if ((input[0] == "a" && input[1] == "a" && input[2] == "a") || (input[0] == "b" && input[1] == "b" && input[2] == "b"))
    {
        if (input[0] == "a")
        {
            Console.WriteLine("Player One Win");
            return false;
        }
        else
        {
            Console.WriteLine("Player Two Win");
            return false;
        }
    }
    else if ((input[3] == "a" && input[4] == "a" && input[5] == "a") || (input[3] == "b" && input[4] == "b" && input[5] == "b"))
    {
        if (input[3] == "a")
        {
            Console.WriteLine("Player One Win");
            return false;
        }
        else
        {
            Console.WriteLine("Player Two Win");
            return false;
        }    
    }
    else if ((input[6] == "a" && input[7] == "a" && input[8] == "a") || (input[6] == "b" && input[7] == "b" && input[8] == "b"))
    {
        if (input[6] == "a")
        {
            Console.WriteLine("Player One Win");
            return false;
        }
        else
        {
            Console.WriteLine("Player Two Win");
            return false;
        }
    }
    else if ((input[0] == "a" && input[3] == "a" && input[6] == "a") || (input[0] == "b" && input[3] == "b" && input[6] == "b"))
    {
        if (input[0] == "a")
        {
            Console.WriteLine("Player One Win");
            return false;
        }
        else
        {
            Console.WriteLine("Player Two Win");
            return false;
        }
    }
    else if ((input[1] == "a" && input[4] == "a" && input[7] == "a") || (input[1] == "b" && input[4] == "b" && input[7] == "b"))
    {
        if (input[1] == "a")
        {
            Console.WriteLine("Player One Win");
            return false;
        }
        else
        {
            Console.WriteLine("Player Two Win");
            return false;
        }
    }
    else if ((input[2] == "a" && input[5] == "a" && input[8] == "a") || (input[2] == "b" && input[5] == "b" && input[8] == "b"))
    {
        if (input[0] == "a")
        {
            Console.WriteLine("Player One Win");
            return false;
        }
        else
        {
            Console.WriteLine("Player Two Win");
            return false;
        }
    }
    else if ((input[0] == "a" && input[4] == "a" && input[8] == "a") || (input[0] == "b" && input[4] == "b" && input[8] == "b"))
    {
        if (input[0] == "a")
        {
            Console.WriteLine("Player One Win");
            return false;
        }
        else
        {
            Console.WriteLine("Player Two Win");
            return false;
        }
    }
    else if ((input[2] == "a" && input[4] == "a" && input[6] == "a") || (input[2] == "b" && input[4] == "b" && input[6] == "b"))
    {
        if (input[2] == "a")
        {
            Console.WriteLine("Player One Win");
            return false;
        }
        else
        {
            Console.WriteLine("Player Two Win");
            return false;
        }
    }
    else
    {
        return true;
    }
}