namespace ркис_1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class bob1
    {
        public short? fileid { get; set; }

        public short? groupid { get; set; }

        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int size { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int maxsize { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int growth { get; set; }

        public int? status { get; set; }

        public int? perf { get; set; }

        [Key]
        [Column(Order = 3)]
        public string name { get; set; }

        [StringLength(260)]
        public string filename { get; set; }
    }
}
