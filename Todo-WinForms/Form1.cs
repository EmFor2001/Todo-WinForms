using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo_WinForms
{
    public partial class Form1 : Form
    {
        private readonly TodoApiClient _todoApiClient;

        public Form1()
        {
            InitializeComponent();

            _todoApiClient = new TodoApiClient("https://localhost:7085");

            Load += Form1_Load;
        }

        private async Task LoadData()
        {
            // Clear any existing controls in FlowLayoutPanel
            flowLayoutPanel1.Controls.Clear();

            // Fetch todos from the API
            var todos = await _todoApiClient.GetTodosAsync();

            // Create labels with delete and edit buttons for each todo
            foreach (var todo in todos)
            {
                var label = new Label
                {
                    Text = $"{todo.Title}\n{todo.Description}",
                    AutoSize = true,
                    Margin = new Padding(0, 0, 0, 10) // Add margin for spacing
                };

                var deleteButton = new Button
                {
                    Text = "Delete",
                    Tag = todo.Guid, // Assuming Guid is a string property
                    Margin = new Padding(0, 0, 0, 5) // Add margin for spacing
                };
                deleteButton.Click += DeleteButton_Click; // Attach the click event handler

                var editButton = new Button
                {
                    Text = "Edit",
                    Tag = todo.Guid, // Assuming Guid is a string property
                    Margin = new Padding(0, 0, 0, 5) // Add margin for spacing
                };
                editButton.Click += EditButton_Click; // Attach the click event handler

                // Add the label, delete button, and edit button to the FlowLayoutPanel
                flowLayoutPanel1.Controls.Add(label);
                flowLayoutPanel1.Controls.Add(deleteButton);
                flowLayoutPanel1.Controls.Add(editButton);
            }
        }

        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadData();
        }

        private async void DeleteButton_Click(object sender, EventArgs e)
        {
            if (sender is Button deleteButton && deleteButton.Tag is string todoGuid)
            {
                try
                {
                    // Debugging: Output the todoId to console
                    Console.WriteLine($"Deleting todo with Guid: {todoGuid}");

                    // Send delete request to the API
                    await _todoApiClient.DeleteTodoAsync(todoGuid);

                    // Optionally, update the UI or refresh the data
                    // Find the index of deleteButton
                    int deleteButtonIndex = flowLayoutPanel1.Controls.IndexOf(deleteButton);

                    // Check if deleteButtonIndex is within valid range
                    if (deleteButtonIndex >= 0)
                    {
                        // Remove both the deleteButton and the label at deleteButtonIndex
                        flowLayoutPanel1.Controls.RemoveAt(deleteButtonIndex);
                        if (deleteButtonIndex > 0)  // Check if index is greater than 0 to avoid ArgumentOutOfRangeException
                        {
                            flowLayoutPanel1.Controls.RemoveAt(deleteButtonIndex - 1);
                        }
                    }
                }
                catch (Exception ex)
                {
                    // Debugging: Output any exceptions to console
                    Console.WriteLine($"Exception occurred: {ex.Message}");
                }
            }
        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            if (sender is Button editButton && editButton.Tag is string todoGuid)
            {
                // Optionally, open a new form or dialog for editing the selected todo
                // You can pass the todoGuid to the editing form
                var editForm = new EditTodoForm(todoGuid, _todoApiClient);
                editForm.ShowDialog();

                // After editing, you might want to refresh the data or update the UI
                // For example, you can re-fetch todos and update the labels in the FlowLayoutPanel
            }
        }

        private async void btnRefresh_Click(object sender, EventArgs e)
        {
            await LoadData();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private async void btnAddNewTodo_Click(object sender, EventArgs e)
        {
            // Create a new todo with user-entered data
            var newTodo = new Todo
            {
                Title = txtNewTodoTitle.Text,
                Description = txtNewTodoDescription.Text
                // Add other properties as needed
            };

            // Add the new todo to the API
            await _todoApiClient.AddTodoAsync(newTodo);

            // Reload data after adding the new todo
            await LoadData();
        }
    }
}
