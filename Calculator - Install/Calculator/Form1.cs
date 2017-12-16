using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Calculator
{
    public partial class Form1 : Form
    {
        string math = "";
        double kq = 0.0;
        double result;
        string[] postfix;
        public Form1()
        {
            InitializeComponent();
            this.KeyPreview = true;
        }
        private void button_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            txtDisplay.Text += button.Text;
            txtDisplay.Select(txtDisplay.Text.Length, 0);
            txtDisplay.Focus();
        }
        private void Cal_Click(object sender, EventArgs e)
        {
            try
            {
                Button button = (Button)sender;
                int l = txtDisplay.TextLength;
                string temp = "";
                if (l >= 2)
                    temp = txtDisplay.Text[l - 2].ToString();
                else if (l == 1)
                {
                    temp = txtDisplay.Text[l - 1].ToString();
                }
                else temp = txtDisplay.Text.ToString();
                if (temp == "(" || temp == "+" || temp == "*" || temp == "/" || temp == "")
                {
                    if (button.Text == "-")
                        txtDisplay.Text += button.Text;
                    else txtDisplay.Text += " " + button.Text + " ";
                }
                else if (temp == "-")
                {
                    int k = txtDisplay.Text.ToString().LastIndexOf("-");
                    if (txtDisplay.Text[k + 1].ToString() == " ")
                    {
                        if (button.Text == "-")
                            txtDisplay.Text += button.Text;
                        else txtDisplay.Text += " " + button.Text + " ";
                    }
                    else
                    {
                        if (button.Text == "-")
                            txtDisplay.Text += " " + button.Text + " ";
                        else txtDisplay.Text += " " + button.Text + " ";
                    }
                }
                else txtDisplay.Text += " " + button.Text + " ";
                txtDisplay.Select(txtDisplay.Text.Length, 0);
                txtDisplay.Focus();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnMoNgoac_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " " + btnMoNgoac.Text + " ";
            txtDisplay.Select(txtDisplay.Text.Length, 0);
            txtDisplay.Focus();
        }
        private void btnDongNgoac_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += " " + btnDongNgoac.Text + " ";
            txtDisplay.Select(txtDisplay.Text.Length, 0);
            txtDisplay.Focus();
        }
        private void btnBang_Click(object sender, EventArgs e)
        {
            txtResult.ResetText();
            txtHT.ResetText();
            if (txtDisplay.Text != "")
            {
                if (txtDisplay.Text.Contains("!") || txtDisplay.Text.Contains("√") || txtDisplay.Text.Contains("^2") || txtDisplay.Text.Contains("^3"))
                {
                    if (math == "GT")
                    {
                        GiaiThua();
                    }
                    else if (math == "Sqrt")
                    {
                        Sqrt();
                    }
                    else if (math == "Square")
                    {
                        Square();
                    }
                    else if (math == "Cube")
                    {
                        Cube();
                    }
                }
                else
                {
                    math = "";
                    InfixToPostfix();
                    Result();
                }
                txtDisplay.Select(txtDisplay.Text.Length, 0);
                txtDisplay.Focus();
            }
        }
        private void GiaiThua()
        {
            try
            {
                string temp = "";
                int l = txtDisplay.Text.ToString().IndexOf("!");
                if (txtDisplay.TextLength > l + 1)
                {
                    MessageBox.Show("Lỗi cú pháp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    temp = txtDisplay.Text.Replace("!", "");
                    int k = int.Parse(temp);
                    kq = k;
                    for (int i = k - 1; i > 0; i--)
                        kq = kq * i;
                    txtResult.Text = kq.ToString();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi cú pháp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Sqrt()
        {
            try
            {
                string temp = "";
                int l = txtDisplay.Text.ToString().IndexOf("√");
                if (l == 0)
                {
                    temp = txtDisplay.Text.Replace("√", "");
                    kq = Math.Sqrt(double.Parse(temp));
                    txtResult.Text = kq.ToString();
                }
                else
                {
                    MessageBox.Show("Lỗi cú pháp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } catch (Exception)
            {
                MessageBox.Show("Lỗi cú pháp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Square()
        {
            try
            {
                string temp = "";
                int l = txtDisplay.Text.ToString().IndexOf("^");
                if (txtDisplay.TextLength > l + 2)
                {
                    MessageBox.Show("Lỗi cú pháp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    temp = txtDisplay.Text.Replace("^2", "");
                    kq = double.Parse(temp) * double.Parse(temp);
                    txtResult.Text = kq.ToString();
                }
            } catch (Exception)
            {
                MessageBox.Show("Lỗi cú pháp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void Cube()
        {
            try
            {
                string temp = "";
                int l = txtDisplay.Text.ToString().IndexOf("^");
                if (txtDisplay.TextLength > l + 2)
                {
                    MessageBox.Show("Lỗi cú pháp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    temp = txtDisplay.Text.Replace("^3", "");
                    kq = double.Parse(temp) * double.Parse(temp) * double.Parse(temp);
                    txtResult.Text = kq.ToString();
                }
            } catch (Exception)
            {
                MessageBox.Show("Lỗi cú pháp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void btnGT_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnGT.Text;
            math = "GT";
            txtDisplay.Select(txtDisplay.Text.Length, 0);
            txtDisplay.Focus();
        }
        private void btnSqrt_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSqrt.Text;
            math = "Sqrt";
            txtDisplay.Select(txtDisplay.Text.Length, 0);
            txtDisplay.Focus();
        }
        private void btnSquare_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnSquare.Text;
            math = "Square";
            txtDisplay.Select(txtDisplay.Text.Length, 0);
            txtDisplay.Focus();
        }
        private void btnCube_Click(object sender, EventArgs e)
        {
            txtDisplay.Text += btnCube.Text;
            math = "Cube";
            txtDisplay.Select(txtDisplay.Text.Length, 0);
            txtDisplay.Focus();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            kq = 0.0;
            txtResult.Clear();
            txtDisplay.Clear();
            txtHT.Clear();
            txtDisplay.Select(txtDisplay.Text.Length, 0);
            txtDisplay.Focus();
        }
        public void Result()
        {
            try
            {
                Stack polishNotationStack = new Stack();
                double n;
                foreach (string c in postfix)
                {
                    if (double.TryParse(c, out n)) //Kiểm tra có phải là toán hạng không
                    {
                        polishNotationStack.Push(n);//Đưa vào stack
                    }
                    if (c == "+")
                    {
                        double x = (double)polishNotationStack.Pop();
                        double y = (double)polishNotationStack.Pop();
                        result = x + y;
                        polishNotationStack.Push(result);   //Đưa kết quả vào stack
                    }
                    if (c == "-")
                    {
                        double x = (double)polishNotationStack.Pop();
                        double y = (double)polishNotationStack.Pop();
                        result = y - x;
                        polishNotationStack.Push(result);
                    }
                    if (c == "*")
                    {
                        double x = (double)polishNotationStack.Pop();
                        double y = (double)polishNotationStack.Pop();
                        result = x * y;
                        polishNotationStack.Push(result);
                    }
                    if (c == "/")
                    {
                        double x = (double)polishNotationStack.Pop();
                        double y = (double)polishNotationStack.Pop();
                        result = y / x;
                        polishNotationStack.Push(result);
                    }
                }
                txtResult.Text = polishNotationStack.Pop().ToString();
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi cú pháp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void InfixToPostfix()
        {
            try
            {
                txtHT.Clear();
                string infix = txtDisplay.Text.Trim();
                infix.Replace("  ", " ");
                string[] tokens = infix.Split(' ');
                Stack<string> s = new Stack<string>();
                List<string> outputList = new List<string>();
                double n;
                foreach (string c in tokens)
                {
                    if (double.TryParse(c.ToString(), out n))       //Nếu là số thì đưa vào outputList
                    {
                        outputList.Add(c);
                    }
                    if (c == "(")
                    {
                        s.Push(c);                                  //Nếu gặp "(" đưa vào stack
                    }
                    if (c == ")")
                    {
                        while (s.Count != 0 && s.Peek() != "(")    //
                        {
                            outputList.Add(s.Pop());
                        }
                        s.Pop();
                    }
                    if (isOperator(c) == true)
                    {
                        while (s.Count != 0 && Priority(s.Peek()) >= Priority(c))
                        {
                            outputList.Add(s.Pop());
                        }
                        s.Push(c);
                    }
                }
                while (s.Count != 0)
                {
                    outputList.Add(s.Pop());
                }
                postfix = outputList.ToArray();
                for (int i = 0; i < outputList.Count; i++)
                {
                    txtHT.Text += outputList[i] + " ";
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Lỗi cú pháp", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        static int Priority(string c)
        {
            if (c == "*" || c == "/")
            {
                return 2;
            }
            else if (c == "+" || c == "-")
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
        static bool isOperator(string c)
        {
            if (c == "+" || c == "-" || c == "*" || c == "/")
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void button_KeyPress(object sender, KeyPressEventArgs e)
        {
            Keys key = (Keys)e.KeyChar;
            e.Handled = true;

            if ((Keys)e.KeyChar == Keys.D0)
                btn0.PerformClick();
            else if (e.KeyChar.ToString() == "1")
                btn1.PerformClick();
            else if (e.KeyChar.ToString() == "2")
                btn2.PerformClick();
            else if (e.KeyChar.ToString() == "3")
                btn3.PerformClick();
            else if (e.KeyChar.ToString() == "4")
                btn4.PerformClick();
            else if (e.KeyChar.ToString() == "5")
                btn5.PerformClick();
            else if (e.KeyChar.ToString() == "6")
                btn6.PerformClick();
            else if (e.KeyChar.ToString() == "7")
                btn7.PerformClick();
            else if (e.KeyChar.ToString() == "8")
                btn8.PerformClick();
            else if (e.KeyChar.ToString() == "9")
                btn9.PerformClick();
            else if (e.KeyChar.ToString() == "+")
                btnCong.PerformClick();
            else if (e.KeyChar.ToString() == "-")
                btnTru.PerformClick();
            else if (e.KeyChar.ToString() == "*")
                btnNhan.PerformClick();
            else if (e.KeyChar.ToString() == "/")
                btnChia.PerformClick();
            else if (e.KeyChar.ToString() == "(")
                btnMoNgoac.PerformClick();
            else if (e.KeyChar.ToString() == ")")
                btnDongNgoac.PerformClick();
            else if (e.KeyChar.ToString() == "=")
                btnBang.PerformClick();
            else if (e.KeyChar.ToString() == "!")
                btnGT.PerformClick();
            else if (e.KeyChar.ToString() == ".")
                btnDot.PerformClick();
            else if ((Keys)e.KeyChar == Keys.Back)
                btnBack.PerformClick();
            else if ((Keys)e.KeyChar == Keys.Enter)
                btnBang.PerformClick();
            //else e.Handled = false;

            txtDisplay.Select(txtDisplay.Text.Length, 1);
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            string temp = txtDisplay.Text;
            if (temp.Length > 2)
            {
                if (temp[temp.Length - 2].ToString() == "+" ||
                    temp[temp.Length - 2].ToString() == "*" || temp[temp.Length - 2].ToString() == "/" ||
                    temp[temp.Length - 2].ToString() == "(" || temp[temp.Length - 2].ToString() == ")")
                    temp = temp.Remove(temp.Length - 3);
                else if (temp[temp.Length - 2].ToString() == "-")
                {
                    if (temp[temp.Length - 1].ToString() == " ")
                        temp = temp.Remove(temp.Length - 3);
                    else
                        temp = temp.Remove(temp.Length - 1);
                }
                else
                    temp = temp.Remove(temp.Length - 1);
            }
            else if (temp.Length == 2)
            {
                temp = temp.Remove(temp.Length - 1);
            }
            else if (temp.Length > 0)
                temp = temp.Remove(temp.Length - 1);
            txtDisplay.Text = temp;
            txtDisplay.Select(txtDisplay.Text.Length, 0);
            txtDisplay.Focus();
        }
        private void Form1_Load_1(object sender, EventArgs e)
        {
            txtDisplay.Select();
        }
        private void txtDisplay_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            Keys key = (Keys)e.KeyChar;
            e.Handled = true;

            if ((Keys)e.KeyChar == Keys.D0)
                btn0.PerformClick();
            else if (e.KeyChar.ToString() == "1")
                btn1.PerformClick();
            else if (e.KeyChar.ToString() == "2")
                btn2.PerformClick();
            else if (e.KeyChar.ToString() == "3")
                btn3.PerformClick();
            else if (e.KeyChar.ToString() == "4")
                btn4.PerformClick();
            else if (e.KeyChar.ToString() == "5")
                btn5.PerformClick();
            else if (e.KeyChar.ToString() == "6")
                btn6.PerformClick();
            else if (e.KeyChar.ToString() == "7")
                btn7.PerformClick();
            else if (e.KeyChar.ToString() == "8")
                btn8.PerformClick();
            else if (e.KeyChar.ToString() == "9")
                btn9.PerformClick();
            else if (e.KeyChar.ToString() == "+")
                btnCong.PerformClick();
            else if (e.KeyChar.ToString() == "-")
                btnTru.PerformClick();
            else if (e.KeyChar.ToString() == "*")
                btnNhan.PerformClick();
            else if (e.KeyChar.ToString() == "/")
                btnChia.PerformClick();
            else if (e.KeyChar.ToString() == "(")
                btnMoNgoac.PerformClick();
            else if (e.KeyChar.ToString() == ")")
                btnDongNgoac.PerformClick();
            else if (e.KeyChar.ToString() == "=")
                btnBang.PerformClick();
            else if (e.KeyChar.ToString() == "!")
                btnGT.PerformClick();
            else if (e.KeyChar.ToString() == ".")
                btnDot.PerformClick();
            else if ((Keys)e.KeyChar == Keys.Back)
                btnBack.PerformClick();
            else if ((Keys)e.KeyChar == Keys.Enter)
                btnBang.PerformClick();
            //else e.Handled = false;

            txtDisplay.Select(txtDisplay.Text.Length, 1);
        }
    }
}