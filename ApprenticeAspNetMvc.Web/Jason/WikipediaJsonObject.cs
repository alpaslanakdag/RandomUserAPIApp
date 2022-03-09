
    using System;
    using System.Collections.Generic;

    using System.Globalization;
    using System.Text.Json.Serialization;
   

    public partial class WikiRootObject
    {
        [JsonPropertyName("tfa")]
        public Tfa Tfa { get; set; }

        [JsonPropertyName("mostread")]
        public Mostread Mostread { get; set; }

        [JsonPropertyName("image")]
        public TemperaturesImage Image { get; set; }

        [JsonPropertyName("onthisday")]
        public Onthisday[] Onthisday { get; set; }
    }

    public partial class TemperaturesImage
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("thumbnail")]
        public ThumbnailClass Thumbnail { get; set; }

        [JsonPropertyName("image")]
        public ThumbnailClass Image { get; set; }

        [JsonPropertyName("file_page")]
        public Uri FilePage { get; set; }

        [JsonPropertyName("artist")]
        public Artist Artist { get; set; }

        [JsonPropertyName("credit")]
        public Artist Credit { get; set; }

        [JsonPropertyName("license")]
        public License License { get; set; }

        [JsonPropertyName("description")]
        public Description Description { get; set; }

        [JsonPropertyName("wb_entity_id")]
        public string WbEntityId { get; set; }

        [JsonPropertyName("structured")]
        public Structured Structured { get; set; }
    }

    public partial class Artist
    {
        [JsonPropertyName("html")]
        public string Html { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public partial class Description
    {
        [JsonPropertyName("html")]
        public string Html { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }

        //[JsonPropertyName("lang")]
        //public Lang Lang { get; set; }
    }

    public partial class ThumbnailClass
    {
        [JsonPropertyName("source")]
        public Uri Source { get; set; }

        [JsonPropertyName("width")]
        public long Width { get; set; }

        [JsonPropertyName("height")]
        public long Height { get; set; }
    }

    public partial class License
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("url")]
        public Uri Url { get; set; }
    }

    public partial class Structured
    {
        [JsonPropertyName("captions")]
        public Captions Captions { get; set; }
    }

    public partial class Captions
    {
        [JsonPropertyName("bg")]
        public string Bg { get; set; }
    }

    public partial class Mostread
    {
        //[JsonPropertyName("date")]
        //public Date Date { get; set; }

        [JsonPropertyName("articles")]
        public Tfa[] Articles { get; set; }
    }

    public partial class Tfa
    {
        [JsonPropertyName("views")]
        public long? Views { get; set; }

        [JsonPropertyName("rank")]
        public long? Rank { get; set; }

        [JsonPropertyName("view_history")]
        public ViewHistory[] ViewHistory { get; set; }

        //[JsonPropertyName("type")]
        //public TypeEnum Type { get; set; }

        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("displaytitle")]
        public string Displaytitle { get; set; }

        [JsonPropertyName("namespace")]
        public Namespace Namespace { get; set; }

        [JsonPropertyName("wikibase_item")]
        public string WikibaseItem { get; set; }

        [JsonPropertyName("titles")]
        public Titles Titles { get; set; }

        [JsonPropertyName("pageid")]
        public long Pageid { get; set; }

        //[JsonPropertyName("lang")]
        //public Lang Lang { get; set; }

        //[JsonPropertyName("dir")]
        //public Dir Dir { get; set; }

        //[JsonPropertyName("revision")]
       
        //public long Revision { get; set; }

        [JsonPropertyName("tid")]
        public Guid Tid { get; set; }

        [JsonPropertyName("timestamp")]
        public DateTimeOffset Timestamp { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        //[JsonPropertyName("description_source")]
        //public DescriptionSource? DescriptionSource { get; set; }

        [JsonPropertyName("content_urls")]
        public ContentUrls ContentUrls { get; set; }

        [JsonPropertyName("extract")]
        public string Extract { get; set; }

        [JsonPropertyName("extract_html")]
        public string ExtractHtml { get; set; }

        [JsonPropertyName("normalizedtitle")]
        public string Normalizedtitle { get; set; }

        [JsonPropertyName("thumbnail")]
        public ThumbnailClass Thumbnail { get; set; }

        [JsonPropertyName("originalimage")]
        public ThumbnailClass Originalimage { get; set; }

        [JsonPropertyName("coordinates")]
        public Coordinates Coordinates { get; set; }
    }

    public partial class ContentUrls
    {
        [JsonPropertyName("desktop")]
        public Desktop Desktop { get; set; }

        [JsonPropertyName("mobile")]
        public Desktop Mobile { get; set; }
    }

    public partial class Desktop
    {
        [JsonPropertyName("page")]
        public Uri Page { get; set; }

        [JsonPropertyName("revisions")]
        public Uri Revisions { get; set; }

        [JsonPropertyName("edit")]
        public Uri Edit { get; set; }

        [JsonPropertyName("talk")]
        public Uri Talk { get; set; }
    }

    public partial class Coordinates
    {
        [JsonPropertyName("lat")]
        public double Lat { get; set; }

        [JsonPropertyName("lon")]
        public double Lon { get; set; }
    }

    public partial class Namespace
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }

    public partial class Titles
    {
        [JsonPropertyName("canonical")]
        public string Canonical { get; set; }

        [JsonPropertyName("normalized")]
        public string Normalized { get; set; }

        [JsonPropertyName("display")]
        public string Display { get; set; }
    }

    public partial class ViewHistory
    {
        //[JsonPropertyName("date")]
        //public Date Date { get; set; }

        [JsonPropertyName("views")]
        public long Views { get; set; }
    }

    public partial class Onthisday
    {
        [JsonPropertyName("text")]
        public string Text { get; set; }

        [JsonPropertyName("pages")]
        public Tfa[] Pages { get; set; }

        [JsonPropertyName("year")]
        public long Year { get; set; }
    }

    //public enum Lang { En };

   // public enum DescriptionSource { Local };

   // public enum Dir { Ltr };

    //public enum TypeEnum { Standard };

 //   public enum Date { The20220219Z, The20220220Z, The20220221Z, The20220222Z, The20220223Z };

    
    
    

