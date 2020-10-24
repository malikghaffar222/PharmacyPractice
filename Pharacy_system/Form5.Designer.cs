namespace Pharacy_system
{
    partial class Form5
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
            System.Windows.Forms.Label invoice_NoLabel;
            System.Windows.Forms.Label amount_PaidLabel;
            System.Windows.Forms.Label method_Of_PaymentLabel;
            System.Windows.Forms.Label visa_CardLabel;
            System.Windows.Forms.Label debit_CardLabel;
            System.Windows.Forms.Label master_CardLabel;
            System.Windows.Forms.Label credit_CardLabel;
            System.Windows.Forms.Label direct_DebitLabel;
            System.Windows.Forms.Label visa_Debit_CardLabel;
            System.Windows.Forms.Label cash_PaidLabel;
            System.Windows.Forms.Label patient_IDLabel;
            System.Windows.Forms.Label per_Paid_PlanLabel;
            System.Windows.Forms.Label patient_NHS_NumberLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form5));
            this.pharmacy_Manageent_SystemDataSet = new Pharacy_system.Pharmacy_Manageent_SystemDataSet();
            this.paymentBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.paymentTableAdapter = new Pharacy_system.Pharmacy_Manageent_SystemDataSetTableAdapters.PaymentTableAdapter();
            this.tableAdapterManager = new Pharacy_system.Pharmacy_Manageent_SystemDataSetTableAdapters.TableAdapterManager();
            this.invoice_NoTextBox = new System.Windows.Forms.TextBox();
            this.amount_PaidTextBox = new System.Windows.Forms.TextBox();
            this.method_Of_PaymentTextBox = new System.Windows.Forms.TextBox();
            this.visa_CardTextBox = new System.Windows.Forms.TextBox();
            this.debit_CardTextBox = new System.Windows.Forms.TextBox();
            this.master_CardTextBox = new System.Windows.Forms.TextBox();
            this.credit_CardTextBox = new System.Windows.Forms.TextBox();
            this.direct_DebitTextBox = new System.Windows.Forms.TextBox();
            this.visa_Debit_CardTextBox = new System.Windows.Forms.TextBox();
            this.cash_PaidTextBox = new System.Windows.Forms.TextBox();
            this.patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.per_Paid_PlanCheckBox = new System.Windows.Forms.CheckBox();
            this.patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            invoice_NoLabel = new System.Windows.Forms.Label();
            amount_PaidLabel = new System.Windows.Forms.Label();
            method_Of_PaymentLabel = new System.Windows.Forms.Label();
            visa_CardLabel = new System.Windows.Forms.Label();
            debit_CardLabel = new System.Windows.Forms.Label();
            master_CardLabel = new System.Windows.Forms.Label();
            credit_CardLabel = new System.Windows.Forms.Label();
            direct_DebitLabel = new System.Windows.Forms.Label();
            visa_Debit_CardLabel = new System.Windows.Forms.Label();
            cash_PaidLabel = new System.Windows.Forms.Label();
            patient_IDLabel = new System.Windows.Forms.Label();
            per_Paid_PlanLabel = new System.Windows.Forms.Label();
            patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_Manageent_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // invoice_NoLabel
            // 
            invoice_NoLabel.AutoSize = true;
            invoice_NoLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            invoice_NoLabel.Location = new System.Drawing.Point(22, 110);
            invoice_NoLabel.Name = "invoice_NoLabel";
            invoice_NoLabel.Size = new System.Drawing.Size(129, 28);
            invoice_NoLabel.TabIndex = 1;
            invoice_NoLabel.Text = "Invoice No:";
            // 
            // amount_PaidLabel
            // 
            amount_PaidLabel.AutoSize = true;
            amount_PaidLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            amount_PaidLabel.Location = new System.Drawing.Point(22, 149);
            amount_PaidLabel.Name = "amount_PaidLabel";
            amount_PaidLabel.Size = new System.Drawing.Size(151, 28);
            amount_PaidLabel.TabIndex = 3;
            amount_PaidLabel.Text = "Amount Paid:";
            // 
            // method_Of_PaymentLabel
            // 
            method_Of_PaymentLabel.AutoSize = true;
            method_Of_PaymentLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            method_Of_PaymentLabel.Location = new System.Drawing.Point(22, 186);
            method_Of_PaymentLabel.Name = "method_Of_PaymentLabel";
            method_Of_PaymentLabel.Size = new System.Drawing.Size(220, 28);
            method_Of_PaymentLabel.TabIndex = 5;
            method_Of_PaymentLabel.Text = "Method Of Payment:";
            // 
            // visa_CardLabel
            // 
            visa_CardLabel.AutoSize = true;
            visa_CardLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            visa_CardLabel.Location = new System.Drawing.Point(22, 227);
            visa_CardLabel.Name = "visa_CardLabel";
            visa_CardLabel.Size = new System.Drawing.Size(117, 28);
            visa_CardLabel.TabIndex = 7;
            visa_CardLabel.Text = "Visa Card:";
            // 
            // debit_CardLabel
            // 
            debit_CardLabel.AutoSize = true;
            debit_CardLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            debit_CardLabel.Location = new System.Drawing.Point(22, 264);
            debit_CardLabel.Name = "debit_CardLabel";
            debit_CardLabel.Size = new System.Drawing.Size(129, 28);
            debit_CardLabel.TabIndex = 9;
            debit_CardLabel.Text = "Debit Card:";
            // 
            // master_CardLabel
            // 
            master_CardLabel.AutoSize = true;
            master_CardLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            master_CardLabel.Location = new System.Drawing.Point(22, 307);
            master_CardLabel.Name = "master_CardLabel";
            master_CardLabel.Size = new System.Drawing.Size(144, 28);
            master_CardLabel.TabIndex = 11;
            master_CardLabel.Text = "Master Card:";
            // 
            // credit_CardLabel
            // 
            credit_CardLabel.AutoSize = true;
            credit_CardLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            credit_CardLabel.Location = new System.Drawing.Point(512, 110);
            credit_CardLabel.Name = "credit_CardLabel";
            credit_CardLabel.Size = new System.Drawing.Size(137, 28);
            credit_CardLabel.TabIndex = 13;
            credit_CardLabel.Text = "Credit Card:";
            // 
            // direct_DebitLabel
            // 
            direct_DebitLabel.AutoSize = true;
            direct_DebitLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direct_DebitLabel.Location = new System.Drawing.Point(512, 149);
            direct_DebitLabel.Name = "direct_DebitLabel";
            direct_DebitLabel.Size = new System.Drawing.Size(142, 28);
            direct_DebitLabel.TabIndex = 15;
            direct_DebitLabel.Text = "Direct Debit:";
            // 
            // visa_Debit_CardLabel
            // 
            visa_Debit_CardLabel.AutoSize = true;
            visa_Debit_CardLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            visa_Debit_CardLabel.Location = new System.Drawing.Point(512, 186);
            visa_Debit_CardLabel.Name = "visa_Debit_CardLabel";
            visa_Debit_CardLabel.Size = new System.Drawing.Size(177, 28);
            visa_Debit_CardLabel.TabIndex = 17;
            visa_Debit_CardLabel.Text = "Visa Debit Card:";
            // 
            // cash_PaidLabel
            // 
            cash_PaidLabel.AutoSize = true;
            cash_PaidLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cash_PaidLabel.Location = new System.Drawing.Point(512, 227);
            cash_PaidLabel.Name = "cash_PaidLabel";
            cash_PaidLabel.Size = new System.Drawing.Size(122, 28);
            cash_PaidLabel.TabIndex = 19;
            cash_PaidLabel.Text = "Cash Paid:";
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_IDLabel.Location = new System.Drawing.Point(512, 264);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(124, 28);
            patient_IDLabel.TabIndex = 21;
            patient_IDLabel.Text = "Patient ID:";
            // 
            // per_Paid_PlanLabel
            // 
            per_Paid_PlanLabel.AutoSize = true;
            per_Paid_PlanLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            per_Paid_PlanLabel.Location = new System.Drawing.Point(512, 307);
            per_Paid_PlanLabel.Name = "per_Paid_PlanLabel";
            per_Paid_PlanLabel.Size = new System.Drawing.Size(160, 28);
            per_Paid_PlanLabel.TabIndex = 23;
            per_Paid_PlanLabel.Text = "Per Paid Plan:";
            // 
            // patient_NHS_NumberLabel
            // 
            patient_NHS_NumberLabel.AutoSize = true;
            patient_NHS_NumberLabel.Font = new System.Drawing.Font("Times New Roman", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_NHS_NumberLabel.Location = new System.Drawing.Point(22, 357);
            patient_NHS_NumberLabel.Name = "patient_NHS_NumberLabel";
            patient_NHS_NumberLabel.Size = new System.Drawing.Size(233, 28);
            patient_NHS_NumberLabel.TabIndex = 25;
            patient_NHS_NumberLabel.Text = "Patient NHS Number:";
            // 
            // pharmacy_Manageent_SystemDataSet
            // 
            this.pharmacy_Manageent_SystemDataSet.DataSetName = "Pharmacy_Manageent_SystemDataSet";
            this.pharmacy_Manageent_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // paymentBindingSource
            // 
            this.paymentBindingSource.DataMember = "Payment";
            this.paymentBindingSource.DataSource = this.pharmacy_Manageent_SystemDataSet;
            // 
            // paymentTableAdapter
            // 
            this.paymentTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = null;
            this.tableAdapterManager.GP_ApppoinmentTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = this.paymentTableAdapter;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pharacy_system.Pharmacy_Manageent_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // invoice_NoTextBox
            // 
            this.invoice_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Invoice No", true));
            this.invoice_NoTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.invoice_NoTextBox.Location = new System.Drawing.Point(743, 110);
            this.invoice_NoTextBox.Name = "invoice_NoTextBox";
            this.invoice_NoTextBox.Size = new System.Drawing.Size(146, 29);
            this.invoice_NoTextBox.TabIndex = 2;
            // 
            // amount_PaidTextBox
            // 
            this.amount_PaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Amount Paid", true));
            this.amount_PaidTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount_PaidTextBox.Location = new System.Drawing.Point(283, 148);
            this.amount_PaidTextBox.Name = "amount_PaidTextBox";
            this.amount_PaidTextBox.Size = new System.Drawing.Size(146, 29);
            this.amount_PaidTextBox.TabIndex = 4;
            // 
            // method_Of_PaymentTextBox
            // 
            this.method_Of_PaymentTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Method Of Payment", true));
            this.method_Of_PaymentTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.method_Of_PaymentTextBox.Location = new System.Drawing.Point(283, 185);
            this.method_Of_PaymentTextBox.Name = "method_Of_PaymentTextBox";
            this.method_Of_PaymentTextBox.Size = new System.Drawing.Size(146, 29);
            this.method_Of_PaymentTextBox.TabIndex = 6;
            // 
            // visa_CardTextBox
            // 
            this.visa_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Visa Card", true));
            this.visa_CardTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visa_CardTextBox.Location = new System.Drawing.Point(283, 226);
            this.visa_CardTextBox.Name = "visa_CardTextBox";
            this.visa_CardTextBox.Size = new System.Drawing.Size(146, 29);
            this.visa_CardTextBox.TabIndex = 8;
            // 
            // debit_CardTextBox
            // 
            this.debit_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Debit Card", true));
            this.debit_CardTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.debit_CardTextBox.Location = new System.Drawing.Point(283, 263);
            this.debit_CardTextBox.Name = "debit_CardTextBox";
            this.debit_CardTextBox.Size = new System.Drawing.Size(146, 29);
            this.debit_CardTextBox.TabIndex = 10;
            // 
            // master_CardTextBox
            // 
            this.master_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Master Card", true));
            this.master_CardTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.master_CardTextBox.Location = new System.Drawing.Point(283, 306);
            this.master_CardTextBox.Name = "master_CardTextBox";
            this.master_CardTextBox.Size = new System.Drawing.Size(146, 29);
            this.master_CardTextBox.TabIndex = 12;
            // 
            // credit_CardTextBox
            // 
            this.credit_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Credit Card", true));
            this.credit_CardTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.credit_CardTextBox.Location = new System.Drawing.Point(283, 109);
            this.credit_CardTextBox.Name = "credit_CardTextBox";
            this.credit_CardTextBox.Size = new System.Drawing.Size(146, 29);
            this.credit_CardTextBox.TabIndex = 14;
            // 
            // direct_DebitTextBox
            // 
            this.direct_DebitTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Direct Debit", true));
            this.direct_DebitTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direct_DebitTextBox.Location = new System.Drawing.Point(283, 356);
            this.direct_DebitTextBox.Name = "direct_DebitTextBox";
            this.direct_DebitTextBox.Size = new System.Drawing.Size(146, 29);
            this.direct_DebitTextBox.TabIndex = 16;
            // 
            // visa_Debit_CardTextBox
            // 
            this.visa_Debit_CardTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Visa Debit Card", true));
            this.visa_Debit_CardTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visa_Debit_CardTextBox.Location = new System.Drawing.Point(743, 149);
            this.visa_Debit_CardTextBox.Name = "visa_Debit_CardTextBox";
            this.visa_Debit_CardTextBox.Size = new System.Drawing.Size(146, 29);
            this.visa_Debit_CardTextBox.TabIndex = 18;
            // 
            // cash_PaidTextBox
            // 
            this.cash_PaidTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Cash Paid", true));
            this.cash_PaidTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cash_PaidTextBox.Location = new System.Drawing.Point(743, 186);
            this.cash_PaidTextBox.Name = "cash_PaidTextBox";
            this.cash_PaidTextBox.Size = new System.Drawing.Size(146, 29);
            this.cash_PaidTextBox.TabIndex = 20;
            // 
            // patient_IDTextBox
            // 
            this.patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Patient ID", true));
            this.patient_IDTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_IDTextBox.Location = new System.Drawing.Point(743, 227);
            this.patient_IDTextBox.Name = "patient_IDTextBox";
            this.patient_IDTextBox.Size = new System.Drawing.Size(146, 29);
            this.patient_IDTextBox.TabIndex = 22;
            // 
            // per_Paid_PlanCheckBox
            // 
            this.per_Paid_PlanCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.paymentBindingSource, "Per Paid Plan", true));
            this.per_Paid_PlanCheckBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.per_Paid_PlanCheckBox.Location = new System.Drawing.Point(743, 271);
            this.per_Paid_PlanCheckBox.Name = "per_Paid_PlanCheckBox";
            this.per_Paid_PlanCheckBox.Size = new System.Drawing.Size(19, 23);
            this.per_Paid_PlanCheckBox.TabIndex = 24;
            this.per_Paid_PlanCheckBox.UseVisualStyleBackColor = true;
            // 
            // patient_NHS_NumberTextBox
            // 
            this.patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.paymentBindingSource, "Patient NHS Number", true));
            this.patient_NHS_NumberTextBox.Font = new System.Drawing.Font("Times New Roman", 14.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_NHS_NumberTextBox.Location = new System.Drawing.Point(743, 310);
            this.patient_NHS_NumberTextBox.Name = "patient_NHS_NumberTextBox";
            this.patient_NHS_NumberTextBox.Size = new System.Drawing.Size(146, 29);
            this.patient_NHS_NumberTextBox.TabIndex = 26;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnView);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(517, 356);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(434, 83);
            this.panel2.TabIndex = 36;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(295, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 46);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnView
            // 
            this.btnView.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.Location = new System.Drawing.Point(155, 21);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(111, 46);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View Report";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnPervious_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(19, 21);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(111, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Transparent;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(12, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(939, 92);
            this.panel3.TabIndex = 38;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(14, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(897, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacy Management Systems";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(960, 457);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(invoice_NoLabel);
            this.Controls.Add(this.invoice_NoTextBox);
            this.Controls.Add(amount_PaidLabel);
            this.Controls.Add(this.amount_PaidTextBox);
            this.Controls.Add(method_Of_PaymentLabel);
            this.Controls.Add(this.method_Of_PaymentTextBox);
            this.Controls.Add(visa_CardLabel);
            this.Controls.Add(this.visa_CardTextBox);
            this.Controls.Add(debit_CardLabel);
            this.Controls.Add(this.debit_CardTextBox);
            this.Controls.Add(master_CardLabel);
            this.Controls.Add(this.master_CardTextBox);
            this.Controls.Add(credit_CardLabel);
            this.Controls.Add(this.credit_CardTextBox);
            this.Controls.Add(direct_DebitLabel);
            this.Controls.Add(this.direct_DebitTextBox);
            this.Controls.Add(visa_Debit_CardLabel);
            this.Controls.Add(this.visa_Debit_CardTextBox);
            this.Controls.Add(cash_PaidLabel);
            this.Controls.Add(this.cash_PaidTextBox);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDTextBox);
            this.Controls.Add(per_Paid_PlanLabel);
            this.Controls.Add(this.per_Paid_PlanCheckBox);
            this.Controls.Add(patient_NHS_NumberLabel);
            this.Controls.Add(this.patient_NHS_NumberTextBox);
            this.Name = "Form5";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Payment";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_Manageent_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.paymentBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pharmacy_Manageent_SystemDataSet pharmacy_Manageent_SystemDataSet;
        private System.Windows.Forms.BindingSource paymentBindingSource;
        private Pharmacy_Manageent_SystemDataSetTableAdapters.PaymentTableAdapter paymentTableAdapter;
        private Pharmacy_Manageent_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox invoice_NoTextBox;
        private System.Windows.Forms.TextBox amount_PaidTextBox;
        private System.Windows.Forms.TextBox method_Of_PaymentTextBox;
        private System.Windows.Forms.TextBox visa_CardTextBox;
        private System.Windows.Forms.TextBox debit_CardTextBox;
        private System.Windows.Forms.TextBox master_CardTextBox;
        private System.Windows.Forms.TextBox credit_CardTextBox;
        private System.Windows.Forms.TextBox direct_DebitTextBox;
        private System.Windows.Forms.TextBox visa_Debit_CardTextBox;
        private System.Windows.Forms.TextBox cash_PaidTextBox;
        private System.Windows.Forms.TextBox patient_IDTextBox;
        private System.Windows.Forms.CheckBox per_Paid_PlanCheckBox;
        private System.Windows.Forms.TextBox patient_NHS_NumberTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnView;
    }
}