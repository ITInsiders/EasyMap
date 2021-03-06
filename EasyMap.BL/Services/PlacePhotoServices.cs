﻿using EasyMap.BL.DTO;
using EasyMap.BL.Extensions;
using EasyMap.DAL.Entities;
using EasyMap.DAL.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace EasyMap.BL.Services
{
    public class PlacePhotoServices
    {
        private static EFUnitOfWork Database = new EFUnitOfWork();

        public static void Create(PlacePhotoDTO placePhotoDTO)
        {
            PlacePhoto placePhoto = MapperTransform<PlacePhoto, PlacePhotoDTO>.ToEntity(placePhotoDTO);
            Database.PlacePhotos.Create(placePhoto);
            Database.Save();
        }
        public static List<PlacePhotoDTO> GetAll()
        {
            List<PlacePhoto> placePhoto = Database.PlacePhotos.GetAll().ToList();
            return MapperTransform<PlacePhoto, PlacePhotoDTO>.ToModelCollection(placePhoto);
        }
        public static PlacePhotoDTO Get(int id)
        {
            PlacePhoto placePhoto = Database.PlacePhotos.Get(id);
            return MapperTransform<PlacePhoto, PlacePhotoDTO>.ToModel(placePhoto);
        }

        public static void Update(PlacePhotoDTO placePhotoDTO)
        {
            PlacePhoto placePhoto = Database.PlacePhotos.Get(placePhotoDTO.Id);
            placePhoto.PlaceId = placePhotoDTO.PlaceId;
            placePhoto.SRC = placePhotoDTO.SRC;
            Database.PlacePhotos.Update(placePhoto);
            Database.Save();
        }
        public static void Delete(int id)
        {
            Database.PlacePhotos.Delete(id);
            Database.Save();
        }
    }
}
