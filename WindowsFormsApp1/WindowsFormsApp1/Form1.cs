using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;


namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        GencMentoringEntities db = new GencMentoringEntities();
        public Form1()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void load()
        {
            dataGridView1.DataSource = db.Window_form.ToList();
        }
        public void reset()
        {
            textName.Text = "";
            textEmail.Text = "";
            textPhno.Text = "";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            load();
        }


        private void btnadd_Click(object sender, EventArgs e)
        {

            Window_form form = new Window_form();
            if (textName.Text != string.Empty && textEmail.Text != string.Empty && textPhno.Text != string.Empty)
            {
                form.Name = textName.Text;
                form.Email = textEmail.Text;
                form.Phno = textPhno.Text;
                db.Window_form.Add(form);
                db.SaveChanges();
                MessageBox.Show("Data Inserted Successfully");
                load();
                reset();
            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnreset_Click(object sender, EventArgs e)
        {
            reset();
        }

        private void textEmail_TextChanged(object sender, EventArgs e)
        {
            string patter = "^(?=.{1,64}@)[A-Za-z0-9_-]+(\\.[A-Za-z0-9_-]+)*@"
        + "[^-][A-Za-z0-9-]+(\\.[A-Za-z0-9-]+)*(\\.[A-Za-z]{2,})$";

            if (Regex.IsMatch(textEmail.Text, patter))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textEmail, "Please Enter valid mail Address");
            }

        }

        private void textPhno_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^\\d{10}$";
            if (Regex.IsMatch(textPhno.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textPhno, "Please Enter valid PhoneNumber");
            }
        }

        private void textName_TextChanged(object sender, EventArgs e)
        {
            string pattern = "^[A-Za-z][A-Za-z0-9_]{7,29}$";
            if (Regex.IsMatch(textName.Text, pattern))
            {
                errorProvider1.Clear();
            }
            else
            {
                errorProvider1.SetError(this.textName, " please Enter Alphabetics only");
            }
        }
    }
}
