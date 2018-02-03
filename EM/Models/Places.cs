using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EM.Models
{
    public class Places
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public double Longitude { get; set; }//долгота
        public double Latitude { get; set; }//широта
        public string Tags { get; set; }//категория, теги
        public string Description { get; set; } // описание
        public string Address { get; set; } //адрес
        public string Site { get; set; }//сайт
        public string Creater { get; set; } // создатель
        public DateTime DateCreate { get; set; } // дата создания

        [ForeignKey("Creater")]
        public virtual User User { get; set; }
    }

    public class InformBlock : MapObject
    {
        public List<int> Album { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public int Checkins { get; set; }
        public int Ratings { get; set; }
        public List<Comment> Comments { get; set; }
    }

    public class BlockMapObject : MapObject
    {
        public int Photo { get; set; }
        public int Like { get; set; }
        public int Dislike { get; set; }
        public int Checkins { get; set; }
        public int Ratings { get; set; }
    }
}