﻿namespace PhoneList
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.MaskedTextBox();
            this.btAdd = new System.Windows.Forms.Button();
            this.dgvList = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
            this.lbl2 = new System.Windows.Forms.Label();
            this.btRemove = new System.Windows.Forms.Button();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
=======
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btRemove = new System.Windows.Forms.Button();
>>>>>>> 7c4d935baf96d3658d7b73c9159deb1b15655625
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(521, 86);
            this.lbl1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(108, 39);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "Nome";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(680, 100);
<<<<<<< HEAD
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
=======
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> 7c4d935baf96d3658d7b73c9159deb1b15655625
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(132, 22);
            this.txtName.TabIndex = 1;
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(680, 182);
<<<<<<< HEAD
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4);
=======
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> 7c4d935baf96d3658d7b73c9159deb1b15655625
            this.txtPhone.Mask = "(00) 00000-0000";
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 22);
            this.txtPhone.TabIndex = 2;
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(480, 337);
<<<<<<< HEAD
            this.btAdd.Margin = new System.Windows.Forms.Padding(4);
=======
            this.btAdd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> 7c4d935baf96d3658d7b73c9159deb1b15655625
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(168, 57);
            this.btAdd.TabIndex = 3;
            this.btAdd.Text = "Adicionar";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.BackgroundColor = System.Drawing.Color.Violet;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
<<<<<<< HEAD
            this.id,
            this.Nome,
            this.Telefone});
            this.dgvList.Location = new System.Drawing.Point(16, 15);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4);
=======
            this.Nome,
            this.Telefone});
            this.dgvList.Location = new System.Drawing.Point(16, 15);
            this.dgvList.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> 7c4d935baf96d3658d7b73c9159deb1b15655625
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersWidth = 51;
            this.dgvList.Size = new System.Drawing.Size(395, 524);
            this.dgvList.TabIndex = 4;
            // 
<<<<<<< HEAD
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(488, 169);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(150, 39);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Telefone";
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(745, 337);
            this.btRemove.Margin = new System.Windows.Forms.Padding(4);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(168, 57);
            this.btRemove.TabIndex = 7;
            this.btRemove.Text = "Remover";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 125;
            // 
=======
>>>>>>> 7c4d935baf96d3658d7b73c9159deb1b15655625
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.MinimumWidth = 6;
            this.Nome.Name = "Nome";
            this.Nome.ReadOnly = true;
            this.Nome.Width = 125;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.MinimumWidth = 6;
            this.Telefone.Name = "Telefone";
            this.Telefone.ReadOnly = true;
            this.Telefone.Width = 125;
            // 
<<<<<<< HEAD
=======
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl2.Location = new System.Drawing.Point(488, 169);
            this.lbl2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(150, 39);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Telefone";
            // 
            // btRemove
            // 
            this.btRemove.Location = new System.Drawing.Point(745, 337);
            this.btRemove.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btRemove.Name = "btRemove";
            this.btRemove.Size = new System.Drawing.Size(168, 57);
            this.btRemove.TabIndex = 7;
            this.btRemove.Text = "Remover";
            this.btRemove.UseVisualStyleBackColor = true;
            this.btRemove.Click += new System.EventHandler(this.btRemove_Click);
            // 
>>>>>>> 7c4d935baf96d3658d7b73c9159deb1b15655625
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1067, 554);
            this.Controls.Add(this.btRemove);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.dgvList);
            this.Controls.Add(this.btAdd);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lbl1);
<<<<<<< HEAD
            this.Margin = new System.Windows.Forms.Padding(4);
=======
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
>>>>>>> 7c4d935baf96d3658d7b73c9159deb1b15655625
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.MaskedTextBox txtPhone;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.Label lbl2;
<<<<<<< HEAD
        private System.Windows.Forms.Button btRemove;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
=======
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.Button btRemove;
>>>>>>> 7c4d935baf96d3658d7b73c9159deb1b15655625
    }
}

