using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace m3hd_abo_2er
{
    public partial class Form1 : System.Windows.Forms.Form
    {
    public Form1()
    {
        InitializeComponent();
    }

    private void Form1_Load(object sender, EventArgs e)
    {
        MessageBox.Show("welcome to my Application");
    }

    private void Form1_MouseMove(object sender, MouseEventArgs e)
    {
        int x = e.X, y = e.Y;
        if (x > 255) x = 255;
        if (y > 255) y = 255;

        BackColor = System.Drawing.Color.FromArgb(255, x, y);
    }

    private void Firstname_KeyPress(object sender, KeyPressEventArgs e)
    {
        char c = e.KeyChar;
        if (c == '\r') Familyname.Focus();
    }

    private void Familyname_KeyPress(object sender, KeyPressEventArgs e)
    {
        char c = e.KeyChar;
        if (c == '\r') Fullname.Focus();
    }

    private void Fullname_KeyPress(object sender, KeyPressEventArgs e)
    {
        char c = e.KeyChar;
        if (c == '\r') Mothername.Focus();
    }

    private void Mothername_KeyPress(object sender, KeyPressEventArgs e)
    {
        char c = e.KeyChar;
        if (c == '\r') Fathername.Focus();
    }

    private void Fathername_KeyPress(object sender, KeyPressEventArgs e)
    {
        char c = e.KeyChar;
        if (c == '\r') Education.Focus();
    }

    private void Date_KeyPress(object sender, KeyPressEventArgs e)
    {
        char c = e.KeyChar;
        if (c == '\r') BirthDatePlace.Focus();
    }

    private void Qualification_KeyPress(object sender, KeyPressEventArgs e)
    {
        char c = e.KeyChar;
        if (c == '\r') Address.Focus();
    }

    private void Nationality_SelectedIndexChanged(object sender, EventArgs e)
    {
        string s = MyCountry.Text;
        MessageBox.Show("you are from" + s + "country");
    }

    private void havechildern_CheckedChanged(object sender, EventArgs e)
    {
        bool c = havechildern.Checked;
        if (c == false)
        {
            GirlsNumber.Enabled = false;
            BoysNumber.Enabled = false;
        }
    }

    private void Married_CheckedChanged(object sender, EventArgs e)
    {
        bool c = havechildern.Checked;
        bool b2 = Married.Checked;
        if (c == true && b2 == true)
        {
            GirlsNumber.Enabled = true;
            havechildern.Enabled = true;
            BoysNumber.Enabled = true;
        }
    }

    private void Single_CheckedChanged(object sender, EventArgs e)
    {
        bool c = havechildern.Checked;
        bool b2 = Single.Checked;
        if (b2 == true)
        {
            GirlsNumber.Enabled = false;
            havechildern.Enabled = false;
            BoysNumber.Enabled = false;
        }
    }

    private void Divorce_CheckedChanged(object sender, EventArgs e)
    {
        bool c = havechildern.Checked;
        bool b3 = Divorce.Checked;
        if (c == true && b3 == true)
        {
            GirlsNumber.Enabled = true;
            havechildern.Enabled = true;
            BoysNumber.Enabled = true;
        }
    }

    private void Widower_CheckedChanged(object sender, EventArgs e)
    {
        bool c = havechildern.Checked;
        bool b4 = Widower.Checked;
        if (c == true && b4 == true)
        {
            GirlsNumber.Enabled = true;
            havechildern.Enabled = true;
            BoysNumber.Enabled = true;
        }
    }

    private void Clear_Click_1(object sender, EventArgs e)
    {
        Firstname.Clear();
        Fullname.Clear();
        Familyname.Clear();
        Fathername.Clear();
        Mothername.Clear();
        MyCountry.Text = "";
        Address.Text = "";
        GirlsNumber.Text = "";
        BoysNumber.Text = "";
        Married.Checked = false;
        Single.Checked = false;
        Divorce.Checked = false;
        Widower.Checked = false;
    }

    private void timer1_Tick(object sender, EventArgs e)
    {
        label9.Text = DateTime.Now.ToString();
    }

    private void Exit_Click_1(object sender, EventArgs e)
    {
        this.Close();
    }

    private void Report_Click(object sender, EventArgs e)
    {
        String s = "FristName is" + Firstname.Text + "\n";
        s += "FamilyName is" + Familyname.Text + "\n";
        s += "FullName is" + Fullname.Text + "\n";
        s += "MyAddress is" + Address.Text + "\n";
        s += "FatherName is" + Fathername.Text + "\n";
        s += "MotherName is" + Mothername.Text + "\n";
        s += "MyEducation" + Education.Text + "\n";
        s += "MyBirthDate&Place" + BirthDatePlace.Text + "\n";
        s += "MyAddress" + Address.Text + "\n";
        s += "MyCountry" + MyCountry.Text + "\n";
        s += "GirlsNumber" + GirlsNumber.Text + "\n";
        s += "boysNumber" + BoysNumber.Text + "\n";
        s += "Married is" + Married.Checked + "\n";
        s += "Single is" + Single.Checked + "\n";
        s += "Divorce is" + Divorce.Checked + "\n";
        s += "Widow is" + Widower.Checked + "\n";
        MessageBox.Show(s, "report");
    }

    private void button1_Click(object sender, EventArgs e)
    {
        new Form1().Show();
    }

    private void Address_KeyPress(object sender, KeyPressEventArgs e)
    {
        char c = e.KeyChar;
        if (c == '\r') MyCountry.Focus();
    }

    private void MyCountry_SelectedIndexChanged(object sender, EventArgs e)
    {
        string s = MyCountry.Text;
        MessageBox.Show("you are from" + s + "country");
    }

    private void MyCountry_KeyPress(object sender, KeyPressEventArgs e)
    {
        char c = e.KeyChar;
        if (c == '\r') GirlsNumber.Focus();
    }

    private void label9_Click(object sender, EventArgs e)
    {

    }
}
}
