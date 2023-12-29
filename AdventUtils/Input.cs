using System;
using System.Net;
using System.Net.Http;

namespace AdventUtils
{
    public static class Input
    {
        public static async Task<string> GetInputAsync(int day)
        {
            var cookie = Environment.GetEnvironmentVariable("ADVENT_COOKIE");
            var baseAddress = new Uri("https://adventofcode.com");
            var cookieContainer = new CookieContainer();
            using var handler = new HttpClientHandler();
            handler.CookieContainer = cookieContainer;
            using var client = new HttpClient(handler);
            client.BaseAddress = baseAddress;
            cookieContainer.Add(baseAddress, new Cookie("session", cookie));
            var input = await client.GetStringAsync($"{baseAddress}2023/day/{day}/input");
            return input;
        }
    }
}
