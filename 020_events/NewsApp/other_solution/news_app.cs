using System;
using System.Collections.Generic;

// A class that represents a news article
class NewsArticle
{
 // The title of the news article
 public string Title { get; set; }

 // The category of the news article
 public string Category { get; set; }

 // Constructor for creating a new news article with the specified title and category
 public NewsArticle(string title, string category)
 {
  Title = title;
  Category = category;
 }
}

class NewsArticleCollection
{
 private List<NewsArticle> articles = new List<NewsArticle>();

 // Define the events
 public event Action<NewsArticle> articleAddedHandler;
 public event Action<NewsArticle> articleRemovedHandler;
 public event Action<string> articleFilteredHandler;

 // Register an event handler for the articleFilteredHandler event
 public void RegisterArticleFilteredHandler(Action<string> handler)
 {
  articleFilteredHandler += handler;
 }

 // Unregister an event handler for the articleFilteredHandler event
 public void UnregisterArticleFilteredHandler(Action<string> handler)
 {
  articleFilteredHandler -= handler;
 }

 // Add a new article to the collection
 public void AddArticle(NewsArticle article)
 {
  articles.Add(article);

  // Raise the article added event
  articleAddedHandler?.Invoke(article);

  // Raise the article filtered event
  articleFilteredHandler?.Invoke(article.Category);
 }

 // Remove an article from the collection
 public void RemoveArticle(NewsArticle article)
 {
  if (articles.Contains(article))
  {
   articles.Remove(article);

   // Raise the article removed event
   articleRemovedHandler?.Invoke(article);

   // Raise the article filtered event
   articleFilteredHandler?.Invoke(article.Category);
  }
 }

 // Filter the articles by category
 public List<NewsArticle> FilterArticlesByCategory(string category)
 {
  List<NewsArticle> filteredArticles = new List<NewsArticle>();

  foreach (NewsArticle article in articles)
  {
   if (article.Category == category)
   {
    filteredArticles.Add(article);
   }
  }

  // Raise the article filtered event
  articleFilteredHandler?.Invoke(category);

  // Return the filtered articles
  return filteredArticles;
 }
}

class Program
{
 static void Main(string[] args)
 {
  // Create a new NewsArticleCollection instance
  NewsArticleCollection newsArticles = new NewsArticleCollection();

  // Register an event handler for the articleFilteredHandler event
  newsArticles.RegisterArticleFilteredHandler(category =>
  {
   Console.WriteLine($"Articles filtered by category '{category}'");
  });

  // Register an event handler for the articleAddedHandler event
  newsArticles.articleAddedHandler += article =>
  {
   Console.WriteLine($"Article added: {article.Title} ({article.Category})");
  };

  // Register an event handler for the articleRemovedHandler event
  newsArticles.articleRemovedHandler += article =>
  {
   Console.WriteLine($"Article removed: {article.Title} ({article.Category})");
  };

  // Add some news articles
  NewsArticle article1 = new NewsArticle("New iPhone release", "Technology");
  NewsArticle article2 = new NewsArticle("Record profits for Apple", "Business");
  NewsArticle article3 = new NewsArticle("New study shows benefits of exercise", "Health");
  newsArticles.AddArticle(article1);
  newsArticles.AddArticle(article2);
  newsArticles.AddArticle(article3);

  // Filter the articles by category
  List<NewsArticle> filteredArticles = newsArticles.FilterArticlesByCategory("Technology");

  // Remove an article
  newsArticles.RemoveArticle(article2);

  Console.ReadKey();
 }
}