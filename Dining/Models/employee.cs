namespace Dining.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("employee")]
    public partial class employee
    {
        [Key]
        public int eid { get; set; }

        [StringLength(35)]
        public string ename { get; set; }

        public int? eage { get; set; }

        public int? esalary { get; set; }

        [StringLength(100)]
        public string eimg { get; set; }
    }
}
