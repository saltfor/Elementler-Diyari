using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsFormsApplication1
{
    public partial class Form9 : Form
    {
        public Form9()
        {
            InitializeComponent();
        }

        OleDbConnection baglanti = new OleDbConnection("provider=microsoft.ace.oledb.12.0;data source=elementler.accdb");
        OleDbDataAdapter da = new OleDbDataAdapter();
        OleDbCommand komut = new OleDbCommand();
        DataSet ds = new DataSet();

        private void Form9_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            da = new OleDbDataAdapter("select * from tabloelement order by sirano", baglanti);
            da.Fill(ds, "tablo");
            for (int i = 0; i < ds.Tables["tablo"].Rows.Count; i++)
            {
                comboBox1.Items.Add(ds.Tables["tablo"].Rows[i]["AtomNumarasi"].ToString());
            }
            baglanti.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.ActiveForm.Hide();
            Form9 frm9 = new Form9(); 
            
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            baglanti.Open();
            ds.Clear();
            int el_adi = Convert.ToInt32(comboBox1.Text);
            da = new OleDbDataAdapter("select * from tabloelement where AtomNumarasi='" + el_adi + "'", baglanti);
            da.Fill(ds, "tablo");
            label3.Text = ds.Tables["tablo"].Rows[0]["ElementAdi"].ToString();
            baglanti.Close();


            
        }
    }
}
