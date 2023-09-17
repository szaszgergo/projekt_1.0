using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fo_projekt
{
    public partial class Form1 : Form
    {
        private int almaAr, bananAr, csirkemellAr, szalamiAr, kenyerAr, tejAr, sajtAr,
                 serpenyoAr, labosAr, porszivoAr, hutoAr, mosogepAr, tanyerAr, sepruAr;

        Dictionary<string, int> termekekArak = new Dictionary<string, int>();
        


        public Form1()
        {
            InitializeComponent();
            termekekArak.Add("alma", 150);
            termekekArak.Add("banan", 200);
            termekekArak.Add("csirkemell", 1500);
            termekekArak.Add("szalami", 5000);
            termekekArak.Add("kenyer", 800);
            termekekArak.Add("tej", 500);
            termekekArak.Add("sajt", 2000);


            termekekArak.Add("serpenyo", 7000);
            termekekArak.Add("labos", 9000);
            termekekArak.Add("porszivo", 20000);
            termekekArak.Add("huto", 80000);
            termekekArak.Add("mosogep", 70000);
            termekekArak.Add("tanyer", 10000);
            termekekArak.Add("sepru", 3000);


        }

        private void rbtn_Haztartasi_cikk_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_Haztartasi_cikk.Checked)
            {
                // Engedélyezd a Checkbox-okat és TextBox-eket az élelmiszer kategória esetén
                cbx_serpenyo.Enabled = true;
                cbx_labos.Enabled = true;
                cbx_porszivo.Enabled = true;
                cbx_huto.Enabled = true;
                cbx_mosogep.Enabled = true;
                cbx_tanyer.Enabled = true;
                cbx_sepru.Enabled = true;

            }
            else
            {
                // Letiltod a Checkbox-okat és TextBox-eket
                cbx_serpenyo.Enabled = false;
                cbx_labos.Enabled = false;
                cbx_porszivo.Enabled = false;
                cbx_huto.Enabled = false;
                cbx_mosogep.Enabled = false;
                cbx_tanyer.Enabled = false;
                cbx_sepru.Enabled = false;
            }
        }

        private void cbx_csirkemell_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_csirkemell.Checked)
            {
                txtb_csirkemell.Enabled = true;
                 csirkemellAr = termekekArak["csirkemell"];
            }
            else
            {
                txtb_csirkemell.Enabled = false;
                csirkemellAr = 0;
            }
        }

        private void cbx_tej_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_tej.Checked)
            {
                txtb_tej.Enabled = true;
                 tejAr = termekekArak["tej"];
            }
            else
            {
                txtb_tej.Enabled = false;
                tejAr = 0;
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void rbtn_elelmiszer_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtn_elelmiszer.Checked)
            {
                // Engedélyezd a Checkbox-okat és TextBox-eket az élelmiszer kategória esetén
                cbx_alma.Enabled = true;
                cbx_banan.Enabled = true;
                cbx_csirkemell.Enabled = true;
                cbx_szalami.Enabled = true;
                cbx_kenyer.Enabled = true;
                cbx_tej.Enabled = true;
                cbx_sajt.Enabled = true;
         
            }
            else
            {
                // Letiltod a Checkbox-okat és TextBox-eket
                cbx_alma.Enabled = false;
                cbx_banan.Enabled = false;
                cbx_csirkemell.Enabled = false;
                cbx_szalami.Enabled = false;
                cbx_kenyer.Enabled = false;
                cbx_tej.Enabled = false;
                cbx_sajt.Enabled = false;
            }
        }

        private void btn_kilepes_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Biztosan ki szeretne lépni?", "Kilépés", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
               
                this.Close();
            }
          
        }

        private void lbl_mennyiseg_Click(object sender, EventArgs e)
        {

        }

        private void cbx_alma_CheckedChanged(object sender, EventArgs e)
        {
           
            if (cbx_alma.Checked)
            {
                txtb_alma.Enabled = true;
                // Lekérdezheted az árat a Dictionary-ből
                 almaAr = termekekArak["alma"];
                // Most az almaAr változóban van az alma ára (100)
            }
            else
            {
                txtb_alma.Enabled = false;
                almaAr = 0;
            }
        }

        private void cbx_banan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_banan.Checked)
            {
                txtb_banan.Enabled = true;
                 bananAr = termekekArak["banan"];
            }
            else
            {
                txtb_banan.Enabled = false;
                bananAr = 0;
            }
        }

        private void cbx_szalami_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_szalami.Checked)
            {
                txtb_szalami.Enabled = true;
                 szalamiAr = termekekArak["szalami"];
            }
            else
            {
                txtb_szalami.Enabled = false;
                szalamiAr = 0;
            }
        }

        private void cbx_kenyer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_kenyer.Checked)
            {
                txtb_kenyer.Enabled = true;
                 kenyerAr = termekekArak["kenyer"];
            }
            else
            {
                txtb_kenyer.Enabled = false;
                kenyerAr = 0;
            }
        }

        private void cbx_sajt_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_sajt.Checked)
            {
                txtb_sajt.Enabled = true;
                 sajtAr = termekekArak["sajt"];
            }
            else
            {
                txtb_sajt.Enabled = false;
                sajtAr = 0;
            }
        }

        private void cbx_serpenyo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_serpenyo.Checked)
            {
                txtb_serpenyo.Enabled = true;
                 serpenyoAr = termekekArak["serpenyo"];
            }
            else
            {
                txtb_serpenyo.Enabled = false;
                serpenyoAr = 0;
            }
        }

        private void cbx_labos_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_labos.Checked)
            {
                txtb_labos.Enabled = true;
                 labosAr = termekekArak["labos"];
            }
            else
            {
                txtb_labos.Enabled = false;
                labosAr = 0;
            }
        }

        private void cbx_porszivo_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_porszivo.Checked)
            {
                txtb_porszivo.Enabled = true;
                 porszivoAr = termekekArak["porszivo"];
            }
            else
            {
                txtb_porszivo.Enabled = false;
                porszivoAr = 0;
            }
        }

        private void cbx_huto_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_huto.Checked)
            {
                txtb_huto.Enabled = true;
                 hutoAr = termekekArak["huto"];
            }
            else
            {
                txtb_huto.Enabled = false;
                hutoAr = 0;
            }
        }

        private void cbx_mosogep_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_mosogep.Checked)
            {
                txtb_mosogep.Enabled = true;
                 mosogepAr = termekekArak["mosogep"];
            }
            else
            {
                txtb_mosogep.Enabled = false;
                mosogepAr = 0;
            }
        }

        private void cbx_tanyer_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_tanyer.Checked)
            {
                txtb_tanyer.Enabled = true;
                 tanyerAr = termekekArak["tanyer"];
            }
            else
            {
                txtb_tanyer.Enabled = false;
                tanyerAr = 0;
            }
        }

        private void cbx_sepru_CheckedChanged(object sender, EventArgs e)
        {
            if (cbx_sepru.Checked)
            {
                txtb_sepru.Enabled = true;
                 sepruAr = termekekArak["sepru"];
            }
            else
            {
                txtb_sepru.Enabled = false;
                sepruAr = 0;
            }
        }


        //fizetés réssz  ------------------------->
      


        private void btn_fizetes_Click(object sender, EventArgs e)
        {
            int osszeg = 0;

            // Ellenőrizd, hogy mely CheckBox-ok vannak kiválasztva, és add hozzá az árakat.
            if (cbx_alma.Checked)
            {
                int mennyiseg = int.Parse(txtb_alma.Text);
                osszeg += almaAr * mennyiseg;
            }

            if (cbx_banan.Checked)
            {
                int mennyiseg = int.Parse(txtb_banan.Text);
                osszeg += bananAr * mennyiseg;
            }

            if (cbx_csirkemell.Checked)
            {
                int mennyiseg = int.Parse(txtb_csirkemell.Text);
                osszeg += csirkemellAr * mennyiseg;
            }

            if (cbx_szalami.Checked)
            {
                int mennyiseg = int.Parse(txtb_szalami.Text);
                osszeg += szalamiAr * mennyiseg;
            }

            if (cbx_kenyer.Checked)
            {
                int mennyiseg = int.Parse(txtb_kenyer.Text);
                osszeg += kenyerAr * mennyiseg;
            }
            if (cbx_tej.Checked)
            {
                int mennyiseg = int.Parse(txtb_tej.Text);
                osszeg += tejAr * mennyiseg;
            }

            if (cbx_sajt.Checked)
            {
                int mennyiseg = int.Parse(txtb_sajt.Text);
                osszeg += sajtAr * mennyiseg;
            }

            if (cbx_serpenyo.Checked)
            {
                int mennyiseg = int.Parse(txtb_serpenyo.Text);
                osszeg += serpenyoAr * mennyiseg;
            }

            if (cbx_labos.Checked)
            {
                int mennyiseg = int.Parse(txtb_labos.Text);
                osszeg += labosAr * mennyiseg;
            }

            if (cbx_porszivo.Checked)
            {
                int mennyiseg = int.Parse(txtb_porszivo.Text);
                osszeg += porszivoAr * mennyiseg;
            }
            if (cbx_huto.Checked)
            {
                int mennyiseg = int.Parse(txtb_huto.Text);
                osszeg += hutoAr * mennyiseg;
            }
            if (cbx_mosogep.Checked)
            {
                int mennyiseg = int.Parse(txtb_mosogep.Text);
                osszeg += mosogepAr * mennyiseg;
            }
            if (cbx_tanyer.Checked)
            {
                int mennyiseg = int.Parse(txtb_tanyer.Text);
                osszeg += tanyerAr * mennyiseg;
            }
            if (cbx_sepru.Checked)
            {
                int mennyiseg = int.Parse(txtb_sepru.Text);
                osszeg += sepruAr * mennyiseg;
            }

            // Az összeget megjelenítheted valahol, például egy MessageBox-ben.
            MessageBox.Show($"Az összesen fizetendő: {osszeg} Ft");

            
        }

    }
}
