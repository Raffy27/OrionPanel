namespace Panel
{
    partial class CmdForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CmdForm));
            this.FormRounding = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.sendButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cancelButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.cmdNameLabel = new System.Windows.Forms.Label();
            this.Sep1 = new Bunifu.Framework.UI.BunifuSeparator();
            this.storeCheck = new Bunifu.Framework.UI.BunifuCheckbox();
            this.storeLabel = new System.Windows.Forms.Label();
            this.FormDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // FormRounding
            // 
            this.FormRounding.ElipseRadius = 5;
            this.FormRounding.TargetControl = this;
            // 
            // sendButton
            // 
            this.sendButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.sendButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sendButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.sendButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.sendButton.BorderRadius = 2;
            this.sendButton.ButtonText = "  Send";
            this.sendButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendButton.DisabledColor = System.Drawing.Color.Gray;
            this.sendButton.Iconcolor = System.Drawing.Color.Transparent;
            this.sendButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("sendButton.Iconimage")));
            this.sendButton.Iconimage_right = null;
            this.sendButton.Iconimage_right_Selected = null;
            this.sendButton.Iconimage_Selected = null;
            this.sendButton.IconMarginLeft = 10;
            this.sendButton.IconMarginRight = 0;
            this.sendButton.IconRightVisible = false;
            this.sendButton.IconRightZoom = 0D;
            this.sendButton.IconVisible = true;
            this.sendButton.IconZoom = 50D;
            this.sendButton.IsTab = false;
            this.sendButton.Location = new System.Drawing.Point(363, 252);
            this.sendButton.Name = "sendButton";
            this.sendButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.sendButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.sendButton.OnHoverTextColor = System.Drawing.Color.White;
            this.sendButton.selected = false;
            this.sendButton.Size = new System.Drawing.Size(127, 40);
            this.sendButton.TabIndex = 10;
            this.sendButton.Text = "  Send";
            this.sendButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.sendButton.Textcolor = System.Drawing.Color.White;
            this.sendButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendButton.Click += new System.EventHandler(this.SendButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.cancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.cancelButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.cancelButton.BorderRadius = 2;
            this.cancelButton.ButtonText = "  Cancel";
            this.cancelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelButton.DisabledColor = System.Drawing.Color.Gray;
            this.cancelButton.Iconcolor = System.Drawing.Color.Transparent;
            this.cancelButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("cancelButton.Iconimage")));
            this.cancelButton.Iconimage_right = null;
            this.cancelButton.Iconimage_right_Selected = null;
            this.cancelButton.Iconimage_Selected = null;
            this.cancelButton.IconMarginLeft = 10;
            this.cancelButton.IconMarginRight = 0;
            this.cancelButton.IconRightVisible = false;
            this.cancelButton.IconRightZoom = 0D;
            this.cancelButton.IconVisible = true;
            this.cancelButton.IconZoom = 50D;
            this.cancelButton.IsTab = false;
            this.cancelButton.Location = new System.Drawing.Point(230, 252);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.cancelButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.cancelButton.OnHoverTextColor = System.Drawing.Color.White;
            this.cancelButton.selected = false;
            this.cancelButton.Size = new System.Drawing.Size(127, 40);
            this.cancelButton.TabIndex = 11;
            this.cancelButton.Text = "  Cancel";
            this.cancelButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.cancelButton.Textcolor = System.Drawing.Color.White;
            this.cancelButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // cmdNameLabel
            // 
            this.cmdNameLabel.AutoSize = true;
            this.cmdNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmdNameLabel.Location = new System.Drawing.Point(12, 26);
            this.cmdNameLabel.Name = "cmdNameLabel";
            this.cmdNameLabel.Size = new System.Drawing.Size(195, 29);
            this.cmdNameLabel.TabIndex = 12;
            this.cmdNameLabel.Text = "Command Name";
            // 
            // Sep1
            // 
            this.Sep1.BackColor = System.Drawing.Color.Transparent;
            this.Sep1.LineColor = System.Drawing.Color.FromArgb(((int)(((byte)(105)))), ((int)(((byte)(105)))), ((int)(((byte)(105)))));
            this.Sep1.LineThickness = 1;
            this.Sep1.Location = new System.Drawing.Point(0, 67);
            this.Sep1.Name = "Sep1";
            this.Sep1.Size = new System.Drawing.Size(586, 16);
            this.Sep1.TabIndex = 13;
            this.Sep1.Transparency = 255;
            this.Sep1.Vertical = false;
            // 
            // storeCheck
            // 
            this.storeCheck.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.storeCheck.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.storeCheck.ChechedOffColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(135)))), ((int)(((byte)(140)))));
            this.storeCheck.Checked = false;
            this.storeCheck.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.storeCheck.ForeColor = System.Drawing.Color.White;
            this.storeCheck.Location = new System.Drawing.Point(17, 220);
            this.storeCheck.Name = "storeCheck";
            this.storeCheck.Size = new System.Drawing.Size(20, 20);
            this.storeCheck.TabIndex = 37;
            // 
            // storeLabel
            // 
            this.storeLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.storeLabel.AutoSize = true;
            this.storeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storeLabel.Location = new System.Drawing.Point(43, 222);
            this.storeLabel.Name = "storeLabel";
            this.storeLabel.Size = new System.Drawing.Size(117, 15);
            this.storeLabel.TabIndex = 36;
            this.storeLabel.Text = "Store this command";
            // 
            // FormDrag
            // 
            this.FormDrag.Fixed = true;
            this.FormDrag.Horizontal = true;
            this.FormDrag.TargetControl = this;
            this.FormDrag.Vertical = true;
            // 
            // CmdForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(502, 304);
            this.Controls.Add(this.storeCheck);
            this.Controls.Add(this.storeLabel);
            this.Controls.Add(this.sendButton);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.Sep1);
            this.Controls.Add(this.cmdNameLabel);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CmdForm";
            this.Opacity = 0.97D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "CmdForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse FormRounding;
        private Bunifu.Framework.UI.BunifuFlatButton cancelButton;
        private Bunifu.Framework.UI.BunifuFlatButton sendButton;
        private Bunifu.Framework.UI.BunifuSeparator Sep1;
        private System.Windows.Forms.Label cmdNameLabel;
        private Bunifu.Framework.UI.BunifuCheckbox storeCheck;
        private System.Windows.Forms.Label storeLabel;
        private Bunifu.Framework.UI.BunifuDragControl FormDrag;
    }
}