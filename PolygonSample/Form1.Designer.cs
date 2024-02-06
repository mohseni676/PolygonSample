namespace PolygonSample
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
            groupBox1 = new GroupBox();
            tokenNameLbl = new Label();
            decimalsLbl = new Label();
            balanceLbl = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            button1 = new Button();
            label2 = new Label();
            label1 = new Label();
            addressTxt = new TextBox();
            tokenContractTxt = new TextBox();
            groupBox2 = new GroupBox();
            resultLstBox = new ListBox();
            button2 = new Button();
            amountTxt = new TextBox();
            trxTokenAddress = new TextBox();
            toTxt = new TextBox();
            prvKeyTxt = new TextBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label10 = new Label();
            label6 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(tokenNameLbl);
            groupBox1.Controls.Add(decimalsLbl);
            groupBox1.Controls.Add(balanceLbl);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(button1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(addressTxt);
            groupBox1.Controls.Add(tokenContractTxt);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(762, 128);
            groupBox1.TabIndex = 4;
            groupBox1.TabStop = false;
            groupBox1.Text = "Balance Of Token";
            // 
            // tokenNameLbl
            // 
            tokenNameLbl.AutoSize = true;
            tokenNameLbl.Location = new Point(576, 51);
            tokenNameLbl.Name = "tokenNameLbl";
            tokenNameLbl.Size = new Size(12, 15);
            tokenNameLbl.TabIndex = 18;
            tokenNameLbl.Text = "-";
            // 
            // decimalsLbl
            // 
            decimalsLbl.AutoSize = true;
            decimalsLbl.Location = new Point(576, 71);
            decimalsLbl.Name = "decimalsLbl";
            decimalsLbl.Size = new Size(12, 15);
            decimalsLbl.TabIndex = 19;
            decimalsLbl.Text = "-";
            // 
            // balanceLbl
            // 
            balanceLbl.AutoSize = true;
            balanceLbl.Location = new Point(576, 90);
            balanceLbl.Name = "balanceLbl";
            balanceLbl.Size = new Size(12, 15);
            balanceLbl.TabIndex = 20;
            balanceLbl.Text = "-";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(478, 51);
            label5.Name = "label5";
            label5.Size = new Size(74, 15);
            label5.TabIndex = 15;
            label5.Text = "Token name:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(478, 71);
            label4.Name = "label4";
            label4.Size = new Size(58, 15);
            label4.TabIndex = 16;
            label4.Text = "Decimals:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(478, 90);
            label3.Name = "label3";
            label3.Size = new Size(51, 15);
            label3.TabIndex = 17;
            label3.Text = "Balance:";
            // 
            // button1
            // 
            button1.Location = new Point(107, 80);
            button1.Name = "button1";
            button1.Size = new Size(318, 35);
            button1.TabIndex = 14;
            button1.Text = "Get token balance for wallet";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 54);
            label2.Name = "label2";
            label2.Size = new Size(87, 15);
            label2.TabIndex = 12;
            label2.Text = "Token Contract";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 25);
            label1.Name = "label1";
            label1.Size = new Size(85, 15);
            label1.TabIndex = 13;
            label1.Text = "Wallet Address";
            label1.Click += label1_Click;
            // 
            // addressTxt
            // 
            addressTxt.Location = new Point(107, 22);
            addressTxt.Name = "addressTxt";
            addressTxt.Size = new Size(318, 23);
            addressTxt.TabIndex = 10;
            addressTxt.Text = "0x0C3C0EE99e24c6De436B19EdBb74c27188142D9C";
            addressTxt.TextChanged += addressTxt_TextChanged;
            // 
            // tokenContractTxt
            // 
            tokenContractTxt.Location = new Point(107, 51);
            tokenContractTxt.Name = "tokenContractTxt";
            tokenContractTxt.Size = new Size(318, 23);
            tokenContractTxt.TabIndex = 11;
            tokenContractTxt.Text = "0x326C977E6efc84E512bB9C30f76E30c160eD06FB";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(resultLstBox);
            groupBox2.Controls.Add(button2);
            groupBox2.Controls.Add(amountTxt);
            groupBox2.Controls.Add(trxTokenAddress);
            groupBox2.Controls.Add(toTxt);
            groupBox2.Controls.Add(prvKeyTxt);
            groupBox2.Controls.Add(label9);
            groupBox2.Controls.Add(label8);
            groupBox2.Controls.Add(label7);
            groupBox2.Controls.Add(label10);
            groupBox2.Controls.Add(label6);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 128);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(762, 311);
            groupBox2.TabIndex = 5;
            groupBox2.TabStop = false;
            groupBox2.Text = "Transfer Token";
            // 
            // resultLstBox
            // 
            resultLstBox.FormattingEnabled = true;
            resultLstBox.ItemHeight = 15;
            resultLstBox.Location = new Point(138, 177);
            resultLstBox.Name = "resultLstBox";
            resultLstBox.Size = new Size(612, 124);
            resultLstBox.TabIndex = 15;
            // 
            // button2
            // 
            button2.Location = new Point(138, 135);
            button2.Name = "button2";
            button2.Size = new Size(287, 36);
            button2.TabIndex = 14;
            button2.Text = "Transfer token";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // amountTxt
            // 
            amountTxt.Location = new Point(138, 106);
            amountTxt.Name = "amountTxt";
            amountTxt.Size = new Size(130, 23);
            amountTxt.TabIndex = 1;
            amountTxt.Text = "2";
            // 
            // trxTokenAddress
            // 
            trxTokenAddress.Location = new Point(140, 47);
            trxTokenAddress.Name = "trxTokenAddress";
            trxTokenAddress.Size = new Size(301, 23);
            trxTokenAddress.TabIndex = 1;
            trxTokenAddress.Text = "0x326C977E6efc84E512bB9C30f76E30c160eD06FB";
            // 
            // toTxt
            // 
            toTxt.Location = new Point(140, 76);
            toTxt.Name = "toTxt";
            toTxt.Size = new Size(301, 23);
            toTxt.TabIndex = 1;
            toTxt.Text = "0x789f94695fcA1A928Ae9fDC4B66e1dEfCB17D599";
            // 
            // prvKeyTxt
            // 
            prvKeyTxt.Location = new Point(140, 17);
            prvKeyTxt.Name = "prvKeyTxt";
            prvKeyTxt.Size = new Size(481, 23);
            prvKeyTxt.TabIndex = 0;
            prvKeyTxt.Text = "bae150fb90f7f02eb319ded2330acc7620c3ae0539cae28f8189e585d9b59317";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(14, 177);
            label9.Name = "label9";
            label9.Size = new Size(83, 15);
            label9.TabIndex = 13;
            label9.Text = "Transfer Result";
            label9.Click += label1_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(12, 109);
            label8.Name = "label8";
            label8.Size = new Size(95, 15);
            label8.TabIndex = 13;
            label8.Text = "Transfer Amount";
            label8.Click += label1_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(14, 79);
            label7.Name = "label7";
            label7.Size = new Size(120, 15);
            label7.TabIndex = 13;
            label7.Text = "Target Wallet Address";
            label7.Click += label1_Click;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(14, 49);
            label10.Name = "label10";
            label10.Size = new Size(87, 15);
            label10.TabIndex = 13;
            label10.Text = "Token Contract";
            label10.Click += label1_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(14, 20);
            label6.Name = "label6";
            label6.Size = new Size(101, 15);
            label6.TabIndex = 13;
            label6.Text = "Wallet Private Key";
            label6.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(762, 441);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label tokenNameLbl;
        private Label decimalsLbl;
        private Label balanceLbl;
        private Label label5;
        private Label label4;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label1;
        private TextBox addressTxt;
        private TextBox tokenContractTxt;
        private GroupBox groupBox2;
        private TextBox amountTxt;
        private TextBox toTxt;
        private TextBox prvKeyTxt;
        private Label label8;
        private Label label7;
        private Label label6;
        private ListBox resultLstBox;
        private Button button2;
        private Label label9;
        private TextBox trxTokenAddress;
        private Label label10;
    }
}
