using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Db4objects.Db4o;
using Db4objects.Db4o.Query;
using Db4objects.Db4o.Linq;
using MidTerm2020;

namespace ADBTeamOffGun_DB4O
{
    public partial class Form2 : Form
    {
        IObjectContainer db;
        public Form2()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            db = Db4oFactory.OpenFile("Congty.yup");
            IList<CongTy> companies = db.Query<CongTy>();
            foreach (CongTy x in companies)
            {
                listcom.Items.Add(x.TenCongTy.ToString());
            }
            db.Close();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            db = Db4oFactory.OpenFile("Nhanvien.yup");
            NhanVien nhanVien = new NhanVien()
            {
                ID=Guid.NewGuid(),
                HoTen = txt_name.Text,
                Skill = txt_skill.Text,
                HomeBase = listcom.SelectedItem.ToString(),
                Luong = (double)num_salary.Value

            };
            int employes = db.Query<NhanVien>(delegate (NhanVien employe1)
            {
                return num_salary.Value < 300 || txt_name.Text.Length <= 0;
            }).Count;
            if (employes == 0) {db.Store(nhanVien); } else { MessageBox.Show("Nhập Không Hợp lệ"); }
            
            db.Close();

        }

        private void Listcom_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Txt_id_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
