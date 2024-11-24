namespace CrudFuncionario
{
    partial class FrmFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_Alterar = new System.Windows.Forms.Button();
            this.btn_Excluir = new System.Windows.Forms.Button();
            this.btn_Consultar = new System.Windows.Forms.Button();
            this.btn_Inserir = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_Admissao = new System.Windows.Forms.MaskedTextBox();
            this.txt_Salario = new System.Windows.Forms.TextBox();
            this.txt_Nome = new System.Windows.Forms.TextBox();
            this.txt_Rg = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_Funcionarios = new System.Windows.Forms.DataGridView();
            this.btn_Sair = new System.Windows.Forms.Button();
            this.btn_Limpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funcionarios)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox1.Controls.Add(this.btn_Alterar);
            this.groupBox1.Controls.Add(this.btn_Excluir);
            this.groupBox1.Controls.Add(this.btn_Consultar);
            this.groupBox1.Controls.Add(this.btn_Inserir);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btn_Admissao);
            this.groupBox1.Controls.Add(this.txt_Salario);
            this.groupBox1.Controls.Add(this.txt_Nome);
            this.groupBox1.Controls.Add(this.txt_Rg);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(30, 40);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(591, 202);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Informações";
            // 
            // btn_Alterar
            // 
            this.btn_Alterar.BackColor = System.Drawing.Color.Lavender;
            this.btn_Alterar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Alterar.Image = global::CrudFuncionario.Properties.Resources._1486505375_edit_pen_change_option_pencil_write_81422;
            this.btn_Alterar.Location = new System.Drawing.Point(426, 97);
            this.btn_Alterar.Name = "btn_Alterar";
            this.btn_Alterar.Size = new System.Drawing.Size(127, 61);
            this.btn_Alterar.TabIndex = 10;
            this.btn_Alterar.Text = "Alterar";
            this.btn_Alterar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Alterar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Alterar.UseVisualStyleBackColor = false;
            this.btn_Alterar.Click += new System.EventHandler(this.btn_Alterar_Click);
            // 
            // btn_Excluir
            // 
            this.btn_Excluir.BackColor = System.Drawing.Color.Lavender;
            this.btn_Excluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Excluir.Image = global::CrudFuncionario.Properties.Resources._1486504830_delete_dustbin_empty_recycle_recycling_remove_trash_81361;
            this.btn_Excluir.Location = new System.Drawing.Point(269, 97);
            this.btn_Excluir.Name = "btn_Excluir";
            this.btn_Excluir.Size = new System.Drawing.Size(127, 61);
            this.btn_Excluir.TabIndex = 9;
            this.btn_Excluir.Text = "Excluir";
            this.btn_Excluir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Excluir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Excluir.UseVisualStyleBackColor = false;
            this.btn_Excluir.Click += new System.EventHandler(this.btn_Excluir_Click);
            // 
            // btn_Consultar
            // 
            this.btn_Consultar.BackColor = System.Drawing.Color.Lavender;
            this.btn_Consultar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Consultar.Image = global::CrudFuncionario.Properties.Resources.xmag_search_find_export_locate_5984;
            this.btn_Consultar.Location = new System.Drawing.Point(426, 30);
            this.btn_Consultar.Name = "btn_Consultar";
            this.btn_Consultar.Size = new System.Drawing.Size(127, 58);
            this.btn_Consultar.TabIndex = 8;
            this.btn_Consultar.Text = "Consultar";
            this.btn_Consultar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Consultar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Consultar.UseVisualStyleBackColor = false;
            this.btn_Consultar.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn_Inserir
            // 
            this.btn_Inserir.BackColor = System.Drawing.Color.Lavender;
            this.btn_Inserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Inserir.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Inserir.Image = global::CrudFuncionario.Properties.Resources.Save_37110;
            this.btn_Inserir.Location = new System.Drawing.Point(269, 30);
            this.btn_Inserir.Name = "btn_Inserir";
            this.btn_Inserir.Size = new System.Drawing.Size(127, 58);
            this.btn_Inserir.TabIndex = 7;
            this.btn_Inserir.Text = "Inserir";
            this.btn_Inserir.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_Inserir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Inserir.UseVisualStyleBackColor = false;
            this.btn_Inserir.Click += new System.EventHandler(this.btn_Inserir_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(27, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "Salário:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(27, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Data Admissão:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(27, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nome:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(27, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "RG:";
            // 
            // btn_Admissao
            // 
            this.btn_Admissao.Location = new System.Drawing.Point(137, 107);
            this.btn_Admissao.Mask = "99/99/9999";
            this.btn_Admissao.Name = "btn_Admissao";
            this.btn_Admissao.Size = new System.Drawing.Size(93, 22);
            this.btn_Admissao.TabIndex = 0;
            // 
            // txt_Salario
            // 
            this.txt_Salario.Location = new System.Drawing.Point(87, 142);
            this.txt_Salario.Name = "txt_Salario";
            this.txt_Salario.Size = new System.Drawing.Size(100, 22);
            this.txt_Salario.TabIndex = 2;
            // 
            // txt_Nome
            // 
            this.txt_Nome.Location = new System.Drawing.Point(81, 69);
            this.txt_Nome.Name = "txt_Nome";
            this.txt_Nome.Size = new System.Drawing.Size(100, 22);
            this.txt_Nome.TabIndex = 1;
            // 
            // txt_Rg
            // 
            this.txt_Rg.Location = new System.Drawing.Point(64, 34);
            this.txt_Rg.Name = "txt_Rg";
            this.txt_Rg.Size = new System.Drawing.Size(100, 22);
            this.txt_Rg.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.LightSteelBlue;
            this.groupBox2.Controls.Add(this.dgv_Funcionarios);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(30, 265);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(591, 203);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Consultar";
            // 
            // dgv_Funcionarios
            // 
            this.dgv_Funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Funcionarios.Location = new System.Drawing.Point(6, 21);
            this.dgv_Funcionarios.Name = "dgv_Funcionarios";
            this.dgv_Funcionarios.Size = new System.Drawing.Size(579, 166);
            this.dgv_Funcionarios.TabIndex = 0;
            this.dgv_Funcionarios.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Funcionarios_CellContentClick);
            // 
            // btn_Sair
            // 
            this.btn_Sair.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Sair.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Sair.Image = global::CrudFuncionario.Properties.Resources.systemshutdown_103390;
            this.btn_Sair.Location = new System.Drawing.Point(431, 495);
            this.btn_Sair.Name = "btn_Sair";
            this.btn_Sair.Size = new System.Drawing.Size(152, 61);
            this.btn_Sair.TabIndex = 3;
            this.btn_Sair.Text = "Sair";
            this.btn_Sair.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Sair.UseVisualStyleBackColor = false;
            this.btn_Sair.Click += new System.EventHandler(this.btn_Sair_Click);
            // 
            // btn_Limpar
            // 
            this.btn_Limpar.BackColor = System.Drawing.Color.LightSteelBlue;
            this.btn_Limpar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Limpar.Image = global::CrudFuncionario.Properties.Resources.logo_orange_ccleaner_clean_icon_134365;
            this.btn_Limpar.Location = new System.Drawing.Point(60, 495);
            this.btn_Limpar.Name = "btn_Limpar";
            this.btn_Limpar.Size = new System.Drawing.Size(156, 61);
            this.btn_Limpar.TabIndex = 2;
            this.btn_Limpar.Text = "Limpar";
            this.btn_Limpar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_Limpar.UseVisualStyleBackColor = false;
            this.btn_Limpar.Click += new System.EventHandler(this.btn_Limpar_Click);
            // 
            // FrmFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SlateGray;
            this.ClientSize = new System.Drawing.Size(664, 587);
            this.Controls.Add(this.btn_Sair);
            this.Controls.Add(this.btn_Limpar);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "FrmFuncionario";
            this.Text = "FrmFuncionario";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Funcionarios)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Alterar;
        private System.Windows.Forms.Button btn_Excluir;
        private System.Windows.Forms.Button btn_Consultar;
        private System.Windows.Forms.Button btn_Inserir;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MaskedTextBox btn_Admissao;
        private System.Windows.Forms.TextBox txt_Salario;
        private System.Windows.Forms.TextBox txt_Nome;
        private System.Windows.Forms.TextBox txt_Rg;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_Limpar;
        private System.Windows.Forms.Button btn_Sair;
        private System.Windows.Forms.DataGridView dgv_Funcionarios;
    }
}