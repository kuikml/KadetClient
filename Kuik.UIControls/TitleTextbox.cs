using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kuik.UIControls
{
    public partial class TitleTextbox: UserControl
    {
        public string Nazwa
        {
            get { return etykieta.Text; }
            set { etykieta.Text = value; }
        }
        public string textBoxNazwa
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }

        public TitleTextbox()
        {
            InitializeComponent();
        }

        
    }
}
