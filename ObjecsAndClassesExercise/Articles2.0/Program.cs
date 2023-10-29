namespace Articles2._0
{
    using System.Net.Http.Headers;

    namespace Articles
    {
        class Article
        {
            public Article(string title, string content, string author)// constructor
            {
                Title = title;
                Content = content;
                Author = author;
            }

            public string Title { get; set; }// properties
            public string Content { get; set; }
            public string Author { get; set; }

            public override string ToString()
            {
                return $"{Title} - {Content}: {Author}";
                //Console.WriteLine($"{Title} - {Content}: {Author}");
            }
        }
        internal class Program
        {
            static void Main(string[] args)
            {
                

                List<Article> articles = new List<Article>();

                
                int commandCount = int.Parse(Console.ReadLine());
                for (int i = 0; i < commandCount; i++)
                {
                    string[] articleString = Console.ReadLine()
                        .Split(", ")
                        .ToArray();

                    Article article = new Article(articleString[0], articleString[1], articleString[2]);
                    articles.Add(article);
                }

                foreach (Article article in articles)
                {
                    Console.WriteLine(article.ToString());
                }
            }
        }
    }
}