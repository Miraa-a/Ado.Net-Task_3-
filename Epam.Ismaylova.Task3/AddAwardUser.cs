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
    public partial class AddAwardUser : Form
    {
        private User_Logic userLogic = new User_Logic();
        private Award_Logic awardLogic = new Award_Logic();
        public AddAwardUser()
        {
            InitializeComponent();
            comboBox1.DataSource = userLogic.GetAll();
            comboBox2.DataSource = awardLogic.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User<string> a = (User<string>)comboBox1.SelectedItem;
            Award b = (Award)comboBox2.SelectedItem;
            awardLogic.AddUserAward(a.ID,b.ID);
            Close();
        }
    }
}
