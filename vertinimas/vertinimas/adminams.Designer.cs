namespace vertinimas
{
    partial class adminams
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
            this.atnaujinti = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.prideti = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.studsar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // atnaujinti
            // 
            this.atnaujinti.BackColor = System.Drawing.Color.SlateBlue;
            this.atnaujinti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.atnaujinti.FlatAppearance.BorderSize = 0;
            this.atnaujinti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.atnaujinti.ForeColor = System.Drawing.Color.White;
            this.atnaujinti.Location = new System.Drawing.Point(236, 310);
            this.atnaujinti.Name = "atnaujinti";
            this.atnaujinti.Size = new System.Drawing.Size(117, 35);
            this.atnaujinti.TabIndex = 52;
            this.atnaujinti.Text = "Atnaujinti";
            this.atnaujinti.UseVisualStyleBackColor = false;
            this.atnaujinti.Click += new System.EventHandler(this.atnaujinti_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label8.ForeColor = System.Drawing.Color.SlateBlue;
            this.label8.Location = new System.Drawing.Point(100, 14);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(205, 24);
            this.label8.TabIndex = 47;
            this.label8.Text = "Dėstytojų sąrašas";
            // 
            // prideti
            // 
            this.prideti.BackColor = System.Drawing.Color.SlateBlue;
            this.prideti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.prideti.FlatAppearance.BorderSize = 0;
            this.prideti.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prideti.ForeColor = System.Drawing.Color.White;
            this.prideti.Location = new System.Drawing.Point(63, 310);
            this.prideti.Name = "prideti";
            this.prideti.Size = new System.Drawing.Size(117, 35);
            this.prideti.TabIndex = 55;
            this.prideti.Text = "Pridėti";
            this.prideti.UseVisualStyleBackColor = false;
            this.prideti.Click += new System.EventHandler(this.prideti_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(63, 53);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(290, 241);
            this.dataGridView1.TabIndex = 56;
            // 
            // studsar
            // 
            this.studsar.BackColor = System.Drawing.Color.SlateBlue;
            this.studsar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.studsar.FlatAppearance.BorderSize = 0;
            this.studsar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.studsar.ForeColor = System.Drawing.Color.White;
            this.studsar.Location = new System.Drawing.Point(89, 368);
            this.studsar.Name = "studsar";
            this.studsar.Size = new System.Drawing.Size(216, 35);
            this.studsar.TabIndex = 57;
            this.studsar.Text = "Studentų sąrašas";
            this.studsar.UseVisualStyleBackColor = false;
            this.studsar.Click += new System.EventHandler(this.studsar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Crimson;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(141, 419);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 58;
            this.button1.Text = "Atsijungti";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // adminams
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 466);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.studsar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.prideti);
            this.Controls.Add(this.atnaujinti);
            this.Controls.Add(this.label8);
            this.Name = "adminams";
            this.Text = "adminams";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button atnaujinti;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button prideti;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button studsar;
        private System.Windows.Forms.Button button1;
    }
}