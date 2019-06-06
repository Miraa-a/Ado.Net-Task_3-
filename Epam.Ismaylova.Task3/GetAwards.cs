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
    public partial class GetAwards : Form
    {
        private User_Logic userLogic = new User_Logic();
        private Award_Logic awardLogic = new Award_Logic();

        public GetAwards()
        {
            InitializeComponent();
           // dataGridView1.DataSource = userLogic.GetAll();
            comboBox1.DataSource = userLogic.GetAll();
            //  comboBox2.DataSource = awardLogic.GetAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
          User<string> c = (User<string>)comboBox1.SelectedItem;
           // Award a = (Award)comboBox2.SelectedItem;
            //awardLogic.GetAllUserAndAwards(c.ID);
            dataGridView1.DataSource = awardLogic.GetAllUserAndAwards(c.ID);
        }

      
    }
}
