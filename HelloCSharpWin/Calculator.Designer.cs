﻿namespace HelloCSharpWin
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
            this.NumBtn3 = new System.Windows.Forms.Button();
            this.NumBtn4 = new System.Windows.Forms.Button();
            this.NumBtn5 = new System.Windows.Forms.Button();
            this.NumBtn6 = new System.Windows.Forms.Button();
            this.NumBtn9 = new System.Windows.Forms.Button();
            this.NumBtn8 = new System.Windows.Forms.Button();
            this.NumBtn7 = new System.Windows.Forms.Button();
            this.NumBtn0 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NumBtn1
            // 
            this.NumBtn1.Location = new System.Drawing.Point(66, 366);
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
            this.NumScreen.Size = new System.Drawing.Size(470, 121);
            this.NumScreen.TabIndex = 1;
            this.NumScreen.Text = "0";
            this.NumScreen.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // NumBtn2
            // 
            this.NumBtn2.Location = new System.Drawing.Point(169, 366);
            this.NumBtn2.Name = "NumBtn2";
            this.NumBtn2.Size = new System.Drawing.Size(70, 65);
            this.NumBtn2.TabIndex = 2;
            this.NumBtn2.Text = "2";
            this.NumBtn2.UseVisualStyleBackColor = true;
            this.NumBtn2.Click += new System.EventHandler(this.NumBtn1_Click);
            // 
            // NumPlus
            // 
            this.NumPlus.Font = new System.Drawing.Font("나눔고딕", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.NumPlus.Location = new System.Drawing.Point(397, 366);
            this.NumPlus.Name = "NumPlus";
            this.NumPlus.Size = new System.Drawing.Size(70, 65);
            this.NumPlus.TabIndex = 3;
            this.NumPlus.Text = "+";
            this.NumPlus.UseVisualStyleBackColor = true;
            this.NumPlus.Click += new System.EventHandler(this.NumPlus_Click);
            // 
            // NumBtn3
            // 
            this.NumBtn3.Location = new System.Drawing.Point(266, 366);
            this.NumBtn3.Name = "NumBtn3";
            this.NumBtn3.Size = new System.Drawing.Size(70, 65);
            this.NumBtn3.TabIndex = 4;
            this.NumBtn3.Text = "3";
            this.NumBtn3.UseVisualStyleBackColor = true;
            this.NumBtn3.Click += new System.EventHandler(this.NumBtn1_Click);
            // 
            // NumBtn4
            // 
            this.NumBtn4.Location = new System.Drawing.Point(66, 276);
            this.NumBtn4.Name = "NumBtn4";
            this.NumBtn4.Size = new System.Drawing.Size(70, 65);
            this.NumBtn4.TabIndex = 5;
            this.NumBtn4.Text = "4";
            this.NumBtn4.UseVisualStyleBackColor = true;
            this.NumBtn4.Click += new System.EventHandler(this.NumBtn1_Click);
            // 
            // NumBtn5
            // 
            this.NumBtn5.Location = new System.Drawing.Point(169, 276);
            this.NumBtn5.Name = "NumBtn5";
            this.NumBtn5.Size = new System.Drawing.Size(70, 65);
            this.NumBtn5.TabIndex = 6;
            this.NumBtn5.Text = "5";
            this.NumBtn5.UseVisualStyleBackColor = true;
            this.NumBtn5.Click += new System.EventHandler(this.NumBtn1_Click);
            // 
            // NumBtn6
            // 
            this.NumBtn6.Location = new System.Drawing.Point(266, 276);
            this.NumBtn6.Name = "NumBtn6";
            this.NumBtn6.Size = new System.Drawing.Size(70, 65);
            this.NumBtn6.TabIndex = 7;
            this.NumBtn6.Text = "6";
            this.NumBtn6.UseVisualStyleBackColor = true;
            this.NumBtn6.Click += new System.EventHandler(this.NumBtn1_Click);
            // 
            // NumBtn9
            // 
            this.NumBtn9.Location = new System.Drawing.Point(266, 181);
            this.NumBtn9.Name = "NumBtn9";
            this.NumBtn9.Size = new System.Drawing.Size(70, 65);
            this.NumBtn9.TabIndex = 10;
            this.NumBtn9.Text = "9";
            this.NumBtn9.UseVisualStyleBackColor = true;
            this.NumBtn9.Click += new System.EventHandler(this.NumBtn1_Click);
            // 
            // NumBtn8
            // 
            this.NumBtn8.Location = new System.Drawing.Point(169, 181);
            this.NumBtn8.Name = "NumBtn8";
            this.NumBtn8.Size = new System.Drawing.Size(70, 65);
            this.NumBtn8.TabIndex = 9;
            this.NumBtn8.Text = "8";
            this.NumBtn8.UseVisualStyleBackColor = true;
            this.NumBtn8.Click += new System.EventHandler(this.NumBtn1_Click);
            // 
            // NumBtn7
            // 
            this.NumBtn7.Location = new System.Drawing.Point(66, 181);
            this.NumBtn7.Name = "NumBtn7";
            this.NumBtn7.Size = new System.Drawing.Size(70, 65);
            this.NumBtn7.TabIndex = 8;
            this.NumBtn7.Text = "7";
            this.NumBtn7.UseVisualStyleBackColor = true;
            this.NumBtn7.Click += new System.EventHandler(this.NumBtn1_Click);
            // 
            // NumBtn0
            // 
            this.NumBtn0.Location = new System.Drawing.Point(169, 458);
            this.NumBtn0.Name = "NumBtn0";
            this.NumBtn0.Size = new System.Drawing.Size(70, 65);
            this.NumBtn0.TabIndex = 11;
            this.NumBtn0.Text = "0";
            this.NumBtn0.UseVisualStyleBackColor = true;
            this.NumBtn0.Click += new System.EventHandler(this.NumBtn1_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(747, 602);
            this.Controls.Add(this.NumBtn0);
            this.Controls.Add(this.NumBtn9);
            this.Controls.Add(this.NumBtn8);
            this.Controls.Add(this.NumBtn7);
            this.Controls.Add(this.NumBtn6);
            this.Controls.Add(this.NumBtn5);
            this.Controls.Add(this.NumBtn4);
            this.Controls.Add(this.NumBtn3);
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
        private System.Windows.Forms.Button NumBtn3;
        private System.Windows.Forms.Button NumBtn4;
        private System.Windows.Forms.Button NumBtn5;
        private System.Windows.Forms.Button NumBtn6;
        private System.Windows.Forms.Button NumBtn9;
        private System.Windows.Forms.Button NumBtn8;
        private System.Windows.Forms.Button NumBtn7;
        private System.Windows.Forms.Button NumBtn0;
    }
}

