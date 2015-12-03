using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaStore.Core.Interface;
using MediaStore.Core.Resources;
using MediaStore.Data.DataModels;

namespace MediaStore.Core.Services
{
    public class CdService:IMedia<Cd>
    {
        public void AddMedia(Cd media)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cd> GetMediaList(MediaType type)
        {
            throw new NotImplementedException();
        }

        public Cd GetMediaById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Cd> GetAllMediaByType(MediaType type)
        {
            throw new NotImplementedException();
        }
    }
}
