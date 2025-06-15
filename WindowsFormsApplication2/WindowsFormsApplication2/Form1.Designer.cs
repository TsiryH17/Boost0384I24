namespace WindowsFormsApplication2 
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
            this.components = new System.ComponentModel.Container();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtPren = new System.Windows.Forms.TextBox();
            this.btnAjt = new System.Windows.Forms.Button();
            this.baseBoostDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.baseBoostDataSet = new WindowsFormsApplication2.BaseBoostDataSet();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtage = new System.Windows.Forms.TextBox();
            this.txtadr = new System.Windows.Forms.TextBox();
            this.txtPrf = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.baseBoostDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseBoostDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(147, 88);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(147, 146);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(263, 83);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(132, 25);
            this.txtNom.TabIndex = 3;
            // 
            // txtPren
            // 
            this.txtPren.Location = new System.Drawing.Point(263, 140);
            this.txtPren.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPren.Name = "txtPren";
            this.txtPren.Size = new System.Drawing.Size(132, 25);
            this.txtPren.TabIndex = 4;
            // 
            // btnAjt
            // 
            this.btnAjt.Location = new System.Drawing.Point(217, 415);
            this.btnAjt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAjt.Name = "btnAjt";
            this.btnAjt.Size = new System.Drawing.Size(100, 39);
            this.btnAjt.TabIndex = 5;
            this.btnAjt.Text = "Ajouter";
            this.btnAjt.UseVisualStyleBackColor = true;
            this.btnAjt.Click += new System.EventHandler(this.btnAjt_Click);
            // 
            // baseBoostDataSetBindingSource
            // 
            this.baseBoostDataSetBindingSource.DataSource = this.baseBoostDataSet;
            this.baseBoostDataSetBindingSource.Position = 0;
            // 
            // baseBoostDataSet
            // 
            this.baseBoostDataSet.DataSetName = "BaseBoostDataSet";
            this.baseBoostDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(151, 217);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(34, 22);
            this.label1.TabIndex = 6;
            this.label1.Text = "Age";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(151, 279);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 22);
            this.label4.TabIndex = 7;
            this.label4.Text = "Adresse";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(147, 347);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(75, 22);
            this.label5.TabIndex = 8;
            this.label5.Text = "Profession";
            // 
            // txtage
            // 
            this.txtage.Location = new System.Drawing.Point(263, 217);
            this.txtage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtage.Name = "txtage";
            this.txtage.Size = new System.Drawing.Size(132, 25);
            this.txtage.TabIndex = 9;
            // 
            // txtadr
            // 
            this.txtadr.Location = new System.Drawing.Point(263, 283);
            this.txtadr.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtadr.Name = "txtadr";
            this.txtadr.Size = new System.Drawing.Size(132, 25);
            this.txtadr.TabIndex = 10;
            // 
            // txtPrf
            // 
            this.txtPrf.Location = new System.Drawing.Point(263, 347);
            this.txtPrf.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPrf.Name = "txtPrf";
            this.txtPrf.Size = new System.Drawing.Size(132, 25);
            this.txtPrf.TabIndex = 11;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.Gold;
            this.dataGridView1.Location = new System.Drawing.Point(479, 137);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(531, 281);
            this.dataGridView1.TabIndex = 12;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(614, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(221, 22);
            this.label6.TabIndex = 13;
            this.label6.Text = "Liste des personnes enregistrées : ";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Firebrick;
            this.ClientSize = new System.Drawing.Size(1107, 526);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtPrf);
            this.Controls.Add(this.txtadr);
            this.Controls.Add(this.txtage);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAjt);
            this.Controls.Add(this.txtPren);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Poppins", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.baseBoostDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.baseBoostDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtPren;
        private System.Windows.Forms.Button btnAjt;
        private System.Windows.Forms.BindingSource baseBoostDataSetBindingSource;
        private BaseBoostDataSet baseBoostDataSet;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtage;
        private System.Windows.Forms.TextBox txtadr;
        private System.Windows.Forms.TextBox txtPrf;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label6;

    }
}

