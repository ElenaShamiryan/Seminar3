void Cube (int a)
{
for (int b=1; b<=a; b++)
{
Console.Write(b*b*b+" ");
}
}
Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
Cube (num);
