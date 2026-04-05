using TP_Modul6_103022400073;

Console.Write("Masukkan Judul Lagu: ");
string title = Console.ReadLine();
SayaMusicTrack track = new SayaMusicTrack(title);
Console.Write("Masukkan Play Count: ");
int playCount = int.Parse(Console.ReadLine());
track.IncreasePlayCount(playCount);
track.PrintTrackDetails();