
int a = 17;
int b = 38;
int max = a;
int min = a;
{
if(b > max) max = b;
if(b < min) min = b;
}
Console.WriteLine(max );
Console.WriteLine(min);