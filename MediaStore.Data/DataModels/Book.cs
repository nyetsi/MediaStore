using System.Net.Mime;

namespace MediaStore.Data.DataModels
{
    public class Book : Media
    {
        public string ISBN { get; set; }
        public string Author { get; set; }
        public string Publisher { get; set; }
    }
}
