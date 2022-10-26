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
            
            numbercboBox.SelectedIndex = 0;

        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // 取得被選取的數值
            int firstNumber = GetNumber();

            // 生成班一乘法表
            string table = RenderSingleTable(firstNumber);

            // 呈現結果
            resultTextBox.Text = table;
        }

        private string RenderSingleTable(int firstNumber)
        {
            string table = string.Empty;
            for (int i = 1; i < 9; i++)
            {
                table += $"{firstNumber} * {i} = {firstNumber * i}\r\n";
            }
            return table;
        }

        private int GetNumber()
        => Convert.ToInt32(numbercboBox.SelectedItem);
            
        
    }
}
