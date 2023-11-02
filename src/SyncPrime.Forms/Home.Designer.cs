namespace SyncPrime
{
    partial class Home
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
            this.btnSave = new System.Windows.Forms.Button();
            this.dtGridViewLines = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBoxLayer = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxStartPtX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxStartPtY = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxEndPtY = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxEndPtX = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLines)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(365, 379);
            this.btnSave.Margin = new System.Windows.Forms.Padding(0);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 0;
            this.btnSave.Text = "Salvar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtGridViewLines
            // 
            this.dtGridViewLines.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtGridViewLines.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewLines.Location = new System.Drawing.Point(14, 107);
            this.dtGridViewLines.Margin = new System.Windows.Forms.Padding(0);
            this.dtGridViewLines.Name = "dtGridViewLines";
            this.dtGridViewLines.Size = new System.Drawing.Size(791, 251);
            this.dtGridViewLines.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.txtBoxEndPtX);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtBoxEndPtY);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtBoxStartPtY);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtBoxStartPtX);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtBoxLayer);
            this.groupBox1.Location = new System.Drawing.Point(123, 9);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propriedades";
            // 
            // txtBoxLayer
            // 
            this.txtBoxLayer.Location = new System.Drawing.Point(20, 44);
            this.txtBoxLayer.Name = "txtBoxLayer";
            this.txtBoxLayer.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLayer.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Layer:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(126, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "StartPtX:";
            // 
            // txtBoxStartPtX
            // 
            this.txtBoxStartPtX.Location = new System.Drawing.Point(126, 44);
            this.txtBoxStartPtX.Name = "txtBoxStartPtX";
            this.txtBoxStartPtX.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStartPtX.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(445, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "StartPtY:";
            // 
            // txtBoxStartPtY
            // 
            this.txtBoxStartPtY.Location = new System.Drawing.Point(445, 44);
            this.txtBoxStartPtY.Name = "txtBoxStartPtY";
            this.txtBoxStartPtY.Size = new System.Drawing.Size(100, 20);
            this.txtBoxStartPtY.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "EndPtY:";
            // 
            // txtBoxEndPtY
            // 
            this.txtBoxEndPtY.Location = new System.Drawing.Point(339, 44);
            this.txtBoxEndPtY.Name = "txtBoxEndPtY";
            this.txtBoxEndPtY.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEndPtY.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(233, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "EndPtX:";
            // 
            // txtBoxEndPtX
            // 
            this.txtBoxEndPtX.Location = new System.Drawing.Point(233, 44);
            this.txtBoxEndPtX.Name = "txtBoxEndPtX";
            this.txtBoxEndPtX.Size = new System.Drawing.Size(100, 20);
            this.txtBoxEndPtX.TabIndex = 8;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(814, 411);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dtGridViewLines);
            this.Controls.Add(this.btnSave);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLines)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DataGridView dtGridViewLines;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxLayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtBoxStartPtX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxEndPtX;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxEndPtY;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtBoxStartPtY;
    }
}