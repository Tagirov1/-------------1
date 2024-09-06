namespace ркис_1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("bob")]
    public partial class bob
    {
        public short? groupid { get; set; }

        public short? allocpolicy { get; set; }

        public int? status { get; set; }

        [Key]
        public string groupname { get; set; }
    }
}
