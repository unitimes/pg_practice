namespace StudyHelper
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.lb_title = new System.Windows.Forms.Label();
            this.btn_cfrm = new System.Windows.Forms.Button();
            this.btn_rst = new System.Windows.Forms.Button();
            this.lb_timer = new System.Windows.Forms.Label();
            this.gb_fn = new System.Windows.Forms.GroupBox();
            this.tBox_entTime = new System.Windows.Forms.TextBox();
            this.rBtn_timer = new System.Windows.Forms.RadioButton();
            this.rBtn_stopWatch = new System.Windows.Forms.RadioButton();
            this.rBtn_watch = new System.Windows.Forms.RadioButton();
            this.gb_fn.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_title
            // 
            this.lb_title.AutoSize = true;
            this.lb_title.ForeColor = System.Drawing.Color.Black;
            this.lb_title.Location = new System.Drawing.Point(12, 9);
            this.lb_title.Name = "lb_title";
            this.lb_title.Size = new System.Drawing.Size(65, 12);
            this.lb_title.TabIndex = 0;
            this.lb_title.Text = "공부도우미";
            // 
            // btn_cfrm
            // 
            this.btn_cfrm.Location = new System.Drawing.Point(12, 35);
            this.btn_cfrm.Name = "btn_cfrm";
            this.btn_cfrm.Size = new System.Drawing.Size(115, 23);
            this.btn_cfrm.TabIndex = 1;
            this.btn_cfrm.Text = "확인";
            this.btn_cfrm.UseVisualStyleBackColor = true;
            this.btn_cfrm.Click += new System.EventHandler(this.btn_cfrm_Click);
            // 
            // btn_rst
            // 
            this.btn_rst.Location = new System.Drawing.Point(139, 35);
            this.btn_rst.Name = "btn_rst";
            this.btn_rst.Size = new System.Drawing.Size(115, 23);
            this.btn_rst.TabIndex = 1;
            this.btn_rst.Text = "리셋";
            this.btn_rst.UseVisualStyleBackColor = true;
            this.btn_rst.Click += new System.EventHandler(this.btn_rst_Click);
            // 
            // lb_timer
            // 
            this.lb_timer.Font = new System.Drawing.Font("나눔고딕코딩", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lb_timer.ForeColor = System.Drawing.Color.Black;
            this.lb_timer.Location = new System.Drawing.Point(4, 81);
            this.lb_timer.Name = "lb_timer";
            this.lb_timer.Size = new System.Drawing.Size(250, 50);
            this.lb_timer.TabIndex = 2;
            this.lb_timer.Text = "00:00:00";
            this.lb_timer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gb_fn
            // 
            this.gb_fn.Controls.Add(this.tBox_entTime);
            this.gb_fn.Controls.Add(this.rBtn_timer);
            this.gb_fn.Controls.Add(this.rBtn_stopWatch);
            this.gb_fn.Controls.Add(this.rBtn_watch);
            this.gb_fn.Location = new System.Drawing.Point(271, 35);
            this.gb_fn.Name = "gb_fn";
            this.gb_fn.Size = new System.Drawing.Size(170, 119);
            this.gb_fn.TabIndex = 3;
            this.gb_fn.TabStop = false;
            this.gb_fn.Text = "기능";
            // 
            // tBox_entTime
            // 
            this.tBox_entTime.Location = new System.Drawing.Point(7, 85);
            this.tBox_entTime.Name = "tBox_entTime";
            this.tBox_entTime.Size = new System.Drawing.Size(134, 19);
            this.tBox_entTime.TabIndex = 1;
            // 
            // rBtn_timer
            // 
            this.rBtn_timer.AutoSize = true;
            this.rBtn_timer.Location = new System.Drawing.Point(6, 62);
            this.rBtn_timer.Name = "rBtn_timer";
            this.rBtn_timer.Size = new System.Drawing.Size(59, 16);
            this.rBtn_timer.TabIndex = 0;
            this.rBtn_timer.Text = "타이머";
            this.rBtn_timer.UseVisualStyleBackColor = true;
            this.rBtn_timer.CheckedChanged += new System.EventHandler(this.rBtn_timer_CheckedChanged);
            // 
            // rBtn_stopWatch
            // 
            this.rBtn_stopWatch.AutoSize = true;
            this.rBtn_stopWatch.Location = new System.Drawing.Point(6, 40);
            this.rBtn_stopWatch.Name = "rBtn_stopWatch";
            this.rBtn_stopWatch.Size = new System.Drawing.Size(71, 16);
            this.rBtn_stopWatch.TabIndex = 0;
            this.rBtn_stopWatch.Text = "스톱워치";
            this.rBtn_stopWatch.UseVisualStyleBackColor = true;
            this.rBtn_stopWatch.CheckedChanged += new System.EventHandler(this.rBtn_stopWatch_CheckedChanged);
            // 
            // rBtn_watch
            // 
            this.rBtn_watch.AutoSize = true;
            this.rBtn_watch.Checked = true;
            this.rBtn_watch.Location = new System.Drawing.Point(6, 18);
            this.rBtn_watch.Name = "rBtn_watch";
            this.rBtn_watch.Size = new System.Drawing.Size(47, 16);
            this.rBtn_watch.TabIndex = 0;
            this.rBtn_watch.TabStop = true;
            this.rBtn_watch.Text = "시계";
            this.rBtn_watch.UseVisualStyleBackColor = true;
            this.rBtn_watch.CheckedChanged += new System.EventHandler(this.rBtn_watch_CheckedChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(461, 171);
            this.Controls.Add(this.gb_fn);
            this.Controls.Add(this.lb_timer);
            this.Controls.Add(this.btn_rst);
            this.Controls.Add(this.btn_cfrm);
            this.Controls.Add(this.lb_title);
            this.Font = new System.Drawing.Font("나눔고딕코딩", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.Name = "Form1";
            this.Text = "공부도우미";
            this.gb_fn.ResumeLayout(false);
            this.gb_fn.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lb_title;
        private System.Windows.Forms.Button btn_cfrm;
        private System.Windows.Forms.Button btn_rst;
        private System.Windows.Forms.Label lb_timer;
        private System.Windows.Forms.GroupBox gb_fn;
        private System.Windows.Forms.TextBox tBox_entTime;
        private System.Windows.Forms.RadioButton rBtn_timer;
        private System.Windows.Forms.RadioButton rBtn_stopWatch;
        private System.Windows.Forms.RadioButton rBtn_watch;
    }
}

