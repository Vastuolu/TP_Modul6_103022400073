using System;
using System.Collections.Generic;
using System.Text;

namespace TP_Modul6_103022400073
{
    internal class SayaMusicTrack
    {
        private int id;
        private string playCount, title;

        public SayaMusicTrack(string title)
        {
            this.id = Random.Shared.Next(10000, 99999); 
            this.title = title;
            this.playCount = "0";
        }

        public void IncreasePlayCount(int count)
        {
            playCount = (int.Parse(playCount) + count).ToString();
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine($"Id: {id} | Title: {title} | Play Count: {playCount}");
        }
    }
}
