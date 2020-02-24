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
    public partial class Form3 : Form
    {
        Form1 f1;
        public Form3(Form1 f)
        {
            InitializeComponent();
            f1 = f;

        }

        

        public void Create_Table()
        {
            for(int i = 0; i < 11;i++)
            {
                dataGridView1.Rows.Add();
            }

            for(int i = 0 ; i < 12; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = i + 1;
            }
          
        }

        private void button1_Click(object sender, EventArgs e)
        {

            List<bool> lst_Cus = new List<bool>();
            for(int i = 0; i < 5 ; i++)
            {
                for(int ij = 0; ij < 12; ij++)
                {
                    if (dataGridView1.Rows[ij].Cells[i+1].Value == null)
                    {
                        lst_Cus.Add(false);
                    }
                    else if ((bool)dataGridView1.Rows[ij].Cells[i+1].Value == false)
                    {
                        lst_Cus.Add(false);
                    }
                    else
                    {
                        lst_Cus.Add(true);
                    }
                }             
            }
           
            f1.Create_lst_Cus(lst_Cus);
            f1.Create_lst();
            List<Subject> tkb = (List<Subject>)f1.Try();


            Form2 f2 = new Form2();
            f2.ThoiKhoaBieu(tkb);

            f2.Show();


        }
    }
}
