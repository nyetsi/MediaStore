using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;

namespace MediaStore.Data.DataModels
{
    public class Media
    {
        public int Id { get; set; }
        public int MediaTypeId { get; set; }
        public string Title { get; set; }
        public DateTime ReleaseDate { get; set; }
        public int CoverArtId { get; set; }
        public Art CoverArt { get; set; }
        public DateTime CreatedDate { get; set; }
    }

    public class Art
    {
    }
}
