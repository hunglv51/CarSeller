using System;
using System.Collections.Generic;
using Car4U.Domain.Entities;

namespace Car4U.Application.ViewModels
{
    public class ListPostViewModel
    {
        public IEnumerable<ListPostItem> Items { get; set; }
    }

    public class ListPostItem
    {
        public string Id { get; set; }
        public ICollection<CarImage> Images { get; set; }
        public string Title {get;set;}
        public double Price {get;set;}
        public DateTime CreatedDate { get; set; }
        public bool IsUsed { get; set; }
        public bool IsImported { get; set; }
        public string Tranmission { get; set; }
        public int ManufactureYear { get; set; }
        public string CarType { get; set; }
        public string Phone { get; set; }
        public string City { get; set; }
        public int DrivenDistance { get; set; }

    }
}