using System;
using System.Linq;
using System.Numerics;

namespace Songs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Song> playList = new List<Song>();

            for (int i = 0; i < n; i++)
            {
                string[] lineTokens = Console.ReadLine().Split("_");
                string listType = lineTokens[0];
                string songName = lineTokens[1];
                string songTime = lineTokens[2];

                //Song song = new Song();
                //{
                    //Name = songName,
                    //TypeList = listType,
                    //Time = songTime
                //};

                //song.Name = songName;
                //song.TypeList = listType;
                //song.Time = songTime;

                Song song = new Song(listType, songName, songTime);
                playList.Add(song);

            }
            string filter = Console.ReadLine();
            if (filter != "all")
            {
                foreach (Song song in playList)
                {
                    if (song.TypeList == filter )
                    {
                        Console.WriteLine(song.Name);
                    }
                }
                return;
                // for (int i = playList.Count-1; i >= 0; i--)
                //{
                // Song currentSong = playList[i];
                //if (currentSong.TypeList != filter)
                //{
                // playList.RemoveAt(i);
                //}
                //}
            }
            foreach (Song song in playList)
            {
                Console.WriteLine(song.Name);
            }

        }

        public class Song
        {
            public Song()
            {

            }
            public Song(string typeList, string name, string time)
            {
                this.TypeList = typeList;
                this.Name = name;
                this.Time = time;
            }

            public string TypeList { get; set; }

            public string Name { get; set; }

            public string Time { get; set; }

        }
    }
}