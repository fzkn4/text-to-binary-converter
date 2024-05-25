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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            input = new Guna.UI2.WinForms.Guna2TextBox();
            label2 = new Label();
            from = new Guna.UI2.WinForms.Guna2ComboBox();
            to = new Guna.UI2.WinForms.Guna2ComboBox();
            label3 = new Label();
            copy = new Guna.UI2.WinForms.Guna2Button();
            output = new Guna.UI2.WinForms.Guna2TextBox();
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
            input.CustomizableEdges = customizableEdges1;
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
            input.ShadowDecoration.CustomizableEdges = customizableEdges2;
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
            from.CustomizableEdges = customizableEdges3;
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
            from.ShadowDecoration.CustomizableEdges = customizableEdges4;
            from.ShadowDecoration.Depth = 20;
            from.Size = new Size(238, 46);
            from.TabIndex = 3;
            // 
            // to
            // 
            to.BackColor = Color.Transparent;
            to.BorderColor = Color.FromArgb(66, 71, 105);
            to.BorderRadius = 6;
            to.CustomizableEdges = customizableEdges5;
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
            to.ShadowDecoration.CustomizableEdges = customizableEdges6;
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
            // copy
            // 
            copy.CustomizableEdges = customizableEdges7;
            copy.DisabledState.FillColor = Color.FromArgb(248, 244, 236);
            copy.DisabledState.ForeColor = Color.FromArgb(248, 244, 236);
            copy.DisabledState.Image = (Image)resources.GetObject("resource.Image");
            copy.FillColor = Color.FromArgb(248, 244, 236);
            copy.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            copy.ForeColor = Color.White;
            copy.Image = (Image)resources.GetObject("copy.Image");
            copy.Location = new Point(510, 352);
            copy.Name = "copy";
            copy.ShadowDecoration.CustomizableEdges = customizableEdges8;
            copy.Size = new Size(39, 35);
            copy.TabIndex = 7;
            copy.Click += copy_Click;
            // 
            // output
            // 
            output.Animated = true;
            output.BorderColor = Color.FromArgb(66, 71, 105);
            output.BorderRadius = 6;
            output.CustomizableEdges = customizableEdges9;
            output.DefaultText = "";
            output.DisabledState.BorderColor = Color.FromArgb(66, 71, 105);
            output.DisabledState.FillColor = Color.FromArgb(248, 244, 236);
            output.DisabledState.ForeColor = Color.FromArgb(66, 71, 105);
            output.DisabledState.PlaceholderForeColor = Color.Gray;
            output.Enabled = false;
            output.FillColor = Color.FromArgb(248, 244, 236);
            output.FocusedState.BorderColor = Color.FromArgb(66, 71, 105);
            output.Font = new Font("Microsoft New Tai Lue", 9F, FontStyle.Regular, GraphicsUnit.Point);
            output.ForeColor = Color.FromArgb(66, 71, 105);
            output.HoverState.BorderColor = Color.FromArgb(66, 71, 105);
            output.Location = new Point(41, 280);
            output.Multiline = true;
            output.Name = "output";
            output.PasswordChar = '\0';
            output.PlaceholderForeColor = Color.Gray;
            output.PlaceholderText = "Output";
            output.SelectedText = "";
            output.ShadowDecoration.CustomizableEdges = customizableEdges10;
            output.Size = new Size(510, 109);
            output.TabIndex = 8;
            output.TextOffset = new Point(3, 0);
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(248, 244, 236);
            ClientSize = new Size(594, 431);
            Controls.Add(copy);
            Controls.Add(to);
            Controls.Add(label3);
            Controls.Add(from);
            Controls.Add(label2);
            Controls.Add(input);
            Controls.Add(label1);
            Controls.Add(output);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Text to Binary Converter";
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
        private Guna.UI2.WinForms.Guna2Button copy;
        private Guna.UI2.WinForms.Guna2TextBox output;
    }
}
