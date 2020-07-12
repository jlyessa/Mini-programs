using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace GeekBrains
{
    public partial class Form1 : Form
    {
        int count = 0;
        Random rnd;
        char[] spec_chars = new char[] { '%', '$','&','^','*','_','-','#','@'};
        Dictionary<string, double> metrica;
        public Form1()
        {
            InitializeComponent();
            rnd = new Random();
            metrica = new Dictionary<string, double>();
            metrica.Add("mm", 1);
            metrica.Add("cm", 10);
            metrica.Add("dm", 100);
            metrica.Add("m", 1000);
            metrica.Add("km", 1000000);
            metrica.Add("mile", 1609344);
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Автор: Довгий А. М.", "О программе");
        }

        private void Plus_Click(object sender, EventArgs e)
        {
            count++;
            Result.Text = count.ToString();
        }

        private void Minus_Click(object sender, EventArgs e)
        {
            count--;
            Result.Text = count.ToString();
        }

        private void Zero_Click(object sender, EventArgs e)
        {
            count = 0;
            Result.Text = count.ToString();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void Result1_Click(object sender, EventArgs e)
        {

        }

        private void Gener_Click(object sender, EventArgs e)
        {
            int n;
            n = rnd.Next(Convert.ToInt32(Ot.Value), Convert.ToInt32(Do.Value)+1);
            Result1.Text = n.ToString();
            if (Powt.Checked)
            {
                if (NumRand.Text.IndexOf(n.ToString()) == -1) NumRand.AppendText(n + "\n");
            }
            else NumRand.AppendText(n + "\n");
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            NumRand.Clear();
        }

        private void Copy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(NumRand.Text);
        }

        private void Date_Click(object sender, EventArgs e)
        {
            NotePad.AppendText(DateTime.Now.ToShortDateString() + "\n");
        }

        private void Time_Click(object sender, EventArgs e)
        {
            NotePad.AppendText(DateTime.Now.ToShortTimeString() + "\n");
        }

        private void Save_Click(object sender, EventArgs e)
        {
            try
            {
                NotePad.SaveFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при созранении","Ошибка");
            }
        }

        private void Load_Click(object sender, EventArgs e)
        {
            try
            {
                NotePad.LoadFile("notepad.rtf");
            }
            catch
            {
                MessageBox.Show("Ошибка при загрузке", "Ошибка");
            }
        }

        private void BuildPas_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == 0) return;
            string pass = "";
            for(int i = 0; i < numericUpDown1.Value; i++)
            {
                int n = rnd.Next(0, checkedListBox1.CheckedItems.Count);
                string s = checkedListBox1.CheckedItems[n].ToString();
                switch(s)
                {
                    case "Цифры": pass += rnd.Next(10).ToString();
                        break;
                    case "Прописные буквы": pass += Convert.ToChar(rnd.Next(65,88));
                        break;
                    case "Строчные буквы":
                        pass += Convert.ToChar(rnd.Next(97, 122));
                        break;
                    default: pass += spec_chars[rnd.Next(spec_chars.Length)];
                        break;
                }
                tbPass.Text = pass;
            }
        }

        private void BCopy_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(tbPass.Text);
        }

        private void Ot_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bConvert_Click(object sender, EventArgs e)
        {
            double m1 = metrica[cbFrom.Text];
            double m2 = metrica[cbTo.Text];
            double n = Convert.ToDouble(tbFrom.Text);
            tbTo.Text = (n*m1/m2).ToString();
        }

        private void bSwap_Click(object sender, EventArgs e)
        {
            string t = cbFrom.Text;
            cbFrom.Text = cbTo.Text;
            cbTo.Text = t;
        }

        private void cbMetrics_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch(cbMetrics.Text)
            {
                case "длина":
                    metrica.Clear();
                    metrica.Add("mm", 1);
                    metrica.Add("cm", 10);
                    metrica.Add("dm", 100);
                    metrica.Add("m", 1000);
                    metrica.Add("km", 1000000);
                    metrica.Add("mile", 1609344);
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("mm");
                    cbFrom.Items.Add("cm");
                    cbFrom.Items.Add("dm");
                    cbFrom.Items.Add("m");
                    cbFrom.Items.Add("km");
                    cbFrom.Items.Add("mile");
                    cbTo.Items.Clear();
                    cbTo.Items.Add("mm");
                    cbTo.Items.Add("cm");
                    cbTo.Items.Add("dm");
                    cbTo.Items.Add("m");
                    cbTo.Items.Add("km");
                    cbTo.Items.Add("mile");
                    cbFrom.Text = "mm";
                    cbTo.Text = "mm";
                    break;
                case "вес":
                    metrica.Clear();
                    metrica.Add("g", 1);
                    metrica.Add("kg", 1000);
                    metrica.Add("t", 1000000);
                    metrica.Add("lb", 453.6);
                    metrica.Add("oz", 283);
                    cbFrom.Items.Clear();
                    cbFrom.Items.Add("g");
                    cbFrom.Items.Add("kg");
                    cbFrom.Items.Add("t");
                    cbFrom.Items.Add("lb");
                    cbFrom.Items.Add("oz");
                    cbTo.Items.Clear();
                    cbTo.Items.Add("g");
                    cbTo.Items.Add("kg");
                    cbTo.Items.Add("t");
                    cbTo.Items.Add("lb");
                    cbTo.Items.Add("oz");
                    cbFrom.Text = "g";
                    cbTo.Text = "g";
                    break;
            }
        }
    }
}
