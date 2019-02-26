using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        Timer t = new Timer();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'testeDataSet.area'. Você pode movê-la ou removê-la conforme necessário.
            this.areaTableAdapter.Fill(this.testeDataSet.area);
            label1.Text = DateTime.Now.ToString();
            t.Interval = 900;
            t.Enabled = true;
            t.Tick += new EventHandler(timer1_Tick);

        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in this.dataGridView1.SelectedRows)
            {
                try
                {
                    label2.Text = dataGridView1[0, item.Index].Value.ToString();
                }
                catch (Exception)
                {
                }
            }
        }
    }
}
