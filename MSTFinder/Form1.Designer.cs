namespace MSTFinder
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label_MSTFinder = new System.Windows.Forms.Label();
            this.label_input = new System.Windows.Forms.Label();
            this.label_output = new System.Windows.Forms.Label();
            this.label_filename = new System.Windows.Forms.Label();
            this.button_search_ = new System.Windows.Forms.Button();
            this.radioButton_Prim = new System.Windows.Forms.RadioButton();
            this.radioButton_Kruskal = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label_MSTFinder
            // 
            this.label_MSTFinder.AutoSize = true;
            this.label_MSTFinder.BackColor = System.Drawing.Color.Transparent;
            this.label_MSTFinder.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MSTFinder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_MSTFinder.Location = new System.Drawing.Point(335, 32);
            this.label_MSTFinder.Name = "label_MSTFinder";
            this.label_MSTFinder.Size = new System.Drawing.Size(299, 55);
            this.label_MSTFinder.TabIndex = 0;
            this.label_MSTFinder.Text = "MST Finder";
            // 
            // label_input
            // 
            this.label_input.AutoSize = true;
            this.label_input.BackColor = System.Drawing.Color.Transparent;
            this.label_input.Font = new System.Drawing.Font("STXinwei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_input.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_input.Location = new System.Drawing.Point(67, 126);
            this.label_input.Name = "label_input";
            this.label_input.Size = new System.Drawing.Size(82, 29);
            this.label_input.TabIndex = 1;
            this.label_input.Text = "Input";
            // 
            // label_output
            // 
            this.label_output.AutoSize = true;
            this.label_output.BackColor = System.Drawing.Color.Transparent;
            this.label_output.Font = new System.Drawing.Font("STXinwei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_output.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_output.Location = new System.Drawing.Point(365, 126);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(106, 29);
            this.label_output.TabIndex = 2;
            this.label_output.Text = "Output";
            // 
            // label_filename
            // 
            this.label_filename.AutoSize = true;
            this.label_filename.BackColor = System.Drawing.Color.Transparent;
            this.label_filename.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_filename.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_filename.Location = new System.Drawing.Point(67, 158);
            this.label_filename.Name = "label_filename";
            this.label_filename.Size = new System.Drawing.Size(94, 29);
            this.label_filename.TabIndex = 3;
            this.label_filename.Text = "<filname>";
            // 
            // button_search_
            // 
            this.button_search_.AutoSize = true;
            this.button_search_.BackColor = System.Drawing.Color.Transparent;
            this.button_search_.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_search_.FlatAppearance.BorderSize = 0;
            this.button_search_.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_search_.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_search_.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_search_.Image = ((System.Drawing.Image)(resources.GetObject("button_search_.Image")));
            this.button_search_.Location = new System.Drawing.Point(70, 190);
            this.button_search_.Name = "button_search_";
            this.button_search_.Size = new System.Drawing.Size(91, 45);
            this.button_search_.TabIndex = 5;
            this.button_search_.UseVisualStyleBackColor = false;
            // 
            // radioButton_Prim
            // 
            this.radioButton_Prim.AutoSize = true;
            this.radioButton_Prim.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Prim.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Prim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton_Prim.Location = new System.Drawing.Point(72, 258);
            this.radioButton_Prim.Name = "radioButton_Prim";
            this.radioButton_Prim.Size = new System.Drawing.Size(75, 33);
            this.radioButton_Prim.TabIndex = 6;
            this.radioButton_Prim.TabStop = true;
            this.radioButton_Prim.Text = "Prim";
            this.radioButton_Prim.UseVisualStyleBackColor = false;
            // 
            // radioButton_Kruskal
            // 
            this.radioButton_Kruskal.AutoSize = true;
            this.radioButton_Kruskal.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Kruskal.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Kruskal.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton_Kruskal.Location = new System.Drawing.Point(72, 297);
            this.radioButton_Kruskal.Name = "radioButton_Kruskal";
            this.radioButton_Kruskal.Size = new System.Drawing.Size(100, 33);
            this.radioButton_Kruskal.TabIndex = 7;
            this.radioButton_Kruskal.TabStop = true;
            this.radioButton_Kruskal.Text = "Kruskal";
            this.radioButton_Kruskal.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.AutoSize = true;
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(70, 336);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 45);
            this.button1.TabIndex = 8;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label1.Location = new System.Drawing.Point(67, 401);
            this.label1.MaximumSize = new System.Drawing.Size(250, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 58);
            this.label1.TabIndex = 9;
            this.label1.Text = "awok awoka aowkaowk awoalwoka aowkaow";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(978, 544);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.radioButton_Kruskal);
            this.Controls.Add(this.radioButton_Prim);
            this.Controls.Add(this.button_search_);
            this.Controls.Add(this.label_filename);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.label_MSTFinder);
            this.Name = "Form1";
            this.Text = "MST Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MSTFinder;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.Label label_filename;
        private System.Windows.Forms.Button button_search_;
        private System.Windows.Forms.RadioButton radioButton_Prim;
        private System.Windows.Forms.RadioButton radioButton_Kruskal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

