namespace Dining.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("menu")]
    public partial class menu
    {
        [Key]
        public int mid { get; set; }

        [StringLength(100)]
        public string mname { get; set; }

        public int? mprice { get; set; }

        public int? mtype { get; set; }
    }
}
