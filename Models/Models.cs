
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;

namespace Zip2TaxWebApp.Models
{
    public class Zip2TaxModel
    {
        public string _Index { get; set; }
        public string _Keyword { get; set; }
        public string _Count { get; set; }

        public Zip2TaxModel()
        {
            _Index = "";
            _Keyword = "";
            _Count = "";
        }

        public string ToZip2ModelToString()
        {
            return $"{_Index} - {_Keyword} - {_Count} \n";
        }
    }


}