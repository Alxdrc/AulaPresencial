﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsView
{
    public partial class frmAvisoCadastrarAluno : Form
    {
        public frmAvisoCadastrarAluno()
        {
            InitializeComponent();
        }

        private void btnVoltarCad_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
