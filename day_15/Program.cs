static async Task<string> GetHttpContentAsync(string url)
{
    using HttpClient client = new HttpClient();
    return await client.GetStringAsync(url);
}

string content = await
GetHttpContentAsync("https://jsonplaceholder.typicode.com/posts");
Console.WriteLine(content);