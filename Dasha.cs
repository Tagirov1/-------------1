namespace ркис_1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Dasha")]
    public partial class Dasha
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Ves { get; set; }
    }
}
