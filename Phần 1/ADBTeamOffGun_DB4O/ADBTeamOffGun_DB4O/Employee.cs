using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidTerm2020
{
    [Serializable]
    public class NhanVien
    {
        public Guid ID { get; set; }
        public string HoTen { get; set; }
        public string Skill { get; set; }
        public string HomeBase { get; set; }
        public NhanVien QuanLy { get; set; }
        public double Luong { get; set; }

        public override string ToString()
        {
            return string.Format("{0}, {1} ({2})", HoTen, Skill, Luong);
        }
    }
}
