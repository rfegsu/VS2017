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

namespace RandomNames
{
    public partial class frm_Main : Form
    {
        List<Panel> listPanel = new List<Panel>();
        Random rnd = new Random();
        string[] list;
        string connectionString;
        SqlConnection connection;

        public frm_Main()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["RandomNames.Properties.Settings.NamesConnectionString"].ToString();
            list = new string[] { "Fergus", "Ethan", "Arran", "Josh", "Len" };
            listPanel.Add(panel1);
        }

        private void frm_Main_Load(object sender, EventArgs e)
        {
            populateClasses();
        }

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
            }
        }

        private void manualToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listPanel[0].BringToFront();
        }

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

        private void lst_class_SelectedIndexChanged(object sender, EventArgs e)
        {
            //foreach(int index in lst_class.CheckedIndices)
            //{
            //    //get list from db and add to array
            //}
            throw new NotImplementedException();
        }


    }
}
