namespace Courier_managment
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
            this.senderName = new System.Windows.Forms.TextBox();
            this.Details = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.senderAddress = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.senderPhoneNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.productWeight = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.reciverName = new System.Windows.Forms.TextBox();
            this.reciverPhoneNo = new System.Windows.Forms.TextBox();
            this.reciverAddress = new System.Windows.Forms.TextBox();
            this.cost = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnBrowser = new System.Windows.Forms.Button();
            this.btnLogOut = new System.Windows.Forms.Button();
            this.btnAddNewProduct = new System.Windows.Forms.Button();
            this.btnUpdateProduct = new System.Windows.Forms.Button();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnShowAllProduct = new System.Windows.Forms.Button();
            this.lblPicture = new System.Windows.Forms.Label();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.Details.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // senderName
            // 
            this.senderName.Location = new System.Drawing.Point(159, 54);
            this.senderName.Name = "senderName";
            this.senderName.Size = new System.Drawing.Size(154, 22);
            this.senderName.TabIndex = 0;
            // 
            // Details
            // 
            this.Details.Controls.Add(this.productGridView);
            this.Details.Controls.Add(this.lblPicture);
            this.Details.Controls.Add(this.btnShowAllProduct);
            this.Details.Controls.Add(this.btnDeleteProduct);
            this.Details.Controls.Add(this.btnUpdateProduct);
            this.Details.Controls.Add(this.btnAddNewProduct);
            this.Details.Controls.Add(this.btnLogOut);
            this.Details.Controls.Add(this.btnBrowser);
            this.Details.Controls.Add(this.pictureBox1);
            this.Details.Controls.Add(this.label8);
            this.Details.Controls.Add(this.label4);
            this.Details.Controls.Add(this.label7);
            this.Details.Controls.Add(this.label3);
            this.Details.Controls.Add(this.label6);
            this.Details.Controls.Add(this.label2);
            this.Details.Controls.Add(this.label5);
            this.Details.Controls.Add(this.label1);
            this.Details.Controls.Add(this.cost);
            this.Details.Controls.Add(this.productWeight);
            this.Details.Controls.Add(this.reciverAddress);
            this.Details.Controls.Add(this.reciverPhoneNo);
            this.Details.Controls.Add(this.senderPhoneNo);
            this.Details.Controls.Add(this.reciverName);
            this.Details.Controls.Add(this.senderAddress);
            this.Details.Controls.Add(this.senderName);
            this.Details.Location = new System.Drawing.Point(39, 12);
            this.Details.Name = "Details";
            this.Details.Size = new System.Drawing.Size(1115, 683);
            this.Details.TabIndex = 1;
            this.Details.TabStop = false;
            this.Details.Text = "Details";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(24, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Sender Name";
            // 
            // senderAddress
            // 
            this.senderAddress.Location = new System.Drawing.Point(159, 132);
            this.senderAddress.Name = "senderAddress";
            this.senderAddress.Size = new System.Drawing.Size(154, 22);
            this.senderAddress.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Sender Phone No";
            // 
            // senderPhoneNo
            // 
            this.senderPhoneNo.Location = new System.Drawing.Point(159, 97);
            this.senderPhoneNo.Name = "senderPhoneNo";
            this.senderPhoneNo.Size = new System.Drawing.Size(154, 22);
            this.senderPhoneNo.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(24, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Sender Address";
            // 
            // productWeight
            // 
            this.productWeight.Location = new System.Drawing.Point(159, 176);
            this.productWeight.Name = "productWeight";
            this.productWeight.Size = new System.Drawing.Size(154, 22);
            this.productWeight.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(24, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(112, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Product Weight";
            // 
            // reciverName
            // 
            this.reciverName.Location = new System.Drawing.Point(491, 54);
            this.reciverName.Name = "reciverName";
            this.reciverName.Size = new System.Drawing.Size(154, 22);
            this.reciverName.TabIndex = 0;
            // 
            // reciverPhoneNo
            // 
            this.reciverPhoneNo.Location = new System.Drawing.Point(491, 94);
            this.reciverPhoneNo.Name = "reciverPhoneNo";
            this.reciverPhoneNo.Size = new System.Drawing.Size(154, 22);
            this.reciverPhoneNo.TabIndex = 0;
            // 
            // reciverAddress
            // 
            this.reciverAddress.Location = new System.Drawing.Point(491, 135);
            this.reciverAddress.Name = "reciverAddress";
            this.reciverAddress.Size = new System.Drawing.Size(154, 22);
            this.reciverAddress.TabIndex = 0;
            // 
            // cost
            // 
            this.cost.Location = new System.Drawing.Point(491, 176);
            this.cost.Name = "cost";
            this.cost.Size = new System.Drawing.Size(154, 22);
            this.cost.TabIndex = 0;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(348, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 16);
            this.label5.TabIndex = 1;
            this.label5.Text = "Reciver Name";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(348, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(133, 16);
            this.label6.TabIndex = 1;
            this.label6.Text = "Reciver Phone No";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(348, 138);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 16);
            this.label7.TabIndex = 1;
            this.label7.Text = "Reciver Address";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(348, 182);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 16);
            this.label8.TabIndex = 1;
            this.label8.Text = "Product Cost";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(693, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 164);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnBrowser
            // 
            this.btnBrowser.Location = new System.Drawing.Point(693, 224);
            this.btnBrowser.Name = "btnBrowser";
            this.btnBrowser.Size = new System.Drawing.Size(102, 48);
            this.btnBrowser.TabIndex = 3;
            this.btnBrowser.Text = "Bowse";
            this.btnBrowser.UseVisualStyleBackColor = true;
            this.btnBrowser.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // btnLogOut
            // 
            this.btnLogOut.Location = new System.Drawing.Point(801, 248);
            this.btnLogOut.Name = "btnLogOut";
            this.btnLogOut.Size = new System.Drawing.Size(91, 24);
            this.btnLogOut.TabIndex = 3;
            this.btnLogOut.Text = "Log Out";
            this.btnLogOut.UseVisualStyleBackColor = true;
            this.btnLogOut.Click += new System.EventHandler(this.btnLogOut_Click);
            // 
            // btnAddNewProduct
            // 
            this.btnAddNewProduct.Location = new System.Drawing.Point(43, 248);
            this.btnAddNewProduct.Name = "btnAddNewProduct";
            this.btnAddNewProduct.Size = new System.Drawing.Size(100, 24);
            this.btnAddNewProduct.TabIndex = 4;
            this.btnAddNewProduct.Text = "Add";
            this.btnAddNewProduct.UseVisualStyleBackColor = true;
            this.btnAddNewProduct.Click += new System.EventHandler(this.btnAddNewProduct_Click);
            // 
            // btnUpdateProduct
            // 
            this.btnUpdateProduct.Location = new System.Drawing.Point(149, 248);
            this.btnUpdateProduct.Name = "btnUpdateProduct";
            this.btnUpdateProduct.Size = new System.Drawing.Size(100, 24);
            this.btnUpdateProduct.TabIndex = 4;
            this.btnUpdateProduct.Text = "Update";
            this.btnUpdateProduct.UseVisualStyleBackColor = true;
            this.btnUpdateProduct.Click += new System.EventHandler(this.btnUpdateProduct_Click);
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.Location = new System.Drawing.Point(255, 249);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(100, 23);
            this.btnDeleteProduct.TabIndex = 4;
            this.btnDeleteProduct.Text = "Delete";
            this.btnDeleteProduct.UseVisualStyleBackColor = true;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnShowAllProduct
            // 
            this.btnShowAllProduct.Location = new System.Drawing.Point(361, 248);
            this.btnShowAllProduct.Name = "btnShowAllProduct";
            this.btnShowAllProduct.Size = new System.Drawing.Size(100, 24);
            this.btnShowAllProduct.TabIndex = 4;
            this.btnShowAllProduct.Text = "Show All";
            this.btnShowAllProduct.UseVisualStyleBackColor = true;
            this.btnShowAllProduct.Click += new System.EventHandler(this.btnShowAllProduct_Click);
            // 
            // lblPicture
            // 
            this.lblPicture.AutoSize = true;
            this.lblPicture.Location = new System.Drawing.Point(690, 205);
            this.lblPicture.Name = "lblPicture";
            this.lblPicture.Size = new System.Drawing.Size(74, 16);
            this.lblPicture.TabIndex = 5;
            this.lblPicture.Text = "Image path";
            // 
            // productGridView
            // 
            this.productGridView.AllowUserToAddRows = false;
            this.productGridView.AllowUserToDeleteRows = false;
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(22, 309);
            this.productGridView.Name = "productGridView";
            this.productGridView.ReadOnly = true;
            this.productGridView.RowHeadersWidth = 51;
            this.productGridView.RowTemplate.Height = 24;
            this.productGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGridView.Size = new System.Drawing.Size(1041, 361);
            this.productGridView.TabIndex = 6;
            this.productGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellContentClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1286, 707);
            this.Controls.Add(this.Details);
            this.Name = "Form1";
            this.Text = "Courier Managment";
            this.Details.ResumeLayout(false);
            this.Details.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox senderName;
        private System.Windows.Forms.GroupBox Details;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox productWeight;
        private System.Windows.Forms.TextBox senderPhoneNo;
        private System.Windows.Forms.TextBox senderAddress;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cost;
        private System.Windows.Forms.TextBox reciverAddress;
        private System.Windows.Forms.TextBox reciverPhoneNo;
        private System.Windows.Forms.TextBox reciverName;
        private System.Windows.Forms.Button btnBrowser;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLogOut;
        private System.Windows.Forms.Button btnShowAllProduct;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnUpdateProduct;
        private System.Windows.Forms.Button btnAddNewProduct;
        private System.Windows.Forms.Label lblPicture;
        private System.Windows.Forms.DataGridView productGridView;
    }
}

