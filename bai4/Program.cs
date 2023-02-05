// bai lam cua Pham Duc Minh
// khoi tao va gan gia tri random tu 1 den 100 cho bien a
Random random = new Random();
int a = random.Next(1, 101);
// khai bao bien number va khoi tao bien so_lan
int number;
int so_lan = 0;

Console.WriteLine("TRO CHOI DOAN SO\n");
// gan gia tri cho bien number va kiem tra voi bien a va tang so_lan
do
{
    Console.Write("Hay nhap so ban du doan: ");
    number = Convert.ToInt32(Console.ReadLine());
    if (number == a)
    {
        Console.WriteLine("Ban da doan dung!");
        return;
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
Console.WriteLine("Ban da het luot choi");