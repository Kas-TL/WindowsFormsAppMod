using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsAppMod
{
    public partial class главное  : Form
    {
        string ConnStr = @"Data Source=DESKTOP-10CULML;Initial Catalog = 44П-ПМ-01-Зуев; Integrated Security = True";
        int count = 0, price = 0;
        public главное ()
        {
            InitializeComponent();
            Fill();
        }
        public void MyExecuteNonQuery(string SqlText)
        {
            SqlConnection cn;
            SqlCommand cmd;

            cn = new SqlConnection(ConnStr);
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = SqlText;
            cmd.ExecuteNonQuery();
            cn.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Корзина f = new Корзина();
            f.Show();
        }

        private void Fill()
        {
            SqlCommand cmd;
            SqlConnection cn = new SqlConnection(ConnStr);
            cn.Open();
            cmd = cn.CreateCommand();
            cmd.CommandText = "select * from [Каталог]";
            SqlDataAdapter da = new SqlDataAdapter(cmd.CommandText, ConnStr);
            DataSet ds = new DataSet();
            da.Fill(ds, "[Каталог]");
            dataGridView1.DataSource = ds.Tables["[Каталог]"].DefaultView;
            label5.Text = Convert.ToString(count);
            label6.Text = Convert.ToString(price);
            if (count < 3)
            {
                label8.Text = "0%";
                label7.Visible = false;
            }
            else if ((count >= 3) && (count < 5))
            {
                label8.Text = "5%";
                price = Convert.ToInt32(Convert.ToInt32(label6.Text) * 0.95);
                label7.Visible = true;
                label7.Text = Convert.ToString(price);
            }
            else if ((count >= 5) && (count < 10))
            {
                label8.Text = "10%";
                price = Convert.ToInt32(Convert.ToInt32(label6.Text) * 0.9);
                label7.Visible = true;
                label7.Text = Convert.ToString(price);
            }
            else if (count >= 10)
            {
                label8.Text = "15%";
                price = Convert.ToInt32(Convert.ToInt32(label6.Text) * 0.85);
                label7.Visible = true;
                label7.Text = Convert.ToString(price);
            }

            cn.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            count = 0;
            price = 0;
            Fill();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            count++;
            int index = dataGridView1.CurrentRow.Index;
            price += Convert.ToInt32(dataGridView1[8, index].Value);
            Fill();
        }
    }
}
