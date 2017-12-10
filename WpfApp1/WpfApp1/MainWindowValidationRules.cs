using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    public class VesVR : ValidationRule
    {
        public override ValidationResult Validate(Object ves, CultureInfo cultureInfo)
        {
            int vesValue = (int)Convert.ChangeType(ves, typeof(int));
            if ((vesValue <= 10) || (vesValue >= 200))
                return new ValidationResult(false, "Введите корректный вес");
            return new ValidationResult(true, null);
        }
    }
    public class RostVR : ValidationRule
    {
        public override ValidationResult Validate(Object rost, CultureInfo cultureInfo)
        {
            int rostValue = (int)Convert.ChangeType(rost, typeof(int));
            if ((rostValue <= 50) || (rostValue >= 250))
                return new ValidationResult(false, "Введите корректный рост");
            return new ValidationResult(true, null);
        }
    }
    public class VozrastVR : ValidationRule
    {
        public override ValidationResult Validate(Object vozrast, CultureInfo cultureInfo)
        {
            int vozrastValue = (int)Convert.ChangeType(vozrast, typeof(int));
            if ((vozrastValue <= 10) || (vozrastValue >= 120))
                return new ValidationResult(false, "Введите корректный возраст");
            return new ValidationResult(true, null);
        }
    }
    public class Zhelaemi_vesVR : ValidationRule
    {
        public override ValidationResult Validate(Object zhelaemi_ves, CultureInfo cultureInfo)
        {
            int zhelaemi_vesValue = (int)Convert.ChangeType(zhelaemi_ves, typeof(int));
            if ((zhelaemi_vesValue <= 10) || (zhelaemi_vesValue >= 200))
                return new ValidationResult(false, "Введите корректный желаемый вес");
            return new ValidationResult(true, null);
        }
    }
    public class DataVR : ValidationRule
    {
        public override ValidationResult Validate(Object data, CultureInfo cultureInfo)
        {
            DateTime dataValue = (DateTime)Convert.ChangeType(data, typeof(DateTime));
            if ((dataValue < DateTime.Now) )
                return new ValidationResult(false, "Введите корректную дату начала");
            return new ValidationResult(true, null);
        }
    }
}


