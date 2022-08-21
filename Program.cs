using System;

namespace operatorler
{

    class Program
    {
        static void Main (string[] args)
        {
           Console.WriteLine("***** Atama ve işlemli Atama Operatörleri ****");
           // Atama Ve İşlemli Atama
           int x = 3;
           int y = 3;
           y = y+2;

           Console.WriteLine(y);
           y += 2;
           Console.WriteLine(y);
           y /=1;
           Console.WriteLine(y);
           x *=2;
           Console.WriteLine(x);
           Console.WriteLine("**** Mantıksal Operatörler *****");
           //Mantıksal Operatörler
           // ||, &&, !

           bool isSuccess = true;
           bool isComplate = false;

           if(isSuccess && isComplate)
              Console.WriteLine("Perfect");
           
           if(isSuccess || isComplate)
                Console.WriteLine("Great");

           if(isSuccess && !isComplate)
                Console.WriteLine("Fine");

           // İlişkisel Operatörler
           //<, >, <=, >=, ==,!=
           
           int a = 3;
           int b = 4;
           bool sonuc = a<b;
           Console.WriteLine(sonuc);
           sonuc =a>b;
           Console.WriteLine(sonuc);
           sonuc = a<=b;
           Console.WriteLine(sonuc);
           sonuc = a>=b;
           Console.WriteLine(sonuc);
           sonuc = a==b;
           Console.WriteLine(sonuc);
           sonuc = a!=b;
           Console.WriteLine(sonuc);

           Console.WriteLine("*** Aritmetik Operatörler");
           // /, *, +,-

           int sayi = 10;
           int sayi2 = 5;

           int sonuc1 = sayi/sayi2;
           Console.WriteLine(sonuc1);
           sonuc1 = sayi*sayi2;
           Console.WriteLine(sonuc1);
           sonuc1 = sayi+sayi2;
           Console.WriteLine(sonuc1);
           sonuc1 = sayi-sayi2;
           Console.WriteLine(sonuc1);
           sayi++;
           Console.WriteLine(sayi);

           // % : mod alır
           int sonuc2= 20%3;
           Console.WriteLine(sonuc2);


        }


    }
}