﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ERP_PROJESİ
{
    public partial class EklemeEkranı : Form
    {

        public string selectedPage { get; set; }
        string giriskelimesi;
        public EklemeEkranı()
        {
            InitializeComponent();
        }

        private void EklemeEkranı_Load(object sender, EventArgs e)
        {
            Font font = new Font("Montserrat", 9f, FontStyle.Bold);
            this.Font = font;
            this.Size = new Size(1000, 600);
            
            BackColor = ColorTranslator.FromHtml("#eeeeee");
            Ana ana = new Ana();
            switch (selectedPage)
            {
                case "üretimemri":
                    #region üretim emri ekleme

                    giriskelimesi = "Üretim emri";
                    Label urunID = new Label();
                    urunID.Text = "Ürün";
                    urunID.Location = new Point(50, 50);
                    urunID.Size = new Size(150, 25);
                    Controls.Add(urunID);
                    ComboBox IDtxt = new ComboBox();
                    IDtxt.Location = new Point(250, 50);
                    IDtxt.Size = new Size(250, 25);
                    Controls.Add(IDtxt);
                    Label verilenTarih = new Label();
                    verilenTarih.Text = "Planlanan başlangıç tarihi";
                    verilenTarih.Location = new Point(50, 100);
                    verilenTarih.Size = new Size(150, 50);
                    Controls.Add(verilenTarih);
                    DateTimePicker date = new DateTimePicker();
                    date.Location = new Point(250, 100);
                    date.Size = new Size(250, 50);
                    Controls.Add(date);
                    Label siparisID = new Label();
                    siparisID.Text = "Sipariş kodu";
                    siparisID.Location = new Point(50, 150);
                    siparisID.Size = new Size(150, 25);
                    Controls.Add(siparisID);
                    TextBox siparisidtxt = new TextBox();
                    siparisidtxt.Location = new Point(250, 150);
                    siparisidtxt.Size = new Size(250, 50);
                    Controls.Add((siparisidtxt));
                    Label rotaID = new Label();
                    rotaID.Text = "Rota";
                    rotaID.Location = new Point(50, 200);
                    rotaID.Size = new Size(150, 25);
                    Controls.Add((rotaID));
                    ComboBox rota = new ComboBox();
                    rota.Location = new Point(250, 200);
                    rota.Size = new Size(250, 50);
                    Controls.Add(rota);
                    Label hammaddelbl = new Label();
                    hammaddelbl.Text = "Hammadde";
                    hammaddelbl.Location = new Point(50, 250);
                    hammaddelbl.Size = new Size(150, 25);
                    Controls.Add(hammaddelbl);
                    ComboBox hammaddecombo = new ComboBox();
                    hammaddecombo.Location = new Point(250, 250);
                    hammaddecombo.Size = new Size(250, 50);
                    Controls.Add(hammaddecombo);
                    Label adet =new Label();
                    adet.Text = "Miktarı";
                    adet.Location = new Point(50,300);
                    adet.Size = new Size(150,25);
                    Controls.Add (adet);
                    TextBox adettxt = new TextBox();
                    adettxt.Location = new Point(250, 300);
                    adettxt.Size = new Size(250, 50);
                    Controls.Add(adettxt);
                    ListBox hammadelistesi = new ListBox();
                    hammadelistesi.Location = new Point(600,50);
                    hammadelistesi.Size = new Size(300,280);
                    hammadelistesi.Location = new Point(600, 50);
                    hammadelistesi.Size = new Size(300, 280);
                    Controls.Add(hammadelistesi);
                    Button ekle = new Button();
                    ekle.Location = new Point(600, 350);
                    ekle.Size = new Size(120, 75);
                    ekle.Text = "Hammade ekle";
                    Controls.Add(ekle);
                    #endregion
                    break;
                case "makinalar":
                    #region Makinalar

                    giriskelimesi = "Makina";
                    Label makinaadı = new Label();
                    makinaadı.Text = "Makina Adı";
                    makinaadı.Location = new Point(50, 50);
                    makinaadı.Size = new Size(150, 25);
                    Controls.Add(makinaadı);
                    TextBox makinaaditxt = new TextBox();
                    makinaaditxt.Location = new Point(250, 50);
                    makinaaditxt.Size = new Size(250, 50);
                    Controls.Add((makinaaditxt));
                    Label makinastok = new Label();
                    makinastok.Text = "Makina Adeti";
                    makinastok.Location = new Point(50, 100);
                    makinastok.Size = new Size(150, 25);
                    Controls.Add(makinastok);
                    TextBox makinastoktxt = new TextBox();
                    makinastoktxt.Location = new Point(250, 100);
                    makinastoktxt.Size = new Size(250, 50);
                    Controls.Add((makinastoktxt));
                    Label bakim = new Label();
                    bakim.Text = "Bakım Tarihi";
                    bakim.Location = new Point(50, 150);
                    bakim.Size = new Size(150, 25);
                    Controls.Add(bakim);
                    DateTimePicker bakimdate = new DateTimePicker();
                    bakimdate.Location = new Point(250, 150);
                    bakimdate.Size = new Size(250, 50);
                    Controls.Add(bakimdate);
                    Label makinaacıklama = new Label();
                    makinaacıklama.Text = "Makina Açıklaması";
                    makinaacıklama.Location = new Point(50, 200);
                    makinaacıklama.Size = new Size(150, 25);
                    Controls.Add(makinaacıklama);
                    TextBox makinaacıklamatxt = new TextBox();
                    makinaacıklamatxt.Location = new Point(250, 200);
                    makinaacıklamatxt.Size = new Size(250, 100);
                    makinaacıklamatxt.Multiline = true;
                    Controls.Add((makinaacıklamatxt));
                    #endregion
                    break;
                #region rotalar

                case "rotalar":
                    #region Rota
                    giriskelimesi = "Rota";
                    Label OperasyonID = new Label();
                    OperasyonID.Text = "Operasyon";
                    OperasyonID.Location = new Point(50, 50);
                    OperasyonID.Size = new Size(150, 25);
                    Controls.Add(OperasyonID);
                    ComboBox RotaIDcombo = new ComboBox();
                    RotaIDcombo.Location = new Point(250, 50);
                    RotaIDcombo.Size = new Size(250, 25);
                    Controls.Add(RotaIDcombo);
                    Button opekle = new Button();
                    opekle.Location = new Point(520, 50);
                    opekle.Size = new Size(200, 25);
                    opekle.Text = "Operasyon ekle";
                    Controls.Add(opekle);
                    DataGridView oplistesi = new DataGridView();
                    oplistesi.Location = new Point(520, 80);
                    oplistesi.Size = new Size(400, 150);
                    Controls.Add((oplistesi));
                    Label urunid = new Label();
                    urunid.Text = "Ürün";
                    urunid.Location = new Point(50, 100);
                    urunid.Size = new Size(150, 25);
                    Controls.Add(urunid);
                    ComboBox urunidcombo = new ComboBox();
                    urunidcombo.Location = new Point(250, 100);
                    urunidcombo.Size = new Size(250, 25);
                    Controls.Add(urunidcombo);
                    Label cikanmamul = new Label();
                    cikanmamul.Text = "Çıkan Mamul";
                    cikanmamul.Location = new Point(50, 150);
                    cikanmamul.Size = new Size(150, 25);
                    Controls.Add(cikanmamul);
                    ComboBox cikanmamulcombo = new ComboBox();
                    cikanmamulcombo.Location = new Point(250, 150);
                    cikanmamulcombo.Size = new Size(250, 25);
                    Controls.Add(cikanmamulcombo);
                    #endregion
                    
                    break;
                     #endregion
                case "günlükraporekle":
                    #region günlükraporekle
                    giriskelimesi = "Günlük Rapor";
                    Label operasyonIDlbl = new Label();
                    operasyonIDlbl.Text = "Operasyon";
                    operasyonIDlbl.Location = new Point(50, 50);
                    operasyonIDlbl.Size = new Size(150, 25);
                    Controls.Add(operasyonIDlbl);
                    ComboBox operasyonID = new ComboBox();
                    operasyonID.Location = new Point(250, 50);
                    operasyonID.Size = new Size(250, 25);
                    Controls.Add(operasyonID);
                    Label kullanılanmakinaIDlbl = new Label();
                    kullanılanmakinaIDlbl.Text = "Kullanılan Makina";
                    kullanılanmakinaIDlbl.Location = new Point(50, 100);
                    kullanılanmakinaIDlbl.Size = new Size(200, 50);
                    Controls.Add(kullanılanmakinaIDlbl);
                    ComboBox kullanılanmakinaID = new ComboBox();
                    kullanılanmakinaID.Location = new Point(250, 100);
                    kullanılanmakinaID.Size = new Size(250, 25);
                    Controls.Add(kullanılanmakinaID);
                    Label kullanılanmalzemeIDlbl = new Label();
                    kullanılanmalzemeIDlbl.Text = "Kullanılan Malzeme";
                    kullanılanmalzemeIDlbl.Location = new Point(50, 150);
                    kullanılanmalzemeIDlbl.Size = new Size(150, 50);
                    Controls.Add(kullanılanmalzemeIDlbl);
                    ComboBox kullanılanmalzemeID = new ComboBox();
                    kullanılanmalzemeID.Location = new Point(250, 150);
                    kullanılanmalzemeID.Size = new Size(250, 25);
                    Controls.Add(kullanılanmalzemeID);
                    Label operasyondatelbl = new Label();
                    operasyondatelbl.Text = "Operasyon Tarihi";
                    operasyondatelbl.Location = new Point(50, 200);
                    operasyondatelbl.Size = new Size(150, 50);
                    Controls.Add(operasyondatelbl);
                    DateTimePicker operasyondate = new DateTimePicker();
                    operasyondate.Location = new Point(250, 200);
                    operasyondate.Size = new Size(250, 25);
                    Controls.Add(operasyondate);
                    Label imalatcıIDlbl = new Label();
                    imalatcıIDlbl.Text = "İmalatcı";
                    imalatcıIDlbl.Location = new Point(50, 250);
                    imalatcıIDlbl.Size = new Size(150, 50);
                    Controls.Add(imalatcıIDlbl);
                    ComboBox imalatcıID = new ComboBox();
                    imalatcıID.Location = new Point(250, 250);
                    imalatcıID.Size = new Size(250, 25);
                    Controls.Add(imalatcıID);


                    break;
                #endregion
                case "operasyonekle":
                    #region operasyonekle
                    giriskelimesi = "Operasyon";
                    Label girilenürünlerIDlbl = new Label();
                    girilenürünlerIDlbl.Text = "Girilen Ürün";
                    girilenürünlerIDlbl.Location = new Point(50, 50);
                    girilenürünlerIDlbl.Size = new Size(150, 25);
                    Controls.Add(girilenürünlerIDlbl);
                    ComboBox girilenürünlerID = new ComboBox();
                    girilenürünlerID.Location = new Point(250, 50);
                    girilenürünlerID.Size = new Size(250, 25);
                    Controls.Add(girilenürünlerID);
                    Label operasyonadilbl = new Label();
                    operasyonadilbl.Text = "Operasyon Adi";
                    operasyonadilbl.Location = new Point(50, 100);
                    operasyonadilbl.Size = new Size(200, 50);
                    Controls.Add(operasyonadilbl);
                    TextBox operasyonadi = new TextBox();
                    operasyonadi.Location = new Point(250, 100);
                    operasyonadi.Size = new Size(250, 25);
                    Controls.Add(operasyonadi);
                    Label rotaIDlbl = new Label();
                    rotaIDlbl.Text = "Rota";
                    rotaIDlbl.Location = new Point(50, 150);
                    rotaIDlbl.Size = new Size(200, 50);
                    Controls.Add(rotaIDlbl);
                    ComboBox rotaID1 = new ComboBox();
                    rotaID1.Location = new Point(250, 150);
                    rotaID1.Size = new Size(250, 25);
                    Controls.Add(rotaID1);
                    DataGridView data = new DataGridView();
                    data.Location = new Point(600, 50);
                    data.Size = new Size(400, 300);
                    Controls.Add(data);


                    break;
                #endregion
                case "personeller":
                    #region personel
                    giriskelimesi = "Personel";
                    Label calısanAdiLBL = new Label();
                    calısanAdiLBL.Text = "Adı";
                    calısanAdiLBL.Location = new Point(50, 50);
                    calısanAdiLBL.Size = new Size(150, 25);
                    Controls.Add(calısanAdiLBL);
                    TextBox calısanadiTXT = new TextBox();
                    calısanadiTXT.Location = new Point(250, 50);
                    calısanadiTXT.Size = new Size(250, 25);
                    Controls.Add(calısanadiTXT);
                    Label calısansoyadiLBL = new Label();
                    calısansoyadiLBL.Text = "Soyadı";
                    calısansoyadiLBL.Location = new Point(50, 100);
                    calısansoyadiLBL.Size = new Size(200, 50);
                    Controls.Add(calısansoyadiLBL);
                    TextBox calısansoyadiTXT = new TextBox();
                    calısansoyadiTXT.Location = new Point(250, 100);
                    calısansoyadiTXT.Size = new Size(250, 25);
                    Controls.Add(calısansoyadiTXT);
                    Label isegirisDateLBL = new Label();
                    isegirisDateLBL.Text = "İşe Giriş Tarihi";
                    isegirisDateLBL.Location = new Point(50, 150);
                    isegirisDateLBL.Size = new Size(200, 50);
                    Controls.Add(isegirisDateLBL);
                    DateTimePicker isegirisDate = new DateTimePicker();
                    isegirisDate.Location = new Point(250, 150);
                    isegirisDate.Size = new Size(250, 50);
                    Controls.Add(isegirisDate);
                    Label telefonLBL = new Label();
                    telefonLBL.Text = "Telefon";
                    telefonLBL.Location = new Point(50, 200);
                    telefonLBL.Size = new Size(200, 50);
                    Controls.Add(telefonLBL);
                    TextBox telefonTXT = new TextBox();
                    telefonTXT.Location = new Point(250, 200);
                    telefonTXT.Size = new Size(250, 25);
                    Controls.Add(telefonTXT);
                    Label ünvanLBL = new Label();
                    ünvanLBL.Text = "Ünvanı";
                    ünvanLBL.Location = new Point(50, 250);
                    ünvanLBL.Size = new Size(200, 50);
                    Controls.Add(ünvanLBL);
                    ComboBox ünvanID = new ComboBox();
                    ünvanID.Location = new Point(250, 250);
                    ünvanID.Size = new Size(250, 25);
                    Controls.Add(ünvanID);
                    Label kullanabildigimakinalarLBL = new Label();
                    kullanabildigimakinalarLBL.Text = "Kullanabildigi Makinalar";
                    kullanabildigimakinalarLBL.Location = new Point(50, 300);
                    kullanabildigimakinalarLBL.Size = new Size(200, 50);
                    Controls.Add(kullanabildigimakinalarLBL);
                    ComboBox kullanabildigimakinalarID = new ComboBox();
                    kullanabildigimakinalarID.Location = new Point(250, 300);
                    kullanabildigimakinalarID.Size = new Size(250, 25);
                    Controls.Add(kullanabildigimakinalarID);
                    Panel resimkoy = new Panel();
                    resimkoy.Location = new Point(300, 350);
                    resimkoy.Size = new Size(200, 250);
                    resimkoy.BackColor = Color.Black;
                    Controls.Add(resimkoy);
                    break;
                #endregion
                case "hakedis":
                    #region hakedis

                    giriskelimesi = "Hakedis";
                    Label hakedistarih = new Label();
                    hakedistarih.Text = "Tarih";
                    hakedistarih.Location = new Point(50, 50);
                    hakedistarih.Size = new Size(150, 25);
                    Controls.Add(hakedistarih);
                    ComboBox hakedistarihcombo = new ComboBox();
                    hakedistarihcombo.Location = new Point(250, 50);
                    hakedistarihcombo.Size = new Size(250, 25);
                    Controls.Add(hakedistarihcombo);
                    Button ayekle = new Button();
                    ayekle.Location = new Point(510, 50);
                    ayekle.Size = new Size(200, 25);
                    ayekle.Text = "Yeni ay ekle";
                    Controls.Add(ayekle);
                    Label hakedisad = new Label();
                    hakedisad.Text = "Çalışan";
                    hakedisad.Location = new Point(50, 100);
                    hakedisad.Size = new Size(150, 25);
                    Controls.Add(hakedisad);
                    ComboBox calısanhakediscombo = new ComboBox();
                    calısanhakediscombo.Location = new Point(250, 100);
                    calısanhakediscombo.Size = new Size(250, 25);
                    Controls.Add(calısanhakediscombo);
                    Label maas = new Label();
                    maas.Text = "Maaşı";
                    maas.Location = new Point(50, 150);
                    maas.Size = new Size(150, 25);
                    Controls.Add(maas);
                    TextBox maastxt = new TextBox();
                    maastxt.Location = new Point(250, 150);
                    maastxt.Size = new Size(250, 25);
                    Controls.Add(maastxt);
                    Label calisilansaat = new Label();
                    calisilansaat.Text = "Çalışılan Saat";
                    calisilansaat.Location = new Point(50, 200);
                    calisilansaat.Size = new Size(150, 25);
                    Controls.Add(calisilansaat);
                    TextBox calisilansaattxt = new TextBox();
                    calisilansaattxt.Location = new Point(250, 200);
                    calisilansaattxt.Size = new Size(250, 25);
                    Controls.Add(calisilansaattxt);
                    Label prim = new Label();
                    prim.Text = "Prim";
                    prim.Location = new Point(50, 250);
                    prim.Size = new Size(150, 25);
                    Controls.Add(prim);
                    TextBox primtxt = new TextBox();
                    primtxt.Location = new Point(250, 250);
                    primtxt.Size = new Size(250, 25);
                    Controls.Add(primtxt);
                    Label hakedisnot = new Label();
                    hakedisnot.Text = "Not";
                    hakedisnot.Location = new Point(50, 300);
                    hakedisnot.Size = new Size(150, 25);
                    Controls.Add(hakedisnot);
                    TextBox hakedisnottxt = new TextBox();
                    hakedisnottxt.Location = new Point(250, 300);
                    hakedisnottxt.Size = new Size(250, 50);
                    hakedisnottxt.Multiline = true;
                    Controls.Add(hakedisnottxt);
                    #endregion
                    break;
                case "fatura":
                    #region faturalar
                    giriskelimesi = "Fatura";
                    Label Cari = new Label();
                    Cari.Text = "Cari";
                    Cari.Location = new Point(50, 50);
                    Cari.Size = new Size(150, 25);
                    Controls.Add(Cari);
                    ComboBox caricombo = new ComboBox();
                    caricombo.Location = new Point(250, 50);
                    caricombo.Size = new Size(250, 25);
                    Controls.Add(caricombo);
                    Label Tarih = new Label();
                    Tarih.Text = "Tarih";
                    Tarih.Location = new Point(50, 100);
                    Tarih.Size = new Size(150, 25);
                    Controls.Add(Tarih);
                    DateTimePicker faturatarih = new DateTimePicker();
                    faturatarih.Location = new Point(250, 100);
                    faturatarih.Size = new Size(250, 25);
                    Controls.Add(faturatarih);
                    Label faturatutar = new Label();
                    faturatutar.Text = "Tutar";
                    faturatutar.Location = new Point(50, 150);
                    faturatutar.Size = new Size(150, 25);
                    Controls.Add(faturatutar);
                    TextBox faturatutartxt = new TextBox();
                    faturatutartxt.Location = new Point(250, 150);
                    faturatutartxt.Size = new Size(250, 25);
                    Controls.Add(faturatutartxt);
                    Label ödemebilgisi = new Label();
                    ödemebilgisi.Text = "Ödeme Bilgisi";
                    ödemebilgisi.Location = new Point(50, 200);
                    ödemebilgisi.Size = new Size(150, 25);
                    Controls.Add(ödemebilgisi);
                    TextBox ödemebilgisitxt = new TextBox();
                    ödemebilgisitxt.Location = new Point(250, 200);
                    ödemebilgisitxt.Size = new Size(250, 25);
                    Controls.Add(ödemebilgisitxt);
                    Label İade = new Label();
                    İade.Text = "İade";
                    İade.Location = new Point(50, 250);
                    İade.Size = new Size(150, 25);
                    Controls.Add(İade);
                    CheckBox iadecheck = new CheckBox();
                    iadecheck.Location = new Point(250, 250);
                    iadecheck.Size = new Size(250, 25);
                    Controls.Add(iadecheck);
                    #endregion
                    break;
                case "cariler":
                    #region cariler
                    giriskelimesi = "Cariler";
                    Label cariadiLBL = new Label();
                    cariadiLBL.Text = "Adı";
                    cariadiLBL.Location = new Point(50, 50);
                    cariadiLBL.Size = new Size(150, 25);
                    Controls.Add(cariadiLBL);
                    TextBox cariadiTXT = new TextBox();
                    cariadiTXT.Location = new Point(250, 50);
                    cariadiTXT.Size = new Size(250, 25);
                    Controls.Add(cariadiTXT);
                    Label caritelefonTXT = new Label();
                    caritelefonTXT.Text = "Telefon";
                    caritelefonTXT.Location = new Point(50, 75);
                    caritelefonTXT.Size = new Size(150, 25);
                    Controls.Add(caritelefonTXT);
                    TextBox caritelefonLBL = new TextBox();
                    caritelefonLBL.Location = new Point(250, 75);
                    caritelefonLBL.Size = new Size(250, 25);
                    Controls.Add(caritelefonLBL);
                    Label cariadresLBL = new Label();
                    cariadresLBL.Text = "Adres";
                    cariadresLBL.Location = new Point(50, 100);
                    cariadresLBL.Size = new Size(150, 25);
                    Controls.Add(cariadresLBL);
                    TextBox cariadresTXT = new TextBox();
                    cariadresTXT.Location = new Point(250, 100);
                    cariadresTXT.Size = new Size(250, 100);
                    cariadresTXT.Multiline = true;
                    Controls.Add(cariadresTXT);
                    Label carimailLBL = new Label();
                    carimailLBL.Text = "Mail";
                    carimailLBL.Location = new Point(50, 210);
                    carimailLBL.Size = new Size(150, 25);
                    Controls.Add(carimailLBL);
                    TextBox carimailTXT = new TextBox();
                    carimailTXT.Location = new Point(250, 210);
                    carimailTXT.Size = new Size(250, 25);
                    Controls.Add(carimailTXT);
                    Label hesapnumarasıLBL = new Label();
                    hesapnumarasıLBL.Text = "Hesap Numarası";
                    hesapnumarasıLBL.Location = new Point(50, 235);
                    hesapnumarasıLBL.Size = new Size(150, 25);
                    Controls.Add(hesapnumarasıLBL);
                    TextBox hesapnumarasıTXT = new TextBox();
                    hesapnumarasıTXT.Location = new Point(250, 235);
                    hesapnumarasıTXT.Size = new Size(250, 25);
                    Controls.Add(hesapnumarasıTXT);
                    Label cariülkeLBL = new Label();
                    cariülkeLBL.Text = "Ülke";
                    cariülkeLBL.Location = new Point(50, 260);
                    cariülkeLBL.Size = new Size(150, 25);
                    Controls.Add(cariülkeLBL);
                    TextBox cariülkeTXT = new TextBox();
                    cariülkeTXT.Location = new Point(250, 260);
                    cariülkeTXT.Size = new Size(250, 25);
                    Controls.Add(cariülkeTXT);
                    Label carisehirLBL = new Label();
                    carisehirLBL.Text = "Sehir";
                    carisehirLBL.Location = new Point(50, 285);
                    carisehirLBL.Size = new Size(150, 25);
                    Controls.Add(carisehirLBL);
                    TextBox carisehirTXT = new TextBox();
                    carisehirTXT.Location = new Point(250, 285);
                    carisehirTXT.Size = new Size(250, 25);
                    Controls.Add(carisehirTXT);
                    Label caripostakoduLBL = new Label();
                    caripostakoduLBL.Text = "Posta Kodu";
                    caripostakoduLBL.Location = new Point(50, 310);
                    caripostakoduLBL.Size = new Size(150, 25);
                    Controls.Add(caripostakoduLBL);
                    TextBox caripostakoduTXT = new TextBox();
                    caripostakoduTXT.Location = new Point(250, 310);
                    caripostakoduTXT.Size = new Size(250, 25);
                    Controls.Add(caripostakoduTXT);
                    Label caritürüLBL = new Label();
                    caritürüLBL.Text = "Tür Seçiniz";
                    caritürüLBL.Location = new Point(550, 50);
                    caritürüLBL.Size = new Size(150, 25);
                    Controls.Add(caritürüLBL);
                    RadioButton caritürüRD3 = new RadioButton();
                    caritürüRD3.Text = "Tedarikçi";
                    caritürüRD3.Location = new Point(550, 75);
                    caritürüRD3.Size = new Size(200, 25);
                    Controls.Add(caritürüRD3);
                    RadioButton caritürüRB = new RadioButton();
                    caritürüRB.Text = "Müşteri";
                    caritürüRB.Location = new Point(550, 100);
                    caritürüRB.Size = new Size(200, 25);
                    Controls.Add(caritürüRB);
                    RadioButton caritürüRB1 = new RadioButton();
                    caritürüRB1.Text = "Her İkisi";
                    caritürüRB1.Location = new Point(550, 125);
                    caritürüRB1.Size = new Size(200, 25);
                    Controls.Add(caritürüRB1);

                    break;
                #endregion
                case "ürünler":
                    #region ürünler
                    giriskelimesi = "ürünler";
                    Label ürünadıLBL = new Label();
                    ürünadıLBL.Text = "Adı";
                    ürünadıLBL.Location = new Point(50, 50);
                    ürünadıLBL.Size = new Size(150, 25);
                    Controls.Add(ürünadıLBL);
                    TextBox ürünadıTXT = new TextBox();
                    ürünadıTXT.Location = new Point(250, 50);
                    ürünadıTXT.Size = new Size(250, 25);
                    Controls.Add(ürünadıTXT);
                    Label ürünacıklamaLBL = new Label();
                    ürünacıklamaLBL.Text = "Acıklama";
                    ürünacıklamaLBL.Location = new Point(50, 75);
                    ürünacıklamaLBL.Size = new Size(150, 25);
                    Controls.Add(ürünacıklamaLBL);
                    TextBox ürünacıklamaTXT = new TextBox();
                    ürünacıklamaTXT.Location = new Point(250, 75);
                    ürünacıklamaTXT.Size = new Size(250, 100);
                    ürünacıklamaTXT.Multiline = true;
                    Controls.Add(ürünacıklamaTXT);
                    Label ürünfiyatLBL = new Label();
                    ürünfiyatLBL.Text = "Fiyat";
                    ürünfiyatLBL.Location = new Point(50, 185);
                    ürünfiyatLBL.Size = new Size(150, 25);
                    Controls.Add(ürünfiyatLBL);
                    TextBox ürünfiyatTXT = new TextBox();
                    ürünfiyatTXT.Location = new Point(250, 185);
                    ürünfiyatTXT.Size = new Size(250, 25);
                    Controls.Add(ürünfiyatTXT);
                    Label ürünkategorisiLBL = new Label();
                    ürünkategorisiLBL.Text = "Kategori";
                    ürünkategorisiLBL.Location = new Point(50, 210);
                    ürünkategorisiLBL.Size = new Size(150, 25);
                    Controls.Add(ürünkategorisiLBL);
                    ComboBox ürünkategorisiTXT = new ComboBox();
                    ürünkategorisiTXT.Location = new Point(250, 210);
                    ürünkategorisiTXT.Size = new Size(250, 25);
                    Controls.Add(ürünkategorisiTXT);
                    RadioButton ürüntürüRD = new RadioButton();
                    ürüntürüRD.Text = "Ticari Ürünler";
                    ürüntürüRD.Location = new Point(250, 245);
                    ürüntürüRD.Size = new Size(200, 25);
                    Controls.Add(ürüntürüRD);
                    RadioButton ürüntürüRD1 = new RadioButton();
                    ürüntürüRD1.Text = "Mamüller";
                    ürüntürüRD1.Location = new Point(250, 270);
                    ürüntürüRD1.Size = new Size(200, 25);
                    Controls.Add(ürüntürüRD1);
                    RadioButton ürüntürüRD2 = new RadioButton();
                    ürüntürüRD2.Text = "Yari Mamüller";
                    ürüntürüRD2.Location = new Point(250, 295);
                    ürüntürüRD2.Size = new Size(200, 25);
                    Controls.Add(ürüntürüRD2);
                    RadioButton ürüntürüRD3 = new RadioButton();
                    ürüntürüRD3.Text = "Hammaddeler";
                    ürüntürüRD3.Location = new Point(250, 320);
                    ürüntürüRD3.Size = new Size(200, 25);
                    Controls.Add(ürüntürüRD3);

                    break;
                #endregion
                default:
                    break;
            }
            Label giriş = new Label();
            giriş.Text = " " + (giriskelimesi) + " bilgilerini giriniz";
            giriş.Location = new Point(250, 25);
            giriş.Size = new Size(250, 100);
            giriş.Size = new Size(500, 100);
            Controls.Add(giriş);
            Button ad = new Button();
            ad.Location = new Point(250, 350);
            ad.Size = new Size(120, 75);
            ad.Text = "Ekle";
            Controls.Add(ad);
            ad.Click += new EventHandler(ekle);

        }

        void ekle(object sender, EventArgs e)
        {
            MessageBox.Show("Veri Girildi");
            this.Close();
            
        }
        private void EklemeEkranı_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
