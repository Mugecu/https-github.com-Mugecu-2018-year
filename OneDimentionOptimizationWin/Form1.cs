using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneDimentionOptimizationWin
{
    public partial class Form1 : Form
    {
        WorkerClass _wc = new WorkerClass();
        public Form1()
        {
            InitializeComponent();            
        }

        private void CalculateBtn_Click(object sender, EventArgs e)
        {
            if (OutputDataList.Items.Count != 0)
                OutputDataList.Items.Clear();

            if(DichotomyMethodRadioBtn.Checked == true)
            {
                if(_wc.CheKInsertData(A_TextBx.Text, B_TextBx.Text, E_TextBx.Text, D_TxtBx.Text, IterationTxtBx.Text) == true)
                OutputDataList.Items.AddRange((_wc.DichotomyMethod(FunctionTxtBx.Text,_wc._a,_wc._b,_wc._e,_wc._d, _wc._iteration)).ToArray());   
            }
            if(GoldenRadioBtn.Checked == true)
            {
                if (_wc.CheKInsertData(A_TextBx.Text, B_TextBx.Text, E_TextBx.Text, D_TxtBx.Text, IterationTxtBx.Text) == true)
                    OutputDataList.Items.AddRange((_wc.GoldenSectionMethod(FunctionTxtBx.Text, _wc._a, _wc._b, _wc._e, _wc._d,_wc._iteration)).ToArray());
            }
            if(MonteCarloRadioBtn.Checked == true)
            {
                if (_wc.CheKInsertData(A_TextBx.Text, B_TextBx.Text, IterationTxtBx.Text) == true)
                    OutputDataList.Items.AddRange((_wc.MonteCarloMethod(FunctionTxtBx.Text, _wc._a, _wc._b, _wc._iteration)).ToArray());
            }
            
        }

        private void MonteCarloRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
                E_TextBx.ReadOnly = true;
                D_TxtBx.ReadOnly = true;
          
        }

        private void GoldenRadioBtn_CheckedChanged(object sender, EventArgs e)
        {
            D_TxtBx.ReadOnly = true;
        }
    }   
}
