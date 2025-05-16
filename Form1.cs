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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            Button btn = new Button();
            btn.Text = "Перейти на форму";
            btn.Click += (s, e) => { new Form2().Show(); };
            this.Controls.Add(btn);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
