﻿using System.Collections.Generic;
using MediaStore.Core.Resources;
using MediaStore.Data;
using MediaStore.Data.DataModels;

namespace MediaStore.Core.Services
{
    public class DvdService : DataContext
    {
        public void AddMedia(Dvd media)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Dvd> GetMediaList(MediaType type)
        {
            throw new System.NotImplementedException();
        }

        public Dvd GetMediaById(int id)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Dvd> GetAllMediaByType(MediaType type)
        {
            throw new System.NotImplementedException();
        }
    }
}
