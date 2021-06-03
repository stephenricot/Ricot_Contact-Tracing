
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
            this.contact_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact_input.Location = new System.Drawing.Point(219, 234);
            this.contact_input.Name = "contact_input";
            this.contact_input.Size = new System.Drawing.Size(333, 45);
            this.contact_input.TabIndex = 13;
            this.contact_input.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // address_input
            // 
            this.address_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address_input.Location = new System.Drawing.Point(205, 182);
            this.address_input.Name = "address_input";
            this.address_input.Size = new System.Drawing.Size(347, 45);
            this.address_input.TabIndex = 12;
            this.address_input.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // age_input
            // 
            this.age_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age_input.Location = new System.Drawing.Point(130, 128);
            this.age_input.Name = "age_input";
            this.age_input.Size = new System.Drawing.Size(91, 45);
            this.age_input.TabIndex = 11;
            this.age_input.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // name_input
            // 
            this.name_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name_input.Location = new System.Drawing.Point(161, 74);
            this.name_input.Name = "name_input";
            this.name_input.Size = new System.Drawing.Size(343, 45);
            this.name_input.TabIndex = 10;
            this.name_input.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // contact
            // 
            this.contact.AutoSize = true;
            this.contact.BackColor = System.Drawing.Color.WhiteSmoke;
            this.contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contact.Location = new System.Drawing.Point(15, 237);
            this.contact.Name = "contact";
            this.contact.Size = new System.Drawing.Size(175, 38);
            this.contact.TabIndex = 4;
            this.contact.Text = "Contact/s:";
            // 
            // address
            // 
            this.address.AutoSize = true;
            this.address.BackColor = System.Drawing.Color.WhiteSmoke;
            this.address.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.address.Location = new System.Drawing.Point(15, 185);
            this.address.Name = "address";
            this.address.Size = new System.Drawing.Size(155, 38);
            this.address.TabIndex = 3;
            this.address.Text = "Address:";
            // 
            // age
            // 
            this.age.AutoSize = true;
            this.age.BackColor = System.Drawing.Color.WhiteSmoke;
            this.age.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.age.Location = new System.Drawing.Point(15, 131);
            this.age.Name = "age";
            this.age.Size = new System.Drawing.Size(88, 38);
            this.age.TabIndex = 2;
            this.age.Text = "Age:";
            // 
            // name
            // 
            this.name.AutoSize = true;
            this.name.BackColor = System.Drawing.Color.WhiteSmoke;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.name.Location = new System.Drawing.Point(15, 77);
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(118, 38);
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
    }
}

