using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Twitcher
{
    class twitterJsonTest
    {


        public class Hashtag
        {
            [DataMember]
            public string text { get; set; }
        }

        public class Entities
        {
            [DataMember]
            public List<object> urls { get; set; }

            [DataMember]
            public List<Hashtag> hashtags { get; set; }
        }

        public class User
        {
            [DataMember]
            public string name { get; set; }

            [DataMember]
            public string profile_image_url { get; set; }

            [DataMember]
            public string created_at { get; set; }

            [DataMember]
            public string profile_image_url_https { get; set; }

            [DataMember]
            public int utc_offset { get; set; }

            [DataMember]
            public string description { get; set; }

            [DataMember]
            public bool default_profile_image { get; set; }

            [DataMember]
            public string screen_name { get; set; }
        }

        public class Status
        {
            [DataMember]
            public object coordinates { get; set; }

            [DataMember]
            public string created_at { get; set; }

            public Entities entities { get; set; }

            [DataMember]
            public string text { get; set; }

            [DataMember]
            public long id { get; set; }

            [DataMember]
            public object geo { get; set; }

            public User user { get; set; }

            [DataMember]
            public string source { get; set; }
        }

        [DataContract]
        public class RootObject
        {
            public ObservableCollection<Status> statuses { get; set; }
        }
    }
}