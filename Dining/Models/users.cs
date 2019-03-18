namespace Dining.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class users
    {
        [Key]
        public int uid { get; set; }

        [StringLength(35)]
        public string uname { get; set; }

        public int? uphone { get; set; }

        public int? ucome { get; set; }
    }
}
