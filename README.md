# README.md for Netflix API Library

## Getting Started with Netflix API

Netflix API is a user-friendly C# library for interacting with the Netflix API. This README will guide you through the steps to set up and use this library.

### Prerequisites

Before you start using the Netflix API library, you need to set up an account and subscribe to the Netflix API on RapidAPI. Follow these simple steps:

1. **Create a Free Account on RapidAPI:** Go to [RapidAPI](https://rapidapi.com/) and register for a free account.
2. **Subscribe to the Netflix API:** Visit the Netflix API page at [Netflix API on RapidAPI](https://rapidapi.com/dataocean/api/netflix99). Click on the "Subscribe to test" button.
3. **Get Your X-RapidAPI-Key:** After subscribing, you will receive your `X-RapidAPI-Key`. This key is available on the right side under the "Code snippets" section.

### Using Netflix API

To use the library, you need to create a client object with your `X-RapidAPI-Key`.

```csharp
NetflixApiClient netflixApiClient = new NetflixApiClient("Your-X-RapidAPI-Key");
```

### Making Requests

Now, you can start making requests to the Netflix API.

#### Example: Search and Display Titles

For example, to search for titles containing the phrase "mirror" and display their genres, use the following code:

```csharp
foreach (var title in response.Data.Titles.Take(10))
{
    Console.WriteLine($"{title.Title} ({title.Type})");
    var details = await netflixApiClient.TitleDetails(title.Id);
    var data = details.Data;
    Console.WriteLine($"\tgenres: {string.Join(", ", data.Genres)}");
}
```

This code snippet will display the top 10 titles related to your search and list their genres.

### Conclusion

That's all you need to get started with the Netflix API library! Enjoy exploring the vast world of Netflix titles in your C# applications.