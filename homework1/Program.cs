// Задайте значения M и N. Напишите программу, которая выведет все
//  натуральные числа 
// в промежутке от M до N. Использовать рекурсию, не использовать циклы

void PrintMN(int numm, int numn)
{
    if (numm == numn)
    {
        Console.WriteLine(numm);
        return;
    }
    if (numn > numm)
    {
    PrintMN (numm, numn - 1);
    Console.WriteLine(numn);
    }
    if (numn < numm)
    {
    PrintMN (numm, numn + 1);
    Console.WriteLine(numn);
    }

}





Console.WriteLine("Введите M:");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите N:");
int n = Convert.ToInt32(Console.ReadLine());
PrintMN(m,n);




