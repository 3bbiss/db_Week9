using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper.Contrib.Extensions;

namespace DapperConsole2
{
    [Table("category")]
    public class Category
    {
        [Key]
        public string id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string location { get; set; }

        public override string ToString()
        {
            return $"{id} {name} {description} {location}";
        }
    }
}
