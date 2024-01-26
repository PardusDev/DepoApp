using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DepoApp.DAL.Models
{
    public enum MeasurementType
    {
        Adet = 0,
        Kg = 1,
        Lt = 2
    }

    public class Product
    {
        [DatabaseGeneratedAttribute(DatabaseGeneratedOption.Identity), Key()]
        public int id { get; set; }

        public string barcode { get; set;}
        public string name { get; set; }

        public Category category { get; set; }

        public int measurementType { get; set; }

        public String getMeasurementType()
        {
            MeasurementType measurementType = (MeasurementType)this.measurementType;
            return measurementType.ToString();
        }
    }
}

