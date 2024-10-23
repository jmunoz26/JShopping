
using JShopping;

Console.WriteLine("Hello, World!");



try
{
  Console.WriteLine(new Date(2022, 2, 11));
  Console.WriteLine(new Date(1974, 9, 23));
  Console.WriteLine(new Date(1522, 11, 45));

}
catch (Exception error)
{
  Console.WriteLine(error.Message);
}