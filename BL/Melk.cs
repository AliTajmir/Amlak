using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BL
{
    public class Melk
    {
        DAL.Melk melk;
        public Melk()
        {
            melk = new DAL.Melk();
        }
        public bool SabtMelk_Kh_Ap(BL.Entity.Melk_Kh_Ap Obj_Melk)
        {
          
            var result = melk.InsertMelk(Obj_Melk);
            return result;
        }

        public List<BL.Entity.Melk_Kh_Ap> GetAllList()
        {
            
            var items = melk.GetAllList();
            return items;
        }
        public bool CreateDatabase()
        {

            
            return melk.CreateDatabase();

        }
        public Entity.Melk_Kh_Ap Find_By_Id(int id)
        {
            var item=melk.Find_By_Id(id);
            return item;
        }
        public bool Delete(BL.Entity.Melk_Kh_Ap item)
        {
          bool result=melk.Delete(item);
            return result;

        }
        public bool update(BL.Entity.Melk_Kh_Ap item)
        {
            var result = melk.update(item);
            return result;
              
           
        }

        public List<BL.Entity.Melk_Kh_Ap> Find_By_TransactionType(string NoMelk, string TransactionType)
        {
          var items =melk.Find_By_TransactionType(NoMelk, TransactionType);
            return items;

        }
        public List<BL.Entity.Melk_Kh_Ap> Find_By_FullName(string Name)
        {
           var items = melk.Find_By_FullName(Name);
            return items;
        }
        public List<BL.Entity.Melk_Kh_Ap> Get_All_customers()
        {
            var items = melk.Get_All_customers();
            return items;
        }
        public List<BL.Entity.Melk_Kh_Ap> Get_orders_Customer(BL.Entity.Melk_Kh_Ap Melk)
        {

            var items = melk.Get_orders_Customer(Melk);
            return items;
        }
    }
}