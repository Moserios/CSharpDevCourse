using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Remoting.Channels;
using System.Threading.Tasks;


//In this assignment, you will create a C# console application that demonstrates the use of delegates and events.
//You will create a NewsArticle class that represents a news article, a NewsArticleCollection class that represents a collection of news articles, and a console application that uses the NewsArticleCollection class to filter news articles by category and notify subscribers when new articles are added to or removed from the collection.

//Requirements
//Create a NewsArticle class with the following properties:
class NewsArticle
{
    //Title(string): the title of the news article
    public string Title
    { get; set; }
    //Category (string): the category of the news article
    public string Category
    { get; set; }
    //Create a constructor that takes a title and a category and initializes the corresponding properties.
    public NewsArticle(string Title, string Category)
    {
        this.Title = Title;
        this.Category = Category;
    }
}


//Create a NewsArticleCollection class with the following properties and methods:
class NewsArticleCollection
{
    //articles(List<NewsArticle>): a list of news articles in the collection
    private List<NewsArticle> na = new List<NewsArticle>();

    //articleAddedHandler (delegate): a delegate that is invoked when a new article is added to the collection
    //articleRemovedHandler (delegate): a delegate that is invoked when an article is removed from the collection
    public delegate void ArticleHandler(object sender, NewsArticle article);
    public event ArticleHandler ArticleAdded;
    public event ArticleHandler ArticleRemoved;


    //articleFilteredHandler (delegate): a delegate that is invoked when articles are filtered by category
    public delegate void ArticleFilteredHandler(object sender, string category);
    public event ArticleFilteredHandler ArticleFiltered;


    //AddArticle(NewsArticle article): adds a news article to the collection
    public void AddArticle(NewsArticle article)
    {
        na.Add(article);
        //Console.WriteLine($"Article added: {article.Title}.");
        ArticleAdded?.Invoke(this, article);
    }

    //RemoveArticle(NewsArticle article): removes a news article from the collection
    public void RemoveArticle(NewsArticle article)
    {
        NewsArticle articleToRemove = null;
        foreach (var existingArticle in na)
        {
            //if (na.Contains(article))
            if (existingArticle.Title == article.Title && existingArticle.Category == article.Category)
            {
                articleToRemove = existingArticle;
                break;
            } 
        }

        if (articleToRemove != null)
        {
            na.Remove(articleToRemove);
            ArticleRemoved?.Invoke(this, article);
        }
        else
        {
            Console.WriteLine("Article is not found");
        }
        
    }

    //FilterArticlesByCategory(string category): returns a list of news articles in the collection with the specified category
    public List<NewsArticle> FilterArticlesByCategory(string category)
    {
        List<NewsArticle> filteredArticles = na.FindAll(a => a.Category == category);


        //Implement the articleFilteredHandler delegate using a lambda expression.
        //List<NewsArticle> filteredArticles = new List<NewsArticle>();
        //foreach (NewsArticle article in na)
        //{
        //    if (article.Category == category)
        //        filteredArticles.Add(article);
        //}
        
        ArticleFiltered?.Invoke(this, category);
        return filteredArticles;
    }


    //RegisterArticleAddedHandler(Action<object, NewsArticle> handler): registers an event handler for the article added event
    //When a new article is added to the collection, the articleAddedHandler delegate should be invoked with the NewsArticleCollection object and the new NewsArticle object as parameters.
    public void RegisterArticleAddedHandler(Action<object, NewsArticle> handler)
    {
        ArticleAdded += new ArticleHandler(handler);
    }


    //RegisterArticleRemovedHandler(Action<object, NewsArticle> handler): registers an event handler for the article removed event
    //When an article is removed from the collection, the articleRemovedHandler delegate should be invoked with the NewsArticleCollection object and the removed NewsArticle object as parameters.
    public void RegisterArticleRemovedHandler(Action<object, NewsArticle> handler)
    { 
        ArticleRemoved += new ArticleHandler(handler);
    }


    //RegisterArticleFilteredHandler(string category, Action<object, string> handler): registers an event handler for the article filtered event
    //When articles are filtered by category, the articleFilteredHandler delegate should be invoked with the NewsArticleCollection object and the category as parameters.
    public void RegisterArticleFilteredHandler(string category, Action<object, string> handler)
    { 
        ArticleFiltered += new ArticleFilteredHandler(handler);
    }
}



//Create a console application that demonstrates the use of the NewsArticleCollection class by doing the following:

namespace NewsApp
{
    internal class Program
    {
        static void OnArticlesFilteredByCategory(object sender, string category)
        {
            Console.WriteLine($"Articles filtered by category: '{category}'");
        }

        static void OnArticleAdded(object sender, NewsArticle article)
        {
            Console.WriteLine($"Article added: {article.Category}: {article.Title}");
        }

        static void OnArticleRemoved(object sender, NewsArticle article)
        {
            Console.WriteLine($"\nArticle removed: {article.Category}: {article.Title}");
        }

        static void Main()
        {
            //Create a new NewsArticleCollection object
            NewsArticleCollection newsCollection = new NewsArticleCollection();

            //Register an event handler for filtering the "Sports" category
            newsCollection.RegisterArticleFilteredHandler("Sports", OnArticlesFilteredByCategory);

            //newsCollection.RegisterArticleFilteredHandler("Sports", (sender, category) =>
            //{
            //    Console.WriteLine($"Articles filtered by category '{category}'");
            // });


            //When a new article is added to or removed from the collection, the console application should write a message to the console indicating that the event was fired.

            newsCollection.RegisterArticleAddedHandler(OnArticleAdded);
            newsCollection.RegisterArticleRemovedHandler(OnArticleRemoved);
            //newsCollection.RegisterArticleAddedHandler((sender, article) =>
            //{
            //    Console.WriteLine($"Article added: {article.Title} ({article.Category})");
            //});

            //newsCollection.RegisterArticleRemovedHandler((sender, article) =>
            //{
            //    Console.WriteLine($"Article removed: {article.Title} ({article.Category})");
            //});


            //Add some news articles to the collection
            newsCollection.AddArticle(new NewsArticle("New IPhone 16 specs", "Technoogy"));
            newsCollection.AddArticle(new NewsArticle("S&P index reached 5000 level", "Business"));
            newsCollection.AddArticle(new NewsArticle("Interest rate is still 5.5", "Business"));
            newsCollection.AddArticle(new NewsArticle("ROI for Microsoft papers raised 2% for last month", "Business"));
            newsCollection.AddArticle(new NewsArticle("Olympic Games in Paris opened", "Sports"));
            newsCollection.AddArticle(new NewsArticle("New IPhone 16Pro specs", "Technoogy"));
            newsCollection.AddArticle(new NewsArticle("Olympic Games in Paris new records", "Sports"));
            newsCollection.AddArticle(new NewsArticle("New IPhone 16ProMax specs", "Technoogy"));
            newsCollection.AddArticle(new NewsArticle("Olympic Games in Paris closed", "Sports"));

            Console.WriteLine();
            //Filter the collection by the "Sports" category
            var sportArticles = newsCollection.FilterArticlesByCategory("Sports");

            foreach (var article in sportArticles)
            { Console.WriteLine($"{article.Category}: {article.Title}"); }
            
            //Remove an article from the collection
            newsCollection.RemoveArticle(new NewsArticle("Olympic Games in Paris closed", "Sports"));
            Console.WriteLine();

            //Filter the collection by the "Sports" category again to demonstrate that the removal was successful
            var sportsAfterRemoval = newsCollection.FilterArticlesByCategory("Sports");
            foreach (var article in sportsAfterRemoval)
            { Console.WriteLine($"{article.Category}: {article.Title}"); }

            Console.WriteLine();
            var TechArticles = newsCollection.FilterArticlesByCategory("Technoogy");
            foreach (var article in TechArticles)
            { Console.WriteLine($"{article.Category}: {article.Title}"); }

            Console.WriteLine();
            var BusinessArticles = newsCollection.FilterArticlesByCategory("Business");
            foreach (var article in BusinessArticles)
            { Console.WriteLine($"{article.Category}: {article.Title}"); }

            Console.ReadKey();

        }
    }
}
