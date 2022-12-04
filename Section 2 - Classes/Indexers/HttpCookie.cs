using System;
using System.Collections.Generic;

namespace Indexers
{
    public class HttpCookie
    {
        // Dictionary is best to use when you have a list of objects and you want to look them up by a key.
        // List is best when you have a list of objects and you want to look them up by an index.
        private readonly Dictionary<string, string> _dictionary;
        public DateTime Expiry { get; set; }

        public HttpCookie() 
        {
            _dictionary= new Dictionary<string, string>();
        }

        public string this[string key] 
        {
            get { return _dictionary[key]; }
            set { _dictionary[key] = value;}
        }
    }
}
