using System;
using System.Threading.Tasks;
using Tweetinvi;

namespace OriginalTweetFinder
{
    class Program
    {
        //using dummy keys and tokens
        private static string CONSUMER_KEY = "CjIO1ihChRmgFaS7FuOHioMbq";
        private static string CONSUMER_SECRET = "9nrYdCY0jkCUYnPklrjmkdtGvCFb1Y8pP4Dc8JkluOB8RWPRKu";
        private static string ACCESS_TOKEN = "1298079202822914049-8PG8hclia0gqtWJvAWkllc0zJLNui3";
        private static string ACCESS_TOKEN_SECRET = "oepEPSCF0hokd5RrFRs1SKT3JidkpknZtWlwpj8nbDCOl";
        //private static TwitterClient userClient = new TwitterClient(CONSUMER_KEY, CONSUMER_SECRET, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);
        static async Task Main(string[] args)
        {
            TwitterClient userClient = new TwitterClient(CONSUMER_KEY, CONSUMER_SECRET, ACCESS_TOKEN, ACCESS_TOKEN_SECRET);
            
            var tweet = await userClient.Tweets.PublishTweetAsync("Wating something out here!");
            await userClient.Tweets.PublishRetweetAsync(tweet.Id);

            //var user = await userClient.Users.GetAuthenticatedUserAsync();
            Console.WriteLine(tweet.Id);
            
        }
    }
}
