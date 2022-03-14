using ApprenticeAspNetMvc.Web.Jason;
using System;
using System.Collections.Generic;

namespace ApprenticeAspNetMvc.Web.Models
{
    public partial class User
    {
        public User()
        {

        }

        public User(Result result)
        {
            Title = result.Name.Title;
            FirstName = result.Name.First;
            LastName = result.Name.Last;
            StreetName = result.Location.Street.Name;
            StreetNumber = result.Location.Street.Number;
            City = result.Location.City;
            Country = result.Location.Country;
            PostCode = result.Location.Postcode;
            Latitude = result.Location.Coordinates.Latitude;
            Longtitude = result.Location.Coordinates.Longitude;
            Email = result.Email;
            UserName = result.Login.Username;
            UuId = result.Login.Uuid;
            DateOfBirth = result.Dob.Date.Date;
            PictureThumbnail = result.Picture.Thumbnail.ToString();
            Picture = result.Picture.Large.ToString();
            CreateDate = DateTime.Now;

        }

        public int Id { get; set; }
        public string? Title { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public string? StreetName { get; set; }
        public int? StreetNumber { get; set; }
        public string? City { get; set; }
        public string? Country { get; set; }
        public string? PostCode { get; set; }
        public double? Latitude { get; set; }
        public double? Longtitude { get; set; }
        public string? Email { get; set; }
        public Guid? UuId { get; set; }
        public string? UserName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string PictureThumbnail { get; set; } = null!;
        public string? Picture { get; set; }

        public DateTime? CreateDate { get; set; }

        //public int? WikipediaArticleId { get; set; }

        //public virtual WikipediaArticle? WikipediaArticle { get; set; }
    }
}
