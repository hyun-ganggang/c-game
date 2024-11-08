namespace Game
{
    partial class lbl_timer
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.btn_start = new System.Windows.Forms.Button();
            this.txtbox_input = new System.Windows.Forms.TextBox();
            this.lbl_lyrics = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_reset = new System.Windows.Forms.Button();
            this.lbl_title = new System.Windows.Forms.Label();
            this.lbl_time = new System.Windows.Forms.Label();
            this.lbl_result = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // btn_start
            // 
            this.btn_start.BackColor = System.Drawing.Color.White;
            this.btn_start.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_start.Location = new System.Drawing.Point(186, 480);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(120, 45);
            this.btn_start.TabIndex = 0;
            this.btn_start.Text = "start/Restart";
            this.btn_start.UseVisualStyleBackColor = false;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // txtbox_input
            // 
            this.txtbox_input.Font = new System.Drawing.Font("Yu Gothic", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtbox_input.Location = new System.Drawing.Point(72, 402);
            this.txtbox_input.Name = "txtbox_input";
            this.txtbox_input.Size = new System.Drawing.Size(591, 38);
            this.txtbox_input.TabIndex = 1;
            this.txtbox_input.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtbox_input_KeyDown_1);
            // 
            // lbl_lyrics
            // 
            this.lbl_lyrics.AutoSize = true;
            this.lbl_lyrics.Font = new System.Drawing.Font("Yu Gothic", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_lyrics.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_lyrics.Location = new System.Drawing.Point(79, 278);
            this.lbl_lyrics.Name = "lbl_lyrics";
            this.lbl_lyrics.Size = new System.Drawing.Size(0, 35);
            this.lbl_lyrics.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Game.Properties.Resources.APT;
            this.pictureBox1.Location = new System.Drawing.Point(322, 53);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(341, 345);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // btn_reset
            // 
            this.btn_reset.BackColor = System.Drawing.Color.White;
            this.btn_reset.Font = new System.Drawing.Font("Candara", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reset.Location = new System.Drawing.Point(454, 480);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(103, 45);
            this.btn_reset.TabIndex = 4;
            this.btn_reset.Text = "text reset";
            this.btn_reset.UseVisualStyleBackColor = false;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.Font = new System.Drawing.Font("Rockwell", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_title.Location = new System.Drawing.Point(77, 145);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(0, 46);
            this.lbl_title.TabIndex = 5;
            // 
            // lbl_time
            // 
            this.lbl_time.AutoSize = true;
            this.lbl_time.Font = new System.Drawing.Font("Yu Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_time.ForeColor = System.Drawing.SystemColors.Control;
            this.lbl_time.Location = new System.Drawing.Point(70, 60);
            this.lbl_time.Name = "lbl_time";
            this.lbl_time.Size = new System.Drawing.Size(0, 19);
            this.lbl_time.TabIndex = 6;
            // 
            // lbl_result
            // 
            this.lbl_result.AutoSize = true;
            this.lbl_result.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_result.ForeColor = System.Drawing.SystemColors.Window;
            this.lbl_result.Location = new System.Drawing.Point(713, 53);
            this.lbl_result.Name = "lbl_result";
            this.lbl_result.Size = new System.Drawing.Size(0, 22);
            this.lbl_result.TabIndex = 7;
            // 
            // lbl_timer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(897, 572);
            this.Controls.Add(this.lbl_result);
            this.Controls.Add(this.lbl_time);
            this.Controls.Add(this.lbl_title);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.lbl_lyrics);
            this.Controls.Add(this.txtbox_input);
            this.Controls.Add(this.btn_start);
            this.Controls.Add(this.pictureBox1);
            this.Name = "lbl_timer";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.TextBox txtbox_input;
        private System.Windows.Forms.Label lbl_lyrics;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Label lbl_time;
        private System.Windows.Forms.Label lbl_result;
    }
}

