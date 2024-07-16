using System.Data;
using System.Data.SqlClient;

namespace Demo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            LoadDBAsync1();
        }
        private void LoadDBAsync1()
        {
            string connectionString = "Server=FHGFD;Database=test; User ID = sa; Password = 1234;Trusted_Connection=true";


            using (SqlConnection conn = new SqlConnection(connectionString))

            {

                try
                {

                    conn.Open();
                    string query = $"select * from Person";
                    SqlDataAdapter adapter = new SqlDataAdapter(query, conn);
                    
                    DataTable table = new DataTable();
                    adapter.Fill(table);
                    dataGridView1.DataSource = table;


                }
                catch (Exception ex)
                {
                    MessageBox.Show("at error" + ex.Message, "error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }
    }
}
