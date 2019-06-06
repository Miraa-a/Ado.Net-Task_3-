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
    
    public partial class Add_User : Form
    {
        private User_Logic users_Logic = new User_Logic();
        public Add_User()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            TimeSpan age = DateTime.Now - dateTimePicker1.Value;
            users_Logic.Add(new User<int>(textBox1.Text, dateTimePicker1.Value, age.Days/365));
            Close();
        }

      
    }
}
