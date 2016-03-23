using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Win32;
using System.IO;


namespace FinalExamComsec
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Microsoft.Win32.RegistryKey key;


        private void writekey(string key , object value)
        {
            RegistryKey rk = Registry.CurrentUser;
            RegistryKey sk1 = rk.CreateSubKey("SOFTWARE\\Luna");
            sk1.SetValue(key,value);

        }
        private void button1_Click(object sender, EventArgs e)
        {
            writekey("MyFullname","SHAIRA P. LUNA");          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            writekey("MyFullname", Encrypt.EncryptString("SHAIRA P. LUNA"));          
        }
    }
}
