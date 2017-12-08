using System.Collections;
using System.Collections.Generic;

namespace BlueFace.VoIP.Net.SIP
{
    public class StringDictionary : IEnumerable
    {
        private Dictionary<string, string> m_dictionary = new Dictionary<string, string>();

        public int Count
        {
            get { return m_dictionary.Count; }
        }

        public string this[string key]
        {
            get{ return m_dictionary[key]; }
            set { m_dictionary[key] = value; }
        }

        public StringDictionary()
        { }

        public void Add(string key, string value)
        {
            m_dictionary.Add(key, value);
        }

        public bool ContainsKey(string key)
        {
            return m_dictionary.ContainsKey(key);
        }

        public void Remove(string key)
        {
            m_dictionary.Remove(key);
        }

        public IEnumerator GetEnumerator()
        {
            return m_dictionary.GetEnumerator();
        }
    }
}
