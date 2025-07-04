namespace Pizza_Project
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
            this.label1 = new System.Windows.Forms.Label();
            this.gbSize = new System.Windows.Forms.GroupBox();
            this.rbLarge = new System.Windows.Forms.RadioButton();
            this.rbMeduim = new System.Windows.Forms.RadioButton();
            this.rbSmall = new System.Windows.Forms.RadioButton();
            this.gbCrustType = new System.Windows.Forms.GroupBox();
            this.rbThink = new System.Windows.Forms.RadioButton();
            this.rbThin = new System.Windows.Forms.RadioButton();
            this.gbWhereToEat = new System.Windows.Forms.GroupBox();
            this.rbTakeOut = new System.Windows.Forms.RadioButton();
            this.rbEatIn = new System.Windows.Forms.RadioButton();
            this.gbToppings = new System.Windows.Forms.GroupBox();
            this.cbGreenPeppers = new System.Windows.Forms.CheckBox();
            this.cbOlives = new System.Windows.Forms.CheckBox();
            this.cbOnion = new System.Windows.Forms.CheckBox();
            this.cbTomatoes = new System.Windows.Forms.CheckBox();
            this.cbMushrooms = new System.Windows.Forms.CheckBox();
            this.cbExtraCheese = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalPrice = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblWhereToEat = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblCrustType = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblToppings = new System.Windows.Forms.Label();
            this.lbToppings = new System.Windows.Forms.Label();
            this.lblSize = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOrderPizza = new System.Windows.Forms.Button();
            this.btnResetForm = new System.Windows.Forms.Button();
            this.gbSize.SuspendLayout();
            this.gbCrustType.SuspendLayout();
            this.gbWhereToEat.SuspendLayout();
            this.gbToppings.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Name = "label1";
            // 
            // gbSize
            // 
            this.gbSize.Controls.Add(this.rbLarge);
            this.gbSize.Controls.Add(this.rbMeduim);
            this.gbSize.Controls.Add(this.rbSmall);
            resources.ApplyResources(this.gbSize, "gbSize");
            this.gbSize.Name = "gbSize";
            this.gbSize.TabStop = false;
            // 
            // rbLarge
            // 
            resources.ApplyResources(this.rbLarge, "rbLarge");
            this.rbLarge.Name = "rbLarge";
            this.rbLarge.UseVisualStyleBackColor = true;
            this.rbLarge.CheckedChanged += new System.EventHandler(this.rbLarge_CheckedChanged);
            // 
            // rbMeduim
            // 
            resources.ApplyResources(this.rbMeduim, "rbMeduim");
            this.rbMeduim.Checked = true;
            this.rbMeduim.Name = "rbMeduim";
            this.rbMeduim.TabStop = true;
            this.rbMeduim.UseVisualStyleBackColor = true;
            this.rbMeduim.CheckedChanged += new System.EventHandler(this.rbMeduim_CheckedChanged);
            // 
            // rbSmall
            // 
            resources.ApplyResources(this.rbSmall, "rbSmall");
            this.rbSmall.Name = "rbSmall";
            this.rbSmall.UseVisualStyleBackColor = true;
            this.rbSmall.CheckedChanged += new System.EventHandler(this.rbSmall_CheckedChanged);
            // 
            // gbCrustType
            // 
            this.gbCrustType.Controls.Add(this.rbThink);
            this.gbCrustType.Controls.Add(this.rbThin);
            resources.ApplyResources(this.gbCrustType, "gbCrustType");
            this.gbCrustType.Name = "gbCrustType";
            this.gbCrustType.TabStop = false;
            // 
            // rbThink
            // 
            resources.ApplyResources(this.rbThink, "rbThink");
            this.rbThink.Name = "rbThink";
            this.rbThink.UseVisualStyleBackColor = true;
            this.rbThink.CheckedChanged += new System.EventHandler(this.rbThick_CheckedChanged);
            // 
            // rbThin
            // 
            resources.ApplyResources(this.rbThin, "rbThin");
            this.rbThin.Checked = true;
            this.rbThin.Name = "rbThin";
            this.rbThin.TabStop = true;
            this.rbThin.UseVisualStyleBackColor = true;
            this.rbThin.CheckedChanged += new System.EventHandler(this.rbThin_CheckedChanged);
            // 
            // gbWhereToEat
            // 
            this.gbWhereToEat.Controls.Add(this.rbTakeOut);
            this.gbWhereToEat.Controls.Add(this.rbEatIn);
            resources.ApplyResources(this.gbWhereToEat, "gbWhereToEat");
            this.gbWhereToEat.Name = "gbWhereToEat";
            this.gbWhereToEat.TabStop = false;
            // 
            // rbTakeOut
            // 
            resources.ApplyResources(this.rbTakeOut, "rbTakeOut");
            this.rbTakeOut.Name = "rbTakeOut";
            this.rbTakeOut.UseVisualStyleBackColor = true;
            this.rbTakeOut.CheckedChanged += new System.EventHandler(this.rbTakeOut_CheckedChanged);
            // 
            // rbEatIn
            // 
            resources.ApplyResources(this.rbEatIn, "rbEatIn");
            this.rbEatIn.Checked = true;
            this.rbEatIn.Name = "rbEatIn";
            this.rbEatIn.TabStop = true;
            this.rbEatIn.UseVisualStyleBackColor = true;
            this.rbEatIn.CheckedChanged += new System.EventHandler(this.rbEatIn_CheckedChanged);
            // 
            // gbToppings
            // 
            this.gbToppings.Controls.Add(this.cbGreenPeppers);
            this.gbToppings.Controls.Add(this.cbOlives);
            this.gbToppings.Controls.Add(this.cbOnion);
            this.gbToppings.Controls.Add(this.cbTomatoes);
            this.gbToppings.Controls.Add(this.cbMushrooms);
            this.gbToppings.Controls.Add(this.cbExtraCheese);
            resources.ApplyResources(this.gbToppings, "gbToppings");
            this.gbToppings.Name = "gbToppings";
            this.gbToppings.TabStop = false;
            // 
            // cbGreenPeppers
            // 
            resources.ApplyResources(this.cbGreenPeppers, "cbGreenPeppers");
            this.cbGreenPeppers.Name = "cbGreenPeppers";
            this.cbGreenPeppers.UseVisualStyleBackColor = true;
            this.cbGreenPeppers.CheckedChanged += new System.EventHandler(this.cbGreenPeppers_CheckedChanged);
            // 
            // cbOlives
            // 
            resources.ApplyResources(this.cbOlives, "cbOlives");
            this.cbOlives.Name = "cbOlives";
            this.cbOlives.UseVisualStyleBackColor = true;
            this.cbOlives.CheckedChanged += new System.EventHandler(this.cbOlives_CheckedChanged);
            // 
            // cbOnion
            // 
            resources.ApplyResources(this.cbOnion, "cbOnion");
            this.cbOnion.Name = "cbOnion";
            this.cbOnion.UseVisualStyleBackColor = true;
            this.cbOnion.CheckedChanged += new System.EventHandler(this.cbOnion_CheckedChanged);
            // 
            // cbTomatoes
            // 
            resources.ApplyResources(this.cbTomatoes, "cbTomatoes");
            this.cbTomatoes.Name = "cbTomatoes";
            this.cbTomatoes.UseVisualStyleBackColor = true;
            this.cbTomatoes.CheckedChanged += new System.EventHandler(this.cbTomatoes_CheckedChanged);
            // 
            // cbMushrooms
            // 
            resources.ApplyResources(this.cbMushrooms, "cbMushrooms");
            this.cbMushrooms.Name = "cbMushrooms";
            this.cbMushrooms.UseVisualStyleBackColor = true;
            this.cbMushrooms.CheckedChanged += new System.EventHandler(this.cbMushrooms_CheckedChanged);
            // 
            // cbExtraCheese
            // 
            resources.ApplyResources(this.cbExtraCheese, "cbExtraCheese");
            this.cbExtraCheese.Name = "cbExtraCheese";
            this.cbExtraCheese.UseVisualStyleBackColor = true;
            this.cbExtraCheese.CheckedChanged += new System.EventHandler(this.cbExtraChees_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalPrice);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblWhereToEat);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.lblCrustType);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.lblToppings);
            this.groupBox1.Controls.Add(this.lbToppings);
            this.groupBox1.Controls.Add(this.lblSize);
            this.groupBox1.Controls.Add(this.label2);
            resources.ApplyResources(this.groupBox1, "groupBox1");
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.TabStop = false;
            // 
            // lblTotalPrice
            // 
            resources.ApplyResources(this.lblTotalPrice, "lblTotalPrice");
            this.lblTotalPrice.ForeColor = System.Drawing.Color.Green;
            this.lblTotalPrice.Name = "lblTotalPrice";
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // lblWhereToEat
            // 
            resources.ApplyResources(this.lblWhereToEat, "lblWhereToEat");
            this.lblWhereToEat.Name = "lblWhereToEat";
            // 
            // label8
            // 
            resources.ApplyResources(this.label8, "label8");
            this.label8.Name = "label8";
            // 
            // lblCrustType
            // 
            resources.ApplyResources(this.lblCrustType, "lblCrustType");
            this.lblCrustType.Name = "lblCrustType";
            // 
            // label6
            // 
            resources.ApplyResources(this.label6, "label6");
            this.label6.Name = "label6";
            // 
            // lblToppings
            // 
            resources.ApplyResources(this.lblToppings, "lblToppings");
            this.lblToppings.Name = "lblToppings";
            // 
            // lbToppings
            // 
            resources.ApplyResources(this.lbToppings, "lbToppings");
            this.lbToppings.Name = "lbToppings";
            // 
            // lblSize
            // 
            resources.ApplyResources(this.lblSize, "lblSize");
            this.lblSize.Name = "lblSize";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // btnOrderPizza
            // 
            this.btnOrderPizza.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnOrderPizza, "btnOrderPizza");
            this.btnOrderPizza.Name = "btnOrderPizza";
            this.btnOrderPizza.UseVisualStyleBackColor = true;
            this.btnOrderPizza.Click += new System.EventHandler(this.btnOrderPizza_Click);
            // 
            // btnResetForm
            // 
            this.btnResetForm.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            resources.ApplyResources(this.btnResetForm, "btnResetForm");
            this.btnResetForm.Name = "btnResetForm";
            this.btnResetForm.UseVisualStyleBackColor = true;
            this.btnResetForm.Click += new System.EventHandler(this.btnResetForm_Click);
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Wheat;
            this.Controls.Add(this.btnResetForm);
            this.Controls.Add(this.btnOrderPizza);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gbToppings);
            this.Controls.Add(this.gbWhereToEat);
            this.Controls.Add(this.gbCrustType);
            this.Controls.Add(this.gbSize);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.gbSize.ResumeLayout(false);
            this.gbSize.PerformLayout();
            this.gbCrustType.ResumeLayout(false);
            this.gbCrustType.PerformLayout();
            this.gbWhereToEat.ResumeLayout(false);
            this.gbWhereToEat.PerformLayout();
            this.gbToppings.ResumeLayout(false);
            this.gbToppings.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox gbSize;
        private System.Windows.Forms.RadioButton rbLarge;
        private System.Windows.Forms.RadioButton rbMeduim;
        private System.Windows.Forms.RadioButton rbSmall;
        private System.Windows.Forms.GroupBox gbCrustType;
        private System.Windows.Forms.RadioButton rbThink;
        private System.Windows.Forms.RadioButton rbThin;
        private System.Windows.Forms.GroupBox gbWhereToEat;
        private System.Windows.Forms.RadioButton rbTakeOut;
        private System.Windows.Forms.RadioButton rbEatIn;
        private System.Windows.Forms.GroupBox gbToppings;
        private System.Windows.Forms.CheckBox cbGreenPeppers;
        private System.Windows.Forms.CheckBox cbOlives;
        private System.Windows.Forms.CheckBox cbOnion;
        private System.Windows.Forms.CheckBox cbTomatoes;
        private System.Windows.Forms.CheckBox cbMushrooms;
        private System.Windows.Forms.CheckBox cbExtraCheese;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbToppings;
        private System.Windows.Forms.Label lblCrustType;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblToppings;
        private System.Windows.Forms.Label lblWhereToEat;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblTotalPrice;
        private System.Windows.Forms.Button btnOrderPizza;
        private System.Windows.Forms.Button btnResetForm;
    }
}

