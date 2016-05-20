using System;
using System.Windows.Forms;

namespace twitterPruebas
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String comment = _textBoxComentario.Text;
            MessageBox.Show("ud escribio: " + comment);
            PublicarTwetter newTweet = new PublicarTwetter();
            newTweet.PublicarTweet(comment);
        }
    }
}
