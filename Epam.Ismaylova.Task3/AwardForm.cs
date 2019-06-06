using BL;
using Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Epam.Ismaylova.Task3
{
    public partial class AwardForm : Form
    {
        private Award_Logic awardLogic = new Award_Logic();
        public AwardForm()
        {
            InitializeComponent();
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            awardLogic.Add(new Award(textBox1.Text));
            Close();
        }
    }
}
