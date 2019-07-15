namespace CRP
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label firstNameLabel;
            System.Windows.Forms.Label lastNameLabel;
            System.Windows.Forms.Label emailLabel;
            System.Windows.Forms.Label costumerCodeLabel;
            System.Windows.Forms.Label requestLabel;
            this.dejsair_CostumerRequestDBDataSet = new CRP.dejsair_CostumerRequestDBDataSet();
            this.costumerRequestTBBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.costumerRequestTBTableAdapter = new CRP.dejsair_CostumerRequestDBDataSetTableAdapters.CostumerRequestTBTableAdapter();
            this.tableAdapterManager = new CRP.dejsair_CostumerRequestDBDataSetTableAdapters.TableAdapterManager();
            this.firstNameTextBox = new System.Windows.Forms.TextBox();
            this.lastNameTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.costumerCodeTextBox = new System.Windows.Forms.TextBox();
            this.requestTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            firstNameLabel = new System.Windows.Forms.Label();
            lastNameLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            costumerCodeLabel = new System.Windows.Forms.Label();
            requestLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dejsair_CostumerRequestDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumerRequestTBBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // firstNameLabel
            // 
            firstNameLabel.AutoSize = true;
            firstNameLabel.BackColor = System.Drawing.Color.LightSkyBlue;
            firstNameLabel.Location = new System.Drawing.Point(12, 15);
            firstNameLabel.Name = "firstNameLabel";
            firstNameLabel.Size = new System.Drawing.Size(90, 20);
            firstNameLabel.TabIndex = 1;
            firstNameLabel.Text = "First Name:";
            // 
            // lastNameLabel
            // 
            lastNameLabel.AutoSize = true;
            lastNameLabel.Location = new System.Drawing.Point(12, 59);
            lastNameLabel.Name = "lastNameLabel";
            lastNameLabel.Size = new System.Drawing.Size(90, 20);
            lastNameLabel.TabIndex = 2;
            lastNameLabel.Text = "Last Name:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Location = new System.Drawing.Point(34, 109);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(57, 20);
            emailLabel.TabIndex = 6;
            emailLabel.Text = "E-mail:";
            // 
            // costumerCodeLabel
            // 
            costumerCodeLabel.AutoSize = true;
            costumerCodeLabel.Location = new System.Drawing.Point(279, 35);
            costumerCodeLabel.Name = "costumerCodeLabel";
            costumerCodeLabel.Size = new System.Drawing.Size(124, 20);
            costumerCodeLabel.TabIndex = 8;
            costumerCodeLabel.Text = "Costumer Code:";
            // 
            // requestLabel
            // 
            requestLabel.AutoSize = true;
            requestLabel.Location = new System.Drawing.Point(12, 201);
            requestLabel.Name = "requestLabel";
            requestLabel.Size = new System.Drawing.Size(74, 20);
            requestLabel.TabIndex = 10;
            requestLabel.Text = "Request:";
            // 
            // dejsair_CostumerRequestDBDataSet
            // 
            this.dejsair_CostumerRequestDBDataSet.DataSetName = "dejsair_CostumerRequestDBDataSet";
            this.dejsair_CostumerRequestDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // costumerRequestTBBindingSource
            // 
            this.costumerRequestTBBindingSource.DataMember = "CostumerRequestTB";
            this.costumerRequestTBBindingSource.DataSource = this.dejsair_CostumerRequestDBDataSet;
            // 
            // costumerRequestTBTableAdapter
            // 
            this.costumerRequestTBTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CostumerRequestTBTableAdapter = this.costumerRequestTBTableAdapter;
            this.tableAdapterManager.UpdateOrder = CRP.dejsair_CostumerRequestDBDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // firstNameTextBox
            // 
            this.firstNameTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.firstNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costumerRequestTBBindingSource, "FirstName", true));
            this.firstNameTextBox.Location = new System.Drawing.Point(108, 12);
            this.firstNameTextBox.Name = "firstNameTextBox";
            this.firstNameTextBox.Size = new System.Drawing.Size(165, 26);
            this.firstNameTextBox.TabIndex = 2;
            // 
            // lastNameTextBox
            // 
            this.lastNameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costumerRequestTBBindingSource, "LastName", true));
            this.lastNameTextBox.Location = new System.Drawing.Point(108, 56);
            this.lastNameTextBox.Name = "lastNameTextBox";
            this.lastNameTextBox.Size = new System.Drawing.Size(165, 26);
            this.lastNameTextBox.TabIndex = 3;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costumerRequestTBBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(108, 103);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(427, 26);
            this.emailTextBox.TabIndex = 7;
            // 
            // costumerCodeTextBox
            // 
            this.costumerCodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costumerRequestTBBindingSource, "CostumerCode", true));
            this.costumerCodeTextBox.Location = new System.Drawing.Point(409, 32);
            this.costumerCodeTextBox.Name = "costumerCodeTextBox";
            this.costumerCodeTextBox.Size = new System.Drawing.Size(131, 26);
            this.costumerCodeTextBox.TabIndex = 9;
            // 
            // requestTextBox
            // 
            this.requestTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.costumerRequestTBBindingSource, "Request", true));
            this.requestTextBox.Location = new System.Drawing.Point(108, 145);
            this.requestTextBox.Multiline = true;
            this.requestTextBox.Name = "requestTextBox";
            this.requestTextBox.Size = new System.Drawing.Size(427, 167);
            this.requestTextBox.TabIndex = 11;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(27, 346);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 37);
            this.button1.TabIndex = 12;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(127, 346);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 37);
            this.button2.TabIndex = 13;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(555, 416);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(requestLabel);
            this.Controls.Add(this.requestTextBox);
            this.Controls.Add(costumerCodeLabel);
            this.Controls.Add(this.costumerCodeTextBox);
            this.Controls.Add(emailLabel);
            this.Controls.Add(this.emailTextBox);
            this.Controls.Add(lastNameLabel);
            this.Controls.Add(this.lastNameTextBox);
            this.Controls.Add(firstNameLabel);
            this.Controls.Add(this.firstNameTextBox);
            this.Name = "Form1";
            this.Text = "Request Window";
            ((System.ComponentModel.ISupportInitialize)(this.dejsair_CostumerRequestDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.costumerRequestTBBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private dejsair_CostumerRequestDBDataSet dejsair_CostumerRequestDBDataSet;
        private System.Windows.Forms.BindingSource costumerRequestTBBindingSource;
        private dejsair_CostumerRequestDBDataSetTableAdapters.CostumerRequestTBTableAdapter costumerRequestTBTableAdapter;
        private dejsair_CostumerRequestDBDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox firstNameTextBox;
        private System.Windows.Forms.TextBox lastNameTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.TextBox costumerCodeTextBox;
        private System.Windows.Forms.TextBox requestTextBox;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

