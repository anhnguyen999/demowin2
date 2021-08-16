namespace AppPhim.DataAccessLayer.Entities
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChiTietHoaDon")]
    public partial class ChiTietHoaDon
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        public int? MaHoaDon { get; set; }

        public int? SoGhe { get; set; }

        public double? GiaTien { get; set; }

        public virtual HoaDon HoaDon { get; set; }
    }
}
