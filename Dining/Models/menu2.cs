namespace Dining.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class menu2
    {
        [Key]
        public int mid { get; set; }

        [StringLength(50)]
        public string mname { get; set; }

        [StringLength(100)]
        public string murl { get; set; }

        public int? mprice { get; set; }
    }
}
