using System.Data;
using System.Linq;

namespace EmployeeInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            panelFilter.Visible = false;
            panelSort.Visible = false;
            dataGridView.Visible = false;
            buttonSort.Visible = false;
            buttonFilter.Visible = false;
            buttonSearch.Visible = false;
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonEmployeeInformation_Click(object sender, EventArgs e)
        {
            //buttonEmployeeInformation.Visible = false;
            buttonStatistics.Visible = false;
            dataGridView.Visible = true;
            buttonFilter.Visible = true;
            buttonSort.Visible = true;
            buttonSearch.Visible = true;
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            //buttonStatistics.Visible = false;
            buttonEmployeeInformation.Visible = false;
        }

        private void comboBox3_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private List<string> definingUniqueValues(int col)
        {
            DataBase dataBase = new DataBase();
            DataTable table = new DataTable();
            HashSet<string> data = new HashSet<string>();

            table = dataBase.sendCommandOutputNotes();

            data.Add("");
            for (int i = 0; i < table.Rows.Count; i++)
            {
                data.Add(table.Rows[i][col].ToString());
            }
            return data.ToList();

        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            panelFilter.Visible = true;

            comboBoxStatus.DataSource = definingUniqueValues(1);
            comboBoxDep.DataSource = definingUniqueValues(2);
            comboBoxPost.DataSource = definingUniqueValues(3);
            
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            panelSort.Visible = true;
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            
            RadioButton[] radioButtons = { rBFIO, rBStatus, rBDep, rBPost, rBDateEmploy, rBDateUneploy};

            string sortBy = "";
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    sortBy = radioButton.Text;
                }
            }

            string filter = "";

            dataGridView.DataSource = dataBase.sendCommandOutputNotes(sortBy);

        }
    }
}
