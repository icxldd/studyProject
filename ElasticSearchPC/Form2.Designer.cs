namespace ElasticSearchPC
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
          #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.CtxtContext = new System.Windows.Forms.TextBox();
            this.CbtnRemove = new System.Windows.Forms.Button();
            this.CbtnUpdate = new System.Windows.Forms.Button();
            this.CbtnGetAll = new System.Windows.Forms.Button();
            this.Cbtnadd = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.CtxtFull = new System.Windows.Forms.RichTextBox();
            this.CbtnGetAll2 = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 809);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.CtxtContext);
            this.panel3.Controls.Add(this.CbtnRemove);
            this.panel3.Controls.Add(this.CbtnUpdate);
            this.panel3.Controls.Add(this.CbtnGetAll2);
            this.panel3.Controls.Add(this.CbtnGetAll);
            this.panel3.Controls.Add(this.Cbtnadd);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 452);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 357);
            this.panel3.TabIndex = 1;
            this.panel3.Click += new System.EventHandler(this.CbtnUpdate_Click);
            // 
            // CtxtContext
            // 
            this.CtxtContext.Location = new System.Drawing.Point(12, 43);
            this.CtxtContext.Name = "CtxtContext";
            this.CtxtContext.Size = new System.Drawing.Size(100, 23);
            this.CtxtContext.TabIndex = 1;
            this.CtxtContext.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CtxtContext_KeyDown);
            this.CtxtContext.KeyUp += new System.Windows.Forms.KeyEventHandler(this.CtxtContext_KeyUp);
            // 
            // CbtnRemove
            // 
            this.CbtnRemove.Location = new System.Drawing.Point(127, 181);
            this.CbtnRemove.Name = "CbtnRemove";
            this.CbtnRemove.Size = new System.Drawing.Size(75, 23);
            this.CbtnRemove.TabIndex = 0;
            this.CbtnRemove.Text = "删除";
            this.CbtnRemove.UseVisualStyleBackColor = true;
            this.CbtnRemove.Click += new System.EventHandler(this.CbtnRemove_Click);
            // 
            // CbtnUpdate
            // 
            this.CbtnUpdate.Location = new System.Drawing.Point(12, 181);
            this.CbtnUpdate.Name = "CbtnUpdate";
            this.CbtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.CbtnUpdate.TabIndex = 0;
            this.CbtnUpdate.Text = "修改";
            this.CbtnUpdate.UseVisualStyleBackColor = true;
            this.CbtnUpdate.Click += new System.EventHandler(this.CbtnUpdate_Click);
            // 
            // CbtnGetAll
            // 
            this.CbtnGetAll.Location = new System.Drawing.Point(127, 222);
            this.CbtnGetAll.Name = "CbtnGetAll";
            this.CbtnGetAll.Size = new System.Drawing.Size(75, 23);
            this.CbtnGetAll.TabIndex = 0;
            this.CbtnGetAll.Text = "查询全部";
            this.CbtnGetAll.UseVisualStyleBackColor = true;
            this.CbtnGetAll.Click += new System.EventHandler(this.CbtnGetAll_Click);
            // 
            // Cbtnadd
            // 
            this.Cbtnadd.Location = new System.Drawing.Point(12, 222);
            this.Cbtnadd.Name = "Cbtnadd";
            this.Cbtnadd.Size = new System.Drawing.Size(75, 23);
            this.Cbtnadd.TabIndex = 0;
            this.Cbtnadd.Text = "插入";
            this.Cbtnadd.UseVisualStyleBackColor = true;
            this.Cbtnadd.Click += new System.EventHandler(this.Cbtnadd_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.CtxtFull);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 454);
            this.panel2.TabIndex = 0;
            // 
            // CtxtFull
            // 
            this.CtxtFull.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CtxtFull.Location = new System.Drawing.Point(0, 0);
            this.CtxtFull.Name = "CtxtFull";
            this.CtxtFull.Size = new System.Drawing.Size(1002, 454);
            this.CtxtFull.TabIndex = 0;
            this.CtxtFull.Text = "";
            // 
            // CbtnGetAll2
            // 
            this.CbtnGetAll2.Location = new System.Drawing.Point(262, 222);
            this.CbtnGetAll2.Name = "CbtnGetAll2";
            this.CbtnGetAll2.Size = new System.Drawing.Size(75, 23);
            this.CbtnGetAll2.TabIndex = 0;
            this.CbtnGetAll2.Text = "查询全部2";
            this.CbtnGetAll2.UseVisualStyleBackColor = true;
            this.CbtnGetAll2.Click += new System.EventHandler(this.CbtnGetAll2_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 809);
            this.Controls.Add(this.panel1);
            this.Name = "Form2";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox CtxtContext;
        private System.Windows.Forms.Button Cbtnadd;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RichTextBox CtxtFull;
        private System.Windows.Forms.Button CbtnGetAll;
        private System.Windows.Forms.Button CbtnUpdate;
        private System.Windows.Forms.Button CbtnRemove;
        private System.Windows.Forms.Button CbtnGetAll2;
    }
}