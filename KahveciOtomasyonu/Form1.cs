using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RabiaKandemir_EylemSayin_UygulamaSinavi
{
    public partial class Form1 : Form
    {
        //Employee(personel) classından liste oluşturduk.
        public static List<Employee> WorkingStaff = new List<Employee>();// Çalışan personel
        public static List<Employee> FreeStaff = new List<Employee>();// Boşta duran personel

        int TotalTimer1 = 0;
        int TotalTimer2 = 0;
        int TotalTimer3 = 0;
        int TotalTimer4 = 0;
        //Personel classında çalışan tanımladık.
        Employee barista1 = new Employee("Rabia", true);
        Employee barista2 = new Employee("Eylem", true);
        Employee barista3 = new Employee("Büşra", true);
        Employee barista4 = new Employee("Büşranur", true);
        //İçeceklerimizi listeledik.
        public static List<Icecekler> Icecekler = new List<Icecekler>()
        {
            new Icecekler(){IcecekAdi="Latte",IcecekFiyati=29.00M ,HazirlanmaSuresi=10},
            new Icecekler(){IcecekAdi="Flat White",IcecekFiyati=35.00M,HazirlanmaSuresi=15},
            new Icecekler(){IcecekAdi="Espresso",IcecekFiyati=35.00M,HazirlanmaSuresi=10},
            new Icecekler(){IcecekAdi="Filtre Kahve",IcecekFiyati=25.00M,HazirlanmaSuresi=5},
            new Icecekler(){IcecekAdi="Caramel Macchiato",IcecekFiyati=40.00M,HazirlanmaSuresi=20},
            new Icecekler(){IcecekAdi="Cappuccino",IcecekFiyati=35.00M,HazirlanmaSuresi=5},
            new Icecekler(){IcecekAdi="Americano",IcecekFiyati=30.00M,HazirlanmaSuresi=5},
            new Icecekler(){IcecekAdi="Cold Brew",IcecekFiyati=30.00M,HazirlanmaSuresi=5}
        };
        //Ekstra malzemeleri listeledik.
        public static List<ExtraMalzemeler> ekstraMalzeme = new List<ExtraMalzemeler>()
        {
            new ExtraMalzemeler{ExtraMaterialName="Laktozsuz Süt", ExtraMalzemePrice=0.00M,ExtraTimer=1},
            new ExtraMalzemeler{ExtraMaterialName="Soya Sütü", ExtraMalzemePrice=6.50M,ExtraTimer=2},
            new ExtraMalzemeler{ExtraMaterialName="Badem Sütü", ExtraMalzemePrice=6.50M,ExtraTimer=3},
            new ExtraMalzemeler{ExtraMaterialName="Gingerbread Şurubu", ExtraMalzemePrice=4.50M,ExtraTimer=2},
            new ExtraMalzemeler{ExtraMaterialName="ToffeNut Şurubu", ExtraMalzemePrice=4.50M,ExtraTimer=2},
            new ExtraMalzemeler{ExtraMaterialName="Fındık Şurubu", ExtraMalzemePrice=4.50M,ExtraTimer=2},
            new ExtraMalzemeler{ExtraMaterialName="Vanilya Şurubu", ExtraMalzemePrice=4.50M,ExtraTimer=2},
            new ExtraMalzemeler{ExtraMaterialName="Karamel Şurubu", ExtraMalzemePrice=4.50M,ExtraTimer=2},
        };
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //İçeceklerimizi combobox'a ekledik.
            foreach (Icecekler icecek in Icecekler)
            {
                cmbIcecekler.Items.Add(icecek);
            }
            cmbIcecekler.SelectedIndex = 0;
            //Ekstra malzemeleri flowpanelimize checkboxla ekledik.
            foreach (ExtraMalzemeler item in ekstraMalzeme)
            {
                flpEkstralar.Controls.Add(new CheckBox() { AutoSize = false, Text = item.ExtraMaterialName, Tag = item, Width = Convert.ToInt32(flpEkstralar.Width * 0.45) });
            }
            //Oluşturulan baristalar,freestaff listemize ekledik.
            FreeStaff.Add(barista1);
            FreeStaff.Add(barista2);
            FreeStaff.Add(barista3);
            FreeStaff.Add(barista4);
        }

        //Butona basıldığında seçtiğimiz içecekler,boyutlar ve ekstra malzemeler listboxa eklenir.
        //Eklediğimiz ürünlerin fiyatını toplayıp toplam tutara yazdırdık.
        private void btnSiparişEkle_Click(object sender, EventArgs e)
        {
            if (FreeStaff.Count > 0)
            {
                List<ExtraMalzemeler> SelectedMaterials = new List<ExtraMalzemeler>();
                Orders newOrder = new Orders();
                newOrder.ChoosenDrinks = (Icecekler)cmbIcecekler.SelectedItem;
                if (rdoTall.Checked)
                    newOrder.DrinkSize = Boyut.Tall;
                else if (rdoGrande.Checked)
                    newOrder.DrinkSize = Boyut.Grande;
                else
                    newOrder.DrinkSize = Boyut.Venti;

                foreach (CheckBox item in flpEkstralar.Controls)
                {
                    if (item.Checked)
                    {
                        SelectedMaterials.Add((ExtraMalzemeler)item.Tag);
                    }
                }
                newOrder.ExtraMaterials = SelectedMaterials;
                newOrder.Count = (int)nmrAdetSayisi.Value;
                newOrder.Hesapla();

                lstSiparisler.Items.Add(newOrder);
                Calculate();

                if (TotalTimer1 == 0 || prb1.Value == 0)
                {
                    TotalTimer1 += (newOrder.ChoosenDrinks.HazirlanmaSuresi) * newOrder.Count;
                    foreach (var item in SelectedMaterials)
                    {
                        TotalTimer1 += item.ExtraTimer;
                    }
                }
                else if (TotalTimer2 == 0 || prb2.Value == 0)
                {
                    TotalTimer2 += (newOrder.ChoosenDrinks.HazirlanmaSuresi) * newOrder.Count;
                    foreach (var item in SelectedMaterials)
                    {
                        TotalTimer2 += item.ExtraTimer;
                    }
                }
                else if (TotalTimer3 == 0 || prb3.Value == 0)
                {
                    TotalTimer3 += (newOrder.ChoosenDrinks.HazirlanmaSuresi) * newOrder.Count;
                    foreach (var item in SelectedMaterials)
                    {
                        TotalTimer3 += item.ExtraTimer;
                    }
                }
                else if (TotalTimer4 == 0 || prb4.Value == 0)
                {
                    TotalTimer4 += (newOrder.ChoosenDrinks.HazirlanmaSuresi) * newOrder.Count;
                    foreach (var item in SelectedMaterials)
                    {
                        TotalTimer4 += item.ExtraTimer;
                    }
                }
                //Temizle metodu ile seçilenleri sildirdik.
                Temizle();
            }
            else if (FreeStaff.Count == 0)
            {
                MessageBox.Show("Şu an müsait personel kalmadı.", "Bilgi Ekranı", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public decimal Calculate()
        {
            decimal TotalCount = 0;
            for (int i = 0; i < lstSiparisler.Items.Count; i++)
            {
                Orders gelenSiparis = (Orders)lstSiparisler.Items[i];
                TotalCount += gelenSiparis.TotalPrice;
            }
            lblToplamTutar.Text = TotalCount.ToString();
            return TotalCount;

        }

        private void btnSiparisTamamla_Click(object sender, EventArgs e)
        {
            if (FreeStaff.Count > 0)
            {
                DialogResult dialogResult = MessageBox.Show($"Toplam tutar : {Calculate().ToString("c2")}\r\nSatın almayı tamamlamak istiyor musunuz ?", "Sipariş Bilgisi", MessageBoxButtons.YesNo, MessageBoxIcon.Information);

                if (dialogResult == DialogResult.Yes)
                {
                    lblToplamTutar.Text = "0.00₺";
                    lstSiparisler.Items.Clear();
                    if (prb1.Value == 0)
                    {
                        tmr1.Start();
                        barista1.IsFree = false;
                        WorkingStaff.Add(barista1);
                        FreeStaff.Remove(barista1);
                        txtBarista1.Text = $"Sipariş Hazırlanıyor... Hazırlanma Süresi : {TotalTimer1} Dakika.";
                        txtBarista1.BackColor = Color.Red;
                    }
                    else if (prb2.Value == 0)
                    {
                        tmr2.Start();
                        barista2.IsFree = false;
                        WorkingStaff.Add(barista2);
                        FreeStaff.Remove(barista2);
                        txtBarista2.Text = $"Sipariş Hazırlanıyor... Hazırlanma Süresi : {TotalTimer2} Dakika.";
                        txtBarista2.BackColor = Color.Red;
                    }
                    else if (prb3.Value == 0)
                    {
                        tmr3.Start();
                        barista3.IsFree = false;
                        WorkingStaff.Add(barista3);
                        FreeStaff.Remove(barista3);
                        txtBarista3.Text = $"Sipariş Hazırlanıyor... Hazırlanma Süresi : {TotalTimer3} Dakika.";
                        txtBarista3.BackColor = Color.Red;
                    }
                    else if (prb4.Value == 0)
                    {
                        tmr4.Start();
                        barista4.IsFree = false;
                        WorkingStaff.Add(barista4);
                        FreeStaff.Remove(barista4);
                        txtBarista4.Text = $"Sipariş Hazırlanıyor... Hazırlanma Süresi : {TotalTimer4} Dakika.";
                        txtBarista4.BackColor = Color.Red;
                    }
                }
            }
            else
            {
                MessageBox.Show("Şuan Uygun Personelimiz Yoktur. ", "Bilgilendirme", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        public void OrderCheckIt()
        {
            if (prb1.Value >= 100)
            {

                txtBarista1.BackColor = Color.Green;
                txtBarista1.Text = "BARİSTA MÜSAİT";
                FreeStaff.Add(barista1);
                WorkingStaff.Remove(barista1);
                txtBarista1.BackColor = Color.Red;

            }
            if (prb2.Value >= 100)
            {
                txtBarista2.BackColor = Color.Green;
                txtBarista2.Text = "BARİSTA MÜSAİT";
                FreeStaff.Add(barista2);
                WorkingStaff.Remove(barista2);
                txtBarista2.BackColor = Color.Red;
            }
            if (prb3.Value >= 100)
            {
                txtBarista3.BackColor = Color.Green;
                txtBarista3.Text = "BARİSTA MÜSAİT";
                FreeStaff.Add(barista3);
                WorkingStaff.Remove(barista3);
                txtBarista3.BackColor = Color.Red;
            }
            if (prb4.Value >= 100)
            {
                txtBarista4.BackColor = Color.Green;
                txtBarista4.Text = " BARİSTA MÜSAİT";
                FreeStaff.Add(barista4);
                WorkingStaff.Remove(barista4);
                txtBarista4.BackColor = Color.Red;
            }
        }

        private void tmr1_Tick(object sender, EventArgs e)
        {
            if (prb1.Value == prb1.Maximum || prb1.Value > prb1.Maximum)
            {
                tmr1.Stop();
                OrderCheckIt();
                TotalTimer1 = 0;
                prb1.Value = 0;
            }
            else if (prb1.Value != prb1.Maximum)
            {
                try
                {
                    prb1.Value += prb1.Maximum / TotalTimer1;
                }
                catch (Exception)
                {
                    prb1.Value = 100;
                }
            }
        }

        private void tmr3_Tick(object sender, EventArgs e)
        {
            if (prb3.Value == prb3.Maximum || prb3.Value > prb3.Maximum)
            {
                tmr3.Stop();
                OrderCheckIt();
                TotalTimer3 = 0;
                prb3.Value = 0;
            }
            else if (prb3.Value != prb3.Maximum)
            {
                try
                {
                    prb3.Value += prb3.Maximum / TotalTimer3;
                }
                catch (Exception)
                {
                    prb3.Value = 100;
                }
            }
        }

        private void tmr2_Tick(object sender, EventArgs e)
        {
            if (prb2.Value == prb2.Maximum || prb2.Value > prb2.Maximum)
            {
                tmr2.Stop();
                OrderCheckIt();
                TotalTimer2 = 0;
                prb2.Value = 0;
            }
            else if (prb2.Value != prb2.Maximum)
            {
                try
                {
                    prb2.Value += prb2.Maximum / TotalTimer2;
                }
                catch (Exception)
                {
                    prb2.Value = 100;
                }
            }
        }

        private void tmr4_Tick(object sender, EventArgs e)
        {
            if (prb4.Value == prb4.Maximum || prb4.Value > prb4.Maximum)
            {
                tmr4.Stop();
                OrderCheckIt();
                TotalTimer4 = 0;
                prb4.Value = 0;
            }
            else if (prb4.Value != prb4.Maximum)
            {
                try
                {
                    prb4.Value += prb4.Maximum / TotalTimer4;
                }
                catch (Exception)
                {
                    prb4.Value = 100;
                }
            }
        }
        private void Temizle()
        {
            cmbIcecekler.SelectedIndex = 0;
            rdoTall.Checked = true;
            rdoGrande.Checked = false;
            rdoVenti.Checked = false;
            foreach (CheckBox item in flpEkstralar.Controls)
            {
                item.Checked = false;
            }
            nmrAdetSayisi.Value = 1;
        }
    }
}

