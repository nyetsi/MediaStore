using System;

namespace MediaStore.Data.DataModels
{
    public class Dvd:Media
    {
        public TimeSpan RunTime { get; set; }
        public string Rating { get; set; }
    }
}
