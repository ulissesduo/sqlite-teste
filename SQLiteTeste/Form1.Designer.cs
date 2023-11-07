namespace SQLiteTeste
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
            btnReadAll = new Button();
            dataGridView1 = new DataGridView();
            label3 = new Label();
            label1 = new Label();
            txtWater = new TextBox();
            txtfood = new TextBox();
            btnInsert = new Button();
            btnUpdateFood = new Button();
            btnUpdateWater = new Button();
            txtFoodR = new TextBox();
            txtPremium = new TextBox();
            txtChicken = new TextBox();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            UpdateChicken = new Button();
            UpdateFoodR = new Button();
            UpdatePremium = new Button();
            btnDelete = new Button();
            btnGetList = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnReadAll
            // 
            btnReadAll.Location = new Point(730, 279);
            btnReadAll.Name = "btnReadAll";
            btnReadAll.Size = new Size(94, 29);
            btnReadAll.TabIndex = 21;
            btnReadAll.Text = "Read All";
            btnReadAll.UseVisualStyleBackColor = true;
            btnReadAll.Click += button2_Click_1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(451, 361);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.RowTemplate.Height = 29;
            dataGridView1.Size = new Size(594, 188);
            dataGridView1.TabIndex = 20;
            dataGridView1.CellBeginEdit += dataGridView1_CellBeginEdit;
            dataGridView1.CellEndEdit += dataGridView1_CellEndEdit;
            dataGridView1.CellValueChanged += dataGridView1_CellValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(540, 53);
            label3.Name = "label3";
            label3.Size = new Size(82, 20);
            label3.TabIndex = 19;
            label3.Text = "Water (ml):";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(111, 45);
            label1.Name = "label1";
            label1.Size = new Size(69, 20);
            label1.TabIndex = 16;
            label1.Text = "Food (g):";
            // 
            // txtWater
            // 
            txtWater.Location = new Point(642, 45);
            txtWater.Name = "txtWater";
            txtWater.Size = new Size(125, 27);
            txtWater.TabIndex = 14;
            // 
            // txtfood
            // 
            txtfood.Location = new Point(191, 42);
            txtfood.Name = "txtfood";
            txtfood.Size = new Size(125, 27);
            txtfood.TabIndex = 12;
            txtfood.Text = "0";
            // 
            // btnInsert
            // 
            btnInsert.Location = new Point(617, 279);
            btnInsert.Name = "btnInsert";
            btnInsert.Size = new Size(94, 29);
            btnInsert.TabIndex = 11;
            btnInsert.Text = "Add";
            btnInsert.UseVisualStyleBackColor = true;
            btnInsert.Click += button1_Click;
            // 
            // btnUpdateFood
            // 
            btnUpdateFood.Location = new Point(335, 42);
            btnUpdateFood.Name = "btnUpdateFood";
            btnUpdateFood.Size = new Size(94, 29);
            btnUpdateFood.TabIndex = 22;
            btnUpdateFood.Text = "Update";
            btnUpdateFood.UseVisualStyleBackColor = true;
            // 
            // btnUpdateWater
            // 
            btnUpdateWater.Location = new Point(786, 45);
            btnUpdateWater.Name = "btnUpdateWater";
            btnUpdateWater.Size = new Size(94, 29);
            btnUpdateWater.TabIndex = 23;
            btnUpdateWater.Text = "Update";
            btnUpdateWater.UseVisualStyleBackColor = true;
            // 
            // txtFoodR
            // 
            txtFoodR.Location = new Point(191, 82);
            txtFoodR.Name = "txtFoodR";
            txtFoodR.Size = new Size(125, 27);
            txtFoodR.TabIndex = 26;
            txtFoodR.Text = "0";
            // 
            // txtPremium
            // 
            txtPremium.Location = new Point(191, 135);
            txtPremium.Name = "txtPremium";
            txtPremium.Size = new Size(125, 27);
            txtPremium.TabIndex = 27;
            txtPremium.Text = "0";
            // 
            // txtChicken
            // 
            txtChicken.Location = new Point(191, 184);
            txtChicken.Name = "txtChicken";
            txtChicken.Size = new Size(125, 27);
            txtChicken.TabIndex = 28;
            txtChicken.Text = "0";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(102, 89);
            label5.Name = "label5";
            label5.Size = new Size(78, 20);
            label5.TabIndex = 29;
            label5.Text = "FoodR (g):";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(94, 191);
            label6.Name = "label6";
            label6.Size = new Size(86, 20);
            label6.TabIndex = 31;
            label6.Text = "Chicken (g):";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(86, 139);
            label7.Name = "label7";
            label7.Size = new Size(94, 20);
            label7.TabIndex = 30;
            label7.Text = "Premium (g):";
            // 
            // UpdateChicken
            // 
            UpdateChicken.Location = new Point(335, 187);
            UpdateChicken.Name = "UpdateChicken";
            UpdateChicken.Size = new Size(94, 29);
            UpdateChicken.TabIndex = 32;
            UpdateChicken.Text = "Update";
            UpdateChicken.UseVisualStyleBackColor = true;
            // 
            // UpdateFoodR
            // 
            UpdateFoodR.Location = new Point(335, 82);
            UpdateFoodR.Name = "UpdateFoodR";
            UpdateFoodR.Size = new Size(94, 29);
            UpdateFoodR.TabIndex = 33;
            UpdateFoodR.Text = "Update";
            UpdateFoodR.UseVisualStyleBackColor = true;
            // 
            // UpdatePremium
            // 
            UpdatePremium.Location = new Point(335, 134);
            UpdatePremium.Name = "UpdatePremium";
            UpdatePremium.Size = new Size(94, 29);
            UpdatePremium.TabIndex = 34;
            UpdatePremium.Text = "Update";
            UpdatePremium.UseVisualStyleBackColor = true;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(853, 279);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(94, 29);
            btnDelete.TabIndex = 37;
            btnDelete.Text = "Delete";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnGetList
            // 
            btnGetList.Location = new Point(644, 174);
            btnGetList.Name = "btnGetList";
            btnGetList.Size = new Size(94, 29);
            btnGetList.TabIndex = 38;
            btnGetList.Text = "button1";
            btnGetList.UseVisualStyleBackColor = true;
            btnGetList.Click += btnGetList_Click;
            // 
            // button1
            // 
            button1.Location = new Point(774, 178);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 39;
            button1.Text = "Somar";
            button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 608);
            Controls.Add(button1);
            Controls.Add(btnGetList);
            Controls.Add(btnDelete);
            Controls.Add(UpdatePremium);
            Controls.Add(UpdateFoodR);
            Controls.Add(UpdateChicken);
            Controls.Add(label6);
            Controls.Add(label7);
            Controls.Add(label5);
            Controls.Add(txtChicken);
            Controls.Add(txtPremium);
            Controls.Add(txtFoodR);
            Controls.Add(btnUpdateWater);
            Controls.Add(btnUpdateFood);
            Controls.Add(btnReadAll);
            Controls.Add(dataGridView1);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(txtWater);
            Controls.Add(txtfood);
            Controls.Add(btnInsert);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnReadAll;
        private DataGridView dataGridView1;
        private Label label3;
        private Label label1;
        private TextBox txtWater;
        private TextBox txtfood;
        private Button btnInsert;
        private Button btnUpdateFood;
        private Button btnUpdateWater;
        private TextBox txtFoodR;
        private TextBox txtPremium;
        private TextBox txtChicken;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button UpdateChicken;
        private Button UpdateFoodR;
        private Button UpdatePremium;
        private Button btnDelete;
        private Button btnGetList;
        private Button button1;
    }
}