Console.OutputEncoding=System.Text.Encoding.UTF8;

while (true)
{
    double netice = 0;
    // Istifadeciden deyeri alan funksiya cagrilir
    double inputDeyer = DeyerAl();

	Console.WriteLine("0) Exit");
	Console.WriteLine("1) Kg to t");
    Console.WriteLine("2) Km to sm");

    Console.WriteLine("Zəhmət olmasa hansı çevirmə əməliyyatını yerinə yetirmək istədiyinizi seçin:");
    int cevirme_emeliyyati = Convert.ToInt32(Console.ReadLine());

    switch (cevirme_emeliyyati)
    {
        case 0:
            Console.WriteLine("Proqramı işlətdiyiniz təşəkkürlər");
            return;
        case 1:
            Console.WriteLine("Kg to t");
            netice = inputDeyer / 1000.0;// Dustur tetbiq olunub
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
// Bir nov oz TryParse i
double DeyerAl()
{
    while (true)
    {
        Console.WriteLine("Zəhmət olmasa dəyəri daxil edin:");
        try
        {
            return Convert.ToDouble(Console.ReadLine());
        }
        catch (FormatException)
        {
            Console.WriteLine("Gözlənilməz xəta baş verdi. Zəhmət olmasa düzgün dəyər daxil edin!");
        }
    }
}