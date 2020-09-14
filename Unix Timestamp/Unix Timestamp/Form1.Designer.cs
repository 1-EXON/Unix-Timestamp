namespace Unix_Timestamp
{
    partial class Unix_Timestamp
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Unix_Timestamp));
            this.unix = new Guna.UI.WinForms.GunaLabel();
            this.gunaLabel1 = new Guna.UI.WinForms.GunaLabel();
            this.gunaPanel1 = new Guna.UI.WinForms.GunaPanel();
            this.gunaPanel2 = new Guna.UI.WinForms.GunaPanel();
            this.gunaLabel2 = new Guna.UI.WinForms.GunaLabel();
            this.time = new Guna.UI.WinForms.GunaLabel();
            this.SuspendLayout();
            // 
            // unix
            // 
            this.unix.AutoSize = true;
            this.unix.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unix.Location = new System.Drawing.Point(16, 58);
            this.unix.Name = "unix";
            this.unix.Size = new System.Drawing.Size(122, 65);
            this.unix.TabIndex = 0;
            this.unix.Text = "time";
            // 
            // gunaLabel1
            // 
            this.gunaLabel1.AutoSize = true;
            this.gunaLabel1.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel1.Location = new System.Drawing.Point(28, 21);
            this.gunaLabel1.Name = "gunaLabel1";
            this.gunaLabel1.Size = new System.Drawing.Size(210, 37);
            this.gunaLabel1.TabIndex = 1;
            this.gunaLabel1.Text = "Unix TimeStamp";
            // 
            // gunaPanel1
            // 
            this.gunaPanel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaPanel1.Location = new System.Drawing.Point(32, 61);
            this.gunaPanel1.Name = "gunaPanel1";
            this.gunaPanel1.Size = new System.Drawing.Size(198, 3);
            this.gunaPanel1.TabIndex = 2;
            // 
            // gunaPanel2
            // 
            this.gunaPanel2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.gunaPanel2.Location = new System.Drawing.Point(32, 163);
            this.gunaPanel2.Name = "gunaPanel2";
            this.gunaPanel2.Size = new System.Drawing.Size(50, 3);
            this.gunaPanel2.TabIndex = 5;
            // 
            // gunaLabel2
            // 
            this.gunaLabel2.AutoSize = true;
            this.gunaLabel2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gunaLabel2.Location = new System.Drawing.Point(31, 139);
            this.gunaLabel2.Name = "gunaLabel2";
            this.gunaLabel2.Size = new System.Drawing.Size(44, 21);
            this.gunaLabel2.TabIndex = 4;
            this.gunaLabel2.Text = "Time";
            // 
            // time
            // 
            this.time.AutoSize = true;
            this.time.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.time.Location = new System.Drawing.Point(26, 163);
            this.time.Name = "time";
            this.time.Size = new System.Drawing.Size(54, 30);
            this.time.TabIndex = 3;
            this.time.Text = "time";
            // 
            // Unix_Timestamp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 350);
            this.Controls.Add(this.gunaPanel2);
            this.Controls.Add(this.gunaLabel2);
            this.Controls.Add(this.time);
            this.Controls.Add(this.gunaPanel1);
            this.Controls.Add(this.gunaLabel1);
            this.Controls.Add(this.unix);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Unix_Timestamp";
            this.Text = "Unix Timestamp";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaLabel unix;
        private Guna.UI.WinForms.GunaLabel gunaLabel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel1;
        private Guna.UI.WinForms.GunaPanel gunaPanel2;
        private Guna.UI.WinForms.GunaLabel gunaLabel2;
        private Guna.UI.WinForms.GunaLabel time;
    }
}

