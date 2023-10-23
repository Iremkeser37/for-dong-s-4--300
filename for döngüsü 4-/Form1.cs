using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace for_döngüsü_4_
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnYaz_Click(object sender, EventArgs e)
        {
            lbSayılar.Items.Clear();

            int bitis = Convert.ToInt32(txtBitis.Text);
            int baslangic = Convert.ToInt32(txtBaslangic.Text);

            for (int i = baslangic; i <= bitis; i++  )
            {
                lbSayılar.Items.Add(i);
            }
            

            
        }
    }
}
