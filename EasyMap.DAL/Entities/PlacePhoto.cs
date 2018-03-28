using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyMap.DAL.Entities
{
    public class PlacePhoto
    {
        [Key]
        public int Id { get; set; }
        public int PlaceId { get; set; }
        public string SRC { get; set; }

        [ForeignKey("PlaceId")]
        public virtual Place Place { get; set; }
    }
}
