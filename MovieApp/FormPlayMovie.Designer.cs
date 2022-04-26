namespace MovieApp
{
    partial class FormPlayMovie
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlayMovie));
            this.wmp1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnExit = new System.Windows.Forms.Button();
            this.lblMovieName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.wmp1)).BeginInit();
            this.SuspendLayout();
            // 
            // wmp1
            // 
            this.wmp1.Enabled = true;
            this.wmp1.Location = new System.Drawing.Point(12, 51);
            this.wmp1.Name = "wmp1";
            this.wmp1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("wmp1.OcxState")));
            this.wmp1.Size = new System.Drawing.Size(553, 262);
            this.wmp1.TabIndex = 0;
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(12, 439);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(157, 58);
            this.btnExit.TabIndex = 17;
            this.btnExit.Text = "Thoát";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // lblMovieName
            // 
            this.lblMovieName.AutoSize = true;
            this.lblMovieName.Font = new System.Drawing.Font("Times New Roman", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMovieName.Location = new System.Drawing.Point(266, 11);
            this.lblMovieName.Name = "lblMovieName";
            this.lblMovieName.Size = new System.Drawing.Size(186, 37);
            this.lblMovieName.TabIndex = 18;
            this.lblMovieName.Text = "movie name";
            // 
            // FormPlayMovie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 498);
            this.Controls.Add(this.lblMovieName);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.wmp1);
            this.Name = "FormPlayMovie";
            this.Text = "FormPlayMovie";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormPlayMovie_FormClosed);
            this.Load += new System.EventHandler(this.FormPlayMovie_Load);
            ((System.ComponentModel.ISupportInitialize)(this.wmp1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer wmp1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Label lblMovieName;
    }
}