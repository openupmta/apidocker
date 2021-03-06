namespace QLNCKHGV.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class GV_ChamThi
    {
        public int Id { get; set; }

        public int? IdGiaoVien { get; set; }

        public int? IdLoaiChamThi { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(10)]
        public string NamHoc { get; set; }

        public int? KiHoc { get; set; }

        public int? SoGio { get; set; }

        public virtual GiaoVien GiaoVien { get; set; }

        public virtual LoaiChamThi LoaiChamThi { get; set; }
    }
}
