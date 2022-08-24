namespace AdoNetDemoProject
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
            this.dgwProducts = new System.Windows.Forms.DataGridView();
            this.gbxProucts = new System.Windows.Forms.GroupBox();
            this.gbxAdd = new System.Windows.Forms.GroupBox();
            this.tbxAddStockAmount = new System.Windows.Forms.TextBox();
            this.tbxAddUnitPrice = new System.Windows.Forms.TextBox();
            this.lblAddUnitPrice = new System.Windows.Forms.Label();
            this.lblAddStockAmount = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.tbxAddName = new System.Windows.Forms.TextBox();
            this.lblAddName = new System.Windows.Forms.Label();
            this.gbxUpdate = new System.Windows.Forms.GroupBox();
            this.tbxUpdateStockAmount = new System.Windows.Forms.TextBox();
            this.tbxUpdateUnitPrice = new System.Windows.Forms.TextBox();
            this.lbUpdateUnitPrice = new System.Windows.Forms.Label();
            this.lbUpdateStockAmount = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.tbxUpdateName = new System.Windows.Forms.TextBox();
            this.lbUpdateName = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).BeginInit();
            this.gbxProucts.SuspendLayout();
            this.gbxAdd.SuspendLayout();
            this.gbxUpdate.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgwProducts
            // 
            this.dgwProducts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwProducts.Location = new System.Drawing.Point(24, 39);
            this.dgwProducts.Name = "dgwProducts";
            this.dgwProducts.RowHeadersWidth = 51;
            this.dgwProducts.RowTemplate.Height = 24;
            this.dgwProducts.Size = new System.Drawing.Size(1074, 231);
            this.dgwProducts.TabIndex = 0;
            this.dgwProducts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgwProducts_CellClick);
            // 
            // gbxProucts
            // 
            this.gbxProucts.Controls.Add(this.dgwProducts);
            this.gbxProucts.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxProucts.Location = new System.Drawing.Point(23, 21);
            this.gbxProucts.Name = "gbxProucts";
            this.gbxProucts.Size = new System.Drawing.Size(1122, 292);
            this.gbxProucts.TabIndex = 1;
            this.gbxProucts.TabStop = false;
            this.gbxProucts.Text = "Products";
            // 
            // gbxAdd
            // 
            this.gbxAdd.Controls.Add(this.tbxAddStockAmount);
            this.gbxAdd.Controls.Add(this.tbxAddUnitPrice);
            this.gbxAdd.Controls.Add(this.lblAddUnitPrice);
            this.gbxAdd.Controls.Add(this.lblAddStockAmount);
            this.gbxAdd.Controls.Add(this.btnAdd);
            this.gbxAdd.Controls.Add(this.tbxAddName);
            this.gbxAdd.Controls.Add(this.lblAddName);
            this.gbxAdd.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxAdd.Location = new System.Drawing.Point(23, 389);
            this.gbxAdd.Name = "gbxAdd";
            this.gbxAdd.Size = new System.Drawing.Size(550, 271);
            this.gbxAdd.TabIndex = 2;
            this.gbxAdd.TabStop = false;
            this.gbxAdd.Text = "Add a Product";
            // 
            // tbxAddStockAmount
            // 
            this.tbxAddStockAmount.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddStockAmount.Location = new System.Drawing.Point(185, 139);
            this.tbxAddStockAmount.Name = "tbxAddStockAmount";
            this.tbxAddStockAmount.Size = new System.Drawing.Size(291, 36);
            this.tbxAddStockAmount.TabIndex = 6;
            // 
            // tbxAddUnitPrice
            // 
            this.tbxAddUnitPrice.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddUnitPrice.Location = new System.Drawing.Point(185, 94);
            this.tbxAddUnitPrice.Name = "tbxAddUnitPrice";
            this.tbxAddUnitPrice.Size = new System.Drawing.Size(291, 36);
            this.tbxAddUnitPrice.TabIndex = 5;
            // 
            // lblAddUnitPrice
            // 
            this.lblAddUnitPrice.AutoSize = true;
            this.lblAddUnitPrice.Location = new System.Drawing.Point(40, 93);
            this.lblAddUnitPrice.Name = "lblAddUnitPrice";
            this.lblAddUnitPrice.Size = new System.Drawing.Size(94, 23);
            this.lblAddUnitPrice.TabIndex = 4;
            this.lblAddUnitPrice.Text = "Unit Price";
            // 
            // lblAddStockAmount
            // 
            this.lblAddStockAmount.AutoSize = true;
            this.lblAddStockAmount.Location = new System.Drawing.Point(40, 139);
            this.lblAddStockAmount.Name = "lblAddStockAmount";
            this.lblAddStockAmount.Size = new System.Drawing.Size(131, 23);
            this.lblAddStockAmount.TabIndex = 3;
            this.lblAddStockAmount.Text = "Stock Amount";
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnAdd.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(235, 196);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(184, 52);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // tbxAddName
            // 
            this.tbxAddName.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxAddName.Location = new System.Drawing.Point(185, 46);
            this.tbxAddName.Name = "tbxAddName";
            this.tbxAddName.Size = new System.Drawing.Size(291, 36);
            this.tbxAddName.TabIndex = 1;
            // 
            // lblAddName
            // 
            this.lblAddName.AutoSize = true;
            this.lblAddName.Location = new System.Drawing.Point(41, 45);
            this.lblAddName.Name = "lblAddName";
            this.lblAddName.Size = new System.Drawing.Size(61, 23);
            this.lblAddName.TabIndex = 0;
            this.lblAddName.Text = "Name";
            // 
            // gbxUpdate
            // 
            this.gbxUpdate.Controls.Add(this.tbxUpdateStockAmount);
            this.gbxUpdate.Controls.Add(this.tbxUpdateUnitPrice);
            this.gbxUpdate.Controls.Add(this.lbUpdateUnitPrice);
            this.gbxUpdate.Controls.Add(this.lbUpdateStockAmount);
            this.gbxUpdate.Controls.Add(this.btnUpdate);
            this.gbxUpdate.Controls.Add(this.tbxUpdateName);
            this.gbxUpdate.Controls.Add(this.lbUpdateName);
            this.gbxUpdate.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbxUpdate.Location = new System.Drawing.Point(595, 389);
            this.gbxUpdate.Name = "gbxUpdate";
            this.gbxUpdate.Size = new System.Drawing.Size(550, 271);
            this.gbxUpdate.TabIndex = 7;
            this.gbxUpdate.TabStop = false;
            this.gbxUpdate.Text = "Update a Product";
            // 
            // tbxUpdateStockAmount
            // 
            this.tbxUpdateStockAmount.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUpdateStockAmount.Location = new System.Drawing.Point(185, 139);
            this.tbxUpdateStockAmount.Name = "tbxUpdateStockAmount";
            this.tbxUpdateStockAmount.Size = new System.Drawing.Size(291, 36);
            this.tbxUpdateStockAmount.TabIndex = 6;
            // 
            // tbxUpdateUnitPrice
            // 
            this.tbxUpdateUnitPrice.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUpdateUnitPrice.Location = new System.Drawing.Point(185, 94);
            this.tbxUpdateUnitPrice.Name = "tbxUpdateUnitPrice";
            this.tbxUpdateUnitPrice.Size = new System.Drawing.Size(291, 36);
            this.tbxUpdateUnitPrice.TabIndex = 5;
            // 
            // lbUpdateUnitPrice
            // 
            this.lbUpdateUnitPrice.AutoSize = true;
            this.lbUpdateUnitPrice.Location = new System.Drawing.Point(40, 94);
            this.lbUpdateUnitPrice.Name = "lbUpdateUnitPrice";
            this.lbUpdateUnitPrice.Size = new System.Drawing.Size(94, 23);
            this.lbUpdateUnitPrice.TabIndex = 4;
            this.lbUpdateUnitPrice.Text = "Unit Price";
            // 
            // lbUpdateStockAmount
            // 
            this.lbUpdateStockAmount.AutoSize = true;
            this.lbUpdateStockAmount.Location = new System.Drawing.Point(40, 139);
            this.lbUpdateStockAmount.Name = "lbUpdateStockAmount";
            this.lbUpdateStockAmount.Size = new System.Drawing.Size(131, 23);
            this.lbUpdateStockAmount.TabIndex = 3;
            this.lbUpdateStockAmount.Text = "Stock Amount";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnUpdate.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(243, 196);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 52);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // tbxUpdateName
            // 
            this.tbxUpdateName.Font = new System.Drawing.Font("Dubai", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxUpdateName.Location = new System.Drawing.Point(185, 46);
            this.tbxUpdateName.Name = "tbxUpdateName";
            this.tbxUpdateName.Size = new System.Drawing.Size(291, 36);
            this.tbxUpdateName.TabIndex = 1;
            // 
            // lbUpdateName
            // 
            this.lbUpdateName.AutoSize = true;
            this.lbUpdateName.Location = new System.Drawing.Point(41, 45);
            this.lbUpdateName.Name = "lbUpdateName";
            this.lbUpdateName.Size = new System.Drawing.Size(61, 23);
            this.lbUpdateName.TabIndex = 0;
            this.lbUpdateName.Text = "Name";
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.btnDelete.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(912, 331);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(184, 52);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1174, 703);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.gbxUpdate);
            this.Controls.Add(this.gbxAdd);
            this.Controls.Add(this.gbxProucts);
            this.Name = "Form1";
            this.Text = "EShop";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgwProducts)).EndInit();
            this.gbxProucts.ResumeLayout(false);
            this.gbxAdd.ResumeLayout(false);
            this.gbxAdd.PerformLayout();
            this.gbxUpdate.ResumeLayout(false);
            this.gbxUpdate.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgwProducts;
        private System.Windows.Forms.GroupBox gbxProucts;
        private System.Windows.Forms.GroupBox gbxAdd;
        private System.Windows.Forms.TextBox tbxAddStockAmount;
        private System.Windows.Forms.TextBox tbxAddUnitPrice;
        private System.Windows.Forms.Label lblAddUnitPrice;
        private System.Windows.Forms.Label lblAddStockAmount;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox tbxAddName;
        private System.Windows.Forms.Label lblAddName;
        private System.Windows.Forms.GroupBox gbxUpdate;
        private System.Windows.Forms.TextBox tbxUpdateStockAmount;
        private System.Windows.Forms.TextBox tbxUpdateUnitPrice;
        private System.Windows.Forms.Label lbUpdateUnitPrice;
        private System.Windows.Forms.Label lbUpdateStockAmount;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox tbxUpdateName;
        private System.Windows.Forms.Label lbUpdateName;
        private System.Windows.Forms.Button btnDelete;
    }
}

