using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Net.Mail;
namespace CRP
{
    public partial class Form1 : Form
    {
        SqlCommand cmd;
        SqlConnection con;
        
        public Form1()
        {
            InitializeComponent();
        }

        private void CostumerRequestTBBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.costumerRequestTBBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.dejsair_CostumerRequestDBDataSet);
        }

        public void GetInfo()
        {
            try
            {
                con = new SqlConnection(@"Data Source=89.32.251.8,9994;Initial Catalog=dejsair_CostumerRequestDB;Persist Security Info=True;User ID=mohkazv;Password=wKhm718@yFw2m7$1");
                con.Open();
                cmd = new SqlCommand("INSERT INTO CostumerRequestTB (FirstName,LastName,Email,CostumerCode,Request)VALUES (@FirstName,@LastName,@Email,@CostumerCode,@Request)", con);
                cmd.Parameters.Add("@FirstName", firstNameTextBox.Text);
                cmd.Parameters.Add("@LastName", lastNameTextBox.Text);
                cmd.Parameters.Add("@Email", emailTextBox.Text);
                cmd.Parameters.Add("@CostumerCode", costumerCodeTextBox.Text);
                cmd.Parameters.Add("@Request", requestTextBox.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("your request sent successfully :)");
            }
            catch (Exception b)
            {
                MessageBox.Show("Exception occur while creating table:" + b.Message + "\t" + b.GetType());
            }
        }
        public void SendEmail()
        {
            Random r = new Random();
            try
            {
                MailMessage mail = new MailMessage();
                SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
                mail.From = new MailAddress("mohammad.kazem747@gmail.com");
                mail.To.Add(emailTextBox.Text);
                mail.Subject = "Verification Code";
                mail.Body = "HI ," + "" + firstNameTextBox.Text + "" + lastNameTextBox.Text + "\n" + "your verification code is :" + "\n" + Convert.ToString(r.Next());
                SmtpServer.Port = 587;
                SmtpServer.Credentials = new System.Net.NetworkCredential("mohammad.kazem747@gmail.com", "kaz19954664kaz");
                SmtpServer.EnableSsl = true;
                SmtpServer.Send(mail);
                MessageBox.Show("your verification code sent");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        
        private void Button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            GetInfo();
            SendEmail();
            Close();
        }
    }
}
