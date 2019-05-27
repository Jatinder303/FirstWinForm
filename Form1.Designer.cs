namespace FirstWinForm
{
    partial class Form_Calculator
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
            this.lbl_FirstNumber = new System.Windows.Forms.Label();
            this.lbl_SecondNumber = new System.Windows.Forms.Label();
            this.lbl_Result = new System.Windows.Forms.Label();
            this.txt_FirstNumber = new System.Windows.Forms.TextBox();
            this.txt_SecondNumber = new System.Windows.Forms.TextBox();
            this.txtResult = new System.Windows.Forms.TextBox();
            this.btn_Add = new System.Windows.Forms.Button();
            this.btn_Sub = new System.Windows.Forms.Button();
            this.btn_Mul = new System.Windows.Forms.Button();
            this.btn_Div = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbl_FirstNumber
            // 
            this.lbl_FirstNumber.AutoSize = true;
            this.lbl_FirstNumber.Location = new System.Drawing.Point(207, 75);
            this.lbl_FirstNumber.Name = "lbl_FirstNumber";
            this.lbl_FirstNumber.Size = new System.Drawing.Size(66, 13);
            this.lbl_FirstNumber.TabIndex = 0;
            this.lbl_FirstNumber.Text = "First Number";
            // 
            // lbl_SecondNumber
            // 
            this.lbl_SecondNumber.AutoSize = true;
            this.lbl_SecondNumber.Location = new System.Drawing.Point(210, 108);
            this.lbl_SecondNumber.Name = "lbl_SecondNumber";
            this.lbl_SecondNumber.Size = new System.Drawing.Size(84, 13);
            this.lbl_SecondNumber.TabIndex = 1;
            this.lbl_SecondNumber.Text = "Second Number";
            // 
            // lbl_Result
            // 
            this.lbl_Result.AutoSize = true;
            this.lbl_Result.Location = new System.Drawing.Point(213, 147);
            this.lbl_Result.Name = "lbl_Result";
            this.lbl_Result.Size = new System.Drawing.Size(37, 13);
            this.lbl_Result.TabIndex = 2;
            this.lbl_Result.Text = "Result";
            // 
            // txt_FirstNumber
            // 
            this.txt_FirstNumber.Location = new System.Drawing.Point(404, 75);
            this.txt_FirstNumber.Name = "txt_FirstNumber";
            this.txt_FirstNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_FirstNumber.TabIndex = 3;
            // 
            // txt_SecondNumber
            // 
            this.txt_SecondNumber.Location = new System.Drawing.Point(404, 108);
            this.txt_SecondNumber.Name = "txt_SecondNumber";
            this.txt_SecondNumber.Size = new System.Drawing.Size(100, 20);
            this.txt_SecondNumber.TabIndex = 4;
            // 
            // txtResult
            // 
            this.txtResult.Location = new System.Drawing.Point(404, 147);
            this.txtResult.Name = "txtResult";
            this.txtResult.Size = new System.Drawing.Size(100, 20);
            this.txtResult.TabIndex = 5;
            // 
            // btn_Add
            // 
            this.btn_Add.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Add.Location = new System.Drawing.Point(119, 236);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(75, 23);
            this.btn_Add.TabIndex = 6;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = false;
            this.btn_Add.Click += new System.EventHandler(this.Btn_Add_Click);
            // 
            // btn_Sub
            // 
            this.btn_Sub.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btn_Sub.Location = new System.Drawing.Point(234, 236);
            this.btn_Sub.Name = "btn_Sub";
            this.btn_Sub.Size = new System.Drawing.Size(75, 23);
            this.btn_Sub.TabIndex = 7;
            this.btn_Sub.Text = "Sub";
            this.btn_Sub.UseVisualStyleBackColor = false;
            this.btn_Sub.Click += new System.EventHandler(this.Btn_Sub_Click);
            // 
            // btn_Mul
            // 
            this.btn_Mul.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btn_Mul.Location = new System.Drawing.Point(360, 236);
            this.btn_Mul.Name = "btn_Mul";
            this.btn_Mul.Size = new System.Drawing.Size(75, 23);
            this.btn_Mul.TabIndex = 8;
            this.btn_Mul.Text = "Multiple";
            this.btn_Mul.UseVisualStyleBackColor = false;
            this.btn_Mul.Click += new System.EventHandler(this.Btn_Mul_Click);
            // 
            // btn_Div
            // 
            this.btn_Div.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_Div.Location = new System.Drawing.Point(473, 236);
            this.btn_Div.Name = "btn_Div";
            this.btn_Div.Size = new System.Drawing.Size(75, 23);
            this.btn_Div.TabIndex = 9;
            this.btn_Div.Text = "Div";
            this.btn_Div.UseVisualStyleBackColor = false;
            this.btn_Div.Click += new System.EventHandler(this.Btn_Div_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(599, 236);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(75, 23);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.Btn_Clear_Click);
            // 
            // Form_Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Beige;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Div);
            this.Controls.Add(this.btn_Mul);
            this.Controls.Add(this.btn_Sub);
            this.Controls.Add(this.btn_Add);
            this.Controls.Add(this.txtResult);
            this.Controls.Add(this.txt_SecondNumber);
            this.Controls.Add(this.txt_FirstNumber);
            this.Controls.Add(this.lbl_Result);
            this.Controls.Add(this.lbl_SecondNumber);
            this.Controls.Add(this.lbl_FirstNumber);
            this.Name = "Form_Calculator";
            this.Text = "Calculator Form";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_FirstNumber;
        private System.Windows.Forms.Label lbl_SecondNumber;
        private System.Windows.Forms.Label lbl_Result;
        private System.Windows.Forms.TextBox txt_FirstNumber;
        private System.Windows.Forms.TextBox txt_SecondNumber;
        private System.Windows.Forms.TextBox txtResult;
        private System.Windows.Forms.Button btn_Add;
        private System.Windows.Forms.Button btn_Sub;
        private System.Windows.Forms.Button btn_Mul;
        private System.Windows.Forms.Button btn_Div;
        private System.Windows.Forms.Button btn_Clear;
    }
}

