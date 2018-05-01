using System;

namespace DatabaseExample
{
    partial class frmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRecipes = new System.Windows.Forms.Label();
            this.lstRecipes = new System.Windows.Forms.ListBox();
            this.lstIngredient = new System.Windows.Forms.ListBox();
            this.lblIngredients = new System.Windows.Forms.Label();
            this.btnAddRecipe = new System.Windows.Forms.Button();
            this.txtRecipeName = new System.Windows.Forms.TextBox();
            this.btnUpdateName = new System.Windows.Forms.Button();
            this.lstAllIngredients = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddToRecipe = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRecipes
            // 
            this.lblRecipes.AutoSize = true;
            this.lblRecipes.Location = new System.Drawing.Point(15, 83);
            this.lblRecipes.Name = "lblRecipes";
            this.lblRecipes.Size = new System.Drawing.Size(46, 13);
            this.lblRecipes.TabIndex = 0;
            this.lblRecipes.Text = "Recipes";
            // 
            // lstRecipes
            // 
            this.lstRecipes.FormattingEnabled = true;
            this.lstRecipes.Location = new System.Drawing.Point(18, 109);
            this.lstRecipes.Name = "lstRecipes";
            this.lstRecipes.Size = new System.Drawing.Size(120, 186);
            this.lstRecipes.TabIndex = 1;
            this.lstRecipes.SelectedIndexChanged += new System.EventHandler(this.lstRecipes_SelectedIndexChanged);
            // 
            // lstIngredient
            // 
            this.lstIngredient.FormattingEnabled = true;
            this.lstIngredient.Location = new System.Drawing.Point(18, 340);
            this.lstIngredient.Name = "lstIngredient";
            this.lstIngredient.Size = new System.Drawing.Size(120, 186);
            this.lstIngredient.TabIndex = 3;
            // 
            // lblIngredients
            // 
            this.lblIngredients.AutoSize = true;
            this.lblIngredients.Location = new System.Drawing.Point(15, 314);
            this.lblIngredients.Name = "lblIngredients";
            this.lblIngredients.Size = new System.Drawing.Size(96, 13);
            this.lblIngredients.TabIndex = 2;
            this.lblIngredients.Text = "Recipe Ingredients";
            // 
            // btnAddRecipe
            // 
            this.btnAddRecipe.Location = new System.Drawing.Point(12, 38);
            this.btnAddRecipe.Name = "btnAddRecipe";
            this.btnAddRecipe.Size = new System.Drawing.Size(75, 23);
            this.btnAddRecipe.TabIndex = 4;
            this.btnAddRecipe.Text = "Add Recipe";
            this.btnAddRecipe.UseVisualStyleBackColor = true;
            this.btnAddRecipe.Click += new System.EventHandler(this.btnAddRecipe_Click);
            // 
            // txtRecipeName
            // 
            this.txtRecipeName.Location = new System.Drawing.Point(12, 12);
            this.txtRecipeName.Name = "txtRecipeName";
            this.txtRecipeName.Size = new System.Drawing.Size(167, 20);
            this.txtRecipeName.TabIndex = 5;
            // 
            // btnUpdateName
            // 
            this.btnUpdateName.Location = new System.Drawing.Point(93, 38);
            this.btnUpdateName.Name = "btnUpdateName";
            this.btnUpdateName.Size = new System.Drawing.Size(86, 23);
            this.btnUpdateName.TabIndex = 6;
            this.btnUpdateName.Text = "Update Name";
            this.btnUpdateName.UseVisualStyleBackColor = true;
            this.btnUpdateName.Click += new System.EventHandler(this.btnUpdateName_Click);
            // 
            // lstAllIngredients
            // 
            this.lstAllIngredients.FormattingEnabled = true;
            this.lstAllIngredients.Location = new System.Drawing.Point(184, 109);
            this.lstAllIngredients.Name = "lstAllIngredients";
            this.lstAllIngredients.Size = new System.Drawing.Size(120, 186);
            this.lstAllIngredients.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(181, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "All Ingredients";
            // 
            // btnAddToRecipe
            // 
            this.btnAddToRecipe.Location = new System.Drawing.Point(187, 309);
            this.btnAddToRecipe.Name = "btnAddToRecipe";
            this.btnAddToRecipe.Size = new System.Drawing.Size(117, 23);
            this.btnAddToRecipe.TabIndex = 9;
            this.btnAddToRecipe.Text = "Add To Recipe";
            this.btnAddToRecipe.UseVisualStyleBackColor = true;
            this.btnAddToRecipe.Click += new System.EventHandler(this.btnAddToRecipe_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 574);
            this.Controls.Add(this.btnAddToRecipe);
            this.Controls.Add(this.lstAllIngredients);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdateName);
            this.Controls.Add(this.txtRecipeName);
            this.Controls.Add(this.btnAddRecipe);
            this.Controls.Add(this.lstIngredient);
            this.Controls.Add(this.lblIngredients);
            this.Controls.Add(this.lstRecipes);
            this.Controls.Add(this.lblRecipes);
            this.Name = "frmMain";
            this.Text = "Cookbook";
            this.Load += new System.EventHandler(this.frmMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion

        private System.Windows.Forms.Label lblRecipes;
        private System.Windows.Forms.ListBox lstRecipes;
        private System.Windows.Forms.ListBox lstIngredient;
        private System.Windows.Forms.Label lblIngredients;
        private System.Windows.Forms.Button btnAddRecipe;
        private System.Windows.Forms.TextBox txtRecipeName;
        private System.Windows.Forms.Button btnUpdateName;
        private System.Windows.Forms.ListBox lstAllIngredients;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnAddToRecipe;
    }
}

