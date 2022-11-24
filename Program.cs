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
        char fruit = fruitList.Pop();
        while (true) {
            if (fruitList.GetLength() <= 0) {
               break; 
            }

            if (fruit == 'L') {
                fruitList.Push('M');
                fruitList.Push('M');
            } 
            else if (fruit == 'M') {
                fruitList.Push('S');
                fruitList.Push('S');
                fruitList.Push('S');
            }  
        }
    }
    
    static void Main(string[] args) {
        Queue<char> fruitList = new Queue<char>();
        InputFruit(fruitList);

        Queue<int> processCount = new Queue<int>();
        for (int i = 0; i < fruitList.GetLength(); i++)
        {
            char getFruit = fruitList.Get(i);
            if (getFruit == 'L') {
                processCount.Push(1);
            } 
            else if (getFruit == 'M') {
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
}