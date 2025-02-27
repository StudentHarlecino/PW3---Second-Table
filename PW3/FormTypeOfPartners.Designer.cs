namespace PW3
{
    partial class FormTypeOfPartners
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
            dataGridViewType = new DataGridView();
            buttonTypeDelete = new Button();
            buttonTypeEdit = new Button();
            buttonTypeAdd = new Button();
            panelFill = new Panel();
            flowLayoutPanelTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewType).BeginInit();
            panelFill.SuspendLayout();
            flowLayoutPanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridViewType
            // 
            dataGridViewType.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewType.BackgroundColor = Color.White;
            dataGridViewType.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewType.Dock = DockStyle.Fill;
            dataGridViewType.Location = new Point(10, 10);
            dataGridViewType.MultiSelect = false;
            dataGridViewType.Name = "dataGridViewType";
            dataGridViewType.ReadOnly = true;
            dataGridViewType.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewType.Size = new Size(780, 364);
            dataGridViewType.TabIndex = 0;
            // 
            // buttonTypeDelete
            // 
            buttonTypeDelete.Location = new Point(324, 12);
            buttonTypeDelete.Name = "buttonTypeDelete";
            buttonTypeDelete.Size = new Size(137, 34);
            buttonTypeDelete.TabIndex = 2;
            buttonTypeDelete.Text = "Удалить";
            buttonTypeDelete.UseVisualStyleBackColor = true;
            buttonTypeDelete.Click += buttonTypeDelete_Click;
            // 
            // buttonTypeEdit
            // 
            buttonTypeEdit.Location = new Point(162, 12);
            buttonTypeEdit.Name = "buttonTypeEdit";
            buttonTypeEdit.Size = new Size(156, 34);
            buttonTypeEdit.TabIndex = 1;
            buttonTypeEdit.Text = "Редактировать";
            buttonTypeEdit.UseVisualStyleBackColor = true;
            buttonTypeEdit.Click += buttonTypeEdit_Click;
            // 
            // buttonTypeAdd
            // 
            buttonTypeAdd.Location = new Point(19, 12);
            buttonTypeAdd.Name = "buttonTypeAdd";
            buttonTypeAdd.Size = new Size(137, 34);
            buttonTypeAdd.TabIndex = 0;
            buttonTypeAdd.Text = "Добавить";
            buttonTypeAdd.UseVisualStyleBackColor = true;
            buttonTypeAdd.Click += buttonTypeAdd_Click;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(dataGridViewType);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 66);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(800, 384);
            panelFill.TabIndex = 3;
            // 
            // flowLayoutPanelTop
            // 
            flowLayoutPanelTop.AutoSize = true;
            flowLayoutPanelTop.BackColor = Color.White;
            flowLayoutPanelTop.Controls.Add(buttonTypeDelete);
            flowLayoutPanelTop.Controls.Add(buttonTypeEdit);
            flowLayoutPanelTop.Controls.Add(buttonTypeAdd);
            flowLayoutPanelTop.Dock = DockStyle.Top;
            flowLayoutPanelTop.Location = new Point(0, 0);
            flowLayoutPanelTop.Margin = new Padding(5);
            flowLayoutPanelTop.Name = "flowLayoutPanelTop";
            flowLayoutPanelTop.Padding = new Padding(16, 17, 16, 17);
            flowLayoutPanelTop.Size = new Size(800, 66);
            flowLayoutPanelTop.TabIndex = 2;
            // 
            // FormTypeOfPartners
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Name = "FormTypeOfPartners";
            Text = "Типы партнеров";
            WindowState = FormWindowState.Maximized;
            Load += FormTypeOfPartners_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewType).EndInit();
            panelFill.ResumeLayout(false);
            flowLayoutPanelTop.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewType;
        private Button buttonTypeDelete;
        private Button buttonTypeEdit;
        private Button buttonTypeAdd;
        private Panel panelFill;
        private Panel flowLayoutPanelTop;
    }
}