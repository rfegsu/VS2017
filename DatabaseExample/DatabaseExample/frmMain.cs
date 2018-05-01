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

namespace DatabaseExample
{
    public partial class frmMain : Form
    {
        string connectionString;
        SqlConnection connection;

        public frmMain()
        {
            InitializeComponent();
            connectionString = ConfigurationManager.ConnectionStrings["DatabaseExample.Properties.Settings.CookbookConnectionString"].ConnectionString;
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            populateRecipes();
            populateAllIngredient();
        }

        private void populateRecipes()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from recipe", connection))
            {
                DataTable recipeTable = new DataTable();
                adapter.Fill(recipeTable);

                lstRecipes.DisplayMember = "Name";
                lstRecipes.ValueMember = "Id";
                lstRecipes.DataSource = recipeTable;
            }
        }

        private void populateAllIngredient()
        {
            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter("Select * from Ingredient", connection))
            {
                DataTable allIngredientTable = new DataTable();
                adapter.Fill(allIngredientTable);

                lstAllIngredients.DisplayMember = "Name";
                lstAllIngredients.ValueMember = "Id";
                lstAllIngredients.DataSource = allIngredientTable;
            }
        }

        private void populateIngredient()
        {
            string query = @"SELECT a.Name FROM Ingredient a
            INNER JOIN RecipeIngredient b ON a.Id = b.IngredientId
            WHERE b.RecipeId = @RecipeId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            using (SqlDataAdapter adapter = new SqlDataAdapter(command))
            //sqladapters are needed when retreiving data from a database
            //no need to open a connection if an adapater is used
            {
                command.Parameters.AddWithValue("@RecipeId", lstRecipes.SelectedValue);

                DataTable ingredientTable = new DataTable();
                adapter.Fill(ingredientTable);

                lstIngredient.DisplayMember = "Name";
                lstIngredient.ValueMember = "Id";
                lstIngredient.DataSource = ingredientTable;
            }
        }

        private void lstRecipes_SelectedIndexChanged(object sender, EventArgs e)
        {
            populateIngredient();
        }

        private void btnAddRecipe_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Recipe VALUES (@RecipeName, 80, 'blah blah')";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            //using statements handle the closing of the database connetion
            //sqlcommand is used when you don't need to get data from the database
            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeName", txtRecipeName.Text);

                command.ExecuteNonQuery();
                populateRecipes();
                txtRecipeName.Text = "";
            }
        }

        private void btnUpdateName_Click(object sender, EventArgs e)
        {
            string query = "UPDATE Recipe SET Name = @RecipeName WHERE Id = @RecipeId";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@RecipeName", txtRecipeName.Text);
                command.Parameters.AddWithValue("@RecipeId", lstRecipes.SelectedValue);
                command.ExecuteNonQuery();

                populateRecipes();
                txtRecipeName.Text = "";
            }
        }

        private void btnAddToRecipe_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO RecipeIngredient VALUES (@RecipeId, @IngredientId)";
            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();
                command.Parameters.AddWithValue("@RecipeId", lstRecipes.SelectedValue);
                command.Parameters.AddWithValue("@IngredientId", lstAllIngredients.SelectedValue);

                command.ExecuteNonQuery();
                populateRecipes();
                txtRecipeName.Text = "";
            }
        }
    }
}
