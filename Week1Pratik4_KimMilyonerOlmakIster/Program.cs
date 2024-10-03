
Console.WriteLine("Kim milyoner olmak ister yarismasina hosgeldiniz sayin seyirciler ve sen sayin yarismaci.");

Console.WriteLine("Evet ilk sorumuzla basliyoruz. Uzaylilarin kac gozu vardir? a) 1 b)bilinmiyor");
string Secim1 = Console.ReadLine().ToLower(); //Harf boyutunun onemi elimine ediliyor
string Cevap1 = "b"; //dogru cevap

string result1 = (Secim1 == Cevap1) ? "Dogru" : "Yanlis"; // terniary operator ile dogru ya da yanlis cevap oldugu belirtiliyor
Console.WriteLine(result1 + "Cevap");

Console.WriteLine("Ikinci soru ile devam ediyoruz. İstanbul Boğazı'ndan geçen en hızlı şey nedir? a) Jetski b)elektrik");
string Secim2 = Console.ReadLine().ToLower();
string Cevap2 = "b";

string result2 = (Secim2 == Cevap2) ? "Dogru" : "Yanlis";
Console.WriteLine(result2 + "Cevap");

if (Secim1 == Cevap1 && Secim2 == Cevap2) //2 soru dogruysa direkt odul veriliyor
    Console.WriteLine("Tebrikler 1 milyon degerindeki odulumuzu kazandiniz!");
else if (Secim1 == Cevap1 || Secim2 == Cevap2) // her iki sorudan birine dogru cevap veren kisiye 3. soru sorulur
{
    Console.WriteLine("Ucuncu sorumuza geciyoruz. Yigidi ne oldurmez? a)Borc b)Dost");
    string Secim3 = Console.ReadLine().ToLower();
    string Cevap3 = "a";

    if (Secim3 == Cevap3) 
        Console.WriteLine("Dogru Cevap! Tebrikler 1 milyon degerindeki odulumuzu kazandiniz!");
    else
        Console.WriteLine("Bu da yanlis cevap! Maalesef sizi bin lira ile ugurluyoruz");
} 
else // iki soru da yanlissa yarismaciyi gonderiyoruz
    Console.WriteLine("Maalesef sizi bin lira ile ugurluyoruz");

Console.ReadKey();
