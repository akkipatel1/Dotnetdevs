namespace AccountDemoApp
{
    partial class AccountForm
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnCreate = new Button();
            btnSet = new Button();
            btnGet = new Button();
            btnClear = new Button();
            btnDestroy = new Button();
            btnGC = new Button();
            txtId = new TextBox();
            txtName = new TextBox();
            txtBalance = new TextBox();
            btnTemp = new Button();
            btnGetGeneration = new Button();
            btnWithdraw = new Button();
            btnDeposite = new Button();
            txtAmount = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 42);
            label1.Name = "label1";
            label1.Size = new Size(22, 20);
            label1.TabIndex = 0;
            label1.Text = "Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(189, 42);
            label2.Name = "label2";
            label2.Size = new Size(49, 20);
            label2.TabIndex = 2;
            label2.Text = "Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(336, 42);
            label3.Name = "label3";
            label3.Size = new Size(61, 20);
            label3.TabIndex = 4;
            label3.Text = "Balance";
            // 
            // btnCreate
            // 
            btnCreate.Location = new Point(41, 120);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(125, 38);
            btnCreate.TabIndex = 6;
            btnCreate.Text = "Create";
            btnCreate.UseVisualStyleBackColor = true;
            btnCreate.Click += btnCreate_Click;
            // 
            // btnSet
            // 
            btnSet.Location = new Point(189, 120);
            btnSet.Name = "btnSet";
            btnSet.Size = new Size(125, 38);
            btnSet.TabIndex = 7;
            btnSet.Text = "Set";
            btnSet.UseVisualStyleBackColor = true;
            btnSet.Click += btnSet_Click;
            // 
            // btnGet
            // 
            btnGet.Location = new Point(336, 120);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(125, 38);
            btnGet.TabIndex = 8;
            btnGet.Text = "Get";
            btnGet.UseVisualStyleBackColor = true;
            btnGet.Click += button3_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(41, 175);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(125, 38);
            btnClear.TabIndex = 9;
            btnClear.Text = "Clear";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnDestroy
            // 
            btnDestroy.Location = new Point(189, 175);
            btnDestroy.Name = "btnDestroy";
            btnDestroy.Size = new Size(125, 38);
            btnDestroy.TabIndex = 10;
            btnDestroy.Text = "Destroy";
            btnDestroy.UseVisualStyleBackColor = true;
            btnDestroy.Click += btnDestroy_Click;
            // 
            // btnGC
            // 
            btnGC.Location = new Point(336, 175);
            btnGC.Name = "btnGC";
            btnGC.Size = new Size(125, 38);
            btnGC.TabIndex = 11;
            btnGC.Text = "GC";
            btnGC.UseVisualStyleBackColor = true;
            btnGC.Click += btnGC_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(41, 78);
            txtId.Name = "txtId";
            txtId.Size = new Size(125, 27);
            txtId.TabIndex = 1;
            txtId.TextChanged += txtId_TextChanged;
            // 
            // txtName
            // 
            txtName.Location = new Point(189, 78);
            txtName.Name = "txtName";
            txtName.Size = new Size(125, 27);
            txtName.TabIndex = 3;
            txtName.TextChanged += textBox2_TextChanged;
            // 
            // txtBalance
            // 
            txtBalance.Location = new Point(336, 78);
            txtBalance.Name = "txtBalance";
            txtBalance.Size = new Size(125, 27);
            txtBalance.TabIndex = 5;
            // 
            // btnTemp
            // 
            btnTemp.Location = new Point(41, 233);
            btnTemp.Name = "btnTemp";
            btnTemp.Size = new Size(125, 38);
            btnTemp.TabIndex = 12;
            btnTemp.Text = "Temp";
            btnTemp.UseVisualStyleBackColor = true;
            btnTemp.Click += btnTemp_Click;
            // 
            // btnGetGeneration
            // 
            btnGetGeneration.Location = new Point(189, 235);
            btnGetGeneration.Name = "btnGetGeneration";
            btnGetGeneration.Size = new Size(272, 38);
            btnGetGeneration.TabIndex = 13;
            btnGetGeneration.Text = "Get Generation";
            btnGetGeneration.UseVisualStyleBackColor = true;
            btnGetGeneration.Click += btnGetGeneration_Click;
            // 
            // btnWithdraw
            // 
            btnWithdraw.Location = new Point(336, 296);
            btnWithdraw.Name = "btnWithdraw";
            btnWithdraw.Size = new Size(125, 38);
            btnWithdraw.TabIndex = 14;
            btnWithdraw.Text = "Withdraw";
            btnWithdraw.UseVisualStyleBackColor = true;
            btnWithdraw.Click += btnWithdraw_Click;
            // 
            // btnDeposite
            // 
            btnDeposite.Location = new Point(41, 296);
            btnDeposite.Name = "btnDeposite";
            btnDeposite.Size = new Size(125, 38);
            btnDeposite.TabIndex = 15;
            btnDeposite.Text = "Deposite";
            btnDeposite.UseVisualStyleBackColor = true;
            btnDeposite.Click += btnDeposite_Click;
            // 
            // txtAmount
            // 
            txtAmount.Location = new Point(189, 307);
            txtAmount.Name = "txtAmount";
            txtAmount.Size = new Size(125, 27);
            txtAmount.TabIndex = 16;
            txtAmount.TextChanged += txtAmount_TextChanged;
            // 
            // AccountForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(508, 383);
            Controls.Add(txtAmount);
            Controls.Add(btnDeposite);
            Controls.Add(btnWithdraw);
            Controls.Add(btnGetGeneration);
            Controls.Add(btnTemp);
            Controls.Add(txtBalance);
            Controls.Add(txtName);
            Controls.Add(txtId);
            Controls.Add(btnGC);
            Controls.Add(btnDestroy);
            Controls.Add(btnClear);
            Controls.Add(btnGet);
            Controls.Add(btnSet);
            Controls.Add(btnCreate);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AccountForm";
            Text = "Account Form";
            Load += AccountForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnCreate;
        private Button btnSet;
        private Button btnGet;
        private Button btnClear;
        private Button btnDestroy;
        private Button btnGC;
        private TextBox txtId;
        private TextBox txtName;
        private TextBox txtBalance;
        private Button btnTemp;
        private Button btnGetGeneration;
        private Button btnWithdraw;
        private Button btnDeposite;
        private TextBox txtAmount;
    }
}