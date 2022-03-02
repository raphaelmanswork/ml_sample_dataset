using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using System.Globalization;
using CsvHelper;
using CsvHelper.Configuration;
using CsvHelper.Configuration.Attributes;

namespace MCL_Stroke
{

    enum Genders
    {
        Male,
        Female,
    }

    class CsvHelper
    {

        public List<StrokeData> getRecords()
        {
            using (var reader = new StreamReader("C:\\Users\\rapha\\source\\repos\\MCL_Stroke\\MCL_Stroke\\data.csv"))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {

                csv.Context.RegisterClassMap<StrokeDataClassMap>();
                var records = csv.GetRecords<StrokeData>().ToList();


                return records;
            }
        }


    
        public int ParseGender(String g)
        {
            Genders result;
            if (Enum.TryParse(g, out result))
            {
                switch (result)
                {
                    case Genders.Male:
                        return 1;
                }
            }
            return 0;
        }

    }


    public class StrokeDataClassMap : ClassMap<StrokeData>
    {
        public StrokeDataClassMap()
        {
            Map(m => m.Age).Name("age");
            Map(m => m.Avg_Glucose_Level).Name("avg_glucose_level");
            Map(m => m.Gender).Name("gender");
            Map(m => m.Heart_Disease).Name("heart_disease");
            Map(m => m.Hypertension).Name("hypertension");
            //Map(m => m.Residence_Type).Name("Residence_type");
            Map(m => m.Stroke).Name("stroke");
        }
    }

    public class StrokeData
    {
        [Name("age")]
        public double Age { get; set; }

        [Name("avg_glucose_level")]
        public double Avg_Glucose_Level { get; set; }

        [Name("gender")]
        public string Gender { get; set; }

        [Name("heart_disease")]
        public int Heart_Disease { get; set; }

        [Name("hypertension")]
        public int Hypertension { get; set; }

        //[Name("Residence_type")]
        //public string Residence_Type { get; set; }

        [Name("stroke")]
        public int Stroke { get; set; }
    }

   
}
