namespace Space_Watcher
{
    partial class WF_Panel
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnPlay = new TableLayoutPanel();
            lblTextPlay = new Label();
            btnPlay.SuspendLayout();
            SuspendLayout();
            // 
            // btnPlay
            // 
            btnPlay.BackColor = Color.Transparent;
            btnPlay.ColumnCount = 1;
            btnPlay.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            btnPlay.Controls.Add(lblTextPlay, 0, 0);
            btnPlay.Cursor = Cursors.Hand;
            btnPlay.GrowStyle = TableLayoutPanelGrowStyle.FixedSize;
            btnPlay.Location = new Point(8, 8);
            btnPlay.Name = "btnPlay";
            btnPlay.RowCount = 1;
            btnPlay.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            btnPlay.Size = new Size(293, 72);
            btnPlay.TabIndex = 2;
            btnPlay.Tag = "Play";
            // 
            // lblTextPlay
            // 
            lblTextPlay.AutoSize = true;
            lblTextPlay.Dock = DockStyle.Fill;
            lblTextPlay.Font = new Font("Unesa", 30F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTextPlay.ForeColor = Color.White;
            lblTextPlay.Location = new Point(3, 0);
            lblTextPlay.Name = "lblTextPlay";
            lblTextPlay.Size = new Size(287, 72);
            lblTextPlay.TabIndex = 1;
            lblTextPlay.Tag = "Play";
            lblTextPlay.Text = "Jugar";
            lblTextPlay.TextAlign = ContentAlignment.MiddleCenter;
            lblTextPlay.UseCompatibleTextRendering = true;
            // 
            // WF_Panel
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1184, 761);
            Controls.Add(btnPlay);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Name = "WF_Panel";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Space Watcher";
            btnPlay.ResumeLayout(false);
            btnPlay.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel btnPlay;
        private Label lblTextPlay;
    }
}
