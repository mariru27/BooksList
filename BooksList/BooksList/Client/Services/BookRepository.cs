﻿using BooksList.Client.IServices;
using BooksList.Shared.Models;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;

namespace BooksList.Client.Services
{
    public class BookRepository : IBookRepository
    {
        private readonly HttpClient _httpClient;
        public BookRepository(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<Book> Books { get; set; }
        public async Task GetBooksAsync()
        {
            HttpResponseMessage response = await _httpClient.GetAsync("api/books");

            if (response.IsSuccessStatusCode)
            {
                var result = await response.Content.ReadFromJsonAsync<List<Book>>();
                Books = result.ToList();
            }
        }
        public async Task<List<Book>> GetBooksByIdsAsync(int id)
        {

            var book = await _httpClient.GetFromJsonAsync<IEnumerable<Book>>($"api/states/{id}");
            Books = book.ToList();
            return Books;

        }

    }
}
