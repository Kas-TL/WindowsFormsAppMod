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
        public главное ()
        {
            InitializeComponent();
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

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "_44П_ПМ_01_ЗуевDataSet.Каталог". При необходимости она может быть перемещена или удалена.
            this.каталогTableAdapter.Fill(this._44П_ПМ_01_ЗуевDataSet.Каталог);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Корзина f = new Корзина();
            f.Show();
        }
    }
}
