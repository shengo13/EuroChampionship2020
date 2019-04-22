namespace EuroChempionship2020
{
    partial class MainForm
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
            this.Mainpanel = new System.Windows.Forms.Panel();
            this.teamsTable = new System.Windows.Forms.TableLayoutPanel();
            this.levelLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.StrongLabel = new System.Windows.Forms.Label();
            this.MediumLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.WeakLabel = new System.Windows.Forms.Label();
            this.veryStrongLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.selectionButton = new System.Windows.Forms.Button();
            this.EuroChempionship2020label = new System.Windows.Forms.Label();
            this.Mainpanel.SuspendLayout();
            this.teamsTable.SuspendLayout();
            this.SuspendLayout();
            // 
            // Mainpanel
            // 
            this.Mainpanel.Controls.Add(this.teamsTable);
            this.Mainpanel.Controls.Add(this.selectionButton);
            this.Mainpanel.Controls.Add(this.EuroChempionship2020label);
            this.Mainpanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Mainpanel.Location = new System.Drawing.Point(0, 0);
            this.Mainpanel.Name = "Mainpanel";
            this.Mainpanel.Size = new System.Drawing.Size(1261, 678);
            this.Mainpanel.TabIndex = 0;
            // 
            // teamsTable
            // 
            this.teamsTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.teamsTable.CellBorderStyle = System.Windows.Forms.TableLayoutPanelCellBorderStyle.Inset;
            this.teamsTable.ColumnCount = 5;
            this.teamsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.teamsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.teamsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.teamsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.teamsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.teamsTable.Controls.Add(this.levelLabel, 0, 0);
            this.teamsTable.Controls.Add(this.label1, 1, 0);
            this.teamsTable.Controls.Add(this.label2, 2, 0);
            this.teamsTable.Controls.Add(this.StrongLabel, 0, 2);
            this.teamsTable.Controls.Add(this.MediumLabel, 0, 3);
            this.teamsTable.Controls.Add(this.label4, 4, 0);
            this.teamsTable.Controls.Add(this.WeakLabel, 0, 4);
            this.teamsTable.Controls.Add(this.veryStrongLabel, 0, 1);
            this.teamsTable.Controls.Add(this.label3, 3, 0);
            this.teamsTable.Location = new System.Drawing.Point(94, 87);
            this.teamsTable.Name = "teamsTable";
            this.teamsTable.RowCount = 5;
            this.teamsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.teamsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 100F));
            this.teamsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 99F));
            this.teamsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 97F));
            this.teamsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 86F));
            this.teamsTable.Size = new System.Drawing.Size(1083, 421);
            this.teamsTable.TabIndex = 2;
            // 
            // levelLabel
            // 
            this.levelLabel.AutoSize = true;
            this.levelLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.levelLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.levelLabel.Location = new System.Drawing.Point(5, 2);
            this.levelLabel.Name = "levelLabel";
            this.levelLabel.Size = new System.Drawing.Size(208, 27);
            this.levelLabel.TabIndex = 0;
            this.levelLabel.Text = "level";
            this.levelLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(221, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 27);
            this.label1.TabIndex = 0;
            this.label1.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(437, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "2";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // StrongLabel
            // 
            this.StrongLabel.AutoSize = true;
            this.StrongLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.StrongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StrongLabel.Location = new System.Drawing.Point(5, 133);
            this.StrongLabel.Name = "StrongLabel";
            this.StrongLabel.Size = new System.Drawing.Size(208, 99);
            this.StrongLabel.TabIndex = 0;
            this.StrongLabel.Text = "Strong";
            this.StrongLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MediumLabel
            // 
            this.MediumLabel.AutoSize = true;
            this.MediumLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MediumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MediumLabel.Location = new System.Drawing.Point(5, 234);
            this.MediumLabel.Name = "MediumLabel";
            this.MediumLabel.Size = new System.Drawing.Size(208, 97);
            this.MediumLabel.TabIndex = 0;
            this.MediumLabel.Text = "Medium";
            this.MediumLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(869, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 20);
            this.label4.TabIndex = 0;
            this.label4.Text = "4";
            // 
            // WeakLabel
            // 
            this.WeakLabel.AutoSize = true;
            this.WeakLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WeakLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WeakLabel.Location = new System.Drawing.Point(5, 333);
            this.WeakLabel.Name = "WeakLabel";
            this.WeakLabel.Size = new System.Drawing.Size(208, 86);
            this.WeakLabel.TabIndex = 0;
            this.WeakLabel.Text = "Weak";
            this.WeakLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // veryStrongLabel
            // 
            this.veryStrongLabel.AutoSize = true;
            this.veryStrongLabel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.veryStrongLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.veryStrongLabel.Location = new System.Drawing.Point(5, 31);
            this.veryStrongLabel.Name = "veryStrongLabel";
            this.veryStrongLabel.Size = new System.Drawing.Size(208, 100);
            this.veryStrongLabel.TabIndex = 0;
            this.veryStrongLabel.Text = "Very Strong";
            this.veryStrongLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Dock = System.Windows.Forms.DockStyle.Left;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(653, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(19, 27);
            this.label3.TabIndex = 0;
            this.label3.Text = "3";
            // 
            // selectionButton
            // 
            this.selectionButton.BackColor = System.Drawing.Color.Green;
            this.selectionButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectionButton.ForeColor = System.Drawing.Color.Lime;
            this.selectionButton.Location = new System.Drawing.Point(465, 591);
            this.selectionButton.Name = "selectionButton";
            this.selectionButton.Size = new System.Drawing.Size(225, 75);
            this.selectionButton.TabIndex = 1;
            this.selectionButton.Text = "Selection";
            this.selectionButton.UseVisualStyleBackColor = false;
            this.selectionButton.Click += new System.EventHandler(this.SelectionButton_Click);
            // 
            // EuroChempionship2020label
            // 
            this.EuroChempionship2020label.AutoSize = true;
            this.EuroChempionship2020label.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EuroChempionship2020label.ForeColor = System.Drawing.Color.Green;
            this.EuroChempionship2020label.Location = new System.Drawing.Point(433, 41);
            this.EuroChempionship2020label.Name = "EuroChempionship2020label";
            this.EuroChempionship2020label.Size = new System.Drawing.Size(340, 31);
            this.EuroChempionship2020label.TabIndex = 0;
            this.EuroChempionship2020label.Text = "Euro Chempionship 2020";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1261, 678);
            this.Controls.Add(this.Mainpanel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.Mainpanel.ResumeLayout(false);
            this.Mainpanel.PerformLayout();
            this.teamsTable.ResumeLayout(false);
            this.teamsTable.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Mainpanel;
        private System.Windows.Forms.Label levelLabel;
        private System.Windows.Forms.Label EuroChempionship2020label;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button selectionButton;
        private System.Windows.Forms.TableLayoutPanel teamsTable;
        private System.Windows.Forms.Label veryStrongLabel;
        private System.Windows.Forms.Label StrongLabel;
        private System.Windows.Forms.Label MediumLabel;
        private System.Windows.Forms.Label WeakLabel;
    }
}

