float a, b, c;

Console.Write("Nhap he so bac 2, a = ");
a = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap he so bac 1, b = ");
b = Convert.ToInt32(Console.ReadLine());
Console.Write("Nhap he so bac 0, c = ");
c = Convert.ToInt32(Console.ReadLine());

if (a == 0)
{
    if (b == 0)
    {
        Console.Write("Phuong trinh vo nghiem!");
    }
    else
    {
        Console.Write($"Phuong trinh co mot nghiem: x = {-c / b}");
    }
    return;
}
// tinh delta
float delta = b * b - 4 * a * c;
float x1;
float x2;
// tinh nghiem
if (delta > 0)
{
    x1 = (float)((-b + Math.Sqrt(delta)) / (2 * a));
    x2 = (float)((-b - Math.Sqrt(delta)) / (2 * a));
    Console.Write($"Phuong trinh co 2 nghiem la: x1 = {x1} va x2 = {x2}");
}
else if (delta == 0)
{
    x1 = (-b / (2 * a));
    Console.Write($"Phong trinh co nghiem kep: x1 = x2 = {x1}");
}
else
{
    Console.Write("Phuong trinh vo nghiem!");
}