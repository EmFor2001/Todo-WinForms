using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Todo_WinForms
{
    public class TodoApiClient
    {
        private readonly HttpClient _httpClient;

        public TodoApiClient(string baseApiUrl)
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseApiUrl)
            };
        }

        public async Task<List<Todo>> GetTodosAsync()
        {
            var response = await _httpClient.GetAsync("/ToDo");
            response.EnsureSuccessStatusCode();
            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<List<Todo>>(content);
        }

        public async Task<Todo> GetTodoAsync(string todoGuid)
        {
            var response = await _httpClient.GetAsync($"/ToDo/{todoGuid}");
            response.EnsureSuccessStatusCode();

            var content = await response.Content.ReadAsStringAsync();
            return JsonConvert.DeserializeObject<Todo>(content);
        }

        public async Task DeleteTodoAsync(string todoId)
        {
            var response = await _httpClient.DeleteAsync($"/ToDo/{todoId}");
            response.EnsureSuccessStatusCode();
        }

        public async Task UpdateTodoAsync(Todo todo)
        {
            var json = JsonConvert.SerializeObject(todo);
            var content = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await _httpClient.PutAsync($"/ToDo/{todo.Guid}", content);
            response.EnsureSuccessStatusCode();
        }

        public async Task AddTodoAsync(Todo todo)
        {
            var todoJson = JsonConvert.SerializeObject(todo);
            var content = new StringContent(todoJson, Encoding.UTF8, "application/json");

            using (var response = await _httpClient.PostAsync("/ToDo", content))
            {
                response.EnsureSuccessStatusCode();
            }
        }
    }
}
