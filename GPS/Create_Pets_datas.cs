using System;
using System.Windows.Forms;
/**/
using System.Data.OleDb;

namespace GPS
{
    public partial class Create_Pets_datas : Form
    {
        public Create_Pets_datas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void create_pets_data(int pets_sex)
        {
            try
            {
                
                using (OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=GFS.accdb;Persist Security Info=False;"))
                {

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void status_check() 
        {
            int pets_sex = 2;
            try
            {
                if (!radioButton3.Checked && !radioButton4.Checked)
                {
                    MessageBox.Show("請點選性別");
                }

                if (radioButton4.Checked) //radioButton4 = 公
                {
                    pets_sex = 1;
                }

                if (radioButton3.Checked)//radioButton3 = 母
                {
                    pets_sex = 0;
                }
                create_pets_data(pets_sex);
            }
            catch (Exception ex)
            {
                MessageBox.Show("建立資料時，出現錯誤，請通知俊億 \r\n" + ex.Message, ToString());
            }
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            /*使用者輸入 20201010，離開欄位後自動轉換 2020/10/10 */
            DateTime dt = DateTime.ParseExact(textBox1.Text, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            var result = dt.ToString("yyyy/MM/dd");
            textBox1.Text = result;
        }
    }
}
