namespace Dining.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Manage")]
    public partial class Manage
    {
        public int id { get; set; }

        [StringLength(35)]
        public string name { get; set; }

        [StringLength(50)]
        public string pwd { get; set; }
    }
}
