using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace T2207A
{
    internal class News : INews
    {


        private int ID;
        private string Title;
        private string PublishDate;
        private string Author;
        private string Content;
        private float AverageRate;

        public int GetID()
        {
            return ID;
        }

        public void SetID(int id)
        {
            ID = id;
        }

        public string GetTitle()
        {
            return Title;
        }

        public void SetTitle(string title)
        {
            Title = title;
        }

        public string GetPublishDate()
        {
            return PublishDate;
        }

        public void SetPublishDate(string publishDate)
        {
            PublishDate = publishDate;
        }

        public string GetAuthor()
        {
            return Author;
        }

        public void SetAuthor(string author)
        {
            Author = author;
        }

        public string GetContent()
        {
            return Content;
        }

        public void SetContent(string content)
        {
            Content = content;
        }

        public float GetAverageRate()
        {
            return AverageRate;
        }

        public void SetAverageRate(float averageRate)
        {
            AverageRate = averageRate;
        }

        public void Display()
        {
            Console.WriteLine("Title: " + Title);
            Console.WriteLine("Publish Date: " + PublishDate);
            Console.WriteLine("Author: " + Author);
            Console.WriteLine("Content: " + Content);
            Console.WriteLine("Average Rate: " + AverageRate);
        }

        int[] RateList = new int[3];

        public void Calculate()
        {
            int sum = 0;
            for (int i = 0; i < 3; i++)
            {
                sum += RateList[i];
            }
            AverageRate = sum / 3.0f;
        }
    }
}
