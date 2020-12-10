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
    

    public partial class Form1 : Form
    {
        IObjectContainer DB;
        public void opendb()
        {
            DB = Db4oFactory.OpenFile("Congty.yup");
        }
        public void closedb()
        {
            DB.Close();
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DB = Db4oFactory.OpenFile("Nhanvien.yup");//10 nhân viên
            for(char id = 'A'; id < 'K'; id++)
            {
                NhanVien x = new NhanVien();
                x = addNhanVien(id);
                DB.Store(x);
            }
            IList<NhanVien> nhanViens = DB.Query<NhanVien>();
            foreach (NhanVien x in nhanViens)
            {
                listNV.Items.Add(x.HoTen.ToString());
            }
            DB.Close();
        }

        private void Btn_add_Click(object sender, EventArgs e)
        {
            opendb();
              
            CongTy congTy = new CongTy()
            {

                TenCongTy = txt_name.Text,
                MaCongTy = Guid.NewGuid(),
                SoNha = txt_home.Text,
                DuongPho = txt_street.Text,
                MaSoThue = txt_idthue.Text,
                QuanHuyen = txt_district.Text,
                GiamDoc = listNV.SelectedItem.ToString()
            };
           
            DB.Store(congTy);
            closedb();
        }

        private void Btn_show_Click(object sender, EventArgs e)
        {
            DB = Db4oFactory.OpenFile("Nhanvien.yup");
            IList<NhanVien> employes = DB.Query<NhanVien>();
            if (employes.Count >= 0)
            {
                foreach (NhanVien em in employes)
                {
                    displaycom.DataSource = employes.ToArray();
                }
            }
            DB.Close();
        }

        private void Btn_addem_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.ShowDialog();
        }

        private void ListNV_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
       public NhanVien addNhanVien(char name)
        {
            Random r = new Random();
            NhanVien x = new NhanVien()
            {
                
                HoTen = "Nguyễn Văn " + name,
                Skill = "Quản lý",
                HomeBase="TTT",
                Luong = r.Next(300, 1000000)
            };

            return x;
        }

        private void Id_home_Click(object sender, EventArgs e)
        {

        }

        private void Street_Click(object sender, EventArgs e)
        {

        }
    }
}
