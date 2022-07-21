namespace FormConsumindoRest
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtPesquisa = new System.Windows.Forms.TextBox();
            this.dtGrid = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.completed = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnDetalhes = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtPesquisa
            // 
            this.txtPesquisa.Location = new System.Drawing.Point(51, 5);
            this.txtPesquisa.Name = "txtPesquisa";
            this.txtPesquisa.PlaceholderText = "Digite aqui a pesquisa...";
            this.txtPesquisa.Size = new System.Drawing.Size(703, 23);
            this.txtPesquisa.TabIndex = 0;
            this.txtPesquisa.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtPesquisa_KeyDown);
            // 
            // dtGrid
            // 
            this.dtGrid.AllowUserToAddRows = false;
            this.dtGrid.AllowUserToDeleteRows = false;
            this.dtGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.title,
            this.completed,
            this.btnDetalhes,
            this.Column1});
            this.dtGrid.Location = new System.Drawing.Point(12, 93);
            this.dtGrid.Name = "dtGrid";
            this.dtGrid.ReadOnly = true;
            this.dtGrid.RowTemplate.Height = 25;
            this.dtGrid.Size = new System.Drawing.Size(776, 345);
            this.dtGrid.TabIndex = 2;
            // 
            // id
            // 
            this.id.DataPropertyName = "id";
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            // 
            // title
            // 
            this.title.DataPropertyName = "title";
            this.title.HeaderText = "Título";
            this.title.Name = "title";
            this.title.ReadOnly = true;
            this.title.Width = 450;
            // 
            // completed
            // 
            this.completed.DataPropertyName = "completed";
            this.completed.HeaderText = "Completado";
            this.completed.Name = "completed";
            this.completed.ReadOnly = true;
            this.completed.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.completed.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.completed.Width = 70;
            // 
            // btnDetalhes
            // 
            this.btnDetalhes.HeaderText = "Detalhes";
            this.btnDetalhes.Name = "btnDetalhes";
            this.btnDetalhes.ReadOnly = true;
            this.btnDetalhes.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.btnDetalhes.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.btnDetalhes.Text = "Detalhes";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "userid";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Visible = false;
            this.Column1.Width = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dtGrid);
            this.Controls.Add(this.txtPesquisa);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dtGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtPesquisa;
        private DataGridView dtGrid;
        private DataGridViewTextBoxColumn id;
        private DataGridViewTextBoxColumn title;
        private DataGridViewCheckBoxColumn completed;
        private DataGridViewButtonColumn btnDetalhes;
        private DataGridViewTextBoxColumn Column1;
    }
}