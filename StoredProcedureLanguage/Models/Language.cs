using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace StoredProcedureLanguage.Models
{
    public class Language
    {
        [Key]
        public string Name { get; set; }
        public string Family { get; set; }
        public string MainAreal { get; set; }
        public int Speakers { get; set; }
    }
}
