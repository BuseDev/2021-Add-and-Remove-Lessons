using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public SinglyLinkedList obj;
        public Form1()
        {
            InitializeComponent();
            obj=new SinglyLinkedList();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            obj.append(comboBox2.Text);
            obj.pop();
            comboBox3.Items.Add(comboBox2.Text);
            listBox1.Items.Add(comboBox2.Text);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            obj.deleteNode(comboBox3.Text);
            listBox1.Items.Remove(comboBox3.SelectedItem);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            obj.push("");
            obj.push(textBox3.Text);
            obj.push(textBox1.Text+" "+textBox2.Text);
            obj.push("");
            obj.push(comboBox1.Text+"("+comboBox4.Text+")");
            obj.pop();

            Environment.Exit(0);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            comboBox1.Items.Add("Bilgisayar Mühendisliği");
            comboBox1.Items.Add("Makine Mühendisliği");
            comboBox1.Items.Add("Elektrik Elektronik Mühendisliği");
            comboBox1.Items.Add("Endüstri Mühendisliği");

            comboBox4.Items.Clear();
            comboBox4.Items.Add("1. Sınıf");
            comboBox4.Items.Add("2. Sınıf");
            comboBox4.Items.Add("3. Sınıf");
            comboBox4.Items.Add("4. Sınıf");

            listBox1.Items.Add("Selected Lessons: ");
            listBox1.Items.Add("");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Bilgisayar Mühendisliği" && comboBox4.Text == "1. Sınıf")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Bilgisayar Mühendisliğine Giriş");
                comboBox2.Items.Add("Programlama");
                comboBox2.Items.Add("Programlama Lab");
                comboBox2.Items.Add("Lineer Cebir");
                comboBox2.Items.Add("İstatistik");
                comboBox2.Items.Add("Ayrık Matematik");
            }
            if (comboBox1.Text == "Bilgisayar Mühendisliği" && comboBox4.Text == "2. Sınıf")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Diferansiyel Denklemler");
                comboBox2.Items.Add("Veri Yapıları ve Algoritmalar");
                comboBox2.Items.Add("Nesneye Yönelik Programlama");
                comboBox2.Items.Add("Nümerik Analiz");
                comboBox2.Items.Add("Sayısal Tasarım");
                comboBox2.Items.Add("Sayısal Tasarım Lab");
            }
            if (comboBox1.Text == "Bilgisayar Mühendisliği" && comboBox4.Text == "3. Sınıf")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Bilgisayar Organizasyonu");
                comboBox2.Items.Add("Bilgisayar Ağları");
                comboBox2.Items.Add("Biçimsel Diller ve Otomatlar");
                comboBox2.Items.Add("İşletim Sistemleri");
                comboBox2.Items.Add("Mikroişlemciler ve Denetleyiciler");
                comboBox2.Items.Add("Mikroişlemciler ve Denetleyiciler Lab");
            }
            if (comboBox1.Text == "Bilgisayar Mühendisliği" && comboBox4.Text == "4. Sınıf")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Gömülü Sistemler");
                comboBox2.Items.Add("Kriptolojiye Giriş");
                comboBox2.Items.Add("Veri Madenciliği");
                comboBox2.Items.Add("Görüntü İşleme");
                comboBox2.Items.Add("Yapay Zeka Teknikleri");
                comboBox2.Items.Add("Mobil Programlama");
            }
            if (comboBox1.Text == "Makine Mühendisliği" && comboBox4.Text == "1. Sınıf")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Makine Mühendisliğine Giriş");
                comboBox2.Items.Add("Genel Kimya");
                comboBox2.Items.Add("Lineer Cebir");
                comboBox2.Items.Add("İstatistik");
                comboBox2.Items.Add("Teknik Resim");
                comboBox2.Items.Add("Ölçme Tekniği");
            }
            if (comboBox1.Text == "Makine Mühendisliği" && comboBox4.Text == "2. Sınıf")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Malzeme");
                comboBox2.Items.Add("Mukavemet");
                comboBox2.Items.Add("Dinamik");
                comboBox2.Items.Add("Termodinamik");
                comboBox2.Items.Add("Akışkanlar Mekaniği");
                comboBox2.Items.Add("Mekanizma Tekniği");
            }
            if (comboBox1.Text == "Makine Mühendisliği" && comboBox4.Text == "3. Sınıf")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Makine Elemanları");
                comboBox2.Items.Add("Otomatik Kontrol");
                comboBox2.Items.Add("Motorlar");
                comboBox2.Items.Add("Isı Transferi");
                comboBox2.Items.Add("Makine Dinamiği");
                comboBox2.Items.Add("Mühendislik Matematiği");

            }
            if (comboBox1.Text == "Makine Mühendisliği" && comboBox4.Text == "4. Sınıf")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Elektroteknik");
                comboBox2.Items.Add("Rüzgar Enerjisi Santralleri"); 
                comboBox2.Items.Add("Soğutma Tekniği"); 
                comboBox2.Items.Add("Mekanik Titreşimler");
                comboBox2.Items.Add("Gaz Türbinleri");
                comboBox2.Items.Add("Kaynak Metalurjisi");
            }
            if (comboBox1.Text == "Elektrik Elektronik Mühendisliği" && comboBox4.Text == "1. Sınıf")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Genel Kimya");
                comboBox2.Items.Add("Genel Kimya Lab");
                comboBox2.Items.Add("Teknik Resim");
                comboBox2.Items.Add("Elektrik Elektronik Müh. Giriş");
                comboBox2.Items.Add("İstatistik");
                comboBox2.Items.Add("Elektrik Devre Temelleri");
            }
            if (comboBox1.Text == "Elektrik Elektronik Mühendisliği" && comboBox4.Text == "2. Sınıf")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Diferansiyel Denklemler");
                comboBox2.Items.Add("Devre Analizi");
                comboBox2.Items.Add("Elektromanyetik Dalgalar");
                comboBox2.Items.Add("Malzeme Bilgisi");
                comboBox2.Items.Add("Sinyaller ve Sistemler");
                comboBox2.Items.Add("Kompleks Analiz");
            }
            if (comboBox1.Text == "Elektrik Elektronik Mühendisliği" && comboBox4.Text == "3. Sınıf")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Kontrol Sistemlerine Giriş");
                comboBox2.Items.Add("Mikrobilgisayarlar");
                comboBox2.Items.Add("Güç Elektroniği");
                comboBox2.Items.Add("Elektrik Makinaları");
                comboBox2.Items.Add("Kumanda Devreleri");
                comboBox2.Items.Add("Yarıiletkenler ve Uygulamaları");
            }
            if (comboBox1.Text == "Elektrik Elektronik Mühendisliği" && comboBox4.Text == "4. Sınıf")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Devre Tasarımı");
                comboBox2.Items.Add("Aydınlatmma Tekniği");
                comboBox2.Items.Add("Yüksek Gerilim Tekniği");
                comboBox2.Items.Add("Mühendislik Etiği");
                comboBox2.Items.Add("Enerji Üretimi ve İletimi");
                comboBox2.Items.Add("Güç Akış Analizi ve Kararlılık");
            }
            if (comboBox1.Text == "Endüstri Mühendisliği" && comboBox4.Text == "1. Sınıf")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Endüstri Mühendisliğine Giriş");
                comboBox2.Items.Add("Genel Kimya");
                comboBox2.Items.Add("Olasılık");
                comboBox2.Items.Add("Lineer Cebir");
                comboBox2.Items.Add("İstatistik");
                comboBox2.Items.Add("Teknik Resim");
            }
            if (comboBox1.Text == "Endüstri Mühendisliği" && comboBox4.Text == "2. Sınıf")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Mekanik");
                comboBox2.Items.Add("Genel  Ekonomi");
                comboBox2.Items.Add("Halkla İlişkiler");
                comboBox2.Items.Add("Bilgisayar Programlama");
                comboBox2.Items.Add("Üretim Yönetimi");
                comboBox2.Items.Add("Diferansiyel Denklemler");
            }
            if (comboBox1.Text == "Endüstri Mühendisliği" && comboBox4.Text == "3. Sınıf")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Ergonomi");
                comboBox2.Items.Add("Sistem Simülasyonu");
                comboBox2.Items.Add("İş Etüdü");
                comboBox2.Items.Add("Tesis Planlama");
                comboBox2.Items.Add("Maliyet Analizi");
                comboBox2.Items.Add("Pazarlama Yönetimi");
            }
            if (comboBox1.Text == "Endüstri Mühendisliği" && comboBox4.Text == "4. Sınıf")
            {
                comboBox2.Items.Clear();
                comboBox2.Items.Add("Verimlilik Analizi");
                comboBox2.Items.Add("Endüstri Mühendisliği Tasarımı");
                comboBox2.Items.Add("Sistem Analizi");
                comboBox2.Items.Add("Tedarik Zinciri Yönetimi");
                comboBox2.Items.Add("Uluslararası İktisat");
                comboBox2.Items.Add("İnsan Kaynakları Yönetimi");
            }

        }
       
        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

    }
}
