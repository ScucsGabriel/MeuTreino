using MeuTreino.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MeuTreino.View.Principal
{
    public partial class FormPrincipal : Form
    {
        public FormPrincipal()
        {
            InitializeComponent();
        }

        private void Tsb_Alunos_Click(object sender, EventArgs e)
        {
            FormListarAluno formListarAluno = new FormListarAluno();
            formListarAluno.ShowDialog();
        }
    }
}
