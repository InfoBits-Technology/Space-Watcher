namespace Space_Watcher
{
    partial class WF_Play
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WF_Play));
            PLive_Left = new Panel();
            TLive_Left = new TableLayoutPanel();
            lblCoin = new Label();
            ICoin_Left = new PictureBox();
            ILive_Left = new PictureBox();
            lblLife = new Label();
            ILaser = new PictureBox();
            TLive_Left.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)ICoin_Left).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ILive_Left).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ILaser).BeginInit();
            SuspendLayout();
            // 
            // PLive_Left
            // 
            PLive_Left.BackColor = Color.Transparent;
            PLive_Left.BackgroundImage = (Image)resources.GetObject("PLive_Left.BackgroundImage");
            PLive_Left.BackgroundImageLayout = ImageLayout.Stretch;
            PLive_Left.Location = new Point(12, 732);
            PLive_Left.Name = "PLive_Left";
            PLive_Left.Size = new Size(222, 17);
            PLive_Left.TabIndex = 3;
            // 
            // TLive_Left
            // 
            TLive_Left.BackColor = Color.Transparent;
            TLive_Left.ColumnCount = 4;
            TLive_Left.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.475729F));
            TLive_Left.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 19.4174767F));
            TLive_Left.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 17.1171169F));
            TLive_Left.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 46.8468475F));
            TLive_Left.Controls.Add(lblCoin, 3, 0);
            TLive_Left.Controls.Add(ICoin_Left, 2, 0);
            TLive_Left.Controls.Add(ILive_Left, 0, 0);
            TLive_Left.Controls.Add(lblLife, 1, 0);
            TLive_Left.Location = new Point(12, 689);
            TLive_Left.Name = "TLive_Left";
            TLive_Left.RowCount = 1;
            TLive_Left.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            TLive_Left.Size = new Size(222, 37);
            TLive_Left.TabIndex = 4;
            // 
            // lblCoin
            // 
            lblCoin.AutoSize = true;
            lblCoin.Dock = DockStyle.Fill;
            lblCoin.Font = new Font("Unesa", 21.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCoin.ForeColor = Color.LightGoldenrodYellow;
            lblCoin.Location = new Point(120, 0);
            lblCoin.Name = "lblCoin";
            lblCoin.Size = new Size(99, 37);
            lblCoin.TabIndex = 3;
            lblCoin.Text = "0";
            lblCoin.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // ICoin_Left
            // 
            ICoin_Left.BackgroundImageLayout = ImageLayout.Stretch;
            ICoin_Left.Dock = DockStyle.Fill;
            ICoin_Left.Location = new Point(83, 3);
            ICoin_Left.Name = "ICoin_Left";
            ICoin_Left.Size = new Size(31, 31);
            ICoin_Left.TabIndex = 2;
            ICoin_Left.TabStop = false;
            // 
            // ILive_Left
            // 
            ILive_Left.BackgroundImageLayout = ImageLayout.Stretch;
            ILive_Left.Dock = DockStyle.Fill;
            ILive_Left.Location = new Point(3, 3);
            ILive_Left.Name = "ILive_Left";
            ILive_Left.Size = new Size(32, 31);
            ILive_Left.TabIndex = 0;
            ILive_Left.TabStop = false;
            // 
            // lblLife
            // 
            lblLife.AutoSize = true;
            lblLife.Dock = DockStyle.Fill;
            lblLife.Font = new Font("Unesa", 21.7499962F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLife.ForeColor = Color.LightBlue;
            lblLife.Location = new Point(41, 0);
            lblLife.Name = "lblLife";
            lblLife.Size = new Size(36, 37);
            lblLife.TabIndex = 1;
            lblLife.Text = "5";
            lblLife.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // ILaser
            // 
            ILaser.BackColor = Color.Transparent;
            ILaser.Location = new Point(593, 538);
            ILaser.Name = "ILaser";
            ILaser.Size = new Size(10, 40);
            ILaser.TabIndex = 5;
            ILaser.TabStop = false;
            // 
            // WF_Play
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(1184, 761);
            ControlBox = false;
            Controls.Add(ILaser);
            Controls.Add(TLive_Left);
            Controls.Add(PLive_Left);
            Cursor = Cursors.Hand;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            KeyPreview = true;
            Name = "WF_Play";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "WF_Playcs";
            TLive_Left.ResumeLayout(false);
            TLive_Left.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)ICoin_Left).EndInit();
            ((System.ComponentModel.ISupportInitialize)ILive_Left).EndInit();
            ((System.ComponentModel.ISupportInitialize)ILaser).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private TableLayoutPanel Table_Ship;
        private Panel PLive_Left;
        private TableLayoutPanel TLive_Left;
        private PictureBox ILive_Left;
        private Label lblLife;
        private Label lblCoin;
        private PictureBox ICoin_Left;
        private PictureBox ILaser;
    }
}