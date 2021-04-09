using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Attributes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DbConfig config = new DbConfig();
            //config.ConnectToDataBase();
            //config.ConnectToDb();

            var memberType = typeof(Member);
            object[] memberAttributes = memberType.GetCustomAttributes(false);
            if(memberAttributes.Length > 0)
            {
                MemberProfileAttribute memberProfileAttribute = (MemberProfileAttribute)memberAttributes[0];
                MessageBox.Show($"{memberProfileAttribute.Fname} {memberProfileAttribute.Lname}");
            }
        }
    }
}
