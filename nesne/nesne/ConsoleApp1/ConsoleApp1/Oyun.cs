using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dapper;

namespace ConsoleApp1
{
    public partial class Oyun : Form
    {
        public Oyun()
        {
            InitializeComponent();
        }

        static string connectionString = "Data Source=DESKTOP-S657VTM\\SQLEXPRESS;Initial Catalog=demoFormaoo;Integrated Security=True";



        private List<Label> labels = new List<Label>();
        private int score = 0;
        bool d1 = true, d2 = false, d3 = false, d4 = false, bitti = false;
        private void Oyun_Load(object sender, EventArgs e)
        {
            
            // in den sonra sadece label olanlar gelsin diye 
            foreach (Label label in this.Controls.OfType<Label>())
            {
                label.BackColor = System.Drawing.Color.Transparent;
                ControlExtension.Draggable(label, true);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            foreach (Label label in this.Controls.OfType<Label>())
            {//çakışma varsa doğru 
                if (pictureBox1.Bounds.IntersectsWith(label.Bounds))
                {
                    if (pictureBox1.Tag.ToString() == label.Text)
                    {
                        label.Text = null;
                        label.Visible = false;
                        score += 5;
                        label7.Text = score.ToString();
                        MessageBox.Show("Doğru Eşleştirme");
                    }
                    else if (!string.IsNullOrEmpty(label.Text))
                    {
                        label.Location = new Point(12,384);
                        label.Text = null;
                        label.Visible = false;



                        MessageBox.Show("Hatalı Eşleştirme");
                    }
                }
                //çakışma varsa doğru 
                if (pictureBox2.Bounds.IntersectsWith(label.Bounds))
                {
                    if (pictureBox2.Tag.ToString() == label.Text)
                    {
                        label.Text = null;
                        label.Visible = false;
                        score += 5;
                        label7.Text = score.ToString();
                        MessageBox.Show("Doğru Eşleştirme");

                    }
                    else if (!string.IsNullOrEmpty(label.Text))

                    {
                        label.Text = null;
                        label.Visible = false;
                        MessageBox.Show("Hatalı Eşleştirme");

                    }
                }
                //çakışma varsa doğru 
                if (pictureBox3.Bounds.IntersectsWith(label.Bounds))
                {
                    if (pictureBox3.Tag.ToString() == label.Text)
                    {
                        label.Text = null;
                        label.Visible = false;
                        score += 5;
                        label7.Text = score.ToString();
                        MessageBox.Show("Doğru Eşleştirme");

                    }
                    else if (!string.IsNullOrEmpty(label.Text))

                    {
                        label.Text = null;
                        label.Visible = false;
                        MessageBox.Show("Hatalı Eşleştirme");

                    }
                }
                //çakışma varsa doğru 
                if (pictureBox4.Bounds.IntersectsWith(label.Bounds))
                {
                    if (pictureBox4.Tag.ToString() == label.Text)
                    {
                        label.Text = null;
                        label.Visible = false;
                        score += 5;
                        label7.Text = score.ToString();
                        MessageBox.Show("Doğru Eşleştirme");

                    }
                    else if (!string.IsNullOrEmpty(label.Text))

                    {
                        label.Text = null;
                        label.Visible = false;
                        MessageBox.Show("Hatalı Eşleştirme");

                    }
                }
                //çakışma varsa doğru 
                if (pictureBox5.Bounds.IntersectsWith(label.Bounds))
                {
                    if (pictureBox5.Tag.ToString() == label.Text)
                    {
                        label.Text = null;
                        label.Visible = false;
                        score += 5;
                        label7.Text = score.ToString();
                        MessageBox.Show("Doğru Eşleştirme");
                    }
                    else if (!string.IsNullOrEmpty(label.Text))
                    {
                        label.Text = null;
                        label.Visible = false;
                        MessageBox.Show("Hatalı Eşleştirme");

                    }
                }
            }

            if (string.IsNullOrEmpty(label1.Text) && string.IsNullOrEmpty(label2.Text) && string.IsNullOrEmpty(label3.Text) && string.IsNullOrEmpty(label4.Text) && string.IsNullOrEmpty(label5.Text) && d1)
            {
                // ilk mekan
                this.pictureBox1.Image = Properties.Resources.deve;
                pictureBox1.Tag = "Deve/Camel";
                this.pictureBox2.Image = Properties.Resources.gergedan;
                pictureBox2.Tag = "Gergedan/Rhino";
                this.pictureBox3.Image = Properties.Resources.goril;
                pictureBox3.Tag = "Goril/Gorilla";
                this.pictureBox4.Image = Properties.Resources.horoz;
                pictureBox4.Tag = "Horoz/Cockerel";
                this.pictureBox5.Image = Properties.Resources.inek;
                pictureBox5.Tag = "İnek/Cow";
                d1 = false;
                d2 = true;
            }
            else if (string.IsNullOrEmpty(label8.Text) && string.IsNullOrEmpty(label9.Text) && string.IsNullOrEmpty(label10.Text) && string.IsNullOrEmpty(label11.Text) && string.IsNullOrEmpty(label12.Text) && d2)
            {

                this.pictureBox1.Image = Properties.Resources.kanguru;
                pictureBox1.Tag = "Kanguru/Kangaroo";
                this.pictureBox2.Image = Properties.Resources.kedi;
                pictureBox2.Tag = "Kedi/Cat";
                this.pictureBox3.Image = Properties.Resources.kertenkele;
                pictureBox3.Tag = "Kertenkele/Lizard";
                this.pictureBox4.Image = Properties.Resources.kokarca;
                pictureBox4.Tag = "Kokarca/Skunk";
                this.pictureBox5.Image = Properties.Resources.koyun;
                pictureBox5.Tag = "Koyun/Sheep";
                d2 = false;
                d3 = true;
            }

            else if (string.IsNullOrEmpty(label13.Text) && string.IsNullOrEmpty(label14.Text) && string.IsNullOrEmpty(label15.Text) && string.IsNullOrEmpty(label16.Text) && string.IsNullOrEmpty(label17.Text) && d3)
            {
                this.pictureBox1.Image = Properties.Resources.köpek;
                pictureBox1.Tag = "Köpek/Dog";
                this.pictureBox2.Image = Properties.Resources.kurbağa;
                pictureBox2.Tag = "Kurbağa/Frog";
                this.pictureBox3.Image = Properties.Resources.kuş;
                pictureBox3.Tag = "Kuş/Bird";
                this.pictureBox4.Image = Properties.Resources.leylek;
                pictureBox4.Tag = "Leylek/Stork";
                this.pictureBox5.Image = Properties.Resources.maymun;
                pictureBox5.Tag = "Maymun/Monkey";
                d3 = false;
                d4 = true;
            }
            else if (string.IsNullOrEmpty(label18.Text) && string.IsNullOrEmpty(label19.Text) && string.IsNullOrEmpty(label20.Text) && string.IsNullOrEmpty(label21.Text) && string.IsNullOrEmpty(label22.Text) && d4)
            {
                d4 = false;

            }
            else if (bitti)
            {
                return; //durmuyo diye böyle bişi yaptık
            }
            else if (!d1 && !d2 && !d3 && !d4)
            {
                timer1.Enabled = false;
                timer1.Stop();
                bitti = true;
                MessageBox.Show("Tebrikler");
                using (var connection = new SqlConnection(connectionString))
                    {
                            var sqlinsert = @"insert into skor (kullanici_adi,skor) values (@kullanici_adi,@skor)";
                            connection.Execute(sqlinsert, new
                            {
                                Kullaniciadi = Login.kullaniciadi.ToString(),
                                Skor = label7.Text
                            });                       
                    }
            }
        }
    }
}

