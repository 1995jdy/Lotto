namespace FinalTest
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
            this.button1 = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.num4 = new System.Windows.Forms.Label();
            this.num5 = new System.Windows.Forms.Label();
            this.num6 = new System.Windows.Forms.Label();
            this.num7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(126, 144);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "추첨";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // num1
            // 
            this.num1.AutoSize = true;
            this.num1.Location = new System.Drawing.Point(32, 84);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(29, 12);
            this.num1.TabIndex = 2;
            this.num1.Text = "____";
            // 
            // num2
            // 
            this.num2.AutoSize = true;
            this.num2.Location = new System.Drawing.Point(67, 84);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(29, 12);
            this.num2.TabIndex = 2;
            this.num2.Text = "____";
            // 
            // num3
            // 
            this.num3.AutoSize = true;
            this.num3.Location = new System.Drawing.Point(102, 84);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(29, 12);
            this.num3.TabIndex = 2;
            this.num3.Text = "____";
            // 
            // num4
            // 
            this.num4.AutoSize = true;
            this.num4.Location = new System.Drawing.Point(137, 84);
            this.num4.Name = "num4";
            this.num4.Size = new System.Drawing.Size(29, 12);
            this.num4.TabIndex = 2;
            this.num4.Text = "____";
            // 
            // num5
            // 
            this.num5.AutoSize = true;
            this.num5.Location = new System.Drawing.Point(172, 84);
            this.num5.Name = "num5";
            this.num5.Size = new System.Drawing.Size(29, 12);
            this.num5.TabIndex = 2;
            this.num5.Text = "____";
            // 
            // num6
            // 
            this.num6.AutoSize = true;
            this.num6.Location = new System.Drawing.Point(207, 84);
            this.num6.Name = "num6";
            this.num6.Size = new System.Drawing.Size(29, 12);
            this.num6.TabIndex = 2;
            this.num6.Text = "____";
            // 
            // num7
            // 
            this.num7.AutoSize = true;
            this.num7.Location = new System.Drawing.Point(273, 84);
            this.num7.Name = "num7";
            this.num7.Size = new System.Drawing.Size(29, 12);
            this.num7.TabIndex = 2;
            this.num7.Text = "____";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("휴먼둥근헤드라인", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "로또 번호 추첨기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "  +  ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 177);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.num7);
            this.Controls.Add(this.num6);
            this.Controls.Add(this.num5);
            this.Controls.Add(this.num4);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num3;
        private System.Windows.Forms.Label num4;
        private System.Windows.Forms.Label num5;
        private System.Windows.Forms.Label num6;
        private System.Windows.Forms.Label num7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

