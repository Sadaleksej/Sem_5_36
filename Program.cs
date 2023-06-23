// See https://aka.ms/new-console-template for more information
Console.Clear();
int[] arrr = new int[30];
FilArray(arrr);
PrintArray(arrr);
Console.WriteLine();
Console.WriteLine($"Сумма элементов на нечетных позициях: {SumUnEven(arrr)}");

void FilArray(int[] ar)
{
    for (int i = 0; i < ar.Length; i++) ar[i] = new Random().Next(1, 99);
}

void PrintArray(int[] ar)
{
    for (int i = 0; i < ar.Length; i++) Console.Write(ar[i] + " ");
}
int SumUnEven(int[] ar)
{
    int sum = 0;

  for (int i = 0; i<ar.Length; i++) 
    {
    if(i % 2 != 0) sum = sum + ar[i];
    }
return sum;
}
