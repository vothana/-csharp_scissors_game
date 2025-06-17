using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace scissors_game
{
    public partial class CustomDialog : Form
    {

        public CustomDialog(string text)
        {
            InitializeComponent();
            lbl.Text = text;
        }

        public string value { get; set; }

    }
}
