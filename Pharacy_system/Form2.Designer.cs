namespace Pharacy_system
{
    partial class Form2
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
            System.Windows.Forms.Label doctor_s_Ref_NoLabel;
            System.Windows.Forms.Label doctor_s_NHS_NoLabel;
            System.Windows.Forms.Label firstnameLabel;
            System.Windows.Forms.Label surnameLabel;
            System.Windows.Forms.Label medical_Center_NameLabel;
            System.Windows.Forms.Label address_of_CenterLabel;
            System.Windows.Forms.Label post_CodeLabel;
            System.Windows.Forms.Label office_Phone_No_1Label;
            System.Windows.Forms.Label office_Phone_No_2Label;
            System.Windows.Forms.Label fax_NoLabel;
            System.Windows.Forms.Label email_AddressLabel;
            System.Windows.Forms.Label patient_NHS_NumberLabel;
            System.Windows.Forms.Label eMIS_NumberLabel;
            System.Windows.Forms.Label gP_Apppointment_RefLabel;
            System.Windows.Forms.Label patient_IDLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.pharmacy_Manageent_SystemDataSet = new Pharacy_system.Pharmacy_Manageent_SystemDataSet();
            this.doctorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.doctorTableAdapter = new Pharacy_system.Pharmacy_Manageent_SystemDataSetTableAdapters.DoctorTableAdapter();
            this.tableAdapterManager = new Pharacy_system.Pharmacy_Manageent_SystemDataSetTableAdapters.TableAdapterManager();
            this.doctor_s_NHS_NoTextBox = new System.Windows.Forms.TextBox();
            this.firstnameTextBox = new System.Windows.Forms.TextBox();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.medical_Center_NameTextBox = new System.Windows.Forms.TextBox();
            this.address_of_CenterTextBox = new System.Windows.Forms.TextBox();
            this.post_CodeTextBox = new System.Windows.Forms.TextBox();
            this.office_Phone_No_1TextBox = new System.Windows.Forms.TextBox();
            this.office_Phone_No_2TextBox = new System.Windows.Forms.TextBox();
            this.fax_NoTextBox = new System.Windows.Forms.TextBox();
            this.email_AddressTextBox = new System.Windows.Forms.TextBox();
            this.patient_NHS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.eMIS_NumberTextBox = new System.Windows.Forms.TextBox();
            this.gP_Apppointment_RefTextBox = new System.Windows.Forms.TextBox();
            this.patient_IDTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            doctor_s_Ref_NoLabel = new System.Windows.Forms.Label();
            doctor_s_NHS_NoLabel = new System.Windows.Forms.Label();
            firstnameLabel = new System.Windows.Forms.Label();
            surnameLabel = new System.Windows.Forms.Label();
            medical_Center_NameLabel = new System.Windows.Forms.Label();
            address_of_CenterLabel = new System.Windows.Forms.Label();
            post_CodeLabel = new System.Windows.Forms.Label();
            office_Phone_No_1Label = new System.Windows.Forms.Label();
            office_Phone_No_2Label = new System.Windows.Forms.Label();
            fax_NoLabel = new System.Windows.Forms.Label();
            email_AddressLabel = new System.Windows.Forms.Label();
            patient_NHS_NumberLabel = new System.Windows.Forms.Label();
            eMIS_NumberLabel = new System.Windows.Forms.Label();
            gP_Apppointment_RefLabel = new System.Windows.Forms.Label();
            patient_IDLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_Manageent_SystemDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // doctor_s_Ref_NoLabel
            // 
            doctor_s_Ref_NoLabel.AutoSize = true;
            doctor_s_Ref_NoLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctor_s_Ref_NoLabel.Location = new System.Drawing.Point(16, 127);
            doctor_s_Ref_NoLabel.Name = "doctor_s_Ref_NoLabel";
            doctor_s_Ref_NoLabel.Size = new System.Drawing.Size(183, 26);
            doctor_s_Ref_NoLabel.TabIndex = 1;
            doctor_s_Ref_NoLabel.Text = "Doctor\'s Ref No:";
            doctor_s_Ref_NoLabel.Click += new System.EventHandler(this.doctor_s_Ref_NoLabel_Click);
            // 
            // doctor_s_NHS_NoLabel
            // 
            doctor_s_NHS_NoLabel.AutoSize = true;
            doctor_s_NHS_NoLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            doctor_s_NHS_NoLabel.Location = new System.Drawing.Point(16, 178);
            doctor_s_NHS_NoLabel.Name = "doctor_s_NHS_NoLabel";
            doctor_s_NHS_NoLabel.Size = new System.Drawing.Size(197, 26);
            doctor_s_NHS_NoLabel.TabIndex = 3;
            doctor_s_NHS_NoLabel.Text = "Doctor\'s NHS No:";
            doctor_s_NHS_NoLabel.Click += new System.EventHandler(this.doctor_s_NHS_NoLabel_Click);
            // 
            // firstnameLabel
            // 
            firstnameLabel.AutoSize = true;
            firstnameLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            firstnameLabel.Location = new System.Drawing.Point(16, 226);
            firstnameLabel.Name = "firstnameLabel";
            firstnameLabel.Size = new System.Drawing.Size(125, 26);
            firstnameLabel.TabIndex = 5;
            firstnameLabel.Text = "Firstname:";
            firstnameLabel.Click += new System.EventHandler(this.firstnameLabel_Click);
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            surnameLabel.Location = new System.Drawing.Point(16, 278);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new System.Drawing.Size(112, 26);
            surnameLabel.TabIndex = 7;
            surnameLabel.Text = "Surname:";
            surnameLabel.Click += new System.EventHandler(this.surnameLabel_Click);
            // 
            // medical_Center_NameLabel
            // 
            medical_Center_NameLabel.AutoSize = true;
            medical_Center_NameLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            medical_Center_NameLabel.Location = new System.Drawing.Point(16, 334);
            medical_Center_NameLabel.Name = "medical_Center_NameLabel";
            medical_Center_NameLabel.Size = new System.Drawing.Size(246, 26);
            medical_Center_NameLabel.TabIndex = 9;
            medical_Center_NameLabel.Text = "Medical Center Name:";
            medical_Center_NameLabel.Click += new System.EventHandler(this.medical_Center_NameLabel_Click);
            // 
            // address_of_CenterLabel
            // 
            address_of_CenterLabel.AutoSize = true;
            address_of_CenterLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            address_of_CenterLabel.Location = new System.Drawing.Point(16, 388);
            address_of_CenterLabel.Name = "address_of_CenterLabel";
            address_of_CenterLabel.Size = new System.Drawing.Size(205, 26);
            address_of_CenterLabel.TabIndex = 11;
            address_of_CenterLabel.Text = "Address of Center:";
            address_of_CenterLabel.Click += new System.EventHandler(this.address_of_CenterLabel_Click);
            // 
            // post_CodeLabel
            // 
            post_CodeLabel.AutoSize = true;
            post_CodeLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            post_CodeLabel.Location = new System.Drawing.Point(16, 448);
            post_CodeLabel.Name = "post_CodeLabel";
            post_CodeLabel.Size = new System.Drawing.Size(123, 26);
            post_CodeLabel.TabIndex = 13;
            post_CodeLabel.Text = "Post Code:";
            // 
            // office_Phone_No_1Label
            // 
            office_Phone_No_1Label.AutoSize = true;
            office_Phone_No_1Label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            office_Phone_No_1Label.Location = new System.Drawing.Point(521, 126);
            office_Phone_No_1Label.Name = "office_Phone_No_1Label";
            office_Phone_No_1Label.Size = new System.Drawing.Size(205, 26);
            office_Phone_No_1Label.TabIndex = 15;
            office_Phone_No_1Label.Text = "Office Phone No 1:";
            office_Phone_No_1Label.Click += new System.EventHandler(this.office_Phone_No_1Label_Click);
            // 
            // office_Phone_No_2Label
            // 
            office_Phone_No_2Label.AutoSize = true;
            office_Phone_No_2Label.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            office_Phone_No_2Label.Location = new System.Drawing.Point(521, 178);
            office_Phone_No_2Label.Name = "office_Phone_No_2Label";
            office_Phone_No_2Label.Size = new System.Drawing.Size(205, 26);
            office_Phone_No_2Label.TabIndex = 17;
            office_Phone_No_2Label.Text = "Office Phone No 2:";
            office_Phone_No_2Label.Click += new System.EventHandler(this.office_Phone_No_2Label_Click);
            // 
            // fax_NoLabel
            // 
            fax_NoLabel.AutoSize = true;
            fax_NoLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fax_NoLabel.Location = new System.Drawing.Point(16, 511);
            fax_NoLabel.Name = "fax_NoLabel";
            fax_NoLabel.Size = new System.Drawing.Size(94, 26);
            fax_NoLabel.TabIndex = 19;
            fax_NoLabel.Text = "Fax No:";
            fax_NoLabel.Click += new System.EventHandler(this.fax_NoLabel_Click);
            // 
            // email_AddressLabel
            // 
            email_AddressLabel.AutoSize = true;
            email_AddressLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            email_AddressLabel.Location = new System.Drawing.Point(521, 226);
            email_AddressLabel.Name = "email_AddressLabel";
            email_AddressLabel.Size = new System.Drawing.Size(169, 26);
            email_AddressLabel.TabIndex = 21;
            email_AddressLabel.Text = "Email Address:";
            email_AddressLabel.Click += new System.EventHandler(this.email_AddressLabel_Click);
            // 
            // patient_NHS_NumberLabel
            // 
            patient_NHS_NumberLabel.AutoSize = true;
            patient_NHS_NumberLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_NHS_NumberLabel.Location = new System.Drawing.Point(521, 278);
            patient_NHS_NumberLabel.Name = "patient_NHS_NumberLabel";
            patient_NHS_NumberLabel.Size = new System.Drawing.Size(239, 26);
            patient_NHS_NumberLabel.TabIndex = 23;
            patient_NHS_NumberLabel.Text = "Patient NHS Number:";
            patient_NHS_NumberLabel.Click += new System.EventHandler(this.patient_NHS_NumberLabel_Click);
            // 
            // eMIS_NumberLabel
            // 
            eMIS_NumberLabel.AutoSize = true;
            eMIS_NumberLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            eMIS_NumberLabel.Location = new System.Drawing.Point(521, 334);
            eMIS_NumberLabel.Name = "eMIS_NumberLabel";
            eMIS_NumberLabel.Size = new System.Drawing.Size(171, 26);
            eMIS_NumberLabel.TabIndex = 25;
            eMIS_NumberLabel.Text = "EMIS Number:";
            eMIS_NumberLabel.Click += new System.EventHandler(this.eMIS_NumberLabel_Click);
            // 
            // gP_Apppointment_RefLabel
            // 
            gP_Apppointment_RefLabel.AutoSize = true;
            gP_Apppointment_RefLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            gP_Apppointment_RefLabel.Location = new System.Drawing.Point(521, 388);
            gP_Apppointment_RefLabel.Name = "gP_Apppointment_RefLabel";
            gP_Apppointment_RefLabel.Size = new System.Drawing.Size(245, 26);
            gP_Apppointment_RefLabel.TabIndex = 27;
            gP_Apppointment_RefLabel.Text = "GP Apppointment Ref:";
            // 
            // patient_IDLabel
            // 
            patient_IDLabel.AutoSize = true;
            patient_IDLabel.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            patient_IDLabel.Location = new System.Drawing.Point(521, 441);
            patient_IDLabel.Name = "patient_IDLabel";
            patient_IDLabel.Size = new System.Drawing.Size(126, 26);
            patient_IDLabel.TabIndex = 29;
            patient_IDLabel.Text = "Patient ID:";
            // 
            // pharmacy_Manageent_SystemDataSet
            // 
            this.pharmacy_Manageent_SystemDataSet.DataSetName = "Pharmacy_Manageent_SystemDataSet";
            this.pharmacy_Manageent_SystemDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // doctorBindingSource
            // 
            this.doctorBindingSource.DataMember = "Doctor";
            this.doctorBindingSource.DataSource = this.pharmacy_Manageent_SystemDataSet;
            // 
            // doctorTableAdapter
            // 
            this.doctorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.DoctorTableAdapter = this.doctorTableAdapter;
            this.tableAdapterManager.GP_ApppoinmentTableAdapter = null;
            this.tableAdapterManager.PatientTableAdapter = null;
            this.tableAdapterManager.PaymentTableAdapter = null;
            this.tableAdapterManager.PharmacyTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Pharacy_system.Pharmacy_Manageent_SystemDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // doctor_s_NHS_NoTextBox
            // 
            this.doctor_s_NHS_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Doctor\'s NHS No", true));
            this.doctor_s_NHS_NoTextBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.doctor_s_NHS_NoTextBox.Location = new System.Drawing.Point(289, 178);
            this.doctor_s_NHS_NoTextBox.Multiline = true;
            this.doctor_s_NHS_NoTextBox.Name = "doctor_s_NHS_NoTextBox";
            this.doctor_s_NHS_NoTextBox.Size = new System.Drawing.Size(166, 30);
            this.doctor_s_NHS_NoTextBox.TabIndex = 4;
            // 
            // firstnameTextBox
            // 
            this.firstnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Firstname", true));
            this.firstnameTextBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.firstnameTextBox.Location = new System.Drawing.Point(289, 226);
            this.firstnameTextBox.Multiline = true;
            this.firstnameTextBox.Name = "firstnameTextBox";
            this.firstnameTextBox.Size = new System.Drawing.Size(166, 30);
            this.firstnameTextBox.TabIndex = 6;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Surname", true));
            this.surnameTextBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.surnameTextBox.Location = new System.Drawing.Point(289, 278);
            this.surnameTextBox.Multiline = true;
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(166, 30);
            this.surnameTextBox.TabIndex = 8;
            // 
            // medical_Center_NameTextBox
            // 
            this.medical_Center_NameTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Medical Center Name", true));
            this.medical_Center_NameTextBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.medical_Center_NameTextBox.Location = new System.Drawing.Point(289, 330);
            this.medical_Center_NameTextBox.Multiline = true;
            this.medical_Center_NameTextBox.Name = "medical_Center_NameTextBox";
            this.medical_Center_NameTextBox.Size = new System.Drawing.Size(166, 30);
            this.medical_Center_NameTextBox.TabIndex = 10;
            // 
            // address_of_CenterTextBox
            // 
            this.address_of_CenterTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Address of Center", true));
            this.address_of_CenterTextBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.address_of_CenterTextBox.Location = new System.Drawing.Point(289, 391);
            this.address_of_CenterTextBox.Multiline = true;
            this.address_of_CenterTextBox.Name = "address_of_CenterTextBox";
            this.address_of_CenterTextBox.Size = new System.Drawing.Size(166, 30);
            this.address_of_CenterTextBox.TabIndex = 12;
            // 
            // post_CodeTextBox
            // 
            this.post_CodeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Post Code", true));
            this.post_CodeTextBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.post_CodeTextBox.Location = new System.Drawing.Point(289, 444);
            this.post_CodeTextBox.Multiline = true;
            this.post_CodeTextBox.Name = "post_CodeTextBox";
            this.post_CodeTextBox.Size = new System.Drawing.Size(166, 30);
            this.post_CodeTextBox.TabIndex = 14;
            // 
            // office_Phone_No_1TextBox
            // 
            this.office_Phone_No_1TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Office Phone No 1", true));
            this.office_Phone_No_1TextBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.office_Phone_No_1TextBox.Location = new System.Drawing.Point(289, 511);
            this.office_Phone_No_1TextBox.Multiline = true;
            this.office_Phone_No_1TextBox.Name = "office_Phone_No_1TextBox";
            this.office_Phone_No_1TextBox.Size = new System.Drawing.Size(166, 30);
            this.office_Phone_No_1TextBox.TabIndex = 16;
            // 
            // office_Phone_No_2TextBox
            // 
            this.office_Phone_No_2TextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Office Phone No 2", true));
            this.office_Phone_No_2TextBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.office_Phone_No_2TextBox.Location = new System.Drawing.Point(793, 123);
            this.office_Phone_No_2TextBox.Multiline = true;
            this.office_Phone_No_2TextBox.Name = "office_Phone_No_2TextBox";
            this.office_Phone_No_2TextBox.Size = new System.Drawing.Size(166, 30);
            this.office_Phone_No_2TextBox.TabIndex = 18;
            // 
            // fax_NoTextBox
            // 
            this.fax_NoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Fax No", true));
            this.fax_NoTextBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.fax_NoTextBox.Location = new System.Drawing.Point(793, 174);
            this.fax_NoTextBox.Multiline = true;
            this.fax_NoTextBox.Name = "fax_NoTextBox";
            this.fax_NoTextBox.Size = new System.Drawing.Size(166, 30);
            this.fax_NoTextBox.TabIndex = 20;
            // 
            // email_AddressTextBox
            // 
            this.email_AddressTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Email Address", true));
            this.email_AddressTextBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.email_AddressTextBox.Location = new System.Drawing.Point(793, 222);
            this.email_AddressTextBox.Multiline = true;
            this.email_AddressTextBox.Name = "email_AddressTextBox";
            this.email_AddressTextBox.Size = new System.Drawing.Size(166, 30);
            this.email_AddressTextBox.TabIndex = 22;
            // 
            // patient_NHS_NumberTextBox
            // 
            this.patient_NHS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Patient NHS Number", true));
            this.patient_NHS_NumberTextBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.patient_NHS_NumberTextBox.Location = new System.Drawing.Point(793, 274);
            this.patient_NHS_NumberTextBox.Multiline = true;
            this.patient_NHS_NumberTextBox.Name = "patient_NHS_NumberTextBox";
            this.patient_NHS_NumberTextBox.Size = new System.Drawing.Size(166, 30);
            this.patient_NHS_NumberTextBox.TabIndex = 24;
            // 
            // eMIS_NumberTextBox
            // 
            this.eMIS_NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "EMIS Number", true));
            this.eMIS_NumberTextBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.eMIS_NumberTextBox.Location = new System.Drawing.Point(793, 334);
            this.eMIS_NumberTextBox.Multiline = true;
            this.eMIS_NumberTextBox.Name = "eMIS_NumberTextBox";
            this.eMIS_NumberTextBox.Size = new System.Drawing.Size(166, 30);
            this.eMIS_NumberTextBox.TabIndex = 26;
            // 
            // gP_Apppointment_RefTextBox
            // 
            this.gP_Apppointment_RefTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "GP Apppointment Ref", true));
            this.gP_Apppointment_RefTextBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.gP_Apppointment_RefTextBox.Location = new System.Drawing.Point(793, 384);
            this.gP_Apppointment_RefTextBox.Multiline = true;
            this.gP_Apppointment_RefTextBox.Name = "gP_Apppointment_RefTextBox";
            this.gP_Apppointment_RefTextBox.Size = new System.Drawing.Size(166, 30);
            this.gP_Apppointment_RefTextBox.TabIndex = 28;
            // 
            // patient_IDTextBox
            // 
            this.patient_IDTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Patient ID", true));
            this.patient_IDTextBox.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.patient_IDTextBox.Location = new System.Drawing.Point(793, 444);
            this.patient_IDTextBox.Multiline = true;
            this.patient_IDTextBox.Name = "patient_IDTextBox";
            this.patient_IDTextBox.Size = new System.Drawing.Size(166, 30);
            this.patient_IDTextBox.TabIndex = 30;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.btnSave);
            this.panel2.Controls.Add(this.btnExit);
            this.panel2.Controls.Add(this.btnAdd);
            this.panel2.Location = new System.Drawing.Point(526, 502);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(433, 83);
            this.panel2.TabIndex = 32;
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(157, 21);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(111, 46);
            this.btnSave.TabIndex = 51;
            this.btnSave.Text = "View Report";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click_1);
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.Location = new System.Drawing.Point(307, 21);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(111, 46);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Times New Roman", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(8, 21);
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
            this.panel3.Size = new System.Drawing.Size(947, 92);
            this.panel3.TabIndex = 41;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(35, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(897, 72);
            this.label1.TabIndex = 0;
            this.label1.Text = "Pharmacy Management Systems";
            // 
            // textBox1
            // 
            this.textBox1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.doctorBindingSource, "Doctor\'s NHS No", true));
            this.textBox1.Font = new System.Drawing.Font("Times New Roman", 12.25F, System.Drawing.FontStyle.Bold);
            this.textBox1.Location = new System.Drawing.Point(289, 126);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(166, 30);
            this.textBox1.TabIndex = 42;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1078, 630);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(doctor_s_Ref_NoLabel);
            this.Controls.Add(doctor_s_NHS_NoLabel);
            this.Controls.Add(this.doctor_s_NHS_NoTextBox);
            this.Controls.Add(firstnameLabel);
            this.Controls.Add(this.firstnameTextBox);
            this.Controls.Add(surnameLabel);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(medical_Center_NameLabel);
            this.Controls.Add(this.medical_Center_NameTextBox);
            this.Controls.Add(address_of_CenterLabel);
            this.Controls.Add(this.address_of_CenterTextBox);
            this.Controls.Add(post_CodeLabel);
            this.Controls.Add(this.post_CodeTextBox);
            this.Controls.Add(office_Phone_No_1Label);
            this.Controls.Add(this.office_Phone_No_1TextBox);
            this.Controls.Add(office_Phone_No_2Label);
            this.Controls.Add(this.office_Phone_No_2TextBox);
            this.Controls.Add(fax_NoLabel);
            this.Controls.Add(this.fax_NoTextBox);
            this.Controls.Add(email_AddressLabel);
            this.Controls.Add(this.email_AddressTextBox);
            this.Controls.Add(patient_NHS_NumberLabel);
            this.Controls.Add(this.patient_NHS_NumberTextBox);
            this.Controls.Add(eMIS_NumberLabel);
            this.Controls.Add(this.eMIS_NumberTextBox);
            this.Controls.Add(gP_Apppointment_RefLabel);
            this.Controls.Add(this.gP_Apppointment_RefTextBox);
            this.Controls.Add(patient_IDLabel);
            this.Controls.Add(this.patient_IDTextBox);
            this.MaximizeBox = false;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Doctor";
            this.Load += new System.EventHandler(this.Form2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pharmacy_Manageent_SystemDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.doctorBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Pharmacy_Manageent_SystemDataSet pharmacy_Manageent_SystemDataSet;
        private System.Windows.Forms.BindingSource doctorBindingSource;
        private Pharmacy_Manageent_SystemDataSetTableAdapters.DoctorTableAdapter doctorTableAdapter;
        private Pharmacy_Manageent_SystemDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox doctor_s_NHS_NoTextBox;
        private System.Windows.Forms.TextBox firstnameTextBox;
        private System.Windows.Forms.TextBox surnameTextBox;
        private System.Windows.Forms.TextBox medical_Center_NameTextBox;
        private System.Windows.Forms.TextBox address_of_CenterTextBox;
        private System.Windows.Forms.TextBox post_CodeTextBox;
        private System.Windows.Forms.TextBox office_Phone_No_1TextBox;
        private System.Windows.Forms.TextBox office_Phone_No_2TextBox;
        private System.Windows.Forms.TextBox fax_NoTextBox;
        private System.Windows.Forms.TextBox email_AddressTextBox;
        private System.Windows.Forms.TextBox patient_NHS_NumberTextBox;
        private System.Windows.Forms.TextBox eMIS_NumberTextBox;
        private System.Windows.Forms.TextBox gP_Apppointment_RefTextBox;
        private System.Windows.Forms.TextBox patient_IDTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnSave;


    }
}