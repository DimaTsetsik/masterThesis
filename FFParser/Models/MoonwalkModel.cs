using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace FFParser.Models
{
    public class Duration
    {
        public int seconds { get; set; }
        public string human { get; set; }
    }

    public class Block
    {
        public object blocked_at { get; set; }
        public bool block_ru { get; set; }
        public bool block_ua { get; set; }
    }

    public class MaterialData
    {
        public string updated_at { get; set; }
        public int year { get; set; }
        public string tagline { get; set; }
        public string description { get; set; }
        public int? age { get; set; }
        public List<string> countries { get; set; }
        public List<string> genres { get; set; }
        public List<string> actors { get; set; }
        public List<string> directors { get; set; }
        public List<string> studios { get; set; }
        public double kinopoisk_rating { get; set; }
        public int? kinopoisk_votes { get; set; }
        public double imdb_rating { get; set; }
        public int imdb_votes { get; set; }
        public double? mpaa_rating { get; set; }
        public int? mpaa_votes { get; set; }
    }

    public class SeasonEpisodesCount
    {
        public int season_number { get; set; }
        public int episodes_count { get; set; }
        public List<int> episodes { get; set; }
    }

    public class MoonwalkModel
    {
        public string posret { get; set; }
        public string title_ru { get; set; }
        public string title_en { get; set; }
        public int year { get; set; }
        public Duration duration { get; set; }
        public int kinopoisk_id { get; set; }
        public object world_art_id { get; set; }
        public object pornolab_id { get; set; }
        public string token { get; set; }
        public string type { get; set; }
        public bool camrip { get; set; }
        public string source_type { get; set; }
        public bool instream_ads { get; set; }
        public bool directors_version { get; set; }
        public string iframe_url { get; set; }
        public object trailer_token { get; set; }
        public object trailer_iframe_url { get; set; }
        public string translator { get; set; }
        public int? translator_id { get; set; }
        public string added_at { get; set; }
        public string category { get; set; }
        public Block block { get; set; }
        public MaterialData material_data { get; set; }
        public int? seasons_count { get; set; }
        public int? episodes_count { get; set; }
        public List<SeasonEpisodesCount> season_episodes_count { get; set; }
        public string last_episode_time { get; set; }
    }
}
