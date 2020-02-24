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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public void ThoiKhoaBieu(object obj)
        {
            List<Subject> lst = (List<Subject>)obj;

            for(int i = 0; i < 12; i++)
            {
                dataGridView1.Rows.Add();
            }

            for (int i = 0 ; i < lst.Count; i ++)
            {
                lst[i].Day_Of_Week = lst[i].Stt_TKB / 12;
                lst[i].Stt_TKB = lst[i].Stt_TKB % 12;
            }

            
            foreach(Subject item in lst)
            {
                int ij = 0;
                Object a  =  dataGridView1.Rows[ij].Cells[item.Day_Of_Week].Value;
              
                    if (a == null)
                    {
                        dataGridView1.Rows[ij].Cells[item.Day_Of_Week].Value = String.Format("{0} ({1} đến {2} )", item.TEN_MON_HOC, item.Stt_TKB, item.Stt_TKB + item.SO_TIET_HOC - 1);
                    }
                    else
                    {
                         ij++;
                         a = dataGridView1.Rows[ij].Cells[item.Day_Of_Week].Value;
                         
                         while (a != null)
                         {
                            ij++;
                            a = dataGridView1.Rows[ij].Cells[item.Day_Of_Week].Value;
                         }

                        dataGridView1.Rows[ij].Cells[item.Day_Of_Week].Value = String.Format("{0} ({1} đến {2})", item.TEN_MON_HOC, item.Stt_TKB, item.Stt_TKB + item.SO_TIET_HOC - 1);



                }
            }
            
        }

       
    }
}
