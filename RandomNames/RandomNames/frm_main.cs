using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;

namespace RandomNames
{
    public partial class frm_Main : Form
    {
        List<Panel> listPanel = new List<Panel>();
        Panel current;
        Random rnd = new Random();
        string connectionString;
        SqlConnection connection;

        //On load -------------------------------------------------------------------------------------------------------
        public frm_Main()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["RandomNames.Properties.Settings.NamesConnectionString"].ToString();
            pnl_random.Visible = false;
            pnl_add_manual.Visible = false;
            pnl_remove.Visible = false;
            listPanel.Add(pnl_random);
            listPanel.Add(pnl_add_manual);
            listPanel.Add(pnl_remove);
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            populateClasses();
            current = listPanel[0];
            listPanel[0].BringToFront();
            listPanel[0].Visible = true;
        }

        //General -------------------------------------------------------------------------------------------------------
        private void populateClasses()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from Class", connection))
            {
                DataTable classTable = new DataTable();
                adapter.Fill(classTable);

                lst_class.DisplayMember = "Class";
                lst_class.ValueMember = "Id";
                lst_class.DataSource = classTable;

                lst_classes.DisplayMember = "Class";
                lst_classes.ValueMember = "Id";
                lst_classes.DataSource = classTable;
            }
        }

        private void populateStudents()
        {
            string query = @"SELECT * FROM Names a
                            INNER JOIN Class b ON a.ClassId = b.Id
                            WHERE b.Id = @ClassId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            {
                command.Parameters.AddWithValue("@ClassId", lst_classes.SelectedValue);
                DataTable studentTable = new DataTable();
                adapter.Fill(studentTable);

                lst_students.DisplayMember = "Name";
                lst_students.ValueMember = "Id";
                lst_students.DataSource = studentTable;
            }
        }

        //Buttons pushed ------------------------------------------------------------------------------------------------
        private void btn_random_Click_1(object sender, EventArgs e)
        {
            int index;
            string query = @"SELECT a.name FROM Names a
                            INNER JOIN Class b ON a.ClassId = b.Id
                            WHERE b.Id = @ClassId";
            try
            {
                using (connection = new SqlConnection(connectionString))
                using (SqlCommand command = new SqlCommand(query, connection))
                using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                {
                    command.Parameters.AddWithValue("@ClassId", lst_class.SelectedValue);
                    DataTable names = new DataTable();
                    adapter.Fill(names);
                    index = rnd.Next(0, names.Rows.Count);
                    int columnIndex = 0;
                    string[] userArr = new string[names.Rows.Count];
                    for (int i = 0; i < names.Rows.Count; i++)
                    {
                        userArr[i] = names.Rows[i][columnIndex].ToString();
                    }
                    lbl_output.Text = userArr[index];
                }
            }
            catch (NullReferenceException)
            {
                lbl_err.Text = "err no names found";
                lbl_err.Visible = true;
            }
        }

        private void btn_add_names_Click(object sender, EventArgs e)
        {
            string name;
            string text = txt_names.Text;
            string query = "INSERT INTO Class VALUES (@ClassName);";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (StringReader reader = new StringReader(text))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ClassName", txt_class.Text);
                command.ExecuteNonQuery();
                query = "INSERT INTO Names values(@Name, (SELECT Id FROM Class WHERE Class = @ClassName))";
                command.CommandText = query;
                name = reader.ReadLine();
                while (name != null)
                {
                    command.Parameters.Clear();
                    command.Parameters.AddWithValue("@ClassName", txt_class.Text);
                    command.Parameters.AddWithValue("@Name", name);
                    command.ExecuteNonQuery();
                    name = reader.ReadLine();
                    if(name == "")
                    {
                        break;
                    }
                }
                connection.Close();
                populateClasses();
            }
        }

        private void btn_remove_class_Click(object sender, EventArgs e)
        {
            string query = @"DELETE FROM Names WHERE ClassId = @ClassId;
                             DELETE FROM Class WHERE Id = @ClassId;";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@ClassId", lst_classes.SelectedValue);

                command.ExecuteNonQuery();
            }
        }

        private void btn_remove_student_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        //Menu Items Clicked --------------------------------------------------------------------------------------------
        private void randomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            current.Visible = false;
            listPanel[0].BringToFront();
            listPanel[0].Visible = true;
            current = listPanel[0];
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            current.Visible = false;
            listPanel[1].BringToFront();
            listPanel[1].Visible = true;
            current = listPanel[1];
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            current.Visible = false;
            listPanel[2].BringToFront();
            listPanel[2].Visible = true;
            current = listPanel[2];
        }

        private void lst_classes_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateStudents();
        }
    }
}
