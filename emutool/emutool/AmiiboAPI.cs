using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;

namespace emutool
{
    public static class AmiiboAPI
    {
        public class Amiibo
        {
            public string AmiiboName { get; set; }

            public string SeriesName { get; set; }

            public string CharacterName { get; set; }

            public string ImageURL { get; set; }

            public string AmiiboId { get; set; }
        }

        public class AmiiboList
        {
            public List<Amiibo> Amiibos { get; set; }

            public AmiiboList()
            {
                Amiibos = new List<Amiibo>();
            }

            public int GetAmiiboCount()
            {
                return Amiibos.Count;
            }

            public List<Amiibo> GetAmiibosBySeries(string series)
            {
                var list = new List<Amiibo>();
                if(Amiibos.Any())
                {
                    list.AddRange(Amiibos.Where(amiibo => amiibo.SeriesName == series));
                }
                return list;
            }

            public List<string> GetAmiiboSeries()
            {
                var list = new List<string>();
                if(Amiibos.Any())
                {
                    foreach(var amiibo in Amiibos)
                    {
                        var series = amiibo.SeriesName;
                        if(!list.Contains(series))
                        {
                            list.Add(series);
                        }
                    }
                }
                return list;
            }
        };

        private const string AmiiboAPIURL = "https://www.amiiboapi.com/api/amiibo/";
        private const string AmiiboImgSource = "https://raw.githubusercontent.com/N3evin/AmiiboAPI/master/images/";

        public static AmiiboList GetAllAmiibos(string imgSource = "")
        {
            var list = new AmiiboList();
            try
            {
                var json = JObject.Parse(Utils.GetFromURL(AmiiboAPIURL));
                foreach(var entry in json["amiibo"])
                {
                    var oimg = entry["image"].ToString();
                    if(imgSource != "")
                    {
                        oimg = oimg.Replace(AmiiboImgSource, imgSource);
                    }

                    var amiibo = new Amiibo
                    {
                        AmiiboName = entry["name"].ToString().Replace('/', '_'), // Avoid amiibo names conflicting with system paths
                        SeriesName = entry["amiiboSeries"].ToString(),
                        CharacterName = entry["character"].ToString(),
                        ImageURL = oimg,
                        AmiiboId = entry["head"].ToString() + entry["tail"].ToString(),
                    };
                    list.Amiibos.Add(amiibo);
                }
            }
            catch(Exception ex)
            {
                Utils.LogExceptionMessage(ex);
            }
            return list;
        }
    }
}