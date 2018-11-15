using System;
using System.ComponentModel.DataAnnotations;

namespace Car4U.Application.ViewModels
{
    public class CarImageViewModel : BaseViewModel<Guid>
    {
        [DataType(DataType.Url)]
        public string Uri { get; set; }
        
        public int Width { get; set; }
        public int Height { get; set; }
        public string Type { get; set; }
    }
}