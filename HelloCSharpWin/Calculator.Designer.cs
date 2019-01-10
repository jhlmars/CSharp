namespace HelloCSharpWin
{
    partial class Calculator
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
            this.NumBtn1 = new System.Windows.Forms.Button();
            this.NumScreen = new System.Windows.Forms.Label();
            this.NumBtn2 = new System.Windows.Forms.Button();
            this.NumPlus = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumBtn1
            // 
            this.NumBtn1.Location = new System.Drawing.Point(37, 172);
            this.NumBtn1.Name = "NumBtn1";
            this.NumBtn1.Size = new System.Drawing.Size(70, 65);
            this.NumBtn1.TabIndex = 0;
            this.NumBtn1.Text = "1";
            this.NumBtn1.UseVisualStyleBackColor = true;
            this.NumBtn1.Click += new System.EventHandler(this.NumBtn1_Click);
            // 
            // NumScreen
            // 
            this.NumScreen.BackColor = System.Drawing.Color.White;
            this.NumScreen.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NumScreen.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumScreen.Location = new System.Drawing.Point(28, 21);
            this.NumScreen.Name = "NumScreen";
            this.NumScreen.Size = new System.Drawing.Size(697, 121);
            this.NumScreen.TabIndex = 1;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumBtn2
            // 
            this.NumBtn2.Location = new System.Drawing.Point(140, 172);
            this.NumBtn2.Name = "NumBtn2";
            this.NumBtn2.Size = new System.Drawing.Size(70, 65);
            this.NumBtn2.TabIndex = 2;
            this.NumBtn2.Text = "2";
            this.NumBtn2.UseVisualStyleBackColor = true;
            this.NumBtn2.Click += new System.EventHandler(this.NumBtn2_Click);
            // 
            // NumPlus
            // 
            this.NumPlus.Font = new System.Drawing.Font("나눔고딕", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumPlus.Location = new System.Drawing.Point(612, 172);
            this.NumPlus.Name = "NumPlus";
            this.NumPlus.Size = new System.Drawing.Size(70, 65);
            this.NumPlus.TabIndex = 3;
            this.NumPlus.Text = "+";
            this.NumPlus.UseVisualStyleBackColor = true;
            this.NumPlus.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 602);
            this.Controls.Add(this.NumPlus);
            this.Controls.Add(this.NumBtn2);
            this.Controls.Add(this.NumScreen);
            this.Controls.Add(this.NumBtn1);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button NumBtn1;
        private System.Windows.Forms.Label NumScreen;
        private System.Windows.Forms.Button NumBtn2;
        private System.Windows.Forms.Button NumPlus;
    }
}

