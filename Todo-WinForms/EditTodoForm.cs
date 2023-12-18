using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_WinForms
{
    public partial class EditTodoForm : Form
    {
        private readonly TodoApiClient _todoApiClient;
        private readonly string _todoGuid;

        public EditTodoForm(string todoGuid, TodoApiClient todoApiClient)
        {
            InitializeComponent();

            _todoApiClient = todoApiClient;
            _todoGuid = todoGuid;

            // Load the existing todo data and populate the textboxes
            LoadTodoData();

            // Wire up events
            btnSave.Click += btnSave_Click;
        }

        private async void LoadTodoData()
        {
            var todo = await _todoApiClient.GetTodoAsync(_todoGuid);

            // Assuming you have textboxes named txtTitle and txtDescription
            txtTitle.Text = todo.Title;
            txtDescription.Text = todo.Description;
        }

        private async void btnSave_Click(object sender, EventArgs e)
        {
            // Save the edited todo data to the API
            var updatedTodo = new Todo
            {
                Guid = _todoGuid,
                Title = txtTitle.Text,
                Description = txtDescription.Text
                // Add other properties as needed
            };

            await _todoApiClient.UpdateTodoAsync(updatedTodo);

            // Optionally, you can close the form or perform additional actions after saving
            Close();
        }
    }
}
