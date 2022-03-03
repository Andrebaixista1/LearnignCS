using SysAnd.BLLClasses;
using SysAnd.DALDados;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SysAnd.UIForm
{
    public partial class frmUsers : Form
    {
        public frmUsers()
        {
            InitializeComponent();
        }
        userBll u = new userBll();
        userDAL dal = new userDAL();
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCad_Click(object sender, EventArgs e)
        {
            u.FirstName = txtName.Text;
            u.LastName = txtLast.Text;
            u.Email = txtEmail.Text;
            u.UserName = txtUser.Text;
            u.Password = txtPass.Text;
            u.Contact = txtTell.Text;
            u.Address = txtAddress.Text;
            u.Gender = cbSex.Text;
            u.UserType = cbType.Text;
            u.AddDate = DateTime.Now;
            u.AddBy = 1;

            bool success = dal.Insert(u);
            if (success == true)
            {
                MessageBox.Show("Usuário cadastrado com sucesso !");
                Limpar();
            }
            else
            {
                MessageBox.Show("Não foi possivel cadastrar este usuário");
            }

            DataTable dt = dal.Select();
            dvgUser.DataSource = dt;

        }

        private void Limpar()
        {
            txtUserID.Text = "";
            txtName.Text = "";
            txtLast.Text = "";
            txtEmail.Text = "";
            txtUser.Text = "";
            txtPass.Text = "";
            txtTell.Text = "";
            txtAddress.Text = "";
            cbSex.Text = "";
            cbType.Text = "";

        }


        private void frmUsers_Load(object sender, EventArgs e)
        {
            DataTable dt = dal.Select();
            dvgUser.DataSource = dt;
            dvgUser.Columns[0].HeaderText = "ID Usuário";
            dvgUser.Columns[1].HeaderText = "Nome";
            dvgUser.Columns[2].HeaderText = "Sobrenome";
            dvgUser.Columns[3].HeaderText = "Email";
            dvgUser.Columns[4].HeaderText = "Nome de Usuário";
            dvgUser.Columns[5].HeaderText = "Senha";
            dvgUser.Columns[6].HeaderText = "Contato";
            dvgUser.Columns[7].HeaderText = "Endereço";
            dvgUser.Columns[8].HeaderText = "Sexo";
            dvgUser.Columns[9].HeaderText = "Tipo de Usuário";
            dvgUser.Columns[10].HeaderText = "Data de Criação";
            dvgUser.Columns[11].HeaderText = "Adicionado por";
        }

        private void dvgUser_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            txtUserID.Text = dvgUser.Rows[rowIndex].Cells[0].Value.ToString();
            txtName.Text = dvgUser.Rows[rowIndex].Cells[1].Value.ToString();
            txtLast.Text = dvgUser.Rows[rowIndex].Cells[2].Value.ToString();
            txtEmail.Text = dvgUser.Rows[rowIndex].Cells[3].Value.ToString();
            txtUser.Text = dvgUser.Rows[rowIndex].Cells[4].Value.ToString();
            txtPass.Text = dvgUser.Rows[rowIndex].Cells[5].Value.ToString();
            txtTell.Text = dvgUser.Rows[rowIndex].Cells[6].Value.ToString();
            txtAddress.Text = dvgUser.Rows[rowIndex].Cells[7].Value.ToString();
            cbSex.Text = dvgUser.Rows[rowIndex].Cells[8].Value.ToString();
            cbType.Text = dvgUser.Rows[rowIndex].Cells[9].Value.ToString();
            
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            u.ID = Convert.ToInt32(txtUserID.Text);
            u.FirstName = txtName.Text;
            u.LastName = txtLast.Text;
            u.Email = txtEmail.Text;
            u.UserName = txtUser.Text;
            u.Password = txtPass.Text;
            u.Contact = txtTell.Text;
            u.Address = txtAddress.Text;
            u.Gender = cbSex.Text;
            u.UserType = cbType.Text;
            u.AddDate = DateTime.Now;
            u.AddBy = 1;

            bool success = dal.Update(u);
            if (success)
            {
                MessageBox.Show("Usuario atualizado com sucesso !");
                Limpar();
            }
            else
            {
                MessageBox.Show("Não foi possivel atualizar o usuário");
            }

            DataTable dt = dal.Select();
            dvgUser.DataSource = dt;
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            u.ID = Convert.ToInt32(txtUserID.Text);
            

            bool success = dal.Delete(u);
            try
            {
                if (success)
                {
                    MessageBox.Show("Usuario excluido com sucesso !");
                    Limpar();
                }
                else
                {
                    MessageBox.Show("Não foi possivel excluir o usuário");
                }
            }
            catch (Exception)
            { 
                MessageBox.Show("Selecione um usuário!");
            }
            finally 
            { 
            DataTable dt = dal.Select();
            dvgUser.DataSource = dt;
            }
        }
    }
}
