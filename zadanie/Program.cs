Console.WriteLine("Введите число");
int num = Convert.ToInt32(Console.ReadLine());
if(num > 99)
{
    int i = num;
    while(i > 999) 
    {
        i/=10;
    }

Console.WriteLine(i%10);
}
else
Console.WriteLine("Третьей цифры нет");
