public class NumbersFact
{
    public static async Task Main()
    {
        Console.WriteLine(">> This program gives you a random fact about any day of the year. ");

        Console.Write("Enter the number of month (1-12): ");
        int month = int.Parse(Console.ReadLine());

        Console.Write("Enter the number of day: ");
        int day = int.Parse(Console.ReadLine());

        // Write code below this line
        string url = $"http://numbersapi.com/11/6/date"
        HttpClient client = new HttpClient();
        HttpResponseMessage response = await client.GetAsync(url);
        string responseContent = await response.Content.ReadAsStringAsync();
        Console.WriteLine("Fact: " + responseContent);
            
        // Write code above this line
    }
}
