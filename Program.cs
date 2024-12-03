namespace lesson_2_12;

class Program
{
    static void Main(string[] args)
    {
        int[] x = {4, 215, -2, 252, -16, 254, 52, 5, 521};

        Console.WriteLine("Задание 1 ------------------");
        int sum = 0;
        foreach (int i in x){
            sum += i;
        }
        Console.WriteLine("summa " + sum);

        Console.WriteLine("Задание 2 ------------------");
        int max = x[0];
        foreach (int i in x){
            if (i > max){
                max = i;
            } 
        }
        Console.WriteLine("max chislo " + max);

        Console.WriteLine("Задание 3 ------------------");
        Console.WriteLine("перевернутый массив");
        Array.Reverse(x);
        foreach (int i in x){
            Console.WriteLine(i);
        }
        Array.Reverse(x); // т.к. у меня все в одном файле, для следующийх заданий нужно вернуть массив в исходное состояние

        Console.WriteLine("Задание 4 ------------------");
        Console.WriteLine("четкие числа ");
        foreach (int i in x){
           if (i % 2 == 0){
            Console.WriteLine(i);
           }
        }

        Console.WriteLine("Задание 5 ------------------");
        Console.WriteLine("бандиты");
        foreach (int i in x){
            if (i < 0){
                Console.WriteLine(i);
            }
        }

        Console.WriteLine("Задание 6 ------------------");
        int y = 5;
        int cnt = 0;
        foreach (int i in x){
            if (i == y){
                cnt += 1;
            }
        }    
            if (cnt == 0){
                Console.WriteLine("Элемент не найден");
            }
            else{
                Console.WriteLine("Элемент найден");
            }

        Console.WriteLine("Задание 7 ------------------");        
        for (int i = 1; i < x.Length; i += 2){
            Console.WriteLine(x[i]);
        }

        Console.WriteLine("Задание 8 ------------------");
        int min = x[0];
        foreach (int i in x){
            if (i < min){
                min = i;
            } 
        }
        Console.WriteLine("min chislo " + min); // нашел только минимальное т.к. нахождение максимального уже было

        Console.WriteLine("Задание 9 ------------------");
        Array.Sort(x);
        foreach (int i in x){
            Console.WriteLine(i);
        }
        Array.Sort(x); // т.к. у меня все в одном файле, для следующийх заданий нужно вернуть массив в исходное состояние
        Console.WriteLine("Задание 10 ------------------");
        for (int i = 0; i < x.Length; i++){
            if (x[i] < 0){
                x[i] = 0;
            }
            Console.WriteLine(x[i]);
        }





    }
}
