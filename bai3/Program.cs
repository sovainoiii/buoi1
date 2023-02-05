// bai lam cua Pham Duc Minh
// khai bao bien n, bien_dem
int n;
int bien_dem = 0;
// nhap n > 2
do
{
    Console.Write("Nhap so n (n>2): ");
    n = Convert.ToInt32(Console.ReadLine());
}
while (n <= 2);
// vong lap kiem tra so nguyen to
for (int i = 1; i <= n; i++)
    if (n % i == 0)
        bien_dem++;
// kiem tra bien_dem
if (bien_dem == 2)
    Console.WriteLine("So da cho la so nguyen to.");
else
    Console.WriteLine("So da cho khong phai la so nguyen to.");