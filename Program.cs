internal class Program
{
    private static void Main(string[] args)
    {

    int [] sayidizisi = {48,81,67,12,56,34,23};
    System.Console.WriteLine("*****Sırasız Dizi*****");
  
       //sort
    foreach (var sayi in sayidizisi)
    {
        System.Console.WriteLine(sayi);
    }
    System.Console.WriteLine("*****Sıralı Dizi*****");
    Array.Sort (sayidizisi);

    foreach (var sayi in sayidizisi)
    {
        System.Console.WriteLine(sayi);
    }
    //Clear
    System.Console.WriteLine("*****Array Clear*****");
    Array.Clear (sayidizisi,2,3);
    foreach (var sayi in sayidizisi)
    {
        System.Console.WriteLine(sayi);
    }
    //Reverse
    System.Console.WriteLine("*****Array Reverse*****");
    Array.Reverse (sayidizisi);
    foreach (var sayi in sayidizisi)
    {
        System.Console.WriteLine(sayi);
    }
    //Indexof
    System.Console.WriteLine("*****Array Indexof *****");
    System.Console.WriteLine(Array.IndexOf(sayidizisi,12));

    //Resize
    System.Console.WriteLine("*****Array Resize *****");
    Array.Resize<int> (ref sayidizisi,8);
    sayidizisi [7] = 98;

    foreach (var sayi in sayidizisi)
    {
        System.Console.WriteLine(sayi);        
    }







    }
}