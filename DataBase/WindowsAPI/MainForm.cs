using WindowsFormsApp1.DataBaseEditor;

namespace WindowsAPI
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormEditorTable1 table1 = new FormEditorTable1();
            table1.ShowDialog();
        }
    }
}