
namespace ProjetoLDS
{
    partial class Form1
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

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.ConcatenarFicheirosBt = new System.Windows.Forms.Button();
            this.ProcurarPastaBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EnderecoPastaDestinoTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.UnirFicheirosGridView = new System.Windows.Forms.DataGridView();
            this.NomeFicheiro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Visualizar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.InserirBt = new System.Windows.Forms.Button();
            this.ProcurarBt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EnderecoFicheiroTxt = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Procurar2Bt = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.EnderecoFicheiro2Txt = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.EliminarBt = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.PaginasParaEliminarTxt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UnirFicheirosGridView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(834, 495);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox3);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(826, 469);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unir ficheiros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.ConcatenarFicheirosBt);
            this.groupBox3.Controls.Add(this.ProcurarPastaBt);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.EnderecoPastaDestinoTxt);
            this.groupBox3.Location = new System.Drawing.Point(8, 72);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(747, 50);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Destino";
            // 
            // ConcatenarFicheirosBt
            // 
            this.ConcatenarFicheirosBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ConcatenarFicheirosBt.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConcatenarFicheirosBt.ForeColor = System.Drawing.Color.Maroon;
            this.ConcatenarFicheirosBt.Location = new System.Drawing.Point(668, 17);
            this.ConcatenarFicheirosBt.Name = "ConcatenarFicheirosBt";
            this.ConcatenarFicheirosBt.Size = new System.Drawing.Size(75, 23);
            this.ConcatenarFicheirosBt.TabIndex = 7;
            this.ConcatenarFicheirosBt.Text = "UNIR!";
            this.ConcatenarFicheirosBt.UseVisualStyleBackColor = true;
            this.ConcatenarFicheirosBt.Click += new System.EventHandler(this.ConcatenarFicheirosBt_Click);
            // 
            // ProcurarPastaBt
            // 
            this.ProcurarPastaBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcurarPastaBt.Location = new System.Drawing.Point(591, 17);
            this.ProcurarPastaBt.Name = "ProcurarPastaBt";
            this.ProcurarPastaBt.Size = new System.Drawing.Size(73, 23);
            this.ProcurarPastaBt.TabIndex = 6;
            this.ProcurarPastaBt.Text = "Procurar";
            this.ProcurarPastaBt.UseVisualStyleBackColor = true;
            this.ProcurarPastaBt.Click += new System.EventHandler(this.ProcurarPastaBt_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Endereço";
            // 
            // EnderecoPastaDestinoTxt
            // 
            this.EnderecoPastaDestinoTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnderecoPastaDestinoTxt.Location = new System.Drawing.Point(64, 19);
            this.EnderecoPastaDestinoTxt.Name = "EnderecoPastaDestinoTxt";
            this.EnderecoPastaDestinoTxt.Size = new System.Drawing.Size(521, 20);
            this.EnderecoPastaDestinoTxt.TabIndex = 4;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.UnirFicheirosGridView);
            this.groupBox2.Location = new System.Drawing.Point(8, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 333);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ficheiros";
            // 
            // UnirFicheirosGridView
            // 
            this.UnirFicheirosGridView.AllowUserToAddRows = false;
            this.UnirFicheirosGridView.AllowUserToDeleteRows = false;
            this.UnirFicheirosGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.UnirFicheirosGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.UnirFicheirosGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeFicheiro,
            this.Visualizar,
            this.Eliminar});
            this.UnirFicheirosGridView.Location = new System.Drawing.Point(8, 19);
            this.UnirFicheirosGridView.Name = "UnirFicheirosGridView";
            this.UnirFicheirosGridView.ReadOnly = true;
            this.UnirFicheirosGridView.Size = new System.Drawing.Size(734, 308);
            this.UnirFicheirosGridView.TabIndex = 0;
            this.UnirFicheirosGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UnirFicheirosGridView_CellContentClick);
            // 
            // NomeFicheiro
            // 
            this.NomeFicheiro.HeaderText = "Nome do ficheiro";
            this.NomeFicheiro.Name = "NomeFicheiro";
            this.NomeFicheiro.ReadOnly = true;
            this.NomeFicheiro.Width = 112;
            // 
            // Visualizar
            // 
            this.Visualizar.HeaderText = "*";
            this.Visualizar.Name = "Visualizar";
            this.Visualizar.ReadOnly = true;
            this.Visualizar.Width = 17;
            // 
            // Eliminar
            // 
            this.Eliminar.HeaderText = "*";
            this.Eliminar.Name = "Eliminar";
            this.Eliminar.ReadOnly = true;
            this.Eliminar.Width = 17;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.InserirBt);
            this.groupBox1.Controls.Add(this.ProcurarBt);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.EnderecoFicheiroTxt);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(8, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 60);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Adicionar ficheiros";
            // 
            // InserirBt
            // 
            this.InserirBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.InserirBt.Location = new System.Drawing.Point(668, 27);
            this.InserirBt.Name = "InserirBt";
            this.InserirBt.Size = new System.Drawing.Size(74, 20);
            this.InserirBt.TabIndex = 4;
            this.InserirBt.Text = "Inserir";
            this.InserirBt.UseVisualStyleBackColor = true;
            this.InserirBt.Click += new System.EventHandler(this.InserirBt_Click);
            // 
            // ProcurarBt
            // 
            this.ProcurarBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ProcurarBt.Location = new System.Drawing.Point(591, 27);
            this.ProcurarBt.Name = "ProcurarBt";
            this.ProcurarBt.Size = new System.Drawing.Size(73, 21);
            this.ProcurarBt.TabIndex = 3;
            this.ProcurarBt.Text = "Procurar";
            this.ProcurarBt.UseVisualStyleBackColor = true;
            this.ProcurarBt.Click += new System.EventHandler(this.ProcurarBt_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Endereço";
            // 
            // EnderecoFicheiroTxt
            // 
            this.EnderecoFicheiroTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnderecoFicheiroTxt.Location = new System.Drawing.Point(64, 28);
            this.EnderecoFicheiroTxt.Name = "EnderecoFicheiroTxt";
            this.EnderecoFicheiroTxt.Size = new System.Drawing.Size(521, 20);
            this.EnderecoFicheiroTxt.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(251, -155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(826, 469);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar página(s)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.Procurar2Bt);
            this.groupBox4.Controls.Add(this.label3);
            this.groupBox4.Controls.Add(this.EnderecoFicheiro2Txt);
            this.groupBox4.Controls.Add(this.textBox3);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(810, 48);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Selecionar ficheiro";
            // 
            // Procurar2Bt
            // 
            this.Procurar2Bt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Procurar2Bt.Location = new System.Drawing.Point(697, 18);
            this.Procurar2Bt.Name = "Procurar2Bt";
            this.Procurar2Bt.Size = new System.Drawing.Size(107, 21);
            this.Procurar2Bt.TabIndex = 3;
            this.Procurar2Bt.Text = "Procurar";
            this.Procurar2Bt.UseVisualStyleBackColor = true;
            this.Procurar2Bt.Click += new System.EventHandler(this.Procurar2Bt_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Endereço";
            // 
            // EnderecoFicheiro2Txt
            // 
            this.EnderecoFicheiro2Txt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EnderecoFicheiro2Txt.Location = new System.Drawing.Point(64, 19);
            this.EnderecoFicheiro2Txt.Name = "EnderecoFicheiro2Txt";
            this.EnderecoFicheiro2Txt.Size = new System.Drawing.Size(627, 20);
            this.EnderecoFicheiro2Txt.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(251, -155);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 0;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // EliminarBt
            // 
            this.EliminarBt.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.EliminarBt.Location = new System.Drawing.Point(697, 17);
            this.EliminarBt.Name = "EliminarBt";
            this.EliminarBt.Size = new System.Drawing.Size(107, 23);
            this.EliminarBt.TabIndex = 2;
            this.EliminarBt.Text = "Eliminar página(s)";
            this.EliminarBt.UseVisualStyleBackColor = true;
            this.EliminarBt.Click += new System.EventHandler(this.EliminarBt_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox5.Controls.Add(this.label5);
            this.groupBox5.Controls.Add(this.label4);
            this.groupBox5.Controls.Add(this.PaginasParaEliminarTxt);
            this.groupBox5.Controls.Add(this.EliminarBt);
            this.groupBox5.Location = new System.Drawing.Point(6, 60);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(810, 63);
            this.groupBox5.TabIndex = 3;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Selecionar página(s) para eliminar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Página(s)";
            // 
            // PaginasParaEliminarTxt
            // 
            this.PaginasParaEliminarTxt.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.PaginasParaEliminarTxt.Location = new System.Drawing.Point(64, 19);
            this.PaginasParaEliminarTxt.Name = "PaginasParaEliminarTxt";
            this.PaginasParaEliminarTxt.Size = new System.Drawing.Size(627, 20);
            this.PaginasParaEliminarTxt.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(61, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(179, 13);
            this.label5.TabIndex = 3;
            this.label5.Text = "Por exemplo, 1-5, 8, 11-13 ou 1; 3; 5";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(834, 495);
            this.Controls.Add(this.tabControl1);
            this.MinimumSize = new System.Drawing.Size(600, 300);
            this.Name = "Form1";
            this.Text = "SimProgramming | PDF utilitário";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UnirFicheirosGridView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button InserirBt;
        private System.Windows.Forms.Button ProcurarBt;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox EnderecoFicheiroTxt;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView UnirFicheirosGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFicheiro;
        private System.Windows.Forms.DataGridViewLinkColumn Visualizar;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button ConcatenarFicheirosBt;
        private System.Windows.Forms.Button ProcurarPastaBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnderecoPastaDestinoTxt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button Procurar2Bt;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox EnderecoFicheiro2Txt;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Button EliminarBt;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox PaginasParaEliminarTxt;
        private System.Windows.Forms.Label label5;
    }
}

