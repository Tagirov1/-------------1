namespace ркис_1
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Vika")]
    public partial class Vika
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Cat { get; set; }
    }
}
