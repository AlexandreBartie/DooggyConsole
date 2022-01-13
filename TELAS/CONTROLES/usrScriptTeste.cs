﻿using PainelTestes.TELAS.CONTROLES;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PainelTestes
{

    public partial class usrScriptTeste : usrMoldura
    {

        private TestPainelScript Painel;

        public usrScriptTeste()
        {
            InitializeComponent();

            SetTitulo(prmTexto: "Script INI");

        }

        public void Setup(TestPainelScript prmPainel)
        {

            Painel = prmPainel;

            Painel.SetPadrao(txtCode, prmEditavel: true);

        }

        public void Exibir()
        {

            txtCode.Text = Painel.Console.Log.code;

        }

    }
}
