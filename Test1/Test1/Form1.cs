using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Test1
{
    public partial class Form1 : Form
    {


        SortedDictionary<string, Subject> lstMonHoc;
        int tongSoTinChi;
        int tongSoMonHoc;
        public Form1()
        {
            InitializeComponent();
            lstMonHoc = new SortedDictionary<string,Subject>();
            tongSoTinChi = 0;
            tongSoMonHoc = 0;


        }

        // -------------------  YC_1 ---------------------

       

        private void Them_MonHoc_Click(object sender, EventArgs e)
        {
            string str = Stand_Str.Stand(textBox_MonHoc.Text);
            int TC = Convert.ToInt16(SoTinChi.Value);
            int So_tietHoc = Convert.ToInt16(So_Tiet.Value);

            if(str == "")
            {
                MessageBox.Show("Nhập Vào Tên Môn Học");
                return;
            }
            try
            {
                lstMonHoc.Add(str,new Subject(str,TC,So_tietHoc));
                Sum_TinChi.Text = ( tongSoTinChi += TC).ToString();
                Sum_MonHoc.Text =( tongSoMonHoc += 1).ToString();    
            }
            catch
            {
                MessageBox.Show("Tên Môn Học Bị Trùng !!!");
            }

            textBox_MonHoc.Text = "";


            //DataTable Table_MonHoc = new DataTable();

            //Table_MonHoc.Columns.Add(null,typeof(string));
            //Table_MonHoc.Columns.Add(null, typeof(int));
            //Table_MonHoc.Columns.Add(null, typeof(int));
            

            ICollection<Subject> Subjs = lstMonHoc.Values;
          
           

            for (int i = 0; i < Subjs.Count; i++)
            {
                DanhSachMonHoc.Rows.Add();
            }

            int ij = 0;
            foreach (Subject sub in Subjs)
            {
                DanhSachMonHoc.Rows[ij].Cells[0].Value = sub.TEN_MON_HOC;
                DanhSachMonHoc.Rows[ij].Cells[1].Value = sub.SO_TIN_CHI;
                DanhSachMonHoc.Rows[ij].Cells[2].Value = sub.SO_TIET_HOC;
                ij++;

              
            }
            
          

        }

        // ------------------------------- YC_2 ------------------------------------
        List<bool> lst_Cus = new List<bool>();
        List<Subject> lst_Subjs = new List<Subject>();
        List<Subject> TKB = new List<Subject>();
        int[] Arr_Index;
        int Tong_Tiet_Hoc = 60;
        int Dem = 0;
        int Min = 60;

        

        public void Create_lst_Cus(object obj)
        {
            lst_Cus = (List<bool>)obj;
        }

        private bool IS_Full()
        {
            foreach(Subject item in lst_Subjs)
            {
                if(item.Stt_TKB == 0)
                {
                    return false;
                }
            }

            return true;
        }

        private bool Checker(int N,int M)
        {
            int check = N % 6;
            if( 0 < check && M > check)
            {
                return true;
            }

            return false;
        }

        private bool Small_Check(int So_Tiet_Hoc)
        {
            try
            {
                for (int i = Dem; i < Dem + So_Tiet_Hoc; i++)
                {
                    if (lst_Cus[i] == true)
                    {
                        return false;
                    }
                }
            }
            catch
            {
                return false;
            }
            return true;
           
        }

        private int Big_Check( int So_Tiet_Hoc)
        {
            while(true)
            {
                if(Dem + So_Tiet_Hoc > Tong_Tiet_Hoc)
                {
                    break;
                }
                if(Small_Check(So_Tiet_Hoc))
                {
                    if(Checker(Dem + So_Tiet_Hoc,So_Tiet_Hoc))
                    {
                        int temp = Dem;
                        Dem = Dem + So_Tiet_Hoc - (Dem + So_Tiet_Hoc) % 6;
                        if(Small_Check(So_Tiet_Hoc))
                        {
                            return 1;
                        }
                        Dem = temp;
                    }
                    else
                    {
                        return 2;
                    }
                }

                Dem++;

            }
            return 0;
        }

       public object Try()
        {
          
                if(Dem >= Tong_Tiet_Hoc)
                {
                    return TKB;
                }
                else
                {
                    
                    for (int ij = 0; ij < lst_Subjs.Count; ij++)
                    {
                        if(Arr_Index[ij] != 0 )
                            {
                                    int temp = Dem;
                                 if (Big_Check(lst_Subjs[ij].SO_TIET_HOC)==1)
                                 {
                                   
                                    Dem = Dem + lst_Subjs[ij].SO_TIET_HOC - (Dem + lst_Subjs[ij].SO_TIET_HOC)%6;
                                    lst_Subjs[ij].Stt_TKB = Dem+1;
                                    Arr_Index[ij] = 0;
                                    Dem = Dem + lst_Subjs[ij].SO_TIET_HOC;
                                    if ( Dem  < Min && IS_Full())
                                    {
                                        Min = Dem;
                                        TKB.Clear();
                                        foreach (Subject sub in lst_Subjs)
                                        {
                                            TKB.Add(new Subject(sub.TEN_MON_HOC, sub.SO_TIET_HOC, sub.SO_TIN_CHI, sub.Stt_TKB));
                                        }

                                        lst_Subjs[ij].Stt_TKB = 0;
                                        Arr_Index[ij] = 1;
                                        Dem = temp;
                                        return TKB;
                                    }
                                     Try();
                                    lst_Subjs[ij].Stt_TKB = 0; 
                                    Arr_Index[ij] = 1;
                                    Dem = temp; 
                                  }
                               else
                                {
                                    lst_Subjs[ij].Stt_TKB = Dem + 1;
                                    Arr_Index[ij] = 0;
                                    Dem = lst_Subjs[ij].SO_TIET_HOC + Dem;
                                    if (Dem < Min && IS_Full())
                                    {
                                        Min = Dem;
                                        TKB.Clear();
                                        foreach (Subject sub in lst_Subjs)
                                        {
                                            TKB.Add(new Subject(sub.TEN_MON_HOC, sub.SO_TIET_HOC, sub.SO_TIN_CHI, sub.Stt_TKB));

                                        }

                                        lst_Subjs[ij].Stt_TKB = 0;
                                        Arr_Index[ij] = 1;
                                        Dem = temp;
                                        return TKB;
                                    }
                                     Try();
                                    Arr_Index[ij] = 1;
                                    lst_Subjs[ij].Stt_TKB = 0;
                                    Dem = temp;

                                }
                                
                             }                     
                    }
                }

            return TKB;
            
         }



        private void TaoThoiKhoaBieu_Click(object sender, EventArgs e)
        {

           
            ICollection<Subject> subjs = lstMonHoc.Values;
            Arr_Index = new int[subjs.Count];
          
            int ij = 0;
            foreach(Subject sub in subjs)
            {
                lst_Subjs.Add(sub);
                Arr_Index[ij] = 1;
                ij++;
            }

            for(int i = 0; i < 12*5; i++)
            {
                lst_Cus.Add(false);
            }

            //for(int i = 0; i < lst_Subjs.Count; i++)
            //{
            //    Arr_Index[i] = 0;
            //    int Index = Dem + lst_Subjs[i].SO_TIET_HOC;
            //    if(Index <= 6)
            //    {

            //        lst_Subjs[i].Stt_TKB = 1;
            //        Dem = Dem + lst_Subjs[i].SO_TIET_HOC;
            //    }
               Try();
            //    Arr_Index[i] = 1;
            //}

            Form2 f2 = new Form2();
            f2.ThoiKhoaBieu(TKB);

            
            f2.Show();
        }


        //--------------------------------- YC3 ----------------------------

       public void Create_lst()
        {
            ICollection<Subject> subjs = lstMonHoc.Values;
            Arr_Index = new int[subjs.Count];

            int ij = 0;
            foreach (Subject sub in subjs)
            {
                lst_Subjs.Add(sub);
                Arr_Index[ij] = 1;
                ij++;
            }
        }

        private void TKB_Cus_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(this);
            f3.Create_Table();
            f3.Show();

        }
    }
}
