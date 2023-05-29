using DetayliTranskriptUygulamasi.Concrete;

namespace DetayliTranskriptUygulamasi
{
    public partial class Form1 : Form

    {
        TranskriptVeri v1 = new TranskriptVeri();
        public Form1()
        {
            InitializeComponent();

        }

        private void btnOgrenciEkle_Click(object sender, EventArgs e)
        {

            new OgrenciFormu(v1).ShowDialog();


        }
        public Form1(TranskriptVeri v1)
        {
            this.v1 = v1;
        }
    }
}