// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"


using static System.Console;
Clear();
WriteLine("Задача 64");
Write("Введите число:    ");
int num=int.Parse(ReadLine()!);
GetNumbers(num);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

WriteLine();
WriteLine("Задача 66");
Write("Введите первое число:    ");
int M=int.Parse(ReadLine()!);
Write("Введите второе число:    ");
int N=int.Parse(ReadLine()!);
WriteLine($"Cумма натуральных элементов в промежутке равна {GetSumOfInterval(M,N)}");

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

WriteLine();
WriteLine("Задача 68");
Write("Введите первое неотрицательное число:    ");
int first=int.Parse(ReadLine()!);
Write("Введите второе неотрицательное число:    ");
int second=int.Parse(ReadLine()!);
WriteLine($"Значение функции Аккермана {AkkermanFunction(first,second)}");




void GetNumbers (int number)
{
    if(number<1)
    {
    if (number==1) Write(1);
    else 
    {
        Write($"{number}, ");
        GetNumbers(number+1);
    }
    }
    if(number>=1)
    {
    if (number==1) Write(1);
    else 
    {
        Write($"{number}, ");
        GetNumbers(number-1);
    }
    }
}


int GetSumOfInterval (int m, int n)
{
    if(m<n)
    {
        return m==n? m: n+GetSumOfInterval(m, n-1);
        // if(m==n) return m;
        // else return n+GetSumOfInterval(m, n-1);
    }
    else
    {
        if(n==m) return n;
        else return m+GetSumOfInterval(n, m-1);
    }
}


int AkkermanFunction (int M, int N)
{
    if (M==0) return N+1;
    if (M!=0 && N==0) return AkkermanFunction(M-1, 1);
    else return AkkermanFunction(M-1, AkkermanFunction(M,N-1));
}