class Program 
{
    static void InputFruit(Queue<char> fruitList)
    {
        char inputFruit;
        while(true)
        {
            inputFruit = char.Parse(Console.ReadLine());
            if(inputFruit != 'L' && inputFruit != 'M' && inputFruit != 'S') {
                break;
            }
            else {
                fruitList.Push(inputFruit);
            }
        }
    }

    static void SeperateFruit(Queue<char> fruitList)
    {
        Queue<int> processCount = new Queue<int>();

        for (int i = 0; i < fruitList.GetLength(); i++)
        {
            char getFruit = fruitList.Get(i);
            if (getFruit == 'L') {
                fruitList.Push('M');
                fruitList.Push('M');
                processCount.Push(1);
            } 
            else if (getFruit == 'M') {
                fruitList.Push('S');
                fruitList.Push('S');
                fruitList.Push('S');
                processCount.Push(2);
            }
            else {
                processCount.Push(3);
            }
        }

        for (int j = 0; j < processCount.GetLength(); j++) {
            Console.Write(processCount.Get(j));
        }
    }
    
    static void Main(string[] args) {
        Queue<char> fruitList = new Queue<char>();
        InputFruit(fruitList);
        SeperateFruit(fruitList);
    }
}