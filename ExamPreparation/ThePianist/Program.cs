namespace ThePianist
{
    class MusicPiece
    {
        public string Name { get; set; }
        public string Composer { get; set; }
        public string Key { get; set; }

        public MusicPiece(string name, string composer, string key)
        {
            Name = name;
            Composer = composer;
            Key = key;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<MusicPiece> pieces = new List<MusicPiece>();

            for (int i = 0; i < n; i++) 
            {
                string[] input = Console.ReadLine().Split('|');
                string piece = input[0];
                string composer = input[1];
                string key = input[2];
                pieces.Add(new MusicPiece(piece, composer, key));
            }

            string command;
            while ((command = Console.ReadLine()) != "Stop")
            {
                string[] commandArgs = command.Split('|');
                string action = commandArgs[0];
                string piece = commandArgs[1];

                switch (action)
                {
                    case "Add":
                        string composer = commandArgs[2];
                        string key = commandArgs[3];
                        AddPiece(pieces, piece, composer, key);
                        break;
                    case "Remove":
                        RemovePiece(pieces, piece);
                        break;
                    case "ChangeKey":
                        string newKey = commandArgs[2];
                        ChangeKey(pieces, piece, newKey);
                        break;
                }
            }
            foreach (var  musicPiece in pieces)
            {
                Console.WriteLine($"{musicPiece.Name} -> Composer: {musicPiece.Composer}, Key: {musicPiece.Key}");
            }
        }

        private static void ChangeKey(List<MusicPiece> pieces, string piece, string newKey)
        {
            MusicPiece musicPiece = pieces.Find(p => p.Name == piece);
            if (musicPiece != null) 
            {
                musicPiece.Key = newKey;
                Console.WriteLine($"Changed the key of {piece} to {newKey}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
        }

        private static void RemovePiece(List<MusicPiece> pieces, string piece)
        {
            MusicPiece musicPiece = pieces.Find(p => p.Name == piece);
            if (musicPiece != null) 
            {
                pieces.Remove(musicPiece);
                Console.WriteLine($"Successfully removed {piece}!");
            }
            else
            {
                Console.WriteLine($"Invalid operation! {piece} does not exist in the collection.");
            }
        }

        private static void AddPiece(List<MusicPiece> pieces, string piece, string composer, string key)
        {
            bool exists = pieces.Exists(p => p.Name == piece);
            if (exists) 
            {
                Console.WriteLine($"{piece} is already in the collection!");
            }
            else 
            {
                pieces.Add(new MusicPiece(piece, composer, key));
                Console.WriteLine($"{piece} by {composer} in {key} added to the collection!");
            }
        }
    }
}