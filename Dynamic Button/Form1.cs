using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Dynamic_Button
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadForm();
        }
        SqlConnection con = new SqlConnection("Data Source=.;Initial Catalog=test;Integrated Security=True");
        int count = 1;
        int x = 0;
        int y = 0;
        int btnLocation = 97;
        int txtLocation = 100;
        void LoadForm()
        {
            con.Open();
            SqlCommand select = new SqlCommand("select name,price from service",con);
            SqlDataReader da = select.ExecuteReader();
            while(da.Read())
            {
                for (int i = 0; i < 1; i++)
                {

                    Button btn = new Button();
                    btn.Text = da.GetValue(0).ToString();
                    btn.Name = count.ToString();
                    btn.Size = new Size(100, 23);
                    btn.FlatStyle = FlatStyle.Flat;
                    btn.FlatAppearance.BorderSize = 0;
                    btn.BackColor = Color.GhostWhite;
                    btn.Location = new Point(57, btnLocation);
                    TextBox txt = new TextBox();
                    txt.Text = da.GetValue(1).ToString();
                    txt.TextAlign = HorizontalAlignment.Center;
                    txt.Name = count.ToString();
                    txt.Size = new Size(100, 20);
                    txt.Location = new Point(163, txtLocation);
                    y++;
                    count++;
                    Controls.Add(btn);
                    Controls.Add(txt);
                    btnLocation = btnLocation + 29;
                    txtLocation = txtLocation + 29;
                }
            }
        }
        private void btnadd_Click_1(object sender, EventArgs e)
        {

            for (int i = 0; i < 1; i++)
            {

                Button btn = new Button();
                btn.Text = "1 MONTH MTC";
                btn.Name = count.ToString();
                btn.Size = new Size(100, 23);
                btn.FlatStyle = FlatStyle.Flat;
                btn.FlatAppearance.BorderSize = 0;
                btn.BackColor = Color.GhostWhite;
                btn.Location = new Point(57, btnLocation);
                TextBox txt = new TextBox();
                txt.Text = "15000";
                txt.TextAlign = HorizontalAlignment.Center;
                txt.Name = count.ToString();
                txt.Size = new Size(100, 20);
                txt.Location = new Point(163, txtLocation);
                y++;
                count++;
                Controls.Add(btn);
                Controls.Add(txt);
                btnLocation = btnLocation + 29;
                txtLocation = txtLocation + 29;
            }

        }
    }
}
