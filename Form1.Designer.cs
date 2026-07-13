namespace Project_Pizza
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
            this.Makeyorpizza = new System.Windows.Forms.Label();
            this.GB_Size = new System.Windows.Forms.GroupBox();
            this.RB_larg = new System.Windows.Forms.RadioButton();
            this.RB_Meduim = new System.Windows.Forms.RadioButton();
            this.RBSmall = new System.Windows.Forms.RadioButton();
            this.GB_Crust_Type = new System.Windows.Forms.GroupBox();
            this.RB_Thinkcrust = new System.Windows.Forms.RadioButton();
            this.RB_ThinCrust = new System.Windows.Forms.RadioButton();
            this.GB_Toppings = new System.Windows.Forms.GroupBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.CB_Olives = new System.Windows.Forms.CheckBox();
            this.CB_Onion = new System.Windows.Forms.CheckBox();
            this.CB_Tomatoes = new System.Windows.Forms.CheckBox();
            this.CB_Mushrooms = new System.Windows.Forms.CheckBox();
            this.CB_ExtraCheese = new System.Windows.Forms.CheckBox();
            this.GB_WhereTo = new System.Windows.Forms.GroupBox();
            this.RB_TakeOut = new System.Windows.Forms.RadioButton();
            this.RB_EatIn = new System.Windows.Forms.RadioButton();
            this.GB_OrderSamary = new System.Windows.Forms.GroupBox();
            this.Lbl_Crust = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Label_Price = new System.Windows.Forms.Label();
            this.Lbl_Size = new System.Windows.Forms.Label();
            this.lbl_Toppings = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Total_Price = new System.Windows.Forms.Label();
            this.Crust_Type = new System.Windows.Forms.Label();
            this.Where_To_Eat = new System.Windows.Forms.Label();
            this.Toppings = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.B_OrderPizza = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.backgroundWorker2 = new System.ComponentModel.BackgroundWorker();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.GB_Size.SuspendLayout();
            this.GB_Crust_Type.SuspendLayout();
            this.GB_Toppings.SuspendLayout();
            this.GB_WhereTo.SuspendLayout();
            this.GB_OrderSamary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // Makeyorpizza
            // 
            this.Makeyorpizza.AutoSize = true;
            this.Makeyorpizza.BackColor = System.Drawing.Color.Transparent;
            this.Makeyorpizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Makeyorpizza.Font = new System.Drawing.Font("Ravie", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Makeyorpizza.ForeColor = System.Drawing.Color.Red;
            this.Makeyorpizza.Location = new System.Drawing.Point(259, 9);
            this.Makeyorpizza.Name = "Makeyorpizza";
            this.Makeyorpizza.Size = new System.Drawing.Size(595, 63);
            this.Makeyorpizza.TabIndex = 0;
            this.Makeyorpizza.Text = "Make Your Pizza";
            this.Makeyorpizza.Click += new System.EventHandler(this.Makeyorpizza_Click_1);
            // 
            // GB_Size
            // 
            this.GB_Size.BackColor = System.Drawing.Color.Transparent;
            this.GB_Size.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GB_Size.Controls.Add(this.RB_larg);
            this.GB_Size.Controls.Add(this.RB_Meduim);
            this.GB_Size.Controls.Add(this.RBSmall);
            this.GB_Size.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GB_Size.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Size.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GB_Size.Location = new System.Drawing.Point(51, 154);
            this.GB_Size.Name = "GB_Size";
            this.GB_Size.Size = new System.Drawing.Size(206, 148);
            this.GB_Size.TabIndex = 1;
            this.GB_Size.TabStop = false;
            this.GB_Size.Text = "Size";
            this.GB_Size.Enter += new System.EventHandler(this.GB_Size_Enter);
            // 
            // RB_larg
            // 
            this.RB_larg.AutoSize = true;
            this.RB_larg.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_larg.ForeColor = System.Drawing.Color.Orange;
            this.RB_larg.Location = new System.Drawing.Point(53, 97);
            this.RB_larg.Name = "RB_larg";
            this.RB_larg.Size = new System.Drawing.Size(71, 27);
            this.RB_larg.TabIndex = 2;
            this.RB_larg.TabStop = true;
            this.RB_larg.Tag = "30";
            this.RB_larg.Text = "Larg";
            this.RB_larg.UseVisualStyleBackColor = true;
            this.RB_larg.CheckedChanged += new System.EventHandler(this.RB_larg_CheckedChanged);
            // 
            // RB_Meduim
            // 
            this.RB_Meduim.AutoSize = true;
            this.RB_Meduim.Font = new System.Drawing.Font("Ink Free", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Meduim.ForeColor = System.Drawing.Color.Orange;
            this.RB_Meduim.Location = new System.Drawing.Point(53, 67);
            this.RB_Meduim.Name = "RB_Meduim";
            this.RB_Meduim.Size = new System.Drawing.Size(94, 27);
            this.RB_Meduim.TabIndex = 1;
            this.RB_Meduim.TabStop = true;
            this.RB_Meduim.Tag = "20";
            this.RB_Meduim.Text = "Meduim";
            this.RB_Meduim.UseVisualStyleBackColor = true;
            this.RB_Meduim.CheckedChanged += new System.EventHandler(this.RB_Meduim_CheckedChanged);
            // 
            // RBSmall
            // 
            this.RBSmall.AutoSize = true;
            this.RBSmall.Checked = true;
            this.RBSmall.Font = new System.Drawing.Font("Ink Free", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RBSmall.ForeColor = System.Drawing.Color.Orange;
            this.RBSmall.Location = new System.Drawing.Point(53, 37);
            this.RBSmall.Name = "RBSmall";
            this.RBSmall.Size = new System.Drawing.Size(75, 27);
            this.RBSmall.TabIndex = 0;
            this.RBSmall.TabStop = true;
            this.RBSmall.Tag = "10";
            this.RBSmall.Text = "Small";
            this.RBSmall.UseVisualStyleBackColor = true;
            this.RBSmall.CheckedChanged += new System.EventHandler(this.RBSmall_CheckedChanged);
            // 
            // GB_Crust_Type
            // 
            this.GB_Crust_Type.BackColor = System.Drawing.Color.Transparent;
            this.GB_Crust_Type.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GB_Crust_Type.Controls.Add(this.RB_Thinkcrust);
            this.GB_Crust_Type.Controls.Add(this.RB_ThinCrust);
            this.GB_Crust_Type.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GB_Crust_Type.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Crust_Type.ForeColor = System.Drawing.Color.Orange;
            this.GB_Crust_Type.Location = new System.Drawing.Point(51, 338);
            this.GB_Crust_Type.Name = "GB_Crust_Type";
            this.GB_Crust_Type.Size = new System.Drawing.Size(206, 148);
            this.GB_Crust_Type.TabIndex = 2;
            this.GB_Crust_Type.TabStop = false;
            this.GB_Crust_Type.Text = "Crust Type";
            this.GB_Crust_Type.Enter += new System.EventHandler(this.GB_Crust_Type_Enter);
            // 
            // RB_Thinkcrust
            // 
            this.RB_Thinkcrust.AutoSize = true;
            this.RB_Thinkcrust.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_Thinkcrust.Location = new System.Drawing.Point(51, 76);
            this.RB_Thinkcrust.Name = "RB_Thinkcrust";
            this.RB_Thinkcrust.Size = new System.Drawing.Size(132, 27);
            this.RB_Thinkcrust.TabIndex = 1;
            this.RB_Thinkcrust.TabStop = true;
            this.RB_Thinkcrust.Tag = "10";
            this.RB_Thinkcrust.Text = "Thick Crust";
            this.RB_Thinkcrust.UseVisualStyleBackColor = true;
            this.RB_Thinkcrust.CheckedChanged += new System.EventHandler(this.RB_Thinkcrust_CheckedChanged);
            // 
            // RB_ThinCrust
            // 
            this.RB_ThinCrust.AutoSize = true;
            this.RB_ThinCrust.Checked = true;
            this.RB_ThinCrust.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_ThinCrust.Location = new System.Drawing.Point(51, 35);
            this.RB_ThinCrust.Name = "RB_ThinCrust";
            this.RB_ThinCrust.Size = new System.Drawing.Size(124, 27);
            this.RB_ThinCrust.TabIndex = 0;
            this.RB_ThinCrust.TabStop = true;
            this.RB_ThinCrust.Tag = "0";
            this.RB_ThinCrust.Text = "Thin Crust";
            this.RB_ThinCrust.UseVisualStyleBackColor = true;
            this.RB_ThinCrust.CheckedChanged += new System.EventHandler(this.RB_ThinCrust_CheckedChanged);
            // 
            // GB_Toppings
            // 
            this.GB_Toppings.BackColor = System.Drawing.Color.Transparent;
            this.GB_Toppings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GB_Toppings.Controls.Add(this.checkBox6);
            this.GB_Toppings.Controls.Add(this.CB_Olives);
            this.GB_Toppings.Controls.Add(this.CB_Onion);
            this.GB_Toppings.Controls.Add(this.CB_Tomatoes);
            this.GB_Toppings.Controls.Add(this.CB_Mushrooms);
            this.GB_Toppings.Controls.Add(this.CB_ExtraCheese);
            this.GB_Toppings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GB_Toppings.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_Toppings.ForeColor = System.Drawing.Color.Orange;
            this.GB_Toppings.Location = new System.Drawing.Point(354, 154);
            this.GB_Toppings.Name = "GB_Toppings";
            this.GB_Toppings.Size = new System.Drawing.Size(341, 174);
            this.GB_Toppings.TabIndex = 3;
            this.GB_Toppings.TabStop = false;
            this.GB_Toppings.Text = "Toppings";
            this.GB_Toppings.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.Location = new System.Drawing.Point(182, 104);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(161, 27);
            this.checkBox6.TabIndex = 5;
            this.checkBox6.Tag = "5";
            this.checkBox6.Text = "Green Peppers";
            this.checkBox6.UseVisualStyleBackColor = true;
            this.checkBox6.CheckedChanged += new System.EventHandler(this.checkBox6_CheckedChanged);
            // 
            // CB_Olives
            // 
            this.CB_Olives.AutoSize = true;
            this.CB_Olives.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Olives.Location = new System.Drawing.Point(182, 73);
            this.CB_Olives.Name = "CB_Olives";
            this.CB_Olives.Size = new System.Drawing.Size(84, 27);
            this.CB_Olives.TabIndex = 4;
            this.CB_Olives.Tag = "5";
            this.CB_Olives.Text = "Olives";
            this.CB_Olives.UseVisualStyleBackColor = true;
            this.CB_Olives.CheckedChanged += new System.EventHandler(this.CB_Olives_CheckedChanged);
            // 
            // CB_Onion
            // 
            this.CB_Onion.AutoSize = true;
            this.CB_Onion.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Onion.Location = new System.Drawing.Point(182, 43);
            this.CB_Onion.Name = "CB_Onion";
            this.CB_Onion.Size = new System.Drawing.Size(78, 27);
            this.CB_Onion.TabIndex = 3;
            this.CB_Onion.Tag = "5";
            this.CB_Onion.Text = "Onion";
            this.CB_Onion.UseVisualStyleBackColor = true;
            this.CB_Onion.CheckedChanged += new System.EventHandler(this.CB_Onion_CheckedChanged);
            // 
            // CB_Tomatoes
            // 
            this.CB_Tomatoes.AutoSize = true;
            this.CB_Tomatoes.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Tomatoes.Location = new System.Drawing.Point(21, 107);
            this.CB_Tomatoes.Name = "CB_Tomatoes";
            this.CB_Tomatoes.Size = new System.Drawing.Size(116, 27);
            this.CB_Tomatoes.TabIndex = 2;
            this.CB_Tomatoes.Tag = "5";
            this.CB_Tomatoes.Text = "Tomatoes";
            this.CB_Tomatoes.UseVisualStyleBackColor = true;
            this.CB_Tomatoes.CheckedChanged += new System.EventHandler(this.CB_Tomatoes_CheckedChanged);
            // 
            // CB_Mushrooms
            // 
            this.CB_Mushrooms.AutoSize = true;
            this.CB_Mushrooms.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_Mushrooms.Location = new System.Drawing.Point(21, 73);
            this.CB_Mushrooms.Name = "CB_Mushrooms";
            this.CB_Mushrooms.Size = new System.Drawing.Size(127, 27);
            this.CB_Mushrooms.TabIndex = 1;
            this.CB_Mushrooms.Tag = "5";
            this.CB_Mushrooms.Text = "Mushrooms";
            this.CB_Mushrooms.UseVisualStyleBackColor = true;
            this.CB_Mushrooms.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // CB_ExtraCheese
            // 
            this.CB_ExtraCheese.AutoSize = true;
            this.CB_ExtraCheese.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.CB_ExtraCheese.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CB_ExtraCheese.Location = new System.Drawing.Point(21, 43);
            this.CB_ExtraCheese.Name = "CB_ExtraCheese";
            this.CB_ExtraCheese.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.CB_ExtraCheese.Size = new System.Drawing.Size(147, 27);
            this.CB_ExtraCheese.TabIndex = 0;
            this.CB_ExtraCheese.Tag = "5";
            this.CB_ExtraCheese.Text = "Extra Cheese";
            this.CB_ExtraCheese.UseVisualStyleBackColor = true;
            this.CB_ExtraCheese.CheckedChanged += new System.EventHandler(this.CB_ExtraCheese_CheckedChanged);
            // 
            // GB_WhereTo
            // 
            this.GB_WhereTo.BackColor = System.Drawing.Color.Transparent;
            this.GB_WhereTo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.GB_WhereTo.Controls.Add(this.RB_TakeOut);
            this.GB_WhereTo.Controls.Add(this.RB_EatIn);
            this.GB_WhereTo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GB_WhereTo.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_WhereTo.ForeColor = System.Drawing.Color.Orange;
            this.GB_WhereTo.Location = new System.Drawing.Point(354, 348);
            this.GB_WhereTo.Name = "GB_WhereTo";
            this.GB_WhereTo.Size = new System.Drawing.Size(341, 138);
            this.GB_WhereTo.TabIndex = 4;
            this.GB_WhereTo.TabStop = false;
            this.GB_WhereTo.Text = "Where To Eat";
            // 
            // RB_TakeOut
            // 
            this.RB_TakeOut.AutoSize = true;
            this.RB_TakeOut.Checked = true;
            this.RB_TakeOut.Location = new System.Drawing.Point(72, 82);
            this.RB_TakeOut.Name = "RB_TakeOut";
            this.RB_TakeOut.Size = new System.Drawing.Size(114, 27);
            this.RB_TakeOut.TabIndex = 1;
            this.RB_TakeOut.TabStop = true;
            this.RB_TakeOut.Text = "Take Out";
            this.RB_TakeOut.UseVisualStyleBackColor = true;
            this.RB_TakeOut.CheckedChanged += new System.EventHandler(this.RB_TakeOut_CheckedChanged);
            // 
            // RB_EatIn
            // 
            this.RB_EatIn.AutoSize = true;
            this.RB_EatIn.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RB_EatIn.Location = new System.Drawing.Point(72, 48);
            this.RB_EatIn.Name = "RB_EatIn";
            this.RB_EatIn.Size = new System.Drawing.Size(91, 27);
            this.RB_EatIn.TabIndex = 0;
            this.RB_EatIn.TabStop = true;
            this.RB_EatIn.Text = "Eat In";
            this.RB_EatIn.UseVisualStyleBackColor = true;
            this.RB_EatIn.CheckedChanged += new System.EventHandler(this.RB_EatIn_CheckedChanged);
            // 
            // GB_OrderSamary
            // 
            this.GB_OrderSamary.BackColor = System.Drawing.Color.Transparent;
            this.GB_OrderSamary.Controls.Add(this.Lbl_Crust);
            this.GB_OrderSamary.Controls.Add(this.label5);
            this.GB_OrderSamary.Controls.Add(this.Label_Price);
            this.GB_OrderSamary.Controls.Add(this.Lbl_Size);
            this.GB_OrderSamary.Controls.Add(this.lbl_Toppings);
            this.GB_OrderSamary.Controls.Add(this.label2);
            this.GB_OrderSamary.Controls.Add(this.Total_Price);
            this.GB_OrderSamary.Controls.Add(this.Crust_Type);
            this.GB_OrderSamary.Controls.Add(this.Where_To_Eat);
            this.GB_OrderSamary.Controls.Add(this.Toppings);
            this.GB_OrderSamary.Controls.Add(this.label1);
            this.GB_OrderSamary.Font = new System.Drawing.Font("Ink Free", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GB_OrderSamary.ForeColor = System.Drawing.Color.Orange;
            this.GB_OrderSamary.Location = new System.Drawing.Point(766, 142);
            this.GB_OrderSamary.Name = "GB_OrderSamary";
            this.GB_OrderSamary.Size = new System.Drawing.Size(340, 358);
            this.GB_OrderSamary.TabIndex = 5;
            this.GB_OrderSamary.TabStop = false;
            this.GB_OrderSamary.Text = "Order Summary";
            this.GB_OrderSamary.UseWaitCursor = true;
            this.GB_OrderSamary.Enter += new System.EventHandler(this.GB_OrderSamary_Enter);
            // 
            // Lbl_Crust
            // 
            this.Lbl_Crust.AutoSize = true;
            this.Lbl_Crust.ForeColor = System.Drawing.Color.White;
            this.Lbl_Crust.Location = new System.Drawing.Point(137, 184);
            this.Lbl_Crust.Name = "Lbl_Crust";
            this.Lbl_Crust.Size = new System.Drawing.Size(106, 23);
            this.Lbl_Crust.TabIndex = 11;
            this.Lbl_Crust.Text = "Thin Crust";
            this.Lbl_Crust.UseWaitCursor = true;
            this.Lbl_Crust.Click += new System.EventHandler(this.label6_Click_1);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(126, 184);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 10;
            this.label5.UseWaitCursor = true;
            // 
            // Label_Price
            // 
            this.Label_Price.Font = new System.Drawing.Font("Goudy Stout", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label_Price.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.Label_Price.Location = new System.Drawing.Point(133, 296);
            this.Label_Price.Name = "Label_Price";
            this.Label_Price.Size = new System.Drawing.Size(143, 72);
            this.Label_Price.TabIndex = 9;
            this.Label_Price.Text = "$10";
            this.Label_Price.UseWaitCursor = true;
            this.Label_Price.Click += new System.EventHandler(this.label6_Click);
            // 
            // Lbl_Size
            // 
            this.Lbl_Size.AutoSize = true;
            this.Lbl_Size.ForeColor = System.Drawing.Color.White;
            this.Lbl_Size.Location = new System.Drawing.Point(72, 50);
            this.Lbl_Size.Name = "Lbl_Size";
            this.Lbl_Size.Size = new System.Drawing.Size(57, 23);
            this.Lbl_Size.TabIndex = 7;
            this.Lbl_Size.Text = "Small";
            this.Lbl_Size.UseWaitCursor = true;
            this.Lbl_Size.Click += new System.EventHandler(this.label4_Click);
            // 
            // lbl_Toppings
            // 
            this.lbl_Toppings.ForeColor = System.Drawing.Color.White;
            this.lbl_Toppings.Location = new System.Drawing.Point(41, 128);
            this.lbl_Toppings.Name = "lbl_Toppings";
            this.lbl_Toppings.Size = new System.Drawing.Size(293, 56);
            this.lbl_Toppings.TabIndex = 6;
            this.lbl_Toppings.Text = "No of topping";
            this.lbl_Toppings.UseWaitCursor = true;
            this.lbl_Toppings.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(138, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Where To Eat:";
            this.label2.UseWaitCursor = true;
            // 
            // Total_Price
            // 
            this.Total_Price.AutoSize = true;
            this.Total_Price.Location = new System.Drawing.Point(27, 296);
            this.Total_Price.Name = "Total_Price";
            this.Total_Price.Size = new System.Drawing.Size(109, 23);
            this.Total_Price.TabIndex = 4;
            this.Total_Price.Text = "Total Price";
            this.Total_Price.UseWaitCursor = true;
            // 
            // Crust_Type
            // 
            this.Crust_Type.AutoSize = true;
            this.Crust_Type.Location = new System.Drawing.Point(27, 184);
            this.Crust_Type.Name = "Crust_Type";
            this.Crust_Type.Size = new System.Drawing.Size(120, 23);
            this.Crust_Type.TabIndex = 3;
            this.Crust_Type.Text = "Crust Type: ";
            this.Crust_Type.UseWaitCursor = true;
            this.Crust_Type.Click += new System.EventHandler(this.Crust_Type_Click);
            // 
            // Where_To_Eat
            // 
            this.Where_To_Eat.AutoSize = true;
            this.Where_To_Eat.ForeColor = System.Drawing.Color.White;
            this.Where_To_Eat.Location = new System.Drawing.Point(41, 264);
            this.Where_To_Eat.Name = "Where_To_Eat";
            this.Where_To_Eat.Size = new System.Drawing.Size(64, 23);
            this.Where_To_Eat.TabIndex = 2;
            this.Where_To_Eat.Text = "Eat in";
            this.Where_To_Eat.UseWaitCursor = true;
            this.Where_To_Eat.Click += new System.EventHandler(this.Where_To_Eat_Click);
            // 
            // Toppings
            // 
            this.Toppings.AutoSize = true;
            this.Toppings.Location = new System.Drawing.Point(21, 97);
            this.Toppings.Name = "Toppings";
            this.Toppings.Size = new System.Drawing.Size(95, 23);
            this.Toppings.TabIndex = 1;
            this.Toppings.Text = "Toppings:";
            this.Toppings.UseWaitCursor = true;
            this.Toppings.Click += new System.EventHandler(this.Toppings_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Size: ";
            this.label1.UseWaitCursor = true;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // B_OrderPizza
            // 
            this.B_OrderPizza.BackColor = System.Drawing.Color.Orange;
            this.B_OrderPizza.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.B_OrderPizza.FlatAppearance.BorderSize = 3;
            this.B_OrderPizza.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.B_OrderPizza.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.B_OrderPizza.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.B_OrderPizza.ForeColor = System.Drawing.Color.Black;
            this.B_OrderPizza.Location = new System.Drawing.Point(336, 505);
            this.B_OrderPizza.Name = "B_OrderPizza";
            this.B_OrderPizza.Size = new System.Drawing.Size(163, 65);
            this.B_OrderPizza.TabIndex = 6;
            this.B_OrderPizza.Text = "Order Pizza";
            this.B_OrderPizza.UseVisualStyleBackColor = false;
            this.B_OrderPizza.Click += new System.EventHandler(this.B_OrderPizza_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Salmon;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("MV Boli", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(600, 505);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(164, 65);
            this.button2.TabIndex = 7;
            this.button2.Text = "Reset Form";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(774, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(332, 18);
            this.label3.TabIndex = 8;
            this.label3.Text = "How many pizzas would you like to order? ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Enabled = false;
            this.numericUpDown1.Location = new System.Drawing.Point(811, 107);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 9;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Project_Pizza.Properties.Resources.photo_2026_06_25_14_32_30;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1166, 651);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.B_OrderPizza);
            this.Controls.Add(this.GB_OrderSamary);
            this.Controls.Add(this.GB_WhereTo);
            this.Controls.Add(this.GB_Size);
            this.Controls.Add(this.GB_Toppings);
            this.Controls.Add(this.GB_Crust_Type);
            this.Controls.Add(this.Makeyorpizza);
            this.Name = "Form1";
            this.Text = "Order Now";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GB_Size.ResumeLayout(false);
            this.GB_Size.PerformLayout();
            this.GB_Crust_Type.ResumeLayout(false);
            this.GB_Crust_Type.PerformLayout();
            this.GB_Toppings.ResumeLayout(false);
            this.GB_Toppings.PerformLayout();
            this.GB_WhereTo.ResumeLayout(false);
            this.GB_WhereTo.PerformLayout();
            this.GB_OrderSamary.ResumeLayout(false);
            this.GB_OrderSamary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Makeyorpizza;
        private System.Windows.Forms.GroupBox GB_Size;
        private System.Windows.Forms.RadioButton RB_larg;
        private System.Windows.Forms.RadioButton RB_Meduim;
        private System.Windows.Forms.RadioButton RBSmall;
        private System.Windows.Forms.GroupBox GB_Crust_Type;
        private System.Windows.Forms.RadioButton RB_ThinCrust;
        private System.Windows.Forms.GroupBox GB_Toppings;
        private System.Windows.Forms.CheckBox CB_Tomatoes;
        private System.Windows.Forms.CheckBox CB_Mushrooms;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox CB_Olives;
        private System.Windows.Forms.CheckBox CB_Onion;
        private System.Windows.Forms.CheckBox CB_ExtraCheese;
        private System.Windows.Forms.RadioButton RB_Thinkcrust;
        private System.Windows.Forms.GroupBox GB_WhereTo;
        private System.Windows.Forms.RadioButton RB_TakeOut;
        private System.Windows.Forms.RadioButton RB_EatIn;
        private System.Windows.Forms.GroupBox GB_OrderSamary;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label Crust_Type;
        private System.Windows.Forms.Label Where_To_Eat;
        private System.Windows.Forms.Label Toppings;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label Total_Price;
        private System.Windows.Forms.Label lbl_Toppings;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label Lbl_Size;
        private System.Windows.Forms.Label Label_Price;
        private System.Windows.Forms.Button B_OrderPizza;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Lbl_Crust;
        private System.ComponentModel.BackgroundWorker backgroundWorker2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}

