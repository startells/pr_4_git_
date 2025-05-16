using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pr_4_git_
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Label lbl = new Label();
            lbl.Text = "Это вторая форма!";
            this.Controls.Add(lbl);
            TextBox txtBox = new TextBox();
            txtBox.Location = new System.Drawing.Point(10, 50);
            this.Controls.Add(txtBox);
        }
    }
}
