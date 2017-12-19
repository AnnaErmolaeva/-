using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace WpfApp1
{
    public class VesVR : ValidationRule
    {
        public override ValidationResult Validate(Object ves, CultureInfo cultureInfo)
        {
            string vesValue = (string)Convert.ChangeType(ves, typeof(string));
            if ((vesValue.Length <= 1) || (vesValue.Length >= 3))
                return new ValidationResult(false, "Введите корректный вес");

            Regex vesRegExp = new Regex(@"^([a-zA-ZА-Яа-я_^\d \t\v\r\n\f0-9])$");

            
            if (vesRegExp.IsMatch(vesValue)||(vesValue.Contains(" ")))
                return new ValidationResult(false, "Вес не должен содержать буквы или символы");

            return new ValidationResult(true, null);


        }
    }
    public class RostVR : ValidationRule
    {
        public override ValidationResult Validate(Object rost, CultureInfo cultureInfo)
        {
            string rostValue = (string)Convert.ChangeType(rost, typeof(string));
            if ((rostValue.Length <= 2) || (rostValue.Length > 3))
                return new ValidationResult(false, "Введите корректный рост");

            Regex rostRegExp = new Regex(@"^([a-zA-ZА-Яа-я_^\d \t\v\r\n\f])$");

            if (rostRegExp.IsMatch(rostValue) || (rostValue.Contains(" ")))
                return new ValidationResult(false, "Рост не должен содержать буквы или символы");

            return new ValidationResult(true, null);

        }
    }
    public class VozrastVR : ValidationRule
    {
        public override ValidationResult Validate(Object vozrast, CultureInfo cultureInfo)
        {
            string vozrastValue = (string)Convert.ChangeType(vozrast, typeof(string));
            if  ((vozrastValue.Length <= 1) || (vozrastValue.Length > 3)) return new ValidationResult(false, "Введите корректный возраст");

            Regex vozrastRegExp = new Regex(@"^([a-zA-ZА-Яа-я])$");

            if (vozrastRegExp.IsMatch(vozrastValue) || (vozrastValue.Contains(" ")))
                return new ValidationResult(false, "Возраст не должен содержать буквы или символы");

            return new ValidationResult(true, null);

        }
    }
    public class Zhelaemi_vesVR : ValidationRule
    {
        public override ValidationResult Validate(Object zhelaemi_ves, CultureInfo cultureInfo)
        {
            string zhelaemi_vesValue = (string)Convert.ChangeType(zhelaemi_ves, typeof(string));
            if ((zhelaemi_vesValue.Length <= 1) || (zhelaemi_vesValue.Length > 3))
                return new ValidationResult(false, "Введите корректный желаемый вес");

            Regex zhelaemi_vesRegExp = new Regex(@"^([a-zA-ZА-Яа-я_^\d \t\v\r\n\f])$");

            if (zhelaemi_vesRegExp.IsMatch(zhelaemi_vesValue) || (zhelaemi_vesValue.Contains(" ")))
                return new ValidationResult(false, "Вес не должен содержать буквы или символы");

            return new ValidationResult(true, null);
        }
    }


    public class PolVR : ValidationRule
    {
        public override ValidationResult Validate(Object parameter, CultureInfo cultureInfo)
        {
            Int32 parameterValue = (Int32)Convert.ChangeType(parameter, typeof(Int32));
            if (parameterValue == 0) 
                return new ValidationResult(false, "Выберите пол");

            return new ValidationResult(true, null);
        }
    }

    public class DataVR : ValidationRule
    {
        public override ValidationResult Validate(Object data, CultureInfo cultureInfo)
        {
            
                DateTime dataValue = (DateTime)Convert.ChangeType(data, typeof(DateTime));
                DateTime dt = new DateTime(2017, 12, 15);
                if (dataValue < dt)
                    return new ValidationResult(false, "Введите корректную дату начала");
                return new ValidationResult(true, null);
            
            
        }
    }
}


