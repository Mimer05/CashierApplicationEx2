namespace CashierApplication
{
    partial class frmPurchaseDiscountedItem
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
            label1 = new Label();
            label2 = new Label();
            TBItem = new TextBox();
            label3 = new Label();
            TBPrice = new TextBox();
            TBDiscount = new TextBox();
            TBQuantity = new TextBox();
            label4 = new Label();
            BCompute = new Button();
            label5 = new Label();
            LBAmount = new Label();
            label7 = new Label();
            TBPayment = new TextBox();
            BSubmit = new Button();
            label8 = new Label();
            LBChange = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(88, 35);
            label1.Name = "label1";
            label1.Size = new Size(47, 25);
            label1.TabIndex = 0;
            label1.Text = "Item:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(479, 35);
            label2.Name = "label2";
            label2.Size = new Size(99, 25);
            label2.TabIndex = 1;
            label2.Text = "Discount(%):";
            // 
            // TBItem
            // 
            TBItem.Location = new Point(88, 75);
            TBItem.Name = "TBItem";
            TBItem.Size = new Size(240, 23);
            TBItem.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(88, 124);
            label3.Name = "label3";
            label3.Size = new Size(51, 25);
            label3.TabIndex = 3;
            label3.Text = "Price:";
            // 
            // TBPrice
            // 
            TBPrice.Location = new Point(145, 126);
            TBPrice.Name = "TBPrice";
            TBPrice.Size = new Size(183, 23);
            TBPrice.TabIndex = 4;
            // 
            // TBDiscount
            // 
            TBDiscount.Location = new Point(479, 75);
            TBDiscount.Name = "TBDiscount";
            TBDiscount.Size = new Size(128, 23);
            TBDiscount.TabIndex = 5;
            // 
            // TBQuantity
            // 
            TBQuantity.Location = new Point(502, 130);
            TBQuantity.Name = "TBQuantity";
            TBQuantity.Size = new Size(105, 23);
            TBQuantity.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(420, 124);
            label4.Name = "label4";
            label4.Size = new Size(76, 25);
            label4.TabIndex = 7;
            label4.Text = "Quantity:";
            // 
            // BCompute
            // 
            BCompute.BackColor = SystemColors.ActiveCaption;
            BCompute.BackgroundImageLayout = ImageLayout.Center;
            BCompute.FlatStyle = FlatStyle.Popup;
            BCompute.Font = new Font("Arial Narrow", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BCompute.ForeColor = SystemColors.ButtonHighlight;
            BCompute.Location = new Point(341, 176);
            BCompute.Name = "BCompute";
            BCompute.Size = new Size(104, 29);
            BCompute.TabIndex = 8;
            BCompute.Text = "Compute";
            BCompute.UseVisualStyleBackColor = false;
            BCompute.Click += BCompute_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(220, 239);
            label5.Name = "label5";
            label5.Size = new Size(108, 25);
            label5.TabIndex = 9;
            label5.Text = "Total amount:";
            // 
            // LBAmount
            // 
            LBAmount.AutoSize = true;
            LBAmount.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBAmount.Location = new Point(351, 239);
            LBAmount.Name = "LBAmount";
            LBAmount.Size = new Size(94, 25);
            LBAmount.TabIndex = 10;
            LBAmount.Text = "The amount";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(159, 298);
            label7.Name = "label7";
            label7.Size = new Size(140, 25);
            label7.TabIndex = 11;
            label7.Text = "Payment recieved:";
            // 
            // TBPayment
            // 
            TBPayment.Location = new Point(314, 304);
            TBPayment.Name = "TBPayment";
            TBPayment.Size = new Size(150, 23);
            TBPayment.TabIndex = 12;
            // 
            // BSubmit
            // 
            BSubmit.BackColor = SystemColors.ActiveCaption;
            BSubmit.BackgroundImageLayout = ImageLayout.Center;
            BSubmit.FlatStyle = FlatStyle.Popup;
            BSubmit.Font = new Font("Arial Narrow", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BSubmit.ForeColor = SystemColors.ButtonFace;
            BSubmit.Location = new Point(503, 304);
            BSubmit.Name = "BSubmit";
            BSubmit.Size = new Size(104, 33);
            BSubmit.TabIndex = 13;
            BSubmit.Text = "Submit";
            BSubmit.UseVisualStyleBackColor = false;
            BSubmit.Click += BSubmit_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(260, 366);
            label8.Name = "label8";
            label8.Size = new Size(68, 25);
            label8.TabIndex = 14;
            label8.Text = "Change:";
            // 
            // LBChange
            // 
            LBChange.AutoSize = true;
            LBChange.Font = new Font("Bahnschrift Condensed", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LBChange.Location = new Point(351, 366);
            LBChange.Name = "LBChange";
            LBChange.Size = new Size(91, 25);
            LBChange.TabIndex = 15;
            LBChange.Text = "The change";
            // 
            // frmPurchaseDiscountedItem
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Lavender;
            BackgroundImageLayout = ImageLayout.Center;
            ClientSize = new Size(800, 450);
            Controls.Add(LBChange);
            Controls.Add(label8);
            Controls.Add(BSubmit);
            Controls.Add(TBPayment);
            Controls.Add(label7);
            Controls.Add(LBAmount);
            Controls.Add(label5);
            Controls.Add(BCompute);
            Controls.Add(label4);
            Controls.Add(TBQuantity);
            Controls.Add(TBDiscount);
            Controls.Add(TBPrice);
            Controls.Add(label3);
            Controls.Add(TBItem);
            Controls.Add(label2);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "frmPurchaseDiscountedItem";
            Text = "Purchase Discounted Item";
            Load += frmPurchaseDiscountedItem_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox TBItem;
        private Label label3;
        private TextBox TBPrice;
        private TextBox TBDiscount;
        private TextBox TBQuantity;
        private Label label4;
        private Button BCompute;
        private Label label5;
        private Label LBAmount;
        private Label label7;
        private TextBox TBPayment;
        private Button BSubmit;
        private Label label8;
        private Label LBChange;
    }
}
