namespace Insights.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("YearlyRecordBook")]
    public partial class YearlyRecordBook
    {
        public int Id { get; set; }

        public int BuildingId { get; set; }

        public long? TotalCost { get; set; }

        public long? TotalSaving { get; set; }

        public short Year { get; set; }

        public bool IsActive { get; set; }

        public DateTime CreatedOn { get; set; }

        public DateTime UpdatedOn { get; set; }
    }
}
