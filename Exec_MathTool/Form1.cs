using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exec_MathTool
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Text = "單一乘法表";
            this.MaximizeBox = this.MinimizeBox = false;
            this.FormBorderStyle = FormBorderStyle.Fixed3D;
            this.StartPosition = FormStartPosition.CenterParent;

            calcButton.Text = "計算";

            resultTextBox.Font = new Font("標楷體", 12, FontStyle.Bold);
            //numbercboBox.SelectedIndex = 0;

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // 
        }
    }
}
