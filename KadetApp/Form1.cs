using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KadetApp.API;

namespace KadetApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private async void textBox1_KeyUp(object sender, KeyEventArgs e)
        {
            await SzukajPracownikow();
        }

        private async void button1_Click(object sender, EventArgs e)
        {
            await SzukajPracownikow();
        }

        private async Task SzukajPracownikow()
        {
            KadryServiceClient kadry = new KadryServiceClient();

            pracownikBindingSource.DataSource = await kadry.WyszukajPracownikaAsync(textBox1.Text);
        }
    }
}
