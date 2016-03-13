using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ParseLibrary;

namespace ParseExpressionForm
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Parser parser;

        private void expressionInputTb_TextChanged(object sender, EventArgs e)
        {
            resultLabel.ResetText();
            errorLabel.ResetText();
            if (!expressionInputTb.Text.Equals(String.Empty))
            {
                parser = new Parser(expressionInputTb.Text);
                if (parser.Parse()) resultLabel.Text = parser.result.ToString();
                else errorLabel.Text = "Invalid expression";
            }
        }
    }
}
