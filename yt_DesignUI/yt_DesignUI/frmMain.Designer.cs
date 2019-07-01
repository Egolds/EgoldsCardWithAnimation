namespace yt_DesignUI
{
    partial class frmMain
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.egoldsCard1 = new yt_DesignUI.EgoldsCard();
            this.yt_Button1 = new yt_DesignUI.yt_Button();
            this.egoldsCard2 = new yt_DesignUI.EgoldsCard();
            this.egoldsCard3 = new yt_DesignUI.EgoldsCard();
            this.SuspendLayout();
            // 
            // egoldsCard1
            // 
            this.egoldsCard1.BackColor = System.Drawing.Color.White;
            this.egoldsCard1.BackColorCurtain = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.egoldsCard1.Font = new System.Drawing.Font("Verdana", 9F);
            this.egoldsCard1.FontDescrition = new System.Drawing.Font("Verdana", 8.25F);
            this.egoldsCard1.FontHeader = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.egoldsCard1.ForeColorDescrition = System.Drawing.Color.Black;
            this.egoldsCard1.ForeColorHeader = System.Drawing.Color.White;
            this.egoldsCard1.Location = new System.Drawing.Point(12, 12);
            this.egoldsCard1.Name = "egoldsCard1";
            this.egoldsCard1.Size = new System.Drawing.Size(250, 200);
            this.egoldsCard1.TabIndex = 1;
            this.egoldsCard1.Text = "egoldsCard1";
            this.egoldsCard1.TextDescrition = "Your description text for this control";
            this.egoldsCard1.TextHeader = "Header";
            // 
            // yt_Button1
            // 
            this.yt_Button1.BackColor = System.Drawing.Color.Tomato;
            this.yt_Button1.ForeColor = System.Drawing.Color.White;
            this.yt_Button1.Location = new System.Drawing.Point(12, 218);
            this.yt_Button1.Name = "yt_Button1";
            this.yt_Button1.Size = new System.Drawing.Size(157, 43);
            this.yt_Button1.TabIndex = 0;
            this.yt_Button1.Text = "yt_Button1";
            this.yt_Button1.Click += new System.EventHandler(this.yt_Button1_Click);
            // 
            // egoldsCard2
            // 
            this.egoldsCard2.BackColor = System.Drawing.Color.White;
            this.egoldsCard2.BackColorCurtain = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.egoldsCard2.Font = new System.Drawing.Font("Verdana", 9F);
            this.egoldsCard2.FontDescrition = new System.Drawing.Font("Verdana", 8.25F);
            this.egoldsCard2.FontHeader = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.egoldsCard2.ForeColorDescrition = System.Drawing.Color.Black;
            this.egoldsCard2.ForeColorHeader = System.Drawing.Color.White;
            this.egoldsCard2.Location = new System.Drawing.Point(268, 12);
            this.egoldsCard2.Name = "egoldsCard2";
            this.egoldsCard2.Size = new System.Drawing.Size(250, 383);
            this.egoldsCard2.TabIndex = 2;
            this.egoldsCard2.Text = "egoldsCard2";
            this.egoldsCard2.TextDescrition = "Your description text for this control";
            this.egoldsCard2.TextHeader = "Header";
            // 
            // egoldsCard3
            // 
            this.egoldsCard3.BackColor = System.Drawing.Color.White;
            this.egoldsCard3.BackColorCurtain = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(76)))), ((int)(((byte)(60)))));
            this.egoldsCard3.Font = new System.Drawing.Font("Verdana", 9F);
            this.egoldsCard3.FontDescrition = new System.Drawing.Font("Verdana", 8.25F);
            this.egoldsCard3.FontHeader = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold);
            this.egoldsCard3.ForeColorDescrition = System.Drawing.Color.Black;
            this.egoldsCard3.ForeColorHeader = System.Drawing.Color.White;
            this.egoldsCard3.Location = new System.Drawing.Point(524, 12);
            this.egoldsCard3.Name = "egoldsCard3";
            this.egoldsCard3.Size = new System.Drawing.Size(250, 383);
            this.egoldsCard3.TabIndex = 3;
            this.egoldsCard3.Text = "egoldsCard3";
            this.egoldsCard3.TextDescrition = "Your description text for this control";
            this.egoldsCard3.TextHeader = "Header";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(794, 407);
            this.Controls.Add(this.egoldsCard3);
            this.Controls.Add(this.egoldsCard2);
            this.Controls.Add(this.egoldsCard1);
            this.Controls.Add(this.yt_Button1);
            this.Name = "frmMain";
            this.Text = "Главная форма";
            this.ResumeLayout(false);

        }

        #endregion

        private yt_Button yt_Button1;
        private EgoldsCard egoldsCard1;
        private EgoldsCard egoldsCard2;
        private EgoldsCard egoldsCard3;
    }
}

