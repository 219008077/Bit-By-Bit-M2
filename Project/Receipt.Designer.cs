namespace Project
{
    partial class Receipt
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
            this.label1 = new System.Windows.Forms.Label();
            this.Items = new System.Windows.Forms.ListBox();
            this.groupPmb8DataSet = new Project.GroupPmb8DataSet();
            this.itemServicesTableAdapter = new Project.GroupPmb8DataSetTableAdapters.ItemServicesTableAdapter();
            this.itemServicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.close = new System.Windows.Forms.Button();
            this.itemsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.itemsTableAdapter = new Project.GroupPmb8DataSetTableAdapters.ItemsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.groupPmb8DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemServicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(92, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Receipt";
            // 
            // Items
            // 
            this.Items.Font = new System.Drawing.Font("Franklin Gothic Medium Cond", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Items.FormattingEnabled = true;
            this.Items.ItemHeight = 20;
            this.Items.Location = new System.Drawing.Point(12, 96);
            this.Items.Name = "Items";
            this.Items.Size = new System.Drawing.Size(330, 184);
            this.Items.TabIndex = 1;
            this.Items.SelectedIndexChanged += new System.EventHandler(this.Items_SelectedIndexChanged);
            // 
            // groupPmb8DataSet
            // 
            this.groupPmb8DataSet.DataSetName = "GroupPmb8DataSet";
            this.groupPmb8DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // itemServicesTableAdapter
            // 
            this.itemServicesTableAdapter.ClearBeforeFill = true;
            // 
            // itemServicesBindingSource
            // 
            this.itemServicesBindingSource.DataMember = "ItemServices";
            this.itemServicesBindingSource.DataSource = this.groupPmb8DataSet;
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(117, 403);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(128, 33);
            this.close.TabIndex = 2;
            this.close.Text = "close";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // itemsTableAdapter
            // 
            this.itemsTableAdapter.ClearBeforeFill = true;
            // 
            // Receipt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(354, 448);
            this.Controls.Add(this.close);
            this.Controls.Add(this.Items);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Receipt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Receipt";
            this.Load += new System.EventHandler(this.Receipt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupPmb8DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemServicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.itemsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Items;
        private GroupPmb8DataSet groupPmb8DataSet;
        private System.Windows.Forms.BindingSource itemServicesBindingSource;
        private GroupPmb8DataSetTableAdapters.ItemServicesTableAdapter itemServicesTableAdapter;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private GroupPmb8DataSetTableAdapters.ItemsTableAdapter itemsTableAdapter;
    }
}