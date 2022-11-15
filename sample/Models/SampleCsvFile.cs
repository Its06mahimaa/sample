using System;
using System.Collections.Generic;

namespace sample.Models
{
    public partial class SampleCsvFile
    {
        public int Id { get; set; }
        public string Name { get; set; } = null!;
        public string FirstName { get; set; } = null!;
        public string LastName { get; set; } = null!;
        public bool Column { get; set; }
        public string Mail { get; set; } = null!;
    }
}
