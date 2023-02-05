int n = 0;
int bien_dem = 0;

do
{
    Console.Write("Nhap so n (n>2): ");
    n = Convert.ToInt32(Console.ReadLine());
}
while (n <= 2);

for (int i = 1; i <= n; i++)
    if (n % i == 0)
        bien_dem++;

if (bien_dem == 2)
    Console.WriteLine("So da cho la so nguyen to.");
else
    Console.WriteLine("So da cho khong phai la so nguyen to.");