namespace Todo_WinForms
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.txtNewTodoTitle = new System.Windows.Forms.TextBox();
            this.txtNewTodoDescription = new System.Windows.Forms.TextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.btnAddNewTodo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(80, 201);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(397, 226);
            this.flowLayoutPanel1.TabIndex = 0;
            // 
            // btnRefresh
            // 
            this.btnRefresh.Location = new System.Drawing.Point(80, 172);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(75, 23);
            this.btnRefresh.TabIndex = 1;
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.UseVisualStyleBackColor = true;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // txtNewTodoTitle
            // 
            this.txtNewTodoTitle.Location = new System.Drawing.Point(80, 44);
            this.txtNewTodoTitle.Name = "txtNewTodoTitle";
            this.txtNewTodoTitle.Size = new System.Drawing.Size(397, 20);
            this.txtNewTodoTitle.TabIndex = 2;
            // 
            // txtNewTodoDescription
            // 
            this.txtNewTodoDescription.Location = new System.Drawing.Point(80, 90);
            this.txtNewTodoDescription.Name = "txtNewTodoDescription";
            this.txtNewTodoDescription.Size = new System.Drawing.Size(397, 20);
            this.txtNewTodoDescription.TabIndex = 3;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(80, 25);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(27, 13);
            this.lbl1.TabIndex = 4;
            this.lbl1.Text = "Title";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(80, 71);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(60, 13);
            this.lbl2.TabIndex = 5;
            this.lbl2.Text = "Description";
            this.lbl2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnAddNewTodo
            // 
            this.btnAddNewTodo.Location = new System.Drawing.Point(80, 117);
            this.btnAddNewTodo.Name = "btnAddNewTodo";
            this.btnAddNewTodo.Size = new System.Drawing.Size(75, 23);
            this.btnAddNewTodo.TabIndex = 6;
            this.btnAddNewTodo.Text = "Add Todo";
            this.btnAddNewTodo.UseVisualStyleBackColor = true;
            this.btnAddNewTodo.Click += new System.EventHandler(this.btnAddNewTodo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 450);
            this.Controls.Add(this.btnAddNewTodo);
            this.Controls.Add(this.lbl2);
            this.Controls.Add(this.lbl1);
            this.Controls.Add(this.txtNewTodoDescription);
            this.Controls.Add(this.txtNewTodoTitle);
            this.Controls.Add(this.btnRefresh);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.TextBox txtNewTodoTitle;
        private System.Windows.Forms.TextBox txtNewTodoDescription;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Button btnAddNewTodo;
    }
}

