using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace zavrsna_aplikacija
{
    public partial class Form1 : Form
    {
        List<Osoba> osobe = new List<Osoba>();
        public Form1()
        {
            InitializeComponent();
            InitializeCustomComponents();

            
        }
        private void InitializeCustomComponents()
        {
            comboBox1.Items.AddRange(new string[] { "ucenik", "profesor", "tehnciko osoblje" });
            comboBox2.Items.AddRange(new string[] { "ucenik", "profesor", "tehnciko osoblje" });
        }

        public string Uloga { get; private set; }
        public string Ime { get; private set; }
        public string Prezime { get; private set; }

        private void button1_Click(object sender, EventArgs e)
        {
            Osoba NovaOsoba = new Osoba();
            {
                Ime = textBox1.Text;
                Prezime = textBox2.Text;
                Uloga = comboBox1.SelectedItem.ToString();

            }
            
            osobe.Add(NovaOsoba);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = osobe;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string uloga = comboBox2.SelectedItem.ToString();
            var Filtriraneosobe = osobe.Where(o => o.Uloga == uloga).ToList();
            dataGridView1.DataSource = Filtriraneosobe;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            foreach (var osoba in osobe)
            {
                if (osoba.Uloga == "Učenik")
                {
                    osoba.Aktivnost = "Uči";
                }
                else if (osoba.Uloga == "Profesor")
                {
                    osoba.Aktivnost = "Predaje";
                }
                else if (osoba.Uloga == "Tehničko osoblje")
                {
                    osoba.Aktivnost = "Održava";
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = osobe;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
