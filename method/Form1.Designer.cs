namespace method
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.tBoxResult = new System.Windows.Forms.TextBox();
            this.tboxNumber1 = new System.Windows.Forms.TextBox();
            this.tboxNumber2 = new System.Windows.Forms.TextBox();
            this.btnMulti = new System.Windows.Forms.Button();
            this.btnDivision = new System.Windows.Forms.Button();
            this.btnPlus = new System.Windows.Forms.Button();
            this.btnMinus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tBoxResult
            // 
            this.tBoxResult.Enabled = false;
            this.tBoxResult.Location = new System.Drawing.Point(55, 32);
            this.tBoxResult.Name = "tBoxResult";
            this.tBoxResult.Size = new System.Drawing.Size(406, 28);
            this.tBoxResult.TabIndex = 0;
            this.tBoxResult.Text = "0";
            // 
            // tboxNumber1
            // 
            this.tboxNumber1.Location = new System.Drawing.Point(55, 75);
            this.tboxNumber1.Name = "tboxNumber1";
            this.tboxNumber1.Size = new System.Drawing.Size(192, 28);
            this.tboxNumber1.TabIndex = 1;
            this.tboxNumber1.Text = "0";
            // 
            // tboxNumber2
            // 
            this.tboxNumber2.Location = new System.Drawing.Point(269, 75);
            this.tboxNumber2.Name = "tboxNumber2";
            this.tboxNumber2.Size = new System.Drawing.Size(190, 28);
            this.tboxNumber2.TabIndex = 2;
            this.tboxNumber2.Text = "0";
            // 
            // btnMulti
            // 
            this.btnMulti.Location = new System.Drawing.Point(269, 113);
            this.btnMulti.Name = "btnMulti";
            this.btnMulti.Size = new System.Drawing.Size(84, 78);
            this.btnMulti.TabIndex = 5;
            this.btnMulti.Text = "*";
            this.btnMulti.UseVisualStyleBackColor = true;
            this.btnMulti.Click += new System.EventHandler(this.btnMulti_Click);
            // 
            // btnDivision
            // 
            this.btnDivision.Location = new System.Drawing.Point(377, 113);
            this.btnDivision.Name = "btnDivision";
            this.btnDivision.Size = new System.Drawing.Size(84, 78);
            this.btnDivision.TabIndex = 6;
            this.btnDivision.Text = "=";
            this.btnDivision.UseVisualStyleBackColor = true;
            this.btnDivision.Click += new System.EventHandler(this.btnDivision_Click);
            // 
            // btnPlus
            // 
            this.btnPlus.Location = new System.Drawing.Point(55, 113);
            this.btnPlus.Name = "btnPlus";
            this.btnPlus.Size = new System.Drawing.Size(84, 78);
            this.btnPlus.TabIndex = 8;
            this.btnPlus.Text = "+";
            this.btnPlus.UseVisualStyleBackColor = true;
            this.btnPlus.Click += new System.EventHandler(this.btnPlus_Click);
            // 
            // btnMinus
            // 
            this.btnMinus.Location = new System.Drawing.Point(163, 113);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(84, 78);
            this.btnMinus.TabIndex = 9;
            this.btnMinus.Text = "-";
            this.btnMinus.UseVisualStyleBackColor = true;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 260);
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.btnPlus);
            this.Controls.Add(this.btnDivision);
            this.Controls.Add(this.btnMulti);
            this.Controls.Add(this.tboxNumber2);
            this.Controls.Add(this.tboxNumber1);
            this.Controls.Add(this.tBoxResult);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tBoxResult;
        private System.Windows.Forms.TextBox tboxNumber1;
        private System.Windows.Forms.TextBox tboxNumber2;
        private System.Windows.Forms.Button btnMulti;
        private System.Windows.Forms.Button btnDivision;
        private System.Windows.Forms.Button btnPlus;
        private System.Windows.Forms.Button btnMinus;
    }
}

