//Khai bao bien a, b
float a, b;
//Khai bao bien pheptinh
string pheptinh;
//Nhap tu ban phim va gan du lieu cho bien a
do
{
    Console.Write("Nhap so a: ");
} 
while(!float.TryParse(Console.ReadLine(),out a));
//Nhap tu ban phim va gan du lieu cho bien b
do
{
    Console.Write("Nhap so b: ");
}
while (!float.TryParse(Console.ReadLine(), out b));
//Nhap pheptinh
Console.Write("Nhap phep tinh ( +-*/ ): ");
pheptinh = Console.ReadLine();
//Xuat ra ket qua
switch (pheptinh)
{
    case "+":
        Console.WriteLine($"Tong 2 so la: {a} + {b} = {a + b}");
        break;
    case "-":
        Console.WriteLine($"Hieu 2 so la: {a} - {b} = {a - b}");
        break;
    case "*":
        Console.WriteLine($"Tich 2 so la: {a} * {b} = {a * b}");
        break;
    case "/":
        Console.WriteLine($"Thuong 2 so la: {a} / {b} = {a / b}");
        break;
    default:
        Console.WriteLine("Nhap sai dinh dang");
        break;
}
