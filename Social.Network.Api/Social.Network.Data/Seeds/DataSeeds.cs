using Social.Network.Domain.Models;
using Social.Network.Domain.Seeds;
using System;
using System.Collections.Generic;


/**
* @author HariLab
* @date - 8/11/2021 1:04:26 AM 
*/

namespace Social.Network.Data.Seeds
{
    /// <summary>
    /// Data Seed for Only Test Purpose
    /// </summary>
    public class DataSeeds : IDataSeeds
    {
        public DataSeeds()
        {

        }

        public List<Users> UserList()
        {
            return new List<Users>()
            {
                new Users(){ ID = 1, FirstName = "John", LastName = "Due", IsActive = true, Username = "jhondue", Password = "password"},
                new Users(){ ID = 2, FirstName = "Waseem", LastName = "Arshad", IsActive = true, Username = "arshad", Password = "password"},
                new Users(){ ID = 3, FirstName = "John", LastName = "Stainers", IsActive = true, Username = "jhonstainer", Password = "password"},
                new Users(){ ID = 4, FirstName = "Michael", LastName = "Phillps", IsActive = true, Username = "mcphillps", Password = "password"},
                new Users(){ ID = 5, FirstName = "Achmed", LastName = "Yaseen", IsActive = true, Username = "yaseen", Password = "password"},
                new Users(){ ID = 6, FirstName = "Tommy", LastName = "Utomo", IsActive = true, Username = "test", Password = "test"},
            };
        }

        public List<People> PeopleList()
        {
            return new List<People>()
            {
                new People(){ ID = 1, Title = "User Interface Designer", UserId = 1, Users = new Users(){ ID = 1, FirstName = "John", LastName = "Due", IsActive = true, ImageUrl = "https://i.ytimg.com/vi/NA2YZJw09fs/maxresdefault.jpg"  }},
                new People(){ ID = 2, Title = ".NET Developer", UserId = 2, Users = new Users(){ ID = 2, FirstName = "Waseem", LastName = "Arshad", IsActive = true, ImageUrl = "https://img-c.udemycdn.com/course/240x135/2259120_305f_6.jpg"  }},
                new People(){ ID = 3, Title = "Anguar Developer", UserId = 3, Users = new Users(){ ID = 3, FirstName = "John", LastName = "Stainers", IsActive = true, ImageUrl = "https://img-c.udemycdn.com/course/240x135/1352468_3d97_7.jpg"  }},
                new People(){ ID = 4, Title = "React Developer", UserId = 4, Users = new Users(){ ID = 4, FirstName = "Michael", LastName = "Phillps", IsActive = true, ImageUrl = "https://img-c.udemycdn.com/course/240x135/1565838_e54e_12.jpg"  }},
                new People(){ ID = 5, Title = "Swift Developer", UserId = 5, Users = new Users(){ ID = 5, FirstName = "Achmed", LastName = "Yaseen", IsActive = true, ImageUrl = "https://img-c.udemycdn.com/course/240x135/2121018_9de5_5.jpg"  }},
                new People(){ ID = 6, Title = "Java Developer", UserId = 6, Users = new Users(){ ID = 8, FirstName = "Tommy", LastName = "Utomo", IsActive = true, ImageUrl = "https://img-c.udemycdn.com/course/240x135/2121018_9de5_5.jpg"  }},
            };
        }

        public List<Videos> VideoList()
        {
            return new List<Videos>()
            {
                new Videos(){ ID = 1, Title = "How to improve your skills", Duration = DateTime.Now.TimeOfDay, Description = "this is description", UserId = 1, Thumbnail = "https://static.wixstatic.com/media/72c0b2_e0eec32fd2ea478e82e1459c3224a623~mv2.jpg/v1/fill/w_1000,h_571,al_c,q_90,usm_0.66_1.00_0.01/72c0b2_e0eec32fd2ea478e82e1459c3224a623~mv2.jpg"},
                new Videos(){ ID = 2, Title = "Build SPA Modern Web App using Angular 12", Duration = DateTime.Now.TimeOfDay, Description = "this is description", UserId = 2, Thumbnail = "https://www.cyberclick.net/hubfs/blog/How%20to%20Improve%20Your%20YouTube%20Content%20%2810%20Tips%29.png"},
                new Videos(){ ID = 3, Title = "Build Web MVC using .NET Core", Duration = DateTime.Now.TimeOfDay, Description = "this is description", UserId = 3, Thumbnail = "https://wc-marketplace.com/wp-content/uploads/2017/04/What-is-the-best-revenue-model-for-your-online-Marketplace-Part-one.jpg"},
                new Videos(){ ID = 4, Title = "What is a SOLID Principles", Duration = DateTime.Now.TimeOfDay, Description = "this is description", UserId = 4, Thumbnail = "http://www.rpmgdigitech.com/wp-content/uploads/2018/11/Youtube-Marketing.png"},
                new Videos(){ ID = 5, Title = "Mastering C# for Dummy", Duration = DateTime.Now.TimeOfDay, Description = "this is description", UserId = 5, Thumbnail = "http://www.rpmgdigitech.com/wp-content/uploads/2018/11/Youtube-Marketing.png"},
                new Videos(){ ID = 6, Title = "What is a SOLID Principles", Duration = DateTime.Now.TimeOfDay, Description = "this is description", UserId = 4, Thumbnail = "https://wc-marketplace.com/wp-content/uploads/2017/04/What-is-the-best-revenue-model-for-your-online-Marketplace-Part-one.jpg"},

            };
        }

        public List<Channels> ChannelList()
        {
            return new List<Channels>()
            {
                new Channels(){ ID = 1, Name = "Google", Description = "channel description here" },
                new Channels(){ ID = 2, Name = "Dribble", Description = "channel description here" },
                new Channels(){ ID = 3, Name = "Mikocok", Description = "channel description here" },
                new Channels(){ ID = 4, Name = "Behance", Description = "channel description here" },
                new Channels(){ ID = 5, Name = "Gurus", Description = "channel description here" },
                new Channels(){ ID = 6, Name = "iMedia", Description = "channel description here" },
                new Channels(){ ID = 7, Name = "Creativeeye", Description = "channel description here" },
                new Channels(){ ID = 8, Name = "Khan Studios", Description = "channel description here" },
                new Channels(){ ID = 9, Name = "Weather Channel", Description = "channel description here" },
                new Channels(){ ID = 10, Name = "Yahoo", Description = "channel description here" },

            };
        }

        public List<Documents> DocumentList()
        {
            return new List<Documents>()
            {
                new Documents(){ ID = 1, UserId = 1, Title = "Mobile UI n UX Guide 2013", Description = "description", Thumbnail = "https://microlancer.lancerassets.com/v2/services/45/8dd250700111e792c8c794b7f45630/large_cover1.jpg" },
                new Documents(){ ID = 2, UserId = 2, Title = "Build SPA Modern Web App using Angular 12", Description = "description", Thumbnail = "https://fiverr-res.cloudinary.com/images/q_auto,f_auto/gigs/133261745/original/71e713f4de88475d2601506e6fbdd63c1e82b302/design-professional-book-cover-or-ebook-cover.jpg" },
                new Documents(){ ID = 3, UserId = 3, Title = "What is a SOLID Principles", Description = "description", Thumbnail = "https://dcassetcdn.com/design_img/3635453/439610/439610_20226820_3635453_9e48faf9_image.jpg" },
                new Documents(){ ID = 4, UserId = 4, Title = "Build Web MVC using .NET Core", Description = "description", Thumbnail = "https://mir-s3-cdn-cf.behance.net/project_modules/1400/f1284291229191.5e2c46564f4ff.jpg" },
                new Documents(){ ID = 5, UserId = 5, Title = "Get Started Deployment Your App with Docker", Description = "description", Thumbnail = "https://digihub.shop/wp-content/uploads/2017/07/Book1.jpg" },
                new Documents(){ ID = 6, UserId = 5, Title = "Get Started Deployment Your App with Docker", Description = "description", Thumbnail = "https://microlancer.lancerassets.com/v2/services/45/8dd250700111e792c8c794b7f45630/large_cover1.jpg" },

            };
        }

        public List<Activities> ActivityList()
        {
            return new List<Activities>()
            {
               new Activities(){ ID = 1, Activity = "posted a video how to bla..", Date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), UserId = 1, Users = new Users(){ ID = 1, FirstName = "John", LastName = "Due", IsActive = true, ImageUrl = "https://img-c.udemycdn.com/course/240x135/3142166_a637.jpg"  }, Description = "description" },
               new Activities(){ ID = 2, Activity = "posted a comment after 10 year", Date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), UserId = 2, Users = new Users(){ ID = 2, FirstName = "Waseem", LastName = "Arshad", IsActive = true, ImageUrl = "https://img-c.udemycdn.com/course/240x135/2259120_305f_6.jpg"  }, Description = "description" },
               new Activities(){ ID = 3, Activity = "Posted a video after 10 year", Date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), UserId = 3,  Users = new Users(){ ID = 3, FirstName = "John", LastName = "Stainers", IsActive = true, ImageUrl = "https://img-c.udemycdn.com/course/240x135/1352468_3d97_7.jpg"  }, Description = "description" },
               new Activities(){ ID = 4, Activity = "posted a document after 20 year", Date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), UserId = 4, Users = new Users(){ ID = 4, FirstName = "Michael", LastName = "Phillps", IsActive = true, ImageUrl = "https://img-c.udemycdn.com/course/240x135/1565838_e54e_12.jpg"  }, Description = "description" },
               new Activities(){ ID = 5, Activity = "posted a video after 10 year", Date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), UserId = 5, Users = new Users(){ ID = 5, FirstName = "Achmed", LastName = "Yaseen", IsActive = true, ImageUrl = "https://img-c.udemycdn.com/course/240x135/2121018_9de5_5.jpg"  }, Description = "description" },
               new Activities(){ ID = 6, Activity = "posted a video again amazing", Date = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss"), UserId = 6, Users = new Users(){ ID = 1, FirstName = "Tommy", LastName = "Utomo", IsActive = true, ImageUrl = "https://img-c.udemycdn.com/course/240x135/2301254_26c8_4.jpg" }, Description = "description" }
            };
        }
    }
}
