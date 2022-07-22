namespace Proyectogasolina
{
    partial class Form1
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
            this.gasolina = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.costokm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.galonkm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.litrokm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btninicio = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gasolina)).BeginInit();
            this.SuspendLayout();
            // 
            // gasolina
            // 
            this.gasolina.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gasolina.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.costokm,
            this.galonkm,
            this.litrokm});
            this.gasolina.Location = new System.Drawing.Point(0, 0);
            this.gasolina.Name = "gasolina";
            this.gasolina.RowHeadersWidth = 51;
            this.gasolina.RowTemplate.Height = 24;
            this.gasolina.Size = new System.Drawing.Size(553, 278);
            this.gasolina.TabIndex = 0;
            // 
            // id
            // 
            this.id.HeaderText = "ID";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.Width = 125;
            // 
            // costokm
            // 
            this.costokm.HeaderText = "Costo/Km";
            this.costokm.MinimumWidth = 6;
            this.costokm.Name = "costokm";
            this.costokm.Width = 125;
            // 
            // galonkm
            // 
            this.galonkm.HeaderText = "Galon/Km";
            this.galonkm.MinimumWidth = 6;
            this.galonkm.Name = "galonkm";
            this.galonkm.Width = 125;
            // 
            // litrokm
            // 
            this.litrokm.HeaderText = "Litro/Km";
            this.litrokm.MinimumWidth = 6;
            this.litrokm.Name = "litrokm";
            this.litrokm.Width = 125;
            // 
            // btninicio
            // 
            this.btninicio.Location = new System.Drawing.Point(559, 0);
            this.btninicio.Name = "btninicio";
            this.btninicio.Size = new System.Drawing.Size(144, 92);
            this.btninicio.TabIndex = 1;
            this.btninicio.Text = "Comenzar";
            this.btninicio.UseVisualStyleBackColor = true;
            this.btninicio.Click += new System.EventHandler(this.btninicio_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 282);
            this.Controls.Add(this.btninicio);
            this.Controls.Add(this.gasolina);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gasolina)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView gasolina;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn costokm;
        private System.Windows.Forms.DataGridViewTextBoxColumn galonkm;
        private System.Windows.Forms.DataGridViewTextBoxColumn litrokm;
        private System.Windows.Forms.Button btninicio;
    }
}

