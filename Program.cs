class Program
{
    static void inputFlower(CircularLinkedList<char> flowerList)
    {
        while(true)
        {
            char inputFlower = char.Parse(Console.ReadLine());

            if (inputFlower != 'J' && inputFlower != 'G' && inputFlower != 'O' && inputFlower != 'R')
                break;
            else {
                int lenghtFlower = flowerList.GetLength();
                if (lenghtFlower == 0) 
                { 
                    if (inputFlower == 'R') {
                        Console.WriteLine("Invalid Pattern");
                    } 
                    else {
                        flowerList.Add(inputFlower);
                    } 
                } 
                
                else if (lenghtFlower <= 2) {
                    if (inputFlower == 'R' && flowerList.Get(0) == 'R' && flowerList.Get(-1) == 'R') {
                        Console.WriteLine("Invalid Pattern");
                    } 
                    else if (flowerList.Get(-2) == inputFlower && flowerList.Get(-1) == 'R') {
                        Console.WriteLine("Invalid Pattern");
                    }
                    else {
                        flowerList.Add(inputFlower);
                    }
                    }
                else if (lenghtFlower >= 3) {
                    if (inputFlower == 'R') {
                    if (flowerList.Get(0) == 'R' && flowerList.Get(-1) == 'R') {
                        Console.WriteLine("Invalid Pattern");
                    } 
                    else {
                        flowerList.Add(inputFlower);
                    }
                    }
                    else if (flowerList.Get(-1) == 'R' && flowerList.Get(-2) == inputFlower) {
                        Console.WriteLine("Invalid Pattern");
                    }
                    else if (inputFlower == 'G') {
                        if (flowerList.Get(0) == inputFlower && flowerList.Get(1) == 'G' && flowerList.Get(2) == 'G') {
                            Console.WriteLine("Invalid Pattern");
                        }
                        else if (flowerList.Get(-1) == 'G' && flowerList.Get(-2) == 'G' && flowerList.Get(-3) == 'G') {
                            Console.WriteLine("Invalid Pattern");
                        } 
                        else if (flowerList.Get(-2) == 'G' && flowerList.Get(-1) == 'G' && flowerList.Get(0) == 'G') {
                            Console.WriteLine("Invalid Pattern");
                        } 
                        else if (flowerList.Get(-1) == 'G' && flowerList.Get(0) == 'G' && flowerList.Get(1) == 'G') {
                            Console.WriteLine("Invalid Pattern");
                        } 
                        else {
                        flowerList.Add(inputFlower);
                        }
                    }
                    else {
                        flowerList.Add(inputFlower);
                    }
                }
                else {
                    flowerList.Add(inputFlower);
                } 
            }
        }  
    }
     static void Main(string[] args) 
    {
        CircularLinkedList<char> flowerList = new CircularLinkedList<char>();
        inputFlower(flowerList);

        for (int i = 0; i < flowerList.GetLength(); i++)
        {
            Console.Write(flowerList.Get(i));
        }
    }
}

