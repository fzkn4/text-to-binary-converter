namespace text_to_binary
{
    partial class Form1
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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            input = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            from = new Guna.UI2.WinForms.Guna2ComboBox();
            to = new Guna.UI2.WinForms.Guna2ComboBox();
            label3 = new Label();
            guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            copy = new Guna.UI2.WinForms.Guna2Button();
            output = new Label();
            guna2Panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft New Tai Lue", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.ForeColor = Color.FromArgb(66, 71, 105);
            label1.Location = new Point(115, 26);
            label1.Name = "label1";
            label1.Size = new Size(360, 42);
            label1.TabIndex = 0;
            label1.Text = "Text to Binary Converter";
            // 
            // input
            // 
            input.Animated = true;
            input.BorderColor = Color.FromArgb(66, 71, 105);
            input.BorderRadius = 6;
            input.CustomizableEdges = customizableEdges11;
            input.DefaultText = "";
            input.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            input.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            input.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            input.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            input.FillColor = Color.FromArgb(248, 244, 236);
            input.FocusedState.BorderColor = Color.FromArgb(66, 71, 105);
            input.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point);
            input.ForeColor = Color.FromArgb(66, 71, 105);
            input.HoverState.BorderColor = Color.FromArgb(66, 71, 105);
            input.Location = new Point(41, 193);
            input.Name = "input";
            input.PasswordChar = '\0';
            input.PlaceholderForeColor = Color.Gray;
            input.PlaceholderText = "Input text...";
            input.SelectedText = "";
            input.ShadowDecoration.CustomizableEdges = customizableEdges12;
            input.Size = new Size(510, 53);
            input.TabIndex = 1;
            input.TextOffset = new Point(3, 0);
            input.TextChanged += guna2TextBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.ForeColor = Color.FromArgb(66, 71, 105);
            label2.Location = new Point(51, 95);
            label2.Name = "label2";
            label2.Size = new Size(35, 15);
            label2.TabIndex = 2;
            label2.Text = "From";
            // 
            // from
            // 
            from.BackColor = Color.Transparent;
            from.BorderColor = Color.FromArgb(66, 71, 105);
            from.BorderRadius = 6;
            from.CustomizableEdges = customizableEdges13;
            from.DrawMode = DrawMode.OwnerDrawFixed;
            from.DropDownStyle = ComboBoxStyle.DropDownList;
            from.FillColor = Color.FromArgb(248, 244, 236);
            from.FocusedColor = Color.FromArgb(66, 71, 105);
            from.FocusedState.BorderColor = Color.FromArgb(66, 71, 105);
            from.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            from.ForeColor = Color.FromArgb(66, 71, 105);
            from.HoverState.BorderColor = Color.FromArgb(66, 71, 105);
            from.ItemHeight = 40;
            from.Location = new Point(41, 114);
            from.Name = "from";
            from.ShadowDecoration.BorderRadius = 8;
            from.ShadowDecoration.Color = Color.FromArgb(66, 71, 105);
            from.ShadowDecoration.CustomizableEdges = customizableEdges14;
            from.ShadowDecoration.Depth = 20;
            from.Size = new Size(238, 46);
            from.TabIndex = 3;
            // 
            // to
            // 
            to.BackColor = Color.Transparent;
            to.BorderColor = Color.FromArgb(66, 71, 105);
            to.BorderRadius = 6;
            to.CustomizableEdges = customizableEdges15;
            to.DrawMode = DrawMode.OwnerDrawFixed;
            to.DropDownStyle = ComboBoxStyle.DropDownList;
            to.FillColor = Color.FromArgb(248, 244, 236);
            to.FocusedColor = Color.FromArgb(66, 71, 105);
            to.FocusedState.BorderColor = Color.FromArgb(66, 71, 105);
            to.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            to.ForeColor = Color.FromArgb(66, 71, 105);
            to.HoverState.BorderColor = Color.FromArgb(66, 71, 105);
            to.ItemHeight = 40;
            to.Location = new Point(313, 114);
            to.Name = "to";
            to.ShadowDecoration.BorderRadius = 8;
            to.ShadowDecoration.Color = Color.FromArgb(66, 71, 105);
            to.ShadowDecoration.CustomizableEdges = customizableEdges16;
            to.ShadowDecoration.Depth = 20;
            to.Size = new Size(238, 46);
            to.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.ForeColor = Color.FromArgb(66, 71, 105);
            label3.Location = new Point(323, 95);
            label3.Name = "label3";
            label3.Size = new Size(19, 15);
            label3.TabIndex = 4;
            label3.Text = "To";
            // 
            // guna2Panel1
            // 
            guna2Panel1.BorderColor = Color.FromArgb(66, 71, 105);
            guna2Panel1.BorderRadius = 6;
            guna2Panel1.BorderThickness = 1;
            guna2Panel1.Controls.Add(copy);
            guna2Panel1.Controls.Add(output);
            guna2Panel1.CustomizableEdges = customizableEdges19;
            guna2Panel1.Location = new Point(41, 280);
            guna2Panel1.Name = "guna2Panel1";
            guna2Panel1.ShadowDecoration.CustomizableEdges = customizableEdges20;
            guna2Panel1.Size = new Size(510, 100);
            guna2Panel1.TabIndex = 6;
            // 
            // copy
            // 
            copy.CustomizableEdges = customizableEdges17;
            copy.DisabledState.FillColor = Color.FromArgb(248, 244, 236);
            copy.DisabledState.ForeColor = Color.FromArgb(248, 244, 236);
            copy.DisabledState.Image = (Image)resources.GetObject("resource.Image");
            copy.FillColor = Color.FromArgb(248, 244, 236);
            copy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            copy.ForeColor = Color.White;
            copy.Image = (Image)resources.GetObject("copy.Image");
            copy.Location = new Point(468, 3);
            copy.Name = "copy";
            copy.ShadowDecoration.CustomizableEdges = customizableEdges18;
            copy.Size = new Size(39, 35);
            copy.TabIndex = 7;
            copy.Click += copy_Click;
            // 
            // output
            // 
            output.Font = new Font("Microsoft New Tai Lue", 24F, FontStyle.Regular, GraphicsUnit.Point);
            output.ForeColor = Color.FromArgb(66, 71, 105);
            output.Location = new Point(3, 9);
            output.Name = "output";
            output.Size = new Size(504, 77);
            output.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 244, 236);
            ClientSize = new Size(594, 413);
            Controls.Add(guna2Panel1);
            Controls.Add(to);
            Controls.Add(label3);
            Controls.Add(from);
            Controls.Add(label2);
            Controls.Add(input);
            Controls.Add(label1);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Text to Binary Converter";
            guna2Panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Guna.UI2.WinForms.Guna2TextBox input;
        private Label label2;
        private Guna.UI2.WinForms.Guna2ComboBox from;
        private Guna.UI2.WinForms.Guna2ComboBox to;
        private Label label3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Label output;
        private Guna.UI2.WinForms.Guna2Button copy;
    }
}
