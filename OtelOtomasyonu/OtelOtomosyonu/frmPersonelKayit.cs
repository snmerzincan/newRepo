using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace OtelOtomosyonu
{
    public partial class frmPersonelKayit : Form
    {
        public frmPersonelKayit()
        {
            InitializeComponent();
        }
        private void frmPersonelKayit_Load(object sender, EventArgs e)
        {

            Personel prs = new Personel();
            prs.PersonelleriGetir(lvPersonelBilgileri);
        }
        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }
        private void Temizle()
        {
            
            txtPersAdi.Clear();
            txtPersSoyadi.Clear();
            txtPersTC.Clear();
            txtDogumYeri.Clear();
            txtTelefon.Clear();
            txtAdres.Clear();
            txtEmail.Clear();
            txtPersAdi.Focus();
        }
        private void btnCikis_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        private void btnKaydet_Click_2(object sender, EventArgs e)
        {
            if (txtPersTC.Text.Trim() != "" && txtPersAdi.Text.Trim() != "" && txtPersSoyadi.Text.Trim() != "" && cbDepartman.Text.Trim() != "")
            {
                Personel p = new Personel();
                //if (p.PersonelVarmi(txtPersTC.Text))
                //{
                //    MessageBox.Show(txtPersTC + "kimlik nolu kişi zaten çalışan!");
                //    txtPersTC.Focus();
                //}
                //else

                p.PersAdi = txtPersAdi.Text;
                p.PersSoyadi = txtPersSoyadi.Text;
                p.PersTC = txtPersTC.Text;
                p.DogumTarih = Convert.ToDateTime(dtpDogum.Text);
                p.DogumYeri = txtDogumYeri.Text;
                p.Telefon = txtTelefon.Text;
                p.Adres = txtAdres.Text;
                p.Email = txtEmail.Text;
                p.Departman = cbDepartman.Text;

                if (rbErkek.Checked == false && rbKadin.Checked == false)
                { MessageBox.Show("Cinsiyet alanı boş bırakılamaz!"); }
                else
                {
                    if (rbErkek.Checked == true)
                    { p.Cinsiyet = false; }
                    else
                    { p.Cinsiyet = true; }
                }
                if (rbBekar.Checked == false && rbEvli.Checked == false)
                { MessageBox.Show("Medeni Hal alanı boş bırakılamaz!"); }
                else
                {
                    if (rbBekar.Checked == true)
                    { p.MedeniHal = true; }
                    else
                    { p.MedeniHal =false; }
                }

                if (p.PersonelEkle(p))
                {
                    MessageBox.Show("Personel Bilgileri Eklendi.");
                    Temizle();
                }
                else { MessageBox.Show("Personel Eklenemedi!"); }
            }

            else
            {
                MessageBox.Show("Zorunlu alanlarını doldurunuz!", "Dikkat! Eksik Bilgi!");
                txtPersAdi.Focus();
            }

        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();

            p.PersID =(txtCalisanID.Text);
            p.PersAdi = txtPersAdi.Text.ToString();
            p.PersSoyadi = txtPersSoyadi.Text.ToString();
            p.PersTC = txtPersTC.Text.ToString();
            p.Telefon = txtTelefon.Text.ToString();
            p.DogumTarih = Convert.ToDateTime(dtpDogum.Value);
            p.DogumYeri =txtDogumYeri.Text.ToString();
            p.Email = txtEmail.Text.ToString();
            p.Adres = txtAdres.Text.ToString();
            p.Departman = cbDepartman.SelectedItem.ToString();
            
            if (p.PersonelBilgileriGuncelle(p))
            {
                MessageBox.Show("Personel bilgileri güncellendi.");
                
            }
            else
            {
                MessageBox.Show("Personel bilgileri güncellenemedi.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            Personel p = new Personel();
            p.PersID = (txtCalisanID.Text);

            if (p.PersonelSil(p))
            {
                MessageBox.Show("Personel bilgileri silindi.");
                
            }
            else
            {
                MessageBox.Show("Personel bilgileri silinemedi.", "HATA", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void lvMusteriBilgileri_DoubleClick(object sender, EventArgs e)
        {
            txtCalisanID.Text = lvPersonelBilgileri.SelectedItems[0].SubItems[0].Text;
            txtPersAdi.Text = lvPersonelBilgileri.SelectedItems[0].SubItems[1].Text;
            txtPersSoyadi.Text = lvPersonelBilgileri.SelectedItems[0].SubItems[2].Text;
            txtPersTC.Text = lvPersonelBilgileri.SelectedItems[0].SubItems[3].Text;
            txtTelefon.Text = lvPersonelBilgileri.SelectedItems[0].SubItems[4].Text;
            txtDogumYeri.Text = lvPersonelBilgileri.SelectedItems[0].SubItems[5].Text;
             txtAdres.Text = lvPersonelBilgileri.SelectedItems[0].SubItems[7].Text;
            txtEmail.Text = lvPersonelBilgileri.SelectedItems[0].SubItems[6].Text;
        
           
            txtPersAdi.Focus();
        }
        }

        
    }



