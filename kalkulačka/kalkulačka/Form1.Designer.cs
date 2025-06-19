namespace kalkulačka
{
    partial class Form1
    {
        /// <summary>
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód generovaný Návrhářem Windows Form

        /// <summary>
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_backspace = new System.Windows.Forms.Button();
            this.txt_result = new System.Windows.Forms.TextBox();
            this.btn_clear_empty = new System.Windows.Forms.Button();
            this.btn_plus_minus = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_divide = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn_multiply = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btn_minus = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.btn_dot = new System.Windows.Forms.Button();
            this.btn_result = new System.Windows.Forms.Button();
            this.btn_plus = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.standardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sciToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btn_x_x = new System.Windows.Forms.Button();
            this.btn_sinh = new System.Windows.Forms.Button();
            this.btn_sin = new System.Windows.Forms.Button();
            this.btn_dec = new System.Windows.Forms.Button();
            this.btn_xxx = new System.Windows.Forms.Button();
            this.btn_cosh = new System.Windows.Forms.Button();
            this.btn_cos = new System.Windows.Forms.Button();
            this.btn_bin = new System.Windows.Forms.Button();
            this.btn_1overx = new System.Windows.Forms.Button();
            this.btn_tanh = new System.Windows.Forms.Button();
            this.btn_tan = new System.Windows.Forms.Button();
            this.btn_hex = new System.Windows.Forms.Button();
            this.btn_lnx = new System.Windows.Forms.Button();
            this.btn_exp = new System.Windows.Forms.Button();
            this.btn_mod = new System.Windows.Forms.Button();
            this.btn_oct = new System.Windows.Forms.Button();
            this.btn_perc = new System.Windows.Forms.Button();
            this.btn_pi = new System.Windows.Forms.Button();
            this.btn_log = new System.Windows.Forms.Button();
            this.btn_sqrt = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_backspace
            // 
            this.btn_backspace.Font = new System.Drawing.Font("Wingdings", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.btn_backspace.Location = new System.Drawing.Point(12, 96);
            this.btn_backspace.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_backspace.Name = "btn_backspace";
            this.btn_backspace.Size = new System.Drawing.Size(75, 54);
            this.btn_backspace.TabIndex = 0;
            this.btn_backspace.Text = "";
            this.btn_backspace.UseVisualStyleBackColor = true;
            this.btn_backspace.Click += new System.EventHandler(this.btn_backspace_Click);
            // 
            // txt_result
            // 
            this.txt_result.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_result.Location = new System.Drawing.Point(12, 34);
            this.txt_result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.txt_result.Multiline = true;
            this.txt_result.Name = "txt_result";
            this.txt_result.ReadOnly = true;
            this.txt_result.Size = new System.Drawing.Size(319, 56);
            this.txt_result.TabIndex = 1;
            this.txt_result.Text = "0";
            this.txt_result.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btn_clear_empty
            // 
            this.btn_clear_empty.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear_empty.Location = new System.Drawing.Point(93, 96);
            this.btn_clear_empty.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear_empty.Name = "btn_clear_empty";
            this.btn_clear_empty.Size = new System.Drawing.Size(75, 54);
            this.btn_clear_empty.TabIndex = 2;
            this.btn_clear_empty.Text = "CE";
            this.btn_clear_empty.UseVisualStyleBackColor = true;
            this.btn_clear_empty.Click += new System.EventHandler(this.btn_clear_empty_Click);
            // 
            // btn_plus_minus
            // 
            this.btn_plus_minus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus_minus.Location = new System.Drawing.Point(255, 96);
            this.btn_plus_minus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_plus_minus.Name = "btn_plus_minus";
            this.btn_plus_minus.Size = new System.Drawing.Size(75, 54);
            this.btn_plus_minus.TabIndex = 4;
            this.btn_plus_minus.Text = "±";
            this.btn_plus_minus.UseVisualStyleBackColor = true;
            this.btn_plus_minus.Click += new System.EventHandler(this.btn_plus_minus_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_clear.Location = new System.Drawing.Point(173, 96);
            this.btn_clear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 54);
            this.btn_clear.TabIndex = 3;
            this.btn_clear.Text = "C";
            this.btn_clear.UseVisualStyleBackColor = true;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // btn_divide
            // 
            this.btn_divide.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_divide.Location = new System.Drawing.Point(255, 156);
            this.btn_divide.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_divide.Name = "btn_divide";
            this.btn_divide.Size = new System.Drawing.Size(75, 54);
            this.btn_divide.TabIndex = 8;
            this.btn_divide.Text = "/";
            this.btn_divide.UseVisualStyleBackColor = true;
            this.btn_divide.Click += new System.EventHandler(this.num_oper);
            // 
            // btn9
            // 
            this.btn9.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn9.Location = new System.Drawing.Point(173, 156);
            this.btn9.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(75, 54);
            this.btn9.TabIndex = 7;
            this.btn9.Text = "9";
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.enter_num);
            // 
            // btn8
            // 
            this.btn8.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn8.Location = new System.Drawing.Point(93, 156);
            this.btn8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(75, 54);
            this.btn8.TabIndex = 6;
            this.btn8.Text = "8";
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.enter_num);
            // 
            // btn7
            // 
            this.btn7.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn7.Location = new System.Drawing.Point(12, 156);
            this.btn7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(75, 54);
            this.btn7.TabIndex = 5;
            this.btn7.Text = "7";
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.enter_num);
            // 
            // btn4
            // 
            this.btn4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn4.Location = new System.Drawing.Point(12, 217);
            this.btn4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(75, 54);
            this.btn4.TabIndex = 0;
            this.btn4.Text = "4";
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.enter_num);
            // 
            // btn5
            // 
            this.btn5.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn5.Location = new System.Drawing.Point(93, 217);
            this.btn5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(75, 54);
            this.btn5.TabIndex = 2;
            this.btn5.Text = "5";
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.enter_num);
            // 
            // btn6
            // 
            this.btn6.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn6.Location = new System.Drawing.Point(173, 217);
            this.btn6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(75, 54);
            this.btn6.TabIndex = 3;
            this.btn6.Text = "6";
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.enter_num);
            // 
            // btn_multiply
            // 
            this.btn_multiply.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_multiply.Location = new System.Drawing.Point(255, 217);
            this.btn_multiply.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_multiply.Name = "btn_multiply";
            this.btn_multiply.Size = new System.Drawing.Size(75, 54);
            this.btn_multiply.TabIndex = 4;
            this.btn_multiply.Text = "*";
            this.btn_multiply.UseVisualStyleBackColor = true;
            this.btn_multiply.Click += new System.EventHandler(this.num_oper);
            // 
            // btn1
            // 
            this.btn1.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn1.Location = new System.Drawing.Point(12, 276);
            this.btn1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 54);
            this.btn1.TabIndex = 5;
            this.btn1.Text = "1";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.enter_num);
            // 
            // btn2
            // 
            this.btn2.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn2.Location = new System.Drawing.Point(93, 276);
            this.btn2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(75, 54);
            this.btn2.TabIndex = 6;
            this.btn2.Text = "2";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.enter_num);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn3.Location = new System.Drawing.Point(173, 276);
            this.btn3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(75, 54);
            this.btn3.TabIndex = 7;
            this.btn3.Text = "3";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.enter_num);
            // 
            // btn_minus
            // 
            this.btn_minus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_minus.Location = new System.Drawing.Point(255, 276);
            this.btn_minus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_minus.Name = "btn_minus";
            this.btn_minus.Size = new System.Drawing.Size(75, 54);
            this.btn_minus.TabIndex = 8;
            this.btn_minus.Text = "-";
            this.btn_minus.UseVisualStyleBackColor = true;
            this.btn_minus.Click += new System.EventHandler(this.num_oper);
            // 
            // btn0
            // 
            this.btn0.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn0.Location = new System.Drawing.Point(12, 336);
            this.btn0.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(75, 54);
            this.btn0.TabIndex = 5;
            this.btn0.Text = "0";
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.enter_num);
            // 
            // btn_dot
            // 
            this.btn_dot.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dot.Location = new System.Drawing.Point(93, 336);
            this.btn_dot.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dot.Name = "btn_dot";
            this.btn_dot.Size = new System.Drawing.Size(75, 54);
            this.btn_dot.TabIndex = 6;
            this.btn_dot.Text = ",";
            this.btn_dot.UseVisualStyleBackColor = true;
            this.btn_dot.Click += new System.EventHandler(this.enter_num);
            // 
            // btn_result
            // 
            this.btn_result.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_result.Location = new System.Drawing.Point(173, 336);
            this.btn_result.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_result.Name = "btn_result";
            this.btn_result.Size = new System.Drawing.Size(75, 54);
            this.btn_result.TabIndex = 7;
            this.btn_result.Text = "=";
            this.btn_result.UseVisualStyleBackColor = true;
            this.btn_result.Click += new System.EventHandler(this.btn_result_Click);
            // 
            // btn_plus
            // 
            this.btn_plus.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_plus.Location = new System.Drawing.Point(255, 336);
            this.btn_plus.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_plus.Name = "btn_plus";
            this.btn_plus.Size = new System.Drawing.Size(75, 54);
            this.btn_plus.TabIndex = 8;
            this.btn_plus.Text = "+";
            this.btn_plus.UseVisualStyleBackColor = true;
            this.btn_plus.Click += new System.EventHandler(this.num_oper);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(800, 28);
            this.menuStrip1.TabIndex = 9;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.standardToolStripMenuItem,
            this.sciToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(46, 24);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // standardToolStripMenuItem
            // 
            this.standardToolStripMenuItem.Name = "standardToolStripMenuItem";
            this.standardToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.standardToolStripMenuItem.Text = "Stand";
            this.standardToolStripMenuItem.Click += new System.EventHandler(this.standardToolStripMenuItem_Click);
            // 
            // sciToolStripMenuItem
            // 
            this.sciToolStripMenuItem.Name = "sciToolStripMenuItem";
            this.sciToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.sciToolStripMenuItem.Text = "Sci";
            this.sciToolStripMenuItem.Click += new System.EventHandler(this.sciToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(130, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // btn_x_x
            // 
            this.btn_x_x.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_x_x.Location = new System.Drawing.Point(596, 96);
            this.btn_x_x.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_x_x.Name = "btn_x_x";
            this.btn_x_x.Size = new System.Drawing.Size(75, 54);
            this.btn_x_x.TabIndex = 4;
            this.btn_x_x.Text = "x²";
            this.btn_x_x.UseVisualStyleBackColor = true;
            this.btn_x_x.Click += new System.EventHandler(this.btn_x_x_Click);
            // 
            // btn_sinh
            // 
            this.btn_sinh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sinh.Location = new System.Drawing.Point(356, 156);
            this.btn_sinh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sinh.Name = "btn_sinh";
            this.btn_sinh.Size = new System.Drawing.Size(75, 54);
            this.btn_sinh.TabIndex = 4;
            this.btn_sinh.Text = "sinh";
            this.btn_sinh.UseVisualStyleBackColor = true;
            this.btn_sinh.Click += new System.EventHandler(this.btn_sinh_Click);
            // 
            // btn_sin
            // 
            this.btn_sin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sin.Location = new System.Drawing.Point(436, 156);
            this.btn_sin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sin.Name = "btn_sin";
            this.btn_sin.Size = new System.Drawing.Size(75, 54);
            this.btn_sin.TabIndex = 4;
            this.btn_sin.Text = "sin";
            this.btn_sin.UseVisualStyleBackColor = true;
            this.btn_sin.Click += new System.EventHandler(this.btn_sin_Click);
            // 
            // btn_dec
            // 
            this.btn_dec.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_dec.Location = new System.Drawing.Point(516, 156);
            this.btn_dec.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_dec.Name = "btn_dec";
            this.btn_dec.Size = new System.Drawing.Size(75, 54);
            this.btn_dec.TabIndex = 4;
            this.btn_dec.Text = "dec";
            this.btn_dec.UseVisualStyleBackColor = true;
            this.btn_dec.Click += new System.EventHandler(this.btn_dec_Click);
            // 
            // btn_xxx
            // 
            this.btn_xxx.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_xxx.Location = new System.Drawing.Point(596, 156);
            this.btn_xxx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_xxx.Name = "btn_xxx";
            this.btn_xxx.Size = new System.Drawing.Size(75, 54);
            this.btn_xxx.TabIndex = 4;
            this.btn_xxx.Text = "x³";
            this.btn_xxx.UseVisualStyleBackColor = true;
            this.btn_xxx.Click += new System.EventHandler(this.btn_xxx_Click);
            // 
            // btn_cosh
            // 
            this.btn_cosh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cosh.Location = new System.Drawing.Point(356, 217);
            this.btn_cosh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cosh.Name = "btn_cosh";
            this.btn_cosh.Size = new System.Drawing.Size(75, 54);
            this.btn_cosh.TabIndex = 4;
            this.btn_cosh.Text = "cosh";
            this.btn_cosh.UseVisualStyleBackColor = true;
            this.btn_cosh.Click += new System.EventHandler(this.btn_cosh_Click);
            // 
            // btn_cos
            // 
            this.btn_cos.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cos.Location = new System.Drawing.Point(436, 217);
            this.btn_cos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_cos.Name = "btn_cos";
            this.btn_cos.Size = new System.Drawing.Size(75, 54);
            this.btn_cos.TabIndex = 4;
            this.btn_cos.Text = "cos";
            this.btn_cos.UseVisualStyleBackColor = true;
            this.btn_cos.Click += new System.EventHandler(this.btn_cos_Click);
            // 
            // btn_bin
            // 
            this.btn_bin.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bin.Location = new System.Drawing.Point(516, 217);
            this.btn_bin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_bin.Name = "btn_bin";
            this.btn_bin.Size = new System.Drawing.Size(75, 54);
            this.btn_bin.TabIndex = 4;
            this.btn_bin.Text = "bin";
            this.btn_bin.UseVisualStyleBackColor = true;
            this.btn_bin.Click += new System.EventHandler(this.btn_bin_Click);
            // 
            // btn_1overx
            // 
            this.btn_1overx.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_1overx.Location = new System.Drawing.Point(596, 217);
            this.btn_1overx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_1overx.Name = "btn_1overx";
            this.btn_1overx.Size = new System.Drawing.Size(75, 54);
            this.btn_1overx.TabIndex = 4;
            this.btn_1overx.Text = "1/x";
            this.btn_1overx.UseVisualStyleBackColor = true;
            this.btn_1overx.Click += new System.EventHandler(this.btn_1overx_Click);
            // 
            // btn_tanh
            // 
            this.btn_tanh.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tanh.Location = new System.Drawing.Point(356, 276);
            this.btn_tanh.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tanh.Name = "btn_tanh";
            this.btn_tanh.Size = new System.Drawing.Size(75, 54);
            this.btn_tanh.TabIndex = 4;
            this.btn_tanh.Text = "tanh";
            this.btn_tanh.UseVisualStyleBackColor = true;
            this.btn_tanh.Click += new System.EventHandler(this.btn_tanh_Click);
            // 
            // btn_tan
            // 
            this.btn_tan.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_tan.Location = new System.Drawing.Point(436, 276);
            this.btn_tan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_tan.Name = "btn_tan";
            this.btn_tan.Size = new System.Drawing.Size(75, 54);
            this.btn_tan.TabIndex = 4;
            this.btn_tan.Text = "tan";
            this.btn_tan.UseVisualStyleBackColor = true;
            this.btn_tan.Click += new System.EventHandler(this.btn_tan_Click);
            // 
            // btn_hex
            // 
            this.btn_hex.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_hex.Location = new System.Drawing.Point(516, 276);
            this.btn_hex.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_hex.Name = "btn_hex";
            this.btn_hex.Size = new System.Drawing.Size(75, 54);
            this.btn_hex.TabIndex = 4;
            this.btn_hex.Text = "hex";
            this.btn_hex.UseVisualStyleBackColor = true;
            this.btn_hex.Click += new System.EventHandler(this.btn_hex_Click);
            // 
            // btn_lnx
            // 
            this.btn_lnx.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_lnx.Location = new System.Drawing.Point(596, 276);
            this.btn_lnx.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_lnx.Name = "btn_lnx";
            this.btn_lnx.Size = new System.Drawing.Size(75, 54);
            this.btn_lnx.TabIndex = 4;
            this.btn_lnx.Text = "ln x";
            this.btn_lnx.UseVisualStyleBackColor = true;
            this.btn_lnx.Click += new System.EventHandler(this.btn_lnx_Click);
            // 
            // btn_exp
            // 
            this.btn_exp.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exp.Location = new System.Drawing.Point(356, 335);
            this.btn_exp.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_exp.Name = "btn_exp";
            this.btn_exp.Size = new System.Drawing.Size(75, 54);
            this.btn_exp.TabIndex = 4;
            this.btn_exp.Text = "exp";
            this.btn_exp.UseVisualStyleBackColor = true;
            this.btn_exp.Click += new System.EventHandler(this.num_oper);
            // 
            // btn_mod
            // 
            this.btn_mod.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_mod.Location = new System.Drawing.Point(436, 335);
            this.btn_mod.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_mod.Name = "btn_mod";
            this.btn_mod.Size = new System.Drawing.Size(75, 54);
            this.btn_mod.TabIndex = 4;
            this.btn_mod.Text = "mod";
            this.btn_mod.UseVisualStyleBackColor = true;
            this.btn_mod.Click += new System.EventHandler(this.num_oper);
            // 
            // btn_oct
            // 
            this.btn_oct.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_oct.Location = new System.Drawing.Point(516, 335);
            this.btn_oct.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_oct.Name = "btn_oct";
            this.btn_oct.Size = new System.Drawing.Size(75, 54);
            this.btn_oct.TabIndex = 4;
            this.btn_oct.Text = "oct";
            this.btn_oct.UseVisualStyleBackColor = true;
            this.btn_oct.Click += new System.EventHandler(this.btn_oct_Click);
            // 
            // btn_perc
            // 
            this.btn_perc.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_perc.Location = new System.Drawing.Point(596, 335);
            this.btn_perc.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_perc.Name = "btn_perc";
            this.btn_perc.Size = new System.Drawing.Size(75, 54);
            this.btn_perc.TabIndex = 4;
            this.btn_perc.Text = "%";
            this.btn_perc.UseVisualStyleBackColor = true;
            this.btn_perc.Click += new System.EventHandler(this.btn_perc_Click);
            // 
            // btn_pi
            // 
            this.btn_pi.Font = new System.Drawing.Font("Centaur", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_pi.Location = new System.Drawing.Point(356, 97);
            this.btn_pi.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_pi.Name = "btn_pi";
            this.btn_pi.Size = new System.Drawing.Size(75, 54);
            this.btn_pi.TabIndex = 10;
            this.btn_pi.Text = "π";
            this.btn_pi.UseVisualStyleBackColor = true;
            this.btn_pi.Click += new System.EventHandler(this.btn_pi_Click);
            // 
            // btn_log
            // 
            this.btn_log.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log.Location = new System.Drawing.Point(436, 97);
            this.btn_log.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_log.Name = "btn_log";
            this.btn_log.Size = new System.Drawing.Size(75, 54);
            this.btn_log.TabIndex = 11;
            this.btn_log.Text = "log";
            this.btn_log.UseVisualStyleBackColor = true;
            this.btn_log.Click += new System.EventHandler(this.btn_log_Click);
            // 
            // btn_sqrt
            // 
            this.btn_sqrt.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_sqrt.Location = new System.Drawing.Point(516, 96);
            this.btn_sqrt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_sqrt.Name = "btn_sqrt";
            this.btn_sqrt.Size = new System.Drawing.Size(75, 54);
            this.btn_sqrt.TabIndex = 12;
            this.btn_sqrt.Text = "sqrt";
            this.btn_sqrt.UseVisualStyleBackColor = true;
            this.btn_sqrt.Click += new System.EventHandler(this.btn_sqrt_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 403);
            this.Controls.Add(this.btn_sqrt);
            this.Controls.Add(this.btn_log);
            this.Controls.Add(this.btn_pi);
            this.Controls.Add(this.btn_plus);
            this.Controls.Add(this.btn_minus);
            this.Controls.Add(this.btn_divide);
            this.Controls.Add(this.btn_result);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn9);
            this.Controls.Add(this.btn_dot);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn8);
            this.Controls.Add(this.btn0);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn7);
            this.Controls.Add(this.btn_multiply);
            this.Controls.Add(this.btn_perc);
            this.Controls.Add(this.btn_lnx);
            this.Controls.Add(this.btn_1overx);
            this.Controls.Add(this.btn_xxx);
            this.Controls.Add(this.btn_x_x);
            this.Controls.Add(this.btn_oct);
            this.Controls.Add(this.btn_hex);
            this.Controls.Add(this.btn_bin);
            this.Controls.Add(this.btn_dec);
            this.Controls.Add(this.btn_mod);
            this.Controls.Add(this.btn_tan);
            this.Controls.Add(this.btn_cos);
            this.Controls.Add(this.btn_sin);
            this.Controls.Add(this.btn_exp);
            this.Controls.Add(this.btn_tanh);
            this.Controls.Add(this.btn_cosh);
            this.Controls.Add(this.btn_sinh);
            this.Controls.Add(this.btn_plus_minus);
            this.Controls.Add(this.btn6);
            this.Controls.Add(this.btn_clear);
            this.Controls.Add(this.btn5);
            this.Controls.Add(this.btn_clear_empty);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.txt_result);
            this.Controls.Add(this.btn_backspace);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_backspace;
        private System.Windows.Forms.TextBox txt_result;
        private System.Windows.Forms.Button btn_clear_empty;
        private System.Windows.Forms.Button btn_plus_minus;
        private System.Windows.Forms.Button btn_clear;
        private System.Windows.Forms.Button btn_divide;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn_multiply;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn_minus;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button btn_dot;
        private System.Windows.Forms.Button btn_result;
        private System.Windows.Forms.Button btn_plus;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem standardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sciToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.Button btn_x_x;
        private System.Windows.Forms.Button btn_sinh;
        private System.Windows.Forms.Button btn_sin;
        private System.Windows.Forms.Button btn_dec;
        private System.Windows.Forms.Button btn_xxx;
        private System.Windows.Forms.Button btn_cosh;
        private System.Windows.Forms.Button btn_cos;
        private System.Windows.Forms.Button btn_bin;
        private System.Windows.Forms.Button btn_1overx;
        private System.Windows.Forms.Button btn_tanh;
        private System.Windows.Forms.Button btn_tan;
        private System.Windows.Forms.Button btn_hex;
        private System.Windows.Forms.Button btn_lnx;
        private System.Windows.Forms.Button btn_exp;
        private System.Windows.Forms.Button btn_mod;
        private System.Windows.Forms.Button btn_oct;
        private System.Windows.Forms.Button btn_perc;
        private System.Windows.Forms.Button btn_pi;
        private System.Windows.Forms.Button btn_log;
        private System.Windows.Forms.Button btn_sqrt;
    }
}

