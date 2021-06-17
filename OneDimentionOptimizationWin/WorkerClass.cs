using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OneDimentionOptimizationWin
{
    class WorkerClass
    {        
        public string _function { get; set; }
        public double _a { get; set; }
        public double _b { get; set; }
        public double _e { get; set; }
        public double _d { get; set; }
        public int _iteration { get; set; }

        public List<ListViewItem> DichotomyMethod(string function, double a, double b, double e, double d, int iteraton)
        {
            function.Trim();
            int _iteration = 0;
            double x1 = 0;
            double x2 = 0;
            double resultX1 = 0;
            double resultX2 = 0;
            string tempString = "";
            List<ListViewItem> OutputData = new List<ListViewItem>();
            while ((Math.Abs(b - a) >= e) & _iteration != iteraton)
            {
                x1 = (a + b - d) / 2;
                tempString = function.Replace("x", x1.ToString());
                resultX1 = (double)ReversePolishNotation.Calculate(tempString);
                x2 = (a + b + d) / 2;
                tempString = function.Replace("x", x2.ToString());
                resultX2 = (double)ReversePolishNotation.Calculate(tempString);
                OutputData.Add(new ListViewItem(resultX1.ToString()+ "   " + resultX2.ToString()));
                if (resultX1 > resultX2)
                {
                    a = x1;
                }
                else
                {
                    b = x2;
                }
                ++_iteration;
            }
                x1 = (a + b) / 2;
                tempString = function.Replace("x", x1.ToString());
                resultX1 = (double)ReversePolishNotation.Calculate(tempString);
            OutputData.Add(new ListViewItem("Точка минимума = " + resultX1.ToString()));
            return OutputData;
        }
        public List<ListViewItem> GoldenSectionMethod(string function, double a, double b, double e, double d, int iteraton)
        {
            function.Trim();
            int _iterator = 0;
            double x1 = 0;
            double x2 = 0;
            double resultX1 = 0;
            double resultX2 = 0;
            string tempStringX1 = "";
            string tempStringX2 = "";
            double _const1 = 0.381966;
            double _const2 = 1 - _const1 ;
            List<ListViewItem> OutputData = new List<ListViewItem>();
            

            do
            {
                x1 = (a + ((b - a) * _const1));
                x2 = (a + ((b - a) * _const2));

                tempStringX1 = function.Replace("x", x1.ToString());
                resultX1 = (double)ReversePolishNotation.Calculate(tempStringX1);
                tempStringX2 = function.Replace("x", x2.ToString());
                resultX2 = (double)ReversePolishNotation.Calculate(tempStringX2);
                OutputData.Add(new ListViewItem("x1=" + Math.Round(x1, 3).ToString() + " F(x1)=" + Math.Round(resultX1, 3).ToString() + "   " + "x2=" + Math.Round(x2, 3).ToString() + " F(x2)=" + Math.Round(resultX2, 3).ToString()));
                if (resultX1 < resultX2)
                {
                    b = x2;
                    x2 = x1;
                    resultX2 = resultX1;
                    x1 = a + ((b - a) * _const1);                    
                    resultX1 = (double)ReversePolishNotation.Calculate(tempStringX1);
                }
                else
                {
                    b = x2;
                    x2 = x1;
                    resultX1 = resultX2;
                    x1 = a + ((b - a) * _const1);                    
                    resultX2 = (double)ReversePolishNotation.Calculate(tempStringX2);
                }
                ++_iterator;
            }
            while ((!(Math.Abs(b - a) < e) || !(_iterator <= iteraton)) == true);

            x1 = (a + b) / 2;            
            resultX1 = (double)ReversePolishNotation.Calculate(tempStringX1);
            OutputData.Add(new ListViewItem("Точка минимума =" + Math.Round( x1, 3).ToString() + "  " + "F(x1)=" + Math.Round(resultX1, 3).ToString()));

            return OutputData;
        }

        public List<ListViewItem> MonteCarloMethod(string function, double a, double b, int iteraton)
        {
            function.Trim();
            Random rnd = new Random();            
            double x1 = 0;
            double x2 = 0;
            double resultX1 = 0;
            double resultX2 = 0;
            string tempStringX1 = "";
            string tempStringX2 = "";
            double _const1 = 0.381966;
            double _const2 = 1 - _const1;
            List<ListViewItem> OutputData = new List<ListViewItem>();

            x1 = rnd.NextDouble() * (b - a) + a;
            tempStringX1 = function.Replace("x", x1.ToString());
            resultX1 = (double)ReversePolishNotation.Calculate(tempStringX1);

            for (int i = 0; i < iteraton; i++)
            {
                x2 = rnd.NextDouble() * (b - a) + a;
                tempStringX2 = function.Replace("x", x2.ToString());
                resultX2 = (double)ReversePolishNotation.Calculate(tempStringX2);              
                    if (resultX2 < resultX1)
                    {
                        x1 = x2;
                        resultX1 = resultX2;
                    } 
                OutputData.Add(new ListViewItem( "x1=" + Math.Round(x1,3).ToString() + " F(x1)=" + Math.Round(resultX1, 3).ToString() + "   " + "x2=" + Math.Round(x2, 3).ToString() + " F(x2)=" + Math.Round(resultX2, 3).ToString()));
            }            

            return OutputData;
        }
        public bool CheKInsertData(string a, string b, string e, string d, string iteration)
        {
            bool flag = true;
            a.Trim();
            b.Trim();
            e.Trim();
            d.Trim();
            iteration.Trim();
            try
            {
                _a = Convert.ToDouble(a);
                _b = Convert.ToDouble(b);
                _e = Convert.ToDouble(e);
                _d = Convert.ToDouble(d);
                _iteration = Convert.ToInt32(iteration);

            }
            catch
            {
                flag = false;
            }
            return flag;
        }
        public bool CheKInsertData(string a, string b, string iteration)
        {
            bool flag = true;
            a.Trim();
            b.Trim();           
            iteration.Trim();
            try
            {
                _a = Convert.ToDouble(a);
                _b = Convert.ToDouble(b);               
                _iteration = Convert.ToInt32(iteration);

            }
            catch
            {
                flag = false;
            }
            return flag;
        }
    }
}
