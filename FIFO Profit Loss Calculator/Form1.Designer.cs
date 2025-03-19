namespace FIFO_Profit_Loss_Calculator
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
            components = new System.ComponentModel.Container();
            buttonUpload = new Button();
            dataGridView = new DataGridView();
            tradeIdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            typeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            dateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            clientDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            securityDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            amountDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            priceDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            feeDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            tradeBindingSource = new BindingSource(components);
            dateTimePicker1 = new DateTimePicker();
            bindingSource1 = new BindingSource(components);
            clientsList = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            calculate = new Button();
            richTextBox1 = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)dataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)tradeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            SuspendLayout();
            // 
            // buttonUpload
            // 
            buttonUpload.Location = new Point(782, 234);
            buttonUpload.Name = "buttonUpload";
            buttonUpload.Size = new Size(75, 23);
            buttonUpload.TabIndex = 0;
            buttonUpload.Text = "Upload";
            buttonUpload.UseVisualStyleBackColor = true;
            buttonUpload.Click += buttonUpload_Click;
            // 
            // dataGridView
            // 
            dataGridView.AutoGenerateColumns = false;
            dataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView.Columns.AddRange(new DataGridViewColumn[] { tradeIdDataGridViewTextBoxColumn, typeDataGridViewTextBoxColumn, dateDataGridViewTextBoxColumn, clientDataGridViewTextBoxColumn, securityDataGridViewTextBoxColumn, amountDataGridViewTextBoxColumn, priceDataGridViewTextBoxColumn, feeDataGridViewTextBoxColumn });
            dataGridView.DataSource = tradeBindingSource;
            dataGridView.Location = new Point(12, 12);
            dataGridView.Name = "dataGridView";
            dataGridView.Size = new Size(845, 216);
            dataGridView.TabIndex = 1;
            // 
            // tradeIdDataGridViewTextBoxColumn
            // 
            tradeIdDataGridViewTextBoxColumn.DataPropertyName = "TradeId";
            tradeIdDataGridViewTextBoxColumn.HeaderText = "TradeId";
            tradeIdDataGridViewTextBoxColumn.Name = "tradeIdDataGridViewTextBoxColumn";
            // 
            // typeDataGridViewTextBoxColumn
            // 
            typeDataGridViewTextBoxColumn.DataPropertyName = "Type";
            typeDataGridViewTextBoxColumn.HeaderText = "Type";
            typeDataGridViewTextBoxColumn.Name = "typeDataGridViewTextBoxColumn";
            // 
            // dateDataGridViewTextBoxColumn
            // 
            dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            dateDataGridViewTextBoxColumn.HeaderText = "Date";
            dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            // 
            // clientDataGridViewTextBoxColumn
            // 
            clientDataGridViewTextBoxColumn.DataPropertyName = "Client";
            clientDataGridViewTextBoxColumn.HeaderText = "Client";
            clientDataGridViewTextBoxColumn.Name = "clientDataGridViewTextBoxColumn";
            // 
            // securityDataGridViewTextBoxColumn
            // 
            securityDataGridViewTextBoxColumn.DataPropertyName = "Security";
            securityDataGridViewTextBoxColumn.HeaderText = "Security";
            securityDataGridViewTextBoxColumn.Name = "securityDataGridViewTextBoxColumn";
            // 
            // amountDataGridViewTextBoxColumn
            // 
            amountDataGridViewTextBoxColumn.DataPropertyName = "Amount";
            amountDataGridViewTextBoxColumn.HeaderText = "Amount";
            amountDataGridViewTextBoxColumn.Name = "amountDataGridViewTextBoxColumn";
            // 
            // priceDataGridViewTextBoxColumn
            // 
            priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            priceDataGridViewTextBoxColumn.HeaderText = "Price";
            priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            // 
            // feeDataGridViewTextBoxColumn
            // 
            feeDataGridViewTextBoxColumn.DataPropertyName = "Fee";
            feeDataGridViewTextBoxColumn.HeaderText = "Fee";
            feeDataGridViewTextBoxColumn.Name = "feeDataGridViewTextBoxColumn";
            // 
            // tradeBindingSource
            // 
            tradeBindingSource.DataSource = typeof(Trade);
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(12, 249);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(206, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // clientsList
            // 
            clientsList.DropDownStyle = ComboBoxStyle.DropDownList;
            clientsList.FormattingEnabled = true;
            clientsList.Location = new Point(12, 293);
            clientsList.Name = "clientsList";
            clientsList.Size = new Size(121, 23);
            clientsList.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 231);
            label1.Name = "label1";
            label1.Size = new Size(109, 15);
            label1.TabIndex = 5;
            label1.Text = "Calculate until date";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 275);
            label2.Name = "label2";
            label2.Size = new Size(43, 15);
            label2.TabIndex = 6;
            label2.Text = "Clients";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 319);
            label4.Name = "label4";
            label4.Size = new Size(36, 15);
            label4.TabIndex = 9;
            label4.Text = "Profit";
            // 
            // calculate
            // 
            calculate.Location = new Point(782, 336);
            calculate.Name = "calculate";
            calculate.Size = new Size(75, 23);
            calculate.TabIndex = 10;
            calculate.Text = "Calculate";
            calculate.UseVisualStyleBackColor = true;
            calculate.Click += calculate_Click;
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(12, 337);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(132, 96);
            richTextBox1.TabIndex = 11;
            richTextBox1.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 445);
            Controls.Add(richTextBox1);
            Controls.Add(calculate);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(clientsList);
            Controls.Add(dateTimePicker1);
            Controls.Add(dataGridView);
            Controls.Add(buttonUpload);
            Name = "Form1";
            Text = "Calculator";
            ((System.ComponentModel.ISupportInitialize)dataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)tradeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonUpload;
        private DataGridView dataGridView;
        private DataGridViewTextBoxColumn tradeIdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn typeDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn clientDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn securityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn amountDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn feeDataGridViewTextBoxColumn;
        private BindingSource tradeBindingSource;
        private DateTimePicker dateTimePicker1;
        private BindingSource bindingSource1;
        private ComboBox clientsList;
        private Label label1;
        private Label label2;
        private Label label4;
        private Button calculate;
        private RichTextBox richTextBox1;
    }
}
