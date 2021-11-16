using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tapanyagok.Models;
using Tapanyagok.ViewInterfaces;

namespace Tapanyagok.Views
{
    public partial class TapanyagForm : Form, ITapanyagView
    {
        private int id;
        public TapanyagForm()
        {
            InitializeComponent();
        }

        public tapanyag tapanyag 
        {
            get
            {
                return new tapanyag(id,
                    textBox1.Text, 
                    EnergianumericUpDown.Value,
                    FeherjenumericUpDown.Value, 
                    ZsirnumericUpDown.Value,
                    SzenhidratnumericUpDown.Value);
            }
            set
            {
                id = value.id;
                textBox1.Text = value.nev;
                EnergianumericUpDown.Value = value.energia;
                FeherjenumericUpDown.Value = value.feherje;
                ZsirnumericUpDown.Value = value.zsir;
                SzenhidratnumericUpDown.Value = value.szenhidrat;
            }
        }
    }
}
