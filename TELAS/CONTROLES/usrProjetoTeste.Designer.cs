﻿namespace PainelTestes.TELAS.CONTROLES
{
    partial class usrProjetoTeste
    {
        /// <summary> 
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Designer de Componentes

        /// <summary> 
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.trvProjeto = new System.Windows.Forms.TreeView();
            this.SuspendLayout();
            // 
            // trvProjeto
            // 
            this.trvProjeto.BackColor = System.Drawing.SystemColors.Info;
            this.trvProjeto.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trvProjeto.Font = new System.Drawing.Font("Consolas", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.trvProjeto.Location = new System.Drawing.Point(0, 40);
            this.trvProjeto.Name = "trvProjeto";
            this.trvProjeto.Size = new System.Drawing.Size(557, 466);
            this.trvProjeto.TabIndex = 7;
            this.trvProjeto.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.trvProjeto_AfterSelect);
            // 
            // usrProjetoTeste
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.trvProjeto);
            this.Name = "usrProjetoTeste";
            this.Size = new System.Drawing.Size(557, 506);
            this.Controls.SetChildIndex(this.trvProjeto, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView trvProjeto;
    }
}
