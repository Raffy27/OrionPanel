namespace Panel
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.TitlePanel = new System.Windows.Forms.Panel();
            this.FormRounding = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.UserEdit = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.PassEdit = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.loginButton = new Bunifu.Framework.UI.BunifuFlatButton();
            this.FormDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.ImageDrag = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.SuspendLayout();
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TitlePanel.BackgroundImage")));
            this.TitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Size = new System.Drawing.Size(360, 200);
            this.TitlePanel.TabIndex = 0;
            // 
            // FormRounding
            // 
            this.FormRounding.ElipseRadius = 5;
            this.FormRounding.TargetControl = this;
            // 
            // UserEdit
            // 
            this.UserEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.UserEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.UserEdit.ForeColor = System.Drawing.Color.White;
            this.UserEdit.HintForeColor = System.Drawing.Color.Gray;
            this.UserEdit.HintText = "Username";
            this.UserEdit.isPassword = false;
            this.UserEdit.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.UserEdit.LineIdleColor = System.Drawing.Color.Gray;
            this.UserEdit.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.UserEdit.LineThickness = 3;
            this.UserEdit.Location = new System.Drawing.Point(30, 260);
            this.UserEdit.Margin = new System.Windows.Forms.Padding(4);
            this.UserEdit.Name = "UserEdit";
            this.UserEdit.Size = new System.Drawing.Size(300, 44);
            this.UserEdit.TabIndex = 2;
            this.UserEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // PassEdit
            // 
            this.PassEdit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.PassEdit.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.PassEdit.ForeColor = System.Drawing.Color.White;
            this.PassEdit.HintForeColor = System.Drawing.Color.Gray;
            this.PassEdit.HintText = "Password";
            this.PassEdit.isPassword = false;
            this.PassEdit.LineFocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.PassEdit.LineIdleColor = System.Drawing.Color.Gray;
            this.PassEdit.LineMouseHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.PassEdit.LineThickness = 3;
            this.PassEdit.Location = new System.Drawing.Point(30, 333);
            this.PassEdit.Margin = new System.Windows.Forms.Padding(4);
            this.PassEdit.Name = "PassEdit";
            this.PassEdit.Size = new System.Drawing.Size(300, 44);
            this.PassEdit.TabIndex = 3;
            this.PassEdit.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.PassEdit.Enter += new System.EventHandler(this.PassEdit_Enter);
            // 
            // loginButton
            // 
            this.loginButton.Activecolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.loginButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginButton.BorderRadius = 2;
            this.loginButton.ButtonText = "  Login";
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.DisabledColor = System.Drawing.Color.Gray;
            this.loginButton.Iconcolor = System.Drawing.Color.Transparent;
            this.loginButton.Iconimage = ((System.Drawing.Image)(resources.GetObject("loginButton.Iconimage")));
            this.loginButton.Iconimage_right = null;
            this.loginButton.Iconimage_right_Selected = null;
            this.loginButton.Iconimage_Selected = null;
            this.loginButton.IconMarginLeft = 0;
            this.loginButton.IconMarginRight = 0;
            this.loginButton.IconRightVisible = true;
            this.loginButton.IconRightZoom = 0D;
            this.loginButton.IconVisible = true;
            this.loginButton.IconZoom = 50D;
            this.loginButton.IsTab = false;
            this.loginButton.Location = new System.Drawing.Point(75, 411);
            this.loginButton.Name = "loginButton";
            this.loginButton.Normalcolor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.loginButton.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(2)))), ((int)(((byte)(186)))), ((int)(((byte)(255)))));
            this.loginButton.OnHoverTextColor = System.Drawing.Color.White;
            this.loginButton.selected = false;
            this.loginButton.Size = new System.Drawing.Size(211, 48);
            this.loginButton.TabIndex = 1;
            this.loginButton.Text = "  Login";
            this.loginButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.loginButton.Textcolor = System.Drawing.Color.White;
            this.loginButton.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // FormDrag
            // 
            this.FormDrag.Fixed = true;
            this.FormDrag.Horizontal = true;
            this.FormDrag.TargetControl = this;
            this.FormDrag.Vertical = true;
            // 
            // ImageDrag
            // 
            this.ImageDrag.Fixed = true;
            this.ImageDrag.Horizontal = true;
            this.ImageDrag.TargetControl = this.TitlePanel;
            this.ImageDrag.Vertical = true;
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(360, 500);
            this.Controls.Add(this.loginButton);
            this.Controls.Add(this.PassEdit);
            this.Controls.Add(this.UserEdit);
            this.Controls.Add(this.TitlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel TitlePanel;
        private Bunifu.Framework.UI.BunifuElipse FormRounding;
        private Bunifu.Framework.UI.BunifuFlatButton loginButton;
        private Bunifu.Framework.UI.BunifuMaterialTextbox PassEdit;
        private Bunifu.Framework.UI.BunifuMaterialTextbox UserEdit;
        private Bunifu.Framework.UI.BunifuDragControl FormDrag;
        private Bunifu.Framework.UI.BunifuDragControl ImageDrag;
    }
}