using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=elementler.accdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand komut = new OleDbCommand();
        DataSet ds = new DataSet();

        private void Form1_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            da = new OleDbDataAdapter("select * from tabloelement order by sirano", baglanti);
            da.Fill(ds, "tablo");
            for (int i = 0; i < ds.Tables["tablo"].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables["tablo"].Rows[i]["ElementAdi"].ToString());  
            }
            baglanti.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
                Form2 form2 = new Form2();
                form2.Show();
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            DialogResult cevap;
            cevap = MessageBox.Show("Çıkmak istediğinizden emin misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (cevap == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Form9 form9 = new Form9();
            form9.Show();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true)
            {
                SoundPlayer player = new SoundPlayer();
                string path = "ses.wav";
                player.SoundLocation = path;
                player.Play();
            }
            if (checkBox1.Checked == false)
            {
                SoundPlayer player = new SoundPlayer();
                player.Stop();
            }
        }
             private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
             {
                baglanti.Open();
                ds.Clear();
                string el_adi = comboBox1.Text;
                da = new OleDbDataAdapter("select * from tabloelement where ElementAdi='" + el_adi + "'", baglanti);
                da.Fill(ds, "tablo");
                label2.Text ="Görünümü "+ ds.Tables["tablo"].Rows[0]["Fiziksel1"].ToString();
                label3.Text = ds.Tables["tablo"].Rows[0]["Fiziksel2"].ToString();
                label4.Text = ds.Tables["tablo"].Rows[0]["Fiziksel3"].ToString();
                label5.Text = ds.Tables["tablo"].Rows[0]["Kim1"].ToString();
                label6.Text = ds.Tables["tablo"].Rows[0]["Kim2"].ToString();
                label7.Text = "Atom ağırlığı "+ds.Tables["tablo"].Rows[0]["Kim3"].ToString();
                label8.Text = "Yoğunluğu "+ds.Tables["tablo"].Rows[0]["Kim4"].ToString();
                label9.Text = ds.Tables["tablo"].Rows[0]["Grup"].ToString();
                label10.Text = ds.Tables["tablo"].Rows[0]["Periyot"].ToString();
                label11.Text = ds.Tables["tablo"].Rows[0]["Blok"].ToString();
                label12.Text = ds.Tables["tablo"].Rows[0]["Kul1"].ToString();
                label13.Text = ds.Tables["tablo"].Rows[0]["Kul2"].ToString();
                label14.Text = ds.Tables["tablo"].Rows[0]["Kul3"].ToString();
                label15.Text = "Atom Numarası";
                label16.Text = ds.Tables["tablo"].Rows[0]["AtomNumarasi"].ToString();
                label17.Text = "Simgesi";
                label18.Text = ds.Tables["tablo"].Rows[0]["Simgesi"].ToString();
                baglanti.Close();

                switch(comboBox1.Text)
                {
                    case "Lityum":
                        pictureBox2.ImageLocation="lityum.jpg";
                        break;
                    case "Berilyum":
                        pictureBox2.ImageLocation="berilyum.jpg";
                        break;
                    case "Bor":
                        pictureBox2.ImageLocation="bor.jpg";
                        break;
                    case "Karbon":
                        pictureBox2.ImageLocation="karbon.jpg";
                        break;
                    case "Sodyum":
                        pictureBox2.ImageLocation="sodyum.jpg";
                        break;
                    case "Magnezyum":
                        pictureBox2.ImageLocation="magnezyum.jpg";
                        break;
                    case "Alüminyum":
                        pictureBox2.ImageLocation="alüminyum.jpg";
                        break;
                    case "Silisyum":
                        pictureBox2.ImageLocation="silisyum.jpg";
                        break;
                    case "Fosfor":
                        pictureBox2.ImageLocation="fosfor.jpg";
                        break;
                    case "Kükürt":
                        pictureBox2.ImageLocation="kükürt.jpg";
                        break;
                    case "Potasyum":
                        pictureBox2.ImageLocation="potasyum.jpg";
                        break;
                    case "Kalsiyum":
                        pictureBox2.ImageLocation="kalsiyum.jpg";
                        break;
                    case "Skandiyum":
                        pictureBox2.ImageLocation = "skandiyum.jpg";
                        break;
                    case "Titanyum":
                        pictureBox2.ImageLocation = "titanyum.jpg";
                        break;
                    case "Vanadyum":
                        pictureBox2.ImageLocation = "vanadyum.jpg";
                        break;
                    case "Krom":
                        pictureBox2.ImageLocation = "krom.jpg";
                        break;
                    case "Mangan":
                        pictureBox2.ImageLocation = "mangan.jpg";
                        break;
                    case "Demir":
                        pictureBox2.ImageLocation = "demir.jpg";
                        break;
                    case "Kobalt":
                        pictureBox2.ImageLocation = "kobalt.jpg";
                        break;
                    case "Nikel":
                        pictureBox2.ImageLocation = "nikel.jpg";
                        break;
                    case "Bakır":
                        pictureBox2.ImageLocation = "bakir.jpg";
                        break;
                    case "Çinko":
                        pictureBox2.ImageLocation = "çinko.jpg";
                        break;
                    case "Galyum":
                        pictureBox2.ImageLocation = "galyum.jpg";
                        break;
                    case "Germanyum":
                        pictureBox2.ImageLocation = "germanyum.jpg";
                        break;
                    case "Hidrojen":
                        pictureBox2.ImageLocation = "hidrojen.jpg";
                        break;
                    case "Helyum":
                        pictureBox2.ImageLocation = "helyum.jpg";
                        break;
                    case "Azot":
                        pictureBox2.ImageLocation = "azot.jpg";
                        break;
                    case "Oksijen":
                        pictureBox2.ImageLocation = "oksijen.jpg";
                        break;
                    case "Flor":
                        pictureBox2.ImageLocation = "flor.jpg";
                        break;
                    case "Neon":
                        pictureBox2.ImageLocation = "neon.jpg";
                        break;
                    case "Klor":
                        pictureBox2.ImageLocation = "klor.jpg";
                        break;
                    case "Argon":
                        pictureBox2.ImageLocation = "argon.jpg";
                        break;
                    case "Arsenik":
                        pictureBox2.ImageLocation = "arsenik.jpg";
                        break;
                    case "Selenyum":
                        pictureBox2.ImageLocation = "selenyum.jpg";
                        break;
                    case "Brom":
                        pictureBox2.ImageLocation = "brom.jpg";
                        break;
                    case "Kripton":
                        pictureBox2.ImageLocation = "kripton.jpg";
                        break;
                    case "Rubidyum":
                        pictureBox2.ImageLocation = "rubidyum.jpg";
                        break;
                    case "Stronsiyum":
                        pictureBox2.ImageLocation = "stronsiyum.jpg";
                        break;
                    case "İtriyum":
                        pictureBox2.ImageLocation = "itriyum.jpg";
                        break;
                    case "Zirkonyum":
                        pictureBox2.ImageLocation = "zirkonyum.jpg";
                        break;
                    case "Niobyum":
                        pictureBox2.ImageLocation = "niobyum.jpg";
                        break;
                    case "Molibden":
                        pictureBox2.ImageLocation = "molibden.jpg";
                        break;
                    case "Teknesyum":
                        pictureBox2.ImageLocation = "teknesyum.jpg";
                        break;
                    case "Rutenyum":
                        pictureBox2.ImageLocation = "rutenyum.jpg";
                        break;
                    case "Rodyum":
                        pictureBox2.ImageLocation = "rodyum.jpg";
                        break;
                    case "Paladyum":
                        pictureBox2.ImageLocation = "paladyum.jpg";
                        break;
                    case "Gümüş":
                        pictureBox2.ImageLocation = "gümüs.jpg";
                        break;
                    case "Kadmiyum":
                        pictureBox2.ImageLocation = "kadmiyum.jpg";
                        break;
                    case "İndiyum":
                        pictureBox2.ImageLocation = "indiyum.jpg";
                        break;
                    case "Kalay":
                        pictureBox2.ImageLocation = "kalay.jpg";
                        break;
                    case "Antimon":
                        pictureBox2.ImageLocation = "antimon.jpg";
                        break;
                    case "Tellür":
                        pictureBox2.ImageLocation = "tellür.jpg";
                        break;
                    case "İyot":
                        pictureBox2.ImageLocation = "iyot.jpg";
                        break;
                    case "Ksenon":
                        pictureBox2.ImageLocation = "ksenon.jpg";
                        break;
                    case "Sezyum":
                        pictureBox2.ImageLocation = "sezyum.jpg";
                        break;
                    case "Baryum":
                        pictureBox2.ImageLocation = "baryum.jpg";
                        break;
                    case "Lantan":
                        pictureBox2.ImageLocation = "lantan.jpg";
                        break;
                    case "Seryum":
                        pictureBox2.ImageLocation = "seryum.jpg";
                        break;
                    case "Praseodim":
                        pictureBox2.ImageLocation = "praseodim.jpg";
                        break;
                    case "Neodimyum":
                        pictureBox2.ImageLocation = "neodimyum.jpg";
                        break;
                    case "Prometyum":
                        pictureBox2.ImageLocation = "prometyum.jpg";
                        break;
                    case "Samaryum":
                        pictureBox2.ImageLocation = "samaryum.jpg";
                        break;
                    case "Evropiyum":
                        pictureBox2.ImageLocation = "evropiyum.jpg";
                        break;
                    case "Gadolinyum":
                        pictureBox2.ImageLocation = "gadolinyum.jpg";
                        break;
                    case "Terbiyum":
                        pictureBox2.ImageLocation = "terbiyum.jpg";
                        break;
                    case "Disprozyum":
                        pictureBox2.ImageLocation = "disprozyum.jpg";
                        break;
                    case "Holmiyum":
                        pictureBox2.ImageLocation = "holmiyum.jpg";
                        break;
                    case "Erbiyum":
                        pictureBox2.ImageLocation = "erbiyum.jpg";
                        break;
                    case "Tulyum":
                        pictureBox2.ImageLocation = "tulyum.jpg";
                        break;
                    case "İterbiyum":
                        pictureBox2.ImageLocation = "iterbiyum.jpg";
                        break;
                    case "Lutesyum":
                        pictureBox2.ImageLocation = "lutesyum.jpg";
                        break;
                    case "Hafniyum":
                        pictureBox2.ImageLocation = "hafniyum.jpg";
                        break;
                    case "Tantal":
                        pictureBox2.ImageLocation = "tantal.jpg";
                        break;
                    case "Volfram":
                        pictureBox2.ImageLocation = "volfram.jpg";
                        break;
                    case "Renyum":
                        pictureBox2.ImageLocation = "renyum.jpg";
                        break;
                    case "Osmiyum":
                        pictureBox2.ImageLocation = "osmiyum.jpg";
                        break;
                    case "İridyum":
                        pictureBox2.ImageLocation = "iridyum.jpg";
                        break;
                    case "Platin":
                        pictureBox2.ImageLocation = "platin.jpg";
                        break;
                    case "Altın":
                        pictureBox2.ImageLocation = "altin.jpg";
                        break;
                    case "Cıva":
                        pictureBox2.ImageLocation = "civa.jpg";
                        break;
                    case "Talyum":
                        pictureBox2.ImageLocation = "talyum.jpg";
                        break;
                    case "Kurşun":
                        pictureBox2.ImageLocation = "kursun.jpg";
                        break;
                    case "Bizmut":
                        pictureBox2.ImageLocation = "bizmut.jpg";
                        break;
                    case "Polonyum":
                        pictureBox2.ImageLocation = "polonyum.jpg";
                        break;
                    case "Astatin":
                        pictureBox2.ImageLocation = "astatin.jpg";
                        break;
                    case "Radon":
                        pictureBox2.ImageLocation = "radon.jpg";
                        break;
                    case "Fransiyum":
                        pictureBox2.ImageLocation = "fransiyum.jpg";
                        break;
                    case "Radyum":
                        pictureBox2.ImageLocation = "radyum.jpg";
                        break;
                    case "Aktinyum":
                        pictureBox2.ImageLocation = "aktinyum.jpg";
                        break;
                    case "Toryum":
                        pictureBox2.ImageLocation = "toryum.jpg";
                        break;
                    case "Protaktinyum":
                        pictureBox2.ImageLocation = "protaktinyum.jpg";
                        break;
                    case "Uranyum":
                        pictureBox2.ImageLocation = "uranyum.jpg";
                        break;
                    case "Neptünyum":
                        pictureBox2.ImageLocation = "neptünyum.jpg";
                        break;
                    case "Plütonyum":
                        pictureBox2.ImageLocation = "plütonyum.jpg";
                        break;
                    case "Amerikyum":
                        pictureBox2.ImageLocation = "amerikyum.jpg";
                        break;
                    case "Küriyum":
                        pictureBox2.ImageLocation = "küriyum.jpg";
                        break;
                    case "Berkelyum":
                        pictureBox2.ImageLocation = "berkelyum.jpg";
                        break;
                    case "Kaliforniyum":
                        pictureBox2.ImageLocation = "kaliforniyum.jpg";
                        break;
                    case "Aynştaynyum":
                        pictureBox2.ImageLocation = "aynstaynyum.jpg";
                        break;
                    case "Fermiyum":
                        pictureBox2.ImageLocation = "fermiyum.jpg";
                        break;
                    case "Mendelevyum":
                        pictureBox2.ImageLocation = "mendelevyum.jpg";
                        break;
                    case "Nobelyum":
                        pictureBox2.ImageLocation = "nobelyum.jpg";
                        break;
                    case "Lavrensiyum":
                        pictureBox2.ImageLocation = "lavrensiyum.jpg";
                        break;
                    case "Rutherfordiyum":
                        pictureBox2.ImageLocation = "rutherfordiyum.jpg";
                        break;
                    case "Dubniyum":
                        pictureBox2.ImageLocation = "dubniyum.jpg";
                        break;
                    case "Seaborgiyum":
                        pictureBox2.ImageLocation = "seaborgiyum.jpg";
                        break;
                    case "Bohriyum":
                        pictureBox2.ImageLocation = "bohriyum.jpg";
                        break;
                    case "Hassiyum":
                        pictureBox2.ImageLocation = "hassiyum.jpg";
                        break;
                    case "Meitneriyum":
                        pictureBox2.ImageLocation = "meitneriyum.jpg";
                        break;
                    case "Darmstadtiyum":
                        pictureBox2.ImageLocation = "darmstadtiyum.jpg";
                        break;
                    case "Röntgenyum":
                        pictureBox2.ImageLocation = "röntgenyum.jpg";
                        break;
                    case "Kopernikyum":
                        pictureBox2.ImageLocation = "kopernikyum.jpg";
                        break;
                    case "Ununtriyum":
                        pictureBox2.ImageLocation = "ununtriyum.jpg";
                        break;
                    case "Flerovyum":
                        pictureBox2.ImageLocation = "flerovyum.jpg";
                        break;
                    case "Ununpentiyum":
                        pictureBox2.ImageLocation = "ununpentiyum.jpg";
                        break;
                    case "Livermoryum":
                        pictureBox2.ImageLocation = "livermoryum.jpg";
                        break;
                    case "Ununseptiyum":
                        pictureBox2.ImageLocation = "ununseptiyum.jpg";
                        break;
                    case "Ununoktiyum":
                        pictureBox2.ImageLocation = "ununoktiyum.jpg";
                        break;
                    
                    default:
                        pictureBox2.ImageLocation = null;
                        break;
                }
            }
        }
    }


