namespace Clothing_Store
{
    partial class Shoes_Area
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Shoes_Area));
            Bt_Generate = new Button();
            Tb_Result = new TextBox();
            Cbo_Shoes = new ComboBox();
            Cbo_Color = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            SuspendLayout();
            // 
            // Bt_Generate
            // 
            Bt_Generate.Location = new Point(12, 158);
            Bt_Generate.Name = "Bt_Generate";
            Bt_Generate.Size = new Size(151, 29);
            Bt_Generate.TabIndex = 3;
            Bt_Generate.Text = "To generate";
            Bt_Generate.UseVisualStyleBackColor = true;
            Bt_Generate.Click += Bt_Generate_Click;
            // 
            // Tb_Result
            // 
            Tb_Result.Enabled = false;
            Tb_Result.Location = new Point(226, 158);
            Tb_Result.Name = "Tb_Result";
            Tb_Result.Size = new Size(151, 27);
            Tb_Result.TabIndex = 9;
            // 
            // Cbo_Shoes
            // 
            Cbo_Shoes.FormattingEnabled = true;
            Cbo_Shoes.Items.AddRange(new object[] { "Jordan 4 ", "Polo ", "Maluvas " });
            Cbo_Shoes.Location = new Point(12, 62);
            Cbo_Shoes.Name = "Cbo_Shoes";
            Cbo_Shoes.Size = new Size(151, 28);
            Cbo_Shoes.TabIndex = 1;
            // 
            // Cbo_Color
            // 
            Cbo_Color.FormattingEnabled = true;
            Cbo_Color.Items.AddRange(new object[] { "Red ", "White ", "Black " });
            Cbo_Color.Location = new Point(226, 62);
            Cbo_Color.Name = "Cbo_Color";
            Cbo_Color.Size = new Size(151, 28);
            Cbo_Color.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 39);
            label1.Name = "label1";
            label1.Size = new Size(133, 20);
            label1.TabIndex = 13;
            label1.Text = "Choose the Shoes :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(226, 39);
            label2.Name = "label2";
            label2.Size = new Size(128, 20);
            label2.TabIndex = 14;
            label2.Text = "Choose the color :";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(226, 135);
            label3.Name = "label3";
            label3.Size = new Size(128, 20);
            label3.TabIndex = 15;
            label3.Text = "Generated Shoes :";
            // 
            // Shoes_Area
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(393, 234);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Cbo_Color);
            Controls.Add(Cbo_Shoes);
            Controls.Add(Tb_Result);
            Controls.Add(Bt_Generate);
            Icon = (Icon)resources.GetObject("$this.Icon");
            MinimizeBox = false;
            Name = "Shoes_Area";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Shoes Generated";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Bt_Generate;
        private TextBox Tb_Result;
        private ComboBox Cbo_Shoes;
        private ComboBox Cbo_Color;
        private Label label1;
        private Label label2;
        private Label label3;
    }
}