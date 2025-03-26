namespace TestWinForm
{
    partial class frmMainEntrance
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.tpgQueue = new System.Windows.Forms.TabControl();
            this.tbgSorting = new System.Windows.Forms.TabPage();
            this.btnSelectionSort = new System.Windows.Forms.Button();
            this.btnMergeSort = new System.Windows.Forms.Button();
            this.btnInsertionSort = new System.Windows.Forms.Button();
            this.lblAfter = new System.Windows.Forms.Label();
            this.tbxtAfterSorting = new System.Windows.Forms.TextBox();
            this.tbxtBeforeSorting = new System.Windows.Forms.TextBox();
            this.lblBefore = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbnString = new System.Windows.Forms.RadioButton();
            this.rbnDouble = new System.Windows.Forms.RadioButton();
            this.rbnInteger = new System.Windows.Forms.RadioButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.DoubleLL_btn = new System.Windows.Forms.Button();
            this.PolyOperation_btn = new System.Windows.Forms.Button();
            this.Single_btn = new System.Windows.Forms.Button();
            this.Search_lbl = new System.Windows.Forms.Label();
            this.Insert_lbl = new System.Windows.Forms.Label();
            this.Delete_lbl = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tbxOriginginal = new System.Windows.Forms.TextBox();
            this.Origianl_lbl = new System.Windows.Forms.Label();
            this.tpgLoopRecurslve = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.tabPage6 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.tpgQueue.SuspendLayout();
            this.tbgSorting.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tpgQueue
            // 
            this.tpgQueue.Controls.Add(this.tbgSorting);
            this.tpgQueue.Controls.Add(this.tabPage2);
            this.tpgQueue.Controls.Add(this.tpgLoopRecurslve);
            this.tpgQueue.Controls.Add(this.tabPage3);
            this.tpgQueue.Controls.Add(this.tabPage4);
            this.tpgQueue.Controls.Add(this.tabPage5);
            this.tpgQueue.Controls.Add(this.tabPage6);
            this.tpgQueue.Dock = System.Windows.Forms.DockStyle.Left;
            this.tpgQueue.Location = new System.Drawing.Point(0, 0);
            this.tpgQueue.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgQueue.Name = "tpgQueue";
            this.tpgQueue.SelectedIndex = 0;
            this.tpgQueue.Size = new System.Drawing.Size(696, 562);
            this.tpgQueue.TabIndex = 0;
            // 
            // tbgSorting
            // 
            this.tbgSorting.Controls.Add(this.btnSelectionSort);
            this.tbgSorting.Controls.Add(this.btnMergeSort);
            this.tbgSorting.Controls.Add(this.btnInsertionSort);
            this.tbgSorting.Controls.Add(this.lblAfter);
            this.tbgSorting.Controls.Add(this.tbxtAfterSorting);
            this.tbgSorting.Controls.Add(this.tbxtBeforeSorting);
            this.tbgSorting.Controls.Add(this.lblBefore);
            this.tbgSorting.Controls.Add(this.groupBox1);
            this.tbgSorting.Location = new System.Drawing.Point(4, 25);
            this.tbgSorting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbgSorting.Name = "tbgSorting";
            this.tbgSorting.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbgSorting.Size = new System.Drawing.Size(688, 533);
            this.tbgSorting.TabIndex = 0;
            this.tbgSorting.Text = "Sorting";
            this.tbgSorting.UseVisualStyleBackColor = true;
            // 
            // btnSelectionSort
            // 
            this.btnSelectionSort.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnSelectionSort.Location = new System.Drawing.Point(232, 212);
            this.btnSelectionSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelectionSort.Name = "btnSelectionSort";
            this.btnSelectionSort.Size = new System.Drawing.Size(129, 42);
            this.btnSelectionSort.TabIndex = 8;
            this.btnSelectionSort.Text = "Selection";
            this.btnSelectionSort.UseVisualStyleBackColor = true;
            this.btnSelectionSort.Click += new System.EventHandler(this.btnSelectionSort_Click);
            // 
            // btnMergeSort
            // 
            this.btnMergeSort.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnMergeSort.Location = new System.Drawing.Point(439, 212);
            this.btnMergeSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMergeSort.Name = "btnMergeSort";
            this.btnMergeSort.Size = new System.Drawing.Size(129, 42);
            this.btnMergeSort.TabIndex = 7;
            this.btnMergeSort.Text = "Merge";
            this.btnMergeSort.UseVisualStyleBackColor = true;
            // 
            // btnInsertionSort
            // 
            this.btnInsertionSort.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.btnInsertionSort.Location = new System.Drawing.Point(29, 212);
            this.btnInsertionSort.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnInsertionSort.Name = "btnInsertionSort";
            this.btnInsertionSort.Size = new System.Drawing.Size(129, 42);
            this.btnInsertionSort.TabIndex = 6;
            this.btnInsertionSort.Text = "Insertion";
            this.btnInsertionSort.UseVisualStyleBackColor = true;
            this.btnInsertionSort.Click += new System.EventHandler(this.btnInsertionSort_Click);
            // 
            // lblAfter
            // 
            this.lblAfter.AutoSize = true;
            this.lblAfter.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblAfter.Location = new System.Drawing.Point(239, 119);
            this.lblAfter.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAfter.Name = "lblAfter";
            this.lblAfter.Size = new System.Drawing.Size(53, 20);
            this.lblAfter.TabIndex = 5;
            this.lblAfter.Text = "After";
            // 
            // tbxtAfterSorting
            // 
            this.tbxtAfterSorting.Location = new System.Drawing.Point(305, 114);
            this.tbxtAfterSorting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxtAfterSorting.Name = "tbxtAfterSorting";
            this.tbxtAfterSorting.Size = new System.Drawing.Size(309, 25);
            this.tbxtAfterSorting.TabIndex = 4;
            // 
            // tbxtBeforeSorting
            // 
            this.tbxtBeforeSorting.Location = new System.Drawing.Point(309, 59);
            this.tbxtBeforeSorting.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxtBeforeSorting.Name = "tbxtBeforeSorting";
            this.tbxtBeforeSorting.Size = new System.Drawing.Size(305, 25);
            this.tbxtBeforeSorting.TabIndex = 3;
            // 
            // lblBefore
            // 
            this.lblBefore.AutoSize = true;
            this.lblBefore.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.lblBefore.Location = new System.Drawing.Point(228, 59);
            this.lblBefore.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblBefore.Name = "lblBefore";
            this.lblBefore.Size = new System.Drawing.Size(65, 20);
            this.lblBefore.TabIndex = 2;
            this.lblBefore.Text = "Before";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbnString);
            this.groupBox1.Controls.Add(this.rbnDouble);
            this.groupBox1.Controls.Add(this.rbnInteger);
            this.groupBox1.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox1.Location = new System.Drawing.Point(29, 48);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(164, 116);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select DT";
            // 
            // rbnString
            // 
            this.rbnString.AutoSize = true;
            this.rbnString.Checked = true;
            this.rbnString.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbnString.Location = new System.Drawing.Point(23, 79);
            this.rbnString.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnString.Name = "rbnString";
            this.rbnString.Size = new System.Drawing.Size(80, 23);
            this.rbnString.TabIndex = 3;
            this.rbnString.TabStop = true;
            this.rbnString.Text = "String";
            this.rbnString.UseVisualStyleBackColor = true;
            // 
            // rbnDouble
            // 
            this.rbnDouble.AutoSize = true;
            this.rbnDouble.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbnDouble.Location = new System.Drawing.Point(23, 52);
            this.rbnDouble.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnDouble.Name = "rbnDouble";
            this.rbnDouble.Size = new System.Drawing.Size(89, 23);
            this.rbnDouble.TabIndex = 2;
            this.rbnDouble.Text = "Double";
            this.rbnDouble.UseVisualStyleBackColor = true;
            // 
            // rbnInteger
            // 
            this.rbnInteger.AutoSize = true;
            this.rbnInteger.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.rbnInteger.Location = new System.Drawing.Point(23, 26);
            this.rbnInteger.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rbnInteger.Name = "rbnInteger";
            this.rbnInteger.Size = new System.Drawing.Size(88, 23);
            this.rbnInteger.TabIndex = 1;
            this.rbnInteger.Text = "Integer";
            this.rbnInteger.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBox7);
            this.tabPage2.Controls.Add(this.textBox6);
            this.tabPage2.Controls.Add(this.textBox5);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Controls.Add(this.DoubleLL_btn);
            this.tabPage2.Controls.Add(this.PolyOperation_btn);
            this.tabPage2.Controls.Add(this.Single_btn);
            this.tabPage2.Controls.Add(this.Search_lbl);
            this.tabPage2.Controls.Add(this.Insert_lbl);
            this.tabPage2.Controls.Add(this.Delete_lbl);
            this.tabPage2.Controls.Add(this.textBox4);
            this.tabPage2.Controls.Add(this.textBox3);
            this.tabPage2.Controls.Add(this.textBox2);
            this.tabPage2.Controls.Add(this.tbxOriginginal);
            this.tabPage2.Controls.Add(this.Origianl_lbl);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage2.Size = new System.Drawing.Size(688, 533);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "LinkedList";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // DoubleLL_btn
            // 
            this.DoubleLL_btn.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.DoubleLL_btn.Location = new System.Drawing.Point(237, 435);
            this.DoubleLL_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.DoubleLL_btn.Name = "DoubleLL_btn";
            this.DoubleLL_btn.Size = new System.Drawing.Size(151, 48);
            this.DoubleLL_btn.TabIndex = 10;
            this.DoubleLL_btn.Text = "Double LL";
            this.DoubleLL_btn.UseVisualStyleBackColor = true;
            // 
            // PolyOperation_btn
            // 
            this.PolyOperation_btn.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.PolyOperation_btn.Location = new System.Drawing.Point(443, 435);
            this.PolyOperation_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.PolyOperation_btn.Name = "PolyOperation_btn";
            this.PolyOperation_btn.Size = new System.Drawing.Size(199, 48);
            this.PolyOperation_btn.TabIndex = 9;
            this.PolyOperation_btn.Text = "Poly Operation";
            this.PolyOperation_btn.UseVisualStyleBackColor = true;
            // 
            // Single_btn
            // 
            this.Single_btn.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Single_btn.Location = new System.Drawing.Point(29, 435);
            this.Single_btn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Single_btn.Name = "Single_btn";
            this.Single_btn.Size = new System.Drawing.Size(151, 48);
            this.Single_btn.TabIndex = 8;
            this.Single_btn.Text = "Single LL";
            this.Single_btn.UseVisualStyleBackColor = true;
            this.Single_btn.Click += new System.EventHandler(this.Single_btn_Click);
            // 
            // Search_lbl
            // 
            this.Search_lbl.AutoSize = true;
            this.Search_lbl.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Search_lbl.Location = new System.Drawing.Point(222, 153);
            this.Search_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Search_lbl.Name = "Search_lbl";
            this.Search_lbl.Size = new System.Drawing.Size(75, 20);
            this.Search_lbl.TabIndex = 7;
            this.Search_lbl.Text = "Search";
            this.Search_lbl.Click += new System.EventHandler(this.Search_lbl_Click);
            // 
            // Insert_lbl
            // 
            this.Insert_lbl.AutoSize = true;
            this.Insert_lbl.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Insert_lbl.Location = new System.Drawing.Point(378, 153);
            this.Insert_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Insert_lbl.Name = "Insert_lbl";
            this.Insert_lbl.Size = new System.Drawing.Size(75, 20);
            this.Insert_lbl.TabIndex = 6;
            this.Insert_lbl.Text = "Insert";
            // 
            // Delete_lbl
            // 
            this.Delete_lbl.AutoSize = true;
            this.Delete_lbl.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Delete_lbl.Location = new System.Drawing.Point(541, 153);
            this.Delete_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Delete_lbl.Name = "Delete_lbl";
            this.Delete_lbl.Size = new System.Drawing.Size(75, 20);
            this.Delete_lbl.TabIndex = 5;
            this.Delete_lbl.Text = "Delete";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(185, 177);
            this.textBox4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(152, 238);
            this.textBox4.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(345, 177);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Multiline = true;
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(152, 238);
            this.textBox3.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(505, 177);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(152, 238);
            this.textBox2.TabIndex = 2;
            // 
            // tbxOriginginal
            // 
            this.tbxOriginginal.Location = new System.Drawing.Point(25, 177);
            this.tbxOriginginal.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tbxOriginginal.Multiline = true;
            this.tbxOriginginal.Name = "tbxOriginginal";
            this.tbxOriginginal.Size = new System.Drawing.Size(152, 238);
            this.tbxOriginginal.TabIndex = 1;
            this.tbxOriginginal.TextChanged += new System.EventHandler(this.Before_TextChanged);
            // 
            // Origianl_lbl
            // 
            this.Origianl_lbl.AutoSize = true;
            this.Origianl_lbl.Font = new System.Drawing.Font("標楷體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.Origianl_lbl.Location = new System.Drawing.Point(54, 153);
            this.Origianl_lbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Origianl_lbl.Name = "Origianl_lbl";
            this.Origianl_lbl.Size = new System.Drawing.Size(97, 20);
            this.Origianl_lbl.TabIndex = 0;
            this.Origianl_lbl.Text = "Origianl";
            // 
            // tpgLoopRecurslve
            // 
            this.tpgLoopRecurslve.Location = new System.Drawing.Point(4, 25);
            this.tpgLoopRecurslve.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgLoopRecurslve.Name = "tpgLoopRecurslve";
            this.tpgLoopRecurslve.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tpgLoopRecurslve.Size = new System.Drawing.Size(688, 533);
            this.tpgLoopRecurslve.TabIndex = 2;
            this.tpgLoopRecurslve.Text = "LoopRecursive";
            this.tpgLoopRecurslve.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage3.Size = new System.Drawing.Size(688, 533);
            this.tabPage3.TabIndex = 3;
            this.tabPage3.Text = "Stack";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 25);
            this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage4.Size = new System.Drawing.Size(688, 533);
            this.tabPage4.TabIndex = 4;
            this.tabPage4.Text = "Queue";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 25);
            this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage5.Size = new System.Drawing.Size(688, 533);
            this.tabPage5.TabIndex = 5;
            this.tabPage5.Text = "Tree";
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // tabPage6
            // 
            this.tabPage6.Location = new System.Drawing.Point(4, 25);
            this.tabPage6.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage6.Name = "tabPage6";
            this.tabPage6.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.tabPage6.Size = new System.Drawing.Size(688, 533);
            this.tabPage6.TabIndex = 6;
            this.tabPage6.Text = "B Tree";
            this.tabPage6.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.radioButton1);
            this.groupBox2.Controls.Add(this.radioButton2);
            this.groupBox2.Controls.Add(this.radioButton3);
            this.groupBox2.Font = new System.Drawing.Font("新細明體", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.groupBox2.Location = new System.Drawing.Point(38, 23);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(164, 116);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Select DT";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton1.Location = new System.Drawing.Point(23, 79);
            this.radioButton1.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(80, 23);
            this.radioButton1.TabIndex = 3;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "String";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton2.Location = new System.Drawing.Point(23, 52);
            this.radioButton2.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(89, 23);
            this.radioButton2.TabIndex = 2;
            this.radioButton2.Text = "Double";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Font = new System.Drawing.Font("新細明體", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.radioButton3.Location = new System.Drawing.Point(23, 26);
            this.radioButton3.Margin = new System.Windows.Forms.Padding(4);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(88, 23);
            this.radioButton3.TabIndex = 1;
            this.radioButton3.Text = "Integer";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(439, 102);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 20);
            this.label1.TabIndex = 12;
            this.label1.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(233, 103);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 20);
            this.label2.TabIndex = 13;
            this.label2.Text = "I/D/E/S";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("新細明體", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label3.Location = new System.Drawing.Point(233, 35);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 14;
            this.label3.Text = "Create";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(512, 103);
            this.textBox5.Margin = new System.Windows.Forms.Padding(4);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(128, 25);
            this.textBox5.TabIndex = 15;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(306, 103);
            this.textBox6.Margin = new System.Windows.Forms.Padding(4);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(120, 25);
            this.textBox6.TabIndex = 16;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(306, 36);
            this.textBox7.Margin = new System.Windows.Forms.Padding(4);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(327, 25);
            this.textBox7.TabIndex = 17;
            // 
            // frmMainEntrance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1067, 562);
            this.Controls.Add(this.tpgQueue);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMainEntrance";
            this.Text = "MainEntrance";
            this.tpgQueue.ResumeLayout(false);
            this.tbgSorting.ResumeLayout(false);
            this.tbgSorting.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tpgQueue;
        private System.Windows.Forms.TabPage tbgSorting;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tpgLoopRecurslve;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbnDouble;
        private System.Windows.Forms.RadioButton rbnInteger;
        private System.Windows.Forms.RadioButton rbnString;
        private System.Windows.Forms.TextBox tbxtAfterSorting;
        private System.Windows.Forms.TextBox tbxtBeforeSorting;
        private System.Windows.Forms.Label lblBefore;
        private System.Windows.Forms.Label lblAfter;
        private System.Windows.Forms.Button btnInsertionSort;
        private System.Windows.Forms.Button btnSelectionSort;
        private System.Windows.Forms.Button btnMergeSort;
        private System.Windows.Forms.Label Search_lbl;
        private System.Windows.Forms.Label Insert_lbl;
        private System.Windows.Forms.Label Delete_lbl;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox tbxOriginginal;
        private System.Windows.Forms.Label Origianl_lbl;
        private System.Windows.Forms.Button Single_btn;
        private System.Windows.Forms.Button DoubleLL_btn;
        private System.Windows.Forms.Button PolyOperation_btn;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
    }
}

