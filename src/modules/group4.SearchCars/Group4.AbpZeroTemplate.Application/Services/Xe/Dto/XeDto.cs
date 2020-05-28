
using System;

namespace Group4.AbpZeroTemplate.Application.Share.Cars.Dto
{
    /// <summary>
    /// <model cref="Car"></model>
    /// </summary>
    public class XeGroup4Dto
    {
        public int? Ma { get; set; }
        public string Xe_Ma { get; set; }
        public string Xe_Ten { get; set; }
        public int Xe_Gia { get; set; }
        public string Xe_Mau { get; set; }
        public string LoaiXe_Ten { get; set; }
        public string LoaiXe_Hang { get; set; }
        public DateTime? DangKiem_NgayDangKiem { get; set; }
        public int DangKiem_Phi { get; set; }
        public DateTime? DKDuongBo_NgayDangKi { get; set; }
        public int DKDuongBo_Phi { get; set; }
        public DateTime? BaoHiemDansu_NgayDangKi { get; set; }
        public int BaoHiemDansu_Phi { get; set; }
        public DateTime? BaoHiemTuNguyen_NgayDangKi { get; set; }
        public int BaoHiemTuNguyen_Phi { get; set; }





    }
}
