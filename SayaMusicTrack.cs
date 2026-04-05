using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace TP_Modul6_103022400073
{
    internal class SayaMusicTrack
    {
        private int id;
        private int playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            Debug.Assert(title != null, "Judul track tidak boleh null.");
            Debug.Assert(title == null || title.Length <= 100, "Judul track maksimal 100 karakter.");

            if (title is null)
            {
                throw new ArgumentNullException(nameof(title), "Judul track tidak boleh null.");
            }

            if (title.Length > 100)
            {
                throw new ArgumentException("Judul track maksimal 100 karakter.", nameof(title));
            }

            this.id = Random.Shared.Next(10000, 99999); 
            this.title = title;
            this.playCount = 0;
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Penambahan play count maksimal 10.000.000 tiap pemanggilan.");

            if (count > 10000000)
            {
                throw new ArgumentOutOfRangeException(nameof(count), "Penambahan play count maksimal 10.000.000 tiap pemanggilan.");
            }

            checked
            {
                playCount += count;
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine($"Id: {id} | Title: {title} | Play Count: {playCount}");
        }
    }
}
