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
    public partial class Interfaz : Form
    {
        public Interfaz()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = _TextBoxUser.Text;
            String password = _textBoxPassword.Text;
            SHA_256 _Encriptar = new SHA_256();
            String hex = _Encriptar.GetSHA_256(user+ password + user);
            _textBoxEncriptado.Text = hex;
            //MessageBox.Show("encriptado: " + hex);
        }

        
    }
}
