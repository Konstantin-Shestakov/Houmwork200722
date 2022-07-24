// Задача 64: Задайте значения M и N. Напишите программу, которая выведет все натуральные числа в промежутке от M до N.

// M = 1; N = 5. -> ""1, 2, 3, 4, 5""

// // M = 4; N = 8. -> ""4, 6, 7, 8""
// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.Clear();
//         Console.WriteLine("Задайте значение М, меньшее значения промежутка:  ");
//         int M = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Задайте значение N, ,большее значения промежутка:  ");
//         int N = Convert.ToInt32(Console.ReadLine());
//        
//         Console.WriteLine(" M = " + M +";" + " N = " + N + ". -> "+ PrintRecursiveNumber(M,N));

//         string PrintRecursiveNumber (int start, int end)
//         {
//             if (start == end)
//             {
//                 return start.ToString();

//             }
//                 return start + "," + " " + PrintRecursiveNumber(start +1, end);
//         }
// }
// }


// // Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.

// // M = 1; N = 15 -> 120
// // M = 4; N = 8. -> 30

// internal class Program
// {
//     private static void Main(string[] args)
//     {
//         Console.Clear();
//         Console.WriteLine("Задайте значение М, меньшее значения промежутка:  ");
//         int M = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine("Задайте значение N, ,большее значения промежутка:  ");
//         int N = Convert.ToInt32(Console.ReadLine());
//         Console.WriteLine($" M = {M}; N = {N}. -> {PrintRecursiveNumber(M,N)}");
//        

//         int PrintRecursiveNumber (int start, int end)
//         {

//             if (start == end)
//             {

//                 return start;
//             }
//             return   start + PrintRecursiveNumber(start+1, end);

//         }
// }
// }

// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9

internal class Program
{
    private static void Main(string[] args)
    {
        // m=0 -> n+1; 
        // m>0 и n=0 -> A(m-1,1); 
        // m>0 и n>0 -> A(m-1,A(m,n-1))
        Console.Clear();
        Console.WriteLine("Задайте значение m:  ");
        int m = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Задайте значение n:  ");
        int n = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($" m = {m}, n = {n} -> A(m,n) = {Ack(m, n)}");

        int Ack(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return Ack(m - 1, 1);
            }
            else if (m > 0 && n > 0)
            {
                return Ack(m - 1, Ack(m, n - 1));
            }
            else
                return n + 1;
        }
    }
}