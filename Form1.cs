using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment_1
{
    public partial class clcForm : Form
    {
        public clcForm()
        {
            InitializeComponent();
        }

        private void txt_ansDisp_TextChanged(object sender, EventArgs e)
        {

        }

        private void clcForm_Load(object sender, EventArgs e)
        {
            txt_ansDisp.Focus();
        }

        private void btn_nine_Click(object sender, EventArgs e)
        {
            if (txt_ansDisp.Text != "")
            {
                txt_ansDisp.Text += "9";
            }
            else
            {
                txt_ansDisp.Text = "9";
            }
            txt_ansDisp.Focus();

        }

        private void btn_one_Click(object sender, EventArgs e)
        {
            if (txt_ansDisp.Text != "")
            {
                txt_ansDisp.Text += "1";
            }
            else
            {
                txt_ansDisp.Text = "1";
            }
            txt_ansDisp.Focus();
        }

        private void btn_two_Click(object sender, EventArgs e)
        {
            if (txt_ansDisp.Text != "")
            {
                txt_ansDisp.Text += "2";
            }
            else
            {
                txt_ansDisp.Text = "2";
            }
            txt_ansDisp.Focus();
        }

        private void btn_three_Click(object sender, EventArgs e)
        {
            if (txt_ansDisp.Text != "")
            {
                txt_ansDisp.Text += "3";
            }
            else
            {
                txt_ansDisp.Text = "3";
            }
            txt_ansDisp.Focus();
        }

        private void btn_four_Click(object sender, EventArgs e)
        {
            if (txt_ansDisp.Text != "")
            {
                txt_ansDisp.Text += "4";
            }
            else
            {
                txt_ansDisp.Text = "4";
            }
            txt_ansDisp.Focus();
        }

        private void btn_five_Click(object sender, EventArgs e)
        {
            if (txt_ansDisp.Text != "")
            {
                txt_ansDisp.Text += "5";
            }
            else
            {
                txt_ansDisp.Text = "5";
            }
            txt_ansDisp.Focus();
        }

        private void btn_six_Click(object sender, EventArgs e)
        {
            if (txt_ansDisp.Text != "")
            {
                txt_ansDisp.Text += "6";
            }
            else
            {
                txt_ansDisp.Text = "6";
            }
            txt_ansDisp.Focus();
        }

        private void btn_seven_Click(object sender, EventArgs e)
        {
            if (txt_ansDisp.Text != "")
            {
                txt_ansDisp.Text += "7";
            }
            else
            {
                txt_ansDisp.Text = "7";
            }
            txt_ansDisp.Focus();
        }

        private void btn_eight_Click(object sender, EventArgs e)
        {
            if (txt_ansDisp.Text != "")
            {
                txt_ansDisp.Text += "8";
            }
            else
            {
                txt_ansDisp.Text = "8";
            }
            txt_ansDisp.Focus();
        }

        private void btn_zero_Click(object sender, EventArgs e)
        {
            if (txt_ansDisp.Text != "")
            {
                txt_ansDisp.Text += "0";
            }
            else
            {
                txt_ansDisp.Text = "0";
            }
            txt_ansDisp.Focus();
        }

        private int pointIsClicked = 2;

        private void btn_point_Click(object sender, EventArgs e)
        {
            string tempStr = txt_ansDisp.Text.ToString();

            if (tempStr.IndexOf(".") == -1 || pointIsClicked != 0)
            {
                if (txt_ansDisp.Text != "")
                {
                    txt_ansDisp.Text += ".";
                }
                else
                {
                    txt_ansDisp.Text = "0.";
                }
                pointIsClicked--;
            }
            txt_ansDisp.Focus();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            txt_ansDisp.Clear();
            txt_ansDisp.Focus();
            equalBtnWasClicked = false;
            pointIsClicked = 2;
        }

        private void txt_ansDisp_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Delete || e.KeyData == Keys.Back)
            {
                btn_clearEntry_Click(sender, e);
                txt_ansDisp.Focus();
            }

            if (e.KeyData == Keys.D0 || e.KeyData == Keys.NumPad0)
            {
                if (txt_ansDisp.Text != "")
                {
                    txt_ansDisp.Text += "0";
                }
                else
                {
                    txt_ansDisp.Text = "0";
                }
                txt_ansDisp.Focus();
            }

            if (e.KeyData == Keys.D1 || e.KeyData == Keys.NumPad1)
            {
                if (txt_ansDisp.Text != "")
                {
                    txt_ansDisp.Text += "1";
                }
                else
                {
                    txt_ansDisp.Text = "1";
                }
                txt_ansDisp.Focus();
            }

            if (e.KeyData == Keys.D2 || e.KeyData == Keys.NumPad2)
            {
                if (txt_ansDisp.Text != "")
                {
                    txt_ansDisp.Text += "2";
                }
                else
                {
                    txt_ansDisp.Text = "2";
                }
                txt_ansDisp.Focus();
            }

            if (e.KeyData == Keys.D3 || e.KeyData == Keys.NumPad3)
            {
                if (txt_ansDisp.Text != "")
                {
                    txt_ansDisp.Text += "3";
                }
                else
                {
                    txt_ansDisp.Text = "3";
                }
                txt_ansDisp.Focus();
            }

            if (e.KeyData == Keys.D4 || e.KeyData == Keys.NumPad4)
            {
                if (txt_ansDisp.Text != "")
                {
                    txt_ansDisp.Text += "4";
                }
                else
                {
                    txt_ansDisp.Text = "4";
                }
                txt_ansDisp.Focus();
            }

            if (e.KeyData == Keys.D5 || e.KeyData == Keys.NumPad5)
            {
                if (txt_ansDisp.Text != "")
                {
                    txt_ansDisp.Text += "5";
                }
                else
                {
                    txt_ansDisp.Text = "5";
                }
                txt_ansDisp.Focus();
            }

            if (e.KeyData == Keys.D6 || e.KeyData == Keys.NumPad6)
            {
                if (txt_ansDisp.Text != "")
                {
                    txt_ansDisp.Text += "6";
                }
                else
                {
                    txt_ansDisp.Text = "6";
                }
                txt_ansDisp.Focus();
            }

            if (e.KeyData == Keys.D7 || e.KeyData == Keys.NumPad7)
            {
                if (txt_ansDisp.Text != "")
                {
                    txt_ansDisp.Text += "7";
                }
                else
                {
                    txt_ansDisp.Text = "7";
                }
                txt_ansDisp.Focus();
            }

            if (e.KeyData == Keys.D8 || e.KeyData == Keys.NumPad8)
            {
                if (txt_ansDisp.Text != "")
                {
                    txt_ansDisp.Text += "8";
                }
                else
                {
                    txt_ansDisp.Text = "8";
                }
                txt_ansDisp.Focus();
            }

            if (e.KeyData == Keys.D9 || e.KeyData == Keys.NumPad9)
            {
                if (txt_ansDisp.Text != "")
                {
                    txt_ansDisp.Text += "9";
                }
                else
                {
                    txt_ansDisp.Text = "9";
                }
                txt_ansDisp.Focus();
            }

            if (e.KeyData == Keys.Add)
            {
                btn_plus_Click(sender, e);
            }

            if (e.KeyData == Keys.Subtract)
            {
                btn_minus_Click(sender, e);
            }

            if (e.KeyData == Keys.Multiply)
            {
                btn_multiply_Click(sender, e);
            }

            if (e.KeyData == Keys.Divide)
            {
                btn_divide_Click(sender, e);
            }

            string tempStr = txt_ansDisp.Text.ToString();

            if (e.KeyData == Keys.Decimal)
            {
                if (tempStr.IndexOf(".") == -1 || pointIsClicked != 0)
                {
                    if (txt_ansDisp.Text != "")
                    {
                        txt_ansDisp.Text += ".";
                    }
                    else
                    {
                        txt_ansDisp.Text = "0.";
                    }

                    pointIsClicked--;

                    txt_ansDisp.Focus();
                }
            }

            if(e.KeyData == Keys.Enter)
            {
                btn_equal_Click(sender, e);

                txt_ansDisp.Focus();
                
            }

        }

        private void btn_clearEntry_Click(object sender, EventArgs e)
        {
            if (txt_ansDisp.Text != "")
            {
                StringBuilder tempString = new StringBuilder(txt_ansDisp.Lines[0].ToString());
                
                txt_ansDisp.Clear();
                
                int tempStringLen = tempString.Length - 1;

                if(tempString[tempStringLen].ToString().Equals("."))
                {
                    pointIsClicked++;
                }

                tempString[tempStringLen] = '\0';
                
                txt_ansDisp.Text = tempString.ToString();
                
                equalBtnWasClicked = false;   
            }
            else
            {
                txt_ansDisp.Clear();
            }
            txt_ansDisp.Focus();
        }

        private void btn_plus_Click(object sender, EventArgs e)
        {
            if (txt_ansDisp.Text.ToString().IndexOf("+").Equals(-1))
            {
                if (txt_ansDisp.Text != "")
                {
                    txt_ansDisp.Text += "+";
                }
                else
                {
                    MessageBox.Show("Please Insert a number first", "Error", MessageBoxButtons.OK);
                }
                txt_ansDisp.Focus();
            }
        }

        private void btn_minus_Click(object sender, EventArgs e)
        {
            if (txt_ansDisp.Text.ToString().IndexOf("-").Equals(-1))
            {
                if (txt_ansDisp.Text != "")
                {
                    txt_ansDisp.Text += "-";
                }
                else
                {
                    MessageBox.Show("Please Insert a number first", "Error", MessageBoxButtons.OK);
                }
                txt_ansDisp.Focus();
            }
        }

        private bool equalBtnWasClicked = false;

        private void btn_equal_Click(object sender, EventArgs e)
        {
            if (txt_ansDisp.Text != "")
            {

                string tempString = "", expression = txt_ansDisp.Text.ToString();

                int operatorIndex, i, len = (expression.Length - 1);

                double firstValue, secondValue, finalAns;

                if (expression[len].ToString().Equals("+") || expression[len].ToString().Equals("-") || expression[len].ToString().Equals("*") || expression[len].ToString().Equals("/") || expression[len].ToString().Equals("."))
                {
                    MessageBox.Show("The Expression is Invalid", "Error", MessageBoxButtons.OK);
                    btn_clear_Click(sender, e);
                    txt_ansDisp.Focus();
                }
                else
                {
                    if (!(expression.IndexOf("+").Equals(-1)))
                    {
                        try
                        {
                            if (equalBtnWasClicked == false)
                            {
                                equalBtnWasClicked = true;

                                operatorIndex = expression.IndexOf("+");

                                for (i = 0; i < operatorIndex; i++)
                                {
                                    tempString += expression[i];
                                }

                                firstValue = Convert.ToDouble(tempString);

                                tempString = "";

                                for (i = operatorIndex + 1; i <= len; i++)
                                {
                                    tempString += expression[i];
                                }

                                secondValue = Convert.ToDouble(tempString);

                                finalAns = firstValue + secondValue;

                                txt_ansDisp.AppendText("=" + Environment.NewLine + Convert.ToString(finalAns));
                            }
                            else
                            {
                                expression = txt_ansDisp.Lines[0].ToString();

                                finalAns = Convert.ToDouble(txt_ansDisp.Lines[1].ToString());

                                txt_ansDisp.Clear();

                                len = (expression.Length - 2);

                                operatorIndex = expression.IndexOf("+");

                                for (i = operatorIndex + 1; i <= len; i++)
                                {
                                    tempString += expression[i];
                                }

                                secondValue = Convert.ToDouble(tempString);

                                txt_ansDisp.AppendText(finalAns + "+" + secondValue);

                                finalAns += secondValue;

                                txt_ansDisp.AppendText("=" + Environment.NewLine + Convert.ToString(finalAns));
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show("Infinity", "Error");

                            btn_clear_Click(sender, e);
                        }

                    }
                    else if (!(expression.IndexOf("-").Equals(-1)))
                    {
                        try
                        {
                            if (equalBtnWasClicked == false)
                            {
                                equalBtnWasClicked = true;

                                operatorIndex = expression.IndexOf("-");

                                for (i = 0; i < operatorIndex; i++)
                                {
                                    tempString += expression[i];
                                }

                                firstValue = Convert.ToDouble(tempString);

                                tempString = "";

                                for (i = operatorIndex + 1; i <= len; i++)
                                {
                                    tempString += expression[i];
                                }

                                secondValue = Convert.ToDouble(tempString);

                                finalAns = firstValue - secondValue;

                                txt_ansDisp.AppendText("=" + Environment.NewLine + Convert.ToString(finalAns));
                            }
                            else
                            {
                                expression = txt_ansDisp.Lines[0].ToString();

                                finalAns = Convert.ToDouble(txt_ansDisp.Lines[1].ToString());

                                txt_ansDisp.Clear();

                                len = (expression.Length - 2);

                                operatorIndex = expression.IndexOf("-");

                                if(operatorIndex == 0)
                                {
                                    StringBuilder tempString1 = new StringBuilder(expression);
                                    tempString1[operatorIndex] = '\0';
                                    expression = tempString1.ToString();
                                    operatorIndex = expression.IndexOf("-");
                                }

                                for (i = operatorIndex + 1; i <= len; i++)
                                {
                                    tempString += expression[i];
                                }

                                secondValue = Convert.ToDouble(tempString);

                                txt_ansDisp.AppendText(finalAns + "-" + secondValue);

                                finalAns = finalAns - secondValue;

                                txt_ansDisp.AppendText("=" + Environment.NewLine + Convert.ToString(finalAns));
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show(e1.Message, "Error");

                            btn_clear_Click(sender, e);
                        }
                    }
                    else if (!(expression.IndexOf("*").Equals(-1)))
                    {
                        try
                        {
                            if (equalBtnWasClicked == false)
                            {
                                equalBtnWasClicked = true;

                                operatorIndex = expression.IndexOf("*");

                                for (i = 0; i < operatorIndex; i++)
                                {
                                    tempString += expression[i];
                                }

                                firstValue = Convert.ToDouble(tempString);

                                tempString = "";

                                for (i = operatorIndex + 1; i <= len; i++)
                                {
                                    tempString += expression[i];
                                }

                                secondValue = Convert.ToDouble(tempString);

                                finalAns = firstValue * secondValue;

                                txt_ansDisp.AppendText("=" + Environment.NewLine + Convert.ToString(finalAns));
                            }
                            else
                            {
                                expression = txt_ansDisp.Lines[0].ToString();

                                finalAns = Convert.ToDouble(txt_ansDisp.Lines[1].ToString());

                                txt_ansDisp.Clear();

                                len = (expression.Length - 2);

                                operatorIndex = expression.IndexOf("*");

                                for (i = operatorIndex + 1; i <= len; i++)
                                {
                                    tempString += expression[i];
                                }

                                secondValue = Convert.ToDouble(tempString);

                                txt_ansDisp.AppendText(finalAns + "*" + secondValue);

                                finalAns *= secondValue;

                                txt_ansDisp.AppendText("=" + Environment.NewLine + Convert.ToString(finalAns));
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show(e1.Message, "Error");

                            btn_clear_Click(sender, e);
                        }
                    }
                    else if (!(expression.IndexOf("/").Equals(-1)))
                    {
                        try
                        {
                            if (equalBtnWasClicked == false)
                            {
                                equalBtnWasClicked = true;

                                operatorIndex = expression.IndexOf("/");

                                for (i = 0; i < operatorIndex; i++)
                                {
                                    tempString += expression[i];
                                }

                                firstValue = Convert.ToDouble(tempString);

                                tempString = "";

                                for (i = operatorIndex + 1; i <= len; i++)
                                {
                                    tempString += expression[i];
                                }

                                secondValue = Convert.ToDouble(tempString);

                                finalAns = firstValue / secondValue;

                                txt_ansDisp.AppendText("=" + Environment.NewLine + Convert.ToString(finalAns));
                            }
                            else
                            {
                                expression = txt_ansDisp.Lines[0].ToString();

                                finalAns = Convert.ToDouble(txt_ansDisp.Lines[1].ToString());

                                txt_ansDisp.Clear();

                                len = (expression.Length - 2);

                                operatorIndex = expression.IndexOf("/");

                                for (i = operatorIndex + 1; i <= len; i++)
                                {
                                    tempString += expression[i];
                                }

                                secondValue = Convert.ToDouble(tempString);

                                txt_ansDisp.AppendText(finalAns + "/" + secondValue);

                                finalAns /= secondValue;

                                txt_ansDisp.AppendText("=" + Environment.NewLine + Convert.ToString(finalAns));
                            }
                        }
                        catch (Exception e1)
                        {
                            MessageBox.Show(e1.Message, "Error");

                            btn_clear_Click(sender,e);
                        }
                    }
                }
            }
            else
            {
                MessageBox.Show("Write an Expression", "Error", MessageBoxButtons.OK);
            }
        }

        private void btn_divide_Click(object sender, EventArgs e)
        {
            if (txt_ansDisp.Text.ToString().IndexOf("/").Equals(-1))
            {
                if (txt_ansDisp.Text != "")
                {
                    txt_ansDisp.Text += "/";
                }
                else
                {
                    MessageBox.Show("Please Insert a number first", "Error", MessageBoxButtons.OK);
                }
                txt_ansDisp.Focus();
            }
        }

        private void btn_multiply_Click(object sender, EventArgs e)
        {
            if (txt_ansDisp.Text.ToString().IndexOf("*").Equals(-1))
            {
                if (txt_ansDisp.Text != "")
                {
                    txt_ansDisp.Text += "*";
                }
                else
                {
                    MessageBox.Show("Please Insert a number first", "Error", MessageBoxButtons.OK);
                }
                txt_ansDisp.Focus();
            }
        }
    }
}
