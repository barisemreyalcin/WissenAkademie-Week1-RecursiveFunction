
// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

#region RECURSIVE FUNCTION
// Method ya da function içerisinde method'un kendisini çağırdığı yapıdır. (Özyineleme)

#region FACTORIAL

//Console.Write("Enter a number to calculate its factorial: ");
//int num = int.Parse(Console.ReadLine());

//decimal factorial = CalcFactorial(num);
//Console.WriteLine($"{num}! =    { factorial}");

//decimal CalcFactorial(int num)
//{
//    if (num == 0 || num == 1)
//        return 1;
//    else
//    {
//        return num * CalcFactorial(num - 1);
//    }
//}

#endregion

#region FIBONACCI

Console.Write("Enter the position of the Fibonacci series you want to calculate: ");
int num = int.Parse(Console.ReadLine());

for (int i = 0; i < num; i++)
{
    Console.WriteLine(CreateFibonacci(i));
}

int CreateFibonacci(int i)
{
    if (i == 0)
        return 0;
    else if (i == 1) 
        return 1;
    else {
        return CreateFibonacci(i - 1) + CreateFibonacci(i - 2);
    }
}

#endregion

#endregion
