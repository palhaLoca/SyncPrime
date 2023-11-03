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
            this.label5 = new System.Windows.Forms.Label();
            this.txtBoxEndPtX = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxEndPtY = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxStartPtY = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxStartPtX = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBoxLayer = new System.Windows.Forms.TextBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.cbTypeValues = new System.Windows.Forms.ComboBox();
            this.dtGridViewCurrentElements = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLines)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewCurrentElements)).BeginInit();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnSave.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSave.Location = new System.Drawing.Point(406, 381);
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
            this.dtGridViewLines.Location = new System.Drawing.Point(49, 121);
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
            this.groupBox1.Location = new System.Drawing.Point(157, 19);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(562, 79);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Propriedades";
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Layer:";
            // 
            // txtBoxLayer
            // 
            this.txtBoxLayer.Location = new System.Drawing.Point(20, 44);
            this.txtBoxLayer.Name = "txtBoxLayer";
            this.txtBoxLayer.Size = new System.Drawing.Size(100, 20);
            this.txtBoxLayer.TabIndex = 0;
            // 
            // tabControl1
            // 
            this.tabControl1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(-1, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(900, 445);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.btnSave);
            this.tabPage1.Controls.Add(this.dtGridViewLines);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(0);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(892, 419);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Banco de Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.cbTypeValues);
            this.tabPage2.Controls.Add(this.dtGridViewCurrentElements);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(892, 419);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Corrente";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // cbTypeValues
            // 
            this.cbTypeValues.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cbTypeValues.FormattingEnabled = true;
            this.cbTypeValues.Location = new System.Drawing.Point(6, 14);
            this.cbTypeValues.Name = "cbTypeValues";
            this.cbTypeValues.Size = new System.Drawing.Size(121, 21);
            this.cbTypeValues.TabIndex = 3;
            this.cbTypeValues.SelectedIndexChanged += new System.EventHandler(this.cbTypeValues_SelectedIndexChanged);
            // 
            // dtGridViewCurrentElements
            // 
            this.dtGridViewCurrentElements.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.dtGridViewCurrentElements.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtGridViewCurrentElements.Location = new System.Drawing.Point(5, 38);
            this.dtGridViewCurrentElements.Margin = new System.Windows.Forms.Padding(0);
            this.dtGridViewCurrentElements.Name = "dtGridViewCurrentElements";
            this.dtGridViewCurrentElements.Size = new System.Drawing.Size(882, 378);
            this.dtGridViewCurrentElements.TabIndex = 2;
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(899, 447);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewLines)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtGridViewCurrentElements)).EndInit();
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridView dtGridViewCurrentElements;
        private System.Windows.Forms.ComboBox cbTypeValues;
    }
}