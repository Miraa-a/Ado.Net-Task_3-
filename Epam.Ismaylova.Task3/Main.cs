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
    public partial class Main : Form
    {
        private User_Logic users_Logic = new User_Logic();
        private Award_Logic award_Logic = new Award_Logic();
        
        public Main()
        {
            InitializeComponent();
           dataGridView1.DataSource = users_Logic.GetAll();
           dataGridView2.DataSource = award_Logic.GetAll();
         
        }

     

        private void button1_Click(object sender, EventArgs e)
        {
            Add_User f = new Add_User();
            f.Show();
        }

        

        private void button4_Click(object sender, EventArgs e)
        {
            AwardForm f = new AwardForm();
            f.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            GetAwards f = new GetAwards();
            f.Show();
        }

       

        private void button2_Click_1(object sender, EventArgs e)
        {
            RemoveUser f = new RemoveUser();
            f.Show();
           
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            AwardForm f = new AwardForm();
            f.Show();
            
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            GetAwards f = new GetAwards();
            f.Show();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            dataGridView1.DataSource = users_Logic.GetAll();
            dataGridView2.DataSource = award_Logic.GetAll();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AddAwardUser f = new AddAwardUser();
            f.Show();
        }

       


    }
}
