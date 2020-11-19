namespace RXNetRedis
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
            this.CFullText = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CbtnALL = new System.Windows.Forms.Button();
            this.btnUpdate2 = new System.Windows.Forms.Button();
            this.CbtnGetAll2 = new System.Windows.Forms.Button();
            this.CbtnUpdate = new System.Windows.Forms.Button();
            this.CbuttonDeleteById = new System.Windows.Forms.Button();
            this.CbtnDelete2 = new System.Windows.Forms.Button();
            this.CbtnGet = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.CgetById = new System.Windows.Forms.Button();
            this.Ctxt2 = new System.Windows.Forms.TextBox();
            this.CtxtId = new System.Windows.Forms.TextBox();
            this.CButtonChangeValue = new System.Windows.Forms.Button();
            this.CtxtRabbitmq = new System.Windows.Forms.TextBox();
            this.CbtnRabbitStart = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // CFullText
            // 
            this.CFullText.Dock = System.Windows.Forms.DockStyle.Top;
            this.CFullText.Location = new System.Drawing.Point(0, 0);
            this.CFullText.Name = "CFullText";
            this.CFullText.Size = new System.Drawing.Size(1175, 459);
            this.CFullText.TabIndex = 0;
            this.CFullText.Text = "";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CbtnRabbitStart);
            this.panel1.Controls.Add(this.CtxtRabbitmq);
            this.panel1.Controls.Add(this.CbtnALL);
            this.panel1.Controls.Add(this.btnUpdate2);
            this.panel1.Controls.Add(this.CbtnGetAll2);
            this.panel1.Controls.Add(this.CbtnUpdate);
            this.panel1.Controls.Add(this.CbuttonDeleteById);
            this.panel1.Controls.Add(this.CbtnDelete2);
            this.panel1.Controls.Add(this.CbtnGet);
            this.panel1.Controls.Add(this.btnsave);
            this.panel1.Controls.Add(this.CgetById);
            this.panel1.Controls.Add(this.Ctxt2);
            this.panel1.Controls.Add(this.CtxtId);
            this.panel1.Controls.Add(this.CButtonChangeValue);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 456);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 327);
            this.panel1.TabIndex = 1;
            // 
            // CbtnALL
            // 
            this.CbtnALL.Location = new System.Drawing.Point(621, 33);
            this.CbtnALL.Name = "CbtnALL";
            this.CbtnALL.Size = new System.Drawing.Size(75, 23);
            this.CbtnALL.TabIndex = 5;
            this.CbtnALL.Text = "获取全部";
            this.CbtnALL.UseVisualStyleBackColor = true;
            this.CbtnALL.Click += new System.EventHandler(this.CbtnALL_Click);
            // 
            // btnUpdate2
            // 
            this.btnUpdate2.Location = new System.Drawing.Point(524, 89);
            this.btnUpdate2.Name = "btnUpdate2";
            this.btnUpdate2.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate2.TabIndex = 4;
            this.btnUpdate2.Text = "修改值";
            this.btnUpdate2.UseVisualStyleBackColor = true;
            this.btnUpdate2.Click += new System.EventHandler(this.btnUpdate2_Click);
            // 
            // CbtnGetAll2
            // 
            this.CbtnGetAll2.Location = new System.Drawing.Point(621, 89);
            this.CbtnGetAll2.Name = "CbtnGetAll2";
            this.CbtnGetAll2.Size = new System.Drawing.Size(75, 23);
            this.CbtnGetAll2.TabIndex = 4;
            this.CbtnGetAll2.Text = "获取全部";
            this.CbtnGetAll2.UseVisualStyleBackColor = true;
            this.CbtnGetAll2.Click += new System.EventHandler(this.CbtnGetAll2_Click);
            // 
            // CbtnUpdate
            // 
            this.CbtnUpdate.Location = new System.Drawing.Point(524, 33);
            this.CbtnUpdate.Name = "CbtnUpdate";
            this.CbtnUpdate.Size = new System.Drawing.Size(75, 23);
            this.CbtnUpdate.TabIndex = 4;
            this.CbtnUpdate.Text = "修改值";
            this.CbtnUpdate.UseVisualStyleBackColor = true;
            // 
            // CbuttonDeleteById
            // 
            this.CbuttonDeleteById.Location = new System.Drawing.Point(402, 33);
            this.CbuttonDeleteById.Name = "CbuttonDeleteById";
            this.CbuttonDeleteById.Size = new System.Drawing.Size(90, 23);
            this.CbuttonDeleteById.TabIndex = 3;
            this.CbuttonDeleteById.Text = "根据ID删除值";
            this.CbuttonDeleteById.UseVisualStyleBackColor = true;
            this.CbuttonDeleteById.Click += new System.EventHandler(this.CbuttonDeleteById_Click);
            // 
            // CbtnDelete2
            // 
            this.CbtnDelete2.Location = new System.Drawing.Point(400, 89);
            this.CbtnDelete2.Name = "CbtnDelete2";
            this.CbtnDelete2.Size = new System.Drawing.Size(92, 23);
            this.CbtnDelete2.TabIndex = 2;
            this.CbtnDelete2.Text = "根据ID删除值";
            this.CbtnDelete2.UseVisualStyleBackColor = true;
            this.CbtnDelete2.Click += new System.EventHandler(this.CbtnDelete2_Click);
            // 
            // CbtnGet
            // 
            this.CbtnGet.Location = new System.Drawing.Point(285, 89);
            this.CbtnGet.Name = "CbtnGet";
            this.CbtnGet.Size = new System.Drawing.Size(92, 23);
            this.CbtnGet.TabIndex = 2;
            this.CbtnGet.Text = "根据ID获取值";
            this.CbtnGet.UseVisualStyleBackColor = true;
            this.CbtnGet.Click += new System.EventHandler(this.CbtnGet_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(39, 89);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(92, 23);
            this.btnsave.TabIndex = 2;
            this.btnsave.Text = "保存值";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // CgetById
            // 
            this.CgetById.Location = new System.Drawing.Point(285, 33);
            this.CgetById.Name = "CgetById";
            this.CgetById.Size = new System.Drawing.Size(92, 23);
            this.CgetById.TabIndex = 2;
            this.CgetById.Text = "根据ID获取值";
            this.CgetById.UseVisualStyleBackColor = true;
            // 
            // Ctxt2
            // 
            this.Ctxt2.Location = new System.Drawing.Point(160, 89);
            this.Ctxt2.Name = "Ctxt2";
            this.Ctxt2.Size = new System.Drawing.Size(100, 23);
            this.Ctxt2.TabIndex = 1;
            // 
            // CtxtId
            // 
            this.CtxtId.Location = new System.Drawing.Point(160, 33);
            this.CtxtId.Name = "CtxtId";
            this.CtxtId.Size = new System.Drawing.Size(100, 23);
            this.CtxtId.TabIndex = 1;
            // 
            // CButtonChangeValue
            // 
            this.CButtonChangeValue.Location = new System.Drawing.Point(39, 33);
            this.CButtonChangeValue.Name = "CButtonChangeValue";
            this.CButtonChangeValue.Size = new System.Drawing.Size(75, 23);
            this.CButtonChangeValue.TabIndex = 0;
            this.CButtonChangeValue.Text = "RX更改值";
            this.CButtonChangeValue.UseVisualStyleBackColor = true;
            this.CButtonChangeValue.Click += new System.EventHandler(this.CButtonChangeValue_Click);
            // 
            // CtxtRabbitmq
            // 
            this.CtxtRabbitmq.Location = new System.Drawing.Point(39, 174);
            this.CtxtRabbitmq.Name = "CtxtRabbitmq";
            this.CtxtRabbitmq.Size = new System.Drawing.Size(100, 23);
            this.CtxtRabbitmq.TabIndex = 6;
            // 
            // CbtnRabbitStart
            // 
            this.CbtnRabbitStart.Location = new System.Drawing.Point(160, 173);
            this.CbtnRabbitStart.Name = "CbtnRabbitStart";
            this.CbtnRabbitStart.Size = new System.Drawing.Size(75, 23);
            this.CbtnRabbitStart.TabIndex = 7;
            this.CbtnRabbitStart.Text = "发送事件";
            this.CbtnRabbitStart.UseVisualStyleBackColor = true;
            this.CbtnRabbitStart.Click += new System.EventHandler(this.CbtnRabbitStart_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1175, 783);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.CFullText);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.RichTextBox CFullText;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button CButtonChangeValue;
        private System.Windows.Forms.Button CgetById;
        private System.Windows.Forms.TextBox CtxtId;
        private System.Windows.Forms.Button CbuttonDeleteById;
        private System.Windows.Forms.Button CbtnUpdate;
        private System.Windows.Forms.Button CbtnALL;
        private System.Windows.Forms.Button btnsave;
        private System.Windows.Forms.Button CbtnGet;
        private System.Windows.Forms.Button btnUpdate2;
        private System.Windows.Forms.Button CbtnDelete2;
        private System.Windows.Forms.TextBox Ctxt2;
        private System.Windows.Forms.Button CbtnGetAll2;
        private System.Windows.Forms.Button G;
        private System.Windows.Forms.Button etAl;
        private System.Windows.Forms.Button CbtnRabbitStart;
        private System.Windows.Forms.TextBox CtxtRabbitmq;
    }
}

