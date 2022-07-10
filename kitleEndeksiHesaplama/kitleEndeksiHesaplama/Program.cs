Console.WriteLine("Vücut Kitle Endeksi Hesaplama");

while (true) {

    // veri girişi
    Console.Write("Boyunuzu giriniz (cm): ");
    int boy = Int32.Parse(Console.ReadLine());

    Console.Write("Kilonuzu giriniz (kg): ");
    int kilo = Int32.Parse(Console.ReadLine());

    //cm i metre ye çevirmemiz gerek
    double boyMetreCinsinden = boy / 100.0;

    //endeks formülü
    double endeks = kilo / Math.Pow(boyMetreCinsinden, 2.0);


    // Mantıksal sorgular
    if (endeks < 18.5)
    {
        Console.WriteLine("Zayıfsınız :(");
        Console.WriteLine("Endeksiniz: "+endeks.ToString());
    }
    else if (endeks > 18.5 && endeks < 25)
    {
        Console.WriteLine("Kilonuz Normal :D");
        Console.WriteLine("Endeksiniz: " + endeks.ToString());
    }
    else if (endeks > 25 && endeks < 30)
    {
        Console.WriteLine("Kilolusunuz :(");
        Console.WriteLine("Endeksiniz: " + endeks.ToString());
    }
    else if (endeks > 30 && endeks < 35)
    {
        Console.WriteLine("1. Seviye Obezitesiniz :(");
        Console.WriteLine("Endeksiniz: " + endeks.ToString());
    }
    else if (endeks > 35 && endeks < 40)
    {
        Console.WriteLine("2. Seviye Obezsiniz :(");
        Console.WriteLine("Endeksiniz: " + endeks.ToString());
    }
    else
    {
        Console.WriteLine("Son Seviye Obezsiniz :'(");
        Console.WriteLine("Endeksiniz: " + endeks.ToString());
    }

    // start atlama oktası.
    Start:

    Console.Write("Tekrar hesaplamak ister misiniz (evet / hayır)? ");
    string soru = Console.ReadLine();

    // Programın tekrar çalışması veya çıkış işlemi
    if (soru == "evet")
    {
        continue;
    }
    else if(soru == "hayır")
    {
        break;
    }
    else
    {
        Console.WriteLine("Yanlış yazdınız.");
        // start'a git
        goto Start;
    }

}