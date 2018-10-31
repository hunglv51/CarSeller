﻿using System;

namespace Car4U.ApplicationCore.Entities
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

        public string Uri { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }
    }
}