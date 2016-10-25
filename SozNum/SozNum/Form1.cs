using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace SozNum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnValidate_Click(object sender, EventArgs e)
        {
            string cSozNummer = tbInput.Text;
            Regex regex = new Regex(@"^[1-9]{3}\.[1-9]{4}\.[1-9]{4}\.[1-9]{2}$"); 
            if (regex.IsMatch(cSozNummer))
            {
                lblOutput.Text = "Richtig";
             }
            else
            {
                lblOutput.Text = "Falsch";
            }
        }
    }
}
