using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstMid
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
         int salary,count=0;
        double tax;
        double t1, t2,t3,t4;
        private void Calculate_Click(object sender, EventArgs e)
        {
            salary = Convert.ToInt32(this.textBox1.Text);
            if(salary>=0 && salary <= 300000)
            {
                tax = salary*0.01;
                this.lbl1.Text = "The tax on first slab is :" +tax +"\nThe total tax is :"+tax;
            }
            else if (salary>=300001 && salary <= 500000)
            {
                t1 = 300000 *0.01;
                salary = salary - 300000;
                t2 = salary *0.03;
                tax = t1 + t2;
                lbl1.Text= "The tax on first slab is :" + Convert.ToString(t1) + "\nThe tax on second slab is :" + Convert.ToString(t2) +"\nThe total tax is :" + tax;
               
            }
            else if(salary>=500001 && salary <= 800000)
            {
                t1 = 300000 * 0.01;
                t2 = 200000 * 0.03;
                salary = salary - 500000;
                t3 = salary * 0.05;
                tax = t1 + t2 + t3;
                lbl1.Text = "The tax on first slab is :" + Convert.ToString(t1) + "\nThe tax on second slab is :" + Convert.ToString(t2) + "\nThe tax on third slab is :" + Convert.ToString(t3) + "\nThe total tax is :" + tax;

            }
            else if (salary > 800000)
            {
                 t1 = 300000 *0.01;
                 t2 = 200000 *0.03;
                 t3 = 300000 *0.05;
                salary = salary - 800000;
                if (salary >0 &&  salary<200000)
                {
                    count += 0;
                }
                else
                {
                    while (salary >= 200000) {
                        count = count+1;
                        salary = salary - 200000;
                    }
                }
                MessageBox.Show("" +count);
                t4 = count*(200000 *0.02);
                tax = t1 + t2 + t3 + t4;
                lbl1.Text = "The tax on first slab is :" + Convert.ToString(t1) + "\nThe tax on second slab is :" + Convert.ToString(t2) + "\nThe tax on third slab is :" + Convert.ToString(t3) + "\nThe tax on fourth slab is :" + Convert.ToString(t4) +"\nThe total tax is :" + tax;

            }
        }
    }
}
