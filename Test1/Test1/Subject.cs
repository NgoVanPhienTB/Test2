using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test1
{
    class Subject
    {
        private string TenMonHoc;
        private int SoTietHoc;
        private int SoTinChi;
        private int STT_TKB;
        private int DayofWeek;

        public Subject(string tenMonHoc, int soTietHoc , int soTinChi )
        {
            TenMonHoc = tenMonHoc;
            SoTietHoc = soTietHoc;
            SoTinChi = soTinChi;
            STT_TKB =0;
            DayofWeek = 0;
        }

        public Subject(string tenMonHoc, int soTietHoc, int soTinChi, int stt_tkb)
        {
            TenMonHoc = tenMonHoc;
            SoTietHoc = soTietHoc;
            SoTinChi = soTinChi;
            STT_TKB = stt_tkb;
            DayofWeek = 0;
        }

         public string TEN_MON_HOC
            {

               get{

                    return TenMonHoc;
                }
                
                set
                {
                     TenMonHoc = value;
                }

            }

        public int SO_TIN_CHI
        {
            get
            {
                return SoTinChi;
            }

            set
            {
                SoTinChi = value;
            }
        }


        public int SO_TIET_HOC
        {
            get
            {
                return SoTietHoc;
            }

            set
            {
                SoTietHoc = value;
            }
        }
          public int Stt_TKB
           {

            get
            {
                return STT_TKB;
            }
            set
            {
                STT_TKB = value;
            }
        }

        public int Day_Of_Week
        {
            get
            {
                return DayofWeek;
            }

            set
            {
                DayofWeek = value;
            }
        }

    }
}
