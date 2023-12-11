using BL.Entity;
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
    public partial class Form1 : Form
    {
        string NoUser=null, NoMelk=null, Forosh_Ejare_Kharid=null, JahatMelk=null, PosheshKaf=null, SysGarmayesh=null, SysSarmayesh=null, Adress;
        bool? Asansor=null, Anbari=null, Teras=null, GhabelTabdil=null, Sanad=null, Kabinet=null;
        int id;
        ErrorProvider errorProvider = new ErrorProvider();
        BL.Melk melk = new BL.Melk();
        Melk_Kh_Ap object_melk;
        List<Melk_Kh_Ap> list;
        public Form1()
        {
            InitializeComponent();
        }

        private void combo_Jahat_Melk_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (combo_Jahat_Melk.Text)
            {
                case "شمالی":
                    JahatMelk = "شمالی";
                    break;
                case "جنوبی":
                    JahatMelk = "جنوبی";
                    break;
                default:
                    JahatMelk = null;
                    break;
            }
        }

        private void combo_Poshesh_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (combo_Poshesh.Text)
            {
                case "سرامیک":
                    PosheshKaf = "سرامیک";
                    break;
                case "مزاییک":
                    PosheshKaf = "مزاییک";
                    break;
                case "کف پوش":
                    PosheshKaf = "کف پوش";
                    break;
                case "پارکت":
                    PosheshKaf = "پارکت";
                    break;
                default:
                    PosheshKaf = null;
                    break;
            }
        }

       

        private void combo_System_Garmayesh_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (combo_System_Garmayesh.Text)
            {
                case "بخاری":
                    SysGarmayesh = "بخاری";
                    break;
                case "شوفاژ":
                    SysGarmayesh = "شوفاژ";
                    break;
                case "شومینه":
                    SysGarmayesh = "شومینه";
                    break;
                default:
                    SysGarmayesh = null;
                    break;
            }
        }

        private void combo_System_Sarmayesh_SelectedValueChanged(object sender, EventArgs e)
        {

            switch (combo_System_Sarmayesh.Text)
            {
                case "کولر آبی":
                    SysSarmayesh = "کولر آبی";
                    break;
                case "کولر گازی":
                    SysSarmayesh = "کولر گازی";
                    break;
                case "پنکه":
                    SysSarmayesh = "پنکه";
                    break;
                default:
                    SysSarmayesh = null;
                    break;

            }
        }

        private void combo_Forosh_Ejare_Kharid_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (combo_Forosh_Ejare_Kharid.Text)
            {
                case "خرید":
                    Forosh_Ejare_Kharid = "خرید";
                    txt_Rahn.Text = "";
                    txt_Ejare.Text = "";
                    txt_Rahn.Enabled = false;
                    txt_Ejare.Enabled = false;
                    txt_gheymat_kol.Enabled = true;
                   
                    txt_Ejare.Text = "";
                    txt_Rahn.Text = "";
                    break;
                case "فروش":
                    Forosh_Ejare_Kharid = "فروش";
                    txt_Rahn.Text = "";
                    txt_Ejare.Text = "";
                    txt_Rahn.Enabled = false;
                    txt_Ejare.Enabled = false;
                    txt_gheymat_kol.Enabled = true;                   
                    break;
                case "اجاره":
                    Forosh_Ejare_Kharid = "اجاره";
                    txt_gheymat_kol.Text = "";
                    txt_Rahn.Enabled = true;
                    txt_Ejare.Enabled = true;
                    txt_gheymat_kol.Enabled = false;
                  
                    break;
                default:
                    Forosh_Ejare_Kharid = null;
                    break;
            }
            
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
               
                id = int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
                object_melk = melk.Find_By_Id(id);

                switch (object_melk.Anbari)
                {
                    case true:
                        radio_Yes_Anbari.Checked = true;
                        break;
                    case false:
                        radio_No_Anbari.Checked = true;
                        break;
                    default :
                        radio_Not_NoYes_Anbari.Checked = true;
                        break;

                }
                switch (object_melk.Asansor)
                {
                    case true:
                        radio_Yes_Asansor.Checked = true;
                        break;
                    case false:
                        radio_No_Asansor.Checked = true;
                        break;
                    default:
                        radio_Not_NoYes_Asansor.Checked = true;
                        break;

                }
                switch (object_melk.Kabinet)
                {
                    case true:
                        radio_Yes_Kabinet.Checked = true;
                        break;
                    case false:
                        radio_No_Kabinet.Checked = true;
                        break;
                    default:
                        radio_Not_NoYes_Kabinet.Checked = true;
                        break;

                }
                switch (object_melk.Teras)
                {
                    case true:
                        radio_Yes_Teras.Checked = true;
                        break;
                    case false:
                        radio_No_Teras.Checked = true;
                        break;
                    default:
                        radio_Not_NoYes_Teras.Checked = true;
                        break;

                }
                switch (object_melk.Sanad)
                {
                    case true:
                        radio_Yes_Sanad.Checked = true;
                        break;
                    case false:
                        radio_No_Sanad.Checked = true;
                        break;
                    default:
                        radio_Not_NoYes_Sanad.Checked = true;
                        break;

                }
                switch (object_melk.GhabelTabdil)
                {
                    case true:
                        radio_Yes_GhabelTabdil.Checked = true;
                        break;
                    case false:
                        radio_No_GhabelTabdil.Checked = true;
                        break;
                    default:
                        radio_Not_NoYes_GhabelTabdil.Checked = true;
                        break;

                }
                var adress = object_melk.Adress.Split(',');
                var vahed_pol = object_melk.Gheymat_kol.Split('_');
                txt_Bonbast.Text = adress[2];
                txt_Ejare.Text = object_melk.Ejare;
                txt_FullName.Text = object_melk.FullName;
                txt_gheymat_kol.Text = vahed_pol[0];
                txt_Kheyaban.Text = adress[0];
                txt_Koche.Text = adress[1];
                txt_Metraj.Text = object_melk.Metraj.ToString();
                txt_PhoneNumber.Text = object_melk.Telephone;
                txt_Rahn.Text = object_melk.Rahn;
                txt_Tabaghe.Text = object_melk.Tabaghe.ToString();
                txt_TedadKhab.Text = object_melk.TedadKhab.ToString();
                txt_TedadVahed.Text = object_melk.TedadVahed.ToString();
                txt_Tozihat.Text = object_melk.Tozihat;
                txt_YearSakht.Text = object_melk.SaleSakht;
                combo_Forosh_Ejare_Kharid.SelectedItem = object_melk.Forosh_ejare_kharid;
                combo_Jahat_Melk.SelectedItem = object_melk.JahatAparteman;
                combo_NoMelk.SelectedItem = object_melk.NoMelk;
                combo_No_User.SelectedItem = object_melk.NoUser;
                combo_Poshesh.SelectedItem = object_melk.PosheshKaf;
                combo_System_Garmayesh.SelectedItem = object_melk.SystemGarmayesh;
                combo_System_Sarmayesh.SelectedItem = object_melk.SystemSarmayesh;
                combo_vahed_pol.SelectedItem = "_"+ vahed_pol[1];
            }
            catch
            {


            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            var result = melk.Delete(object_melk);
            Form1_Load(null,null);
            if (result == true)
            {
                MessageBox.Show("کاربر عزیز حذف انجام شد");
            }

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Adress = txt_Kheyaban.Text + "," + txt_Koche.Text + "," + txt_Bonbast.Text;
            string rahn = txt_Rahn.Text != "" ? txt_Rahn.Text + "_" + lbl_Rahn.Text : null;
            string ejare = txt_Ejare.Text != "" ? txt_Ejare.Text + "_" + lbl_Ejare.Text : null;
            int? CountVahed;
            try
            {
                CountVahed = int.Parse(txt_TedadVahed.Text);
            }
            catch
            {
                CountVahed = null;
            }
           
                object_melk = new Melk_Kh_Ap(rahn, ejare, txt_gheymat_kol.Text + combo_vahed_pol.Text, Forosh_Ejare_Kharid, txt_FullName.Text, Convert.ToInt32(txt_Metraj.Text), Convert.ToInt32(txt_TedadKhab.Text), int.Parse(txt_Tabaghe.Text), Asansor, PosheshKaf, SysGarmayesh, SysSarmayesh, Sanad, txt_YearSakht.Text, Teras, Kabinet, JahatMelk, Anbari, GhabelTabdil, masked_TarikhTahvil.Text, txt_PhoneNumber.Text, DateTime.Now.ToShamsi(), CountVahed, Adress, JahatMelk, txt_Kheyaban.Text, NoUser, NoMelk, txt_Tozihat.Text, true);

               
            object_melk.ID = id;
            bool result = melk.update(object_melk);
            if (result == true)
            {
                MessageBox.Show("کاربر عزیز ویرایش شما با موفقیت انجام شد");
            }
            else
            {
                MessageBox.Show("مشکلی در ویرایش به وجود آمده");
            }
            Form1_Load(null,null);
        }

      

       

        private void btn_Search_ShowList_Click(object sender, EventArgs e)
        {
            var item = combo_Search_TransactionType.Text.Split('-');

            list = melk.Find_By_TransactionType(item[1], item[0]);
            dataGridView1.DataSource = list.ToList();
           
        }

        private void radio_No_Asansor_CheckedChanged(object sender, EventArgs e)
        {
            Asansor = false;
        }

        private void radio_Yes_Asansor_CheckedChanged(object sender, EventArgs e)
        {
            Asansor = true;
        }

        private void radio_Not_NoYes_GhabelTabdil_CheckedChanged(object sender, EventArgs e)
        {
            GhabelTabdil = null;
        }

        private void radio_No_GhabelTabdil_CheckedChanged(object sender, EventArgs e)
        {
            GhabelTabdil = false;
        }

        private void radio_Yes_GhabelTabdil_CheckedChanged(object sender, EventArgs e)
        {
            GhabelTabdil = true;
        }

        private void radio_Not_NoYes_Sanad_CheckedChanged(object sender, EventArgs e)
        {
            Sanad = null;
        }

        private void radio_No_Sanad_CheckedChanged(object sender, EventArgs e)
        {
            Sanad = false;
        }

        private void radio_Yes_Sanad_CheckedChanged(object sender, EventArgs e)
        {
            Sanad = true;
        }

        private void radio_Not_NoYes_Teras_CheckedChanged(object sender, EventArgs e)
        {
            Teras = null;
        }

        private void radio_No_Teras_CheckedChanged(object sender, EventArgs e)
        {
            Teras = false;
        }

        private void radio_Yes_Teras_CheckedChanged(object sender, EventArgs e)
        {
            Teras = true;
        }

        private void radio_Not_NoYes_Anbari_CheckedChanged(object sender, EventArgs e)
        {
            Anbari = null;
        }

        private void radio_No_Anbari_CheckedChanged(object sender, EventArgs e)
        {
            Anbari = false;
        }

        private void radio_Yes_Anbari_CheckedChanged(object sender, EventArgs e)
        {
            Anbari = true;
        }

        private void radio_Not_NoYes_Kabinet_CheckedChanged(object sender, EventArgs e)
        {
            Kabinet = null;
        }

        private void radio_No_Kabinet_CheckedChanged(object sender, EventArgs e)
        {
            Kabinet = false;
        }

        private void radio_Yes_Kabinet_CheckedChanged(object sender, EventArgs e)
        {
            Kabinet = true;
        }

        private void btn_Clear_input_Click(object sender, EventArgs e)
        {
            empty_input();
        }

        private void combo_Search_TransactionType_SelectedValueChanged(object sender, EventArgs e)
        {
            var item = combo_Search_TransactionType.Text.Split('-');

            list = melk.Find_By_TransactionType(item[1], item[0]);
            dataGridView1.DataSource = list.ToList();
        }

        private void btn_Show_All_List_Click(object sender, EventArgs e)
        {
            Form1_Load(null, null);
        }

        private void btn_show_Customer_Click(object sender, EventArgs e)
        {
            string Full_Name = txt_Search_FullName.Text;
            if (!string.IsNullOrEmpty(Full_Name))
            {
                list = melk.Find_By_FullName(Full_Name);
                Fill_DataGridView(true);
            }
            else
            {
                errorProvider.SetError(txt_Search_FullName, "خالی است");
            }
        }

        private void dataGridView1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            id =int.Parse(dataGridView1.CurrentRow.Cells[0].Value.ToString());
            var item = melk.Find_By_Id(id);
            Form2 form2 = new Form2(item,this);
            form2.ShowDialog();

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void radio_Not_NoYes_Asansor_CheckedChanged(object sender, EventArgs e)
        {
            Asansor = null;
        }

        private void btn_Show_All_Customers_Click(object sender, EventArgs e)
        {
            list = melk.Get_All_customers();
            Fill_DataGridView(true);
        }

       

       

        private void combo_NoMelk_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (combo_NoMelk.Text)
            {
                case "خانه":
                    NoMelk = "خانه";
                    txt_TedadVahed.Text = "";
                    txt_TedadVahed.Enabled = false;
                    break;
                case "آپارتمان":
                    NoMelk = "آپارتمان";
                    txt_TedadVahed.Enabled = true;
                    break;
                default:
                    NoMelk = null;
                    break;
            }
           
        }
       

        private void combo_No_User_SelectedValueChanged(object sender, EventArgs e)
        {
            switch (combo_No_User.Text)
            {
                case "متقاضی":
                    NoUser = "متقاضی";
                    break;
                case "صاحب ملک":
                    NoUser = "صاحب ملک";
                    break;
                default:
                    NoUser = null;
                    break;
            }
           
        }
        
        private void empty_input()
        {
            txt_Bonbast.Text = "";
            txt_Ejare.Text = "";
            txt_FullName.Text = "";
            txt_gheymat_kol.Text = "";
            txt_Kheyaban.Text = "";
            txt_Koche.Text = "";
            txt_Metraj.Text = "";
            txt_PhoneNumber.Text = "";
            txt_Rahn.Text = "";
            txt_Tabaghe.Text = "";
            txt_TedadKhab.Text = "";
            txt_TedadVahed.Text = "";
            txt_Tozihat.Text = "";
            txt_YearSakht.Text = "";
            radio_Not_NoYes_Anbari.Checked = true;
            radio_Not_NoYes_Asansor.Checked = true;
            radio_Not_NoYes_GhabelTabdil.Checked = true;
            radio_Not_NoYes_Kabinet.Checked = true;
            radio_Not_NoYes_Sanad.Checked = true;
            radio_Not_NoYes_Teras.Checked = true;
            combo_Forosh_Ejare_Kharid.SelectedIndex = 0;
            combo_Jahat_Melk.SelectedIndex = 0;
            combo_NoMelk.SelectedIndex = 0;
            combo_No_User.SelectedIndex = 0;
            combo_Poshesh.SelectedIndex = 0;
            combo_System_Garmayesh.SelectedIndex = 0;
            combo_System_Sarmayesh.SelectedIndex = 0;
            combo_vahed_pol.SelectedIndex = 0;

        }
       
        public void Fill_DataGridView(bool? a)
        {

            
            dataGridView1.DataSource = list;
            if (a == true)
            {
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
            else
            {

            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            var result = melk.CreateDatabase();
            if (result == true)
            {
                MessageBox.Show(" دیتابیس با موفقیت ساخته شد");
            }
            list = melk.GetAllList();
            Fill_DataGridView(true);
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {


         
            errorProvider.Clear();
            string rahn =txt_Rahn.Text!=""? txt_Rahn.Text + "_" + lbl_Rahn.Text:null;
            string ejare = txt_Ejare.Text!=""?txt_Ejare.Text + "_" + lbl_Ejare.Text:null;
            int? CountVahed;
            try
            {
                CountVahed = int.Parse(txt_TedadVahed.Text);
            }
            catch
            {
                CountVahed = null;
            }
            bool success = false;
            if (tabControl1.SelectedTab.Name == "tab_Khane_Ap")
            {
                if (txt_YearSakht.Text != "" && ((txt_TedadVahed.Text != "") || (txt_TedadVahed.Text == "" && txt_TedadVahed.Enabled == false)) && txt_TedadKhab.Text != "" && txt_Tabaghe.Text != "" && ((txt_Rahn.Text != "" && txt_Ejare.Text != "") || (txt_Rahn.Text == "" && txt_Ejare.Text == "" && txt_Ejare.Enabled == false)) && txt_Metraj.Text != "" && txt_Koche.Text != "" && txt_Kheyaban.Text != "" && txt_FullName.Text != "" && txt_Bonbast.Text != "" && NoMelk != "" && NoUser != "" && Forosh_Ejare_Kharid != "" && JahatMelk != "" && PosheshKaf != "" && SysGarmayesh != "" && SysSarmayesh != "" && ((txt_gheymat_kol.Text != "" && txt_gheymat_kol.Enabled == true) || (txt_gheymat_kol.Text == "" && txt_gheymat_kol.Enabled == false)))
                {
                    Adress = txt_Kheyaban.Text + "," + txt_Koche.Text + "," + txt_Bonbast.Text;
                   
                        object_melk = new Melk_Kh_Ap(rahn, ejare, txt_gheymat_kol.Text + combo_vahed_pol.Text, Forosh_Ejare_Kharid, txt_FullName.Text, Convert.ToInt32(txt_Metraj.Text), Convert.ToInt32(txt_TedadKhab.Text), int.Parse(txt_Tabaghe.Text), Asansor, PosheshKaf, SysGarmayesh, SysSarmayesh, Sanad, txt_YearSakht.Text, Teras, Kabinet, JahatMelk, Anbari, GhabelTabdil, masked_TarikhTahvil.Text, txt_PhoneNumber.Text, DateTime.Now.ToShamsi(), CountVahed, Adress, JahatMelk, txt_Kheyaban.Text, NoUser, NoMelk, txt_Tozihat.Text,true);

                   
                    BL.Melk melk = new BL.Melk();
                    success = melk.SabtMelk_Kh_Ap(object_melk);
                    Form1_Load(null, null);
                    if (success == true)
                    {
                        MessageBox.Show("کاربر عزیز ثبت شما موفقیت آمیز بود");
                        Fill_DataGridView(null);
                        empty_input();
                    }
                    else
                    {
                        MessageBox.Show("مشکلی در ثبت به وجود آمده");
                    }
                }
                else
                {
                    if (txt_TedadVahed.Text == "")
                    {
                        errorProvider.SetError(txt_TedadVahed, "لطفا پر کنید");
                    }
                    if (txt_FullName.Text == "")
                    {
                        errorProvider.SetError(txt_FullName, "لطفا پر کنید");
                    }
                    if (txt_Ejare.Text == "")
                    {
                        errorProvider.SetError(txt_Ejare, "لطفا پر کنید");
                    }
                    if (txt_Bonbast.Text == "")
                    {
                        errorProvider.SetError(txt_Bonbast, "لطفا پر کنید");

                    }
                    if (txt_Kheyaban.Text == "")
                    {
                        errorProvider.SetError(txt_Kheyaban, "لطفا پر کنید");
                    }
                    if (txt_Koche.Text == "")
                    {
                        errorProvider.SetError(txt_Koche, "لطفا پر کنید");

                    }
                    if (txt_Metraj.Text == "")
                    {
                        errorProvider.SetError(txt_Metraj, "لطفا پر کنید");
                    }
                    if (txt_Rahn.Text == "")
                    {
                        errorProvider.SetError(txt_Rahn, "لطفا پر کنید");
                    }
                    if (txt_Tabaghe.Text == "")
                    {
                        errorProvider.SetError(txt_Tabaghe, "لطفا پر کنید");

                    }
                    if (txt_TedadKhab.Text == "")
                    {
                        errorProvider.SetError(txt_TedadKhab, "لطفا پر کنید");
                    }
                   
                    if (txt_YearSakht.Text == "")
                    {
                        errorProvider.SetError(txt_YearSakht, "لطفا پر کنید");
                    }
                  
                    if (SysGarmayesh == "")
                    {
                        errorProvider.SetError(combo_System_Garmayesh, "لطفا یک آیتم انتخاب کنید");
                    }
                    if (SysSarmayesh == "")
                    {
                        errorProvider.SetError(combo_System_Sarmayesh, "لطفا یک آیتم انتخاب کنید");

                    }
                    if (NoUser == "")
                    {
                        errorProvider.SetError(combo_No_User, "لطفا یک آیتم انتخاب کنید");

                    }
                    if (NoMelk == "")
                    {
                        errorProvider.SetError(combo_NoMelk, "لطفا یک آیتم انتخاب کنید");
                    }
                    if (PosheshKaf == "")
                    {
                        errorProvider.SetError(combo_Poshesh, "لطفا یک آیتم انتخاب کنید");

                    }
                    if (JahatMelk == "")
                    {
                        errorProvider.SetError(combo_Jahat_Melk, "لطفا یک آیتم انتخاب کنید");

                    }
                    if (Forosh_Ejare_Kharid == "")
                    {
                        errorProvider.SetError(combo_Forosh_Ejare_Kharid, "لطفا یک آیتم انتخاب کنید");
                    }
                    if (txt_gheymat_kol.Text == "")
                    {
                        errorProvider.SetError(txt_gheymat_kol, "لطفا پر کنید");

                    }
                }

            }
            else if (tabControl1.SelectedTab.Name == "tab_Zamin")
            {



            }

            else if (tabControl1.SelectedTab.Name == "tab_Vilayee")
            {


            }
            else if (tabControl1.SelectedTab.Name == "tab_Maghaze")
            {


            }
            else
            {
                MessageBox.Show("لطفا تب خود را انتخاب نمایید");

            }
            

        }
    }
}
