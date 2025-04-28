using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Uyg1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtGiris.Focus();
            lstİllerA.Items.Add("Adana");
            lstİllerA.Items.Add("Urfa");
            lstİllerA.Items.Add("Malatya");
            lstİllerA.Items.Add("Kocaeli");
            lstİllerA.Items.Add("İstanbul");
            lstİllerA.Items.Add("Eskişehir");
            lstİllerA.Items.Add("Sivas");
            lstİllerA.Items.Add("Sinop");

            // Form Load içinde ListBox'ların AllowDrop özelliğini açalım
            lstİllerA.AllowDrop = true;
            lstİllerB.AllowDrop = true;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            lstİllerA.Items.Add(txtGiris.Text);
            txtGiris.Clear();
            txtGiris.Focus();
        }

        private void txtGiris_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstİllerA.Items.Add(txtGiris.Text);
                txtGiris.Clear();
            }
        }

        private void btnGoster_Click(object sender, EventArgs e)
        {
            var a = lstİllerA.SelectedItems;
            string mesaj = string.Empty;
            if (a.Count <= 0)
            {
                MessageBox.Show("İl Seçimi Yapılmamıştır!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                foreach (var item in a)
                {
                    mesaj += item.ToString() + Environment.NewLine;
                }
                MessageBox.Show(mesaj);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            var secilenisil = lstİllerA.SelectedIndices;
            if (secilenisil.Count <= 0)
            {
                MessageBox.Show("Silinecek İl Seçimi Yapılmamıştır!", "UYARI", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            for (int i = secilenisil.Count - 1; i >= 0; i = i - 1)
            {
                lstİllerA.Items.RemoveAt(secilenisil[i]);
            }
        }

        private void btnRightAktar_Click(object sender, EventArgs e)
        {
            var secilenindexler = lstİllerA.SelectedIndices;
            if (secilenindexler.Count <= 0)
            {
                MessageBox.Show(
                    "Aktarılacak İl Seçiniz",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {
                foreach (int item in secilenindexler)
                {
                    lstİllerB.Items.Add(lstİllerA.Items[item]);
                }
                for (int i = secilenindexler.Count - 1; i >= 0; i--)
                {
                    lstİllerA.Items.RemoveAt(secilenindexler[i]);
                }
            }
        }

        private void lstİllerA_KeyDown(object sender, KeyEventArgs e)
        {
        }

        private void lstİllerA_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstİllerA.SelectedItems.Count > 0)
            {
                lstİllerA.DoDragDrop(lstİllerA, DragDropEffects.Move);
            }
        }

        private void lstİllerB_MouseDown(object sender, MouseEventArgs e)
        {
            if (lstİllerB.SelectedItems.Count > 0)
            {
                lstİllerB.DoDragDrop(lstİllerB, DragDropEffects.Move);
            }
        }

        private void lstİllerB_DragOver(object sender, DragEventArgs e)
        {
            var tasınandata = e.Data.GetData(typeof(ListBox).FullName) as ListBox;
            if (tasınandata != null)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lstİllerB_DragDrop(object sender, DragEventArgs e)
        {
            var tasınandata = e.Data.GetData(typeof(ListBox).FullName) as ListBox;
            var secilenindexler = tasınandata.SelectedIndices;
            foreach (int item in secilenindexler)
            {
                lstİllerB.Items.Add(lstİllerA.Items[item]);
            }
            for (int i = secilenindexler.Count - 1; i >= 0; i--)
            {
                lstİllerA.Items.RemoveAt(secilenindexler[i]);
            }
        }

        private void lstİllerA_DragOver(object sender, DragEventArgs e)
        {
            var tasınandata = e.Data.GetData(typeof(ListBox).FullName) as ListBox;
            if (tasınandata != null)
            {
                e.Effect = DragDropEffects.Move;
            }
            else
            {
                e.Effect = DragDropEffects.None;
            }
        }

        private void lstİllerA_DragDrop(object sender, DragEventArgs e)
        {
            var tasınandata = e.Data.GetData(typeof(ListBox).FullName) as ListBox;
            if (tasınandata != null && tasınandata == lstİllerB)
            {
                var secilenindexler = tasınandata.SelectedIndices;
                foreach (int item in secilenindexler)
                {
                    lstİllerA.Items.Add(lstİllerB.Items[item]);
                }
                for (int i = secilenindexler.Count - 1; i >= 0; i--)
                {
                    lstİllerB.Items.RemoveAt(secilenindexler[i]);
                }
            }
        }

        private void lstİllerA_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLeftAktar_Click(object sender, EventArgs e)
        {
            var secilenindexler = lstİllerB.SelectedIndices;
            if (secilenindexler.Count <= 0)
            {
                MessageBox.Show(
                    "Aktarılacak İl Seçiniz",
                    "Hata",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }
            else
            {
                foreach (int item in secilenindexler)
                {
                    lstİllerA.Items.Add(lstİllerB.Items[item]);
                }
                for (int i = secilenindexler.Count - 1; i >= 0; i--)
                {
                    lstİllerB.Items.RemoveAt(secilenindexler[i]);
                }
            }
        }
    }
}