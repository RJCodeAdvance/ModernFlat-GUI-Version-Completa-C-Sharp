using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMPLETE_FLAT_UI
{
    public partial class F_login : Form
    {
        public F_login()
        {
            InitializeComponent();
        }

        private void tb_usuario_Click(object sender, EventArgs e)
        {
            tb_usuario.Clear();
           // pictureBox2.BackgroundImage = Properties.Resources.usuario;
            panel1.BackColor = Color.FromArgb(187, 30, 89);
            tb_usuario.ForeColor = Color.FromArgb(187, 30, 89);

           // pictureBox3.BackgroundImage = Properties.Resources.cadeado;
            panel2.BackColor = Color.FromArgb(255, 255, 255);
            tb_senha.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void tb_senha_Click(object sender, EventArgs e)
        {
            tb_senha.Clear();
            tb_senha.PasswordChar = '°';
            //pictureBox2.BackgroundImage = Properties.Resources.cadeado3;
            panel2.BackColor = Color.FromArgb(187, 30, 89);
            tb_senha.ForeColor = Color.FromArgb(187, 30, 89);

            //pictureBox1.BackgroundImage = Properties.Resources.usuario3;
            panel1.BackColor = Color.FromArgb(255, 255, 255);
            tb_usuario.ForeColor = Color.FromArgb(255, 255, 255);
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btn_entrar_Click(object sender, EventArgs e)
        {
            FormMenuPrincipal f_menu = new FormMenuPrincipal();

            if (tb_usuario.Text == "rl" && tb_senha.Text == "rl")

            {
                f_menu.Show();
                F_login f_Login = new F_login();
            }
            else
            {
                if (tb_usuario.Text != "rl" && tb_senha.Text == "rl")
                {
                    MessageBox.Show("Usuário incorreto!");
                }
                else
                {
                    if (tb_usuario.Text == "rl" && tb_senha.Text != "rl")
                    {
                        MessageBox.Show("Senha incorreto!");
                    }
                    else
                    {
                        MessageBox.Show("Usuário e Senha incorretas!");
                    }
                }
            }
        }
    }
}
