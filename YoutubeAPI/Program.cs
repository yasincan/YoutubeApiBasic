
using Google.Apis.Services;
using Google.Apis.YouTube.v3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YoutubeAPI
{
    class Program
    {
        static void Main(string[] args)
        {
            YouTubeService youtube = new YouTubeService(new BaseClientService.Initializer() { ApiKey = "" });

            //SEARCH QUERY

            var searchListRequest = youtube.Search.List("snippet");
            searchListRequest.Q = "yasin";
            var searchListResult = searchListRequest.Execute();
            foreach (var item in searchListResult.Items)
            {
                Console.WriteLine("ID:" + item.Id.VideoId);
                Console.WriteLine("snippet:" + item.Snippet.Title);
            }

            //SEARCH CHANEL

            //var searchListRequest = youtube.Search.List("snippet");
            //searchListRequest.ChannelId = "CHANEL_ID";
            //var searchListResult = searchListRequest.Execute();
            //foreach (var item in searchListResult.Items)
            //{
            //    Console.WriteLine("ID:" + item.Id.VideoId);
            //    Console.WriteLine("snippet:" + item.Snippet.Title);
            //}

            Console.ReadKey();
        }
    }
}
