
using System;

namespace Ricot_Contact_Tracing
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.contact_input = new System.Windows.Forms.TextBox();
            this.address_input = new System.Windows.Forms.TextBox();
            this.age_input = new System.Windows.Forms.TextBox();
            this.name_input = new System.Windows.Forms.TextBox();
            this.contact = new System.Windows.Forms.Label();
            this.address = new System.Windows.Forms.Label();
            this.age = new System.Windows.Forms.Label();
            this.name = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.gender = new System.Windows.Forms.Label();
            this.gender_input = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel1.BackgroundImage = global::Ricot_Contact_Tracing.Properties.Resources._187161;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(8, 9);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(951, 109);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 52.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(46, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(862, 101);
            this.label1.TabIndex = 0;
            this.label1.Text = "Contact Tracing App";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel2.BackgroundImage = global::Ricot_Contact_Tracing.Properties.Resources._3214373;
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel2.Location = new System.Drawing.Point(8, 131);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(342, 378);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSkyBlue;
            this.panel3.BackgroundImage = global::Ricot_Contact_Tracing.Properties.Resources._187161;
            this.panel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panel3.Controls.Add(this.gender_input);
            this.panel3.Controls.Add(this.gender);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.contact_input);
            this.panel3.Controls.Add(this.address_input);
            this.panel3.Controls.Add(this.age_input);
            this.panel3.Controls.Add(this.name_input);
            this.panel3.Controls.Add(this.contact);
            this.panel3.Controls.Add(this.address);
            this.panel3.Controls.Add(this.age);
            this.panel3.Controls.Add(this.name);
            this.panel3.Controls.Add(this.button1);
            this.panel3.Location = new System.Drawing.Point(356, 131);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(603, 378);
            this.panel3.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 38);
            this.label2.TabIndex = 14;
            this.label2.Text = "Enter information:";
            // 
            // contact_input
            // 
            this.contact_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_input.Location = new System.Drawing.Point(179, 250);
            this.contact_input.Name = "contact_input";
            this.contact_input.Size = new System.Drawing.Size(324, 36);
            this.contact_input.TabIndex = 13;
            this.contact_input.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // address_input
            // 
            this.address_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_input.Location = new System.Drawing.Point(161, 198);
            this.address_input.Name = "address_input";
            this.address_input.Size = new System.Drawing.Size(347, 36);
            this.address_input.TabIndex = 12;
            this.address_input.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // age_input
            // 
            this.age_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_input.Location = new System.Drawing.Point(132, 147);
            this.age_input.Name = "age_input";
            this.age_input.Size = new System.Drawing.Size(118, 36);
            this.age_input.TabIndex = 11;
            this.age_input.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // name_input
            // 
            this.name_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_input.Location = new System.Drawing.Point(132, 59);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(343, 36);
            this.name_input.TabIndex = 10;
            this.name_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(17, 253);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(137, 29);
            this.contact.TabIndex = 4;
            this.contact.Text = "Contact/s:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.WhiteSmoke;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(17, 201);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(121, 29);
            this.address.TabIndex = 3;
            this.address.Text = "Address:";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.BackColor = System.Drawing.Color.WhiteSmoke;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(16, 154);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(69, 29);
            this.age.TabIndex = 2;
            this.age.Text = "Age:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(17, 62);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(93, 29);
            this.name.TabIndex = 1;
            this.name.Text = "Name:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(419, 308);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(170, 54);
            this.button1.TabIndex = 0;
            this.button1.TabStop = false;
            this.button1.Text = "ENTER";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.enter_click);
            // 
            // gender
            // 
            this.gender.AutoSize = true;
            this.gender.BackColor = System.Drawing.Color.WhiteSmoke;
            this.gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender.Location = new System.Drawing.Point(16, 109);
            this.gender.Name = "gender";
            this.gender.Size = new System.Drawing.Size(110, 29);
            this.gender.TabIndex = 15;
            this.gender.Text = "Gender:";
            // 
            // gender_input
            // 
            this.gender_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gender_input.Location = new System.Drawing.Point(149, 105);
            this.gender_input.Name = "gender_input";
            this.gender_input.Size = new System.Drawing.Size(118, 36);
            this.gender_input.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SaddleBrown;
            this.BackgroundImage = global::Ricot_Contact_Tracing.Properties.Resources._187161;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(966, 517);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Tracing App";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label contact;
        private System.Windows.Forms.Label address;
        private System.Windows.Forms.Label age;
        private System.Windows.Forms.Label name;
        private System.Windows.Forms.TextBox contact_input;
        private System.Windows.Forms.TextBox address_input;
        private System.Windows.Forms.TextBox age_input;
        private System.Windows.Forms.TextBox name_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox gender_input;
        private System.Windows.Forms.Label gender;
    }
}

