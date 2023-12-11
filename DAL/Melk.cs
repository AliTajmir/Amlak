using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using BL.Entity;

namespace DAL
{
    public class Melk
    {
        List<Melk_Kh_Ap> items;
        Db_Context db;
        public Melk()
        {
            items = new List<Melk_Kh_Ap>();
            db = new Db_Context();
        }
        public bool InsertMelk(BL.Entity.Melk_Kh_Ap Obj_Melk)
        {
            try
            {
                db.MelkKhAp.Add(Obj_Melk);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public List<BL.Entity.Melk_Kh_Ap> GetAllList()
        {
            try
            {
                var items = db.MelkKhAp.ToList();
                return items;
            }
            catch
            {
                return null;
            }


        }

        public bool CreateDatabase()
        {
            if (db.Database.Exists())
            {
                return false;
            }
            db.Database.CreateIfNotExists();
            return true;

        }

        public Melk_Kh_Ap Find_By_Id(int id)
        {
            var item = db.MelkKhAp.Find(id);
            return item;
        }

        public bool Delete(BL.Entity.Melk_Kh_Ap melk)
        {
            try
            {
                db.MelkKhAp.Remove(melk);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public bool update(BL.Entity.Melk_Kh_Ap melk)
        {
            try
            {
                var item = db.MelkKhAp.Find(melk.ID);
                db.Entry(item).CurrentValues.SetValues(melk);
                db.SaveChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public List<Melk_Kh_Ap> Find_By_TransactionType(string NoMelk, string TransactionType)
        {
            items = db.MelkKhAp.Where(x => x.Forosh_ejare_kharid == TransactionType && x.NoMelk == NoMelk ).ToList();
            return items;

        }
        public List<Melk_Kh_Ap> Find_By_FullName(string Name)
        {
            items = db.MelkKhAp.Where(x => x.FullName == Name).ToList();
            return items;
        }
        public List<Melk_Kh_Ap> Get_All_customers()
        {
            var items = db.MelkKhAp.Where(x => x.NoUser == "متقاضی").ToList();
            return items;
        }

        public List<Melk_Kh_Ap> Get_orders_Customer(BL.Entity.Melk_Kh_Ap Melk)
        {
            string NoUser = Melk.NoUser == "صاحب ملک" ? "متقاضی" : "صاحب ملک";

            List<Melk_Kh_Ap> items;
            items = db.MelkKhAp.Where(x => x.Mahdode == Melk.Mahdode && x.Mojod == true && x.NoMelk == Melk.NoMelk&&x.NoUser==NoUser ).ToList();
            if (Melk.Forosh_ejare_kharid == "خرید")
            {
                
                items = items.Where(x => x.Forosh_ejare_kharid == "فروش").ToList();
            }
            if (Melk.Forosh_ejare_kharid == "فروش")
            {
                items = items.Where(x => x.Forosh_ejare_kharid == "خرید").ToList();
            }
            if (Melk.Forosh_ejare_kharid == "اجاره")
            {
                items = items.Where(x => x.Forosh_ejare_kharid == "اجاره").ToList();
            }
            if (Melk.Tabaghe != null)
            {
                items = items.Where(x => x.Tabaghe == Melk.Tabaghe).ToList();
            }

            if (Melk.TedadVahed != null)
            {
                items = items.Where(x => x.TedadVahed == Melk.TedadVahed).ToList();
            }


            if (Melk.TedadKhab != null)
            {
                items = items.Where(x => x.TedadKhab >= Melk.TedadKhab).ToList();
            }
            if (Melk.Ejare != null)
            {
              
                    var ejare = Melk.Ejare.Split(',');
                    items = items.Where(x => x.Ejare.StartsWith(ejare[0])).ToList();
              


            }

            if (Melk.Gheymat_kol != "")
            {
                items = items.Where(x => x.Gheymat_kol.StartsWith(Melk.Gheymat_kol)).ToList();

            }
            if (Melk.Rahn != null)
            {
                if (Melk.Rahn.Contains(','))
                {
                    var rahn = Melk.Rahn.Split(',');
                    items = items.Where(x => x.Rahn.StartsWith(rahn[0])).ToList();

                }
                else
                {
                    items = items.Where(x => x.Rahn.StartsWith(Melk.Rahn)).ToList();
                }

            }
            if (Melk.Metraj != null)
            {
                items = items.Where(x => x.Metraj < Melk.Metraj + 1000 && x.Metraj > Melk.Metraj - 500).ToList();

            }
            if (Melk.PosheshKaf != null)
            {
                items = items.Where(x => x.PosheshKaf == Melk.PosheshKaf).ToList();
            }
            if (Melk.SystemGarmayesh != null)
            {
                items = items.Where(x => x.SystemGarmayesh == Melk.SystemGarmayesh).ToList();
            }
            if (Melk.SystemSarmayesh != null)
            {
                items = items.Where(x => x.SystemSarmayesh == Melk.SystemSarmayesh).ToList();

            }

            if (Melk.Anbari != null)
            {
                items = items.Where(x => x.Anbari == Melk.Anbari).ToList();

            }

            if (Melk.Asansor != null)
            {
                items = items.Where(x => x.Asansor == Melk.Asansor).ToList();

            }

            if (Melk.GhabelTabdil != null)
            {
                items = items.Where(x => x.GhabelTabdil == Melk.GhabelTabdil).ToList();
            }

            if (Melk.Kabinet != null)
            {
                items = items.Where(x => x.Kabinet == Melk.Kabinet).ToList();
            }

            if (Melk.Sanad != null)
            {
                items = items.Where(x => x.Sanad == Melk.Sanad).ToList();
            }

            if (Melk.Teras != null)
            {
                items = items.Where(x => x.Teras == Melk.Teras).ToList();
            }


            return items;
        }
    }
}