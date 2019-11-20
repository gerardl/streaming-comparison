using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StreamingTvComparison.Data
{
    public static class DbInitializer
    {
        public static void Seed(ApplicationDbContext context)
        {
            #region Channels
            if (!context.Channel.Any())
            {
                string[] channelList = {"AFRO",
                                        "AXS TV",
                                        "A&E",
                                        "AMC",
                                        "American Heroes Channel",
                                        "Animal Planet",
                                        "Aspire",
                                        "Audience",
                                        "Baby TV",
                                        "BBC America",
                                        "BBC World News",
                                        "BeIN Sports",
                                        "BeIN Sports en Espanol",
                                        "BET",
                                        "BET Her",
                                        "Big Ten Network",
                                        "Blaze TV",
                                        "Bloomberg Television",
                                        "Boomerang",
                                        "Bravo",
                                        "Campus Insider",
                                        "Cartoon Network/Adult Swim",
                                        "CBS Sports Net",
                                        "CBSN",
                                        "Cheddar",
                                        "Cheddar Big News",
                                        "Cinemax",
                                        "CMT",
                                        "CNBC",
                                        "CNBC World",
                                        "CNN",
                                        "CNN International",
                                        "Comedy Central",
                                        "Comedy TV",
                                        "Comet",
                                        "Cooking Channel",
                                        "Cowboy Channel",
                                        "Cozi TV",
                                        "Crime & Investigation",
                                        "Destination America",
                                        "Discovery",
                                        "Discovery Family",
                                        "Discovery Life",
                                        "Disney Channel",
                                        "Disney Junior",
                                        "Disney XD",
                                        "DIY Network",
                                        "Duck TV",
                                        "E!",
                                        "El Rey",
                                        "Eleven Sports",
                                        "EPIX",
                                        "EPIX Drive-In",
                                        "EPIX Hits",
                                        "EPIX2",
                                        "ESPN",
                                        "ESPN 2",
                                        "ESPN Bases Loaded",
                                        "ESPN Deportes",
                                        "ESPN Goal Line",
                                        "ESPN News",
                                        "ESPN U",
                                        "Euronews",
                                        "Family Channel",
                                        "Fla Ma",
                                        "FM",
                                        "Food Network",
                                        "Fox Business",
                                        "Fox College Sports",
                                        "Fox Deportes",
                                        "Fox News Channel",
                                        "Fox Regional Sports Networks",
                                        "Fox Soccer Plus",
                                        "France 24",
                                        "Free Speech",
                                        "FreeForm",
                                        "FS1",
                                        "FS2",
                                        "FuboTV Network",
                                        "Fuse",
                                        "Fusion",
                                        "FX",
                                        "FXM",
                                        "FXX",
                                        "FYI",
                                        "Galavision",
                                        "Golf Channel",
                                        "Great America",
                                        "GSN",
                                        "Hallmark, Drama, & Movies",
                                        "HBO",
                                        "HDNet Movies",
                                        "HGTV",
                                        "History",
                                        "Hi-Yah!",
                                        "HLN",
                                        "IFC",
                                        "Investigation Discovery",
                                        "Lifetime",
                                        "Lifetime Movies",
                                        "Local Now",
                                        "Logo",
                                        "Machinima",
                                        "MTV Classic",
                                        "MLB Network",
                                        "MSG/MSG+",
                                        "MSNBC",
                                        "MTV",
                                        "MTV 2",
                                        "MTV Live",
                                        "Nat Geo",
                                        "Nat Geo Wild",
                                        "NBA TV",
                                        "NBC Sports Network",
                                        "NBC Sportsnet",
                                        "NDTV",
                                        "NESN",
                                        "News18",
                                        "Newsmax",
                                        "Newsy",
                                        "NFL Network",
                                        "NHL Network",
                                        "Nick Jr.",
                                        "Nickelodeon",
                                        "Nicktoons",
                                        "OAN / AWE",
                                        "Olympic Channel",
                                        "Outside TV",
                                        "Ovation",
                                        "OWN",
                                        "Oxygen",
                                        "Pac-12",
                                        "Paramount",
                                        "Poker",
                                        "Pop",
                                        "Pursuit Channel",
                                        "Revolt",
                                        "RFDTV",
                                        "Ride TV",
                                        "RT Network",
                                        "Science Channel",
                                        "SEC Network",
                                        "Showtime",
                                        "Start TV",
                                        "Smithsonian",
                                        "SNY",
                                        "Sony Movie Channel",
                                        "Sportsman",
                                        "Sprout",
                                        "Stadium",
                                        "Sundance TV",
                                        "SyFy",
                                        "TBS",
                                        "TeenNick",
                                        "Tennis Channel",
                                        "TLC",
                                        "TNT",
                                        "Travel Channel",
                                        "Tru TV",
                                        "Turner Classic Movies",
                                        "TV Land",
                                        "Unimas",
                                        "Univision",
                                        "Univision Deportes",
                                        "UP Family",
                                        "USA",
                                        "Motortrend",
                                        "VH1",
                                        "Vibrant",
                                        "Viceland",
                                        "WE tv",
                                        "Weather Channel",
                                        "WeatherNation",
                                        "YES" };

                foreach (var channel in channelList)
                {
                    context.Channel.Add(new Models.Channel { Name = channel, IsActive = true });
                }
                context.SaveChanges();
            }
            #endregion

            #region Provider
            if (!context.Provider.Any())
            {
                context.Provider.Add(new Models.Provider
                {
                    Name = "YouTube TV",
                    Price = 49.99m,
                    IsActive = true,
                    Url = "https://tv.youtube.com/"
                });
                context.Provider.Add(new Models.Provider
                {
                    Name = "Hulu Live TV",
                    Price = 44.99m,
                    IsActive = true,
                    Url = "https://www.hulu.com/live-tv/"
                });
                context.Provider.Add(new Models.Provider
                {
                    Name = "FuboTV",
                    Price = 44.99m,
                    IsActive = true,
                    Url = "https://www.fubo.tv/welcome"
                });
                context.SaveChanges();
            }
            #endregion
        }
    }
}
