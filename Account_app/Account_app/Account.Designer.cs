namespace Account_app
{
    partial class Account
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
            idTxt = new Label();
            nameTxt = new Label();
            accTxt = new Label();
            create_btn = new Button();
            set_btn = new Button();
            get_btn = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            clear_btn = new Button();
            destroy_btn = new Button();
            gc_btn = new Button();
            SuspendLayout();
            // 
            // idTxt
            // 
            idTxt.AutoSize = true;
            idTxt.Location = new Point(121, 43);
            idTxt.Name = "idTxt";
            idTxt.Size = new Size(22, 20);
            idTxt.TabIndex = 0;
            idTxt.Text = "Id";
            idTxt.Click += idTxt_Click;
            // 
            // nameTxt
            // 
            nameTxt.AutoSize = true;
            nameTxt.Location = new Point(251, 43);
            nameTxt.Name = "nameTxt";
            nameTxt.Size = new Size(49, 20);
            nameTxt.TabIndex = 1;
            nameTxt.Text = "Name";
            nameTxt.Click += nameTxt_Click;
            // 
            // accTxt
            // 
            accTxt.AutoSize = true;
            accTxt.Location = new Point(382, 43);
            accTxt.Name = "accTxt";
            accTxt.Size = new Size(57, 20);
            accTxt.TabIndex = 2;
            accTxt.Text = "Acc No";
            accTxt.Click += label3_Click;
            // 
            // create_btn
            // 
            create_btn.Location = new Point(97, 108);
            create_btn.Name = "create_btn";
            create_btn.Size = new Size(94, 29);
            create_btn.TabIndex = 3;
            create_btn.Text = "Create";
            create_btn.UseVisualStyleBackColor = true;
            create_btn.Click += create_btn_Click;
            // 
            // set_btn
            // 
            set_btn.Location = new Point(238, 108);
            set_btn.Name = "set_btn";
            set_btn.Size = new Size(94, 29);
            set_btn.TabIndex = 4;
            set_btn.Text = "Set";
            set_btn.UseVisualStyleBackColor = true;
            set_btn.Click += set_btn_Click;
            // 
            // get_btn
            // 
            get_btn.Location = new Point(370, 108);
            get_btn.Name = "get_btn";
            get_btn.Size = new Size(94, 29);
            get_btn.TabIndex = 5;
            get_btn.Text = "Get";
            get_btn.UseVisualStyleBackColor = true;
            get_btn.Click += get_btn_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(80, 66);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(125, 27);
            textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(223, 66);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(125, 27);
            textBox2.TabIndex = 7;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(361, 66);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 27);
            textBox3.TabIndex = 8;
            // 
            // clear_btn
            // 
            clear_btn.Location = new Point(97, 159);
            clear_btn.Name = "clear_btn";
            clear_btn.Size = new Size(94, 29);
            clear_btn.TabIndex = 9;
            clear_btn.Text = "Clear";
            clear_btn.UseVisualStyleBackColor = true;
            clear_btn.Click += clear_btn_Click;
            // 
            // destroy_btn
            // 
            destroy_btn.Location = new Point(238, 159);
            destroy_btn.Name = "destroy_btn";
            destroy_btn.Size = new Size(94, 29);
            destroy_btn.TabIndex = 10;
            destroy_btn.Text = "Destroy";
            destroy_btn.UseVisualStyleBackColor = true;
            destroy_btn.Click += destroy_btn_Click;
            // 
            // gc_btn
            // 
            gc_btn.Location = new Point(370, 159);
            gc_btn.Name = "gc_btn";
            gc_btn.Size = new Size(94, 29);
            gc_btn.TabIndex = 11;
            gc_btn.Text = "GC";
            gc_btn.UseVisualStyleBackColor = true;
            gc_btn.Click += gc_btn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(gc_btn);
            Controls.Add(destroy_btn);
            Controls.Add(clear_btn);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(get_btn);
            Controls.Add(set_btn);
            Controls.Add(create_btn);
            Controls.Add(accTxt);
            Controls.Add(nameTxt);
            Controls.Add(idTxt);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label idTxt;
        private Label nameTxt;
        private Label accTxt;
        private Button create_btn;
        private Button set_btn;
        private Button get_btn;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Button clear_btn;
        private Button destroy_btn;
        private Button gc_btn;
    }
}