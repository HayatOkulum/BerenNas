namespace BerenNas
{
    partial class Kare
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Kare));
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tBEdge = new System.Windows.Forms.TextBox();
            this.btnSolition = new System.Windows.Forms.Button();
            this.lblTitle2 = new System.Windows.Forms.Label();
            this.lblResult = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.Indigo;
            this.lblTitle.Location = new System.Drawing.Point(448, 39);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(340, 33);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Karenin Bir Kenarını Giriniz (a)";
            this.lblTitle.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Indigo;
            this.label2.Location = new System.Drawing.Point(448, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "a=";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // tBEdge
            // 
            this.tBEdge.Location = new System.Drawing.Point(489, 120);
            this.tBEdge.Multiline = true;
            this.tBEdge.Name = "tBEdge";
            this.tBEdge.Size = new System.Drawing.Size(117, 35);
            this.tBEdge.TabIndex = 3;
            this.tBEdge.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnSolition
            // 
            this.btnSolition.Location = new System.Drawing.Point(647, 120);
            this.btnSolition.Name = "btnSolition";
            this.btnSolition.Size = new System.Drawing.Size(99, 36);
            this.btnSolition.TabIndex = 4;
            this.btnSolition.Text = "Hesapla";
            this.btnSolition.UseVisualStyleBackColor = true;
            this.btnSolition.Click += new System.EventHandler(this.btnSolition_Click);
            // 
            // lblTitle2
            // 
            this.lblTitle2.Font = new System.Drawing.Font("MV Boli", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle2.ForeColor = System.Drawing.Color.DarkOrchid;
            this.lblTitle2.Location = new System.Drawing.Point(448, 209);
            this.lblTitle2.Name = "lblTitle2";
            this.lblTitle2.Size = new System.Drawing.Size(257, 23);
            this.lblTitle2.TabIndex = 5;
            this.lblTitle2.Text = "Karenin Çevresi nedir? = ";
            this.lblTitle2.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblResult
            // 
            this.lblResult.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblResult.ForeColor = System.Drawing.Color.Indigo;
            this.lblResult.Location = new System.Drawing.Point(702, 211);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(106, 33);
            this.lblResult.TabIndex = 6;
            this.lblResult.Text = "?_?";
            this.lblResult.Click += new System.EventHandler(this.label4_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::BerenNas.Properties.Resources.karenin_alani_nasil_bulunur_karenin_alan_hesaplama_formulu_e1_1619438753406;
            this.pictureBox1.Location = new System.Drawing.Point(12, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(430, 373);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Kare
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 358);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.lblTitle2);
            this.Controls.Add(this.btnSolition);
            this.Controls.Add(this.tBEdge);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Kare";
            this.Text = "Karenin Bir Kenarını Girniz (a)";
            this.Load += new System.EventHandler(this.Kare_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tBEdge;
        private System.Windows.Forms.Button btnSolition;
        private System.Windows.Forms.Label lblTitle2;
        private System.Windows.Forms.Label lblResult;
    }
}