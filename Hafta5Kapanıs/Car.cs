using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Hafta5Kapanıs
{
    public class Car
    {
        private int _serialNo { get; set; }
        private string _brand { get; set; }
        private int _model {  get; set; }
        private string _color { get; set; }
        private int _door { get; set; }
        DateTime _date { get; set; }
        public Car(int serialNo, string brand, int model, string color, int door,DateTime date)
        {
            _serialNo = serialNo;
            _brand = brand;
            _model = model;
            _color = color;
            _door = door;
            _date = DateTime.Now;
        }
        public override string ToString()
        {
            return $"Marka: {_brand}, Model: {_model}, Seri No: {_serialNo}, Renk: {_color}, Kapı Sayısı: {_door}, Üretim Tarihi: {DateTime.Now}";
        }
    }
    
}
