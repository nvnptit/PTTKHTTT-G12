//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace QLTV.Entity
{
    using System;
    using System.Collections.Generic;
    
    public partial class ChiTietPhieuTra
    {
        public string MaPhieuTra { get; set; }
        public int MaSach { get; set; }
        public string MaPhieuMuon { get; set; }
        public Nullable<int> SoTienPhat { get; set; }
        public string GhiChu { get; set; }
    
        public virtual PhieuMuon PhieuMuon { get; set; }
        public virtual PhieuTra PhieuTra { get; set; }
        public virtual Sach Sach { get; set; }
    }
}
