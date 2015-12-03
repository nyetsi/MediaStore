using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading.Tasks;
using MediaStore.Core.Resources;

namespace MediaStore.Core.Interface
{
    public interface IMedia<T>
    {
        void AddMedia(T media);
        IEnumerable<T> GetMediaList(MediaType type);
        T GetMediaById(int id);
    }
}
