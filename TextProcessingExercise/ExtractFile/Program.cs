namespace ExtractFile
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string file = Console.ReadLine();

            string fileName = String.Empty;
            string fileExtension = String.Empty;

            int lastSeparator = file.LastIndexOf('\\');
            int extensionIndex = file.LastIndexOf(".");
            if (lastSeparator != -1 && extensionIndex != -1 && lastSeparator < extensionIndex)
            {
                fileName = file.Substring(lastSeparator+1, extensionIndex-lastSeparator-1);
                fileExtension = file.Substring(extensionIndex + 1);
            }

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}