Random random = new Random();
int a = random.Next(1, 101);

int number;
int so_lan = 0;

Console.WriteLine("TRO CHOI DOAN SO\n");

do
{
    Console.Write("Hay nhap so ban du doan: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number == a)
    {
        Console.WriteLine("Ban da doan dung!");
        break;
    }  
    else
    {   
        if(number > a)
            Console.WriteLine("So ban doan lon hon so random");
        if (number < a)
            Console.WriteLine("So ban doan nho hon so random");
        so_lan++;
    }    
}
while (so_lan < 7) ;