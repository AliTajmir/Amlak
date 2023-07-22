using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace BL.Entity
{
    public class Melk_Kh_Ap
    {
        public Melk_Kh_Ap()
        {

        }
        public Melk_Kh_Ap(string _Rahn, string _Ejare,string _Gheymat_kol, string _Forosh_ejare_kharid, string _Malek, int _Metraj, int _TedadKhab, string _Tabaghe, bool? _Asansor, string _PosheshKaf, string _SystemGarmayesh, string _SystemSarmayesh, bool? _Sanad, string _SaleSakht, bool? _Teras, bool? _Kabinet, string _JahatAparteman, bool? _Anbari, bool? _GhabelTabdil, string _TarikhTahvil, string _Telephone, string _TarikhSabt, int _TedadVahed, string _Adress, string _Shomali_Jonobi, string _Mahdode, string _NoUser, string _NoMelk,string _Tozihat,bool _Mojod)
        {
            this.Adress = _Adress;
            this.Anbari = _Anbari;
            this.Asansor = _Asansor;
            this.Ejare = _Ejare;
            this.GhabelTabdil = _GhabelTabdil;
            this.JahatAparteman = _JahatAparteman;
            this.Kabinet = _Kabinet;
            this.Mahdode = _Mahdode;
            this.FullName = _Malek;
            this.Metraj = _Metraj;
            this.NoMelk = _NoMelk;
            this.NoUser = _NoUser;
            this.PosheshKaf = _PosheshKaf;
            this.Rahn = _Rahn;
            this.SaleSakht = _SaleSakht;
            this.Sanad = _Sanad;
            this.Shomali_Jonobi = _Shomali_Jonobi;
            this.SystemGarmayesh = _SystemGarmayesh;
            this.SystemSarmayesh = _SystemSarmayesh;
            this.Tabaghe = _Tabaghe;
            this.TarikhSabt = _TarikhSabt;
            this.TarikhTahvil = _TarikhTahvil;
            this.TedadKhab = _TedadKhab;
            this.TedadVahed = _TedadVahed;
            this.Telephone = _Telephone;
            this.Teras = _Teras;
            this.Forosh_ejare_kharid = _Forosh_ejare_kharid;
            this.Gheymat_kol = _Gheymat_kol;
            this.Tozihat = _Tozihat;
            this.Mojod = _Mojod;
        }
        public Melk_Kh_Ap(string _Rahn, string _Ejare, string _Gheymat_kol, string _Forosh_ejare_kharid, string _Malek, int _Metraj, int _TedadKhab, string _Tabaghe, bool? _Asansor, string _PosheshKaf, string _SystemGarmayesh, string _SystemSarmayesh, bool? _Sanad, string _SaleSakht, bool? _Teras, bool? _Kabinet, string _JahatAparteman, bool? _Anbari, bool? _GhabelTabdil, string _TarikhTahvil, string _Telephone, string _TarikhSabt, string _Adress, string _Shomali_Jonobi, string _Mahdode, string _NoUser, string _NoMelk, string _Tozihat,bool _Mojod)
        {
            this.Adress = _Adress;
            this.Anbari = _Anbari;
            this.Asansor = _Asansor;
            this.Ejare = _Ejare;
            this.GhabelTabdil = _GhabelTabdil;
            this.JahatAparteman = _JahatAparteman;
            this.Kabinet = _Kabinet;
            this.Mahdode = _Mahdode;
            this.FullName = _Malek;
            this.Metraj = _Metraj;
            this.NoMelk = _NoMelk;
            this.NoUser = _NoUser;
            this.PosheshKaf = _PosheshKaf;
            this.Rahn = _Rahn;
            this.SaleSakht = _SaleSakht;
            this.Sanad = _Sanad;
            this.Shomali_Jonobi = _Shomali_Jonobi;
            this.SystemGarmayesh = _SystemGarmayesh;
            this.SystemSarmayesh = _SystemSarmayesh;
            this.Tabaghe = _Tabaghe;
            this.TarikhSabt = _TarikhSabt;
            this.TarikhTahvil = _TarikhTahvil;
            this.TedadKhab = _TedadKhab;
            this.Telephone = _Telephone;
            this.Teras = _Teras;
            this.Forosh_ejare_kharid = _Forosh_ejare_kharid;
            this.Gheymat_kol = _Gheymat_kol;
            this.Tozihat = _Tozihat;
            this.Mojod = _Mojod;
        }
        [Key]
        public int ID
        {
            get;
            set;

        }
        public string NoUser
        {
            get;
            set;

        }
        public string Forosh_ejare_kharid
        {
            get;
            set;

        }

        public string NoMelk
        {
            get;
            set;

        }
        public string FullName
        {
            get;
            set;

        }
        public string Rahn
        {
            get;
            set;
        }

        public string Ejare
        {
            get;
            set;
           
        }

       

        public int? Metraj
        {
            get;
            set;
           
        }

        public int? TedadKhab
        {
            get;
            set;
           
        }

        public string Tabaghe
        {
            get;
            set;
           
        }

        

        public string PosheshKaf
        {
            get;
            set;
            
        }

        public string SystemGarmayesh
        {
            get;
            set;
            
        }

        public string SystemSarmayesh
        {
            get;
            set;
            
        }
       

        public string SaleSakht
        {
            get;
            set;
            
        }
        public bool? Asansor
        {
            get;
            set;

        }
        public bool? Sanad
        {
            get;
            set;

        }
        public bool? Teras
        {
            get;
            set;
           
        }

        public bool? Kabinet
        {
            get;
            set;
            
        }
        public bool? Anbari
        {
            get;
            set;

        }

        public bool? GhabelTabdil
        {
            get;
            set;

        }
        public string JahatAparteman
        {
            get;
            set;
            
        }

    

        public string TarikhTahvil
        {
            get;
            set;
           
        }

        public string Telephone
        {
            get;
            set;
            
        }

        public string TarikhSabt
        {
            get;
            set;
           
        }

        public int? TedadVahed
        {
            get;
            set;
           
        }

        public string Adress
        {
            get;
            set;
           
        }

        public string Shomali_Jonobi
        {
            get;
            set;
            
        }

        public string Mahdode
        {
            get;
            set;
            
        }

       

        public string SeenID
        {
            get;
            set;
            
        }

        public string Tozihat
        {
            get;
            set;
           
        }
        public string Gheymat_kol
        {
            get;
            set;

        }
        public bool Mojod
        {
            get;
            set;

        }
    }


}