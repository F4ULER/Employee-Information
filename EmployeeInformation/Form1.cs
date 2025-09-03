using System.Data;
using System.Globalization;

namespace EmployeeInformation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            StartPosition = FormStartPosition.CenterScreen;
        }

        private void buttonEmployeeInformation_Click(object sender, EventArgs e)
        {
            //buttonEmployeeInformation.Visible = false;
            if (buttonStatistics.Visible)
            {
                buttonStatistics.Visible = false;
                dataGridView.Visible = true;
                buttonFilter.Visible = true;
                buttonSort.Visible = true;
                buttonSearch.Visible = true;
            }
            else
            {
                buttonStatistics.Visible = true;
                dataGridView.Visible = false;
                buttonFilter.Visible = false;
                buttonSort.Visible = false;
                buttonSearch.Visible = false;

                hideFilter();
                hideSort();
            }
        }

        private void buttonStatistics_Click(object sender, EventArgs e)
        {
            if (buttonEmployeeInformation.Visible)
            {
                panelStatistics.Visible = true;
                buttonEmployeeInformation.Visible = false;

                comboBoxDateNameStatistics.SelectedIndex = 0;

                comboBoxStatusStatistics.DataSource = definingUniqueValues(1);
            }
            else
            {
                panelStatistics.Visible = false;
                buttonEmployeeInformation.Visible = true;
            }
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

        private void hideFilter()
        {
            panelFilter.Visible = false;
            comboBoxStatus.SelectedText = "";
            comboBoxDep.SelectedText = "";
            comboBoxPost.SelectedText = "";
        }

        private void buttonFilter_Click(object sender, EventArgs e)
        {
            if (panelFilter.Visible == false)
            {
                panelFilter.Visible = true;

                comboBoxStatus.DataSource = definingUniqueValues(1);
                comboBoxDep.DataSource = definingUniqueValues(2);
                comboBoxPost.DataSource = definingUniqueValues(3);
            }
            else
            {
                hideFilter();
            }

        }

        private void hideSort()
        {
            panelSort.Visible = false;
            RadioButton[] radioButtons = { rBFIO, rBStatus, rBDep, rBPost, rBDateEmploy, rBDateUneploy };
            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    radioButton.Checked = false;
                }
            }
        }

        private void buttonSort_Click(object sender, EventArgs e)
        {
            if (panelSort.Visible == false)
                panelSort.Visible = true;
            else
            {
                hideSort();
            }
        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();

            RadioButton[] radioButtons = { rBFIO, rBStatus, rBDep, rBPost, rBDateEmploy, rBDateUneploy };

            string sortBy = "",
                    status = comboBoxStatus.SelectedValue != null ? comboBoxStatus.SelectedValue.ToString() : "",
                    dep = comboBoxDep.SelectedValue != null ? comboBoxDep.SelectedValue.ToString() : "",
                    post = comboBoxPost.SelectedValue != null ? comboBoxPost.SelectedValue.ToString() : "";

            foreach (var radioButton in radioButtons)
            {
                if (radioButton.Checked)
                {
                    sortBy = radioButton.Text;
                }
            }

            dataGridView.DataSource = dataBase.sendCommandOutputNotes(sortBy, status, dep, post, textBoxLastName.Text);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            panelFilter.Visible = false;
            panelSort.Visible = false;
            dataGridView.Visible = false;
            buttonSort.Visible = false;
            buttonFilter.Visible = false;
            buttonSearch.Visible = false;
            panelStatistics.Visible = false;

            textBoxLastName.Text = "";

            comboBoxDateNameStatistics.Items.Add("");
            comboBoxDateNameStatistics.Items.Add("Дата приема");
            comboBoxDateNameStatistics.Items.Add("Дата увольнения");

            comboBoxDateNameStatistics.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatus.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxDep.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPost.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxStatusStatistics.DropDownStyle = ComboBoxStyle.DropDownList;

        }
        private void EnabledButtonShowStatistics()
        {
            if ((comboBoxStatusStatistics.SelectedIndex != 0 && comboBoxDateNameStatistics.SelectedIndex == 0) || (comboBoxStatusStatistics.SelectedIndex == 0 && comboBoxDateNameStatistics.SelectedIndex != 0))
            {
                buttonShowStatistics.Enabled = true;
            }
            else buttonShowStatistics.Enabled = false;
        }

        private void comboBoxStatusStatistics_TextChanged(object sender, EventArgs e)
        {
            EnabledButtonShowStatistics();
        }

        private void comboBoxDateNameStatistics_TextChanged(object sender, EventArgs e)
        {
            EnabledButtonShowStatistics();
        }

        private void buttonShowStatistics_Click(object sender, EventArgs e)
        {
            string status = comboBoxStatusStatistics.SelectedItem != null ? comboBoxStatusStatistics.SelectedItem.ToString() : "",
            dateName = comboBoxDateNameStatistics.SelectedItem != null ? comboBoxDateNameStatistics.SelectedItem.ToString() : "";

            DataBase dataBase = new DataBase();
            MessageBox.Show("Найдено " + @dataBase.sendCommandGetStatistics(status, dateName, firsrtDateStatistics.Value.ToString("yyyy-MM-dd"), secondDateStatistics.Value.ToString("yyyy-MM-dd")) + " записи", "Статистика");
        }
    }
}
