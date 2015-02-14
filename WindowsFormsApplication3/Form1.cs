using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication3
{
    public partial class Form1 : Form
    {
        int BossLife = 1000, MaxBossLife = 1000, Hp = 1000, damage, BossDamage;
        Random rnq = new Random();    
        
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Random rn = new Random();
            
            damage = 10 + rn.Next(-5, +5);
            label1.ForeColor = Color.Lime;
            if (rn.Next(0, 100) <= 25)
            {
                damage = 50 + rn.Next(-5, +5);
                label1.ForeColor = Color.Red;
            }

            BossDamage = 7 + rn.Next(-5, +5);
            label2.ForeColor = Color.Lime;
            if (rn.Next(0, 100) <= 15)
            {
                BossDamage = 60 + rn.Next(-5, +5);
                label2.ForeColor = Color.Red;
            }
            
            Hp -= BossDamage;
            if (progressBar2.Value - damage <= 0)
            {
                MaxBossLife += 250;
                BossLife = MaxBossLife;
                progressBar2.Maximum = BossLife;
                progressBar2.Value = progressBar2.Maximum;
                //pictureBox3.Visible = false;
                if (rnq.Next(0, 100) <= 5)
                {
                    listBox2.Items.Add(Rare.Items[rnq.Next(0, Rare.Items.Count)]);
                    listBox3.Items.Add(rnq.Next(5000, 50000));
                    listBox4.Items.Add(rnq.Next(500, 5000));
                    listBox5.Items.Add(rnq.Next(25, 99));
                }
                else
                {
                    if (rnq.Next(0, 100) <= 35)
                    {
                        listBox2.Items.Add(Magical.Items[rnq.Next(0, Magical.Items.Count)]);
                        listBox3.Items.Add(rnq.Next(500, 15000));
                        listBox4.Items.Add(rnq.Next(500, 1500));
                        listBox5.Items.Add(rnq.Next(25, 70));
                    }
                    else
                    {
                        listBox2.Items.Add(Classical.Items[rnq.Next(0, Classical.Items.Count)]);
                        listBox3.Items.Add(rnq.Next(1, 500));
                        listBox4.Items.Add(rnq.Next(1, 500));
                        listBox5.Items.Add(rnq.Next(1, 50));
                    }
                }
                
                
                Hp = 1000;
                progressBar1.Value = Hp;
            }
            else
            {
                progressBar2.Value -= damage;
                label2.Text = BossDamage.ToString();
            }
            if (progressBar1.Value - BossDamage <= 0)
            {
                Form2 f = new Form2();
                f.Show();

            }
            else
            {
                progressBar1.Value -= BossDamage;
                label1.Text = damage.ToString();
                
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        }
    }

