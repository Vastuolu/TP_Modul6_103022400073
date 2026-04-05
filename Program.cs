using TP_Modul6_103022400073;

Console.Write("Masukkan Judul Lagu: ");
string title = Console.ReadLine()!;

try
{
    Console.WriteLine("\n[TEST] Input normal dari user");
    SayaMusicTrack track = new SayaMusicTrack(title);
    Console.Write("Masukkan Play Count: ");
    int playCount = int.Parse(Console.ReadLine()!);
    track.IncreasePlayCount(playCount);
    track.PrintTrackDetails();
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType().Name} - {ex.Message}");
}

try
{
    Console.WriteLine("\n[TEST] Precondition: judul null");
    SayaMusicTrack trackNull = new SayaMusicTrack(null);
    trackNull.PrintTrackDetails();
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType().Name} - {ex.Message}");
}

try
{
    Console.WriteLine("\n[TEST] Precondition: judul > 100 karakter");
    string judulPanjang = new string('A', 101);
    SayaMusicTrack trackJudulPanjang = new SayaMusicTrack(judulPanjang);
    trackJudulPanjang.PrintTrackDetails();
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType().Name} - {ex.Message}");
}

try
{
    Console.WriteLine("\n[TEST] Precondition: tambah play count > 10.000.000");
    SayaMusicTrack trackCount = new SayaMusicTrack("Track Uji Count");
    trackCount.IncreasePlayCount(10000001);
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType().Name} - {ex.Message}");
}

try
{
    Console.WriteLine("\n[TEST] Exception overflow dengan checked");
    SayaMusicTrack overflowTrack = new SayaMusicTrack("Track Uji Overflow");

    for (int i = 0; i < 300; i++)
    {
        overflowTrack.IncreasePlayCount(10000000);
    }

    overflowTrack.PrintTrackDetails();
}
catch (Exception ex)
{
    Console.WriteLine($"{ex.GetType().Name} - {ex.Message}");
}
