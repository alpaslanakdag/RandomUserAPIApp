using System;
using System.Collections.Generic;

namespace ApprenticeAspNetMvc.Web.Models
{
    public partial class WikipediaArticle
    {
        public WikipediaArticle()
        {

        }

        public WikipediaArticle(WikiRootObject wikipedia)
        {
            Title = wikipedia.Tfa.Title;
            DisplayTitle = wikipedia.Tfa.Displaytitle;
            PageId = (int)wikipedia.Tfa.Pageid;
            Description = wikipedia.Tfa.Description;
            Url = wikipedia.Tfa.ContentUrls.Desktop.Page.ToString();
            Extract = wikipedia.Tfa.Extract;
            CreateDate = DateTime.Now.Date;

        }
        //public WikipediaArticle()
        //{
        //    Users = new HashSet<User>();
        //}

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? DisplayTitle { get; set; }
        public int? PageId { get; set; }
        public string? Description { get; set; }
        //public double? Latitude { get; set; }
        //public double? Longtitude { get; set; }
        public string? Url { get; set; }
        public string? Extract { get; set; }

        public DateTime? CreateDate { get; set; }
        //public virtual ICollection<User> Users { get; set; }

        public static string DateConverter()

        {
            string date = DateTime.Now.ToString("yyyy/MM/dd");
            Console.WriteLine(date);
            return date.Replace('-','/');
        }
    }
}
