using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace testesRazor.Models
{
    public class VeiculosModel
    {
        public VeiculosModel(int id, string plate, int type)
        {
            Id = id;
            Plate = plate;
            Type = type;
        }

        public int Id { get; set; }
        public string Plate { get; set; }
        public int Type { get; set; }
    }
}