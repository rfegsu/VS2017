namespace RandomNames
{
    partial class frm_Main
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
            this.pnl_random = new System.Windows.Forms.Panel();
            this.lst_class = new System.Windows.Forms.ListBox();
            this.btn_random = new System.Windows.Forms.Button();
            this.lbl_output = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_err = new System.Windows.Forms.Label();
            this.pnl_add_manual = new System.Windows.Forms.Panel();
            this.lbl_class = new System.Windows.Forms.Label();
            this.txt_class = new System.Windows.Forms.TextBox();
            this.btn_add_names = new System.Windows.Forms.Button();
            this.lbl_names = new System.Windows.Forms.Label();
            this.txt_names = new System.Windows.Forms.RichTextBox();
            this.pnl_remove = new System.Windows.Forms.Panel();
            this.btn_remove_student = new System.Windows.Forms.Button();
            this.lst_students = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_remove_class = new System.Windows.Forms.Button();
            this.lst_classes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnl_random.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.pnl_add_manual.SuspendLayout();
            this.pnl_remove.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_random
            // 
            this.pnl_random.Controls.Add(this.lst_class);
            this.pnl_random.Controls.Add(this.btn_random);
            this.pnl_random.Controls.Add(this.lbl_output);
            this.pnl_random.Location = new System.Drawing.Point(12, 27);
            this.pnl_random.Name = "pnl_random";
            this.pnl_random.Size = new System.Drawing.Size(760, 375);
            this.pnl_random.TabIndex = 0;
            // 
            // lst_class
            // 
            this.lst_class.FormattingEnabled = true;
            this.lst_class.Location = new System.Drawing.Point(3, 3);
            this.lst_class.Name = "lst_class";
            this.lst_class.Size = new System.Drawing.Size(301, 368);
            this.lst_class.TabIndex = 2;
            // 
            // btn_random
            // 
            this.btn_random.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_random.Location = new System.Drawing.Point(467, 174);
            this.btn_random.Name = "btn_random";
            this.btn_random.Size = new System.Drawing.Size(140, 55);
            this.btn_random.TabIndex = 1;
            this.btn_random.Text = "Random";
            this.btn_random.UseVisualStyleBackColor = true;
            this.btn_random.Click += new System.EventHandler(this.btn_random_Click_1);
            // 
            // lbl_output
            // 
            this.lbl_output.Font = new System.Drawing.Font("Microsoft Sans Serif", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_output.Location = new System.Drawing.Point(310, 91);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(447, 80);
            this.lbl_output.TabIndex = 0;
            this.lbl_output.Text = "Name";
            this.lbl_output.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addToolStripMenuItem,
            this.removeToolStripMenuItem,
            this.randomToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(784, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // addToolStripMenuItem
            // 
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            this.addToolStripMenuItem.Click += new System.EventHandler(this.addToolStripMenuItem_Click);
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.removeToolStripMenuItem.Text = "Remove";
            this.removeToolStripMenuItem.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.randomToolStripMenuItem.Text = "Random";
            this.randomToolStripMenuItem.Click += new System.EventHandler(this.randomToolStripMenuItem_Click);
            // 
            // lbl_err
            // 
            this.lbl_err.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_err.ForeColor = System.Drawing.Color.Red;
            this.lbl_err.Location = new System.Drawing.Point(150, 405);
            this.lbl_err.Name = "lbl_err";
            this.lbl_err.Size = new System.Drawing.Size(500, 30);
            this.lbl_err.TabIndex = 2;
            this.lbl_err.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pnl_add_manual
            // 
            this.pnl_add_manual.Controls.Add(this.lbl_class);
            this.pnl_add_manual.Controls.Add(this.txt_class);
            this.pnl_add_manual.Controls.Add(this.btn_add_names);
            this.pnl_add_manual.Controls.Add(this.lbl_names);
            this.pnl_add_manual.Controls.Add(this.txt_names);
            this.pnl_add_manual.Location = new System.Drawing.Point(12, 27);
            this.pnl_add_manual.Name = "pnl_add_manual";
            this.pnl_add_manual.Size = new System.Drawing.Size(760, 375);
            this.pnl_add_manual.TabIndex = 3;
            // 
            // lbl_class
            // 
            this.lbl_class.AutoSize = true;
            this.lbl_class.Location = new System.Drawing.Point(133, 9);
            this.lbl_class.Name = "lbl_class";
            this.lbl_class.Size = new System.Drawing.Size(35, 13);
            this.lbl_class.TabIndex = 4;
            this.lbl_class.Text = "Class:";
            // 
            // txt_class
            // 
            this.txt_class.Location = new System.Drawing.Point(174, 5);
            this.txt_class.Name = "txt_class";
            this.txt_class.Size = new System.Drawing.Size(100, 20);
            this.txt_class.TabIndex = 3;
            // 
            // btn_add_names
            // 
            this.btn_add_names.Location = new System.Drawing.Point(52, 3);
            this.btn_add_names.Name = "btn_add_names";
            this.btn_add_names.Size = new System.Drawing.Size(75, 23);
            this.btn_add_names.TabIndex = 2;
            this.btn_add_names.Text = "Add Names";
            this.btn_add_names.UseVisualStyleBackColor = true;
            this.btn_add_names.Click += new System.EventHandler(this.btn_add_names_Click);
            // 
            // lbl_names
            // 
            this.lbl_names.AutoSize = true;
            this.lbl_names.Location = new System.Drawing.Point(3, 9);
            this.lbl_names.Name = "lbl_names";
            this.lbl_names.Size = new System.Drawing.Size(43, 13);
            this.lbl_names.TabIndex = 1;
            this.lbl_names.Text = "Names:";
            // 
            // txt_names
            // 
            this.txt_names.Location = new System.Drawing.Point(3, 32);
            this.txt_names.Name = "txt_names";
            this.txt_names.Size = new System.Drawing.Size(271, 339);
            this.txt_names.TabIndex = 0;
            this.txt_names.Text = "";
            // 
            // pnl_remove
            // 
            this.pnl_remove.Controls.Add(this.btn_remove_student);
            this.pnl_remove.Controls.Add(this.lst_students);
            this.pnl_remove.Controls.Add(this.label2);
            this.pnl_remove.Controls.Add(this.btn_remove_class);
            this.pnl_remove.Controls.Add(this.lst_classes);
            this.pnl_remove.Controls.Add(this.label1);
            this.pnl_remove.Location = new System.Drawing.Point(12, 27);
            this.pnl_remove.Name = "pnl_remove";
            this.pnl_remove.Size = new System.Drawing.Size(760, 375);
            this.pnl_remove.TabIndex = 4;
            // 
            // btn_remove_student
            // 
            this.btn_remove_student.Location = new System.Drawing.Point(132, 348);
            this.btn_remove_student.Name = "btn_remove_student";
            this.btn_remove_student.Size = new System.Drawing.Size(120, 23);
            this.btn_remove_student.TabIndex = 5;
            this.btn_remove_student.Text = "Remove Student";
            this.btn_remove_student.UseVisualStyleBackColor = true;
            this.btn_remove_student.Click += new System.EventHandler(this.btn_remove_student_Click);
            // 
            // lst_students
            // 
            this.lst_students.FormattingEnabled = true;
            this.lst_students.Location = new System.Drawing.Point(132, 21);
            this.lst_students.Name = "lst_students";
            this.lst_students.Size = new System.Drawing.Size(120, 316);
            this.lst_students.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(129, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Students";
            // 
            // btn_remove_class
            // 
            this.btn_remove_class.Location = new System.Drawing.Point(6, 348);
            this.btn_remove_class.Name = "btn_remove_class";
            this.btn_remove_class.Size = new System.Drawing.Size(120, 23);
            this.btn_remove_class.TabIndex = 2;
            this.btn_remove_class.Text = "Remove Class";
            this.btn_remove_class.UseVisualStyleBackColor = true;
            this.btn_remove_class.Click += new System.EventHandler(this.btn_remove_class_Click);
            // 
            // lst_classes
            // 
            this.lst_classes.FormattingEnabled = true;
            this.lst_classes.Location = new System.Drawing.Point(6, 21);
            this.lst_classes.Name = "lst_classes";
            this.lst_classes.Size = new System.Drawing.Size(120, 316);
            this.lst_classes.TabIndex = 1;
            this.lst_classes.SelectedIndexChanged += new System.EventHandler(this.lst_classes_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Class";
            // 
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.pnl_remove);
            this.Controls.Add(this.pnl_add_manual);
            this.Controls.Add(this.lbl_err);
            this.Controls.Add(this.pnl_random);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.pnl_random.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.pnl_add_manual.ResumeLayout(false);
            this.pnl_add_manual.PerformLayout();
            this.pnl_remove.ResumeLayout(false);
            this.pnl_remove.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnl_random;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.Label lbl_err;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.ListBox lst_class;
        private System.Windows.Forms.Panel pnl_add_manual;
        private System.Windows.Forms.Button btn_add_names;
        private System.Windows.Forms.Label lbl_names;
        private System.Windows.Forms.RichTextBox txt_names;
        private System.Windows.Forms.Label lbl_class;
        private System.Windows.Forms.TextBox txt_class;
        private System.Windows.Forms.Panel pnl_remove;
        private System.Windows.Forms.Button btn_remove_student;
        private System.Windows.Forms.ListBox lst_students;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_remove_class;
        private System.Windows.Forms.ListBox lst_classes;
        private System.Windows.Forms.Label label1;
    }
}

