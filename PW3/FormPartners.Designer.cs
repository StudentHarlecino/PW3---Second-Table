namespace PW3
{
    partial class FormPartners
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
            buttonTypeDelete = new Button();
            buttonTypeEdit = new Button();
            buttonTypeAdd = new Button();
            dataGridViewPartners = new DataGridView();
            panelFill = new Panel();
            flowLayoutPanelTop = new Panel();
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartners).BeginInit();
            panelFill.SuspendLayout();
            flowLayoutPanelTop.SuspendLayout();
            SuspendLayout();
            // 
            // buttonTypeDelete
            // 
            buttonTypeDelete.Location = new Point(324, 12);
            buttonTypeDelete.Name = "buttonTypeDelete";
            buttonTypeDelete.Size = new Size(137, 34);
            buttonTypeDelete.TabIndex = 2;
            buttonTypeDelete.Text = "Удалить";
            buttonTypeDelete.UseVisualStyleBackColor = true;
            // 
            // buttonTypeEdit
            // 
            buttonTypeEdit.Location = new Point(162, 12);
            buttonTypeEdit.Name = "buttonTypeEdit";
            buttonTypeEdit.Size = new Size(156, 34);
            buttonTypeEdit.TabIndex = 1;
            buttonTypeEdit.Text = "Редактировать";
            buttonTypeEdit.UseVisualStyleBackColor = true;
            // 
            // buttonTypeAdd
            // 
            buttonTypeAdd.Location = new Point(19, 12);
            buttonTypeAdd.Name = "buttonTypeAdd";
            buttonTypeAdd.Size = new Size(137, 34);
            buttonTypeAdd.TabIndex = 0;
            buttonTypeAdd.Text = "Добавить";
            buttonTypeAdd.UseVisualStyleBackColor = true;
            // 
            // dataGridViewPartners
            // 
            dataGridViewPartners.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            dataGridViewPartners.BackgroundColor = Color.White;
            dataGridViewPartners.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewPartners.Dock = DockStyle.Fill;
            dataGridViewPartners.Location = new Point(10, 10);
            dataGridViewPartners.MultiSelect = false;
            dataGridViewPartners.Name = "dataGridViewPartners";
            dataGridViewPartners.ReadOnly = true;
            dataGridViewPartners.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewPartners.Size = new Size(780, 364);
            dataGridViewPartners.TabIndex = 0;
            // 
            // panelFill
            // 
            panelFill.BackColor = Color.White;
            panelFill.Controls.Add(dataGridViewPartners);
            panelFill.Dock = DockStyle.Fill;
            panelFill.Location = new Point(0, 66);
            panelFill.Name = "panelFill";
            panelFill.Padding = new Padding(10);
            panelFill.Size = new Size(800, 384);
            panelFill.TabIndex = 5;
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
            flowLayoutPanelTop.TabIndex = 4;
            // 
            // FormPartners
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelFill);
            Controls.Add(flowLayoutPanelTop);
            Name = "FormPartners";
            Text = "FormPartners";
            ((System.ComponentModel.ISupportInitialize)dataGridViewPartners).EndInit();
            panelFill.ResumeLayout(false);
            flowLayoutPanelTop.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonTypeDelete;
        private Button buttonTypeEdit;
        private Button buttonTypeAdd;
        private DataGridView dataGridViewPartners;
        private Panel panelFill;
        private Panel flowLayoutPanelTop;
    }
}