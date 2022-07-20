void Palindrom(int n)
{
    if (n > 99999) Console.WriteLine("Введите пятизначное число");
    if (n < 99999)
    {
        int index = 0;
        string s1 = Convert.ToString(n);
        int length = s1.Length;
        for (; s1[index] == s1[length - 1];)
        {
            index++;
            length--;
            Console.Write("число является палиндромом");
            break;
        }
        for (; s1[index] != s1[length - 1];)
        {
            Console.WriteLine("число НЕ является палиндромом");
            break;
        }
    }
}

Console.WriteLine("Введите пятизначное число");
int num = Convert.ToInt32(Console.ReadLine());
Palindrom(num);
