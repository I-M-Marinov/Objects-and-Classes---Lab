using System;
using System.Collections.Generic;
using System.Linq;

namespace P3.Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfSongs = int.Parse(Console.ReadLine());
            List<Song> songList = new List<Song>();

            for (int i = 0; i < numberOfSongs; i++)
            {
                List<string> input = Console.ReadLine().Split("_").ToList();
                
                string type = input[0];
                string name = input[1];
                string time = input[2];

                Song song = new Song();

                song.TypeList = type;
                song.Name = name;
                song.Time = time;

                songList.Add(song);
            }

            string typeList = Console.ReadLine();

            if (typeList == "all")
            {
                foreach (Song song in songList)
                {
                    Console.WriteLine(song.Name);
                }
            }
            else
            {
                foreach (Song song in songList)
                {
                    if (song.TypeList == typeList)
                    {
                        Console.WriteLine(song.Name);
                    }
                }
            }

            // another way to filter the songs if the type of list has been called from the console (using System.Linq)

            /*
             List<Song> filteredSongs = songList.Where(s => s.TypeList == typeList).ToList();

            foreach (Song song in filteredSongs)
            {
             Console.WriteLine(song.Name);
            }
            */

        }
    }
    }

    class Song
    {
        public string TypeList { get; set; }
        public string Name { get; set; }
        public string Time { get; set; }

    }

