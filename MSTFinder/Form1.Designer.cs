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
            this.button_search_ = new System.Windows.Forms.Button();
            this.radioButton_Prim = new System.Windows.Forms.RadioButton();
            this.radioButton_Kruskal = new System.Windows.Forms.RadioButton();
            this.buttonSolve = new System.Windows.Forms.Button();
            this.labelNotif = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox_filename = new System.Windows.Forms.TextBox();
            this.button_visualize = new System.Windows.Forms.Button();
            this.textBox_addNode = new System.Windows.Forms.TextBox();
            this.buttonAddNode = new System.Windows.Forms.Button();
            this.label_newnode = new System.Windows.Forms.Label();
            this.label_newedge = new System.Windows.Forms.Label();
            this.buttonAddEdge = new System.Windows.Forms.Button();
            this.labelN1 = new System.Windows.Forms.Label();
            this.listBoxN1 = new System.Windows.Forms.ListBox();
            this.labelN2 = new System.Windows.Forms.Label();
            this.label_weight = new System.Windows.Forms.Label();
            this.listBoxN2 = new System.Windows.Forms.ListBox();
            this.textBoxWeight = new System.Windows.Forms.TextBox();
            this.listBoxDelNode = new System.Windows.Forms.ListBox();
            this.buttonDelNode = new System.Windows.Forms.Button();
            this.label_clustering = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.labelN = new System.Windows.Forms.Label();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.buttonMakeCluster = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_MSTFinder
            // 
            this.label_MSTFinder.AutoSize = true;
            this.label_MSTFinder.BackColor = System.Drawing.Color.Transparent;
            this.label_MSTFinder.Font = new System.Drawing.Font("Lucida Sans", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_MSTFinder.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_MSTFinder.Location = new System.Drawing.Point(459, 31);
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
            this.label_output.Location = new System.Drawing.Point(391, 126);
            this.label_output.Name = "label_output";
            this.label_output.Size = new System.Drawing.Size(106, 29);
            this.label_output.TabIndex = 2;
            this.label_output.Text = "Output";
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
            this.button_search_.Location = new System.Drawing.Point(70, 200);
            this.button_search_.Name = "button_search_";
            this.button_search_.Size = new System.Drawing.Size(91, 45);
            this.button_search_.TabIndex = 5;
            this.button_search_.UseVisualStyleBackColor = false;
            this.button_search_.Click += new System.EventHandler(this.button_search__Click);
            // 
            // radioButton_Prim
            // 
            this.radioButton_Prim.AutoSize = true;
            this.radioButton_Prim.BackColor = System.Drawing.Color.Transparent;
            this.radioButton_Prim.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButton_Prim.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.radioButton_Prim.Location = new System.Drawing.Point(73, 635);
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
            this.radioButton_Kruskal.Location = new System.Drawing.Point(169, 635);
            this.radioButton_Kruskal.Name = "radioButton_Kruskal";
            this.radioButton_Kruskal.Size = new System.Drawing.Size(100, 33);
            this.radioButton_Kruskal.TabIndex = 7;
            this.radioButton_Kruskal.TabStop = true;
            this.radioButton_Kruskal.Text = "Kruskal";
            this.radioButton_Kruskal.UseVisualStyleBackColor = false;
            // 
            // buttonSolve
            // 
            this.buttonSolve.AutoSize = true;
            this.buttonSolve.BackColor = System.Drawing.Color.Transparent;
            this.buttonSolve.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSolve.FlatAppearance.BorderSize = 0;
            this.buttonSolve.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonSolve.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonSolve.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSolve.Image = ((System.Drawing.Image)(resources.GetObject("buttonSolve.Image")));
            this.buttonSolve.Location = new System.Drawing.Point(296, 631);
            this.buttonSolve.Name = "buttonSolve";
            this.buttonSolve.Size = new System.Drawing.Size(91, 45);
            this.buttonSolve.TabIndex = 8;
            this.buttonSolve.UseVisualStyleBackColor = false;
            this.buttonSolve.Click += new System.EventHandler(this.buttonSolve_Click);
            // 
            // labelNotif
            // 
            this.labelNotif.AutoSize = true;
            this.labelNotif.BackColor = System.Drawing.Color.Transparent;
            this.labelNotif.Font = new System.Drawing.Font("Gill Sans MT", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNotif.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelNotif.Location = new System.Drawing.Point(407, 600);
            this.labelNotif.MaximumSize = new System.Drawing.Size(500, 0);
            this.labelNotif.Name = "labelNotif";
            this.labelNotif.Size = new System.Drawing.Size(0, 29);
            this.labelNotif.TabIndex = 9;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(396, 165);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(380, 415);
            this.panel1.TabIndex = 11;
            // 
            // textBox_filename
            // 
            this.textBox_filename.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_filename.Location = new System.Drawing.Point(72, 161);
            this.textBox_filename.Name = "textBox_filename";
            this.textBox_filename.ReadOnly = true;
            this.textBox_filename.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_filename.Size = new System.Drawing.Size(237, 26);
            this.textBox_filename.TabIndex = 12;
            // 
            // button_visualize
            // 
            this.button_visualize.AutoSize = true;
            this.button_visualize.BackColor = System.Drawing.Color.Transparent;
            this.button_visualize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_visualize.FlatAppearance.BorderSize = 0;
            this.button_visualize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button_visualize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button_visualize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_visualize.Image = ((System.Drawing.Image)(resources.GetObject("button_visualize.Image")));
            this.button_visualize.Location = new System.Drawing.Point(195, 200);
            this.button_visualize.Name = "button_visualize";
            this.button_visualize.Size = new System.Drawing.Size(91, 45);
            this.button_visualize.TabIndex = 13;
            this.button_visualize.UseVisualStyleBackColor = false;
            this.button_visualize.Click += new System.EventHandler(this.button_visualize_Click);
            // 
            // textBox_addNode
            // 
            this.textBox_addNode.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBox_addNode.Location = new System.Drawing.Point(73, 297);
            this.textBox_addNode.Name = "textBox_addNode";
            this.textBox_addNode.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox_addNode.Size = new System.Drawing.Size(88, 26);
            this.textBox_addNode.TabIndex = 14;
            // 
            // buttonAddNode
            // 
            this.buttonAddNode.AutoSize = true;
            this.buttonAddNode.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddNode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddNode.FlatAppearance.BorderSize = 0;
            this.buttonAddNode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAddNode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAddNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddNode.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddNode.Image")));
            this.buttonAddNode.Location = new System.Drawing.Point(179, 288);
            this.buttonAddNode.Name = "buttonAddNode";
            this.buttonAddNode.Size = new System.Drawing.Size(116, 45);
            this.buttonAddNode.TabIndex = 15;
            this.buttonAddNode.UseVisualStyleBackColor = false;
            this.buttonAddNode.Click += new System.EventHandler(this.buttonAddNode_Click);
            // 
            // label_newnode
            // 
            this.label_newnode.AutoSize = true;
            this.label_newnode.BackColor = System.Drawing.Color.Transparent;
            this.label_newnode.Font = new System.Drawing.Font("STXinwei", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_newnode.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_newnode.Location = new System.Drawing.Point(69, 268);
            this.label_newnode.Name = "label_newnode";
            this.label_newnode.Size = new System.Drawing.Size(164, 17);
            this.label_newnode.TabIndex = 16;
            this.label_newnode.Text = "Node configuration";
            // 
            // label_newedge
            // 
            this.label_newedge.AutoSize = true;
            this.label_newedge.BackColor = System.Drawing.Color.Transparent;
            this.label_newedge.Font = new System.Drawing.Font("STXinwei", 7.999999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_newedge.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_newedge.Location = new System.Drawing.Point(68, 431);
            this.label_newedge.Name = "label_newedge";
            this.label_newedge.Size = new System.Drawing.Size(157, 17);
            this.label_newedge.TabIndex = 19;
            this.label_newedge.Text = "Edge configuration";
            // 
            // buttonAddEdge
            // 
            this.buttonAddEdge.AutoSize = true;
            this.buttonAddEdge.BackColor = System.Drawing.Color.Transparent;
            this.buttonAddEdge.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonAddEdge.FlatAppearance.BorderSize = 0;
            this.buttonAddEdge.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonAddEdge.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonAddEdge.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddEdge.Image = ((System.Drawing.Image)(resources.GetObject("buttonAddEdge.Image")));
            this.buttonAddEdge.Location = new System.Drawing.Point(66, 563);
            this.buttonAddEdge.Name = "buttonAddEdge";
            this.buttonAddEdge.Size = new System.Drawing.Size(116, 45);
            this.buttonAddEdge.TabIndex = 18;
            this.buttonAddEdge.UseVisualStyleBackColor = false;
            this.buttonAddEdge.Click += new System.EventHandler(this.buttonAddEdge_Click);
            // 
            // labelN1
            // 
            this.labelN1.AutoSize = true;
            this.labelN1.BackColor = System.Drawing.Color.Transparent;
            this.labelN1.Font = new System.Drawing.Font("STXinwei", 7.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelN1.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelN1.Location = new System.Drawing.Point(70, 455);
            this.labelN1.Name = "labelN1";
            this.labelN1.Size = new System.Drawing.Size(27, 17);
            this.labelN1.TabIndex = 20;
            this.labelN1.Text = "N1";
            // 
            // listBoxN1
            // 
            this.listBoxN1.FormattingEnabled = true;
            this.listBoxN1.ItemHeight = 20;
            this.listBoxN1.Location = new System.Drawing.Point(70, 479);
            this.listBoxN1.Name = "listBoxN1";
            this.listBoxN1.Size = new System.Drawing.Size(89, 64);
            this.listBoxN1.TabIndex = 21;
            // 
            // labelN2
            // 
            this.labelN2.AutoSize = true;
            this.labelN2.BackColor = System.Drawing.Color.Transparent;
            this.labelN2.Font = new System.Drawing.Font("STXinwei", 7.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelN2.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelN2.Location = new System.Drawing.Point(180, 455);
            this.labelN2.Name = "labelN2";
            this.labelN2.Size = new System.Drawing.Size(30, 17);
            this.labelN2.TabIndex = 22;
            this.labelN2.Text = "N2";
            // 
            // label_weight
            // 
            this.label_weight.AutoSize = true;
            this.label_weight.BackColor = System.Drawing.Color.Transparent;
            this.label_weight.Font = new System.Drawing.Font("STXinwei", 7.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_weight.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_weight.Location = new System.Drawing.Point(291, 455);
            this.label_weight.Name = "label_weight";
            this.label_weight.Size = new System.Drawing.Size(58, 17);
            this.label_weight.TabIndex = 23;
            this.label_weight.Text = "Weight";
            // 
            // listBoxN2
            // 
            this.listBoxN2.FormattingEnabled = true;
            this.listBoxN2.ItemHeight = 20;
            this.listBoxN2.Location = new System.Drawing.Point(183, 479);
            this.listBoxN2.Name = "listBoxN2";
            this.listBoxN2.Size = new System.Drawing.Size(91, 64);
            this.listBoxN2.TabIndex = 24;
            // 
            // textBoxWeight
            // 
            this.textBoxWeight.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxWeight.Location = new System.Drawing.Point(296, 479);
            this.textBoxWeight.Name = "textBoxWeight";
            this.textBoxWeight.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxWeight.Size = new System.Drawing.Size(60, 26);
            this.textBoxWeight.TabIndex = 25;
            // 
            // listBoxDelNode
            // 
            this.listBoxDelNode.FormattingEnabled = true;
            this.listBoxDelNode.ItemHeight = 20;
            this.listBoxDelNode.Location = new System.Drawing.Point(72, 342);
            this.listBoxDelNode.Name = "listBoxDelNode";
            this.listBoxDelNode.Size = new System.Drawing.Size(89, 64);
            this.listBoxDelNode.TabIndex = 26;
            // 
            // buttonDelNode
            // 
            this.buttonDelNode.AutoSize = true;
            this.buttonDelNode.BackColor = System.Drawing.Color.Transparent;
            this.buttonDelNode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDelNode.FlatAppearance.BorderSize = 0;
            this.buttonDelNode.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonDelNode.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonDelNode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDelNode.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelNode.Image")));
            this.buttonDelNode.Location = new System.Drawing.Point(179, 339);
            this.buttonDelNode.Name = "buttonDelNode";
            this.buttonDelNode.Size = new System.Drawing.Size(116, 45);
            this.buttonDelNode.TabIndex = 27;
            this.buttonDelNode.UseVisualStyleBackColor = false;
            this.buttonDelNode.Click += new System.EventHandler(this.buttonDelNode_Click);
            // 
            // label_clustering
            // 
            this.label_clustering.AutoSize = true;
            this.label_clustering.BackColor = System.Drawing.Color.Transparent;
            this.label_clustering.Font = new System.Drawing.Font("STXinwei", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label_clustering.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.label_clustering.Location = new System.Drawing.Point(813, 126);
            this.label_clustering.Name = "label_clustering";
            this.label_clustering.Size = new System.Drawing.Size(143, 29);
            this.label_clustering.TabIndex = 28;
            this.label_clustering.Text = "Clustering";
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(818, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(406, 367);
            this.panel2.TabIndex = 12;
            // 
            // labelN
            // 
            this.labelN.AutoSize = true;
            this.labelN.BackColor = System.Drawing.Color.Transparent;
            this.labelN.Font = new System.Drawing.Font("STXinwei", 7.999999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.labelN.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelN.Location = new System.Drawing.Point(818, 170);
            this.labelN.Name = "labelN";
            this.labelN.Size = new System.Drawing.Size(30, 17);
            this.labelN.TabIndex = 29;
            this.labelN.Text = "N :";
            // 
            // textBoxN
            // 
            this.textBoxN.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.textBoxN.Location = new System.Drawing.Point(854, 165);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBoxN.Size = new System.Drawing.Size(60, 26);
            this.textBoxN.TabIndex = 30;
            // 
            // buttonMakeCluster
            // 
            this.buttonMakeCluster.AutoSize = true;
            this.buttonMakeCluster.BackColor = System.Drawing.Color.Transparent;
            this.buttonMakeCluster.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonMakeCluster.FlatAppearance.BorderSize = 0;
            this.buttonMakeCluster.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.buttonMakeCluster.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.buttonMakeCluster.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonMakeCluster.Image = ((System.Drawing.Image)(resources.GetObject("buttonMakeCluster.Image")));
            this.buttonMakeCluster.Location = new System.Drawing.Point(952, 156);
            this.buttonMakeCluster.Name = "buttonMakeCluster";
            this.buttonMakeCluster.Size = new System.Drawing.Size(116, 45);
            this.buttonMakeCluster.TabIndex = 31;
            this.buttonMakeCluster.UseVisualStyleBackColor = false;
            this.buttonMakeCluster.Click += new System.EventHandler(this.buttonMakeCluster_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(1278, 754);
            this.Controls.Add(this.buttonMakeCluster);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.labelN);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.label_clustering);
            this.Controls.Add(this.buttonDelNode);
            this.Controls.Add(this.listBoxDelNode);
            this.Controls.Add(this.textBoxWeight);
            this.Controls.Add(this.listBoxN2);
            this.Controls.Add(this.label_weight);
            this.Controls.Add(this.labelN2);
            this.Controls.Add(this.listBoxN1);
            this.Controls.Add(this.labelN1);
            this.Controls.Add(this.label_newedge);
            this.Controls.Add(this.buttonAddEdge);
            this.Controls.Add(this.label_newnode);
            this.Controls.Add(this.buttonAddNode);
            this.Controls.Add(this.textBox_addNode);
            this.Controls.Add(this.button_visualize);
            this.Controls.Add(this.textBox_filename);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.labelNotif);
            this.Controls.Add(this.buttonSolve);
            this.Controls.Add(this.radioButton_Kruskal);
            this.Controls.Add(this.radioButton_Prim);
            this.Controls.Add(this.button_search_);
            this.Controls.Add(this.label_output);
            this.Controls.Add(this.label_input);
            this.Controls.Add(this.label_MSTFinder);
            this.MaximumSize = new System.Drawing.Size(1300, 900);
            this.Name = "Form1";
            this.Text = "MST Finder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_MSTFinder;
        private System.Windows.Forms.Label label_input;
        private System.Windows.Forms.Label label_output;
        private System.Windows.Forms.Button button_search_;
        private System.Windows.Forms.RadioButton radioButton_Prim;
        private System.Windows.Forms.RadioButton radioButton_Kruskal;
        private System.Windows.Forms.Button buttonSolve;
        private System.Windows.Forms.Label labelNotif;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox_filename;
        private System.Windows.Forms.Button button_visualize;
        private System.Windows.Forms.TextBox textBox_addNode;
        private System.Windows.Forms.Button buttonAddNode;
        private System.Windows.Forms.Label label_newnode;
        private System.Windows.Forms.Label label_newedge;
        private System.Windows.Forms.Button buttonAddEdge;
        private System.Windows.Forms.Label labelN1;
        private System.Windows.Forms.ListBox listBoxN1;
        private System.Windows.Forms.Label labelN2;
        private System.Windows.Forms.Label label_weight;
        private System.Windows.Forms.ListBox listBoxN2;
        private System.Windows.Forms.TextBox textBoxWeight;
        private System.Windows.Forms.ListBox listBoxDelNode;
        private System.Windows.Forms.Button buttonDelNode;
        private System.Windows.Forms.Label label_clustering;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label labelN;
        private System.Windows.Forms.TextBox textBoxN;
        private System.Windows.Forms.Button buttonMakeCluster;
    }
}

