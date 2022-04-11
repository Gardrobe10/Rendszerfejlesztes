
namespace Rendszerfejlesztes
{
    partial class Eszkozkezelo
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
            this.mainlayout = new System.Windows.Forms.TableLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.AddDeviceBtn = new System.Windows.Forms.Button();
            this.ShowDevicesBtn = new System.Windows.Forms.Button();
            this.mainlayout.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainlayout
            // 
            this.mainlayout.ColumnCount = 1;
            this.mainlayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.mainlayout.Controls.Add(this.label1, 0, 0);
            this.mainlayout.Controls.Add(this.ShowDevicesBtn, 0, 1);
            this.mainlayout.Controls.Add(this.AddDeviceBtn, 0, 2);
            this.mainlayout.Location = new System.Drawing.Point(13, 13);
            this.mainlayout.Name = "mainlayout";
            this.mainlayout.RowCount = 4;
            this.mainlayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainlayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainlayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainlayout.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.mainlayout.Size = new System.Drawing.Size(236, 256);
            this.mainlayout.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ön eszközkezelőként van bejelentkezve";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AddDeviceBtn
            // 
            this.AddDeviceBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AddDeviceBtn.Location = new System.Drawing.Point(3, 90);
            this.AddDeviceBtn.Name = "AddDeviceBtn";
            this.AddDeviceBtn.Size = new System.Drawing.Size(197, 57);
            this.AddDeviceBtn.TabIndex = 1;
            this.AddDeviceBtn.Text = "Eszköz felvétele";
            this.AddDeviceBtn.UseVisualStyleBackColor = true;
            this.AddDeviceBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // ShowDevicesBtn
            // 
            this.ShowDevicesBtn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ShowDevicesBtn.Location = new System.Drawing.Point(25, 153);
            this.ShowDevicesBtn.Name = "ShowDevicesBtn";
            this.ShowDevicesBtn.Size = new System.Drawing.Size(196, 41);
            this.ShowDevicesBtn.TabIndex = 2;
            this.ShowDevicesBtn.Text = "Eszközök megtekintése";
            this.ShowDevicesBtn.UseVisualStyleBackColor = true;
            // 
            // Eszkozkezelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(252, 281);
            this.Controls.Add(this.mainlayout);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Eszkozkezelo";
            this.Text = "Eszkozkezelo";
            this.mainlayout.ResumeLayout(false);
            this.mainlayout.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel mainlayout;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button AddDeviceBtn;
        private System.Windows.Forms.Button ShowDevicesBtn;
    }
}