
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
            this.button2 = new System.Windows.Forms.Button();
            this.ProcurarPastaBt = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.EnderecoPastaDestinoTxt = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
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
            this.tabControl1.Size = new System.Drawing.Size(772, 359);
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
            this.tabPage1.Size = new System.Drawing.Size(764, 333);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Unir ficheiros";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox3.Controls.Add(this.button2);
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
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(668, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "UNIR!";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
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
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Location = new System.Drawing.Point(8, 128);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(748, 197);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ficheiros";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NomeFicheiro,
            this.Visualizar,
            this.Eliminar});
            this.dataGridView1.Location = new System.Drawing.Point(8, 19);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(734, 172);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(764, 333);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Eliminar página(s)";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 359);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "SimProgramming | PDF utilitário";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn NomeFicheiro;
        private System.Windows.Forms.DataGridViewLinkColumn Visualizar;
        private System.Windows.Forms.DataGridViewLinkColumn Eliminar;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button ProcurarPastaBt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox EnderecoPastaDestinoTxt;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
    }
}

