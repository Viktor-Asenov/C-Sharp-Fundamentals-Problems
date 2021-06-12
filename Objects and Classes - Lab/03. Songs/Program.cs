using System;
using System.Collections.Generic;
using System.Linq;

namespace _03._Songs
{
    public class Program
    {
        class Song
        {
            public string TypeList { get; set; }

            public string Name { get; set; }

            public string Time { get; set; }
        }
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> songs = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] currentSongData = Console.ReadLine().Split('_').ToArray();

                string type = currentSongData[0];
                string name = currentSongData[1];
                string time = currentSongData[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songs.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songs)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songs)
                {
                    if (typeList == song.TypeList)
                    {
                        Console.WriteLine(song.Name);
                    }

                }
            }
        }
    }   
}
