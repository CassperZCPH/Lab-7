using System.Windows.Forms;

namespace RtfRedactor
{
    public partial class NewFileForm : Form
    {
        public string fileName = "";
        public NewFileForm()
        {
            InitializeComponent();
        }

        private void NewFileForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            fileName = textBox1.Text;
        }
    }
}
