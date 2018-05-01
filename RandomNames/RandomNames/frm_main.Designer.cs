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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lst_class = new System.Windows.Forms.ListBox();
            this.btn_random = new System.Windows.Forms.Button();
            this.lbl_output = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.addToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.manualToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromExcelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromTxtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fromWebTableToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.randomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.allToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_err = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lst_class);
            this.panel1.Controls.Add(this.btn_random);
            this.panel1.Controls.Add(this.lbl_output);
            this.panel1.Location = new System.Drawing.Point(12, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(760, 375);
            this.panel1.TabIndex = 0;
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
            this.btn_random.Location = new System.Drawing.Point(310, 300);
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
            this.lbl_output.Location = new System.Drawing.Point(297, 217);
            this.lbl_output.Name = "lbl_output";
            this.lbl_output.Size = new System.Drawing.Size(460, 80);
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
            this.addToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.manualToolStripMenuItem,
            this.fromExcelToolStripMenuItem,
            this.fromTxtToolStripMenuItem,
            this.fromWebTableToolStripMenuItem});
            this.addToolStripMenuItem.Name = "addToolStripMenuItem";
            this.addToolStripMenuItem.Size = new System.Drawing.Size(41, 20);
            this.addToolStripMenuItem.Text = "Add";
            // 
            // manualToolStripMenuItem
            // 
            this.manualToolStripMenuItem.Name = "manualToolStripMenuItem";
            this.manualToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.manualToolStripMenuItem.Text = "Manual";
            this.manualToolStripMenuItem.Click += new System.EventHandler(this.manualToolStripMenuItem_Click);
            // 
            // fromExcelToolStripMenuItem
            // 
            this.fromExcelToolStripMenuItem.Name = "fromExcelToolStripMenuItem";
            this.fromExcelToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.fromExcelToolStripMenuItem.Text = "From Excel";
            // 
            // fromTxtToolStripMenuItem
            // 
            this.fromTxtToolStripMenuItem.Name = "fromTxtToolStripMenuItem";
            this.fromTxtToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.fromTxtToolStripMenuItem.Text = "From txt";
            // 
            // fromWebTableToolStripMenuItem
            // 
            this.fromWebTableToolStripMenuItem.Name = "fromWebTableToolStripMenuItem";
            this.fromWebTableToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.fromWebTableToolStripMenuItem.Text = "From Web Table";
            // 
            // removeToolStripMenuItem
            // 
            this.removeToolStripMenuItem.Name = "removeToolStripMenuItem";
            this.removeToolStripMenuItem.Size = new System.Drawing.Size(62, 20);
            this.removeToolStripMenuItem.Text = "Remove";
            // 
            // randomToolStripMenuItem
            // 
            this.randomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.allToolStripMenuItem});
            this.randomToolStripMenuItem.Name = "randomToolStripMenuItem";
            this.randomToolStripMenuItem.Size = new System.Drawing.Size(64, 20);
            this.randomToolStripMenuItem.Text = "Random";
            // 
            // allToolStripMenuItem
            // 
            this.allToolStripMenuItem.Name = "allToolStripMenuItem";
            this.allToolStripMenuItem.Size = new System.Drawing.Size(88, 22);
            this.allToolStripMenuItem.Text = "All";
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
            // frm_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.lbl_err);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm_Main";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.frm_Main_Load);
            this.panel1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem addToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem manualToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromExcelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromTxtToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fromWebTableToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem randomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem allToolStripMenuItem;
        private System.Windows.Forms.Label lbl_err;
        private System.Windows.Forms.Label lbl_output;
        private System.Windows.Forms.Button btn_random;
        private System.Windows.Forms.ListBox lst_class;
    }
}

