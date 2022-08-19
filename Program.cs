using System;

class Program{

    static void Main(string[] args){

        //out parametreler
        string sayi = "999";

        bool sonuc = int.TryParse(sayi, out int outSayi);
        if (sonuc)
        {
            Console.WriteLine("başarılı");
            Console.WriteLine(outSayi);
        }else{
            Console.WriteLine(outSayi);
        }

        metotlar instance = new metotlar();
        instance.Topla(4,5, out int toplamsonucu);
        Console.WriteLine(toplamsonucu);

        //metot aşırı yükleme - overloading

        int ifade = 999;
        instance.EkranaYazdir(Convert.ToString(ifade));
        instance.EkranaYazdir(ifade);
        instance.EkranaYazdir("ibrahim" );


    }
}

class metotlar{

    public void Topla(int a, int b, out int toplam){
        toplam = a+b;
    }

    public void EkranaYazdir(String veri){
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(int veri){
        Console.WriteLine(veri);
    }
    public void EkranaYazdir(String veri1, string veri2){
        Console.WriteLine(veri1, veri2);
    }

}