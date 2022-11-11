// See https://aka.ms/new-console-template for more information


// out parametreler
string sayi="999";
int outSayi;

bool sonuc = int.TryParse(sayi, out outSayi);
if(sonuc)
{
    Console.WriteLine("Başarılı");
    Console.WriteLine(outSayi);
}
else
{
        Console.WriteLine("Başarısız");

}

 Metotlar instance = new Metotlar();
 instance.Topla(4,5,out int toplamSonucu);
  Console.WriteLine("toplamSonucu");


class Metotlar
{
    public void Topla(int a, int b, out int toplam)
{
    toplam = a+b;
}
}