namespace App3
{
    public partial class Form1 : Form
    {
        List<string> myTasks = new List<string>();
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myTasks.Add(inputTB.Text);

            inputListBox.DataSource = null;
            inputListBox.DataSource = myTasks;
        }

        private void inputListBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void inputListBox_Click(object sender, EventArgs e)
        {
            if (inputListBox.SelectedIndex == -1) return;
            myTasks.RemoveAt(inputListBox.SelectedIndex);

            inputListBox.DataSource=null;
            inputListBox.DataSource = myTasks;
        }
    }
}
