using System;

namespace QuanLyPhongTroTheoThang.Data
{
    public class Contract
    {
        public int ContractID { get; set; }

        public int RoomID { get; set; }
        public int TenantID { get; set; }

        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal Deposit { get; set; }

        public virtual Room Room { get; set; }
        public virtual Tenant Tenant { get; set; }
    }
}
