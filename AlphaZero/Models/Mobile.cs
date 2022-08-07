using AlphaZero.Data;
using AlphaZero.Data.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AlphaZero.Models
{
    public class Mobile : IEntityBase
    {
        [Key]
        public int ID { get; set; }

        [Display(Name ="Picture")]
        [Required(ErrorMessage = "Picture Url is required")]
        public string PictureUrl { get; set; }
        [Display(Name = "Model Name")]
        [Required(ErrorMessage = "ModelName is required")]
        public string ModelName { get; set; }
        [Required(ErrorMessage = "WirelessCarrier is required")]
        public string WirelessCarrier { get; set; }
        public Brand Brand { get; set; }
        [Required(ErrorMessage = "FormFactor is required")]
        public string FormFactor { get; set; }
        [Required(ErrorMessage = "RamMemory is required")]
        public int RamMemory { get; set; }
        public OperSystem OperatingSystem { get; set; }
        [Required(ErrorMessage = "Color is required")]
        public string Color { get; set; }
        [Required(ErrorMessage = "CellularTechnology is required")]
        public string CellularTechnology { get; set; }
        [Required(ErrorMessage = "Year is required")]
        public int Year { get; set; }
        public int Resolution { get; set; }
        [Required(ErrorMessage = "AboutThisItem is required")]
        [StringLength(1500, MinimumLength = 10, ErrorMessage = "AboutThisItem must be between 10 and 1500 chars")]
        public string AboutThisItem { get; set; }
        [Required(ErrorMessage = "InternalStorageMemory is required")]
        public int InternalStorageMemory { get; set; }
        public string Bio { get; set; }
        public double Price { get; set; }
        public SIMCardSlotCount SIMCardSlotCount { get; set; }
        public SIMCardSize SIMCardSize { get; set; }




    }
}
