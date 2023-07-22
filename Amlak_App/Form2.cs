using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Amlak_App
{
    public partial class Form2 : Form
    {
        BL.Entity.Melk_Kh_Ap melk;
        List<BL.Entity.Melk_Kh_Ap> list;
        BL.Melk _melk;
        public Form2(BL.Entity.Melk_Kh_Ap Melk)
        {
            InitializeComponent();
            melk = Melk;
            _melk = new BL.Melk();
        }


        private void Form2_Load(object sender, EventArgs e)
        {
            list = _melk.Get_orders_Customer(melk);
            dataGridView1.DataSource = list;
            dataGridView1.Columns[0].HeaderText = "ردیف";
            dataGridView1.Columns[0].Width = 50;
            dataGridView1.Columns[1].HeaderText = "فروشنده/مشتری";
            dataGridView1.Columns[1].Width = 95;
            dataGridView1.Columns[2].HeaderText = "نوع معامله";
            dataGridView1.Columns[2].Width = 60;
            dataGridView1.Columns[3].HeaderText = "نوع ملک";
            dataGridView1.Columns[3].Width = 100;
            dataGridView1.Columns[4].HeaderText = "نام کامل";
            dataGridView1.Columns[4].Width = 200;
            dataGridView1.Columns[5].HeaderText = "رهن";
            dataGridView1.Columns[5].Width = 100;
            dataGridView1.Columns[6].HeaderText = "اجاره";
            dataGridView1.Columns[6].Width = 100;
            dataGridView1.Columns[7].HeaderText = "متراژ";
            dataGridView1.Columns[7].Width = 100;
            dataGridView1.Columns[8].HeaderText = "تعداد خواب";
            dataGridView1.Columns[8].Width = 50;
            dataGridView1.Columns[9].HeaderText = "طبقه";
            dataGridView1.Columns[9].Width = 50;
            dataGridView1.Columns[10].HeaderText = "پوشش کف";
            dataGridView1.Columns[10].Width = 80;
            dataGridView1.Columns[11].HeaderText = "سیستم گرمایش";
            dataGridView1.Columns[11].Width = 100;
            dataGridView1.Columns[12].HeaderText = "سیستم سرمایش";
            dataGridView1.Columns[12].Width = 100;
            dataGridView1.Columns[13].HeaderText = "سال ساخت";
            dataGridView1.Columns[13].Width = 80;
            dataGridView1.Columns[14].HeaderText = "آسانسور";
            dataGridView1.Columns[14].Width = 80;
            dataGridView1.Columns[15].HeaderText = "سند";
            dataGridView1.Columns[15].Width = 50;
            dataGridView1.Columns[16].HeaderText = "تراس";
            dataGridView1.Columns[16].Width = 50;
            dataGridView1.Columns[17].HeaderText = "کابینت";
            dataGridView1.Columns[17].Width = 50;
            dataGridView1.Columns[18].HeaderText = "انباری";
            dataGridView1.Columns[18].Width = 50;
            dataGridView1.Columns[19].HeaderText = "قابل تبدیل";
            dataGridView1.Columns[19].Width = 80;
            dataGridView1.Columns[20].HeaderText = "جهت ملک";
            dataGridView1.Columns[20].Width = 80;
            dataGridView1.Columns[21].HeaderText = "تاریخ تحویل";
            dataGridView1.Columns[21].Width = 100;
            dataGridView1.Columns[22].HeaderText = "تلفن";
            dataGridView1.Columns[22].Width = 200;
            dataGridView1.Columns[23].HeaderText = "تاریخ ثبت";
            dataGridView1.Columns[23].Width = 100;
            dataGridView1.Columns[24].HeaderText = "تعداد واحد";
            dataGridView1.Columns[24].Width = 80;
            dataGridView1.Columns[25].HeaderText = "آدرس";
            dataGridView1.Columns[25].Width = 250;
            dataGridView1.Columns[26].HeaderText = "شمالی/جنوبی";
            dataGridView1.Columns[26].Width = 80;
            dataGridView1.Columns[27].HeaderText = "محدوده";
            dataGridView1.Columns[27].Width = 80;
            dataGridView1.Columns[28].HeaderText = "بازدید از خانه";
            dataGridView1.Columns[28].Width = 50;
            dataGridView1.Columns[29].HeaderText = "توضیحات";
            dataGridView1.Columns[29].Width = 250;
            dataGridView1.Columns[30].HeaderText = "قیمت کل";
            dataGridView1.Columns[30].Width = 100;
            dataGridView1.Columns[31].HeaderText = "موجود";
            dataGridView1.Columns[31].Width = 50;
           
        }
    }
}
