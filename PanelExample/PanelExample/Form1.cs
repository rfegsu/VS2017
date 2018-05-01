using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PanelExample
{
    public partial class Form1 : Form
    {
        List<Panel> listPanel = new List<Panel>();
        int index = 0;
        public Form1()
        {
            InitializeComponent();
            listPanel.Add(panel1);
            listPanel.Add(panel2);
            listPanel.Add(panel3);
            listPanel[index].BringToFront();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                index--;
                listPanel[index].BringToFront();
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if(index < listPanel.Count-1)
            {
                index++;
                listPanel[index].BringToFront();
            }
        }
    }
}
