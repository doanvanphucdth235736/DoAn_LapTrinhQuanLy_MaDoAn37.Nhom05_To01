using System;

namespace QuanLyPhongTroTheoThang.Data
{
    public class Bill
    {
        public int BillID { get; set; }

        public int RoomID { get; set; }
        public DateTime Month { get; set; }

        public int ElectricOld { get; set; }
        public int ElectricNew { get; set; }

        public int WaterOld { get; set; }
        public int WaterNew { get; set; }

        public decimal Total { get; set; }
        public bool Status { get; set; }

        public virtual Room Room { get; set; }
    }
}
