Console.OutputEncoding=System.Text.Encoding.UTF8;

double deyerFunc()
{
    double deyer = 0;
    while (true)
    {
        Console.WriteLine("Zəhmət olmasa dəyəri daxil edin:");
        try
        {
            deyer = Convert.ToDouble(Console.ReadLine());
            break;
        }
        catch (FormatException)
        {
            Console.WriteLine("Gözlənilməz xəta baş verdi. Zəhmət olmasa düzgün dəyər daxil edin!");
        }
    }
    return deyer;
}

while (true)
{
    double netice = 0;
    double inputDeyer = deyerFunc();

    Console.WriteLine("Zəhmət olmasa hansı çevirmə əməliyyatını yerinə yetirmək istədiyinizi seçin:");
    int cevirme_emeliyyati = Convert.ToInt32(Console.ReadLine());

    switch (cevirme_emeliyyati)
    {
        case 1:
            Console.WriteLine("Kg to t");
            netice = inputDeyer / 1000.0;
            Console.WriteLine($"{inputDeyer} kg ={netice} t");
            break;
        case 2:
            Console.WriteLine("Km to sm");
             netice  = inputDeyer * 100000.0;
            Console.WriteLine($"{inputDeyer} km ={netice} sm");
            break;
        case 3:
            Console.WriteLine("F to C");
             netice = (inputDeyer - 32.0) * 5.0 / 9.0;
            Console.WriteLine($"{inputDeyer} F ={netice}C");
            break;
        default:
            Console.WriteLine("Belə bir seçim yoxdur! Yenidən cəhd edin");
            break;
    }
}








