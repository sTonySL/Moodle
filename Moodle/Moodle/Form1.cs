using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace Moodle
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String FunctionName = "core_file_get_files";
            Hashtable Hash = new Hashtable();
            Hash.Add("criteria[0][key]","username");
            Hash.Add("criteria[0][value]","admin");
            //Hash.Add("enrolments[0][courseid]", "4");

            Wskt WsktData = new Wskt(FunctionName,Hash);
            textBox1.Text = WsktData.SendRequest();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
