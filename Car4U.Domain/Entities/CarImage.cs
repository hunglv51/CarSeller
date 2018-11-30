using System;
using System.ComponentModel.DataAnnotations;
using Car4U.Domain.Enums;

namespace Car4U.Domain.Entities
{
    public class CarImage : BaseEntity<Guid>
    {
        private CarImage()
        {

        }
        public CarImage(string uri, int width, int height)
        {
            Uri = uri;
            Width = width;
            Height = height;
        }
        
        public Car Car { get; set; }
        [DataType(DataType.Url)]
        public string Uri { get; set; }
        
        public int Width { get; set; }
        public int Height { get; set; }
        public bool IsAvatar { get; set; }

    }
}