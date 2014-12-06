using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        List<User> users = null;
        void init()
        {
            users = new List<User>();
            for (int i = 0; i < 10; i++)
                users.Add(new User());
        }
        public Form1()
        {
            InitializeComponent();
            init();

            List<User> korisnici = users.FindAll(x => x.Name == "Musa");
  
            listBox1.DataSource = users;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            users.Add(new User());
            DateTime d = DateTime.Now;
            if (d.Date == dateTimePicker1.Value.Date)
                users.Add(new User());
            string s = listBox1.SelectedItem.ToString();
        }
    }
}
