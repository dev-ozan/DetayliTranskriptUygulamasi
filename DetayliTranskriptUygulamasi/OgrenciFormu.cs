using DetayliTranskriptUygulamasi.Concrete;
using DetayliTranskriptUygulamasi.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Intrinsics;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DetayliTranskriptUygulamasi
{


    public partial class OgrenciFormu : Form
    {
        TranskriptVeri x1;
        public OgrenciFormu(TranskriptVeri v1)
        {
            InitializeComponent();
            cmbDersDonem.Items.AddRange(Enum.GetNames(typeof(Donem)));
            cmbDonem.Items.AddRange(Enum.GetNames(typeof(Donem)));
            cmbDers.Items.Add(v1.Dersler);
            x1 = v1;




        }

        private void button6_Click(object sender, EventArgs e)
        {
            cmbDers.Items.Clear();
            Enum.TryParse(cmbDersDonem.SelectedItem.ToString(), out Donem X);
            Dersler d1 = new Dersler(txtDersAd.Text, Convert.ToInt32(txtDersKredi.Text), X);
            x1.Dersler.Add(d1);






        }

        private void button1_Click(object sender, EventArgs e)
        {
            cmbDers.Items.Clear();
            Ogrenci o1 = new Ogrenci(txtAd.Text, txtSoyad.Text, Convert.ToInt32(txtNot.Text), (Dersler)cmbDers.SelectedItem);
            x1.Ogrenciler.Add(o1);
            
        }

        private void cmbDonem_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDers.Items.Clear();
            foreach (Dersler item in x1.Dersler)
            {

                if (cmbDers.SelectedIndex == 0 )
                {
                    cmbDers.Items.Add( item.DersinDonemi.ToString());

                }

                else if (cmbDers.SelectedIndex == 1 && item.DersinDonemi == Donem.Bahar)
                    cmbDers.Items.Add(item.Ad);

            }
        }
    }
}
